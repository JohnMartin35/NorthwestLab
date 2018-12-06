using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("Invoices")]
    public class Invoices
    {
        [Key]
        public int InvoiceID { get; set; }
        public int WorkOrderID { get; set; }
        public virtual WorkOrders WorkOrders { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateSent { get; set; }
        public double FinalPrice { get; set; }
    }
}