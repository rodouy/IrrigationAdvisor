using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Localization;

namespace IrrigationAdvisor.DBContext.Localization
{
    public class PositionConfiguration:
        EntityTypeConfiguration<Position>
    {
        public PositionConfiguration()
        {
            ToTable("Position");
            HasKey(l => l.PositionId);
            Property(l => l.PositionId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(l => l.Latitude)
                .IsRequired();
            Property(l => l.Longitude)
                .IsRequired();
            Ignore(l => l.ThePosition);
        }
    }
}