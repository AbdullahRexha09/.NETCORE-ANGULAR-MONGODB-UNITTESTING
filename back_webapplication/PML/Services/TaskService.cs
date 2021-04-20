using Microsoft.EntityFrameworkCore;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapplication.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace webapplication.Services
{
    public class TaskService : ITaskService
    {
        private readonly IMongoCollection<PMLTask> _task;

        public TaskService(IPMLDatabaseSettings settings)
        {

            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _task = database.GetCollection<PMLTask>(settings.PMLTaskCollectionName);
        }
        public bool Create(PMLTask task)
        {
            _task.InsertOne(task);

            return true;
        }

        public bool Delete(string id)
        {
            _task.DeleteOne(x => x.Id == id);
             return true;
        }
        public bool ChangeStatus(string id) 
        {
            var entity = _task.Find(x => x.Id == id).FirstOrDefault();

            var filter = Builders<PMLTask>.Filter.Eq("Id", id);
            var update = Builders<PMLTask>.Update.Set("Completed", !entity.Completed);
             _task.UpdateOne(filter, update);
            return true;
        }

        public List<PMLTask> GetAllTasks()
        {
            List<PMLTask> tasks = _task.Find(_ => true).ToList();
            foreach (var item in tasks) 
            {
                if (item.Parent != null) 
                {
                    item.ParentTask = GetById(item.Parent);
                }
            }
            return tasks;
        }
        public PMLTask GetById(string id) 
        {
            PMLTask pMLTask = _task.Find(x => x.Id == id).FirstOrDefault();
            return pMLTask;
        }

        public bool Update(PMLTask task)
        {
            var filter = Builders<PMLTask>.Filter.Eq("Id", task.Id);
            var update = Builders<PMLTask>.Update
                .Set("Title",task.Title)
                .Set("Description", task.Description)
                .Set("DueDate",task.DueDate)
                .Set("Completed", task.Completed)
                .Set("Parent",task.Parent)
                .Set("ListId",task.ListId);
            _task.UpdateOne(filter, update);
            return true;
        }

        public List<PMLTask> GetByListId(string id)
        {
            List<PMLTask> taskList = _task.Find(x => x.ListId == id).ToList();
            return taskList;
        }
    }
}
