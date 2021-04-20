using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapplication.Models;

namespace webapplication.Services
{
    public class UserService : IUserService
    {
        public readonly AppDbContext _db;

        public UserService(AppDbContext db) 
        {
            this._db = db;
        }
        public User GetUserByEmail(string email)
        {
            User user = _db.User.FirstOrDefault(x => x.Email == email);
            return user;
        }
        public bool UpdateUser(User user)
        {
            var item = _db.User.Update(user);
            if (item.State == EntityState.Modified)
            {
                _db.SaveChanges();
                return true;
            }
            return false;

        }
        public User GetById(Guid id) 
        {
            User user = _db.User.First(x => x.Id == id);
            return user;
        }
    }
}
