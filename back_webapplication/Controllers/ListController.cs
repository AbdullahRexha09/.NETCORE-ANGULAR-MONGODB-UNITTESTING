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
    [Route("api/list")]
    [ApiController]
    public class ListController : ControllerBase
    {
        private readonly IListService listService;
        public ListController(IListService listService)
        {
            this.listService = listService;
        }
        [HttpPost]
        [Route("createList")]
        //[Authorize(Roles = "User")]
        public IActionResult CreateList([FromBody] ListModel listModel)
        {
            PMLList pMLList = new PMLList
            {
                Name = listModel.Name,
                Description = listModel.Description
            };
            bool isAdded = listService.Create(pMLList);
            if (isAdded)
            {
                return Ok(isAdded);
            }
            return BadRequest("Row wasn't Added");
        }
        [HttpGet]
        [Route("getAllLists")]
        //[Authorize(Roles = "User")]
        public IActionResult GetAllTasks()
        {
            List<PMLList> lists = listService.GetAllLists();
            return Ok(lists);
        }

    }
}
