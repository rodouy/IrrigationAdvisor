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
            //Table Per Concrete Type (TPC), 
            //  all properties for each type are stored in separate tables.
            //There is no core table that contains data 
            //  common to all types in the hierarchy.
            Map(w => 
            { 
                w.ToTable("WaterInput"); 
            })
            .Map<Rain>(w => 
            {
                w.ToTable("Rain");
                w.MapInheritedProperties();
            }).Map<Models.Water.Irrigation>(w =>
            {
                w.ToTable("Irrigation");
                w.MapInheritedProperties();
            });
            ToTable("WaterInput");
            HasKey(w => w.WaterInputId);
            Property(w => w.WaterInputId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(w => w.Date)
                .IsRequired();
            Property(w => w.Input)
                .IsRequired();
            Property(w => w.CropIrrigationWeatherId)
                .IsRequired();
            
        }
    }
}