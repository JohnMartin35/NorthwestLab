using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("QuantitativeFileTypes")]
    public class QuantitativeFileTypes
    {
        public int QuantitativeFileTypeID { get; set; }
        public string Type { get; set; }
    }
}