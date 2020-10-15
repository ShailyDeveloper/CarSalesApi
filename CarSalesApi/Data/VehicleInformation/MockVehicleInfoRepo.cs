using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApi.Models;

namespace CarSalesApi.Data.VehicleInformation
{
    public class MockVehicleInfoRepo : IVehicleInfo
    {
        public void CreateVehicleInfo(VehicleInfo vht)
        {
            throw new NotImplementedException();
        }

        public void DeleteVehicleInfo(VehicleInfo vht)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VehicleInfo> GetVehicleInfo()
        {
            var VehicleInfocommand = new List<VehicleInfo>
            {
                new VehicleInfo{ID=1,RecordID=1,VehicleType="Car",Make="Audi",Model="Vendana",Engine="GTX97",Doors=4,Wheels=4,BodyType="Metallic",FuelType="Petrol",AudioSystem="Sony",OpalScannerMake=null },
                new VehicleInfo{ID=2,RecordID=2,VehicleType="Bus",Make="Toyota",Model="X78",Engine="TUV67",Doors=2,Wheels=6,BodyType="Metallic",FuelType="Diesel",AudioSystem=null,OpalScannerMake="verifone" }
            };

            return VehicleInfocommand;
        }

        public VehicleInfo GetvehicleInfobyID(int ID)
        {
            return new VehicleInfo { ID = 1, RecordID = 1, VehicleType = "Car", Make = "Audi", Model = "Vendana", Engine = "GTX97", Doors = 4, Wheels = 4, BodyType = "Metallic", FuelType = "Petrol", AudioSystem = "Sony", OpalScannerMake = null };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicleInfo(VehicleInfo vht)
        {
            throw new NotImplementedException();
        }
    }
}
