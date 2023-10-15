using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class RentingTransaction
    {
        public int RentingTransationID { get; set; }
        public DateTime? RentingDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public int CustomerID { get; set; }
        public byte? RentingStatus { get; set; }
    }
}
