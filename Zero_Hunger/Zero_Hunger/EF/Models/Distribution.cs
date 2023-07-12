using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zero_Hunger.EF.Models
{
    public class Distribution
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [ForeignKey("Collection")]
        public int CollectionId { get; set; }

        public virtual Collection Collection { get; set; }
        public virtual Employee Employee { get; set; }
    }
}