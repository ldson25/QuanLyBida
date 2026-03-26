using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIDADTO
{
    public class PromotionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public float Value { get; set; }
        public bool Status { get; set; }

        public int? ApplyForFoodId { get; set; } 
        public int RequiredQty { get; set; }

        public PromotionDTO(int id, string name, int type, float value, bool status, int? foodId, int reqQty)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Value = value;
            this.Status = status;
            this.ApplyForFoodId = foodId;
            this.RequiredQty = reqQty;
        }

        public PromotionDTO(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Name = row["NAME"].ToString();
            this.Type = (int)row["TYPE"];
            this.Value = (float)Convert.ToDouble(row["VALUE"]);
            this.Status = (bool)row["STATUS"];

            if (row["APPLY_FOR_FOOD_ID"] != DBNull.Value)
                this.ApplyForFoodId = (int)row["APPLY_FOR_FOOD_ID"];
            else
                this.ApplyForFoodId = null;

            if (row["REQUIRED_QTY"] != DBNull.Value)
                this.RequiredQty = (int)row["REQUIRED_QTY"];
            else
                this.RequiredQty = 0;
        }
    }
}
