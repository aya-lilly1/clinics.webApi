using Clinic.Helper;
using Clinic_Common.Extensions;
using Clinic_ModelView;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Extensions.Options;

namespace Clinic.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly JWT _jwt;
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,IOptions<JWT> jwt)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwt = jwt.Value;
        }
        [Route("LoginUser")]
        [HttpPost]
        public async Task<IActionResult> Login(PatientLoginModelView DoctorLogin) => Ok(await GetTokenAsync(DoctorLogin));

        [Route("RegisterUser")]
        [HttpPost]
        //public async Task<IActionResult> Register(PatientLoginModelView DoctorLogin) => Ok(await RegisterUser(DoctorLogin));

        //private async Task<LoginPatientResponse> RegisterUser(PatientLoginModelView model)
        //{
        //    if (await _userManager.FindByEmailAsync(model.Email) is not null)
        //        return new LoginPatientResponse { Message = "Email is already registered!" };

        //    if (await _userManager.FindByNameAsync(model.Username) is not null)
        //        return new LoginPatientResponse { Message = "Username is already registered!" };

        //    var user = new IdentityUser
        //    {
        //        UserName = model.Username,
        //        Email = model.Email,

        //    };

        //    var result = await _userManager.CreateAsync(user, model.Password);

        //    if (!result.Succeeded)
        //    {
        //        var errors = string.Empty;

        //        foreach (var error in result.Errors)
        //            errors += $"{error.Description},";

        //        return new LoginPatientResponse { Message = errors };
        //    }

        //    await _userManager.AddToRoleAsync(user, "User");

        //    var jwtSecurityToken = await CreateJwtToken(user);

        //    return new LoginPatientResponse
        //    {
        //        Email = user.Email,
        //        IsValid = true,
        //        Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
        //        Message = "Login Successfully"
        //    };
        //}
        private async Task<LoginPatientResponse> GetTokenAsync(PatientLoginModelView model)
        {
            try
            {
                LoginPatientResponse authModel = new();

                // var user = await _userManager.FindByEmailAsync(model.usernameOrEmail);
                var user = await _userManager.FindByEmailAsync(model.Email);
                var result = await _userManager.CheckPasswordAsync(user, model.Password);
                if (user is null || !result)
                {
                    authModel.Message = "Email or Password is incorrect!";
                    return authModel;
                }

                var jwtSecurityToken = await CreateJwtToken(user);
                //var rolesList = await _userManager.GetRolesAsync(user);

                authModel.IsValid = true;
                authModel.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
                authModel.Email = user.Email;
                //authModel.Roles = rolesList.ToList();
                return authModel;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return null;
            }
        }

 
        private async Task<JwtSecurityToken> CreateJwtToken(IdentityUser user)
        {

            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);
            var Centerclaims = new List<Claim>
                            {
                            new System.Security.Claims.Claim("Email",user.Email),
                            };

            var roleClaims = new List<Claim>();

            foreach (var role in roles)
                roleClaims.Add(new Claim("roles", role));


            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id)
            }

            .Union(userClaims)
            .Union(roleClaims)
            .Union(Centerclaims);


            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwt.Issuer,
                audience: _jwt.Audience,
                claims: claims,
                expires: DateTime.Now.AddDays(_jwt.DurationInDays),
                signingCredentials: signingCredentials);

            return jwtSecurityToken;



        }
    }
}
