using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapplication.Models;

namespace webapplication.Services
{
    public class UserService : IUserService
    {
        private readonly IMongoCollection<User> _user;
        private readonly AppDbContext _db;
        public UserService(IPMLDatabaseSettings settings, AppDbContext db) 
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _user = database.GetCollection<User>(settings.UserCollectionName);
            _db = db;
        }
        public User GetUserByEmail(string email)
        {
            User user = _user.Find(x => x.Email == email).FirstOrDefault();
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
        public User GetById(string id) 
        {
            User user = _user.Find(x => x.Id == id).FirstOrDefault();
            return user;
        }
    }
}
