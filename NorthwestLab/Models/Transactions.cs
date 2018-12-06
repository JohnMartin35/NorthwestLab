using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("Transactions")]
    public class Transactions
    {
        [Key]
        public int TransactionID { get; set; }

        public int PaymentCardID { get; set; }
        public virtual PaymentCards PaymentCards { get; set; }

        public int InvoiceID { get; set; }
        public virtual Invoices Invoices { get; set; }

        public DateTime DatePaid { get; set; }

        public double AmountPaid { get; set; }
    }
}