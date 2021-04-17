using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using webapplication.DtoModels;
using webapplication.Models;
using webapplication.Services;
using webapplication.Utils;

namespace webapplication.Controllers
{
    [Route("api/location")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService locationService;
        public LocationController(ILocationService locationService) 
        {
            this.locationService =  locationService;
        }

        [HttpGet]
        [Route("getAllCities")]
        [Authorize(Roles = "User")]
        public IActionResult GetAllCities() 
        {
            List<City> cities = locationService.GetAllCities();
            return Ok(cities);
        }
        [HttpGet]
        [Route("getAllLocations")]
        [Authorize(Roles = "User")]
        public IActionResult GetAllLocations() 
        {
            List<Location> locations = locationService.GetAllLocations();
            return Ok(locations);
        }
        [HttpGet]
        [Route("getLocationById")]
        [Authorize(Roles = "User")]
        public IActionResult GetLocationById(Guid id)
        {
            Location location = locationService.GetLocationById(id);
            return Ok(location);
        }
        [HttpPost]
        [Route("postLocation")]
        [Authorize(Roles = "User")]
        public IActionResult PostLocation([FromBody] LocationModel locationModel) 
        {
            Location location = new Location
            {
                Name = locationModel.Name,
                Address = locationModel.Address,
                CityId = locationModel.CityId
            };
            bool isAdded = locationService.AddLocation(location);
            if (isAdded) 
            {
                return Ok(isAdded);
            }
            return BadRequest("Row wasn't Added");
        }
        [HttpPut]
        [Route("putLocation")]
        [Authorize(Roles = "User")]
        public IActionResult PutLocation([FromBody] LocationModel locationModel,Guid id)
        {
            Location location = new Location
            {
                Id = id,
                Name = locationModel.Name,
                Address = locationModel.Address,
                CityId = locationModel.CityId
            };

            bool isUpdated = locationService.UpdateLocation(location);
            if (isUpdated) 
            {
                return Ok(isUpdated);
            }
            return BadRequest("Row wasn't Updated");
        }
        [HttpDelete]
        [Route("deleteLocation")]
        [Authorize(Roles = "User")]
        public IActionResult DeleteLocation(Guid id) 
        {
            bool isDeleted = locationService.DeleteLocation(id);
            if (isDeleted) 
            {
                return Ok(isDeleted);
            }
            return BadRequest("Row wasn't Deleted");
            
        }

    }
}
