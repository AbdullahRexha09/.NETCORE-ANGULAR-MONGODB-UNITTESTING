using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapplication.DtoModels;
using webapplication.Models;
using webapplication.Services;

namespace webapplication.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly ITokenService tokenService;

        public UserController(IUserService userService, ITokenService tokenService)
        {
            this.userService = userService;
            this.tokenService = tokenService;
        }

        [HttpGet]
        [Authorize(Roles = "User")]
        [Route("getUserByJwt")]
        public IActionResult GetUser(string jwt) 
        {
            string  email = tokenService.GetUserByJwt(jwt);
            User user = userService.GetUserByEmail(email);
            return Ok(user);
        }
        [HttpPut]
        [Authorize(Roles = "User")]
        [Route("updateUser")]
        public IActionResult UpdateUser([FromBody]UserModel userModel,Guid id) 
        {
            //TODO -- AUTOMAPPER <- Message From ME!
            User user = userService.GetById(id);
            {
                user.FirstName = userModel.FirstName;
                user.LastName = userModel.LastName;
                user.Status = userModel.Status;
            }
            bool isUpdated = userService.UpdateUser(user);
            if (isUpdated)
            {
                return Ok(isUpdated);
            }
            return BadRequest("Row wasn't Updated");
        }

    }
}
