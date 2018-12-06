using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("ConditionalDependencies")]
    public class ConditionalDependencies
    {
        [Key]
        public int ConditionalDependencyID  { get; set; }

        [ForeignKey("AssayTestTypeSuccessor")]
        public int AssayTestTypeSuccessorID { get; set; }
        public virtual AssayTestTypes AssayTestTypeSuccessor { get; set; }

        [ForeignKey("AssayTestTypePredecessor")]
        public int AssayTestTypePredecessorID { get; set; }
        public virtual AssayTestTypes AssayTestTypePredecessor { get; set; }

        public string TriggerConditions { get; set; }

    }
}