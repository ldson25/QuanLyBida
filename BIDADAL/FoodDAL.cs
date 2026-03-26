using BIDADAL;
using BIDADTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIDADAL
{
    public class FoodDAL
    {
        private static FoodDAL instance;

        public static FoodDAL Instance
        {
            get
            {
                if (instance == null) instance = new FoodDAL();
                return instance;
            }
        }

        private FoodDAL() { }

        public List<FoodDTO> GetAllFood()
        {
            List<FoodDTO> list = new List<FoodDTO>();

            string query = "SELECT * FROM FOOD";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                FoodDTO f = new FoodDTO
                {
                    IdFood = Convert.ToInt32(row["IDFOOD"]),
                    Name = row["NAME"].ToString(),
                    IdCategory = Convert.ToInt32(row["IDCATEGORY"]),
                    Price = Convert.ToDouble(row["PRICE"]),
                    Images = row["IMAGES"] == DBNull.Value ? "" : row["IMAGES"].ToString()
                };

                list.Add(f);
            }

            return list;
        }
        public List<string> GetAllCategories()
        {
            List<string> list = new List<string>();

            string query = "SELECT NAME FROM FOODCATEGORY";

            DataTable dt = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(row["NAME"].ToString());
            }

            return list;
        }
        public int InsertFood(FoodDTO food)
        {
            string query = "INSERT INTO FOOD (NAME, PRICE, IDCATEGORY, IMAGES) VALUES ( @name , @price , @cate , @img )";
            return DataProvider.Instance.ExcuteNonQuery(query,
                new object[] { food.Name, food.Price, food.IdCategory, food.Images });
        }

        public int UpdateFood(FoodDTO food)
        {
            string query = "UPDATE FOOD SET " +
                        "NAME = @name , " + 
                        "PRICE = @price , " +
                        "IDCATEGORY = @cate , " +
                        "IMAGES = @img " +
                        "WHERE IDFOOD = @id";

            return DataProvider.Instance.ExcuteNonQuery(query,
                new object[] { food.Name, food.Price, food.IdCategory, food.Images, food.IdFood });
        }

        public int DeleteFood(int id)
        {
            return DataProvider.Instance.ExcuteNonQuery("DELETE FROM FOOD WHERE IDFOOD=" + id);
        }
        public List<FoodDTO> GetInventoryList()
        {
            List<FoodDTO> list = new List<FoodDTO>();

            string query = "EXEC USP_GetInventoryList";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                FoodDTO f = new FoodDTO();
                f.IdFood = Convert.ToInt32(row["IDFOOD"]);
                f.Name = row["NAME"].ToString();
                f.Price = Convert.ToDouble(row["PRICE"]);

                f.CategoryName = row["CategoryName"] != DBNull.Value ? row["CategoryName"].ToString() : "";
                f.Unit = row["UNIT"] != DBNull.Value ? row["UNIT"].ToString() : "";
                f.Inventory = row["INVENTORY"] != DBNull.Value ? Convert.ToInt32(row["INVENTORY"]) : 0;

                list.Add(f);
            }
            return list;
        }
        public int GetInventoryByFoodId(int idFood)
        {
            string query = "SELECT INVENTORY FROM dbo.FOOD WHERE IDFOOD = " + idFood;
            object result = DataProvider.Instance.ExcuteScalar(query);

            if (result != null)
            {
                return Convert.ToInt32(result);
            }
            return 0;
        }
        public bool SmartImportFood(int importBillId, int idFood, string name, int cateId, double price, int qty, string unit, string image)
        {
            string query = "EXEC USP_SmartImportFood @ImportBillID , @FoodID , @FoodName , @CategoryID , @Price , @Quantity , @Unit , @Image";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {
        importBillId,
        idFood,     
        name,
        cateId,
        price,
        qty,
        unit,
        image
    });

            return result > 0;
        }
    }
}
