using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_ModelView
{
    public class BlogModelView
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Image { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
