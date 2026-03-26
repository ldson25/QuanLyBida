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
    public class BillBLL
    {
        private static BillBLL instance;

        public static BillBLL Instance
        {
            get
            {
                if (instance == null) instance = new BillBLL();
                return instance;
            }
            private set { instance = value; }
        }

        private BillBLL() { }
        public int GetUnCheckBillIdByTable(int idTable)
        {
            return BillDAL.Instance.GetUnCheckBillIdByTable(idTable);
        }

        public void InsertBill(int idTable)
        {
            BillDAL.Instance.InsertBill(idTable);
        }

        public void CheckOut(int idBill, int discount, double totalPrice)
        {
            BillDAL.Instance.CheckOut(idBill, discount, totalPrice);
        }
        public DataTable GetReceiptData(int idBill)
        {
            string query = "EXEC USP_GetReceiptData @IDBill";
            return DataProvider.Instance.ExcuteQuery(query, new object[] { idBill });
        }
        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return BillDAL.Instance.GetBillListByDate(checkIn, checkOut);
        }
        public (List<BillDetailsDTO>, decimal) GetFoodDetailsAndTotal(int idTable)
        {
            List<BillDetailsDTO> details = new List<BillDetailsDTO>();
            decimal foodTotal = 0;

            DataTable data = BillDAL.Instance.GetUnpaidBillDetailsByTableId(idTable);

            foreach (DataRow row in data.Rows)
            {
                BillDetailsDTO item = new BillDetailsDTO
                {
                    IDFOOD = Convert.ToInt32(row["IDFOOD"]),

                    FoodName = row["NAME"].ToString(),
                    Quantity = Convert.ToInt32(row["COUNT"]),
                    Price = Convert.ToDecimal(row["PRICE"]),
                    Total = Convert.ToDecimal(row["TOTALPRICE"])
                };

                foodTotal += item.Total;
                details.Add(item);
            }
            return (details, foodTotal);
        }

        public int Checkout(int idTable, decimal tableFee, decimal foodFee, int discount, decimal surcharge, decimal totalAmount)
        {
            return BillDAL.Instance.Checkout(idTable, tableFee, foodFee, discount, surcharge, totalAmount);
        }
        public DataTable GetMonthlyRevenue(int year)
        {
            return BillDAL.Instance.GetMonthlyRevenue(year);
        }
    }
}
