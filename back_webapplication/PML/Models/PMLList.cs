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
    public class PMLList
    {
        [BsonId]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public List<PMLTask> PMLTask { get; set; }

        public PMLList() 
        {
            Id = Guid.NewGuid().ToString();
        }

               
    }
}
