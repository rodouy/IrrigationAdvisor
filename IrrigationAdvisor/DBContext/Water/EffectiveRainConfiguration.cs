using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Water;

namespace IrrigationAdvisor.DBContext.Water
{
    public class EffectiveRainConfiguration:
        EntityTypeConfiguration<EffectiveRain>
    {
        public EffectiveRainConfiguration()
        {
            ToTable("EffectiveRain");
            HasKey(w => w.EffectiveRainId);
            Property(w => w.EffectiveRainId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(w => w.Month)
                .IsRequired();
            Property(w => w.MaxRain)
                .IsRequired();
            Property(w => w.MinRain)
                .IsRequired();
            Property(w => w.Percentage)
                .IsRequired();
            
        }
    }
}