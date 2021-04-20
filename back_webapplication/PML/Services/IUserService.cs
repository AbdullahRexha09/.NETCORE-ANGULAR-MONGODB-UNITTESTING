using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapplication.Models;

namespace webapplication.Services
{
   public interface IUserService
    {
        public User GetUserByEmail(string email);
        public bool UpdateUser(User user);
        public User GetById(string id);
    }
}
