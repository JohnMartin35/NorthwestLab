using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("WorkOrders")]
    public class WorkOrders
    {
        [Key]
        public int WorkOrderID { get; set; }

        public int CustomerID { get; set; }
        public virtual Customers Customers { get; set; }

        public string Comments { get; set; }

        public DateTime DateReceived { get; set; }

        public DateTime DateDue { get; set; }
    }
}