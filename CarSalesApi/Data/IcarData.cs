using CarSalesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesApi.Data
{
    public interface ICarData
    {
        bool SaveChanges();
        IEnumerable<VehicleTypes> GetCarDataCommands();
        VehicleTypes GetDataByID(int ID);
        void CreateVehicle(VehicleTypes vht);
        void UpdateVehicle(VehicleTypes vht);
        void DeleteVehicleType(VehicleTypes vht);

    }

    public interface IVehicleProps
    {
        bool SaveChanges();
        IEnumerable<VehicleProps> GetAllVehicleProps();
        IEnumerable<VehicleProps>GetVehicleProps(int ID);
        VehicleProps GetVehiclePropsById(int ID);
        void CreateVehicleProps(VehicleProps vht);
        void UpdateVehicleProps(VehicleProps vht);
        void DeleteVehicleProps(VehicleProps vht);
    }

    public interface IVehicleInfo
    {
        bool SaveChanges();
        IEnumerable<VehicleInfo> GetVehicleInfo();
        VehicleInfo GetvehicleInfobyID(int ID);
        void CreateVehicleInfo(VehicleInfo vht);
        void UpdateVehicleInfo(VehicleInfo vht);
        void DeleteVehicleInfo(VehicleInfo vht);
    }
}
