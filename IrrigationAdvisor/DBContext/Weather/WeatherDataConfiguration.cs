using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Weather;


namespace IrrigationAdvisor.DBContext.Weather
{
    public class WeatherDataConfiguration:
        EntityTypeConfiguration<WeatherData>
    {
        public WeatherDataConfiguration()
        {
            ToTable("WeatherData");
            HasKey(w => w.WeatherDataId);
            Property(w => w.WeatherDataId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(w => w.Date)
                .IsRequired();
            Property(w => w.Evapotranspiration)
                .IsRequired();
            Property(w => w.Temperature)
                .IsRequired();
            Property(w => w.TemperatureMax)
                .IsRequired();
            Property(w => w.TemperatureMin)
                .IsRequired();
            
        }
    }
}