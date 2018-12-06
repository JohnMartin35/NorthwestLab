using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("TestMaterialTypes")]
    public class TestMaterialTypes
    {
        public int TestID { get; set; }
        public virtual Tests Tests { get; set; }

        public int MaterialTypeID { get; set; }
        public virtual MaterialTypes MaterialTypes { get; set; }

        public double QuantityUsed { get; set; }
    }
}