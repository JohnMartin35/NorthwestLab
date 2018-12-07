using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("CompoundReceipts")]
    public class CompoundReceipts
    {
        [Key]
        public int CompoundReceiptID { get; set; }
        public DateTime DateArrived { get; set; }
        [ForeignKey("Employees")]
        public int ReceivedByID { get; set; }
        public virtual Employees Employees { get; set; }
    }
}