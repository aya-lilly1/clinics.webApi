using Clinic_DbModel.Models;
using Clinic_ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Core.Managers.Interfaces
{
    public interface IScheduletimingManager
    {
        ScheduletimingModelView AddScheduletiming(int DoctorId, ScheduletimingModelView scheduletiming);
        List<Scheduletiming> GetScheduletimingForDoctor(int DoctorId);
    }
}
