using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIDADTO
{
    public class BillInfoDTO
    {
        public int Id { get; set; }
        public int IdBill { get; set; }
        public int IdFood { get; set; }
        public int Count { get; set; }

        public BillInfoDTO() { }

        public BillInfoDTO(int id, int idBill, int idFood, int count)
        {
            Id = id;
            IdBill = idBill;
            IdFood = idFood;
            Count = count;
        }
    }
}
