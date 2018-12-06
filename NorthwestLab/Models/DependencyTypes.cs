using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("DependencyTypes")]
    public class DependencyTypes
    {
        [Key]
        public int DependencyID { get; set; }
        public string Type { get; set; }
    }
}