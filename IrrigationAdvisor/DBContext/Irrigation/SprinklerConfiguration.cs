using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Irrigation;

namespace IrrigationAdvisor.DBContext.Irrigation
{
    public class SprinklerConfiguration:
        EntityTypeConfiguration<Sprinkler>
    {
        public SprinklerConfiguration()
        {
            ToTable("Sprinkler");
            HasKey(s => s.IrrigationUnitId);
            Property(s => s.IrrigationUnitId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Name)
                .IsRequired();
            
        }
    }
}