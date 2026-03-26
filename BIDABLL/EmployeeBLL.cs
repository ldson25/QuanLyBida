using BIDADAL;
using BIDADTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIDABLL
{
    public class EmployeeBLL
    {
        private static EmployeeBLL instance;
        public static EmployeeBLL Instance
        {
            get
            {
                if (instance == null) instance = new EmployeeBLL();
                return instance;
            }
        }

        public List<EmployeeDTO> GetAll() => EmployeeDAL.Instance.GetAll();

        public bool Insert(EmployeeDTO e) => EmployeeDAL.Instance.Insert(e);

        public bool Update(EmployeeDTO e) => EmployeeDAL.Instance.Update(e);

        public bool Delete(int id) => EmployeeDAL.Instance.Delete(id);
    }

}
