using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapplication.Models
{
    public class TaskModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public bool Completed { get; set; }
        public string Parent { get; set; }
        public string ListId { get; set; }
    }
}
