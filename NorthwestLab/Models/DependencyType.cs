using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("DependencyType")]
    public class DependencyType
    {
        [Key]
        public int DependencyTypeID { get; set; }
        public string Type { get; set; }
    }
}