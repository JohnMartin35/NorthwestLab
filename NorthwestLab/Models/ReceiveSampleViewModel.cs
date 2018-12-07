using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data;


namespace NorthwestLab.Models
{
    public class ReceiveSampleViewModel
    {
        public ReceiveSampleViewModel()
        {
            Samples = new List<SamplesViewModel>();
        }
        public int ID { get; set; }

        public List<SamplesViewModel> Samples { get; set; } 
    }
}