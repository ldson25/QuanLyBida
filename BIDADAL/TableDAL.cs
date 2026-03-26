using BIDADTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BIDADAL
{
    public class TableDAL
    {
        private static TableDAL instance;

        public static TableDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private TableDAL() { }

        public List<TableDTO> GetTableList(int? typeId = null)
        {
            List<TableDTO> list = new List<TableDTO>();

            string query = @"
                SELECT  T.IDTABLE,
                        T.NAME,
                        T.STATUS,
                        T.KHUVUC,  
                        ISNULL(T.IDTYPE, 0) AS IDTYPE,
                        ISNULL(TT.TYPENAME, N'Không rõ') AS TYPENAME,
                        B.DATECHECKIN 
                FROM TABLEFOOD T
                LEFT JOIN BILLIARD_TABLE_TYPE TT ON T.IDTYPE = TT.IDTYPE
                LEFT JOIN BILL B ON T.IDTABLE = B.IDTABLE AND B.STATUS = 0";

            object[] parameters = null;

            if (typeId.HasValue)
            {
                query += " WHERE T.IDTYPE = @typeId";
                parameters = new object[] { typeId.Value };
            }

            DataTable data = DataProvider.Instance.ExcuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                int idTable = Convert.ToInt32(row["IDTABLE"]);
                string name = row["NAME"].ToString();
                int idType = (row["IDTYPE"] == DBNull.Value) ? 0 : Convert.ToInt32(row["IDTYPE"]);
                string typeName = row["TYPENAME"].ToString();
                string status = row["STATUS"].ToString();

                string khuVuc = row["KHUVUC"] != DBNull.Value ? row["KHUVUC"].ToString() : "Tầng 1";

                DateTime? startTime = null;
                if (row["DATECHECKIN"] != DBNull.Value)
                {
                    startTime = Convert.ToDateTime(row["DATECHECKIN"]);
                }

                TableDTO t = new TableDTO(idTable, name, idType, typeName, status, khuVuc, startTime);

                list.Add(t);
            }

            return list;
        }
        public void ChuyenBan(int idCu, int idMoi)
        {
            DataProvider.Instance.ExcuteNonQuery("USP_ChuyenBan @idTableCu , @idTableMoi", new object[] { idCu, idMoi });
        }
        public bool AddTable(string name, int type, string khuVuc)
        {
            string query = "INSERT INTO TABLEFOOD (NAME, IDTYPE, STATUS, KHUVUC) VALUES ( @name , @type , N'Trống', @khuVuc )";
            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { name, type, khuVuc }) > 0;
        }
        public DataTable GetTableTypes()
        {
            return DataProvider.Instance.ExcuteQuery("SELECT * FROM BILLIARD_TABLE_TYPE");
        }
        public bool UpdateTableStatus(int idTable, string status)
        {
            string query = string.Format("UPDATE TABLEFOOD SET STATUS = N'{0}' WHERE IDTABLE = {1}", status, idTable);
            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }
        public int DeleteTable(int idTable)
        {
            string query = "EXEC USP_DeleteTable @idTable";
            object result = DataProvider.Instance.ExcuteScalar(query, new object[] { idTable });
            return Convert.ToInt32(result);
        }
        public bool UpdatePrice(int idType, decimal newPrice)
        {
            string query = "EXEC USP_UpdateTablePrice @id , @price";
            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { idType, newPrice }) > 0;
        }

        public decimal GetPricePerHour(int typeId)
        {
            string query = "SELECT PRICE_PER_HOUR FROM BILLIARD_TABLE_TYPE WHERE IDTYPE = @id";
            object result = DataProvider.Instance.ExcuteScalar(query, new object[] { typeId });

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToDecimal(result);
            }
            return 0;
        }
    }
}