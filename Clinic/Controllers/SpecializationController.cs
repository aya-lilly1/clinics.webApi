using Clinic_Core.Managers.Interfaces;
using Clinic_ModelView;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Clinic.Controllers
{
   
    [ApiController]
    public class SpecializationController : ControllerBase
    {
        private ISpecializationManager _specializationManager;
        private readonly ILogger<SpecializationController> _logger;
        public SpecializationController(ILogger<SpecializationController> logger,
                              ISpecializationManager specializationManager)
        {
            _logger = logger;
            _specializationManager = specializationManager;
        }

        [Route("api/specialties/GetAllSpecialties")]
        [HttpGet]
        public IActionResult GetAllSpecialties()
        {
            var result = _specializationManager.GetAllSpecialties();
            return Ok(result);

        }

        [Route("api/specialties/GetSpecialtiesBySpecificNum")]
        [HttpGet]
        public IActionResult GetSpecialtiesBySpecificNum(int NumberOfSpecialties)
        {
            var result = _specializationManager.GetSpecialtiesBySpecificNum(NumberOfSpecialties);
            return Ok(result);

        }

        [Route("api/specialties/CreateSpecialty")]
        [HttpPost]
         public IActionResult CreateSpecialty([FromBody] SpectalizationModelView specialtyMV)
        {
            var result = _specializationManager.CreateSpecialty(specialtyMV);
            return Ok(result);
        }

        
        [Route("api/specialties/UpdateSpecialty/{id}")]
        [HttpPut]
        public IActionResult UpdateSpecialty([FromBody] SpectalizationModelView currentSpecialty)
        {
            var result = _specializationManager.UpdateSpecialty(currentSpecialty);
            return Ok(result);
        }

        [Route("api/specialties/DeleteSpecialty/{id}")]
        [HttpDelete]
        public IActionResult DeleteSpecialty(SpectalizationModelView specialtyMV)
        {
            var result = _specializationManager.DeleteSpecialty(specialtyMV);
            return Ok(result);

        }
    }



}

