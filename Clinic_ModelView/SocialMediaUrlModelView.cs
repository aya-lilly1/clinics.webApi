using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_ModelView
{
    public class SocialMediaUrlModelView
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string WebsiteUrl { get; set; }
    }
}
