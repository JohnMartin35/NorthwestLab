using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("AssayResultTypes")]
    public class AssayResultTypes
    {
        [Key]
        public int AssayResultTypeID { get; set; }
        public string Name { get; set; }
    }
}