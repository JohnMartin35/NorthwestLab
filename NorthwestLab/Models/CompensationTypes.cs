using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("CompensationTypes")]
    public class CompensationTypes
    {
        public int CompensationTypeID { get; set; }
        public string Type { get; set; }
    }
}