using AutoMapper;
using Clinic.Helper;
using Clinic_Common.Extinsions;
using clinic_Core.Managers.Interfaces;
using Clinic_Core.Managers.Interfaces;
using Clinic_Core.Managers.Services;
using Clinic_Core.Mapper;
using Clinic_DbModel.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Startup
    {
        private MapperConfiguration _mapperConfiguration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            _mapperConfiguration = new MapperConfiguration(a => {
                a.AddProfile(new Mapping());
            });
        }
        
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<clinic_dbContext>(op =>
                op.UseMySQL(Configuration.GetConnectionString("Default"))
                );
            services.AddOptions();
            services.Configure<JWT>(Configuration.GetSection("JWTOken"));
            services.AddIdentity<ApplicationUser, IdentityRole>()
             .AddDefaultTokenProviders()
             .AddEntityFrameworkStores<clinic_dbContext>();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = false;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration.GetValue<string>("JWTOken:Issuer"),
                    ValidAudience = Configuration.GetValue<string>("JWTOken:Audience"),
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration.GetValue<string>("JWTOken:Key")))
                };
            });
         
            services.AddControllers();
            services.AddHttpContextAccessor();
            services.AddSingleton(sp => _mapperConfiguration.CreateMapper());
            services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();
            services.AddScoped<IPatientManager, PatientManager>();
            services.AddScoped<IDoctorManager, DoctorManager>();
            services.AddScoped<ISpecializationManager, SpecializationManager>(); 
            services.AddScoped<IScheduletimingManager, ScheduletimingManager>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Clinic", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Clinic v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
