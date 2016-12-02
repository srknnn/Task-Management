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
    class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            HasKey(c => c.CustomerID);

            Property(c => c.CustomerID)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.CompanyName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(c => c.ContactName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(c => c.Address)
                .IsRequired()
                .HasColumnType("varchar");

            Property(c => c.Email)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(40);

            Property(c => c.Phone)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(20);

            Property(c => c.isDeleted)
                .IsRequired()
                .HasColumnType("bit");

        }
    }
}
