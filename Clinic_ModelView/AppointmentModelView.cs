using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_ModelView
{
    public class AppointmentModelView
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Date { get; set; }
        public string Day { get; set; }
        [Timestamp]
        public DateTime Time { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
