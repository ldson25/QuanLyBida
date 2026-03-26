using BIDADAL;
using BIDADTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIDABLL
{
    public class PromotionBLL
    {
        private static PromotionBLL instance;
        public static PromotionBLL Instance
        {
            get { if (instance == null) instance = new PromotionBLL(); return instance; }
            private set { instance = value; }
        }
        private PromotionBLL() { }

        public List<PromotionDTO> GetActivePromotions()
        {
            return PromotionDAL.Instance.GetActivePromotions();
        }

        public bool InsertPromotion(string name, int type, double value, int? foodId, int requiredQty)
        {
            return PromotionDAL.Instance.InsertPromotion(name, type, value, foodId, requiredQty);
        }

        public bool UpdatePromotion(int id, string name, int type, double value, int? foodId, int requiredQty)
        {
            return PromotionDAL.Instance.UpdatePromotion(id, name, type, value, foodId, requiredQty);
        }

        public bool DeletePromotion(int id)
        {
            return PromotionDAL.Instance.DeletePromotion(id);
        }
    }
}
