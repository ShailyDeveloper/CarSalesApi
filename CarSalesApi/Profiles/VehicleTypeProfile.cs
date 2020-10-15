using AutoMapper;
using CarSalesApi.Dtos;
using CarSalesApi.Dtos.VehicleInformation;
using CarSalesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesApi.Profiles
{
    public class VehicleTypeProfile : Profile
    {
        public VehicleTypeProfile()
        {
            CreateMap<VehicleTypes, VehicleTypesReadDto>();
            CreateMap<VehicleTypesCreateDto, VehicleTypes>();
            CreateMap<VehicleTypeUpdateDto, VehicleTypes>();
        }
    }

    public class VehiclePropertiesProfile : Profile
    {
        public VehiclePropertiesProfile()

        {
            CreateMap<VehicleProps, VehiclePropertiesReadDto>();
            CreateMap<VehiclePropertiesCreateDto, VehicleProps>();
            CreateMap<VehiclePropertiesUpdateDto, VehicleProps>();

        }
    }

    public class VehicleInfoProfile : Profile
    {
        public VehicleInfoProfile()

        {
            CreateMap<VehicleInfo,VehicleInfoReadDto>();
            CreateMap<VehicleInfoCreateDto, VehicleInfo>();
            CreateMap<VehicleInfoUpdateDto, VehicleInfo>();
        }
    }
}
