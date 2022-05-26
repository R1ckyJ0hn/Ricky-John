using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClinicDeskApplication.Models
{
    public class Doctor
    {

        
        public int DoctorID { get; set; }
        [RegularExpression("^[A-Za-z0-9]*$", ErrorMessage = " must not have special characters")]
        public string FirstName { get; set; }
        [RegularExpression("^[A-Za-z0-9]*$", ErrorMessage = " must not have special characters")]
        public string LastName { get; set; }
        public string  Sex { get; set; }
        public string  Specialization { get; set; }

        public string VisitingHours { get; set; }
    }
}
