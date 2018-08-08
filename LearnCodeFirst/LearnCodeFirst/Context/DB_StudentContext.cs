using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LearnCodeFirst.Entity;
using LearnCodeFirst.Mapper;

namespace LearnCodeFirst.Context
{
    public class DB_StudentContext : DbContext
    {
        public DB_StudentContext () : base("DBStudentConnection")
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new StudentMap());
        }
    }
}