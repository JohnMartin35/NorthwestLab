using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("SampleTubes")]
    public class SampleTubes
    {
        public int SampleTubeID { get; set; }

        public int SampleID { get; set; }
        public virtual Samples Samples { get; set; }

        public int TestID { get; set; }
        public virtual Tests Tests { get; set; }

        public double Concentration { get; set; }
    }
}