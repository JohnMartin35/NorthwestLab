using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("Schedule")]
    public class Schedule
    {
        public int ScheduleID { get; set; }

        public int TestID { get; set; }
        public virtual Tests Tests { get; set; }

        public DateTime ScheduledStartDate { get; set; }
    }
}