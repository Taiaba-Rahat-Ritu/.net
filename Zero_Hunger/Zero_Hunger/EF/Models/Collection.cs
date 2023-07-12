using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zero_Hunger.EF.Models
{
    public class Collection
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }
        [InverseProperty("Collection")]
        public virtual ICollection<Distribution> Distributions { get; set; }


        public Collection()
        {
            Employees = new List<Employee>();
            Restaurants = new List<Restaurant>();
            Distributions = new List<Distribution>();
        }
    }
}
