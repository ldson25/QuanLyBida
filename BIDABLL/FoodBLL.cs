using BIDADTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIDADAL;
namespace BIDABLL
{
    public class FoodBLL
    {
        private static FoodBLL instance;
        public static FoodBLL Instance
        {
            get
            {
                if (instance == null) instance = new FoodBLL();
                return instance;
            }
        }

        public List<FoodDTO> GetAllFood()
        {
            return FoodDAL.Instance.GetAllFood();
        }

        public bool InsertFood(FoodDTO food)
        {
            return FoodDAL.Instance.InsertFood(food) > 0;
        }

        public bool UpdateFood(FoodDTO food)
        {
            return FoodDAL.Instance.UpdateFood(food) > 0;
        }

        public bool DeleteFood(int id)
        {
            return FoodDAL.Instance.DeleteFood(id) > 0;
        }
        public List<FoodDTO> GetInventoryList()
        {
            return FoodDAL.Instance.GetInventoryList();
        }
        public int GetInventoryByFoodId(int idFood)
        {
            return FoodDAL.Instance.GetInventoryByFoodId(idFood);
        }
        public bool SmartImportFood(int importBillId, int idFood, string name, int cateId, double price, int qty, string unit, string image)
        {
            return FoodDAL.Instance.SmartImportFood(importBillId, idFood, name, cateId, price, qty, unit, image);
        }
        public List<string> GetAllCategories()
        {
            return FoodDAL.Instance.GetAllCategories();
        }
    }
}
