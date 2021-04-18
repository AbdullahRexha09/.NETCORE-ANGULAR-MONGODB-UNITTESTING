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
        [Authorize(Roles = "User")]
        public IActionResult CreateTask([FromBody] TaskModel taskModel)
        {
            PMLTask pMLTask = new PMLTask
            {
                Title = taskModel.Title,
                Description = taskModel.Description,
                DueDate = DateTime.Parse(taskModel.DueDate),
                Parent = taskModel.Parent,
                ListId = taskModel.ListId

            };
            bool isAdded = taskService.Create(pMLTask);
            if (isAdded)
            {
                return Ok(isAdded);
            }
            return BadRequest("Row wasn't Added");
        }
        [HttpPut]
        [Route("chngstatus")]
        //[Authorize(Roles = "User")]
        public IActionResult ChangeStatus(Guid id)
        {
            bool isChanged = taskService.ChangeStatus(id);
            if (isChanged)
            {
                return Ok(isChanged);
            }
            return BadRequest("Row wasn't Changed");
        }
        [HttpGet]
        [Route("getTaskById")]
        [Authorize(Roles = "User")]
        public IActionResult GetTaskById(Guid id)
        {
            PMLTask task = taskService.GetById(id);
            return Ok(task);
        }
        [HttpGet]
        [Route("getAllTasks")]
        [Authorize(Roles = "User")]
        public IActionResult GetAllTasks()
        {
            List<PMLTask> tasks = taskService.GetAllTasks();
            return Ok(tasks);
        }
        [HttpGet]
        [Route("getByListId")]
        [Authorize(Roles = "User")]
        public IActionResult GetByListId(Guid id)
        {
            List<PMLTask> tasks = taskService.GetByListId(id);
            return Ok(tasks);
        }
        [HttpPut]
        [Route("updateTask")]
        [Authorize(Roles = "User")]
        public IActionResult UpdateTask([FromBody]TaskModel taskModel, Guid id)
        {
            PMLTask pMLTask = taskService.GetById(id);
            {
                pMLTask.Title = taskModel.Title;
                pMLTask.Description = taskModel.Description;
                pMLTask.DueDate = DateTime.Parse(taskModel.DueDate);
                pMLTask.Completed = taskModel.Completed;
            }
            bool isUpdated = taskService.Update(pMLTask);
            if (isUpdated)
            {
                return Ok(isUpdated);
            }
            return BadRequest("Row wasn't Updated");
        }
        [HttpDelete]
        [Route("delete")]
        [Authorize(Roles = "User")]
        public IActionResult DeleteById(Guid id)
        {
            bool isDeleted = taskService.Delete(id);
            if (isDeleted)
            {
                return Ok(isDeleted);
            }
            return BadRequest("Row wasn't Deleted");
        }
    }
}
