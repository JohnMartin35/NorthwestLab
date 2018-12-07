using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("TestTypes")]
    public class TestTypes
    {
        [Key]
        public int TestTypeID { get; set; }
        public string TestTitle { get; set; }
        public string TestProtocol { get; set; }
        public DateTime? TimeToComplete { get; set; }
        public SqlMoney? BasePrice { get; set; }
    }
}