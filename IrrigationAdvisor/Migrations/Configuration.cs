namespace IrrigationAdvisor.Migrations
{
    using IrrigationAdvisor.Models.Agriculture;
    using IrrigationAdvisor.Models.Data;
    using IrrigationAdvisor.Models.Irrigation;
    using IrrigationAdvisor.Models.Language;
    using IrrigationAdvisor.Models.Localization;
    using IrrigationAdvisor.Models.Management;
    using IrrigationAdvisor.Models.Security;
    using IrrigationAdvisor.Models.Utilities;
    using IrrigationAdvisor.Models.Water;
    using IrrigationAdvisor.Models.Weather;

    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IrrigationAdvisor.DBContext.IrrigationAdvisorContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        
        protected override void Seed(IrrigationAdvisor.DBContext.IrrigationAdvisorContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            #region 1.-Create Languages
            #if true

            var Languages = new List<Language>
            {
                new Language { LanguageId = 1, Name = "Spanish"},
                new Language { LanguageId = 2, Name = "English"}
            };

            Languages.ForEach(lan => context.Languages.AddOrUpdate(l => l.LanguageId, lan));
            context.SaveChanges();

            #endif
            #endregion

            #region 2.-Create Positions
            #if true

            var Positions = new List<Position>
            {
                //Uruguay
                new Position { PositionId  = 1, Latitude = -32.523, Longitude = -55.766},
                //Region Sur
                new Position { PositionId  = 2, Latitude = -33.874333, Longitude = -56.009694},
                //Region Norte
                new Position { PositionId  = 3, Latitude = -31.381117, Longitude = -56.539784},
                //Montevideo
                new Position { PositionId  = 4, Latitude = -34.9019718, Longitude = -56.1640629},
                //Minas
                new Position { PositionId  = 5, Latitude = -34.366747, Longitude = -55.233317},
                //Santa Lucia
                new Position { PositionId  = 6, Latitude = -34.232518, Longitude = -55.541477}

            };

            Positions.ForEach(pos => context.Positions.AddOrUpdate(p => p.PositionId, pos));
            context.SaveChanges();

            #endif
            #endregion

            #region 3.-Create Region
            #if true

            var Regions = new List<Region>
            {
                new Region { RegionId = 1, Name = "Sur", PositionId = 2, 
                             EffectiveRainList = null, SpecieList = null},
                new Region { RegionId = 2, Name = "Norte", PositionId = 3, 
                             EffectiveRainList = null, SpecieList = null}
            };

            Regions.ForEach(reg => context.Regions.AddOrUpdate(r => r.RegionId, reg));
            context.SaveChanges();

            #endif
            #endregion

            #region 4.-Effective Rain List, Initial Tables
            #if true

            Regions[1].EffectiveRainList = InitialTables.CreateEffectiveRainListToSystem();
            context.Regions.AddOrUpdate(Regions[1]);
            context.SaveChanges();

            #endif
            #endregion

            #region 5.-Create Cities
            #if true

            var Cities = new List<City>
            {
                new City { CityId = 1, Name = "Montevideo", PositionId = 1},
                new City { CityId = 2, Name = "Minas", PositionId = 2}
            };

            Cities.ForEach(c => context.Cities.AddOrUpdate(p => p.CityId, c));
            context.SaveChanges();

            #endif
            #endregion

            #region 6.-Create Country
            #if true

            var Countries = new List<Country>
            {
                new Country { CountryId = 1, Name = "Uruguay", CapitalId = 1, LanguageId = 1}
            };

            Countries.ForEach(c => context.Countries.AddOrUpdate(p => p.CountryId, c));
            context.SaveChanges();

            #endif
            #endregion

            #region 7.-Create SpecieCycle
            #if false



            #endif
            #endregion

            #region 8.-Create Specie
            #if false

            var Species = new List<Specie>
            {
                new Specie { SpecieId = 1, Name = "Maiz", BaseTemperature = 10, StressTemperature = 40},
                new Specie { SpecieId = 2, Name = "Soja", BaseTemperature = 10, StressTemperature = 40},
            };

            Species.ForEach(sp => context.Species.AddOrUpdate(s => s.SpecieId, sp));
            context.SaveChanges();

            #endif
            #endregion

            #region 7.-Add Specie to Region (SpecieList)
            #if false

            List<Specie> lSpecieList = new List<Specie>();
            lSpecieList.Add(Species[1]);
            lSpecieList.Add(Species[2]);
            Regions[1].SpecieList = lSpecieList;
            context.Regions.AddOrUpdate(Regions[1]);
            context.SaveChanges();

            #endif
            #endregion


        }
        
    
    }
}
