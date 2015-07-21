using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;

using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Weather;

namespace IrrigationAdvisor.Models.IrrigationSystem
{
    [TestClass]
    public class IrrigationSystemTest
    {
        #region Fields Santa Lucia Test
        private Position testPositionUruguay;
        private Position testPositionRegionTemplada;
        private Position testPositionSantaLucia;
        private Position testPositionMontevideo;
        private Position testPositionMinas;
        private Language.Language testLanguage;
        private Country testCountry;
        private Region testRegion;
        private City testCapital;
        //private City testCity;
        private City testCityMinas;

        private Location testLocationSantaLucia;
        private Location testLocationMinas;
        private Specie testSpecieSoja;
        private Specie testSpecieMaiz;
        private List<Specie> testSpecieList;

        private Stage testInitialStage_Maiz;
        private Stage testInitialStage_Soja;

        //private List<Stage> testStageList_Maiz;
        //private List<Stage> testStageList_Soja;

        private PhenologicalStage testInitialPhenologicalStage_Soja;
        private PhenologicalStage testInitialPhenologicalStage_Maiz;
        private CropCoefficient testCropCoefficient_Soja;
        private CropCoefficient testCropCoefficient_Maiz;

        private List<PhenologicalStage> testPhenologicalStageList_Maiz;
        private List<PhenologicalStage> testPhenologicalStageList_Soja;
       
        private Soil testSoil_Pivot_1;
        private double testSoil_Pivot_1_DepthLimit;

        private Soil testSoil_Pivot_2;
        private double testSoil_Pivot_2_DepthLimit;

        private Soil testSoil_Pivot_3_4;
        private double testSoil_Pivot_3_4_DepthLimit;

        private Soil testSoil_Pivot_5;
        private double testSoil_Pivot_5_DepthLimit;

        private Bomb testBomb;
        private WeatherStation testWeatherStation;
        private WeatherStation testWeatherStationAlternative;
        
        
        enum SantaLuciaPivotList
        {
            Pivot2,
            Pivot3_4,
            Pivot5
        };

        private double testEfficiency_Pivot_2;
        private double testEfficiency_Pivot_3_4;
        private double testEfficiency_Pivot_5;
        private int testSurface_Pivot_2;
        private int testSurface_Pivot_3_4;
        private int testSurface_Pivot_5;

        /// <summary>
        /// Pivots to work
        /// </summary>
        private IrrigationUnit testIU_Pivot_2;
        private IrrigationUnit testIU_Pivot_3_4;
        private IrrigationUnit testIU_Pivot_5;
        
        /// <summary>
        /// Irrigations of each Irrigation Unit
        /// </summary>
        private List<Pair<DateTime, double>> testIrrigationUnit_IrrigationList_Pivot_2;
        private List<Pair<DateTime, double>> testIrrigationUnit_IrrigationList_Pivot_3_4;
        private List<Pair<DateTime, double>> testIrrigationUnit_IrrigationList_Pivot_5;

        /// <summary>
        /// Crops of each Irrigation Unit
        /// </summary>
        private List<Crop> testIrrigationUnit_CropList_Pivot_2;
        private List<Crop> testIrrigationUnit_CropList_Pivot_3_4;
        private List<Crop> testIrrigationUnit_CropList_Pivot_5;


        private Crop testCrop_Maiz_Sur;
        private Crop testCrop_Soja_Sur;

        private CropIrrigationWeather testCropIrrigationWeather_Pivot_2;
        private CropIrrigationWeather testCropIrrigationWeather_Pivot_3_4;
        private CropIrrigationWeather testCropIrrigationWeather_Pivot_5;


        private double testSojaBaseTemp;
        private double testMaizBaseTemp;
        private double testPREDETERMINATED_IRRIGATION;

        private double testMaxEvapotranspirationToIrrigate_Maiz;
        private double testMaxEvapotranspirationToIrrigate_Soja;
        private double testMinEvapotranspirationToIrrigate_Maiz;
        private double testMinEvapotranspirationToIrrigate_Soja;
        
        private double testCropDensityMaiz;
        private double testCropDensitySoja;

        /* NOT USED
        private double testCropMinDegree_Maiz;
        private double testCropMaxDegree_Maiz;
        private double testCropRootDepth_Maiz;
        private double testCropHydricBalanceDepth_Maiz;
        private double testCropMinDegree_Soja;
        private double testCropMaxDegree_Soja;
        private double testCropRootDepth_Soja;
        private double testCropHydricBalanceDepth_Soja;
        */

        private List<EffectiveRain> testEffectiveRainsList;
        //private List<PhenologicalStage> testPhenologicalStageList;
        //private Pair<Region, List<PhenologicalStage>> testPhenologicalStagesForRegion;
        //private Pair<Region, List<EffectiveRainList>> testEffectiveRainsForRegion;
        

        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot2;
        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot3_4;
        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot5;

        private DateTime testDateBeginCrop_Pivot2;
        private DateTime testDateBeginCrop_Pivot3_4;
        private DateTime testDateBeginCrop_Pivot5;

        private DateTime testDateEndCrop_Pivot2;
        private DateTime testDateEndCrop_Pivot3_4;
        private DateTime testDateEndCrop_Pivot5;

        private DateTime testWeatherDataStartDate;

        //private CropIrrigationWeatherRecord testCropIrrigationWeatherRecord_Pivot_2;
        //private CropIrrigationWeatherRecord testCropIrrigationWeatherRecord_Pivot_3_4;
        //private CropIrrigationWeatherRecord testCropIrrigationWeatherRecord_Pivot_5;

        //Log information
        private String textLogPivot2;
        private String textLogPivot3_4;
        private String textLogPivot5;

        #endregion

        private Management.IrrigationSystem testIrrigationSystem;
        /// <summary>
        /// this method is used to obtain the layout
        /// </summary>
        [TestMethod]
        public void santaLuciaTest()
        {
            testIrrigationSystem = Management.IrrigationSystem.Instance;

            #region Initial Variables

            testWeatherDataStartDate = new DateTime(2014, 10, 18);

            //Pivot Depth Limit
            testSoil_Pivot_1_DepthLimit = 40;
            testSoil_Pivot_2_DepthLimit = 40;
            testSoil_Pivot_3_4_DepthLimit = 40;
            testSoil_Pivot_5_DepthLimit = 40;

            //Pivot Begin Dates for each Pivot
            testDateBeginCrop_Pivot2 = new DateTime(2014, 10, 21);
            testDateBeginCrop_Pivot3_4 = new DateTime(2014, 11, 14);
            testDateBeginCrop_Pivot5 = new DateTime(2014, 10, 18);

            //Pivot End Dates for each Pivot
            testDateEndCrop_Pivot2 = new DateTime(2015, 3, 21);
            testDateEndCrop_Pivot3_4 = new DateTime(2015, 3, 14);
            testDateEndCrop_Pivot5 = new DateTime(2015, 3, 18);

            //Pivot Efficiency
            testEfficiency_Pivot_2 = 0.85;
            testEfficiency_Pivot_3_4 = 0.85;
            testEfficiency_Pivot_5 = 0.85;
            
            //Pivot Surface
            testSurface_Pivot_2 = 300;
            testSurface_Pivot_3_4 = 300;
            testSurface_Pivot_5 = 300;

            //Specie Base Temp
            testSojaBaseTemp = 8;
            testMaizBaseTemp = 10;

            testPREDETERMINATED_IRRIGATION = 20;

            /*
             * 2.- Densidad de cultivo:
                2.1.- Maíz:
                Predeterminada 80.000 pl/ha
                Alta: más de 90.000 pl/ha. En este caso tomar el cropCoefficient correspondiente a región Árida
                Baja: por el momento nada
 
                2.2.- Soja
                Predeterminada: 350.000 pl/ha
                Alta: más de 400.000 pl/ha. En este caso tomar cropCoefficient correspondiente a región Árida
                Baja: por el momento nada
             */
            
            testMaxEvapotranspirationToIrrigate_Maiz = 35;
            testMaxEvapotranspirationToIrrigate_Soja = 30;
            testMinEvapotranspirationToIrrigate_Maiz = 30;
            testMinEvapotranspirationToIrrigate_Soja = 25;
            testCropDensityMaiz = 80000;
            testCropDensitySoja = 350000;

            /* NOT USED
            testCropMinDegree_Maiz = 0;
            testCropMaxDegree_Maiz = 60;
            testCropRootDepth_Maiz = 5;
            testCropHydricBalanceDepth_Maiz = 15;
            testCropMinDegree_Soja = 0;
            testCropMaxDegree_Soja = 60;
            testCropRootDepth_Soja = 5;
            testCropHydricBalanceDepth_Soja = 15;
            */


            #endregion

            //1. Create position
            testPositionUruguay = new Position(-32.523, -55.766);
            testPositionRegionTemplada = new Position(-33.874333, -56.009694);
            testPositionMontevideo = new Position(-34.9019718,-56.1640629);
            testPositionMinas = new Position(-34.366747, -55.233317);
            testPositionSantaLucia = new Position(-34.232518, -55.541477);

            //2. Create Region (First create Effective Rain, Specie List)
            testRegion = testIrrigationSystem.AddRegion("Templada", testPositionRegionTemplada, null, null);
            
            //3. Create Specie 
            testSpecieMaiz = new Specie(0, "Maiz", "Unico", testMaizBaseTemp);
            testSpecieSoja = new Specie(1, "Soja", "Corto", testSojaBaseTemp);

            //4. Add Specie to SpecieList of Region
            testSpecieList = new List<Specie>();
            testSpecieList.Add(testSpecieMaiz);
            testSpecieList.Add(testSpecieSoja);
            testRegion.SpecieList = testSpecieList;

            //5. Initial Tables, Effective Rain List of Region
            testEffectiveRainsList = InitialTables.CreateEffectiveRainListToSystem();
            testRegion.EffectiveRainList = testEffectiveRainsList;

            //6. Create Crops
            testCrop_Maiz_Sur = new Crop(0, "Maiz Sur", testRegion, testSpecieMaiz, 
                                        testCropDensityMaiz,
                                        testMaxEvapotranspirationToIrrigate_Maiz,
                                        testMinEvapotranspirationToIrrigate_Maiz);
            testCrop_Soja_Sur = new Crop(1, "Soja Sur", testRegion, testSpecieSoja,
                                        testCropDensitySoja,
                                        testMaxEvapotranspirationToIrrigate_Soja,
                                        testMinEvapotranspirationToIrrigate_Soja);

            //7.  Create CropCoefficient
            testCropCoefficient_Maiz = Data.InitialTables.CreateCropCoefficientWithList_Maiz();
            testCropCoefficient_Soja = Data.InitialTables.CreateCropCoefficientWithList_Soja();

            //8.  Add CropCoefficient to Crop
            testCrop_Maiz_Sur.CropCoefficient = testCropCoefficient_Maiz;
            testCrop_Soja_Sur.CropCoefficient = testCropCoefficient_Soja;

            //9.  Create PhenologicalStage List & Add Stage List to Crop
            testPhenologicalStageList_Maiz = InitialTables.CreatePhenologicalStageListForMaiz(testCrop_Maiz_Sur);
            testPhenologicalStageList_Soja = InitialTables.CreatePhenologicalStageListForSoja(testCrop_Soja_Sur);

            //10.  Add PhenologicalStageList to Crop
            testCrop_Maiz_Sur.UpdatePhenologicalStageList(testPhenologicalStageList_Maiz);
            testCrop_Soja_Sur.UpdatePhenologicalStageList(testPhenologicalStageList_Soja);
            
            //11.  Add Crops to System
            addCrops_SantaLucia();

            //12. Create Initial Stage & Initial PhenologicalStage of Crop
            testInitialStage_Maiz = testCrop_Maiz_Sur.GetInitialStage();
            testInitialStage_Soja = testCrop_Soja_Sur.GetInitialStage();
            testInitialPhenologicalStage_Maiz = testCrop_Maiz_Sur.GetInitialPhenologicalStage();
            testInitialPhenologicalStage_Soja = testCrop_Soja_Sur.GetInitialPhenologicalStage();
            
            //13. Create Language
            testLanguage = testIrrigationSystem.AddLanguage("Spanish");

            //14. Create City (Capital)
            testCapital = testIrrigationSystem.AddCity("Montevideo", testPositionMontevideo);

            //15. Create Country (First create Capital City)
            testCountry = testIrrigationSystem.AddCountry("Uruguay", testCapital, testLanguage, null, null);
            
            //16. Create City
            testCityMinas = testIrrigationSystem.AddCity("Minas", testPositionMinas);
            testCityMinas = testIrrigationSystem.AddCityToCountry(testCountry, testCityMinas);

            //17. Create Location
            testLocationSantaLucia = testIrrigationSystem.AddLocation(testPositionSantaLucia, testCountry,
                                                                testRegion, testCityMinas);
            testLocationMinas = testIrrigationSystem.AddLocation(testPositionRegionTemplada, testCountry,
                                                                testRegion, testCityMinas);

            //18. Create Soils, Horizons
            createSoils_SantaLucia();
            
            //19.  Create Bomb 
            testBomb = testIrrigationSystem.AddBomb("Bomba Santa Lucia", 1234, DateTime.Now, DateTime.Now, testLocationSantaLucia);

            //20.  Create WeatherStation
            testWeatherStation = testIrrigationSystem.AddWeatherStation("WeatherStation Santa Lucia", "Model 1234", 
                                                                    DateTime.Now, DateTime.Now, DateTime.Now, 1, 
                                                                    testLocationSantaLucia, true);
            
            testWeatherStationAlternative = testIrrigationSystem.AddWeatherStation("WeatherStation Minas", "Model 2342",
                                                                    DateTime.Now, DateTime.Now, DateTime.Now, 1, 
                                                                    testLocationMinas, true);
            //21.  Create Irrigation Units
            createIrrigationUnits_SantaLucia();

            //22.  Create Crop Irrigation Weather
            createCropIrrigationWeatherSantaLucia();

            //Creating Crop Irrigation Weather Records
            //23.  Add Information of Weather
            ExternalData.AddWeatherData(testIrrigationSystem, testWeatherStation, testWeatherDataStartDate);

            testIrrigationSystem.InicializeCropIrrigationWeather(testCropIrrigationWeather_Pivot_2, 
                                                                testInitialPhenologicalStage_Maiz, 
                                                                testDateBeginCrop_Pivot2, testDateEndCrop_Pivot2);
            testIrrigationSystem.InicializeCropIrrigationWeather(testCropIrrigationWeather_Pivot_3_4,
                                                                testInitialPhenologicalStage_Soja,
                                                                testDateBeginCrop_Pivot3_4, testDateEndCrop_Pivot3_4);
            testIrrigationSystem.InicializeCropIrrigationWeather(testCropIrrigationWeather_Pivot_5,
                                                                testInitialPhenologicalStage_Maiz,
                                                                testDateBeginCrop_Pivot5, testDateEndCrop_Pivot5);

            
            //24.  Add Information of Rain
            addRainData();

            //25.  Add Information of Irrigation
            addIrrigationData();

            
            //Add Phenological Stege Ajustements
            PhenologicalStageChange_Pivot2 = AddListOfPhenologicalStageAdjustments(SantaLuciaPivotList.Pivot2);
            PhenologicalStageChange_Pivot3_4 = AddListOfPhenologicalStageAdjustments(SantaLuciaPivotList.Pivot3_4);
            PhenologicalStageChange_Pivot5 = AddListOfPhenologicalStageAdjustments(SantaLuciaPivotList.Pivot5);

            //Add information to Irrigation Units to calculate lIrrigationItem for each one
            AddDataIrrigationUnit(testCropIrrigationWeather_Pivot_2, SantaLuciaPivotList.Pivot2);
            AddDataIrrigationUnit(testCropIrrigationWeather_Pivot_3_4, SantaLuciaPivotList.Pivot3_4);
            AddDataIrrigationUnit(testCropIrrigationWeather_Pivot_5, SantaLuciaPivotList.Pivot5);
            
            //Layout from Irrigation Units
            textLogPivot2 = testCropIrrigationWeather_Pivot_2.OutPut;
            textLogPivot3_4 = testCropIrrigationWeather_Pivot_3_4.OutPut;
            textLogPivot5 = testCropIrrigationWeather_Pivot_5.OutPut;

            //Layout from System the daily records
            textLogPivot2 += Environment.NewLine + Environment.NewLine + testIrrigationSystem.printDailyRecordsList(testCropIrrigationWeather_Pivot_2);
            textLogPivot3_4 += Environment.NewLine + Environment.NewLine + testIrrigationSystem.printDailyRecordsList(testCropIrrigationWeather_Pivot_3_4);
            textLogPivot5 += Environment.NewLine + Environment.NewLine + testIrrigationSystem.printDailyRecordsList(testCropIrrigationWeather_Pivot_5);


            //Layout in txt format
            this.printSystemData(textLogPivot2, "IrrigationSystemTestPivot2");
            this.printSystemData(textLogPivot3_4, "IrrigationSystemTestPivot3_4");
            this.printSystemData(textLogPivot5, "IrrigationSystemTestPivot5");

            //Layout in CSV format
            this.printSystemDataCSV("IrrigationSystem-TestPivot2-", testCropIrrigationWeather_Pivot_2.Titles, testCropIrrigationWeather_Pivot_2.Messages);
            this.printSystemDataCSV("IrrigationSystem-TestPivot3_4-", testCropIrrigationWeather_Pivot_3_4.Titles, testCropIrrigationWeather_Pivot_3_4.Messages);
            this.printSystemDataCSV("IrrigationSystem-TestPivot5-", testCropIrrigationWeather_Pivot_5.Titles, testCropIrrigationWeather_Pivot_5.Messages);

            this.printSystemDataCSV("IrrigationSystem-DailyRecords-TestPivot2-", testCropIrrigationWeather_Pivot_2.TitlesDaily, testCropIrrigationWeather_Pivot_2.MessagesDaily);
            this.printSystemDataCSV("IrrigationSystem-DailyRecords-TestPivot3_4-", testCropIrrigationWeather_Pivot_3_4.TitlesDaily, testCropIrrigationWeather_Pivot_3_4.MessagesDaily);
            this.printSystemDataCSV("IrrigationSystem-DailyRecords-TestPivot5-", testCropIrrigationWeather_Pivot_5.TitlesDaily, testCropIrrigationWeather_Pivot_5.MessagesDaily);

        }

        #region Private Helpers


        /// <summary>
        /// Pre: Specie, Region, Phenological Stage List, Crop Density, MaxEvapotranspiration to irrigate
        /// Pos: Crop for all Pivots
        /// </summary>
        private void addCrops_SantaLucia()
        {
            
            testIrrigationSystem.AddCrop(testCrop_Maiz_Sur);
            testIrrigationSystem.AddCrop(testCrop_Soja_Sur);

        }

        /// <summary>
        /// TODO add description
        /// </summary>
        private void createIrrigationUnits_SantaLucia()
        {
            testIrrigationUnit_IrrigationList_Pivot_2 = new List<Pair<DateTime, double>>();
            testIrrigationUnit_CropList_Pivot_2 = new List<Crop>();
            testIU_Pivot_2 = testIrrigationSystem.AddIrrrigationUnit("Pivot 2", "Pivot", testEfficiency_Pivot_2,
                               testIrrigationUnit_IrrigationList_Pivot_2, testSurface_Pivot_2,
                               testIrrigationUnit_CropList_Pivot_2, testBomb, testLocationSantaLucia);
            
            testIrrigationUnit_IrrigationList_Pivot_3_4 = new List<Pair<DateTime, double>>();
            testIrrigationUnit_CropList_Pivot_3_4 = new List<Crop>();
            testIU_Pivot_3_4 = testIrrigationSystem.AddIrrrigationUnit("Pivot 3 y 4", "Pivot", testEfficiency_Pivot_3_4,
                            testIrrigationUnit_IrrigationList_Pivot_3_4, testSurface_Pivot_3_4, 
                            testIrrigationUnit_CropList_Pivot_3_4, testBomb, testLocationSantaLucia);
            
            testIrrigationUnit_IrrigationList_Pivot_5 = new List<Pair<DateTime, double>>();
            testIrrigationUnit_CropList_Pivot_5 = new List<Crop>();
            testIU_Pivot_5 = testIrrigationSystem.AddIrrrigationUnit("Pivot 5", "Pivot", testEfficiency_Pivot_5,
                            testIrrigationUnit_IrrigationList_Pivot_5, testSurface_Pivot_5, 
                            testIrrigationUnit_CropList_Pivot_5, testBomb, testLocationSantaLucia);

        }

        /// <summary>
        /// TODO add description
        /// </summary>
        private void createCropIrrigationWeatherSantaLucia()
        {
            testCropIrrigationWeather_Pivot_2 = testIrrigationSystem.AddCropIrrigationWeather
                                                    (testIU_Pivot_2, testCrop_Maiz_Sur, testWeatherStation, 
                                                    testWeatherStation, testPREDETERMINATED_IRRIGATION, 
                                                    testLocationSantaLucia, testSoil_Pivot_2);

            testCropIrrigationWeather_Pivot_3_4 = testIrrigationSystem.AddCropIrrigationWeather
                                                    (testIU_Pivot_3_4, testCrop_Soja_Sur,testWeatherStation,
                                                    testWeatherStation, testPREDETERMINATED_IRRIGATION, 
                                                    testLocationSantaLucia, testSoil_Pivot_3_4);

            testCropIrrigationWeather_Pivot_5 = testIrrigationSystem.AddCropIrrigationWeather
                                                    (testIU_Pivot_5, testCrop_Maiz_Sur, testWeatherStation, 
                                                    testWeatherStation, testPREDETERMINATED_IRRIGATION, 
                                                    testLocationSantaLucia, testSoil_Pivot_5);

        }

        /// <summary>
        /// Add lRainItem data for each pivot
        /// </summary>
        private void addRainData()
        {
            // DATOS DE LLUVIA
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2014, 10, 29), 66);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2014, 10, 31), 2.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2014, 11, 1), 2.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2014, 11, 2), 10);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2014, 11, 3), 35);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2014, 11, 22), 27);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2014, 11, 30), 130);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2014, 12, 8), 15);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2014, 12, 21), 5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2014, 12, 23), 5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2014, 12, 27), 4.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2014, 12, 31), 3.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2015, 01, 06), 15);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2015, 01, 13), 42);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2015, 01, 19), 10);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2015, 01, 28), 15);


            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2014, 11, 22), 27);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2014, 11, 30), 130);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2014, 12, 8), 15);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2014, 12, 21), 5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2014, 12, 23), 5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2014, 12, 27), 4.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2014, 12, 31), 3.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2015, 01, 06), 15);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2015, 01, 13), 42);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2015, 01, 19), 10);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2015, 01, 28), 15);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2015, 02, 23), 36);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2015, 03, 03), 38);


            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 10, 29), 66);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 10, 31), 2.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 11, 1), 2.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 11, 2), 10);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 11, 3), 35);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 11, 22), 27);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 11, 30), 130);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 12, 8), 15);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 12, 21), 5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 12, 23), 5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 12, 27), 4.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 12, 31), 3.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2015, 01, 06), 15);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2015, 01, 13), 42);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2015, 01, 19), 10);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2015, 01, 28), 15);

            //TODO: 2 Layout Rain Weather Data
            

        }

        /// <summary>
        /// TODO add description
        /// </summary>
        private void addIrrigationData()
        {
            
            //Pivot 2
            //Riego inicial
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2014, 10, 22), new Pair<double, Utils.WaterInputType>(22, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2014, 12, 17), new Pair<double, Utils.WaterInputType>(10, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2014, 12, 20), new Pair<double, Utils.WaterInputType>(10, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2014, 12, 23), new Pair<double, Utils.WaterInputType>(10, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2014, 12, 26), new Pair<double, Utils.WaterInputType>(10, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2014, 12, 30), new Pair<double, Utils.WaterInputType>(10, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2015, 01, 22), new Pair<double, Utils.WaterInputType>(10, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_2, new DateTime(2015, 01, 25), new Pair<double, Utils.WaterInputType>(20, Utils.WaterInputType.Irrigation), true);

            //PIVOT 3_4
            //Riego inicial
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2014, 11, 15), new Pair<double, Utils.WaterInputType>(5, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2014, 11, 19), new Pair<double, Utils.WaterInputType>(7, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2014, 12, 16), new Pair<double, Utils.WaterInputType>(10, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2014, 12, 28), new Pair<double, Utils.WaterInputType>(10, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2015, 01, 02), new Pair<double, Utils.WaterInputType>(10, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_3_4, new DateTime(2015, 01, 24), new Pair<double, Utils.WaterInputType>(10, Utils.WaterInputType.Irrigation), true);
            
            //dias 14, 18 y 22 de diciembre, todos de 5 mm
            //PIVOT 5
            //Riego inicial
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 10, 19), new Pair<double, Utils.WaterInputType>(7, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 10, 21), new Pair<double, Utils.WaterInputType>(7, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 12, 14), new Pair<double, Utils.WaterInputType>(5, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 12, 19), new Pair<double, Utils.WaterInputType>(5, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 12, 23), new Pair<double, Utils.WaterInputType>(5, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 12, 29), new Pair<double, Utils.WaterInputType>(10, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2014, 12, 31), new Pair<double, Utils.WaterInputType>(10, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2015, 01, 21), new Pair<double, Utils.WaterInputType>(10, Utils.WaterInputType.Irrigation), true);
            testIrrigationSystem.AddOrUpdateIrrigationDataToList(testCropIrrigationWeather_Pivot_5, new DateTime(2015, 01, 25), new Pair<double, Utils.WaterInputType>(20, Utils.WaterInputType.Irrigation), true);


            //TODO: 3 Layout Irrigation Weather Data

        }


        private List<Pair<DateTime, Stage>> AddListOfPhenologicalStageAdjustments(SantaLuciaPivotList pPivot)
        {
            List<Pair<DateTime, Stage>> lPhenologicalStageChange;
            DateTime lDateTimeToChange;
            Stage lStageToChange;

            lPhenologicalStageChange = new List<Pair<DateTime, Stage>>();
            if (pPivot.Equals(SantaLuciaPivotList.Pivot2))
            {
                //First Change
                lDateTimeToChange = new DateTime(2014, 11, 20);
                lStageToChange = new Stage(1, "Maiz v4", "4 Hojas");
                lPhenologicalStageChange.Add(new Pair<DateTime, Stage>(lDateTimeToChange, lStageToChange));
                //Second Change
                //lDateTimeToChange = new DateTime(2014, 11, 20);
                //lStageToChange = new Stage(1, "Maiz v2", "2 Hojas");
                //lPhenologicalStageChange.Add(new Pair<DateTime, Stage>(lDateTimeToChange, lStageToChange));
            }
            
            if (pPivot.Equals(SantaLuciaPivotList.Pivot3_4))
            {
                //First Change
                lDateTimeToChange = new DateTime(2014, 12, 25);
                lStageToChange = new Stage(1, "Soja v4", "4 Hojas");
                lPhenologicalStageChange.Add(new Pair<DateTime, Stage>(lDateTimeToChange, lStageToChange));
                //Second Change
                //lDateTimeToChange = new DateTime(2014, 12, 25);
                //lStageToChange = new Stage(1, "Soja v4", "4 Hojas");
                //lPhenologicalStageChange.Add(new Pair<DateTime, Stage>(lDateTimeToChange, lStageToChange));
            }

            if (pPivot.Equals(SantaLuciaPivotList.Pivot5))
            {
                //First Change
                //lDateTimeToChange = new DateTime(2015, 1, 5);
                //lStageToChange = new Stage(1, "Maiz v9", "9 Hojas");
                //lPhenologicalStageChange.Add(new Pair<DateTime, Stage>(lDateTimeToChange, lStageToChange));
                
            }
            return lPhenologicalStageChange;
        }

        /// <summary>
        /// Adds Data to Irrigation Unit
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pPivot"></param>
        private void AddDataIrrigationUnit(CropIrrigationWeather pCropIrrigationWeather, SantaLuciaPivotList pPivot)
        {
            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            CropIrrigationWeather lCropIrrigationWeather;
            DateTime lDateOfRecord;
            String lObservation;

            //The start day is one day after sowing because the first day is created when the testCrop is created
            lFromDate = pCropIrrigationWeather.SowingDate.AddDays(1);
            lToDate = DateTime.Now.AddDays(7);

            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;
            lCropIrrigationWeather = pCropIrrigationWeather;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                if (lDateOfRecord.Date.Equals(new DateTime(2015, 1, 22)))
                {
                    //System.Diagnostics.Debugger.Break();
                }
                
                testIrrigationSystem.addDailyRecordToList(lCropIrrigationWeather, lDateOfRecord, lObservation);

                if (pPivot.Equals(SantaLuciaPivotList.Pivot2))
                {
                    //Adjustment of Phenological Stage for Pivot2
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot2)
                    {
                        if (item.First.Equals(lDateOfRecord))
                        {
                            testIrrigationSystem.AdjustmentPhenology(lCropIrrigationWeather, item.Second, lDateOfRecord);
                            break;
                        }
                    }
                }
                if (pPivot.Equals(SantaLuciaPivotList.Pivot3_4))
                {
                    //Adjustment of Phenological Stage for Pivot3_4
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot3_4)
                    {
                        if (item.First.Equals(lDateOfRecord))
                        {
                            testIrrigationSystem.AdjustmentPhenology(lCropIrrigationWeather, item.Second, lDateOfRecord);
                            break;
                        }
                    }
                }
                if (pPivot.Equals(SantaLuciaPivotList.Pivot5))
                {
                    //Adjustment of Phenological Stage for Pivot5
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot5)
                    {
                        if (item.First.Equals(lDateOfRecord))
                        {
                            testIrrigationSystem.AdjustmentPhenology(lCropIrrigationWeather, item.Second, lDateOfRecord);
                            break;
                        }
                    }
                }
            }
        }

        


        /// <summary>
        /// Create Soil for each Pivot with the horizons
        /// </summary>
        private void createSoils_SantaLucia()
        {

            //Suelos
            testSoil_Pivot_1 = testIrrigationSystem.AddSoil("Suelo Pivot 1", "Suelo Pivot 1", testLocationSantaLucia, DateTime.MinValue, testSoil_Pivot_1_DepthLimit);
            testSoil_Pivot_2 = testIrrigationSystem.AddSoil("Suelo Pivot 2", "Suelo Pivot 2", testLocationSantaLucia, DateTime.MinValue, testSoil_Pivot_2_DepthLimit);
            testSoil_Pivot_3_4 = testIrrigationSystem.AddSoil("Suelo Pivot 3_4", "Suelo Pivot 3_4", testLocationSantaLucia, DateTime.MinValue, testSoil_Pivot_3_4_DepthLimit);
            testSoil_Pivot_5 = testIrrigationSystem.AddSoil("Suelo Pivot 5", "Suelo Pivot 5", testLocationSantaLucia, DateTime.MinValue, testSoil_Pivot_5_DepthLimit);

            // horizon_1A = new Horizon(1,"Horizonte A - Suelo 1", 1, "A",)
            Horizon horizon_2A = new Horizon(1, "A", 0, "A", 14, 19, 53, 28, 4.4, 0, 1.2);
            Horizon horizon_2AB = new Horizon(2, "AB", 1, "AB", 23, 18, 45, 37, 3, 0, 1.3);
            Horizon horizon_2B = new Horizon(3, "B", 2, "B", 20, 19, 37, 44, 2, 0, 1.4);

            testSoil_Pivot_2.HorizonList.Add(horizon_2A);
            testSoil_Pivot_2.HorizonList.Add(horizon_2AB);
            testSoil_Pivot_2.HorizonList.Add(horizon_2B);

            Horizon horizon_3_4A = new Horizon(1, "A", 0, "A", 15, 33, 40, 26, 4.4, 0, 1.3);
            Horizon horizon_3_4B = new Horizon(2, "B", 1, "B", 20, 20, 28, 52, 4.4, 0, 1.4);

            testSoil_Pivot_3_4.HorizonList.Add(horizon_3_4A);
            testSoil_Pivot_3_4.HorizonList.Add(horizon_3_4B);

            Horizon horizon_5A = new Horizon(1, "A", 0, "A",14, 19, 53, 28, 4.4, 0, 1.2);
            Horizon horizon_5AB = new Horizon(2, "AB", 1, "AB", 23, 18, 45, 37, 3, 0, 1.3);
            Horizon horizon_5B = new Horizon(3, "B", 2, "B", 20, 19, 37, 44, 2, 0, 1.4);

<<<<<<< HEAD
            testSoil_Pivot_5.HorizonList.Add(horizon_5A);
            testSoil_Pivot_5.HorizonList.Add(horizon_5AB);
            testSoil_Pivot_5.HorizonList.Add(horizon_5B);
=======
            testSoil_5.Horizons.Add(horizon_5A);
            testSoil_5.Horizons.Add(horizon_5AB);
            testSoil_5.Horizons.Add(horizon_5B);


        }

        private void agregarDatosDeLluvia()
        {
            // DATOS DE LLUVIA
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot2, new DateTime(2014, 10, 29), 66);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot2, new DateTime(2014, 10, 31), 2.5);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot2, new DateTime(2014, 11, 1), 2.5);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot2, new DateTime(2014, 11, 2), 10);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot2, new DateTime(2014, 11, 3), 35);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot2, new DateTime(2014, 11, 22), 27);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot2, new DateTime(2014, 11, 30), 130);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot2, new DateTime(2014, 12, 8), 15);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot2, new DateTime(2014, 12, 21), 5);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot2, new DateTime(2014, 12, 23), 5);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot2, new DateTime(2014, 12, 27), 4.5);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot2, new DateTime(2014, 12, 31), 3.5);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot2, new DateTime(2015, 01, 06), 15);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot2, new DateTime(2015, 01, 13), 42);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot2, new DateTime(2015, 01, 19), 10);//(a confirmar)


            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot3_4, new DateTime(2014, 11, 22), 27);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot3_4, new DateTime(2014, 11, 30), 130);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot3_4, new DateTime(2014, 12, 8), 15);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot3_4, new DateTime(2014, 12, 21), 5);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot3_4, new DateTime(2014, 12, 23), 5);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot3_4, new DateTime(2014, 12, 27), 4.5);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot3_4, new DateTime(2014, 12, 31), 3.5);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot3_4, new DateTime(2015, 01, 06), 15);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot3_4, new DateTime(2015, 01, 13), 42);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot3_4, new DateTime(2015, 01, 19), 10);//(a confirmar)

            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot5, new DateTime(2014, 10, 29), 66);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot5, new DateTime(2014, 10, 31), 2.5);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot5, new DateTime(2014, 11, 1), 2.5);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot5, new DateTime(2014, 11, 2), 10);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot5, new DateTime(2014, 11, 3), 35);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot5, new DateTime(2014, 11, 22), 27);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot5, new DateTime(2014, 11, 30), 130);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot5, new DateTime(2014, 12, 8), 15);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot5, new DateTime(2014, 12, 21), 5);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot5, new DateTime(2014, 12, 23), 5);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot5, new DateTime(2014, 12, 27), 4.5);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot5, new DateTime(2014, 12, 31), 3.5);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot5, new DateTime(2015, 01, 06), 15);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot5, new DateTime(2015, 01, 13), 42);
            testIrrigationSystem.addRainDataToList(testCropIrrigWeatherPivot5, new DateTime(2015, 01, 19), 10);//(a confirmar)

            //TODO: 2 Layout Rain Weather Data
            

        }

>>>>>>> e60c109a64ccab13f9b70f37f4c72a5a85a76bf7


        }


        /// <summary>
        /// Layout in txt with a name to the file
        /// </summary>
        /// <param name="pText"></param>
        /// <param name="pFileName"></param>
        private void printSystemData(String pText, String pFileName)
        {
            TextFileLogger lTextFileLogger = new TextFileLogger();
            String lMethod = "createACropIrrigationWeather";
            String lMessage = pText;
            String lTime = System.DateTime.Now.ToString();
            String lDate = System.DateTime.Today.Year.ToString() +
                System.DateTime.Today.Month.ToString() +
                System.DateTime.Today.Day.ToString();
            String lFile;
            if (String.IsNullOrEmpty(pFileName))
            {
                lFile = "IrrigationSystemTest-" + lDate;
            }
            else
            {
                lFile = pFileName + "-" + lDate;
            }
            
            lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pFileName"></param>
        /// <param name="pTitles"></param>
        /// <param name="pMessages"></param>
        private void printSystemDataCSV(
            String pFileName, 
            List<String> pTitles,
            List<List<String>> pMessages )
        {
            String lFilePath;
            String lFolderName;
            String lDataSplit; 
            
            String lMethod;
            String lDescription;
            String lTime;

            String lDate;
            
            OutputFileCSV lOutputFile;
         
            //create the file
            lOutputFile = new OutputFileCSV(pFileName);
            lFolderName = lOutputFile.FolderName;
            lFilePath = lOutputFile.FilePath;
            lDataSplit = lOutputFile.DataSplit;

            lMethod = "createACropIrrigationWeather";
            lDescription = "All the data neccesary for doing a Irrigation Advisor.";
            lTime = System.DateTime.Now.ToString();
            lDate = System.DateTime.Today.Year.ToString() +
                System.DateTime.Today.Month.ToString() +
                System.DateTime.Today.Day.ToString();
            
            //Output of file information
            lOutputFile.FileHeader = "Table with all the lIrrigation results.";
            lOutputFile.FileTitles = pTitles;
            lOutputFile.FileMessages = pMessages;
            lOutputFile.FileFooter = "Finish all the information.";

            //Writes the CSV file in the FilePath
            lOutputFile.WriteFile(lMethod, lDescription, lTime);


        }

        #endregion


    }
}
