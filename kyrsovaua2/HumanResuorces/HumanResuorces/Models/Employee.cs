using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResuorces.Models
{
    public class Employee
    {
        public string Passport { get; set; }
        public string Name { get; set; }
        public string Ededucation { get; set; }
        public string Specialty { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public DateTime DOE { get; set; } // Date of Employment
        public DateTime DLA { get; set; } // Date of Last Appointment
        public DateTime BirthDate { get; set; } // Date of Birth


    }
}
