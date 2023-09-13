using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Clinic_DbModel.Models
{ 
    public  class Blog
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte? IsDeleted { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}
