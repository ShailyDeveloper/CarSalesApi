using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesApi.Dtos
{
    public class VehiclePropertiesReadDto
    {
        public int ID { get; set; }
        public string VehicleProperties { get; set; }
        public int VehicleMapping { get; set; }
    }
}
