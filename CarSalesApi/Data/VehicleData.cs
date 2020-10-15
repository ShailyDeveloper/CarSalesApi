using CarSalesApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesApi.Data
{
    public class VehicleData : DbContext
    {
        public VehicleData(DbContextOptions<VehicleData> opt) :base(opt)
        {

        }

        public DbSet<VehicleTypes> VehicleTypes{ get; set; }
        public DbSet<VehicleProps> VehicleProps { get; set; }
        public DbSet<VehicleInfo> VehicleInfo { get; set; }
    }
}
