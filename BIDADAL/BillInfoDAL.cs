using BIDADAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIDADTO;

namespace BIDADAL
{
public class BillInfoDAL
    {
        private static BillInfoDAL instance;

        public static BillInfoDAL Instance
        {
            get
            {
                if (instance == null) instance = new BillInfoDAL();
                return instance;
            }
        }

        private BillInfoDAL() { }

        public void AddBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExcuteNonQuery(
                "usp_INSERTBILLINFO @IDBILL , @IDFOOD , @COUNT",
                new object[] { idBill, idFood, count }
            );
        }

        public DataTable GetBillDetails(int idTable)
        {
            return DataProvider.Instance.ExcuteQuery(
                "GetBillDetailsByTableId @TableId",
                new object[] { idTable }
            );
        }
        public void UpdateBillInfoCount(int idBill, int idFood, int count)
        {

            DataProvider.Instance.ExcuteNonQuery("USP_UpdateBillInfoCount @idBill , @idFood , @count", 
                new object[] { idBill, idFood, count }
                );
        }

        public int GetOpenBillId(int idTable)
        {
            object result = DataProvider.Instance.ExcuteScalar(
                "SELECT IDBILL FROM BILL WHERE IDTABLE = @id AND STATUS = 0",
                new object[] { idTable }
            );

            if (result == null || result == DBNull.Value)
                return -1;

            return Convert.ToInt32(result);
        }

    }
}
