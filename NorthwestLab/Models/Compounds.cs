using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("Compounds")]
    public class Compounds
    {
        [Key]
        public int CompoundID { get; set; }
        [DisplayName("Compound Name")]
        public string Name { get; set; }
        public int CustomerID { get; set; }

        public virtual Customers Customers { get; set; }
        public virtual ICollection<Samples> Samples { get; set; }
    }
}