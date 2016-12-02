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
    class EmployeeTypeMap : EntityTypeConfiguration<EmployeeType>
    {
        public EmployeeTypeMap()
        {
            HasKey(et => et.EmployeeTypeID);

            Property(et => et.EmployeeTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(et => et.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(40);
                
        }
    }
}
