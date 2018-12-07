using NorthwestLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLab.ViewModels
{
    public class CompoundsWorkOrdersViewModel
    {
        public List<Compounds> compounds { get; set; }
        public WorkOrders workOrder { get; set; }
    }
}