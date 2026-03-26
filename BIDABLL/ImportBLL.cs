using BIDADAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIDABLL
{
    public class ImportBLL
    {
        private static ImportBLL instance;
        public static ImportBLL Instance
        {
            get { if (instance == null) instance = new ImportBLL(); return instance; }
            private set { instance = value; }
        }
        private ImportBLL() { }

        public int CreateImportBill(decimal total, string note)
        {
            return ImportDAL.Instance.InsertImportBill(total, note);
        }

        public bool AddImportDetail(int idBill, int idFood, int quantity, decimal price)
        {
            return ImportDAL.Instance.InsertImportInfo(idBill, idFood, quantity, price);
        }
    }
}
