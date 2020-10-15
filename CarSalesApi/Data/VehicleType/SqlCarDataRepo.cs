using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApi.Models;

namespace CarSalesApi.Data
{
    public class SqlVehicleTypesRepo : ICarData
    {
        private readonly VehicleData _context;

        public SqlVehicleTypesRepo(VehicleData context)
        {
            _context = context;
        }

        public void CreateVehicle(VehicleTypes vht)
        {
            if (vht == null)
            {
                throw new ArgumentNullException(nameof(vht));
            }
            _context.VehicleTypes.Add(vht);

        }

        public void DeleteVehicleType(VehicleTypes vht)
        {
            if (vht == null)
            {
                throw new ArgumentNullException(nameof(vht));
            }

            _context.VehicleTypes.Remove(vht);
        }

        public IEnumerable<VehicleTypes> GetCarDataCommands()
        {
            return _context.VehicleTypes.ToList();
            
        }

        public VehicleTypes GetDataByID(int ID)
        {
           return _context.VehicleTypes.FirstOrDefault(p => p.ID == ID);            
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateVehicle(VehicleTypes vht)
        {
           //Nothing
        }
    }
}
