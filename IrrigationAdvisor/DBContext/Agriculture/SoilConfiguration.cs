using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class SoilConfiguration:
        EntityTypeConfiguration<Soil>
    {
        public SoilConfiguration()
        {
            ToTable("Soil");
            HasKey(s => s.SoilId);
            Property(s => s.SoilId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);
            Property(s => s.DepthLimit)
                .IsRequired();

        }
    }
}