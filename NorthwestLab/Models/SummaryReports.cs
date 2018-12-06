using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("SummaryReports")]
    public class SummaryReports
    {
        [Key]
        public int SummaryReportID { get; set; }

        public int WorkOrderID { get; set; }
        public virtual WorkOrders WorkOrders { get; set; }

        public string Comments { get; set; }

        public DateTime DateCreated { get; set; }
    }
}