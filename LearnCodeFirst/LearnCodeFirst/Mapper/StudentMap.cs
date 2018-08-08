using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace LearnCodeFirst.Mapper
{
    public class StudentMap : EntityTypeConfiguration<Entity.Student>
    {
       public StudentMap()
        {
            ToTable("StudentTable");
            HasKey(x => x.StudentUQId);
            Property(x => x.StudentUQId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).HasColumnName("Id");
            Property(x => x.Name).HasColumnName("StudentName").HasMaxLength(50).IsRequired();
        }
    }
}