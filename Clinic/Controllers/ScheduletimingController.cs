using Clinic_Core.Managers.Interfaces;
using Clinic_DbModel.Models;
using Clinic_ModelView;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.Controllers
{
    [ApiController]
    [Authorize]
    public class ScheduletimingController : BaseController
    {
        private IScheduletimingManager _scheduletimingManager;
        private readonly IHttpContextAccessor __httpContextAccessor;
        public ScheduletimingController(IScheduletimingManager scheduletimingManager, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            _scheduletimingManager = scheduletimingManager;
            __httpContextAccessor = httpContextAccessor;
        }
        [Route("api/scheduletiming/addscheduletiming")]
        [HttpPost]
        public IActionResult AddScheduletiming(int doctorId, ScheduletimingModelView scheduletiming)
        {
            doctorId = 1;
            var time = _scheduletimingManager.AddScheduletiming(doctorId, scheduletiming);
            return Ok(time);
        }

        [Route("api/scheduletiming/getscheduletimingfordoctor")]
        [HttpGet]
        public IActionResult GetScheduletimingForDoctor(int doctorId)
        {
            var d = _DoctorId;
            var result = _scheduletimingManager.GetScheduletimingForDoctor(doctorId);
            return Ok(result);
        }
    }
}
