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
    public class VehicleTypesController : ControllerBase
    {
        private readonly ICarData _repo;
        private readonly IMapper _mapper;

        public VehicleTypesController(ICarData repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // Get api/controller
        [HttpGet]
        public ActionResult<IEnumerable<VehicleTypesReadDto>> GetVehicleTypesCommands()
        {
            var VehicleTypesItems = _repo.GetCarDataCommands();
            return Ok(_mapper.Map<IEnumerable<VehicleTypesReadDto>>(VehicleTypesItems));
        }

        // Get api/controller/{id}
        [HttpGet("{ID}", Name = "GetDataByID")]
        public ActionResult<IEnumerable<VehicleTypesReadDto>> GetDataByID(int ID)
        {
            var carddatabyID = _repo.GetDataByID(ID);
            
            if (carddatabyID != null)
            {
                return Ok(_mapper.Map<VehicleTypesReadDto>(carddatabyID));
            }
            return NotFound();
        }

        //POST api/controller
        [HttpPost]
        public ActionResult<VehicleTypesReadDto> CreateVehicle(VehicleTypesCreateDto VehicleCreateDto)
        {
            var vehicleModel = _mapper.Map<VehicleTypes>(VehicleCreateDto);
            _repo.CreateVehicle(vehicleModel);
            _repo.SaveChanges();
            return NoContent();

        }

        //PUT api/controller/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateVehicleType(int ID, VehicleTypeUpdateDto vehicleupdatedto)
        {
            var vehicleModelfromRepo = _repo.GetDataByID(ID);
            if (vehicleModelfromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(vehicleupdatedto, vehicleModelfromRepo);

            _repo.UpdateVehicle(vehicleModelfromRepo);

            _repo.SaveChanges();

            return NoContent();
        }

        //DELETE api/controller/{id}
        [HttpDelete("{ID}")]
        public ActionResult DeleteVehicleType(int ID)
        {
            var vehicleModelfromRepo = _repo.GetDataByID(ID);
            if (vehicleModelfromRepo == null)
            {
                return NotFound();
            }

            _repo.DeleteVehicleType(vehicleModelfromRepo);
            _repo.SaveChanges();

            return NoContent();

        }
    }
}