using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("State")]
    public class State
    {
        [Key]
        public int State_ProvinceID { get; set; }
        public string Abbriviation { get; set; }
        public string Name { get; set; }
    }
}