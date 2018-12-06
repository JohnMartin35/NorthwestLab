using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("TestMaterialTypes")]
    public class TestMaterialTypes
    {
        [Key]
        [Column(Order = 1)]
        public int TestID { get; set; }
        public virtual Tests Tests { get; set; }

        [Key]
        [Column(Order = 2)]
        public int MaterialTypeID { get; set; }
        public virtual MaterialTypes MaterialTypes { get; set; }

        public double QuantityUsed { get; set; }
    }
}