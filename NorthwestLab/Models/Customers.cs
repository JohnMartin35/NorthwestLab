﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("Customers")]
    public class Customers
    {
        [Key]
        public int CustomerID { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [DisplayName("Company Name")]
        [Required(ErrorMessage="Company Name is required")]
        [StringLength(75)]
        public string CompanyName { get; set; }

        [DisplayName("Street Address")]
        [Required(ErrorMessage = "Street address is required")]
        [StringLength(75)]
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(50)]
        public string City { get; set; }
        
        
        //Foreign Key Connect to State table
        [StringLength(2)]
        public int State_ProvinceID { get; set; }
        public virtual State_Province State_Province { get; set; }

        [Display(Name = "Zip Code"), Required(ErrorMessage = "Zip code is required")]
        [RegularExpression(@"^\d{5}-\d{4}|\d{5}$", ErrorMessage = "Zip Code must be 5 (#####) or 9 digits (#####-####)")]
        public string Zip { get; set; }

        public string Notes { get; set; }

        [Display(Name ="Phone Number"),Required(ErrorMessage ="Phone number is required")]
        [RegularExpression(@"^\(?\d{3}[) ]?\d{3}[- ]\d{4}$", ErrorMessage = "Invalid phone number format")]
        public string Phone { get; set; }

    }
}