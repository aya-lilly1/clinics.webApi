using Clinic_DbModel.Models;
using Clinic_ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic_Core.Managers.Interfaces
{
    public interface IDoctorManager
    {
        Task<LoginPatientResponse> SignUp(DoctorRegistrationModelView DoctorReg);
        Task<LoginDoctorResponse> SignIn(PatientLoginModelView DoctorLogin);
        List<ApplicationUser> GetAllPatients();
        List<Doctor> GetTopDoctors();
        List<Doctor> GetTopDoctorsBySpecificNumber(int Number);

    }
}
