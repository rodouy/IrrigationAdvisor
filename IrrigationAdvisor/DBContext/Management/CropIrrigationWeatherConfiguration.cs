using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using IrrigationAdvisor.Models.Management;

namespace IrrigationAdvisor.DBContext.Management
{
    public class CropIrrigationWeatherConfiguration:
        EntityTypeConfiguration<CropIrrigationWeather>
    {
        public CropIrrigationWeatherConfiguration()
        {
            ToTable("CropIrrigationWeather");
            HasKey(c => c.CropIrrigationWeatherId);
            Property(c => c.CropIrrigationWeatherId).IsRequired();
            
        }
    }
}