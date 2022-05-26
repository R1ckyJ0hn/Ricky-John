using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClinicDeskApplication.Models
{
    public class Schedules
    {
        public int AppointmentID { get; set; }
        [Required]
        public string Specializations { get; set; }
        [Required]
        public string DoctorName { get; set; }
        [Required]
        public string patientName { get; set; }
        [Required]
        public string VisitDate { get; set; }
        [Required]
        public string  AppointmentTime { get; set; }
    }
}
