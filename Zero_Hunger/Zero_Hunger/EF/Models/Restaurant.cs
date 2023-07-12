using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zero_Hunger.EF.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [ForeignKey("Collection")]
        public int CollectionId { get; set; }
        public virtual Collection Collection { get; set; }

        public virtual ICollection<Distribution> Distributions { get; set; }

        public Restaurant()
        {
            Distributions = new List<Distribution>();
        }
    }
}