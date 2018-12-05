using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("MaterialTypes")]
    public class MaterialTypes
    {
        [Key]
        public int MaterialTypeID { get; set; }
        public string MaterialName { get; set; }
        public double CostPerUnit { get; set; }

    }
}