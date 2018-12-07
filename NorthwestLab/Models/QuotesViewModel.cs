using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    public class QuotesViewModel
    {

        public int NumCompounds { get; set; }
        public IEnumerable<AssayTypes> Assays { get; set; }
        public IEnumerable<AssayTestTypes> AssayTests { get; set; }

    }
}