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
    public class TableBLL
    {
        private static TableBLL instance;
        public static TableBLL Instance
        {
            get
            {
                if (instance == null) instance = new TableBLL();
                return instance;
            }
            private set { instance = value; }
        }
        public TableBLL()
        {
        }

        public List<TableDTO> GetAllTables()
        {
            return TableDAL.Instance.GetTableList();
        }
        public void SwitchTable(int id1, int id2)
        {
            if (id1 == id2) return;

            TableDAL.Instance.ChuyenBan(id1, id2);
        }
        public decimal GetPricePerHour(int typeId)
        {
            return TableDAL.Instance.GetPricePerHour(typeId);
        }
        public bool AddTable(string name, int type, string khuVuc)
        {
            return TableDAL.Instance.AddTable(name, type, khuVuc);
        }
        public DataTable GetTableTypes()
        {
            return TableDAL.Instance.GetTableTypes();
        }
        public int DeleteTable(int idTable)
        {
            return TableDAL.Instance.DeleteTable(idTable);
        }
        public bool UpdateTableStatus(int idTable, string status)
        {
            return TableDAL.Instance.UpdateTableStatus(idTable, status);
        }
        public bool UpdatePrice(int idType, decimal newPrice)
        {
            return TableDAL.Instance.UpdatePrice(idType, newPrice);
        }

        public decimal CalculateTableFee(TimeSpan duration, int typeId)
        {
            decimal pricePerHour = GetPricePerHour(typeId);
            if (pricePerHour == 0) return 0;

            double totalMinutes = duration.TotalMinutes;

            decimal rawFee = (decimal)(totalMinutes / 60.0) * pricePerHour;

            return Math.Ceiling(rawFee / 1000) * 1000;
        }
    }
}

