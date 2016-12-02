using _01_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer.Mapping
{
    class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            HasKey(c => c.EmployeeID);

            Property(p => p.EmployeeID)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.FirstName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(p => p.LastName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            HasRequired(p => p.EmployeeType)
                .WithMany()
                .HasForeignKey(p => p.EmployeeTypeID);

            Property(p => p.Phone)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(20);

            Property(p => p.EMail)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(p => p.Password)
                 .IsRequired()
                 .HasColumnType("varchar")
                 .HasMaxLength(50);

            Ignore(p => p.FullName);

            Property(p => p.isDelected)
                .IsRequired()
                .HasColumnType("bit");

            // Sql' de görünmeyecek. Entity içinde tanımladık.


        }
    }
}
