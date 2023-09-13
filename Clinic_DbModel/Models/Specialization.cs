using System;
using System.Collections.Generic;

#nullable disable

namespace Clinic_DbModel.Models
{
    public  class Specialization
    {
        public Specialization()
        {
            Doctors = new HashSet<Doctor>();
        }

        public int Id { get; set; }
        public string SpecialtyName { get; set; }
        public bool IsDelete { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
