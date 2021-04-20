using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webapplication.Models
{
    public class User
    {
        [BsonId]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public string Role { get; set; } = "User";
        public string Status { get; set; } = "Hi there! I am using PolyDo";

        public User() 
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
