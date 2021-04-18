using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using System;
using webapplication.Controllers;
using webapplication.Services;
using Xunit;

namespace PMLAssignment.Tests
{
    public class PMLAssignmentTests
    {
        [Fact]
        public void GetTasks_Returns_The_Correct_Number_Of_Tasks()
        {
            var dataStore = A.Fake<ITaskService>();
            A.CallTo(() => dataStore.GetAllTasks());
            var controller = new TaskController(dataStore);

            var actionResult = controller.GetAllTasks();

            var result = actionResult as OkObjectResult;

        }
    }
}
