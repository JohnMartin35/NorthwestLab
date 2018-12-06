using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("Employees")]
    public class Employees
    {
        [Key]
        public int EmployeeID { get; set; }

        public string UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public int State_ProvinceID { get; set; }
        public virtual State_Province State_Province { get; set; }

        public string Zip { get; set; }

        public string Phone { get; set; }

        public string Notes { get; set; }

    }
}