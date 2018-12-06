using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("DiscountTypes")]
    public class DiscountTypes
    {
        [Key]
        public int DiscountTypeID { get; set; }
        public string Type { get; set; }
        public string Expression { get; set; }
        public double DefaultValue { get; set; }
    }
}