using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIDADTO
{
    public class EmployeeDTO
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Images { get; set; }
        public int PositionID { get; set; }
        public int ScheduleID { get; set; }
        public float CoefficientSalary { get; set; }
        public int DaysOff { get; set; }
        public DateTime YearStarted { get; set; }
        public string Identification { get; set; }
        public string IssuingAuthority { get; set; }
    }
}
