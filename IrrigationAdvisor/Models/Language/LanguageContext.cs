using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models
{
    public class LanguageContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public LanguageContext() : base("name=LanguageContext")
        {
        }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Language.Language> Languages { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Localization.City> Cities { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Localization.Position> Positions { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Localization.Country> Countries { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Localization.Region> Regions { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Localization.Farm> Farms { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Irrigation.Bomb> Bombs { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Irrigation.Drip> IrrigationUnits { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.Crop> Crops { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.Specie> Species { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.CropCoefficient> CropCoefficients { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.Soil> Soils { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.SpecieCycle> SpecieCycles { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.PhenologicalStage> PhenologicalStages { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.Horizon> Horizons { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.CropInformationByDate> CropInformationByDates { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.Stage> Stages { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Water.EffectiveRain> EffectiveRains { get; set; }
    
    }
}
