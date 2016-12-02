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
    class StatusMap:EntityTypeConfiguration<Status>
    {
        public StatusMap()
        {
            HasKey(s => s.StatusID);

            Property(s=>s.StatusID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//ID özelliğine otomatik artan özelliği ekledik.

            Property(s => s.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            
        }
    }
}
