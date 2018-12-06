using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("Discounts")]
    public class Discounts
    {
        [Key]
        public int DiscountID { get; set; }

        public int WorkOrderID { get; set; }
        public virtual WorkOrders WorkOrders { get; set; }

        public int DiscountTypeID { get; set; }
        public virtual DiscountTypes DiscountTypes { get; set; }

        public double Value { get; set; }
    }
}