using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_ModelView
{
    public class LoginPatientResponse
    {
        public string Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }

        public string Email { get; set; }

        public string Token { get; set; }
        public bool IsValid { get; set; }
        public string Message { get; set; }
        //public string Username { get; set; }
    }
}
