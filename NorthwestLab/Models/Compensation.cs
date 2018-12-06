using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("Compensation")]
    public class Compensation
    {
        public int CompensationID { get; set; }
        public int EmployeeID { get; set; }
        public virtual Employees Employees { get; set; }
        public int CompensationTypeID { get; set; }
        public virtual CompensationTypes CompensationTypes { get; set; }
        public double Value { get; set; }
    }
}