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
            try
            {
                //IASystem IASystem = new IrrigationAdvisorConsole.IASystem();

                #if false
                Database.SetInitializer < IrrigationAdvisorContext>
                    (new DropCreateDatabaseIfModelChanges<IrrigationAdvisorContext>());
                #endif

                #if false
                Database.SetInitializer < IrrigationAdvisorContext>
                    (new CreateDatabaseIfNotExists<IrrigationAdvisorContext>());
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

                #region Lenguage
                InsertLanguages();
                #endregion

                #region Security
                InsertUsers();
                #endregion

                #region Localization
                InsertPositions();
                InsertRegions();
                InsertCapitals();
                InsertCountry();
                InsertCities();
                InsertWeatherStations();
                InsertFarms();
                #endregion

                #region Agriculture
                InsertSpecieCycles();
                InsertSpecies();
                UpdateRegionSpecies();
                InsertStages();
                InsertEffectiveRains();
                UpdateRegionSetEffectiveRainList();
                #endregion

#if false

                
                InsertCrop();
                InsertCropCoefficient();
                InsertCropInformationByDate();
                UpdateCropCoefficientToCrop();

                InsertPhenologicalStage();
                InsertHorizons();
                InsertSoils();

                InsertBombs();
                InsertPivots();
#endif
            }
            catch (Exception ex)
            {
                Console.WriteLine("Initialization Failed...");
                Console.WriteLine(ex.Message);
            }

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
                //context.Languages.Add(lBase);
                context.Languages.Add(lSpanish);
                context.Languages.Add(lEnglish);
                context.SaveChanges();
            }
        }
        
        #endregion

        #region Security

        private static void InsertUsers()
        {
            var lBase = new User()
            {
                Name = "Base",
                Surname = "",
                Phone = "",
                Address = "",
                Email = "",
                UserName = "",
                Password = "",
            };

            var lDemo = new User()
            {
                Name = "Demo",
                Surname = "PGW Water",
                Phone = "098 938 269",
                Address = "1958 Cuareim, Montevideo",
                Email = "riegopgw@googlegroups.com",
                UserName = "demo",
                Password = "lluvia",
            };

            var lSCasanova = new User()
            {
                Name = "Sebastian",
                Surname = "Casanova",
                Phone = "098 938 269",
                Address = "1958 Cuareim, Montevideo",
                Email = "scasanova@pgwwater.com.uy",
                UserName = "scasanova",
                Password = "SCasanova",
            };

            var lAdmin = new User()
            {
                Name = "Admin",
                Surname = "PGW Water",
                Phone = "099 618 260",
                Address = "1958 Cuareim, Montevideo",
                Email = "riegopgw@googlegroups.com",
                UserName = "admin",
                Password = "Irrigation4dvis0r",
            };

            using (var context = new IrrigationAdvisorContext())
            {
                //context.Users.Add(lBase);
                context.Users.Add(lDemo);
                context.Users.Add(lSCasanova);
                context.Users.Add(lAdmin);
                context.SaveChanges();
            }
 
        }
        
        #endregion

        #region Localization
        #if true

        private static void InsertPositions()
        {
            var lBase = new Position()
            {
                Name = "Base",
                Latitude = 0,
                Longitude = 0
            };

            var lUruguay = new Position()
            {
                Name = "Uruguay",
                Latitude = -32.523,
                Longitude = -55.766
            };

            var lRegionSur = new Position()
            {
                Name = "Sur",
                Latitude = -33.874333,
                Longitude = -56.009694
            };

            var lRegionNorte = new Position()
            {
                Name = "Norte",
                Latitude = -31.381117,
                Longitude = -56.539784
            };

            var lMontevideo = new Position()
            {
                Name = "Montevideo",
                Latitude = -34.9019718,
                Longitude = -56.1640629
            };

            var lMinas = new Position()
            {
                Name = "Minas",
                Latitude = -34.366747,
                Longitude = -55.233317
            };

            var lSantaLucia = new Position()
            {
                Name = "Santa Lucia",
                Latitude = -34.232518,
                Longitude = -55.541477
            };

            var lWeatherStation = new Position()
            {
                Name = "Las Brujas WS",
                Latitude = -34.232518,
                Longitude = -55.541477
            };
            
            var lSantaLuciaWS = new Position()
            {
                Name = "Santa Lucia WS",
                Latitude = -34.232518,
                Longitude = -55.541477
            };

            using (var context = new IrrigationAdvisorContext())
            {
                //context.Positions.Add(lBase);
                context.Positions.Add(lUruguay); 
                context.Positions.Add(lRegionSur); 
                context.Positions.Add(lRegionNorte); 
                context.Positions.Add(lMontevideo); 
                context.Positions.Add(lMinas); 
                context.Positions.Add(lSantaLucia); 
                context.Positions.Add(lWeatherStation); 
                context.Positions.Add(lSantaLuciaWS); 
                context.SaveChanges();
            }
        }
        
        private static void InsertRegions()
        {
            Position lPosition = null;
            using (var context = new IrrigationAdvisorContext())
            {
                #region Base
                var lBase = new Region
                {
                    Name = "Base",
                    PositionId = 0,
                    Position = new Position(),
                    EffectiveRainList = null,
                    SpecieList = null,
                    SpecieCycleList = null
                };
                #endregion

                lPosition = (from pos in context.Positions
                               where pos.Name == "Sur"
                               select pos).FirstOrDefault();
                var lSur = new Region 
                {
                    Name = "Sur",
                    PositionId = lPosition.PositionId,
                    EffectiveRainList = null,
                    SpecieList = null,
                    SpecieCycleList = null 
                };

                lPosition = (from pos in context.Positions
                             where pos.Name == "Norte"
                             select pos).FirstOrDefault();
                var lNorte = new Region
                {
                    Name = "Norte",
                    PositionId = lPosition.PositionId,
                    EffectiveRainList = null,
                    SpecieList = null,
                    SpecieCycleList = null
                };
            
                //context.Regions.Add(lBase);
                context.Regions.Add(lSur);
                context.Regions.Add(lNorte);
                context.SaveChanges();
            }
        }

        private static void InsertCapitals()
        {
            using(var context = new IrrigationAdvisorContext())
            {
                Position lPosition = null;
                
                #region Base
                var lBase = new City
                {
                    Name = "Base",
                    PositionId = 0,
                    CountryId = 0,
                };
                #endregion

                lPosition = (from pos in context.Positions
                             where pos.Name == "Montevideo"
                             select pos).FirstOrDefault();
                var lMontevideo = new City
                {
                    Name = "Montevideo",
                    PositionId = lPosition.PositionId,
                    CountryId = 1,
                };
                
                //lMontevideo.Country.LanguageId = 1;

                //context.Cities.Add(lBase);
                context.Cities.Add(lMontevideo);
                context.SaveChanges();
            }
        }

        private static void InsertCountry()
        {
            Position lPosition = null;
            City lCity = null;
            Language lLanguage = null;

            using (var context = new IrrigationAdvisorContext())
            {
                #region Base
                var lBase = new Country
                {
                    Name = "Base",
                    CapitalId = 0,
                    LanguageId = 0,
                    CityList = null,
                    RegionList = null,
                };
                #endregion

                #region Uruguay
                lPosition = (from pos in context.Positions
                             where pos.Name == "Uruguay"
                             select pos).FirstOrDefault();

                lLanguage = (from language in context.Languages
                             where language.Name == "Spanish"
                             select language).FirstOrDefault();

                lCity = (from city in context.Cities
                         where city.Name == "Montevideo"
                         select city).FirstOrDefault();


                var lUruguay = new Country
                {
                    Name = "Uruguay",
                    LanguageId = lLanguage.LanguageId,
                    CapitalId = lCity.CityId,
                    RegionList = null,
                    CityList = new List<City>(),
                };
                lUruguay.AddCity(lCity);
                #endregion

                //context.Countries.Add(lBase);
                context.Countries.Add(lUruguay);
                context.SaveChanges();
            }
        }

        private static void InsertCities()
        {
            using (var context = new IrrigationAdvisorContext())
            {
                Position lPosition = null;
                Country lCountry = null;

                #region Base
                var lBase = new City
                {
                    Name = "Base",
                    PositionId = 0,
                    CountryId = 0,
                };
                #endregion

                lCountry = (from country in context.Countries
                            where country.Name == "Uruguay"
                            select country).FirstOrDefault();
                

                lPosition = (from pos in context.Positions
                             where pos.Name == "Minas"
                             select pos).FirstOrDefault();
                var lMinas = new City
                {
                    Name = "Minas",
                    PositionId = lPosition.PositionId,
                    CountryId = lCountry.CountryId,
                };

                //context.Cities.Add(lBase);
                context.Cities.Add(lMinas);
                context.SaveChanges();
            }
        }

        #endif
        #endregion

        #region Weather.WeatherStation
        #if true

        private static void InsertWeatherStations()
        {
            Position lPosition = null;
            using (var context = new IrrigationAdvisorContext())
            {
                #region Base
                var lBase = new WeatherStation
                {
                    Name = "Base",
                    Model = "",
                    DateOfInstallation = Utils.MIN_DATETIME,
                    DateOfService =Utils.MAX_DATETIME,
                    UpdateTime = Utils.MAX_DATETIME,
                    WirelessTransmission = 0,
                    PositionId = 0,
                    GiveET = false,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.NoData,
                };
                #endregion

                #region Inia
                lPosition = (from pos in context.Positions
                             where pos.Name == "Las Brujas WS"
                             select pos).FirstOrDefault();
                var lIniaWS = new WeatherStation
                {
                    Name = "Las Brujas WS",
                    Model = "Inia 01",
                    DateOfInstallation = new DateTime(2015, 10, 01),
                    DateOfService = new DateTime(2016, 10, 01).AddMonths(6),
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                };

                #endregion

                #region SantaLucia
                lPosition = (from pos in context.Positions
                             where pos.Name == "Santa Lucia WS"
                             select pos).FirstOrDefault();
                var lSantaLuciaWS = new WeatherStation
                {
                    Name = "Santa Lucia WS",
                    Model = "",
                    DateOfInstallation = new DateTime(2015, 10, 01),
                    DateOfService = new DateTime(2015, 10, 01).AddMonths(6),
                    UpdateTime = DateTime.Now,
                    WirelessTransmission = 0,
                    PositionId = lPosition.PositionId,
                    GiveET = true,
                    WeatherDataList = null,
                    WeatherDataType = Utils.WeatherDataType.AllData,
                };
                #endregion

                //context.WeatherStations.Add(lBase);
                context.WeatherStations.Add(lIniaWS);
                context.WeatherStations.Add(lSantaLuciaWS);
                context.SaveChanges();
            };
        }

        #endif
        #endregion

        #region Localization.Farm
        #if true

        private static void InsertFarms()
        {
            #region Base
            var lBase = new Farm
            {
                Name = "Base",
                Company = "",
                Address = "",
                Phone = "",
                PositionId = 0,
                Has = 0,
                WeatherStationId = 0,
                WeatherStation = null,
                SoilList = null,
                BombList = null,
                IrrigationUnitList = null,
                UserId = 0,
            };
            #endregion

            #region SantaLucia
            WeatherStation lWeatherStation = null;
            using (var context = new IrrigationAdvisorContext())
            {
                lWeatherStation = context.WeatherStations.SingleOrDefault(
                                        ws => ws.WeatherStationId == 1);
            }
            var lSantaLucia = new Farm
            {
                Name = "Santa Lucia",
                Company = "Campo de Sol SA",
                Address = "",
                Phone = "",
                PositionId = 6,
                Has = 470,
                WeatherStationId = 1,
                WeatherStation = lWeatherStation,
                SoilList = null,
                BombList = null,
                IrrigationUnitList = null,
                UserId = 1,
            };
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {
                //context.Farms.Add(lBase);
                context.Farms.Add(lSantaLucia);
                context.SaveChanges();
            }
        }

        #endif
        #endregion

        #region Agriculture
        #if true

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
                //context.SpecieCycles.Add(lBase);
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
                //context.Species.Add(lBase);
                context.Species.Add(lMaiz);
                context.Species.Add(lSoja);
                context.SaveChanges();
            };
        }

        private static void UpdateRegionSpecies()
        {
            Region lRegion = null;
            Country lCountry = null;
            using (var context = new IrrigationAdvisorContext())
            {
                lRegion = context.Regions.SingleOrDefault(
                                    region => region.Name == "Sur");
                context.SpecieCycles.ForEachAsync(specieCycle => lRegion.AddSpecieCycle(specieCycle));
                context.Species.ForEachAsync(specie => lRegion.AddSpecie(specie));
                lCountry = context.Countries.SingleOrDefault(
                                    country => country.Name == "Uruguay");
                lCountry.RegionList.Add(lRegion);
                lRegion = context.Regions.SingleOrDefault(
                                                    region => region.Name == "Norte");
                lCountry.RegionList.Add(lRegion);
                
                context.SaveChanges();
            }
            
        }

        private static void InsertStages()
        {
            var lBase = new Stage
            {
                Name = "Base",
                Description = "",
            };

            var lStage = new Stage
            {
                Name = "Base",
                Description = "",
            };

            
            using(var context = new IrrigationAdvisorContext())
            {
                context.Stages.Add(lBase);
                context.SaveChanges();
            };
        }

        #endif
        #endregion

        #region Water
        #if true

        private static void InsertEffectiveRains()
        {
            var lBase = new EffectiveRain
            {
                Name = "Base",
                Month = 0,
                MinRain = 0,
                MaxRain = 0,
                Percentage = 0,
            };

            //January, February, March, April, May, June, July, August, September, October, November and December

            #region September
            var l0900 = new EffectiveRain { Name = "Sur0900", Month = 09, MinRain = 0, MaxRain = 10, Percentage = 90 };
            var l0911 = new EffectiveRain { Name = "Sur0911", Month = 09, MinRain = 11, MaxRain = 20, Percentage = 85 };
            var l0921 = new EffectiveRain { Name = "Sur0921", Month = 09, MinRain = 21, MaxRain = 30, Percentage = 80 };
            var l0931 = new EffectiveRain { Name = "Sur0931", Month = 09, MinRain = 31, MaxRain = 40, Percentage = 75 };
            var l0941 = new EffectiveRain { Name = "Sur0941", Month = 09, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l0951 = new EffectiveRain { Name = "Sur0951", Month = 09, MinRain = 51, MaxRain = 60, Percentage = 70 };
            var l0961 = new EffectiveRain { Name = "Sur0961", Month = 09, MinRain = 61, MaxRain = 70, Percentage = 65 };
            var l0971 = new EffectiveRain { Name = "Sur0971", Month = 09, MinRain = 71, MaxRain = 80, Percentage = 60 };
            var l0981 = new EffectiveRain { Name = "Sur0981", Month = 09, MinRain = 81, MaxRain = 90, Percentage = 60 };
            var l0991 = new EffectiveRain { Name = "Sur0991", Month = 09, MinRain = 91, MaxRain = 100, Percentage = 55 };
            var l09101 = new EffectiveRain { Name = "Sur09101", Month = 09, MinRain = 101, MaxRain = 1000, Percentage = 50 };
            #endregion

            #region October
            var l1000 = new EffectiveRain { Name = "Sur1000", Month = 10, MinRain = 0, MaxRain = 10, Percentage = 90 };
            var l1011 = new EffectiveRain { Name = "Sur1011", Month = 10, MinRain = 11, MaxRain = 20, Percentage = 85 };
            var l1021 = new EffectiveRain { Name = "Sur1021", Month = 10, MinRain = 21, MaxRain = 30, Percentage = 80 };
            var l1031 = new EffectiveRain { Name = "Sur1031", Month = 10, MinRain = 31, MaxRain = 40, Percentage = 75 };
            var l1041 = new EffectiveRain { Name = "Sur1041", Month = 10, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l1051 = new EffectiveRain { Name = "Sur1051", Month = 10, MinRain = 51, MaxRain = 60, Percentage = 70 };
            var l1061 = new EffectiveRain { Name = "Sur1061", Month = 10, MinRain = 61, MaxRain = 70, Percentage = 65 };
            var l1071 = new EffectiveRain { Name = "Sur1071", Month = 10, MinRain = 71, MaxRain = 80, Percentage = 60 };
            var l1081 = new EffectiveRain { Name = "Sur1081", Month = 10, MinRain = 81, MaxRain = 90, Percentage = 60 };
            var l1091 = new EffectiveRain { Name = "Sur1091", Month = 10, MinRain = 91, MaxRain = 100, Percentage = 55 };
            var l10101 = new EffectiveRain { Name = "Sur10101", Month = 10, MinRain = 101, MaxRain = 1000, Percentage = 50 };
            #endregion

            #region November
            var l1100 = new EffectiveRain { Name = "Sur1100", Month = 10, MinRain = 0, MaxRain = 10, Percentage = 90 };
            var l1111 = new EffectiveRain { Name = "Sur1111", Month = 11, MinRain = 11, MaxRain = 20, Percentage = 85 };
            var l1121 = new EffectiveRain { Name = "Sur1121", Month = 11, MinRain = 21, MaxRain = 30, Percentage = 85 };
            var l1131 = new EffectiveRain { Name = "Sur1131", Month = 11, MinRain = 31, MaxRain = 40, Percentage = 80 };
            var l1141 = new EffectiveRain { Name = "Sur1141", Month = 11, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l1151 = new EffectiveRain { Name = "Sur1151", Month = 11, MinRain = 51, MaxRain = 60, Percentage = 75 };
            var l1161 = new EffectiveRain { Name = "Sur1161", Month = 11, MinRain = 61, MaxRain = 70, Percentage = 70 };
            var l1171 = new EffectiveRain { Name = "Sur1171", Month = 11, MinRain = 71, MaxRain = 80, Percentage = 70 };
            var l1181 = new EffectiveRain { Name = "Sur1181", Month = 11, MinRain = 81, MaxRain = 90, Percentage = 70 };
            var l1191 = new EffectiveRain { Name = "Sur1191", Month = 11, MinRain = 91, MaxRain = 100, Percentage = 70 };
            var l11101 = new EffectiveRain { Name = "Sur11101", Month = 11, MinRain = 101, MaxRain = 1000, Percentage = 65 };
            #endregion

            #region December
            var l1200 = new EffectiveRain { Name = "Sur1200", Month = 12, MinRain = 0, MaxRain = 10, Percentage = 90 };
            var l1211 = new EffectiveRain { Name = "Sur1211", Month = 12, MinRain = 11, MaxRain = 20, Percentage = 85 };
            var l1221 = new EffectiveRain { Name = "Sur1221", Month = 12, MinRain = 21, MaxRain = 30, Percentage = 85 };
            var l1231 = new EffectiveRain { Name = "Sur1231", Month = 12, MinRain = 31, MaxRain = 40, Percentage = 80 };
            var l1241 = new EffectiveRain { Name = "Sur1241", Month = 12, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l1251 = new EffectiveRain { Name = "Sur1251", Month = 12, MinRain = 51, MaxRain = 60, Percentage = 75 };
            var l1261 = new EffectiveRain { Name = "Sur1261", Month = 12, MinRain = 61, MaxRain = 70, Percentage = 70 };
            var l1271 = new EffectiveRain { Name = "Sur1271", Month = 12, MinRain = 71, MaxRain = 80, Percentage = 70 };
            var l1281 = new EffectiveRain { Name = "Sur1281", Month = 12, MinRain = 81, MaxRain = 90, Percentage = 70 };
            var l1291 = new EffectiveRain { Name = "Sur1291", Month = 12, MinRain = 91, MaxRain = 100, Percentage = 70 };
            var l12101 = new EffectiveRain { Name = "Sur12101", Month = 12, MinRain = 101, MaxRain = 1000, Percentage = 60 };
            #endregion

            #region January
            var l0100 = new EffectiveRain { Name = "Sur0100", Month = 01, MinRain = 0, MaxRain = 10, Percentage = 90 };
            var l0111 = new EffectiveRain { Name = "Sur0111", Month = 01, MinRain = 11, MaxRain = 20, Percentage = 85 };
            var l0121 = new EffectiveRain { Name = "Sur0121", Month = 01, MinRain = 21, MaxRain = 30, Percentage = 85 };
            var l0131 = new EffectiveRain { Name = "Sur0131", Month = 01, MinRain = 31, MaxRain = 40, Percentage = 80 };
            var l0141 = new EffectiveRain { Name = "Sur0141", Month = 01, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l0151 = new EffectiveRain { Name = "Sur0151", Month = 01, MinRain = 51, MaxRain = 60, Percentage = 75 };
            var l0161 = new EffectiveRain { Name = "Sur0161", Month = 01, MinRain = 61, MaxRain = 70, Percentage = 70 };
            var l0171 = new EffectiveRain { Name = "Sur0171", Month = 01, MinRain = 71, MaxRain = 80, Percentage = 70 };
            var l0181 = new EffectiveRain { Name = "Sur0181", Month = 01, MinRain = 81, MaxRain = 90, Percentage = 70 };
            var l0191 = new EffectiveRain { Name = "Sur0191", Month = 01, MinRain = 91, MaxRain = 100, Percentage = 70 };
            var l01101 = new EffectiveRain { Name = "Sur01101", Month = 01, MinRain = 101, MaxRain = 1000, Percentage = 60 };
            #endregion

            #region February
            var l0200 = new EffectiveRain { Name = "Sur0200", Month = 02, MinRain = 00, MaxRain = 10, Percentage = 90 };
            var l0211 = new EffectiveRain { Name = "Sur0211", Month = 02, MinRain = 11, MaxRain = 20, Percentage = 85 };
            var l0221 = new EffectiveRain { Name = "Sur0221", Month = 02, MinRain = 21, MaxRain = 30, Percentage = 85 };
            var l0231 = new EffectiveRain { Name = "Sur0231", Month = 02, MinRain = 31, MaxRain = 40, Percentage = 80 };
            var l0241 = new EffectiveRain { Name = "Sur0241", Month = 02, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l0251 = new EffectiveRain { Name = "Sur0251", Month = 02, MinRain = 51, MaxRain = 60, Percentage = 75 };
            var l0261 = new EffectiveRain { Name = "Sur0261", Month = 02, MinRain = 61, MaxRain = 70, Percentage = 70 };
            var l0271 = new EffectiveRain { Name = "Sur0271", Month = 02, MinRain = 71, MaxRain = 80, Percentage = 70 };
            var l0281 = new EffectiveRain { Name = "Sur0281", Month = 02, MinRain = 81, MaxRain = 90, Percentage = 70 };
            var l0291 = new EffectiveRain { Name = "Sur0291", Month = 02, MinRain = 91, MaxRain = 100, Percentage = 70 };
            var l02101 = new EffectiveRain { Name = "Sur02101", Month = 02, MinRain = 101, MaxRain = 1000, Percentage = 60 };
            #endregion

            #region March
            var l0300 = new EffectiveRain { Name = "Sur0300", Month = 03, MinRain = 00, MaxRain = 10, Percentage = 90 };
            var l0311 = new EffectiveRain { Name = "Sur0311", Month = 03, MinRain = 11, MaxRain = 20, Percentage = 80 };
            var l0321 = new EffectiveRain { Name = "Sur0321", Month = 03, MinRain = 21, MaxRain = 30, Percentage = 75 };
            var l0331 = new EffectiveRain { Name = "Sur0331", Month = 03, MinRain = 31, MaxRain = 40, Percentage = 75 };
            var l0341 = new EffectiveRain { Name = "Sur0341", Month = 03, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l0351 = new EffectiveRain { Name = "Sur0351", Month = 03, MinRain = 51, MaxRain = 60, Percentage = 70 };
            var l0361 = new EffectiveRain { Name = "Sur0361", Month = 03, MinRain = 61, MaxRain = 70, Percentage = 65 };
            var l0371 = new EffectiveRain { Name = "Sur0371", Month = 03, MinRain = 71, MaxRain = 80, Percentage = 60 };
            var l0381 = new EffectiveRain { Name = "Sur0381", Month = 03, MinRain = 81, MaxRain = 90, Percentage = 60 };
            var l0391 = new EffectiveRain { Name = "Sur0391", Month = 03, MinRain = 91, MaxRain = 100, Percentage = 55 };
            var l03101 = new EffectiveRain { Name = "Sur03101", Month = 03, MinRain = 101, MaxRain = 1000, Percentage = 50 };
            #endregion

            #region April
            var l0400 = new EffectiveRain { Name = "Sur0400", Month = 04, MinRain = 0, MaxRain = 10, Percentage = 90 };
            var l0411 = new EffectiveRain { Name = "Sur0411", Month = 04, MinRain = 11, MaxRain = 20, Percentage = 80 };
            var l0421 = new EffectiveRain { Name = "Sur0421", Month = 04, MinRain = 21, MaxRain = 30, Percentage = 75 };
            var l0431 = new EffectiveRain { Name = "Sur0431", Month = 04, MinRain = 31, MaxRain = 40, Percentage = 75 };
            var l0441 = new EffectiveRain { Name = "Sur0441", Month = 04, MinRain = 41, MaxRain = 50, Percentage = 75 };
            var l0451 = new EffectiveRain { Name = "Sur0451", Month = 04, MinRain = 51, MaxRain = 60, Percentage = 70 };
            var l0461 = new EffectiveRain { Name = "Sur0461", Month = 04, MinRain = 61, MaxRain = 70, Percentage = 65 };
            var l0471 = new EffectiveRain { Name = "Sur0471", Month = 04, MinRain = 71, MaxRain = 80, Percentage = 60 };
            var l0481 = new EffectiveRain { Name = "Sur0481", Month = 04, MinRain = 81, MaxRain = 90, Percentage = 60 };
            var l0491 = new EffectiveRain { Name = "Sur0491", Month = 04, MinRain = 91, MaxRain = 100, Percentage = 55 };
            var l04101 = new EffectiveRain { Name = "Sur04101", Month = 04, MinRain = 101, MaxRain = 1000, Percentage = 50 };
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {
                //context.EffectiveRain.Add(lBase);

                #region September
                context.EffectiveRains.Add(l0900);
                context.EffectiveRains.Add(l0911);
                context.EffectiveRains.Add(l0921);
                context.EffectiveRains.Add(l0931);
                context.EffectiveRains.Add(l0941);
                context.EffectiveRains.Add(l0951);
                context.EffectiveRains.Add(l0961);
                context.EffectiveRains.Add(l0971);
                context.EffectiveRains.Add(l0981);
                context.EffectiveRains.Add(l0991);
                context.EffectiveRains.Add(l09101);
                #endregion

                #region October
                context.EffectiveRains.Add(l1000);
                context.EffectiveRains.Add(l1011);
                context.EffectiveRains.Add(l1021);
                context.EffectiveRains.Add(l1031);
                context.EffectiveRains.Add(l1041);
                context.EffectiveRains.Add(l1051);
                context.EffectiveRains.Add(l1061);
                context.EffectiveRains.Add(l1071);
                context.EffectiveRains.Add(l1081);
                context.EffectiveRains.Add(l1091);
                context.EffectiveRains.Add(l10101);
                #endregion

                #region November
                context.EffectiveRains.Add(l1100);
                context.EffectiveRains.Add(l1111);
                context.EffectiveRains.Add(l1121);
                context.EffectiveRains.Add(l1131);
                context.EffectiveRains.Add(l1141);
                context.EffectiveRains.Add(l1151);
                context.EffectiveRains.Add(l1161);
                context.EffectiveRains.Add(l1171);
                context.EffectiveRains.Add(l1181);
                context.EffectiveRains.Add(l1191);
                context.EffectiveRains.Add(l11101);
                #endregion

                #region December
                context.EffectiveRains.Add(l1200);
                context.EffectiveRains.Add(l1211);
                context.EffectiveRains.Add(l1221);
                context.EffectiveRains.Add(l1231);
                context.EffectiveRains.Add(l1241);
                context.EffectiveRains.Add(l1251);
                context.EffectiveRains.Add(l1261);
                context.EffectiveRains.Add(l1271);
                context.EffectiveRains.Add(l1281);
                context.EffectiveRains.Add(l1291);
                context.EffectiveRains.Add(l12101);
                #endregion

                #region January
                context.EffectiveRains.Add(l0100);
                context.EffectiveRains.Add(l0111);
                context.EffectiveRains.Add(l0121);
                context.EffectiveRains.Add(l0131);
                context.EffectiveRains.Add(l0141);
                context.EffectiveRains.Add(l0151);
                context.EffectiveRains.Add(l0161);
                context.EffectiveRains.Add(l0171);
                context.EffectiveRains.Add(l0181);
                context.EffectiveRains.Add(l0191);
                context.EffectiveRains.Add(l01101);
                #endregion

                #region February
                context.EffectiveRains.Add(l0200);
                context.EffectiveRains.Add(l0211);
                context.EffectiveRains.Add(l0221);
                context.EffectiveRains.Add(l0231);
                context.EffectiveRains.Add(l0241);
                context.EffectiveRains.Add(l0251);
                context.EffectiveRains.Add(l0261);
                context.EffectiveRains.Add(l0271);
                context.EffectiveRains.Add(l0281);
                context.EffectiveRains.Add(l0291);
                context.EffectiveRains.Add(l02101);
                #endregion

                #region March
                context.EffectiveRains.Add(l0300);
                context.EffectiveRains.Add(l0311);
                context.EffectiveRains.Add(l0321);
                context.EffectiveRains.Add(l0331);
                context.EffectiveRains.Add(l0341);
                context.EffectiveRains.Add(l0351);
                context.EffectiveRains.Add(l0361);
                context.EffectiveRains.Add(l0371);
                context.EffectiveRains.Add(l0381);
                context.EffectiveRains.Add(l0391);
                context.EffectiveRains.Add(l03101);
                #endregion

                #region April
                context.EffectiveRains.Add(l0400);
                context.EffectiveRains.Add(l0411);
                context.EffectiveRains.Add(l0421);
                context.EffectiveRains.Add(l0431);
                context.EffectiveRains.Add(l0441);
                context.EffectiveRains.Add(l0451);
                context.EffectiveRains.Add(l0461);
                context.EffectiveRains.Add(l0471);
                context.EffectiveRains.Add(l0481);
                context.EffectiveRains.Add(l0491);
                context.EffectiveRains.Add(l04101);
                #endregion
                
                context.SaveChanges();
            };
        }

        private static void UpdateRegionSetEffectiveRainList()
        {
            List<EffectiveRain> lEffectiveRainList = null;
            Region lRegion = null;
            using (var context = new IrrigationAdvisorContext())
            {
                lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                     where effectiverain.Name.StartsWith("Sur")
                                     select effectiverain)
                                     .ToList<EffectiveRain>();

                lRegion = (from region in context.Regions
                           where region.Name == "Sur"
                           select region).FirstOrDefault();

                lRegion = context.Regions.SingleOrDefault(
                                    region => region.Name == "Sur");
                lRegion.EffectiveRainList = lEffectiveRainList;
                
                //TODO: Add Effective Rains to Region 'Norte'
                lRegion = context.Regions.SingleOrDefault(
                                    region => region.Name == "Norte");
                //lRegion.EffectiveRainList = lEffectiveRainList;
                
                context.SaveChanges();
            }

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
