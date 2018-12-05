using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("Customer")]
    public class Customer
    {
        public int CustomerID { get; set; }
        public string UserID { get; set; }
        [DisplayName("Company Name")]
        [Required(ErrorMessage="Company Name is required")]
        public string CompanyName { get; set; }
        [DisplayName("Street Address")]
        [Required(ErrorMessage = "Street address is required")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        //Foreign Key Connect to State table
        [StringLength(2)]
        public int State_ProvinceID { get; set; }
        public virtual State State { get; set; }

        public string Zip { get; set; }
        public string Notes { get; set; }
        public string Phone { get; set; }

    }
}