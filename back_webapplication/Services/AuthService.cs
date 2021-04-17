using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapplication.Models;

namespace webapplication.Services
{
    public class AuthService : IAuthService
    {
        public readonly AppDbContext _db;
        public AuthService(AppDbContext _db) 
        {
            this._db = _db;
        }

        public User GetUser(string email,string password)
        {
            var foundItem = _db.User.FirstOrDefault(u => u.Email == email && u.Password == password);
            return foundItem;
        }

        public  bool Register(User user)
        {
            if (_db.User.FirstOrDefault(u => u.Email == user.Email)!= null) 
            {
                return false;
            }
            var item = _db.User.Add(user);
            if (item.State == EntityState.Added) 
            {
                _db.SaveChanges();
                return true;
            }
            return false;

        }
        public User GetUserFromEmail(string email) 
        {
            var user = _db.User.FirstOrDefault(e => e.Email == email);
            return user;
        }
        public bool UpdateUser(User user) 
        {
            var userToUpdate = _db.User.Update(user);
            if (userToUpdate.State == EntityState.Modified) 
            {
                _db.SaveChanges();
                return true;
            }
            return false;            
            
        }
    }
}
