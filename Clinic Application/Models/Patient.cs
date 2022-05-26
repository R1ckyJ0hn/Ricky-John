using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClinicDeskApplication.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        [Required]
        [RegularExpression("^[A-Za-z0-9]*$", ErrorMessage = " must not have special characters")]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression("^[A-Za-z0-9]*$", ErrorMessage = " must not have special characters")]
        public string LastName { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string DateofBirth { get; set; }
    }
}
