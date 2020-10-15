using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarSalesApi.Data;
using CarSalesApi.Dtos;
using CarSalesApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CarSalesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleProprtiesController : ControllerBase
    {
        private readonly IVehicleProps _repo;
        private readonly IMapper _mapper;

        public VehicleProprtiesController(IVehicleProps repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // Get api/controller
        [HttpGet]
        public ActionResult<IEnumerable<VehiclePropertiesReadDto>> GetVehicleProperties()
        {
            var VehiclePropertiesItems = _repo.GetAllVehicleProps();
            return Ok(_mapper.Map<IEnumerable<VehiclePropertiesReadDto>>(VehiclePropertiesItems));
        }

        // Get api/controller/{id}
        [HttpGet("{ID}", Name = "GetVehicleProps")]
        public ActionResult<IEnumerable<VehiclePropertiesReadDto>> GetVehiclePropertiesByID(int ID)
        {
            var vehiclePropertiesbyID = _repo.GetVehicleProps(ID);
            
            if (vehiclePropertiesbyID != null)
            {
                return Ok(_mapper.Map <IEnumerable<VehiclePropertiesReadDto>>(vehiclePropertiesbyID));           
            }
            return NotFound();
        }

        //POST api/controller
        [HttpPost]
        public ActionResult<VehiclePropertiesReadDto> CreateVehicleProperties(VehiclePropertiesCreateDto VehicleCreateDto)
        {
            
                var vehicleModel = _mapper.Map<VehicleProps>(VehicleCreateDto);
                _repo.CreateVehicleProps(vehicleModel);
                _repo.SaveChanges();
                return NoContent();           
            
        }

        //PUT api/controller/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateVehicleType(int ID, VehiclePropertiesUpdateDto vehicleupdatedto)
        {
            var vehicleModelfromRepo = _repo.GetVehiclePropsById(ID);
            if (vehicleModelfromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(vehicleupdatedto, vehicleModelfromRepo);

            _repo.UpdateVehicleProps(vehicleModelfromRepo);

            _repo.SaveChanges();

            return NoContent();
        }

        //DELETE api/controller/{id}
        [HttpDelete("{ID}")]
        public ActionResult DeleteVehicleType(int ID)
        {
            var vehicleModelfromRepo = _repo.GetVehiclePropsById(ID);
            if (vehicleModelfromRepo == null)
            {
                return NotFound();
            }

            _repo.DeleteVehicleProps(vehicleModelfromRepo);
            _repo.SaveChanges();

            return NoContent();

        }
    }
}