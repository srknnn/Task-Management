using _01_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer.Mapping
{
    class ProjectEmplooyesMap:EntityTypeConfiguration<ProjectEmployees>
    {
        public ProjectEmplooyesMap()
        {
            Property(pe => pe.isEmployeeActive)
                .IsOptional()
                .HasColumnType("bit");

          
            HasRequired(pe => pe.project)
                .WithMany()
                .HasForeignKey(pe => pe.ProjectID);

            HasRequired(pe => pe.employee)
              .WithMany()
              .HasForeignKey(pe => pe.EmployeeID);


            HasKey(pe => new { pe.ProjectID, pe.EmployeeID });

        }
    }
}
