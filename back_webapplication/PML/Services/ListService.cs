using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapplication.Models;

namespace webapplication.Services
{
    public class ListService : IListService
    {
        private readonly ITaskService taskService;
        private readonly IMongoCollection<PMLList> _list;

        public ListService(ITaskService taskService, IPMLDatabaseSettings settings)
        {
            this.taskService = taskService;
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _list = database.GetCollection<PMLList>(settings.PMLLitsCollectionName);
        }
        public bool Create(PMLList pMLList)
        {
            _list.InsertOne(pMLList);
            return true;
        }

        public bool Delete(string id)
        {
            _list.DeleteOne(x => x.Id == id);
            return true;
        }

        public List<PMLList> GetAllLists()
        {
            List<PMLList> lists = _list.Find(_ => true).ToList();
            foreach (var list in lists) 
            {
                list.PMLTask = taskService.GetByListId(list.Id);
            }
            return lists;
        }


        public PMLList GetById(string id)
        {
            PMLList pMLList = _list.Find(x => x.Id == id).FirstOrDefault();
            return pMLList;
        }

        public bool Update(PMLList pMLList)
        {
            var filter = Builders<PMLList>.Filter.Eq("Id", pMLList.Id);
            var update = Builders<PMLList>.Update
                .Set("Name", pMLList.Name)
                .Set("Description", pMLList.Description);

            _list.UpdateOne(filter, update);
            return true;
        }
    }
}
