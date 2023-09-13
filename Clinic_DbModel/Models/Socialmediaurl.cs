using System;
using System.Collections.Generic;

#nullable disable

namespace Clinic_DbModel.Models
{
    public  class Socialmediaurl
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string WebsiteUrl { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}
