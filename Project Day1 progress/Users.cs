using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicDeskApplication.Models
{
    public class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set;}
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string Password { get; set; }
    }
}
