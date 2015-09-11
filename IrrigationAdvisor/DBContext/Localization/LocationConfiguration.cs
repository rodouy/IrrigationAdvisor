using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Localization;

namespace IrrigationAdvisor.DBContext.Localization
{
    public class LocationConfiguration:
        EntityTypeConfiguration<Location>
    {
        public LocationConfiguration()
        {
            ToTable("Location");
            HasKey(l => l.LocationId);
            Property(l => l.LocationId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(l => l.CityId)
                .IsRequired();
            Property(l => l.CountryId)
                .IsRequired();
            Property(l => l.RegionId)
                .IsRequired();
            Property(l => l.PositionId)
                .IsRequired();
            
        }
    }
}