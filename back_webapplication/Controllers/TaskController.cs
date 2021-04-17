using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapplication.Models;
using webapplication.Services;

namespace webapplication.Controllers
{
    [Route("api/task")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService taskService;
        public TaskController(ITaskService taskService)
        {
            this.taskService = taskService;
        }
        [HttpPost]
        [Route("createTask")]
        //[Authorize(Roles = "User")]
        public IActionResult CreateTask([FromBody] TaskModel taskModel)
        {
            PMLTask pMLTask = new PMLTask
            {
                Title = taskModel.Title,
                Description = taskModel.Description,
                DueDate = DateTime.Parse(taskModel.DueDate)
            };
            bool isAdded = taskService.Create(pMLTask);
            if (isAdded)
            {
                return Ok(isAdded);
            }
            return BadRequest("Row wasn't Added");
    }
}
}
