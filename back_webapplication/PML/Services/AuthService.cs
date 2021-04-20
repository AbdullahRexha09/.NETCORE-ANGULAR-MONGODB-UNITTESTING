using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapplication.Models;

namespace webapplication.Services
{
    public class AuthService : IAuthService
    {
        private readonly IMongoCollection<User> _user;


        public AuthService(IPMLDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _user = database.GetCollection<User>(settings.UserCollectionName);
        }

        public User GetUser(string email, string password)
        {
            var foundItem = _user.Find(u => u.Email == email && u.Password == password).FirstOrDefault();
            return foundItem;
        }

        public bool Register(User user)
        {
            if (_user.Find(u => u.Email == user.Email).FirstOrDefault() != null)
            {
                return false;
            }
            _user.InsertOne(user);

            return true;

        }
        public User GetUserFromEmail(string email)
        {
            var user = _user.Find(e => e.Email == email).FirstOrDefault();
            return user;
        }
        public bool UpdateUser(User user)
        {
            var filter = Builders<User>.Filter.Eq("Id", user.Id);
            var update = Builders<User>.Update
                .Set("FirstName", user.FirstName)
                .Set("LastName", user.LastName)
                .Set("Email", user.Email)
                .Set("Password", user.Password)
                .Set("RefreshTokenExpiryTime", user.RefreshTokenExpiryTime)
                .Set("Role", user.Role)
                .Set("Status", user.Status);
            _user.UpdateOne(filter, update);
            return true;
        }
    }
}
