using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Weather;


namespace IrrigationAdvisor.DBContext.Weather
{
    public class WeatherInformationConfiguration:
        EntityTypeConfiguration<WeatherInformation>
    {
        public WeatherInformationConfiguration()
        {
            ToTable("WeatherInformation");
            HasKey(w => w.WeatherInformationId);
            Property(w => w.WeatherInformationId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(w => w.WeatherDataId).IsRequired();
            
        }
    }
}