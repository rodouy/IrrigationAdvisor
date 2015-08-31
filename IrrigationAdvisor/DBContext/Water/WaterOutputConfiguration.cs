using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Water;

namespace IrrigationAdvisor.DBContext.Water
{
    public class WaterOutputConfiguration:
        EntityTypeConfiguration<WaterOutput>
    {
        public WaterOutputConfiguration()
        {
            ///Table Per Concrete Type (TPC), 
            ///  all properties for each type are stored in separate tables.
            ///There is no core table that contains data 
            ///  common to all types in the hierarchy.
            ///MapInheritedProperties is essentially telling Code First that it
            ///  should remap all the properties that are inherited from the base
            ///  class to new columns in the table for the derived type.
            Map(w =>
            {
                w.ToTable("WaterOutput");
            })
            .Map<EvapotranspirationCrop>(w =>
            {
                w.ToTable("EvapotranspirationCrop");
                w.MapInheritedProperties();
            });
            ToTable("WaterOutput");
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