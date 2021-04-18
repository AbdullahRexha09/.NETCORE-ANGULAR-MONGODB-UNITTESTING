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
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Column("title"), StringLength(200)]
        public string Title { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("duedate")]
        public DateTime DueDate { get; set; }
        [Column("completed")]
        public bool Completed { get; set; }
        [Column("parent")]
        public Guid? Parent { get; set; }
        [Column("listid")]
        public Guid ListId { get; set; }
        [NotMapped]
        public  PMLTask ParentTask { get; set; }
    }
}