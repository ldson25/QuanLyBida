using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIDADAL
{
    public class ImportDAL
    {
        private static ImportDAL instance;
        public static ImportDAL Instance
        {
            get { if (instance == null) instance = new ImportDAL(); return instance; }
            private set { instance = value; }
        }
        private ImportDAL() { }

        public int InsertImportBill(decimal totalPrice, string note)
        {
            string query = "EXEC USP_InsertImportBill @total , @note";
            try
            {
                object result = DataProvider.Instance.ExcuteScalar(query, new object[] { totalPrice, note });
                return Convert.ToInt32(result);
            }
            catch
            {
                return -1;
            }
        }

        public bool InsertImportInfo(int idBill, int idFood, int quantity, decimal inputPrice)
        {
            string query = "EXEC USP_InsertImportInfo @idBill , @idFood , @count , @price";
            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { idBill, idFood, quantity, inputPrice }) > 0;
        }
    }
}
