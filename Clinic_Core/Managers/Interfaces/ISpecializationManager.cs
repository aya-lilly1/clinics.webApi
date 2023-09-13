using Clinic_DbModel.Models;
using Clinic_ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Core.Managers.Interfaces
{
    public interface ISpecializationManager
    {
        List<Specialization> GetAllSpecialties();
        SpectalizationModelView CreateSpecialty(SpectalizationModelView specialtyMV);
        SpectalizationModelView UpdateSpecialty(SpectalizationModelView currentSpecialty);
        SpectalizationModelView DeleteSpecialty(SpectalizationModelView currentSpecialty);
        List<Specialization> GetSpecialtiesBySpecificNum(int NumberOfSpecialties);

    }
}
