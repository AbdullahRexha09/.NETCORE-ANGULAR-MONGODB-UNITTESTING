using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webapplication.Models
{
    public class PMLTask
    {
        [BsonId]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }
        public string Parent { get; set; }
        public string ListId { get; set; }
        [NotMapped]
        public  PMLTask ParentTask { get; set; }

        public PMLTask() 
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}