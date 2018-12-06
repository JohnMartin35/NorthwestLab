using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("QualitativeResults")]
    public class QualitativeResults
    {
        [Key]
        public int QualitativeResultID { get; set;}
        public string Notes { get; set; }
    }
}