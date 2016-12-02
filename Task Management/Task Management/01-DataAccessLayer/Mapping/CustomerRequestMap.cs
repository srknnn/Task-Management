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
    class CustomerRequestMap : EntityTypeConfiguration<CustomerRequest>
    {
        public CustomerRequestMap()
        {
            HasKey(cr => cr.CustomerRequestID);

            Property(cr => cr.CustomerRequestID)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(cr => cr.Description)
                 .IsRequired()
                 .HasColumnType("Varchar");

            Property(cr => cr.RequestType)
                .IsRequired()
                .HasColumnType("bit");

            Property(cr => cr.RequestDate)
                .IsRequired()
                .HasColumnType("Date");

            Property(cr => cr.isActive)
                .IsRequired()
                .HasColumnType("bit");

            HasRequired(cr => cr.Project)
            .WithMany()
            .HasForeignKey(cr => cr.ProjectID);

            HasRequired(cr => cr.Employee)
            .WithMany()
            .HasForeignKey(cr => cr.EmployeeID);

        }
    }
}
