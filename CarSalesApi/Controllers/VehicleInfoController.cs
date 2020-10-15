using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarSalesApi.Data;
using CarSalesApi.Dtos.VehicleInformation;
using CarSalesApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarSalesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleInfoController : ControllerBase
    {
        private readonly IVehicleInfo _repo;
        private readonly IMapper _mapper;

        public VehicleInfoController(IVehicleInfo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // Get api/controller
        [HttpGet]
        public ActionResult<IEnumerable<VehicleInfoReadDto>> GetVehicleTypesCommands()
        {
            var VehicleTypesItems = _repo.GetVehicleInfo();
            return Ok(_mapper.Map<IEnumerable<VehicleInfoReadDto>>(VehicleTypesItems));
        }

        // Get api/controller/{id}
        [HttpGet("{ID}", Name = "GetVehicleInfoByID")]
        public ActionResult<IEnumerable<VehicleInfoReadDto>> GetDataByID(int ID)
        {
            var carddatabyID = _repo.GetvehicleInfobyID(ID);

            if (carddatabyID != null)
            {
                return Ok(_mapper.Map<VehicleInfoReadDto>(carddatabyID));
            }
            return NotFound();
        }

        //POST api/controller
        [HttpPost]
        public ActionResult<VehicleInfoReadDto> CreateVehicle(VehicleInfoCreateDto VehicleCreateDto)
        {
            var vehicleModel = _mapper.Map<VehicleInfo>(VehicleCreateDto);
            _repo.CreateVehicleInfo(vehicleModel);
            _repo.SaveChanges();
            return NoContent();

        }

        //PUT api/controller/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateVehicleType(int ID, VehicleInfoUpdateDto vehicleupdatedto)
        {
            var vehicleModelfromRepo = _repo.GetvehicleInfobyID(ID);
            if (vehicleModelfromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(vehicleupdatedto, vehicleModelfromRepo);

            _repo.UpdateVehicleInfo(vehicleModelfromRepo);

            _repo.SaveChanges();

            return NoContent();
        }

        //DELETE api/controller/{id}
        [HttpDelete("{ID}")]
        public ActionResult DeleteVehicleType(int ID)
        {
            var vehicleModelfromRepo = _repo.GetvehicleInfobyID(ID);
            if (vehicleModelfromRepo == null)
            {
                return NotFound();
            }

            _repo.DeleteVehicleInfo(vehicleModelfromRepo);
            _repo.SaveChanges();

            return NoContent();

        }
    }
}