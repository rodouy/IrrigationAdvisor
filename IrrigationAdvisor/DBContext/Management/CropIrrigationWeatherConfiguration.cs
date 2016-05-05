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

            #region Agriculture
            Property(m => m.SowingDate)
                .IsRequired();
            Property(m => m.HarvestDate)
                .IsRequired();
            Property(m => m.HydricBalance)
                .IsRequired();
            Property(m => m.SoilHydricVolume)
                .IsRequired();
            #endregion

            #region Calculus
            Property(m => m.DaysAfterSowing)
                .IsRequired();
            Property(m => m.GrowingDegreeDaysAccumulated)
                .IsRequired();
            #endregion

            #region Water Properties
            Property(m => m.LastWaterInputDate)
                .IsRequired();
            Property(m => m.LastBigWaterInputDate)
                .IsRequired();
            Property(m => m.LastPartialWaterInputDate)
                .IsRequired();
            Property(m => m.LastPartialWaterInput)
                .IsRequired();
            #endregion
                       
            #region Totals Properties
            Property(m => m.TotalEvapotranspirationCrop)
                .IsRequired();
            Property(m => m.TotalEffectiveRain)
                .IsRequired();
            Property(m => m.TotalRealRain)
                .IsRequired();
            Property(m => m.TotalIrrigation)
                .IsRequired();
            Property(m => m.TotalIrrigationInHydricBalance)
                .IsRequired();
            Property(m => m.TotalExtraIrrigation)
                .IsRequired();
            Property(m => m.TotalExtraIrrigationInHydricBalance)
                .IsRequired();
            #endregion

            #region Relationship
            HasRequired(m => m.Crop)
                .WithRequiredDependent();
            HasRequired(m => m.Soil)
                .WithRequiredDependent();
            HasRequired(m => m.PhenologicalStage)
                .WithRequiredDependent();
            HasRequired(m => m.IrrigationUnit)
                .WithRequiredDependent();
            HasRequired(m => m.MainWeatherStation)
                .WithRequiredDependent();
            HasRequired(m => m.AlternativeWeatherStation)
                .WithRequiredDependent();


            HasMany(m => m.EffectiveRainList)
                .WithOptional();
            HasMany(m => m.RainList)
                .WithOptional();
            HasMany(m => m.IrrigationList)
               .WithOptional();
            HasMany(m => m.EvapotranspirationCropList)
               .WithOptional();
            HasMany(m => m.DailyRecordList)
               .WithOptional();
            #endregion

            #region Extra Print Data
            Ignore(m => m.Titles);
            Ignore(m => m.Messages);
            Ignore(m => m.TitlesDaily);
            Ignore(m => m.MessagesDaily);
            #endregion

        }
    }
}