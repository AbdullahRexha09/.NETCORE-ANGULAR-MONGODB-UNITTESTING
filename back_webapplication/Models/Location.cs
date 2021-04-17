using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace webapplication.Models
{
    public class Location
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Column("name"), StringLength(20)]
        public string Name { get; set; }
        [Column("address"), StringLength(50)]
        public string Address { get; set; }
        [Column("cityid"), StringLength(60)]
        [ForeignKey("City")]
        public Guid CityId { get; set; }

        #region
        public virtual City City { get; set; }
        #endregion

    }
}
