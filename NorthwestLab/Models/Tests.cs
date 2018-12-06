using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("Tests")]
    public class Tests
    {
        [Key]
        public int TestID { get; set; }

        public int AssayTestTypeID { get; set; }
        public virtual AssayTestTypes AssayTestTypes { get; set; }

        public int DependencyID { get; set; }
        public virtual DependencyTypes DependencyTypes { get; set; }

        public int QuantitativeResultID { get; set; }
        public virtual QuantitativeResults QuantitativeResults { get; set; }

        public int QualitativeResultID { get; set; }
        public virtual QualitativeResults QualitativeResults { get; set; }

        public bool CustomerApproval { get; set; }

        public int AssayID { get; set; }
        public virtual Assays Assays { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }
}