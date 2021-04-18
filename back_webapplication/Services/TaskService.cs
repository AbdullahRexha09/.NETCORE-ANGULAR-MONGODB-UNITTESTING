using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapplication.Models;

namespace webapplication.Services
{
    public class TaskService : ITaskService
    {
        private readonly AppDbContext _db;
        public TaskService(AppDbContext db)
        {
            this._db = db;
        }
        public bool Create(PMLTask task)
        {
            var item = _db.PMLTask.Add(task);
            if (item.State == EntityState.Added)
            {
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(Guid id)
        {
            PMLTask task = _db.PMLTask.FirstOrDefault(x => x.Id == id);
            var item = _db.PMLTask.Remove(task);
            if (item.State == EntityState.Deleted)
            {
                _db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool ChangeStatus(Guid id) 
        {
            PMLTask task = _db.PMLTask.FirstOrDefault(x => x.Id == id);
            task.Completed = !task.Completed;
            var item = _db.PMLTask.Update(task);
            if (item.State == EntityState.Modified)
            {
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<PMLTask> GetAllTasks()
        {
            List<PMLTask> tasks = _db.PMLTask.ToList();
            foreach (var item in tasks) 
            {
                if (item.Parent != null) 
                {
                    item.ParentTask = GetById(item.Parent);
                }
            }
            return tasks;
        }
        public PMLTask GetById(Guid? id) 
        {
            PMLTask pMLTask = _db.PMLTask.First(x => x.Id == id);
            return pMLTask;
        }

        public bool Update(PMLTask task)
        {
            var item = _db.PMLTask.Update(task);
            if (item.State == EntityState.Modified)
            {
                _db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
