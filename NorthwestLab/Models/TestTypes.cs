using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("TestTypes")]
    public class TestTypes
    {
        [Key]
        public int TestTypeID { get; set; }
        public string TestName { get; set; }
        public string TestProtocol { get; set; }
        public string TimeToComplete { get; set; }
        public double BasePrice { get; set; }
    }
}