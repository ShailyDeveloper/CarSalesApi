using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApi.Models;

namespace CarSalesApi.Data
{
    public class MockVehicleTypesRepo : ICarData
    {
        public void CreateVehicle(VehicleTypes vht)
        {
            throw new NotImplementedException();
        }

        public void DeleteVehicleType(VehicleTypes vht)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VehicleTypes> GetCarDataCommands()
        {
            var VehicleTypescommand = new List<VehicleTypes>
            {
                new VehicleTypes{ID=1 , VehicleType="Car"},
                new VehicleTypes{ID=2 , VehicleType="Bus"},
                new VehicleTypes{ID=3 , VehicleType="Boat"}
            };

            return VehicleTypescommand;
        }

        public VehicleTypes GetDataByID(int ID)
        {
            return new VehicleTypes { ID = 1, VehicleType = "Car" };
            
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicle(VehicleTypes vht)
        {
            throw new NotImplementedException();
        }
    }
}
