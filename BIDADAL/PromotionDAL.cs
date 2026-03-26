using BIDADTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIDADAL
{
    public class PromotionDAL
    {
        private static PromotionDAL instance;
        public static PromotionDAL Instance
        {
            get { if (instance == null) instance = new PromotionDAL(); return instance; }
            private set { instance = value; }
        }
        private PromotionDAL() { }

        public List<PromotionDTO> GetActivePromotions()
        {
            List<PromotionDTO> list = new List<PromotionDTO>();
            string query = "SELECT * FROM PROMOTION WHERE STATUS = 1";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new PromotionDTO(row));
            }
            return list;
        }

        public bool InsertPromotion(string name, int type, double value, int? foodId, int requiredQty)
        {
            string query = "EXEC USP_InsertPromotion @Name , @Type , @Value , @ApplyFoodID , @ReqQty";

            object foodIdParam = foodId.HasValue ? (object)foodId.Value : DBNull.Value;

            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { name, type, value, foodIdParam, requiredQty }) > 0;
        }

        public bool UpdatePromotion(int id, string name, int type, double value, int? foodId, int requiredQty)
        {
            string query = "EXEC USP_UpdatePromotion @ID , @Name , @Type , @Value , @ApplyFoodID , @ReqQty";
            object foodIdParam = foodId.HasValue ? (object)foodId.Value : DBNull.Value;

            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { id, name, type, value, foodIdParam, requiredQty }) > 0;
        }

        public bool DeletePromotion(int id)
        {
            string query = "EXEC USP_DeletePromotion @ID";
            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { id }) > 0;
        }
    }
}
