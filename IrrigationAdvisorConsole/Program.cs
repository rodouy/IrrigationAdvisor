using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

using IrrigationAdvisor.DBContext;

using System.Data.Entity;

namespace IrrigationAdvisorConsole
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            //IASystem IASystem = new IrrigationAdvisorConsole.IASystem();

            #if false
            Database.SetInitializer < IrrigationAdvisorContext>
                (new DropCreateDatabaseIfModelChanges<IrrigationAdvisorContext>());
            #endif
            
            /*
             * Changing from DropCreateDatabaseIfModelChanges to DropCreateDatabaseAlways works, 
             * the latter configuration causes the database to be recreated no matter what, 
             * bypassing any sort of database versioning that might be causing an error.
             */
            #if true
            Database.SetInitializer<IrrigationAdvisorContext>
                (new DropCreateDatabaseAlways<IrrigationAdvisorContext>());
            #endif

            InsertLanguages();
            InsertPositions();
            InsertRegions();
            InsertCities();
            InsertCountry();

        }

        #region Language
        private static void InsertLanguages()
        {
            var lBase = new Language
            {
                Name = "Base"
            }; 
            
            var lSpanish = new Language
            {
                Name = "Spanish"
            };

            var lEnglish = new Language
            {
                Name = "English"
            };

            using (var context = new IrrigationAdvisorContext())
            {
                context.Languages.Add(lBase);
                context.Languages.Add(lSpanish);
                context.Languages.Add(lEnglish);
                context.SaveChanges();
            }
        }
        #endregion

        #region Localization

        private static void InsertPositions()
        {
            var lBase = new Position()
            {
                Latitude = 0,
                Longitude = 0
            };

            var lUruguay = new Position()
            {
                Latitude = -32.523,
                Longitude = -55.766
            };

            var lRegionSur = new Position()
            {
                Latitude = -33.874333,
                Longitude = -56.009694
            };

            var lRegionNorte = new Position()
            {
                Latitude = -31.381117,
                Longitude = -56.539784
            };

            var lMontevideo = new Position()
            {
                Latitude = -34.9019718,
                Longitude = -56.1640629
            };

            var lMinas = new Position()
            {
                Latitude = -34.366747,
                Longitude = -55.233317
            };

            var lSantaLucia = new Position()
            {
                Latitude = -34.232518,
                Longitude = -55.541477
            };

            using (var context = new IrrigationAdvisorContext())
            {
                context.Positions.Add(lBase);
                context.Positions.Add(lUruguay);
                context.Positions.Add(lRegionSur);
                context.Positions.Add(lRegionNorte);
                context.Positions.Add(lMontevideo);
                context.Positions.Add(lMinas);
                context.Positions.Add(lSantaLucia);
                context.SaveChanges();
            }
        }
        
        private static void InsertRegions()
        {
            var lBase = new Region
            {
                Name = "Base",
                PositionId = 0,
                EffectiveRainList = null,
                SpecieList = null,
                SpecieCycleList = null
            };

            var lSur = new Region 
            {
                Name = "Sur",
                PositionId = 2,
                EffectiveRainList = null,
                SpecieList = null,
                SpecieCycleList = null 
            };

            var lNorte = new Region
            {
                Name = "Norte",
                PositionId = 3,
                EffectiveRainList = null,
                SpecieList = null,
                SpecieCycleList = null
            };
            using (var context = new IrrigationAdvisorContext())
            {
                context.Regions.Add(lBase);
                context.Regions.Add(lSur);
                context.Regions.Add(lNorte);
                context.SaveChanges();
            }
        }

        private static void InsertCities()
        {
            var lBase = new City
            {
                Name = "Base",
                PositionId = 0,
                CountryId = 0
            };

            var lMontevideo = new City
            {
                Name = "Montevideo",
                PositionId = 4,
                CountryId = 1
            };

            var lMinas = new City
            {
                Name = "Minas",
                PositionId = 5,
                CountryId = 1
            };
        }

        private static void InsertCountry()
        {
            var lBase = new Country
            {
                Name = "Base",
                CapitalId = 0,
                LanguageId = 0
            };

            var lUruguay = new Country
            {
                Name = "Uruguay",
                CapitalId = 4,
                LanguageId = 1,
                RegionList = null,
                CityList = null,
                
            };

            using(var context = new IrrigationAdvisorContext())
            {
                context.Countries.Add(lBase);
                context.Countries.Add(lUruguay);
                context.SaveChanges();
            }
        }

        #endregion

        #region Agriculture
        #if false

        private static void InsertSpecieCycles()
        {
            var lBase = new SpecieCycle
            {
                Name = "Base"
            };

            var lCorto = new SpecieCycle
            {
                Name = "Corto"
            };

            var lUnico = new SpecieCycle
            {
                Name = "Unico"
            };

            using (var context = new IrrigationAdvisorContext())
            {
                context.SpecieCycles.Add(lBase);
                context.SpecieCycles.Add(lCorto);
                context.SpecieCycles.Add(lUnico);
                context.SaveChanges();
            }
        }

        private static void InsertSpecies()
        {
            var lBase = new Specie
            {
                Name = "Base",
                SpecieCycleId = 0,
                BaseTemperature = 0,
                StressTemperature = 0
            };

            var lMaiz = new Specie
            {
                Name = "Maiz",
                SpecieCycleId = 1,
                BaseTemperature = 10,
                StressTemperature = 40
            };

            var lSoja = new Specie
            {
                Name = "Soja",
                SpecieCycleId = 1,
                BaseTemperature = 8,
                StressTemperature = 40
            };

            using (var context = new IrrigationAdvisorContext())
            {
                context.Species.Add(lBase);
                context.Species.Add(lMaiz);
                context.Species.Add(lSoja);
                context.SaveChanges();
            };
        }

        #endif
        #endregion


       

    }

    public class IASystem 
    {
        
        public IrrigationSystem IrrigationAdvSystem { get; set; }
        
        public IASystem()
        {
            IrrigationAdvSystem = IrrigationSystem.Instance;
        }

    }
}
