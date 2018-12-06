using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("TestTypeMaterials")]
    public class TestTypeMaterials
    {
        public int TestTypeID { get; set; }
        public virtual TestTypes TestTypes { get; set; }

        public int MaterialTypeID { get; set; }
        public virtual MaterialTypes MaterialTypes { get; set; }

        public double StandardQuantity { get; set; }
    }
}