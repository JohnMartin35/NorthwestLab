using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("State_Province")]
    public class State_Province
    {
        [Key]
        public int State_ProvinceID { get; set; }

       
        public string Abbreviation { get; set; }
        public string Name { get; set; }
    }
}