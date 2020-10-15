using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApi.Models;

namespace CarSalesApi.Data.VehicleProperties
{
    public class SqlVehiclePropsRepo : IVehicleProps
    {
        private readonly VehicleData _context;

        public SqlVehiclePropsRepo(VehicleData context)
        {
            _context = context;
        }
        public void CreateVehicleProps(VehicleProps vht)
        {
            if (vht == null)
            {
                throw new ArgumentNullException(nameof(vht));
            }
            _context.VehicleProps.Add(vht);
        }

        public IEnumerable<VehicleProps> GetAllVehicleProps()
        {
            return _context.VehicleProps.ToList();
        }

        public void DeleteVehicleProps(VehicleProps vht)
        {
            if (vht == null)
            {
                throw new ArgumentNullException(nameof(vht));
            }

            _context.VehicleProps.Remove(vht);
        }

        public IEnumerable<VehicleProps> GetVehicleProps(int ID)
        {
            return _context.VehicleProps.Where(p => p.VehicleMapping == ID).Union(_context.VehicleProps.Where(p=>p.VehicleMapping == 0));
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateVehicleProps(VehicleProps vht)
        {
            //Nothing
        }

        public VehicleProps GetVehiclePropsById(int ID)
        {
            return _context.VehicleProps.FirstOrDefault(p => p.ID == ID);
        }
    }
}
