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
        [Route("getListById")]
        //[Authorize(Roles = "User")]
        public IActionResult GetListById(Guid id)
        {
            PMLList pMLList = listService.GetById(id);
            return Ok(pMLList);
        }
        [HttpGet]
        [Route("getAllLists")]
        //[Authorize(Roles = "User")]
        public IActionResult GetAllTasks()
        {
            List<PMLList> lists = listService.GetAllLists();
            return Ok(lists);
        }
        [HttpPut]
        [Route("updateList")]
        [Authorize(Roles = "User")]
        public IActionResult UpdateList([FromBody]ListModel listModel, Guid id)
        {
            PMLList pMLList = listService.GetById(id);
            {
                pMLList.Name = listModel.Name;
                pMLList.Description = listModel.Description;
            }
            bool isUpdated = listService.Update(pMLList);
            if (isUpdated)
            {
                return Ok(isUpdated);
            }
            return BadRequest("Row wasn't Updated");
        }
        [HttpDelete]
        [Route("delete")]
        //[Authorize(Roles = "User")]
        public IActionResult Delete(Guid id)
        {
            bool isDeleted = listService.Delete(id);
            if (isDeleted)
            {
                return Ok(isDeleted);
            }
            return BadRequest("Row wasn't Deleted");
        }

    }
}
