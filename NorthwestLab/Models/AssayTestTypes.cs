using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("AssayTestTypes")]
    public class AssayTestTypes
    {
        public int AssayTestTypeID { get; set; }
        public int AssayTypeID { get; set; }
        public virtual AssayTypes AssayTypes  { get; set; }
        public int TestTypeID { get; set; }
        public virtual TestTypes TestTypes { get; set; }
    }
}