using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicDeskApplication.Models
{
    public class Schedules
    {
        public int PatientID { get; set; }
        public string Specializations { get; set; }
        public string DoctorName { get; set; }
        public string VisitDate { get; set; }
        public string  AppointmentTime { get; set; }
    }
}
