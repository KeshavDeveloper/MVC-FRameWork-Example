using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityCodeFirstApproach.Models
{
    [Table("tblCatagory")]
    public class Catagory
    {
        [Key]
        public int CatagoryId { get; set; }
        public string CatagoryName { get; set; }
    }
}