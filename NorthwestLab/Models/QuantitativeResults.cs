using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("QuantitativeResults")]
    public class QuantitativeResults
    {
        public int QuantitativeResultID { get; set; }

        public int QuantitativeFileTypeID { get; set; }
        public virtual QuantitativeFileTypes QuantitativeFileTypes { get; set; }

        public string FileLocation { get; set; }
    }
}