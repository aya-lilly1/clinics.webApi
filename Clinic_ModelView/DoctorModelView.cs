using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_ModelView
{
    public class DoctorModelView
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        [Timestamp]
        public DateTime? DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string AboutMe { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string DoctorSpecialization { get; set; }
        public string DoctorServices { get; set; }
        public string DoctorImage { get; set; }
        public string Degree { get; set; }
        public string College { get; set; }
        public string YearOfCompletion { get; set; }
        public int SpecialtyId { get; set; }
        public int ClinicId { get; set; }
    }
}
