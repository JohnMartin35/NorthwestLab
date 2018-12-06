using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("PaymentCards")]
    public class PaymentCards
    {
        [Key]
        public int PaymentCardID { get; set; }
        public int CustomerID { get; set; }
        public virtual Customers Customers { get; set; }
        public string CardNumberHash { get; set; }
        public string CVCHash { get; set; }
        public DateTime CardExpirationDate { get; set; }
        public bool Active { get; set; }
    }
}