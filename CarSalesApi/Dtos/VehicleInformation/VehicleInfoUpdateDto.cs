using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesApi.Dtos.VehicleInformation
{
    public class VehicleInfoUpdateDto
    {
        public int RecordID { get; set; }
        public string VehicleType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public int Doors { get; set; }
        public int Wheels { get; set; }
        public string BodyType { get; set; }
        public string FuelType { get; set; }
        public string AudioSystem { get; set; }
        public string OpalScannerMake { get; set; }
    }
}
