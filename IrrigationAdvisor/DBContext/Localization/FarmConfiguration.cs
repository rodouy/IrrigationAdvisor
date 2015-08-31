using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Localization;

namespace IrrigationAdvisor.DBContext.Localization
{
    public class FarmConfiguration:
        EntityTypeConfiguration<Farm>
    {
        public FarmConfiguration()
        {
            ToTable("Farm");
            HasKey(l => l.FarmId);
            Property(l => l.FarmId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(l => l.Name)
                .IsRequired()
                .HasMaxLength(50);
            
        }
    }
}