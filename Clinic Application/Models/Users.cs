using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClinicDeskApplication.Models
{
    public class Users
    {
        [Required(ErrorMessage ="Please Enter your username")]
        [RegularExpression("^[A-Za-z0-9]*$", ErrorMessage = " must not have special charecters")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter your Password")]
        public string Password { get; set; }
    }
}
