using BIDADTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIDADAL
{
    public class EmployeeDAL
    {
        private static EmployeeDAL instance;
        public static EmployeeDAL Instance
        {
            get
            {
                if (instance == null) instance = new EmployeeDAL();
                return instance;
            }
        }

        private EmployeeDAL() { }

        public List<EmployeeDTO> GetAll()
        {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM EMPLOYEES");

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new EmployeeDTO
                {
                    EmployeeID = Convert.ToInt32(row["EMPLOYEEID"]),
                    FullName = row["FULLNAME"].ToString(),
                    Gender = row["GENDER"].ToString(),
                    Phone = row["PHONE"].ToString(),
                    Email = row["EMAIL"].ToString(),
                    Images = row["IMAGES"].ToString(),
                    PositionID = Convert.ToInt32(row["POSITIONID"]),
                    ScheduleID = Convert.ToInt32(row["SCHEDULEID"]),
                    CoefficientSalary = float.Parse(row["COEFFICIENTSSALARY"].ToString()),
                    DaysOff = Convert.ToInt32(row["NUMBEROFDAYSOFFOFANEMPLOYEE"]),
                    YearStarted = Convert.ToDateTime(row["YEAR_STARTED"]),
                    Identification = row["IDENTIFICATION"].ToString(),
                    IssuingAuthority = row["ISSUING_AUTHORITY"].ToString()
                });
            }
            return list;
        }

        public bool Insert(EmployeeDTO emp)
        {
            string query =
                "EXEC usp_InsertEmployees " +
                "@FULLNAME , @GENDER , @PHONE , @EMAIL , @IMAGES , " +
                "@POSITIONID , @SCHEDULEID , @COEFFICIENTSSALARY , " +
                "@NUMBEROFDAYSOFFOFANEMPLOYEE , @YEAR_STARTED , " +
                "@IDENTIFICATION , @ISSUING_AUTHORITY";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[]
            {
        emp.FullName,
        emp.Gender,
        emp.Phone,
        emp.Email,
        emp.Images,
        emp.PositionID,
        emp.ScheduleID,
        emp.CoefficientSalary,
        emp.DaysOff,
        emp.YearStarted,      
        emp.Identification,   
        emp.IssuingAuthority  
            });

            return result > 0;
        }

        public bool Update(EmployeeDTO emp)
        {
            string query =
                "EXEC usp_UpdateEmployees " +
                "@EMPLOYEEID , @FULLNAME , @GENDER , @PHONE , @EMAIL , @IMAGES , " +
                "@POSITIONID , @SCHEDULEID , @COEFFICIENTSSALARY , " +
                "@NUMBEROFDAYSOFFOFANEMPLOYEE , @YEAR_STARTED , " +
                "@IDENTIFICATION , @ISSUING_AUTHORITY";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[]
            {
        emp.EmployeeID,
        emp.FullName,
        emp.Gender,
        emp.Phone,
        emp.Email,
        emp.Images,
        emp.PositionID,
        emp.ScheduleID,
        emp.CoefficientSalary,
        emp.DaysOff,
        emp.YearStarted,
        emp.Identification,
        emp.IssuingAuthority
            });

            return result > 0;
        }

        public bool Delete(int id)
        {
            string query = "EXEC usp_DeleteEmployees @EMPLOYEEID";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { id });
            return result > 0;
        }
    }
}
