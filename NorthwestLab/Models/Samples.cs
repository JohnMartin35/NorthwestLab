﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("Samples")]
    public class Samples
    {
        public int SampleID { get; set; }
        public int SampleSequenceID { get; set; }

        public int CompoundID { get; set; }
        public virtual Compounds Compounds { get; set; }

        public int CompoundReceiptID { get; set; }
        public virtual CompoundReceipts CompoundReceipts { get; set; }

        public int AssayID { get; set; }
        public virtual Assays Assays { get; set; }

        public string Appearance { get; set; }

        public double IndicatedWeight { get; set; }

        public double ActualWeight { get; set; }

        public double MolecularMass { get; set; }

        public double MaximumToleratedDose { get; set; }
    }
}