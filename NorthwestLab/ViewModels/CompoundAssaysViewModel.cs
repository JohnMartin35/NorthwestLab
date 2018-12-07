using NorthwestLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLab.ViewModels
{
    public class CompoundAssaysViewModel
    {
        public List<Assays> assaysList { get; set; }
        public Compounds newCompound { get; set; }
    }
}