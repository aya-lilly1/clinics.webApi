using System;
using System.Collections.Generic;

#nullable disable

namespace Clinic_DbModel.Models
{
    public  class Review
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int DoctorId { get; set; }
        public string Comment { get; set; }
        public virtual Doctor Doctors { get; set; }


        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
