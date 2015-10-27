using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Water;

namespace IrrigationAdvisor.DBContext.Water
{
    public class WaterInputConfiguration:
        EntityTypeConfiguration<WaterInput>
    {
        public WaterInputConfiguration()
        {
            ToTable("WaterInput");
            HasKey(w => w.WaterInputId);
            Property(w => w.WaterInputId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(w => w.Date)
                .IsRequired();
            Property(w => w.Input)
                .IsRequired();

        }
    }
}