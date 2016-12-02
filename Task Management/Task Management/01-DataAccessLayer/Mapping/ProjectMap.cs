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
    class ProjectMap:EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            HasKey(p => p.ProjectID);

            Property(p=>p.ProjectID)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//ID özelliğine otomatik artan özelliği ekledik.

            Property(p => p.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(p => p.Description)
                .IsRequired()
                .HasColumnType("varchar");
                

            Property(p => p.ProjectStartDate)
               .IsOptional()
               .HasColumnType("Date");

            Property(p => p.ProjectFinishDate)
                .IsOptional()
                .HasColumnType("Date");

            Property(p => p.RequiredStartDate)
                .IsRequired()
                .HasColumnType("Date");

            Property(p => p.RequiredEndDate)
                .IsRequired()
                .HasColumnType("Date");

            Property(p => p.isActive)
                .IsRequired()
                .HasColumnType("bit");

            Property(p => p.isDelected)
                .IsRequired()
                .HasColumnType("bit");

            HasRequired(p => p.Customer)
                .WithMany()
                .HasForeignKey(p => p.CustomerID);

            HasRequired(p => p.Employee)
                .WithMany()
                .HasForeignKey(p => p.EmployeeID)
                .WillCascadeOnDelete(false);


        }
    }
}
