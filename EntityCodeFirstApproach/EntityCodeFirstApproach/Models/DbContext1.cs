using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EntityCodeFirstApproach.Models
{
    public class DbContext1:DbContext
    {
        public DbContext1()
            :base("data1")
        {

        }
        public DbSet<Catagory> Catagorytable { get; set; }
        public DbSet<Product> ProductTable { get; set; }
    }
}