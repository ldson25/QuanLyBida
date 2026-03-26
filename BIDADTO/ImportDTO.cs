using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIDADTO
{
    public class ImportBillDTO
    {
        public int Id { get; set; }
        public DateTime DateImport { get; set; }
        public decimal TotalPrice { get; set; }
        public string Note { get; set; }
    }

    public class ImportInfoDTO
    {
        public int Id { get; set; }
        public int IdBill { get; set; }
        public int IdFood { get; set; }
        public int Quantity { get; set; }
        public decimal InputPrice { get; set; }
    }
}
