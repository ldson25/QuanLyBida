using BIDADAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BIDABLL
{
    public class BillInfoBLL
    {
        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            BillInfoDAL.Instance.AddBillInfo(idBill, idFood, count);
        }

        public DataTable GetBillDetailsByTable(int idTable)
        {
            return BillInfoDAL.Instance.GetBillDetails(idTable);
        }
    }
}
