using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Localization;

namespace IrrigationAdvisor.DBContext.Localization
{
    public class CityConfiguration:
        EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            ToTable("City");
            HasKey(l => l.CityId);
            Property(l => l.CityId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(l => l.Name)
                .IsRequired()
                .HasMaxLength(50);
            
            
        }
    }
}