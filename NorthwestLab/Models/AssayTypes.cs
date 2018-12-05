using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("AssayTypes")]
    public class AssayTypes
    {
        [Key]
        public int AssayTypeID { get; set; }
        public string AssayTitle { get; set; }
        public string Description { get; set; }
    }
}