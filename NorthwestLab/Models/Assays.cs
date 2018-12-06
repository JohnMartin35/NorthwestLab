using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("Assays")]
    public class Assays
    {
        [Key]
        public int AssayID { get; set; }
        public int AssayTypeID { get; set; }
        public virtual AssayTypes AssayTypes { get; set; }
        public int WorkOrderID { get; set; }
        public virtual WorkOrders WorkOrders { get; set; }
        public bool Complete { get; set; }
        public int AssayResultTypeID { get; set; }
        public virtual AssayResultTypes AssayResultTypes { get; set; }

    }
}