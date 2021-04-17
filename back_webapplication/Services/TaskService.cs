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

        public PMLTask Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public PMLTask Update(PMLTask task, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
