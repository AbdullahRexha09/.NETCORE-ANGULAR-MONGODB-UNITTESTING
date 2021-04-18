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
        public ListService(AppDbContext db)
        {
            this._db = db;
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
            throw new NotImplementedException();
        }

        public List<PMLList> GetAllLists()
        {
            List<PMLList> lists = _db.PMLList.ToList();

            return lists;
        }


        public PMLList GetById(Guid? id)
        {
            throw new NotImplementedException();
        }

        public bool Update(PMLList pMLList)
        {
            throw new NotImplementedException();
        }
    }
}
