using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Water;

namespace IrrigationAdvisor.DBContext.Water
{
    public class EvapotranspirationCropConfiguration:
        EntityTypeConfiguration<EvapotranspirationCrop>
    {
        public EvapotranspirationCropConfiguration()
        {
            ToTable("EvapotranspirationCrop");
            HasKey(w => w.WaterOutputId);
            Property(w => w.WaterOutputId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(w => w.Date)
                .IsRequired();
            Property(w => w.Output)
                .IsRequired();
            Property(w => w.CropIrrigationWeatherId)
                .IsRequired();
        }
    }
}