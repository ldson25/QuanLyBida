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
    public class BillDAL
    {
        private static BillDAL instance;
        public static BillDAL Instance
        {
            get
            {
                if (instance == null) instance = new BillDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private BillDAL() { }

        public int GetUnCheckBillIdByTable(int idTable)
        {
            string query = "SELECT * FROM BILL WHERE IDTABLE = @id AND STATUS = 0";

            DataTable data = DataProvider.Instance.ExcuteQuery(
                query,
                new object[] { idTable }
            );

            if (data.Rows.Count > 0)
                return (int)data.Rows[0]["IDBILL"];

            return -1;
        }

        public void InsertBill(int idTable)
        {
            DataProvider.Instance.ExcuteNonQuery(
                "usp_INSERTBILL @IDTABLE",
                new object[] { idTable }
            );
        }
        public void CheckOut(int idBill, int discount, double totalPrice)
        {
            string query = @"UPDATE BILL 
                             SET DATECHECKOUT = GETDATE(),
                                 STATUS = 1,
                                 DISCOUNT = @discount,
                                 TOTALPRICE = @totalPrice
                             WHERE IDBILL = @idBill";

            DataProvider.Instance.ExcuteNonQuery(
                query,
                new object[] { discount, totalPrice, idBill }
            );
        }
        public DataTable GetUnpaidBillDetailsByTableId(int idTable)
        {
            string query = "EXEC dbo.GetBillDetailsByTableId @TableId";

            return DataProvider.Instance.ExcuteQuery(query, new object[] { idTable });
        }
        public int Checkout(
            int idTable,
            decimal tableFee,
            decimal foodFee,
            int discount, 
            decimal surcharge,
            decimal totalAmount)
        {
            string query = "EXEC USP_CheckoutBill @IDTABLE , @TABLEFEE , @FOODFEE , @DISCOUNT , @SURCHARGE , @TOTALAMOUNT";

    
            object result = DataProvider.Instance.ExcuteScalar(
                query,
                new object[] { idTable, tableFee, foodFee, discount, surcharge, totalAmount }
            );

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            return -1;
        }
        public DataTable GetReceiptData(int idBill)
        {
            string query = "EXEC USP_GetReceiptData @IDBill";
            return DataProvider.Instance.ExcuteQuery(query, new object[] { idBill });
        }
        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExcuteQuery("EXEC USP_GETLISTBILLBYDATE @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
        public DataTable GetMonthlyRevenue(int year)
        {
            string query = @"
        SELECT MONTH(DateCheckOut) AS Thang, SUM(TotalAmount) AS TongTien
        FROM BILL
        WHERE STATUS = 1 AND YEAR(DateCheckOut) = @Year
        GROUP BY MONTH(DateCheckOut)
        ORDER BY Thang";

            return DataProvider.Instance.ExcuteQuery(query, new object[] { year });
        }
    }
}
