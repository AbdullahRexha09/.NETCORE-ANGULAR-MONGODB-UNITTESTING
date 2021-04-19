using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using System;
using webapplication.Controllers;
using webapplication.Models;
using webapplication.Services;
using Xunit;

namespace PMLAssignment.Tests
{
    public class PMLAssignmentTaskTests
    {
        private Guid taskId = Guid.Parse("8538562C-6BDD-4621-6BB7-08D90272C43F");
        [Fact]
        public void GetTasks_Returns_OK()
        {
            var dataStore = A.Fake<ITaskService>();
            A.CallTo(() => dataStore.GetAllTasks());
            var controller = new TaskController(dataStore);

            var actionResult = controller.GetAllTasks();
            ObjectResult objectResponse = Assert.IsType<OkObjectResult>(actionResult);
        }
        [Fact]
        public void Create_A_Task_Returns_OK()
        {
            var dataStore = A.Fake<ITaskService>();
            A.CallTo(() => dataStore.Create(NewTaskObj()));
            var controller = new TaskController(dataStore);
            var item = dataStore.Create(NewTaskObj());
            Assert.True(!dataStore.Create(NewTaskObj()));
        }
        [Fact]
        public void Check_Get_Task_By_Id()
        {
            var dataStore = A.Fake<ITaskService>();
            A.CallTo(() => dataStore.GetById(taskId));
            var controller = new TaskController(dataStore);
            var item = dataStore.GetById(taskId);
            item.Id = taskId;
            Assert.IsAssignableFrom<PMLTask>(item);
        }
        private PMLTask NewTaskObj()
        {
            return new PMLTask()
            {
                Title = "Taska 01",
                Description = "Zhvillimi i nje ueb aplikacioni",
                DueDate = DateTime.Now,
                Completed = false,
            };
        }
    }
}
