using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using webapplication.Controllers;
using webapplication.Models;
using webapplication.Services;
using Xunit;

namespace PMLAssignment.Tests
{
    public class PMLAssignmentListTest
    {
        private Guid listId = Guid.Parse("8538562C-6BDD-4621-6BB7-08D90272C43F");
        [Fact]
        public void GetLists_Returns_OK()
        {
            var dataStore = A.Fake<IListService>();
            A.CallTo(() => dataStore.GetAllLists());
            var controller = new ListController(dataStore);

            var actionResult = controller.GetAllTasks();
            ObjectResult objectResponse = Assert.IsType<OkObjectResult>(actionResult);
        }
        [Fact]
        public void Create_A_List_Returns_OK()
        {
            var dataStore = A.Fake<IListService>();
            A.CallTo(() => dataStore.Create(NewListObject()));
            var controller = new ListController(dataStore);
            var item = dataStore.Create(NewListObject());
            Assert.True(!dataStore.Create(NewListObject()));
        }
        [Fact]
        public void Check_Get_List_By_Id()
        {
            var dataStore = A.Fake<IListService>();
            A.CallTo(() => dataStore.GetById(listId));
            var controller = new ListController(dataStore);
            var item = dataStore.GetById(listId);
            item.Id = listId;
            Assert.IsAssignableFrom<PMLList>(item);
        }
        private PMLList NewListObject() 
        {
            return new PMLList
            {
                Name = "List 01",
                Description = "Lista per zhvillimin e uebit"
            };
        }
    }
}
