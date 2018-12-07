using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwestLab.Models
{
    public class SamplesViewModel
    {
        public int SampleID { get; set; }

        public int OriginSampleID { get; set; }

        public int SampleSequenceID { get; set; }

        public int WorkOrderID { get; set; }
        public virtual WorkOrders WorkOrders { get; set; }

        [ForeignKey("Compounds")]
        public int CompoundID { get; set; }
        public virtual Compounds Compounds { get; set; }

        public string Appearance { get; set; }

        public double? IndicatedWeight { get; set; }

        public double? ActualWeight { get; set; }

        public double? MolecularMass { get; set; }

        public double? MaximumToleratedDose { get; set; }

        public bool IsSelected { get; set; }
    }
}