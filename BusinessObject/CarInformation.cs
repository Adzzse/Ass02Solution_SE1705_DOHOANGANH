using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class CarInformation
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public string CarDescription { get; set; }
        public int? NumberOfDoors { get; set; }
        public int? SeatingCapacity { get; set; }
        public string FuelType { get; set; }
        public int? Year { get; set; }
        public int ManufacturerID { get; set; }
        public int SupplierID { get; set; }
        public byte? CarStatus { get; set; }
        public decimal? CarRentingPricePerDay { get; set; }
    }
}
