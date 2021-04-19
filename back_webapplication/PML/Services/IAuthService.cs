using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapplication.Models;

namespace webapplication.Services
{
    public interface IAuthService
    {
        bool Register(User user);
        User GetUser(string email, string password);
        User GetUserFromEmail(string email);
        bool UpdateUser(User user);
    }
}
