using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LearnCodeFirst.Entity
{
    public class Student
    {
        [Key]
        public int StudentUQId { get; set; }
        public string Name { get; set; }
        public string Gender{ get; set; }
        public string Grade { get; set; }
    }
}