using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class HorizonConfiguration:
        EntityTypeConfiguration<Horizon>
    {
        public HorizonConfiguration()
        {
            ToTable("Horizon");
            HasKey(h => h.HorizonId);
            Property(h => h.HorizonId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(h => h.Name)
                .IsRequired()
                .HasMaxLength(50);
            
        }
    }
}