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
    class TasksMap:EntityTypeConfiguration<Tasks>
    {
        public TasksMap()
        {
            HasKey(p => p.TaskID);

            Property(p => p.TaskID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(p => p.Description)
                .IsRequired()
                .HasColumnType("varchar");
               

            HasRequired(p => p.Project)
                .WithMany()
                .HasForeignKey(p => p.ProjectID)
                .WillCascadeOnDelete(false);

            Property(p => p.StartDate)
                .IsRequired()
                .HasColumnType("Date");

            Property(p => p.EndDate)
                .IsRequired()
                .HasColumnType("Date");

            HasOptional(p => p.Employee)
                .WithMany()
                .HasForeignKey(p => p.EmployeeID);

            HasRequired(p => p.Status)
                .WithMany()
                .HasForeignKey(p => p.StatusID);

            HasRequired(p => p.Manager)
                .WithMany()
                .HasForeignKey(p => p.ManagerID)
                .WillCascadeOnDelete(false);

        }
    }
}
