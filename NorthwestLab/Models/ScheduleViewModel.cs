using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    public class ScheduleViewModel
    {
        public ScheduleViewModel()
        {
            Tests = new List<TestScheduleViewModel>();
        }

        public int ID { get; set; }
        public List<TestScheduleViewModel> Tests { get; set; }
    }
}