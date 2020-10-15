using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApi.Models;

namespace CarSalesApi.Data.VehicleProperties
{
    public class MockVehiclePropsRepo : IVehicleProps
    {
        public void CreateVehicleProps(VehicleProps vht)
        {
            throw new NotImplementedException();
        }

        public void DeleteVehicleProps(VehicleProps vht)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VehicleProps> GetAllVehicleProps()
        {
            var VehiclePropscommand = new List<VehicleProps>
            {
                new VehicleProps{ID=1 , VehicleProperties="Make"},
                new VehicleProps{ID=2 , VehicleProperties="Model"},
                new VehicleProps{ID=3 , VehicleProperties="Audio System"}
            };

            return VehiclePropscommand;
        }

        public IEnumerable<VehicleProps> GetVehicleProps(int ID)
        {
            var VehiclePropscommand = new List<VehicleProps>
            {
                new VehicleProps{ID=1 , VehicleProperties="Make"},
                new VehicleProps{ID=2 , VehicleProperties="Model"},
                new VehicleProps{ID=3 , VehicleProperties="Audio System"}
            };

            return VehiclePropscommand.AsQueryable();
        }

        public VehicleProps GetVehiclePropsById(int ID)
        {
            return new VehicleProps { ID = 1, VehicleProperties = "Audio System" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicleProps(VehicleProps vht)
        {
            throw new NotImplementedException();
        }
    }
}
