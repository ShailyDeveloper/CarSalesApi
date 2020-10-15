using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesApi.Models;

namespace CarSalesApi.Data.VehicleInformation
{
    public class SqlVehicleInfoRepo : IVehicleInfo
    {
        private readonly VehicleData _context;

        public SqlVehicleInfoRepo(VehicleData context)
        {
            _context = context;
        }
        public void CreateVehicleInfo(VehicleInfo vht)
        {
            if (vht == null)
            {
                throw new ArgumentNullException(nameof(vht));
            }
            _context.VehicleInfo.Add(vht);
        }

        public void DeleteVehicleInfo(VehicleInfo vht)
        {
            if (vht == null)
            {
                throw new ArgumentNullException(nameof(vht));
            }
            _context.VehicleInfo.Remove(vht);
        }

        public IEnumerable<VehicleInfo> GetVehicleInfo()
        {
            return _context.VehicleInfo.ToList();
        }

        public VehicleInfo GetvehicleInfobyID(int ID)
        {
            return _context.VehicleInfo.FirstOrDefault(p => p.ID == ID);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateVehicleInfo(VehicleInfo vht)
        {
            //Do Nothing
        }
    }
}
