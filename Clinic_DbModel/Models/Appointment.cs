using System;
using System.Collections.Generic;

#nullable disable

namespace Clinic_DbModel.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Date { get; set; }
        public string Day { get; set; }
        public DateTime Time { get; set; }
        public byte? IsDeleted { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
