using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webapplication.Models
{
    public class City
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Column("name"),StringLength(200)]
        public string Name { get; set; }
        [Column("longitude"), StringLength(10)]
        public string Longitude { get; set; }
        [Column("latitude"), StringLength(10)]
        public string Latitude { get; set; }
    }
}
