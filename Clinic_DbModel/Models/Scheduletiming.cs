using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Clinic_DbModel.Models
{
    public  class Scheduletiming
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int DurationTime { get; set; }
        public string Day { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        [NotMapped]
        public string StTime { get { return StartTime.ToString("hh:mm tt"); } }

        [NotMapped]
        public string EnTime { get { return EndTime.ToString("hh:mm tt"); } }


        public virtual Doctor Doctor { get; set; }
    }
}
