using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapplication.Models;

namespace webapplication.Services
{
    public class ListService : IListService
    {
        private readonly AppDbContext _db;
        private readonly ITaskService taskService;
        public ListService(AppDbContext db, ITaskService taskService)
        {
            this._db = db;
            this.taskService = taskService;
        }
        public bool Create(PMLList pMLList)
        {
            var item = _db.PMLList.Add(pMLList);
            if (item.State == EntityState.Added)
            {
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(Guid id)
        {
            PMLList pMLList = _db.PMLList.FirstOrDefault(x => x.Id == id);
            var item = _db.PMLList.Remove(pMLList);
            if (item.State == EntityState.Deleted)
            {
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<PMLList> GetAllLists()
        {
            List<PMLList> lists = _db.PMLList.ToList();
            foreach (var list in lists) 
            {
                list.PMLTask = taskService.GetByListId(list.Id);
            }
            return lists;
        }


        public PMLList GetById(Guid? id)
        {
            PMLList pMLList = _db.PMLList.First(x => x.Id == id);
            return pMLList;
        }

        public bool Update(PMLList pMLList)
        {
            var item = _db.PMLList.Update(pMLList);
            if (item.State == EntityState.Modified)
            {
                _db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
