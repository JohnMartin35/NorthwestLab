using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("TestTimeLog")]
    public class TestTimeLog
    {
        public int TestTimeLogID { get; set; }

        public int TestID { get; set; }
        public virtual Tests Tests { get; set; }

        public int EmployeeID { get; set; }
        public virtual Employees Employees { get; set; }

        public double HoursWorked { get; set; }
    }
}