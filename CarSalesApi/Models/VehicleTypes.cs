using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesApi.Models
{
    public class VehicleTypes
    {
        public int ID { get; set; }
        public string VehicleType { get; set; }
    }

    public class VehicleProps
    {
        public int ID { get; set; }
        public string VehicleProperties { get; set; }
        public int VehicleMapping { get; set; }
    }

    public class VehicleInfo
    {
        public int ID { get; set; }
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
