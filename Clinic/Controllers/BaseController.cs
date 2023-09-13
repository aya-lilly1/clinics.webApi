using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Clinic.Controllers
{
    public class BaseController : ControllerBase

    {
        public readonly string _DoctorId;
        public readonly IHttpContextAccessor _httpContextAccessor;
        public BaseController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _DoctorId = _httpContextAccessor.HttpContext.User.FindFirst("DoctorId")?.Value ;

        }
    }
}
