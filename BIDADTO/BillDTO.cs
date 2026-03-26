using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIDADTO
{
    public class BillDTO
    {
        public int IdBill { get; set; }
        public int IdTable { get; set; }

        public DateTime DateCheckIn { get; set; }
        public DateTime DateCheckOut { get; set; }

        public decimal TableFee { get; set; }    
        public decimal FoodFee { get; set; }     
        public decimal Discount { get; set; }    
        public decimal Surcharge { get; set; }   
        public decimal TotalAmount { get; set; } 

        public int Status { get; set; } 
        public int? EmployeeId { get; set; } 

        public BillDTO() { }
    }
}
