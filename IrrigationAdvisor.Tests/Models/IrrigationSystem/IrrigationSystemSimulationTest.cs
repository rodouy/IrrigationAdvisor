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
    public class IrrigationSystemSimulationTest
    {
        #region Fields Test
        private Position testPositionUruguay;
        private Position testPositionRegionTemplada;
        private Position testPositionFarm;
        private Position testPositionMontevideo;
        private Position testPositionMinas;
        private Language.Language testLanguage;
        private Country testCountry;
        private Region testRegion;
        private City testCapital;
        //private City testCity;
        private City testCityMinas;

        private Location testLocationFarm;
        private Location testLocationMinas;
        private Specie testSpecieSoja;
        private Specie testSpecieMaiz;
        private List<Specie> testSpecieList;

        private Stage testInitialStage_Maiz;
        private Stage testInitialStage_Soja;

        private PhenologicalStage testInitialPhenologicalStage_Soja;
        private PhenologicalStage testInitialPhenologicalStage_Maiz;
        private CropCoefficient testCropCoefficient_Soja;
        private CropCoefficient testCropCoefficient_Maiz;

        private List<PhenologicalStage> testPhenologicalStageList_Maiz;
        private List<PhenologicalStage> testPhenologicalStageList_Soja;
        
        #region Soil for Pivots

        private Soil testSoil_Pivot_01;
        private double testSoil_Pivot_01_DepthLimit;

        private Soil testSoil_Pivot_02;
        private double testSoil_Pivot_02_DepthLimit;

        private Soil testSoil_Pivot_03;
        private double testSoil_Pivot_03_DepthLimit;

        private Soil testSoil_Pivot_04;
        private double testSoil_Pivot_04_DepthLimit;

        private Soil testSoil_Pivot_05;
        private double testSoil_Pivot_05_DepthLimit;
        
        private Soil testSoil_Pivot_06;
        private double testSoil_Pivot_06_DepthLimit;

        private Soil testSoil_Pivot_07;
        private double testSoil_Pivot_07_DepthLimit;

        private Soil testSoil_Pivot_08;
        private double testSoil_Pivot_08_DepthLimit;

        private Soil testSoil_Pivot_09;
        private double testSoil_Pivot_09_DepthLimit;

        private Soil testSoil_Pivot_10;
        private double testSoil_Pivot_10_DepthLimit;

        private Soil testSoil_Pivot_11;
        private double testSoil_Pivot_11_DepthLimit;

        private Soil testSoil_Pivot_12;
        private double testSoil_Pivot_12_DepthLimit;

        private Soil testSoil_Pivot_13;
        private double testSoil_Pivot_13_DepthLimit;

        #endregion

        private Bomb testBomb;

        #region Weather Stations
        private WeatherStation testWeatherStation_Pivot_01;
        private WeatherStation testWeatherStation_Pivot_02;
        private WeatherStation testWeatherStation_Pivot_03;
        private WeatherStation testWeatherStation_Pivot_04;
        private WeatherStation testWeatherStation_Pivot_05;
        private WeatherStation testWeatherStation_Pivot_06;
        private WeatherStation testWeatherStation_Pivot_07;
        private WeatherStation testWeatherStation_Pivot_08;
        private WeatherStation testWeatherStation_Pivot_09;
        private WeatherStation testWeatherStation_Pivot_10;
        private WeatherStation testWeatherStation_Pivot_11;
        private WeatherStation testWeatherStation_Pivot_12;
        private WeatherStation testWeatherStation_Pivot_13;
        private WeatherStation testWeatherStationAlternative;
        #endregion

        /*
             *  Cultivos Maiz
             *  
             *  1. Pivot 1 = Maíz 2007  Temporada 2007-2008 - GDAc. - ETc - Lluvia
             *  2. Pivot 2 = Tammi 2008 Temporada 2008-2009 - DDS - GDAc. - Fen - ETc - Lluvia
             *  3. Pivot 3 = La perdiz 2010   Temporada 2010-2011 - DDS - ET0 - Lluvias
             *  4. Pivot 4 = NK900 2010  Temporada 2010-2011 - DDS - ET0 - Lluvias
             *  5. Pivot 5 = NK900 2012  Temporada 2012-2013 - DDS - ET0 - Lluvias
             *  6. Pivot 6 = SL P2 2010   Temporada 2010-2011 - DDS - ET0 - Lluvias
             *  7. Pivot 7 = SL P2 2012   Temporada 2013-2014 - DDS - ET0 - Lluvias
             *  8. Pivot 8 = SL P2 2013   Temporada 2013-2014 - DDS - ET0 - Lluvias
             *  9. Pivot 9 = SL P5 2013   Temporada 2013-2014 - DDS - ET0 - Lluvias

             *  Cultivos Soja

             *  1. Pivot 10 = SL Soja 2013   Temporada 2013-2014 - DDS - ET0 - Lluvias
             *  2. Pivot 11 = LP Soja 2010   Temporada 2010-2011 - DDS - ET0 - Lluvias
             *  3. Pivot 12 = LP Soja 2011   Temporada 2010-2011 - DDS - ET0 - Lluvias
             *  4. Pivot 13 = LP Soja 2012   Temporada 2012-2013 - DDS - ET0 - Lluvias - CropCoefficient - ETc
        */
  
        enum FarmPivotList
        {
            Pivot_01_Maiz_2007,
            Pivot_02_Tammi_2008,
            Pivot_03_LaPerdiz_2010,
            Pivot_04_NK900_2010,
            Pivot_05_NK900_2012,
            Pivot_06_SLP2_2010,
            Pivot_07_SLP2_2012,
            Pivot_08_SLP2_2013,
            Pivot_09_SLP5_2013,
            Pivot_10_SL_Soja_2013,
            Pivot_11_LP_Soja_2010,
            Pivot_12_LP_Soja_2011,
            Pivot_13_LP_Soja_2012
        };

        #region Pivot data

        private double testEfficiency_Pivot_01;
        private double testEfficiency_Pivot_02;
        private double testEfficiency_Pivot_03;
        private double testEfficiency_Pivot_04;
        private double testEfficiency_Pivot_05;
        private double testEfficiency_Pivot_06;
        private double testEfficiency_Pivot_07;
        private double testEfficiency_Pivot_08;
        private double testEfficiency_Pivot_09;
        private double testEfficiency_Pivot_10;
        private double testEfficiency_Pivot_11;
        private double testEfficiency_Pivot_12;
        private double testEfficiency_Pivot_13;

        private int testSurface_Pivot_01;
        private int testSurface_Pivot_02;
        private int testSurface_Pivot_03;
        private int testSurface_Pivot_04;
        private int testSurface_Pivot_05;
        private int testSurface_Pivot_06;
        private int testSurface_Pivot_07;
        private int testSurface_Pivot_08;
        private int testSurface_Pivot_09;
        private int testSurface_Pivot_10;
        private int testSurface_Pivot_11;
        private int testSurface_Pivot_12;
        private int testSurface_Pivot_13;
        
        #endregion

        #region Pivots to work

        private IrrigationUnit testIU_Pivot_01_Maiz_2007;
        private IrrigationUnit testIU_Pivot_02_Tammi_2008;
        private IrrigationUnit testIU_Pivot_03_LaPerdiz2010;
        private IrrigationUnit testIU_Pivot_04_NK900_2010;
        private IrrigationUnit testIU_Pivot_05_NK900_2012;
        private IrrigationUnit testIU_Pivot_06_SLP2_2010;
        private IrrigationUnit testIU_Pivot_07_SLP2_2012;
        private IrrigationUnit testIU_Pivot_08_SLP2_2013;
        private IrrigationUnit testIU_Pivot_09_SLP5_2013;
        private IrrigationUnit testIU_Pivot_10_SL_Soja_2013;
        private IrrigationUnit testIU_Pivot_11_LP_Soja_2010;
        private IrrigationUnit testIU_Pivot_12_LP_Soja_2011;
        private IrrigationUnit testIU_Pivot_13_LP_Soja_2012;
        
        #endregion

        #region Irrigations of each Irrigation Unit
        
        private List<Pair<DateTime, double>> testIrrigationUnit_IrrigationList_Pivot_01_Maiz_2007;
        private List<Pair<DateTime, double>> testIrrigationUnit_IrrigationList_Pivot_02_Tammi_2008;
        private List<Pair<DateTime, double>> testIrrigationUnit_IrrigationList_Pivot_03_LaPerdiz_2010;
        private List<Pair<DateTime, double>> testIrrigationUnit_IrrigationList_Pivot_04_NK900_2010;
        private List<Pair<DateTime, double>> testIrrigationUnit_IrrigationList_Pivot_05_NK900_2012;
        private List<Pair<DateTime, double>> testIrrigationUnit_IrrigationList_Pivot_06_SLP2_2010;
        private List<Pair<DateTime, double>> testIrrigationUnit_IrrigationList_Pivot_07_SLP2_2012;
        private List<Pair<DateTime, double>> testIrrigationUnit_IrrigationList_Pivot_08_SLP2_2013;
        private List<Pair<DateTime, double>> testIrrigationUnit_IrrigationList_Pivot_09_SLP5_2013;
        private List<Pair<DateTime, double>> testIrrigationUnit_IrrigationList_Pivot_10_SL_Soja_2013;
        private List<Pair<DateTime, double>> testIrrigationUnit_IrrigationList_Pivot_11_LP_Soja_2010;
        private List<Pair<DateTime, double>> testIrrigationUnit_IrrigationList_Pivot_12_LP_Soja_2011;
        private List<Pair<DateTime, double>> testIrrigationUnit_IrrigationList_Pivot_13_LP_Soja_2012;

        #endregion

        #region Crops of each Irrigation Unit
        
        private List<Crop> testIrrigationUnit_CropList_Pivot_01_Maiz_2007;
        private List<Crop> testIrrigationUnit_CropList_Pivot_02_Tammi_2008;
        private List<Crop> testIrrigationUnit_CropList_Pivot_03_LaPerdiz_2010;
        private List<Crop> testIrrigationUnit_CropList_Pivot_04_NK900_2010;
        private List<Crop> testIrrigationUnit_CropList_Pivot_05_NK900_2012;
        private List<Crop> testIrrigationUnit_CropList_Pivot_06_SLP2_2010;
        private List<Crop> testIrrigationUnit_CropList_Pivot_07_SLP2_2012;
        private List<Crop> testIrrigationUnit_CropList_Pivot_08_SLP2_2013;
        private List<Crop> testIrrigationUnit_CropList_Pivot_09_SLP5_2013;
        private List<Crop> testIrrigationUnit_CropList_Pivot_10_SL_Soja_2013;
        private List<Crop> testIrrigationUnit_CropList_Pivot_11_LP_Soja_2010;
        private List<Crop> testIrrigationUnit_CropList_Pivot_12_LP_Soja_2011;
        private List<Crop> testIrrigationUnit_CropList_Pivot_13_LP_Soja_2012;

        #endregion

        private Crop testCrop_Maiz_Sur;
        private Crop testCrop_Soja_Sur;

        #region CropIrrigationWeather for each Irrigation Unit

        private CropIrrigationWeather testCropIrrigationWeather_Pivot_01_Maiz_2007;
        private CropIrrigationWeather testCropIrrigationWeather_Pivot_02_Tammi_2008;
        private CropIrrigationWeather testCropIrrigationWeather_Pivot_03_LaPerdiz_2010;
        private CropIrrigationWeather testCropIrrigationWeather_Pivot_04_NK900_2010;
        private CropIrrigationWeather testCropIrrigationWeather_Pivot_05_NK900_2012;
        private CropIrrigationWeather testCropIrrigationWeather_Pivot_06_SLP2_2010;
        private CropIrrigationWeather testCropIrrigationWeather_Pivot_07_SLP2_2012;
        private CropIrrigationWeather testCropIrrigationWeather_Pivot_08_SLP2_2013;
        private CropIrrigationWeather testCropIrrigationWeather_Pivot_09_SLP5_2013;
        private CropIrrigationWeather testCropIrrigationWeather_Pivot_10_SL_Soja_2013;
        private CropIrrigationWeather testCropIrrigationWeather_Pivot_11_LP_Soja_2010;
        private CropIrrigationWeather testCropIrrigationWeather_Pivot_12_LP_Soja_2011;
        private CropIrrigationWeather testCropIrrigationWeather_Pivot_13_LP_Soja_2012;

        #endregion

        #region Calculus for Phenological Stage
        
        private Utils.CalculusOfPhenologicalStage testCalculusOfPhenologicalStage_Pivot_01;
        private Utils.CalculusOfPhenologicalStage testCalculusOfPhenologicalStage_Pivot_02;
        private Utils.CalculusOfPhenologicalStage testCalculusOfPhenologicalStage_Pivot_03;
        private Utils.CalculusOfPhenologicalStage testCalculusOfPhenologicalStage_Pivot_04;
        private Utils.CalculusOfPhenologicalStage testCalculusOfPhenologicalStage_Pivot_05;
        private Utils.CalculusOfPhenologicalStage testCalculusOfPhenologicalStage_Pivot_06;
        private Utils.CalculusOfPhenologicalStage testCalculusOfPhenologicalStage_Pivot_07;
        private Utils.CalculusOfPhenologicalStage testCalculusOfPhenologicalStage_Pivot_08;
        private Utils.CalculusOfPhenologicalStage testCalculusOfPhenologicalStage_Pivot_09;
        private Utils.CalculusOfPhenologicalStage testCalculusOfPhenologicalStage_Pivot_10;
        private Utils.CalculusOfPhenologicalStage testCalculusOfPhenologicalStage_Pivot_11;
        private Utils.CalculusOfPhenologicalStage testCalculusOfPhenologicalStage_Pivot_12;
        private Utils.CalculusOfPhenologicalStage testCalculusOfPhenologicalStage_Pivot_13;

        #endregion

        private double testSojaBaseTemp;
        private double testMaizBaseTemp;
        private double testPREDETERMINATED_IRRIGATION;

        private double testMaxEvapotranspirationToIrrigate_Maiz;
        private double testMaxEvapotranspirationToIrrigate_Soja;
        private double testMinEvapotranspirationToIrrigate_Maiz;
        private double testMinEvapotranspirationToIrrigate_Soja;
        
        private double testCropDensityMaiz;
        private double testCropDensitySoja;

        private List<EffectiveRain> testEffectiveRainsList;
        
        #region Phenological Stage Change for Pivots

        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot_01;
        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot_02;
        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot_03;
        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot_04;
        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot_05;
        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot_06;
        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot_07;
        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot_08;
        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot_09;
        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot_10;
        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot_11;
        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot_12;
        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot_13;

        #endregion

        #region Dates for Crop Pivots

        private DateTime testDateBeginCrop_Pivot_01;
        private DateTime testDateBeginCrop_Pivot_02;
        private DateTime testDateBeginCrop_Pivot_03;
        private DateTime testDateBeginCrop_Pivot_04;
        private DateTime testDateBeginCrop_Pivot_05;
        private DateTime testDateBeginCrop_Pivot_06;
        private DateTime testDateBeginCrop_Pivot_07;
        private DateTime testDateBeginCrop_Pivot_08;
        private DateTime testDateBeginCrop_Pivot_09;
        private DateTime testDateBeginCrop_Pivot_10;
        private DateTime testDateBeginCrop_Pivot_11;
        private DateTime testDateBeginCrop_Pivot_12;
        private DateTime testDateBeginCrop_Pivot_13;
        
        private DateTime testDateEndCrop_Pivot_01;
        private DateTime testDateEndCrop_Pivot_02;
        private DateTime testDateEndCrop_Pivot_03;
        private DateTime testDateEndCrop_Pivot_04;
        private DateTime testDateEndCrop_Pivot_05;
        private DateTime testDateEndCrop_Pivot_06;
        private DateTime testDateEndCrop_Pivot_07;
        private DateTime testDateEndCrop_Pivot_08;
        private DateTime testDateEndCrop_Pivot_09;
        private DateTime testDateEndCrop_Pivot_10;
        private DateTime testDateEndCrop_Pivot_11;
        private DateTime testDateEndCrop_Pivot_12;
        private DateTime testDateEndCrop_Pivot_13;

        #endregion

        private DateTime testWeatherDataStartDate;

        #region Log information
        
        private String textLogPivot_01;
        private String textLogPivot_02;
        private String textLogPivot_03;
        private String textLogPivot_04;
        private String textLogPivot_05;
        private String textLogPivot_06;
        private String textLogPivot_07;
        private String textLogPivot_08;
        private String textLogPivot_09;
        private String textLogPivot_10;
        private String textLogPivot_11;
        private String textLogPivot_12;
        private String textLogPivot_13;

        #endregion

        #endregion

        private Management.IrrigationSystem testIrrigationSystem;
        /// <summary>
        /// this method is used to obtain the layout
        /// </summary>
        [TestMethod]
        public void farmTest()
        {
            testIrrigationSystem = Management.IrrigationSystem.Instance;

            #region Initial Variables


            testWeatherDataStartDate = new DateTime(2014, 10, 18);

            #region Pivot Depth Limit

            testSoil_Pivot_01_DepthLimit = 40;
            testSoil_Pivot_02_DepthLimit = 40;
            testSoil_Pivot_03_DepthLimit = 40;
            testSoil_Pivot_04_DepthLimit = 40;
            testSoil_Pivot_05_DepthLimit = 40;
            testSoil_Pivot_06_DepthLimit = 40;
            testSoil_Pivot_07_DepthLimit = 40;
            testSoil_Pivot_08_DepthLimit = 40;
            testSoil_Pivot_09_DepthLimit = 40;
            testSoil_Pivot_10_DepthLimit = 40;
            testSoil_Pivot_11_DepthLimit = 40;
            testSoil_Pivot_12_DepthLimit = 40;
            testSoil_Pivot_13_DepthLimit = 40;

            #endregion

            #region Pivot Begin Dates for each Pivot
            
            testDateBeginCrop_Pivot_01 = new DateTime(2007, 11, 15);
            testDateBeginCrop_Pivot_02 = new DateTime(2008, 09, 25);
            testDateBeginCrop_Pivot_03 = new DateTime(2010, 10, 20);
            testDateBeginCrop_Pivot_04 = new DateTime(2010, 10, 20);
            testDateBeginCrop_Pivot_05 = new DateTime(2012, 10, 10);
            testDateBeginCrop_Pivot_06 = new DateTime(2010, 10, 26);
            testDateBeginCrop_Pivot_07 = new DateTime(2012, 11, 20);
            testDateBeginCrop_Pivot_08 = new DateTime(2013, 10, 15);
            testDateBeginCrop_Pivot_09 = new DateTime(2013, 11, 10);
            testDateBeginCrop_Pivot_10 = new DateTime(2013, 10, 31);
            testDateBeginCrop_Pivot_11 = new DateTime(2010, 10, 22);
            testDateBeginCrop_Pivot_12 = new DateTime(2010, 12, 23);
            testDateBeginCrop_Pivot_13 = new DateTime(2012, 12, 08);

            #endregion

            #region Pivot End Dates for each Pivot
            
            testDateEndCrop_Pivot_01 = new DateTime(2008, 03, 04);
            testDateEndCrop_Pivot_02 = new DateTime(2009, 01, 15);
            testDateEndCrop_Pivot_03 = new DateTime(2011, 02, 08);
            testDateEndCrop_Pivot_04 = new DateTime(2011, 02, 08);
            testDateEndCrop_Pivot_05 = new DateTime(2013, 02, 04);
            testDateEndCrop_Pivot_06 = new DateTime(2011, 02, 19);
            testDateEndCrop_Pivot_07 = new DateTime(2013, 03, 02);
            testDateEndCrop_Pivot_08 = new DateTime(2014, 01, 18);
            testDateEndCrop_Pivot_09 = new DateTime(2014, 02, 09);
            testDateEndCrop_Pivot_10 = new DateTime(2014, 02, 07);
            testDateEndCrop_Pivot_11 = new DateTime(2011, 03, 10);
            testDateEndCrop_Pivot_12 = new DateTime(2011, 04, 18);
            testDateEndCrop_Pivot_13 = new DateTime(2013, 03, 31);

            #endregion

            #region Pivot Efficiency
            
            testEfficiency_Pivot_01 = 0.85;
            testEfficiency_Pivot_02 = 0.85;
            testEfficiency_Pivot_03 = 0.85;
            testEfficiency_Pivot_04 = 0.85;
            testEfficiency_Pivot_05 = 0.85;
            testEfficiency_Pivot_06 = 0.85;
            testEfficiency_Pivot_07 = 0.85;
            testEfficiency_Pivot_08 = 0.85;
            testEfficiency_Pivot_09 = 0.85;
            testEfficiency_Pivot_10 = 0.85;
            testEfficiency_Pivot_11 = 0.85;
            testEfficiency_Pivot_12 = 0.85;
            testEfficiency_Pivot_13 = 0.85;
            
            #endregion
            
            #region Pivot Surface
            
            testSurface_Pivot_01 = 300;
            testSurface_Pivot_02 = 300;
            testSurface_Pivot_03 = 300;
            testSurface_Pivot_04 = 300;
            testSurface_Pivot_05 = 300;
            testSurface_Pivot_06 = 300;
            testSurface_Pivot_07 = 300;
            testSurface_Pivot_08 = 300;
            testSurface_Pivot_09 = 300;
            testSurface_Pivot_10 = 300;
            testSurface_Pivot_11 = 300;
            testSurface_Pivot_12 = 300;
            testSurface_Pivot_13 = 300;
            
            #endregion
            
            #region Specie Base Temp
            
            testSojaBaseTemp = 8;
            testMaizBaseTemp = 10;

            #endregion

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

            #endregion

            #region 1. Create position
            testPositionUruguay = new Position(-32.523, -55.766);
            testPositionRegionTemplada = new Position(-33.874333, -56.009694);
            testPositionMontevideo = new Position(-34.9019718,-56.1640629);
            testPositionMinas = new Position(-34.366747, -55.233317);
            testPositionFarm = new Position(-34.232518, -55.541477);
            #endregion

            #region 2. Create Region (First create Effective Rain, Specie List)
            testRegion = testIrrigationSystem.AddRegion("Templada", testPositionRegionTemplada, null, null);
            #endregion

            #region 3. Create Specie 
            testSpecieMaiz = new Specie(0, "Maiz", "Unico", testMaizBaseTemp);
            testSpecieSoja = new Specie(1, "Soja", "Corto", testSojaBaseTemp);
            #endregion

            #region 4. Add Specie to SpecieList of Region
            testSpecieList = new List<Specie>();
            testSpecieList.Add(testSpecieMaiz);
            testSpecieList.Add(testSpecieSoja);
            testRegion.SpecieList = testSpecieList;
            #endregion

            #region 5. Initial Tables, Effective Rain List of Region
            testEffectiveRainsList = InitialTables.CreateEffectiveRainListToSystem();
            testRegion.EffectiveRainList = testEffectiveRainsList;
            #endregion

            #region 6. Create Crops
            testCrop_Maiz_Sur = new Crop(0, "Maiz Sur", testRegion, testSpecieMaiz, 
                                        testCropDensityMaiz,
                                        testMaxEvapotranspirationToIrrigate_Maiz,
                                        testMinEvapotranspirationToIrrigate_Maiz);
            testCrop_Soja_Sur = new Crop(1, "Soja Sur", testRegion, testSpecieSoja,
                                        testCropDensitySoja,
                                        testMaxEvapotranspirationToIrrigate_Soja,
                                        testMinEvapotranspirationToIrrigate_Soja);
            #endregion

            #region 7.  Create CropCoefficient
            testCropCoefficient_Maiz = Data.InitialTables.CreateCropCoefficientWithList_Maiz();
            testCropCoefficient_Soja = Data.InitialTables.CreateCropCoefficientWithList_Soja();
            #endregion

            #region 8.  Add CropCoefficient to Crop
            testCrop_Maiz_Sur.CropCoefficient = testCropCoefficient_Maiz;
            testCrop_Soja_Sur.CropCoefficient = testCropCoefficient_Soja;
            #endregion

            #region 9.  Create PhenologicalStage List & Add Stage List to Crop
            testPhenologicalStageList_Maiz = InitialTables.CreatePhenologicalStageListForMaiz(testCrop_Maiz_Sur);
            testPhenologicalStageList_Soja = InitialTables.CreatePhenologicalStageListForSoja(testCrop_Soja_Sur);
            #endregion

            #region 10.  Add PhenologicalStageList to Crop
            testCrop_Maiz_Sur.UpdatePhenologicalStageList(testPhenologicalStageList_Maiz);
            testCrop_Soja_Sur.UpdatePhenologicalStageList(testPhenologicalStageList_Soja);
            #endregion

            #region 11.  Add Crops to System
            addCrops_Farm();
            #endregion

            #region 12. Create Initial Stage & Initial PhenologicalStage of Crop
            testInitialStage_Maiz = testCrop_Maiz_Sur.GetInitialStage();
            testInitialStage_Soja = testCrop_Soja_Sur.GetInitialStage();
            testInitialPhenologicalStage_Maiz = testCrop_Maiz_Sur.GetInitialPhenologicalStage();
            testInitialPhenologicalStage_Soja = testCrop_Soja_Sur.GetInitialPhenologicalStage();
            #endregion

            #region 13. Create Language
            testLanguage = testIrrigationSystem.AddLanguage("Spanish");
            #endregion

            #region 14. Create City (Capital)
            testCapital = testIrrigationSystem.AddCity("Montevideo", testPositionMontevideo);
            #endregion

            #region 15. Create Country (First create Capital City)
            testCountry = testIrrigationSystem.AddCountry("Uruguay", testCapital, testLanguage, null, null);
            #endregion

            #region 16. Create City
            testCityMinas = testIrrigationSystem.AddCity("Minas", testPositionMinas);
            testCityMinas = testIrrigationSystem.AddCityToCountry(testCountry, testCityMinas);
            #endregion

            #region 17. Create Location
            testLocationFarm = testIrrigationSystem.AddLocation(testPositionFarm, testCountry,
                                                                testRegion, testCityMinas);
            testLocationMinas = testIrrigationSystem.AddLocation(testPositionRegionTemplada, testCountry,
                                                                testRegion, testCityMinas);
            #endregion

            #region 18. Create Soils, Horizons
            createSoils_Farm();
            #endregion

            #region 19.  Create Bomb
            testBomb = testIrrigationSystem.AddBomb("Bomba Santa Lucia", 1234, DateTime.Now, DateTime.Now, testLocationFarm);
            #endregion

            #region 20.  Create WeatherStation
            testWeatherStationAlternative = testIrrigationSystem.AddWeatherStation("WeatherStation Farm", "Model Alternative",
                                                                    DateTime.Now, DateTime.Now, DateTime.Now, 1,
                                                                    testLocationFarm, true);

            testWeatherStation_Pivot_01 = testIrrigationSystem.AddWeatherStation("WeatherStation Farm", "Model Pivot 01", 
                                                                    DateTime.Now, DateTime.Now, DateTime.Now, 1, 
                                                                    testLocationFarm, true);

            testWeatherStation_Pivot_02 = testIrrigationSystem.AddWeatherStation("WeatherStation Farm", "Model Pivot 02",
                                                                    DateTime.Now, DateTime.Now, DateTime.Now, 1,
                                                                    testLocationFarm, true);

            testWeatherStation_Pivot_03 = testIrrigationSystem.AddWeatherStation("WeatherStation Farm", "Model Pivot 03",
                                                                    DateTime.Now, DateTime.Now, DateTime.Now, 1,
                                                                    testLocationFarm, true);

            testWeatherStation_Pivot_04 = testIrrigationSystem.AddWeatherStation("WeatherStation Farm", "Model Pivot 04",
                                                                    DateTime.Now, DateTime.Now, DateTime.Now, 1,
                                                                    testLocationFarm, true);

            testWeatherStation_Pivot_05 = testIrrigationSystem.AddWeatherStation("WeatherStation Farm", "Model Pivot 05",
                                                                    DateTime.Now, DateTime.Now, DateTime.Now, 1,
                                                                    testLocationFarm, true);

            testWeatherStation_Pivot_06 = testIrrigationSystem.AddWeatherStation("WeatherStation Farm", "Model Pivot 06",
                                                                    DateTime.Now, DateTime.Now, DateTime.Now, 1,
                                                                    testLocationFarm, true);

            testWeatherStation_Pivot_07 = testIrrigationSystem.AddWeatherStation("WeatherStation Farm", "Model Pivot 07",
                                                                    DateTime.Now, DateTime.Now, DateTime.Now, 1,
                                                                    testLocationFarm, true);

            testWeatherStation_Pivot_08 = testIrrigationSystem.AddWeatherStation("WeatherStation Farm", "Model Pivot 08",
                                                                    DateTime.Now, DateTime.Now, DateTime.Now, 1,
                                                                    testLocationFarm, true);

            testWeatherStation_Pivot_09 = testIrrigationSystem.AddWeatherStation("WeatherStation Farm", "Model Pivot 09",
                                                                    DateTime.Now, DateTime.Now, DateTime.Now, 1,
                                                                    testLocationFarm, true);

            testWeatherStation_Pivot_10 = testIrrigationSystem.AddWeatherStation("WeatherStation Farm", "Model Pivot 10",
                                                                    DateTime.Now, DateTime.Now, DateTime.Now, 1,
                                                                    testLocationFarm, true);

            testWeatherStation_Pivot_11 = testIrrigationSystem.AddWeatherStation("WeatherStation Farm", "Model Pivot 11",
                                                                    DateTime.Now, DateTime.Now, DateTime.Now, 1,
                                                                    testLocationFarm, true);

            testWeatherStation_Pivot_12 = testIrrigationSystem.AddWeatherStation("WeatherStation Farm", "Model Pivot 12",
                                                                    DateTime.Now, DateTime.Now, DateTime.Now, 1,
                                                                    testLocationFarm, true);

            testWeatherStation_Pivot_13 = testIrrigationSystem.AddWeatherStation("WeatherStation Farm", "Model Pivot 13",
                                                                    DateTime.Now, DateTime.Now, DateTime.Now, 1,
                                                                    testLocationFarm, true);

            
            #endregion

            #region 21.  Create Irrigation Units
            createIrrigationUnits_Farm();
            #endregion

            #region 22.  Create Crop Irrigation Weather
            createCropIrrigationWeatherFarm();
            #endregion

            #region 23.  Add Information of Weather
            
            //ExternalData.AddWeather_Pivot_01(testIrrigationSystem, testWeatherStation_Pivot_01);
            //ExternalData.AddWeather_Pivot_02(testIrrigationSystem, testWeatherStation_Pivot_02);
            ExternalData.AddWeatherData_Pivot_03(testIrrigationSystem, testWeatherStation_Pivot_03);
            ExternalData.AddWeatherData_Pivot_04(testIrrigationSystem, testWeatherStation_Pivot_04);
            ExternalData.AddWeatherData_Pivot_05(testIrrigationSystem, testWeatherStation_Pivot_05);
            ExternalData.AddWeatherData_Pivot_06(testIrrigationSystem, testWeatherStation_Pivot_06);
            ExternalData.AddWeatherData_Pivot_07(testIrrigationSystem, testWeatherStation_Pivot_07);
            ExternalData.AddWeatherData_Pivot_08(testIrrigationSystem, testWeatherStation_Pivot_08);
            ExternalData.AddWeatherData_Pivot_09(testIrrigationSystem, testWeatherStation_Pivot_09);
            //ExternalData.AddWeatherData_Pivot_10(testIrrigationSystem, testWeatherStation_Pivot_10);
            //ExternalData.AddWeatherData_Pivot_11(testIrrigationSystem, testWeatherStation_Pivot_11);
            //ExternalData.AddWeatherData_Pivot_12(testIrrigationSystem, testWeatherStation_Pivot_12);
            //ExternalData.AddWeatherData_Pivot_13(testIrrigationSystem, testWeatherStation_Pivot_13);
            
            ExternalData.AddWeatherData2007(testIrrigationSystem, testWeatherStationAlternative);
            #endregion

            #region 24.Inicialize Crop Irrigation Weather
            
            testCalculusOfPhenologicalStage_Pivot_01 = Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing;
            testIrrigationSystem.InicializeCropIrrigationWeather(testCropIrrigationWeather_Pivot_01_Maiz_2007, 
                                                                testInitialPhenologicalStage_Maiz, 
                                                                testDateBeginCrop_Pivot_01, testDateEndCrop_Pivot_01,
                                                                testCalculusOfPhenologicalStage_Pivot_01);

            testCalculusOfPhenologicalStage_Pivot_02 = Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing;
            testIrrigationSystem.InicializeCropIrrigationWeather(testCropIrrigationWeather_Pivot_02_Tammi_2008, 
                                                                testInitialPhenologicalStage_Maiz, 
                                                                testDateBeginCrop_Pivot_02, testDateEndCrop_Pivot_02,
                                                                testCalculusOfPhenologicalStage_Pivot_02);
            
            testCalculusOfPhenologicalStage_Pivot_03 = Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing;
            testIrrigationSystem.InicializeCropIrrigationWeather(testCropIrrigationWeather_Pivot_03_LaPerdiz_2010,
                                                                testInitialPhenologicalStage_Maiz,
                                                                testDateBeginCrop_Pivot_03, testDateEndCrop_Pivot_03,
                                                                testCalculusOfPhenologicalStage_Pivot_03);

            testCalculusOfPhenologicalStage_Pivot_04 = Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing;
            testIrrigationSystem.InicializeCropIrrigationWeather(testCropIrrigationWeather_Pivot_04_NK900_2010,
                                                                testInitialPhenologicalStage_Maiz,
                                                                testDateBeginCrop_Pivot_04, testDateEndCrop_Pivot_04,
                                                                testCalculusOfPhenologicalStage_Pivot_04);

            testCalculusOfPhenologicalStage_Pivot_05 = Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing;
            testIrrigationSystem.InicializeCropIrrigationWeather(testCropIrrigationWeather_Pivot_05_NK900_2012,
                                                                testInitialPhenologicalStage_Maiz,
                                                                testDateBeginCrop_Pivot_05, testDateEndCrop_Pivot_05,
                                                                testCalculusOfPhenologicalStage_Pivot_05);

            testCalculusOfPhenologicalStage_Pivot_06 = Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing;
            testIrrigationSystem.InicializeCropIrrigationWeather(testCropIrrigationWeather_Pivot_06_SLP2_2010,
                                                                testInitialPhenologicalStage_Maiz,
                                                                testDateBeginCrop_Pivot_06, testDateEndCrop_Pivot_06,
                                                                testCalculusOfPhenologicalStage_Pivot_06);

            testCalculusOfPhenologicalStage_Pivot_07 = Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing;
            testIrrigationSystem.InicializeCropIrrigationWeather(testCropIrrigationWeather_Pivot_07_SLP2_2012,
                                                                testInitialPhenologicalStage_Maiz,
                                                                testDateBeginCrop_Pivot_07, testDateEndCrop_Pivot_07,
                                                                testCalculusOfPhenologicalStage_Pivot_07);

            testCalculusOfPhenologicalStage_Pivot_08 = Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing;
            testIrrigationSystem.InicializeCropIrrigationWeather(testCropIrrigationWeather_Pivot_08_SLP2_2013,
                                                                testInitialPhenologicalStage_Maiz,
                                                                testDateBeginCrop_Pivot_08, testDateEndCrop_Pivot_08,
                                                                testCalculusOfPhenologicalStage_Pivot_08);

            testCalculusOfPhenologicalStage_Pivot_09 = Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing;
            testIrrigationSystem.InicializeCropIrrigationWeather(testCropIrrigationWeather_Pivot_09_SLP5_2013,
                                                                testInitialPhenologicalStage_Maiz,
                                                                testDateBeginCrop_Pivot_09, testDateEndCrop_Pivot_09,
                                                                testCalculusOfPhenologicalStage_Pivot_09);

            testCalculusOfPhenologicalStage_Pivot_10 = Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing;
            testIrrigationSystem.InicializeCropIrrigationWeather(testCropIrrigationWeather_Pivot_10_SL_Soja_2013,
                                                                testInitialPhenologicalStage_Soja,
                                                                testDateBeginCrop_Pivot_10, testDateEndCrop_Pivot_10,
                                                                testCalculusOfPhenologicalStage_Pivot_10);

            testCalculusOfPhenologicalStage_Pivot_11 = Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing;
            testIrrigationSystem.InicializeCropIrrigationWeather(testCropIrrigationWeather_Pivot_11_LP_Soja_2010,
                                                                testInitialPhenologicalStage_Soja,
                                                                testDateBeginCrop_Pivot_11, testDateEndCrop_Pivot_11,
                                                                testCalculusOfPhenologicalStage_Pivot_11);

            testCalculusOfPhenologicalStage_Pivot_12 = Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing;
            testIrrigationSystem.InicializeCropIrrigationWeather(testCropIrrigationWeather_Pivot_12_LP_Soja_2011,
                                                                testInitialPhenologicalStage_Soja,
                                                                testDateBeginCrop_Pivot_12, testDateEndCrop_Pivot_12,
                                                                testCalculusOfPhenologicalStage_Pivot_12);

            testCalculusOfPhenologicalStage_Pivot_13 = Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing;
            testIrrigationSystem.InicializeCropIrrigationWeather(testCropIrrigationWeather_Pivot_13_LP_Soja_2012,
                                                                testInitialPhenologicalStage_Soja,
                                                                testDateBeginCrop_Pivot_13, testDateEndCrop_Pivot_13,
                                                                testCalculusOfPhenologicalStage_Pivot_13);

            #endregion

            #region 25.  Add Information of Rain
            testAddRainData();
            #endregion

            #region 26.  Add Information of Irrigation
            testAddIrrigationData();
            #endregion

            #region 27. Add Phenological Stege Ajustements
            PhenologicalStageChange_Pivot_01 = AddListOfPhenologicalStageAdjustments(FarmPivotList.Pivot_01_Maiz_2007);
            PhenologicalStageChange_Pivot_02 = AddListOfPhenologicalStageAdjustments(FarmPivotList.Pivot_02_Tammi_2008);
            PhenologicalStageChange_Pivot_03 = AddListOfPhenologicalStageAdjustments(FarmPivotList.Pivot_03_LaPerdiz_2010);
            PhenologicalStageChange_Pivot_04 = AddListOfPhenologicalStageAdjustments(FarmPivotList.Pivot_04_NK900_2010);
            PhenologicalStageChange_Pivot_05 = AddListOfPhenologicalStageAdjustments(FarmPivotList.Pivot_05_NK900_2012);
            PhenologicalStageChange_Pivot_06 = AddListOfPhenologicalStageAdjustments(FarmPivotList.Pivot_06_SLP2_2010);
            PhenologicalStageChange_Pivot_07 = AddListOfPhenologicalStageAdjustments(FarmPivotList.Pivot_07_SLP2_2012);
            PhenologicalStageChange_Pivot_08 = AddListOfPhenologicalStageAdjustments(FarmPivotList.Pivot_08_SLP2_2013);
            PhenologicalStageChange_Pivot_09 = AddListOfPhenologicalStageAdjustments(FarmPivotList.Pivot_09_SLP5_2013);
            PhenologicalStageChange_Pivot_10 = AddListOfPhenologicalStageAdjustments(FarmPivotList.Pivot_10_SL_Soja_2013);
            PhenologicalStageChange_Pivot_11 = AddListOfPhenologicalStageAdjustments(FarmPivotList.Pivot_11_LP_Soja_2010);
            PhenologicalStageChange_Pivot_12 = AddListOfPhenologicalStageAdjustments(FarmPivotList.Pivot_12_LP_Soja_2011);
            PhenologicalStageChange_Pivot_13 = AddListOfPhenologicalStageAdjustments(FarmPivotList.Pivot_13_LP_Soja_2012);
            #endregion

            #region 28. Add information to Irrigation Units to calculate lIrrigationItem for each one
            //AddDataIrrigationUnit(testCropIrrigationWeather_Pivot_01_Maiz_2007, FarmPivotList.Pivot_01_Maiz_2007);
            //AddDataIrrigationUnit(testCropIrrigationWeather_Pivot_02_Tammi_2008, FarmPivotList.Pivot_02_Tammi_2008);
            AddDataIrrigationUnit(testCropIrrigationWeather_Pivot_03_LaPerdiz_2010, FarmPivotList.Pivot_03_LaPerdiz_2010);
            AddDataIrrigationUnit(testCropIrrigationWeather_Pivot_04_NK900_2010, FarmPivotList.Pivot_04_NK900_2010);
            AddDataIrrigationUnit(testCropIrrigationWeather_Pivot_05_NK900_2012, FarmPivotList.Pivot_05_NK900_2012);
            AddDataIrrigationUnit(testCropIrrigationWeather_Pivot_06_SLP2_2010, FarmPivotList.Pivot_06_SLP2_2010);
            AddDataIrrigationUnit(testCropIrrigationWeather_Pivot_07_SLP2_2012, FarmPivotList.Pivot_07_SLP2_2012);
            AddDataIrrigationUnit(testCropIrrigationWeather_Pivot_08_SLP2_2013, FarmPivotList.Pivot_08_SLP2_2013);
            AddDataIrrigationUnit(testCropIrrigationWeather_Pivot_09_SLP5_2013, FarmPivotList.Pivot_09_SLP5_2013);
            //AddDataIrrigationUnit(testCropIrrigationWeather_Pivot_10_SL_Soja_2013, FarmPivotList.Pivot_10_SL_Soja_2013);
            //AddDataIrrigationUnit(testCropIrrigationWeather_Pivot_11_LP_Soja_2010, FarmPivotList.Pivot_11_LP_Soja_2010);
            //AddDataIrrigationUnit(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, FarmPivotList.Pivot_12_LP_Soja_2011);
            //AddDataIrrigationUnit(testCropIrrigationWeather_Pivot_13_LP_Soja_2012, FarmPivotList.Pivot_13_LP_Soja_2012);
            #endregion

            #region 29. Layout from Irrigation Units
            textLogPivot_01 = testCropIrrigationWeather_Pivot_01_Maiz_2007.OutPut;
            textLogPivot_02 = testCropIrrigationWeather_Pivot_02_Tammi_2008.OutPut;
            textLogPivot_03 = testCropIrrigationWeather_Pivot_03_LaPerdiz_2010.OutPut;
            textLogPivot_01 = testCropIrrigationWeather_Pivot_04_NK900_2010.OutPut;
            textLogPivot_02 = testCropIrrigationWeather_Pivot_05_NK900_2012.OutPut;
            textLogPivot_03 = testCropIrrigationWeather_Pivot_06_SLP2_2010.OutPut;
            textLogPivot_01 = testCropIrrigationWeather_Pivot_07_SLP2_2012.OutPut;
            textLogPivot_02 = testCropIrrigationWeather_Pivot_08_SLP2_2013.OutPut;
            textLogPivot_03 = testCropIrrigationWeather_Pivot_09_SLP5_2013.OutPut;
            textLogPivot_01 = testCropIrrigationWeather_Pivot_10_SL_Soja_2013.OutPut;
            textLogPivot_01 = testCropIrrigationWeather_Pivot_11_LP_Soja_2010.OutPut;
            textLogPivot_02 = testCropIrrigationWeather_Pivot_12_LP_Soja_2011.OutPut;
            textLogPivot_03 = testCropIrrigationWeather_Pivot_13_LP_Soja_2012.OutPut;
            #endregion

            #region 30. Layout from System the daily records
            textLogPivot_01 += Environment.NewLine + Environment.NewLine + testIrrigationSystem.printDailyRecordsList(testCropIrrigationWeather_Pivot_01_Maiz_2007);
            textLogPivot_02 += Environment.NewLine + Environment.NewLine + testIrrigationSystem.printDailyRecordsList(testCropIrrigationWeather_Pivot_02_Tammi_2008);
            textLogPivot_03 += Environment.NewLine + Environment.NewLine + testIrrigationSystem.printDailyRecordsList(testCropIrrigationWeather_Pivot_03_LaPerdiz_2010);
            textLogPivot_04 += Environment.NewLine + Environment.NewLine + testIrrigationSystem.printDailyRecordsList(testCropIrrigationWeather_Pivot_04_NK900_2010);
            textLogPivot_05 += Environment.NewLine + Environment.NewLine + testIrrigationSystem.printDailyRecordsList(testCropIrrigationWeather_Pivot_05_NK900_2012);
            textLogPivot_06 += Environment.NewLine + Environment.NewLine + testIrrigationSystem.printDailyRecordsList(testCropIrrigationWeather_Pivot_06_SLP2_2010);
            textLogPivot_07 += Environment.NewLine + Environment.NewLine + testIrrigationSystem.printDailyRecordsList(testCropIrrigationWeather_Pivot_07_SLP2_2012);
            textLogPivot_08 += Environment.NewLine + Environment.NewLine + testIrrigationSystem.printDailyRecordsList(testCropIrrigationWeather_Pivot_08_SLP2_2013);
            textLogPivot_09 += Environment.NewLine + Environment.NewLine + testIrrigationSystem.printDailyRecordsList(testCropIrrigationWeather_Pivot_09_SLP5_2013);
            textLogPivot_10 += Environment.NewLine + Environment.NewLine + testIrrigationSystem.printDailyRecordsList(testCropIrrigationWeather_Pivot_10_SL_Soja_2013);
            textLogPivot_11 += Environment.NewLine + Environment.NewLine + testIrrigationSystem.printDailyRecordsList(testCropIrrigationWeather_Pivot_11_LP_Soja_2010);
            textLogPivot_12 += Environment.NewLine + Environment.NewLine + testIrrigationSystem.printDailyRecordsList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011);
            textLogPivot_13 += Environment.NewLine + Environment.NewLine + testIrrigationSystem.printDailyRecordsList(testCropIrrigationWeather_Pivot_13_LP_Soja_2012);
            #endregion

            #region 31. Layout in txt format
            this.printSystemData(textLogPivot_01, "IrrigationSystemTestPivot_01_Maiz_2007");
            this.printSystemData(textLogPivot_02, "IrrigationSystemTestPivot_02_Tammi_2008");
            this.printSystemData(textLogPivot_03, "IrrigationSystemTestPivot_03_LaPerdiz_2010");
            this.printSystemData(textLogPivot_04, "IrrigationSystemTestPivot_04_NK900_2010");
            this.printSystemData(textLogPivot_05, "IrrigationSystemTestPivot_05_NK900_2012");
            this.printSystemData(textLogPivot_06, "IrrigationSystemTestPivot_06_SLP2_2010");
            this.printSystemData(textLogPivot_07, "IrrigationSystemTestPivot_07_SLP2_2012");
            this.printSystemData(textLogPivot_08, "IrrigationSystemTestPivot_08_SLP2_2013");
            this.printSystemData(textLogPivot_09, "IrrigationSystemTestPivot_09_SLP5_2013");
            this.printSystemData(textLogPivot_10, "IrrigationSystemTestPivot_10_SL_Soja_2013");
            this.printSystemData(textLogPivot_11, "IrrigationSystemTestPivot_11_LP_Soja_2010");
            this.printSystemData(textLogPivot_12, "IrrigationSystemTestPivot_12_LP_Soja_2011");
            this.printSystemData(textLogPivot_13, "IrrigationSystemTestPivot_13_LP_Soja_2012");
            #endregion

            #region 32. Layout in CSV format
            this.printSystemDataCSV("IrrigationSystem-Pivot_01_Maiz_2007-", testCropIrrigationWeather_Pivot_01_Maiz_2007.Titles, testCropIrrigationWeather_Pivot_01_Maiz_2007.Messages);
            this.printSystemDataCSV("IrrigationSystem-Pivot_02_Tammi_2008-", testCropIrrigationWeather_Pivot_02_Tammi_2008.Titles, testCropIrrigationWeather_Pivot_02_Tammi_2008.Messages);
            this.printSystemDataCSV("IrrigationSystem-Pivot_03_LaPerdiz_2010-", testCropIrrigationWeather_Pivot_03_LaPerdiz_2010.Titles, testCropIrrigationWeather_Pivot_03_LaPerdiz_2010.Messages);
            this.printSystemDataCSV("IrrigationSystem-Pivot_04_NK900_2010-", testCropIrrigationWeather_Pivot_04_NK900_2010.Titles, testCropIrrigationWeather_Pivot_04_NK900_2010.Messages);
            this.printSystemDataCSV("IrrigationSystem-Pivot_05_NK900_2012-", testCropIrrigationWeather_Pivot_05_NK900_2012.Titles, testCropIrrigationWeather_Pivot_05_NK900_2012.Messages);
            this.printSystemDataCSV("IrrigationSystem-Pivot_06_SLP2_2010-", testCropIrrigationWeather_Pivot_06_SLP2_2010.Titles, testCropIrrigationWeather_Pivot_06_SLP2_2010.Messages);
            this.printSystemDataCSV("IrrigationSystem-Pivot_07_SLP2_2012-", testCropIrrigationWeather_Pivot_07_SLP2_2012.Titles, testCropIrrigationWeather_Pivot_07_SLP2_2012.Messages);
            this.printSystemDataCSV("IrrigationSystem-Pivot_08_SLP2_2013-", testCropIrrigationWeather_Pivot_08_SLP2_2013.Titles, testCropIrrigationWeather_Pivot_08_SLP2_2013.Messages);
            this.printSystemDataCSV("IrrigationSystem-Pivot_09_SLP5_2013-", testCropIrrigationWeather_Pivot_09_SLP5_2013.Titles, testCropIrrigationWeather_Pivot_09_SLP5_2013.Messages);
            this.printSystemDataCSV("IrrigationSystem-Pivot_10_SL_Soja_2013-", testCropIrrigationWeather_Pivot_10_SL_Soja_2013.Titles, testCropIrrigationWeather_Pivot_10_SL_Soja_2013.Messages);
            this.printSystemDataCSV("IrrigationSystem-Pivot_11_LP_Soja_2010-", testCropIrrigationWeather_Pivot_11_LP_Soja_2010.Titles, testCropIrrigationWeather_Pivot_11_LP_Soja_2010.Messages);
            this.printSystemDataCSV("IrrigationSystem-Pivot_12_LP_Soja_2011-", testCropIrrigationWeather_Pivot_12_LP_Soja_2011.Titles, testCropIrrigationWeather_Pivot_12_LP_Soja_2011.Messages);
            this.printSystemDataCSV("IrrigationSystem-Pivot_13_LP_Soja_2012-", testCropIrrigationWeather_Pivot_13_LP_Soja_2012.Titles, testCropIrrigationWeather_Pivot_13_LP_Soja_2012.Messages);

            this.printSystemDataCSV("IrrigationSystem-DailyRecords-Pivot_01_Maiz_2007-", testCropIrrigationWeather_Pivot_01_Maiz_2007.TitlesDaily, testCropIrrigationWeather_Pivot_01_Maiz_2007.MessagesDaily);
            this.printSystemDataCSV("IrrigationSystem-DailyRecords-Pivot_02_Tammi_2008-", testCropIrrigationWeather_Pivot_02_Tammi_2008.TitlesDaily, testCropIrrigationWeather_Pivot_02_Tammi_2008.MessagesDaily);
            this.printSystemDataCSV("IrrigationSystem-DailyRecords-Pivot_03_LaPerdiz_2010-", testCropIrrigationWeather_Pivot_03_LaPerdiz_2010.TitlesDaily, testCropIrrigationWeather_Pivot_03_LaPerdiz_2010.MessagesDaily);
            this.printSystemDataCSV("IrrigationSystem-DailyRecords-Pivot_04_NK900_2010-", testCropIrrigationWeather_Pivot_04_NK900_2010.TitlesDaily, testCropIrrigationWeather_Pivot_04_NK900_2010.MessagesDaily);
            this.printSystemDataCSV("IrrigationSystem-DailyRecords-Pivot_05_NK900_2012-", testCropIrrigationWeather_Pivot_05_NK900_2012.TitlesDaily, testCropIrrigationWeather_Pivot_05_NK900_2012.MessagesDaily);
            this.printSystemDataCSV("IrrigationSystem-DailyRecords-Pivot_06_SLP2_2010-", testCropIrrigationWeather_Pivot_06_SLP2_2010.TitlesDaily, testCropIrrigationWeather_Pivot_06_SLP2_2010.MessagesDaily);
            this.printSystemDataCSV("IrrigationSystem-DailyRecords-Pivot_07_SLP2_2012-", testCropIrrigationWeather_Pivot_07_SLP2_2012.TitlesDaily, testCropIrrigationWeather_Pivot_07_SLP2_2012.MessagesDaily);
            this.printSystemDataCSV("IrrigationSystem-DailyRecords-Pivot_08_SLP2_2013-", testCropIrrigationWeather_Pivot_08_SLP2_2013.TitlesDaily, testCropIrrigationWeather_Pivot_08_SLP2_2013.MessagesDaily);
            this.printSystemDataCSV("IrrigationSystem-DailyRecords-Pivot_09_SLP5_2013-", testCropIrrigationWeather_Pivot_09_SLP5_2013.TitlesDaily, testCropIrrigationWeather_Pivot_09_SLP5_2013.MessagesDaily);
            this.printSystemDataCSV("IrrigationSystem-DailyRecords-Pivot_10_SL_Soja_2013-", testCropIrrigationWeather_Pivot_10_SL_Soja_2013.TitlesDaily, testCropIrrigationWeather_Pivot_10_SL_Soja_2013.MessagesDaily);
            this.printSystemDataCSV("IrrigationSystem-DailyRecords-Pivot_11_LP_Soja_2010-", testCropIrrigationWeather_Pivot_11_LP_Soja_2010.TitlesDaily, testCropIrrigationWeather_Pivot_11_LP_Soja_2010.MessagesDaily);
            this.printSystemDataCSV("IrrigationSystem-DailyRecords-Pivot_12_LP_Soja_2011-", testCropIrrigationWeather_Pivot_12_LP_Soja_2011.TitlesDaily, testCropIrrigationWeather_Pivot_12_LP_Soja_2011.MessagesDaily);
            this.printSystemDataCSV("IrrigationSystem-DailyRecords-Pivot_13_LP_Soja_2012-", testCropIrrigationWeather_Pivot_13_LP_Soja_2012.TitlesDaily, testCropIrrigationWeather_Pivot_13_LP_Soja_2012.MessagesDaily);
            #endregion

        }

        #region Private Helpers


        /// <summary>
        /// Pre: Specie, Region, Phenological Stage List, Crop Density, MaxEvapotranspiration to irrigate
        /// Pos: Crop for all Pivots
        /// </summary>
        private void addCrops_Farm()
        {
            
            testIrrigationSystem.AddCrop(testCrop_Maiz_Sur);
            testIrrigationSystem.AddCrop(testCrop_Soja_Sur);

        }

        /// <summary>
        /// Create Irrigation Unit, List of Irrigation, List of Crop.
        /// </summary>
        private void createIrrigationUnits_Farm()
        {
            testIrrigationUnit_IrrigationList_Pivot_01_Maiz_2007 = new List<Pair<DateTime, double>>();
            testIrrigationUnit_CropList_Pivot_01_Maiz_2007 = new List<Crop>();
            testIU_Pivot_01_Maiz_2007 = testIrrigationSystem.AddIrrrigationUnit("Pivot 01", "Pivot", testEfficiency_Pivot_01,
                               testIrrigationUnit_IrrigationList_Pivot_01_Maiz_2007, testSurface_Pivot_01,
                               testIrrigationUnit_CropList_Pivot_01_Maiz_2007, testBomb, testLocationFarm);
            
            testIrrigationUnit_IrrigationList_Pivot_02_Tammi_2008 = new List<Pair<DateTime, double>>();
            testIrrigationUnit_CropList_Pivot_02_Tammi_2008 = new List<Crop>();
            testIU_Pivot_02_Tammi_2008 = testIrrigationSystem.AddIrrrigationUnit("Pivot 02", "Pivot", testEfficiency_Pivot_02,
                            testIrrigationUnit_IrrigationList_Pivot_02_Tammi_2008, testSurface_Pivot_02, 
                            testIrrigationUnit_CropList_Pivot_02_Tammi_2008, testBomb, testLocationFarm);
            
            testIrrigationUnit_IrrigationList_Pivot_03_LaPerdiz_2010 = new List<Pair<DateTime, double>>();
            testIrrigationUnit_CropList_Pivot_03_LaPerdiz_2010 = new List<Crop>();
            testIU_Pivot_03_LaPerdiz2010 = testIrrigationSystem.AddIrrrigationUnit("Pivot 03", "Pivot", testEfficiency_Pivot_03,
                            testIrrigationUnit_IrrigationList_Pivot_03_LaPerdiz_2010, testSurface_Pivot_03, 
                            testIrrigationUnit_CropList_Pivot_03_LaPerdiz_2010, testBomb, testLocationFarm);

            testIrrigationUnit_IrrigationList_Pivot_04_NK900_2010 = new List<Pair<DateTime, double>>();
            testIrrigationUnit_CropList_Pivot_04_NK900_2010 = new List<Crop>();
            testIU_Pivot_04_NK900_2010 = testIrrigationSystem.AddIrrrigationUnit("Pivot 04", "Pivot", testEfficiency_Pivot_04,
                            testIrrigationUnit_IrrigationList_Pivot_04_NK900_2010, testSurface_Pivot_04,
                            testIrrigationUnit_CropList_Pivot_04_NK900_2010, testBomb, testLocationFarm);

            testIrrigationUnit_IrrigationList_Pivot_05_NK900_2012 = new List<Pair<DateTime, double>>();
            testIrrigationUnit_CropList_Pivot_05_NK900_2012 = new List<Crop>();
            testIU_Pivot_05_NK900_2012 = testIrrigationSystem.AddIrrrigationUnit("Pivot 05", "Pivot", testEfficiency_Pivot_05,
                            testIrrigationUnit_IrrigationList_Pivot_05_NK900_2012, testSurface_Pivot_05,
                            testIrrigationUnit_CropList_Pivot_05_NK900_2012, testBomb, testLocationFarm);

            testIrrigationUnit_IrrigationList_Pivot_06_SLP2_2010 = new List<Pair<DateTime, double>>();
            testIrrigationUnit_CropList_Pivot_06_SLP2_2010 = new List<Crop>();
            testIU_Pivot_06_SLP2_2010 = testIrrigationSystem.AddIrrrigationUnit("Pivot 06", "Pivot", testEfficiency_Pivot_06,
                            testIrrigationUnit_IrrigationList_Pivot_06_SLP2_2010, testSurface_Pivot_06,
                            testIrrigationUnit_CropList_Pivot_06_SLP2_2010, testBomb, testLocationFarm);

            testIrrigationUnit_IrrigationList_Pivot_07_SLP2_2012 = new List<Pair<DateTime, double>>();
            testIrrigationUnit_CropList_Pivot_07_SLP2_2012 = new List<Crop>();
            testIU_Pivot_07_SLP2_2012 = testIrrigationSystem.AddIrrrigationUnit("Pivot 07", "Pivot", testEfficiency_Pivot_07,
                            testIrrigationUnit_IrrigationList_Pivot_07_SLP2_2012, testSurface_Pivot_07,
                            testIrrigationUnit_CropList_Pivot_07_SLP2_2012, testBomb, testLocationFarm);

            testIrrigationUnit_IrrigationList_Pivot_08_SLP2_2013 = new List<Pair<DateTime, double>>();
            testIrrigationUnit_CropList_Pivot_08_SLP2_2013 = new List<Crop>();
            testIU_Pivot_08_SLP2_2013 = testIrrigationSystem.AddIrrrigationUnit("Pivot 08", "Pivot", testEfficiency_Pivot_08,
                            testIrrigationUnit_IrrigationList_Pivot_08_SLP2_2013, testSurface_Pivot_08,
                            testIrrigationUnit_CropList_Pivot_08_SLP2_2013, testBomb, testLocationFarm);

            testIrrigationUnit_IrrigationList_Pivot_09_SLP5_2013 = new List<Pair<DateTime, double>>();
            testIrrigationUnit_CropList_Pivot_09_SLP5_2013 = new List<Crop>();
            testIU_Pivot_09_SLP5_2013 = testIrrigationSystem.AddIrrrigationUnit("Pivot 09", "Pivot", testEfficiency_Pivot_09,
                            testIrrigationUnit_IrrigationList_Pivot_09_SLP5_2013, testSurface_Pivot_09,
                            testIrrigationUnit_CropList_Pivot_09_SLP5_2013, testBomb, testLocationFarm);

            testIrrigationUnit_IrrigationList_Pivot_10_SL_Soja_2013 = new List<Pair<DateTime, double>>();
            testIrrigationUnit_CropList_Pivot_10_SL_Soja_2013 = new List<Crop>();
            testIU_Pivot_10_SL_Soja_2013 = testIrrigationSystem.AddIrrrigationUnit("Pivot 10", "Pivot", testEfficiency_Pivot_10,
                            testIrrigationUnit_IrrigationList_Pivot_10_SL_Soja_2013, testSurface_Pivot_10,
                            testIrrigationUnit_CropList_Pivot_10_SL_Soja_2013, testBomb, testLocationFarm);

            testIrrigationUnit_IrrigationList_Pivot_11_LP_Soja_2010 = new List<Pair<DateTime, double>>();
            testIrrigationUnit_CropList_Pivot_11_LP_Soja_2010 = new List<Crop>();
            testIU_Pivot_11_LP_Soja_2010 = testIrrigationSystem.AddIrrrigationUnit("Pivot 11", "Pivot", testEfficiency_Pivot_11,
                            testIrrigationUnit_IrrigationList_Pivot_11_LP_Soja_2010, testSurface_Pivot_11,
                            testIrrigationUnit_CropList_Pivot_11_LP_Soja_2010, testBomb, testLocationFarm);

            testIrrigationUnit_IrrigationList_Pivot_12_LP_Soja_2011 = new List<Pair<DateTime, double>>();
            testIrrigationUnit_CropList_Pivot_12_LP_Soja_2011 = new List<Crop>();
            testIU_Pivot_12_LP_Soja_2011 = testIrrigationSystem.AddIrrrigationUnit("Pivot 12", "Pivot", testEfficiency_Pivot_12,
                            testIrrigationUnit_IrrigationList_Pivot_12_LP_Soja_2011, testSurface_Pivot_12,
                            testIrrigationUnit_CropList_Pivot_12_LP_Soja_2011, testBomb, testLocationFarm);

            testIrrigationUnit_IrrigationList_Pivot_13_LP_Soja_2012 = new List<Pair<DateTime, double>>();
            testIrrigationUnit_CropList_Pivot_13_LP_Soja_2012 = new List<Crop>();
            testIU_Pivot_13_LP_Soja_2012 = testIrrigationSystem.AddIrrrigationUnit("Pivot 13", "Pivot", testEfficiency_Pivot_13,
                            testIrrigationUnit_IrrigationList_Pivot_13_LP_Soja_2012, testSurface_Pivot_13,
                            testIrrigationUnit_CropList_Pivot_13_LP_Soja_2012, testBomb, testLocationFarm);

        }

        /// <summary>
        /// Create Crop Irrigation Weather
        /// </summary>
        private void createCropIrrigationWeatherFarm()
        {
            testCropIrrigationWeather_Pivot_01_Maiz_2007 = testIrrigationSystem.AddCropIrrigationWeather
                                                    (testIU_Pivot_01_Maiz_2007, testCrop_Maiz_Sur, 
                                                    testWeatherStation_Pivot_01, 
                                                    testWeatherStationAlternative, testPREDETERMINATED_IRRIGATION, 
                                                    testLocationFarm, testSoil_Pivot_01);

            testCropIrrigationWeather_Pivot_02_Tammi_2008 = testIrrigationSystem.AddCropIrrigationWeather
                                                    (testIU_Pivot_02_Tammi_2008, testCrop_Maiz_Sur, 
                                                    testWeatherStation_Pivot_02,
                                                    testWeatherStationAlternative, testPREDETERMINATED_IRRIGATION, 
                                                    testLocationFarm, testSoil_Pivot_02);

            testCropIrrigationWeather_Pivot_03_LaPerdiz_2010 = testIrrigationSystem.AddCropIrrigationWeather
                                                    (testIU_Pivot_03_LaPerdiz2010, testCrop_Maiz_Sur, 
                                                    testWeatherStation_Pivot_03, 
                                                    testWeatherStationAlternative, testPREDETERMINATED_IRRIGATION, 
                                                    testLocationFarm, testSoil_Pivot_03);

            testCropIrrigationWeather_Pivot_04_NK900_2010 = testIrrigationSystem.AddCropIrrigationWeather
                                                    (testIU_Pivot_04_NK900_2010, testCrop_Maiz_Sur, 
                                                    testWeatherStation_Pivot_04,
                                                    testWeatherStationAlternative, testPREDETERMINATED_IRRIGATION,
                                                    testLocationFarm, testSoil_Pivot_04);

            testCropIrrigationWeather_Pivot_05_NK900_2012 = testIrrigationSystem.AddCropIrrigationWeather
                                                    (testIU_Pivot_05_NK900_2012, testCrop_Maiz_Sur,
                                                    testWeatherStation_Pivot_05,
                                                    testWeatherStationAlternative, testPREDETERMINATED_IRRIGATION,
                                                    testLocationFarm, testSoil_Pivot_05);

            testCropIrrigationWeather_Pivot_06_SLP2_2010 = testIrrigationSystem.AddCropIrrigationWeather
                                                    (testIU_Pivot_06_SLP2_2010, testCrop_Maiz_Sur,
                                                    testWeatherStation_Pivot_06,
                                                    testWeatherStationAlternative, testPREDETERMINATED_IRRIGATION,
                                                    testLocationFarm, testSoil_Pivot_06);

            testCropIrrigationWeather_Pivot_07_SLP2_2012 = testIrrigationSystem.AddCropIrrigationWeather
                                                    (testIU_Pivot_07_SLP2_2012, testCrop_Maiz_Sur,
                                                    testWeatherStation_Pivot_07,
                                                    testWeatherStationAlternative, testPREDETERMINATED_IRRIGATION,
                                                    testLocationFarm, testSoil_Pivot_07);

            testCropIrrigationWeather_Pivot_08_SLP2_2013 = testIrrigationSystem.AddCropIrrigationWeather
                                                    (testIU_Pivot_08_SLP2_2013, testCrop_Maiz_Sur,
                                                    testWeatherStation_Pivot_08,
                                                    testWeatherStationAlternative, testPREDETERMINATED_IRRIGATION,
                                                    testLocationFarm, testSoil_Pivot_08);

            testCropIrrigationWeather_Pivot_09_SLP5_2013 = testIrrigationSystem.AddCropIrrigationWeather
                                                    (testIU_Pivot_09_SLP5_2013, testCrop_Maiz_Sur,
                                                    testWeatherStation_Pivot_09,
                                                    testWeatherStationAlternative, testPREDETERMINATED_IRRIGATION,
                                                    testLocationFarm, testSoil_Pivot_09);

            testCropIrrigationWeather_Pivot_10_SL_Soja_2013 = testIrrigationSystem.AddCropIrrigationWeather
                                                    (testIU_Pivot_10_SL_Soja_2013, testCrop_Soja_Sur,
                                                    testWeatherStation_Pivot_10,
                                                    testWeatherStationAlternative, testPREDETERMINATED_IRRIGATION,
                                                    testLocationFarm, testSoil_Pivot_10);

            testCropIrrigationWeather_Pivot_11_LP_Soja_2010 = testIrrigationSystem.AddCropIrrigationWeather
                                                    (testIU_Pivot_11_LP_Soja_2010, testCrop_Soja_Sur,
                                                    testWeatherStation_Pivot_11,
                                                    testWeatherStationAlternative, testPREDETERMINATED_IRRIGATION,
                                                    testLocationFarm, testSoil_Pivot_11);

            testCropIrrigationWeather_Pivot_12_LP_Soja_2011 = testIrrigationSystem.AddCropIrrigationWeather
                                                    (testIU_Pivot_12_LP_Soja_2011, testCrop_Soja_Sur,
                                                    testWeatherStation_Pivot_12,
                                                    testWeatherStationAlternative, testPREDETERMINATED_IRRIGATION,
                                                    testLocationFarm, testSoil_Pivot_12);

            testCropIrrigationWeather_Pivot_13_LP_Soja_2012 = testIrrigationSystem.AddCropIrrigationWeather
                                                    (testIU_Pivot_13_LP_Soja_2012, testCrop_Soja_Sur,
                                                    testWeatherStation_Pivot_13,
                                                    testWeatherStationAlternative, testPREDETERMINATED_IRRIGATION,
                                                    testLocationFarm, testSoil_Pivot_13);

        }

        /// <summary>
        /// Add lRainItem data for each pivot
        /// </summary>
        private void testAddRainData()
        {
            // DATOS DE LLUVIA
            
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_01_Maiz_2007, new DateTime(2007, 11, 25), 15);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_01_Maiz_2007, new DateTime(2007, 12, 04), 20);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_01_Maiz_2007, new DateTime(2007, 12, 28), 20);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_01_Maiz_2007, new DateTime(2008, 01, 03), 20);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_01_Maiz_2007, new DateTime(2008, 01, 10), 15);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_01_Maiz_2007, new DateTime(2008, 01, 11), 4.8);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_01_Maiz_2007, new DateTime(2008, 01, 15), 23);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_01_Maiz_2007, new DateTime(2008, 01, 18), 07);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_01_Maiz_2007, new DateTime(2008, 01, 28), 10);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_01_Maiz_2007, new DateTime(2008, 02, 10), 07);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_01_Maiz_2007, new DateTime(2008, 02, 29), 12);

            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_02_Tammi_2008, new DateTime(2008, 10, 12), 07);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_02_Tammi_2008, new DateTime(2008, 10, 15), 3.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_02_Tammi_2008, new DateTime(2008, 10, 21), 15);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_02_Tammi_2008, new DateTime(2008, 10, 29), 20);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_02_Tammi_2008, new DateTime(2008, 11, 03), 25);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_02_Tammi_2008, new DateTime(2008, 11, 16), 20);

            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_03_LaPerdiz_2010, new DateTime(2010, 10, 20), 02);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_03_LaPerdiz_2010, new DateTime(2010, 10, 21), 03);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_03_LaPerdiz_2010, new DateTime(2010, 10, 23), 02);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_03_LaPerdiz_2010, new DateTime(2010, 10, 29), 06);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_03_LaPerdiz_2010, new DateTime(2010, 11, 05), 05);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_03_LaPerdiz_2010, new DateTime(2010, 11, 08), 47);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_03_LaPerdiz_2010, new DateTime(2010, 11, 20), 30);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_03_LaPerdiz_2010, new DateTime(2010, 11, 21), 22);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_03_LaPerdiz_2010, new DateTime(2010, 12, 13), 09);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_03_LaPerdiz_2010, new DateTime(2010, 12, 16), 14);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_03_LaPerdiz_2010, new DateTime(2010, 12, 17), 06);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_03_LaPerdiz_2010, new DateTime(2010, 12, 21), 14);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_03_LaPerdiz_2010, new DateTime(2010, 12, 23), 10);

            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_04_NK900_2010, new DateTime(2010, 10, 20), 02);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_04_NK900_2010, new DateTime(2010, 10, 21), 03);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_04_NK900_2010, new DateTime(2010, 10, 23), 02);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_04_NK900_2010, new DateTime(2010, 10, 29), 06);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_04_NK900_2010, new DateTime(2010, 11, 05), 05);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_04_NK900_2010, new DateTime(2010, 11, 08), 47);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_04_NK900_2010, new DateTime(2010, 11, 20), 30);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_04_NK900_2010, new DateTime(2010, 11, 21), 22);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_04_NK900_2010, new DateTime(2010, 12, 13), 09);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_04_NK900_2010, new DateTime(2010, 12, 16), 14);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_04_NK900_2010, new DateTime(2010, 12, 17), 06);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_04_NK900_2010, new DateTime(2010, 12, 21), 14);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_04_NK900_2010, new DateTime(2010, 12, 23), 10);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_04_NK900_2010, new DateTime(2011, 01, 11), 03);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_04_NK900_2010, new DateTime(2010, 02, 05), 16);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_04_NK900_2010, new DateTime(2010, 02, 07), 30);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_04_NK900_2010, new DateTime(2010, 02, 08), 56);

            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2012, 10, 10), 72);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2012, 10, 11), 23);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2012, 10, 12), 03);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2012, 10, 13), 05);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2012, 10, 14), 15);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2012, 10, 21), 110);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2012, 10, 22), 10);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2012, 10, 29), 35);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2012, 10, 30), 09);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2012, 11, 18), 12);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2012, 11, 22), 15);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2012, 11, 30), 31);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2012, 12, 02), 13);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2012, 12, 06), 56);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2012, 12, 07), 122);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2012, 12, 10), 72);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2012, 12, 15), 10);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2012, 12, 20), 117);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2013, 01, 04), 60);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2013, 01, 17), 20);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_05_NK900_2012, new DateTime(2013, 02, 04), 44);

            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2010, 11, 09), 16.3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2010, 11, 20), 18.3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2010, 11, 21), 17.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2010, 11, 29), 30);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2010, 12, 11), 3.6);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2010, 12, 12), 10.9);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2010, 12, 13), 14.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2010, 12, 14), 0.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2010, 12, 15), 11.2);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2011, 12, 16), 22.9);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2011, 12, 17), 11.4);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2011, 12, 22), 4.1);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2011, 12, 23), 10);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2011, 01, 12), 21.3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2011, 01, 22), 26.2);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2011, 01, 23), 0.3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2011, 01, 24), 12.4);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2011, 02, 01), 2.0);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2011, 02, 03), 42.6);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2011, 02, 16), 1.2);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2011, 02, 17), 24.2);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_06_SLP2_2010, new DateTime(2011, 02, 19), 13.8);

            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2012, 11, 23), 1.8);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2012, 11, 28), 2.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2012, 11, 30), 8.6);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2012, 12, 06), 85);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2012, 12, 10), 65);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2012, 12, 16), 18.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2012, 12, 20), 74.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2012, 12, 25), 83.8);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2012, 12, 31), 44.2);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2013, 01, 03), 6.7);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2013, 01, 17), 4);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2013, 01, 18), 7);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2013, 01, 24), 45);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2013, 01, 25), 34.3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2013, 01, 31), 11.8);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2013, 02, 02), 37.2);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2013, 02, 11), 20.6);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2013, 02, 16), 4);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2013, 02, 19), 3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2013, 02, 20), 7.2);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2013, 02, 22), 7.0);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_07_SLP2_2012, new DateTime(2013, 03, 02), 40);

            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2013, 10, 20), 11.7);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2013, 10, 26), 6.4);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2013, 11, 01), 45.7);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2013, 11, 04), 1.6);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2013, 11, 07), 22.6);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2013, 11, 08), 18.3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2013, 11, 10), 3.3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2013, 11, 15), 15.3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2013, 11, 19), 6.6);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2013, 11, 20), 5.6);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2013, 11, 26), 16.0);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2013, 11, 27), 15);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2013, 12, 04), 6.1);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2013, 12, 23), 11);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2013, 12, 26), 2.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2014, 01, 01), 109);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2014, 01, 02), 33);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2014, 01, 07), 80.3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_08_SLP2_2013, new DateTime(2014, 01, 08), 7.4);


            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_09_SLP5_2013, new DateTime(2013, 11, 10), 3.3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_09_SLP5_2013, new DateTime(2013, 11, 15), 15.3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_09_SLP5_2013, new DateTime(2013, 11, 19), 6.6);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_09_SLP5_2013, new DateTime(2013, 11, 20), 5.6);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_09_SLP5_2013, new DateTime(2013, 11, 26), 16.0);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_09_SLP5_2013, new DateTime(2013, 11, 27), 15);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_09_SLP5_2013, new DateTime(2013, 12, 06), 6.1);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_09_SLP5_2013, new DateTime(2013, 12, 25), 11);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_09_SLP5_2013, new DateTime(2014, 01, 01), 11.9);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_09_SLP5_2013, new DateTime(2014, 01, 02), 99.6);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_09_SLP5_2013, new DateTime(2014, 01, 07), 80.3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_09_SLP5_2013, new DateTime(2014, 01, 09), 7.4);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_09_SLP5_2013, new DateTime(2014, 01, 10), 28.2);

            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_10_SL_Soja_2013, new DateTime(2013, 11, 01), 45.7);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_10_SL_Soja_2013, new DateTime(2013, 11, 04), 1.6);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_10_SL_Soja_2013, new DateTime(2013, 11, 07), 22.6);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_10_SL_Soja_2013, new DateTime(2013, 11, 08), 18.3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_10_SL_Soja_2013, new DateTime(2013, 11, 10), 3.3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_10_SL_Soja_2013, new DateTime(2013, 11, 15), 15.3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_10_SL_Soja_2013, new DateTime(2013, 11, 19), 6.6);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_10_SL_Soja_2013, new DateTime(2013, 11, 20), 5.6);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_10_SL_Soja_2013, new DateTime(2013, 11, 26), 16.0);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_10_SL_Soja_2013, new DateTime(2013, 11, 27), 15);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_10_SL_Soja_2013, new DateTime(2013, 12, 04), 6.1);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_10_SL_Soja_2013, new DateTime(2013, 12, 23), 11);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_10_SL_Soja_2013, new DateTime(2013, 12, 26), 2.5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_10_SL_Soja_2013, new DateTime(2014, 01, 01), 109);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_10_SL_Soja_2013, new DateTime(2014, 01, 02), 33);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_10_SL_Soja_2013, new DateTime(2014, 01, 07), 80.3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_10_SL_Soja_2013, new DateTime(2014, 01, 08), 7.4);


            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_11_LP_Soja_2010, new DateTime(2010, 10, 20), 20);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_11_LP_Soja_2010, new DateTime(2010, 11, 08), 28);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_11_LP_Soja_2010, new DateTime(2010, 12, 11), 40);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_11_LP_Soja_2010, new DateTime(2011, 01, 11), 21);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_11_LP_Soja_2010, new DateTime(2011, 01, 20), 22);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_11_LP_Soja_2010, new DateTime(2011, 01, 24), 12);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_11_LP_Soja_2010, new DateTime(2011, 01, 25), 6);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_11_LP_Soja_2010, new DateTime(2011, 01, 28), 12.3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_11_LP_Soja_2010, new DateTime(2011, 01, 29), 10.8);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_11_LP_Soja_2010, new DateTime(2011, 02, 04), 20);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_11_LP_Soja_2010, new DateTime(2011, 02, 07), 49);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_11_LP_Soja_2010, new DateTime(2011, 02, 19), 26);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_11_LP_Soja_2010, new DateTime(2011, 02, 23), 49);


            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, new DateTime(2010, 12, 23), 10);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, new DateTime(2011, 01, 11), 3);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, new DateTime(2011, 01, 22), 2);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, new DateTime(2011, 01, 23), 5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, new DateTime(2011, 01, 24), 2);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, new DateTime(2011, 02, 05), 16);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, new DateTime(2011, 02, 07), 20);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, new DateTime(2011, 02, 08), 20);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, new DateTime(2011, 02, 17), 20);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, new DateTime(2011, 02, 21), 45);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, new DateTime(2011, 02, 28), 41);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, new DateTime(2011, 02, 29), 14);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, new DateTime(2011, 03, 01), 10);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, new DateTime(2011, 03, 06), 65);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, new DateTime(2011, 03, 12), 5);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, new DateTime(2011, 03, 13), 20);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, new DateTime(2011, 03, 19), 56);
            testIrrigationSystem.AddRainDataToList(testCropIrrigationWeather_Pivot_12_LP_Soja_2011, new DateTime(2011, 03, 26), 11);
            
           

        }

        /// <summary>
        /// Add Irrigation Data to System
        /// </summary>
        private void testAddIrrigationData()
        {
            DateTime lIrrigationDate;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;

            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = 
                new Pair<double, Utils.WaterInputType>(20, Utils.WaterInputType.Irrigation);
            lIsExtraIrrigation = true;
            //Pivot 01
            //Riego inicial
            lIrrigationDate = new DateTime(2015, 01, 25);
            //testIrrigationSystem.AddOrUpdateIrrigationDataToList
            //    (testCropIrrigationWeather_Pivot_01_Maiz_2007, lIrrigationDate, 
            //    lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);



        }


        private List<Pair<DateTime, Stage>> AddListOfPhenologicalStageAdjustments(FarmPivotList pPivot)
        {
            List<Pair<DateTime, Stage>> lPhenologicalStageChange;
            DateTime lDateTimeToChange;
            Stage lStageToChange;

            lPhenologicalStageChange = new List<Pair<DateTime, Stage>>();
            if (pPivot.Equals(FarmPivotList.Pivot_01_Maiz_2007))
            {
                //First Change
                lDateTimeToChange = new DateTime(2014, 11, 20);
                lStageToChange = new Stage(1, "Maiz v4", "4 Hojas");
                //lPhenologicalStageChange.Add(new Pair<DateTime, Stage>(lDateTimeToChange, lStageToChange));
                //Second Change
                lDateTimeToChange = new DateTime(2014, 11, 20);
                lStageToChange = new Stage(1, "Maiz v2", "2 Hojas");
                //lPhenologicalStageChange.Add(new Pair<DateTime, Stage>(lDateTimeToChange, lStageToChange));
            }
            
            if (pPivot.Equals(FarmPivotList.Pivot_02_Tammi_2008))
            {
                //First Change
                lDateTimeToChange = new DateTime(2014, 12, 25);
                lStageToChange = new Stage(1, "Soja v4", "4 Hojas");
                //lPhenologicalStageChange.Add(new Pair<DateTime, Stage>(lDateTimeToChange, lStageToChange));
                //Second Change
                lDateTimeToChange = new DateTime(2014, 12, 25);
                lStageToChange = new Stage(1, "Soja v4", "4 Hojas");
                //lPhenologicalStageChange.Add(new Pair<DateTime, Stage>(lDateTimeToChange, lStageToChange));
            }

            if (pPivot.Equals(FarmPivotList.Pivot_03_LaPerdiz_2010))
            {
                //First Change
                lDateTimeToChange = new DateTime(2015, 1, 5);
                lStageToChange = new Stage(1, "Maiz v9", "9 Hojas");
                //lPhenologicalStageChange.Add(new Pair<DateTime, Stage>(lDateTimeToChange, lStageToChange));
                
            }

            if (pPivot.Equals(FarmPivotList.Pivot_04_NK900_2010))
            {
                //First Change
                lDateTimeToChange = new DateTime(2015, 1, 5);
                lStageToChange = new Stage(1, "Maiz v9", "9 Hojas");
                //lPhenologicalStageChange.Add(new Pair<DateTime, Stage>(lDateTimeToChange, lStageToChange));

            }
            return lPhenologicalStageChange;
        }

        /// <summary>
        /// Adds Phenological Stage Change Data to Irrigation Unit
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pPivot"></param>
        private void AddDataIrrigationUnit(CropIrrigationWeather pCropIrrigationWeather, FarmPivotList pPivot)
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

                if (pPivot.Equals(FarmPivotList.Pivot_01_Maiz_2007))
                {
                    //Adjustment of Phenological Stage for Pivot2
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot_01)
                    {
                        if (item.First.Equals(lDateOfRecord))
                        {
                            testIrrigationSystem.AdjustmentPhenology(lCropIrrigationWeather, item.Second, lDateOfRecord);
                            break;
                        }
                    }
                }

                if (pPivot.Equals(FarmPivotList.Pivot_02_Tammi_2008))
                {
                    //Adjustment of Phenological Stage for Pivot3_4
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot_02)
                    {
                        if (item.First.Equals(lDateOfRecord))
                        {
                            testIrrigationSystem.AdjustmentPhenology(lCropIrrigationWeather, item.Second, lDateOfRecord);
                            break;
                        }
                    }
                }

                if (pPivot.Equals(FarmPivotList.Pivot_03_LaPerdiz_2010))
                {
                    //Adjustment of Phenological Stage for Pivot5
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot_03)
                    {
                        if (item.First.Equals(lDateOfRecord))
                        {
                            testIrrigationSystem.AdjustmentPhenology(lCropIrrigationWeather, item.Second, lDateOfRecord);
                            break;
                        }
                    }
                }

                if (pPivot.Equals(FarmPivotList.Pivot_04_NK900_2010))
                {
                    //Adjustment of Phenological Stage for Pivot5
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot_04)
                    {
                        if (item.First.Equals(lDateOfRecord))
                        {
                            testIrrigationSystem.AdjustmentPhenology(lCropIrrigationWeather, item.Second, lDateOfRecord);
                            break;
                        }
                    }
                }

                if (pPivot.Equals(FarmPivotList.Pivot_05_NK900_2012))
                {
                    //Adjustment of Phenological Stage for Pivot5
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot_05)
                    {
                        if (item.First.Equals(lDateOfRecord))
                        {
                            testIrrigationSystem.AdjustmentPhenology(lCropIrrigationWeather, item.Second, lDateOfRecord);
                            break;
                        }
                    }
                }

                if (pPivot.Equals(FarmPivotList.Pivot_06_SLP2_2010))
                {
                    //Adjustment of Phenological Stage for Pivot5
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot_06)
                    {
                        if (item.First.Equals(lDateOfRecord))
                        {
                            testIrrigationSystem.AdjustmentPhenology(lCropIrrigationWeather, item.Second, lDateOfRecord);
                            break;
                        }
                    }
                }

                if (pPivot.Equals(FarmPivotList.Pivot_07_SLP2_2012))
                {
                    //Adjustment of Phenological Stage for Pivot5
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot_07)
                    {
                        if (item.First.Equals(lDateOfRecord))
                        {
                            testIrrigationSystem.AdjustmentPhenology(lCropIrrigationWeather, item.Second, lDateOfRecord);
                            break;
                        }
                    }
                }

                if (pPivot.Equals(FarmPivotList.Pivot_08_SLP2_2013))
                {
                    //Adjustment of Phenological Stage for Pivot5
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot_08)
                    {
                        if (item.First.Equals(lDateOfRecord))
                        {
                            testIrrigationSystem.AdjustmentPhenology(lCropIrrigationWeather, item.Second, lDateOfRecord);
                            break;
                        }
                    }
                }

                if (pPivot.Equals(FarmPivotList.Pivot_09_SLP5_2013))
                {
                    //Adjustment of Phenological Stage for Pivot5
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot_09)
                    {
                        if (item.First.Equals(lDateOfRecord))
                        {
                            testIrrigationSystem.AdjustmentPhenology(lCropIrrigationWeather, item.Second, lDateOfRecord);
                            break;
                        }
                    }
                }

                if (pPivot.Equals(FarmPivotList.Pivot_10_SL_Soja_2013))
                {
                    //Adjustment of Phenological Stage for Pivot5
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot_10)
                    {
                        if (item.First.Equals(lDateOfRecord))
                        {
                            testIrrigationSystem.AdjustmentPhenology(lCropIrrigationWeather, item.Second, lDateOfRecord);
                            break;
                        }
                    }
                }

                if (pPivot.Equals(FarmPivotList.Pivot_11_LP_Soja_2010))
                {
                    //Adjustment of Phenological Stage for Pivot5
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot_11)
                    {
                        if (item.First.Equals(lDateOfRecord))
                        {
                            testIrrigationSystem.AdjustmentPhenology(lCropIrrigationWeather, item.Second, lDateOfRecord);
                            break;
                        }
                    }
                }

                if (pPivot.Equals(FarmPivotList.Pivot_12_LP_Soja_2011))
                {
                    //Adjustment of Phenological Stage for Pivot5
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot_12)
                    {
                        if (item.First.Equals(lDateOfRecord))
                        {
                            testIrrigationSystem.AdjustmentPhenology(lCropIrrigationWeather, item.Second, lDateOfRecord);
                            break;
                        }
                    }
                }

                if (pPivot.Equals(FarmPivotList.Pivot_13_LP_Soja_2012))
                {
                    //Adjustment of Phenological Stage for Pivot5
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot_13)
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
        private void createSoils_Farm()
        {

            #region Soils
            testSoil_Pivot_01 = testIrrigationSystem.AddSoil("Suelo Pivot 01", "Suelo Pivot 01", testLocationFarm, DateTime.MinValue, testSoil_Pivot_01_DepthLimit);
            testSoil_Pivot_02 = testIrrigationSystem.AddSoil("Suelo Pivot 02", "Suelo Pivot 02", testLocationFarm, DateTime.MinValue, testSoil_Pivot_02_DepthLimit);
            testSoil_Pivot_03 = testIrrigationSystem.AddSoil("Suelo Pivot 03", "Suelo Pivot 03", testLocationFarm, DateTime.MinValue, testSoil_Pivot_03_DepthLimit);
            testSoil_Pivot_04 = testIrrigationSystem.AddSoil("Suelo Pivot 04", "Suelo Pivot 04", testLocationFarm, DateTime.MinValue, testSoil_Pivot_04_DepthLimit);
            testSoil_Pivot_05 = testIrrigationSystem.AddSoil("Suelo Pivot 05", "Suelo Pivot 05", testLocationFarm, DateTime.MinValue, testSoil_Pivot_05_DepthLimit);
            testSoil_Pivot_06 = testIrrigationSystem.AddSoil("Suelo Pivot 06", "Suelo Pivot 06", testLocationFarm, DateTime.MinValue, testSoil_Pivot_06_DepthLimit);
            testSoil_Pivot_07 = testIrrigationSystem.AddSoil("Suelo Pivot 07", "Suelo Pivot 07", testLocationFarm, DateTime.MinValue, testSoil_Pivot_07_DepthLimit);
            testSoil_Pivot_08 = testIrrigationSystem.AddSoil("Suelo Pivot 08", "Suelo Pivot 08", testLocationFarm, DateTime.MinValue, testSoil_Pivot_08_DepthLimit);
            testSoil_Pivot_09 = testIrrigationSystem.AddSoil("Suelo Pivot 09", "Suelo Pivot 09", testLocationFarm, DateTime.MinValue, testSoil_Pivot_09_DepthLimit);
            testSoil_Pivot_10 = testIrrigationSystem.AddSoil("Suelo Pivot 10", "Suelo Pivot 10", testLocationFarm, DateTime.MinValue, testSoil_Pivot_10_DepthLimit);
            testSoil_Pivot_11 = testIrrigationSystem.AddSoil("Suelo Pivot 11", "Suelo Pivot 11", testLocationFarm, DateTime.MinValue, testSoil_Pivot_11_DepthLimit);
            testSoil_Pivot_12 = testIrrigationSystem.AddSoil("Suelo Pivot 12", "Suelo Pivot 12", testLocationFarm, DateTime.MinValue, testSoil_Pivot_12_DepthLimit);
            testSoil_Pivot_13 = testIrrigationSystem.AddSoil("Suelo Pivot 13", "Suelo Pivot 13", testLocationFarm, DateTime.MinValue, testSoil_Pivot_13_DepthLimit);
            #endregion

            #region horizon types
            Horizon horizon_A = new Horizon(1, "A", 0, "A", 14, 19, 53, 28, 4.4, 0, 1.2);
            Horizon horizon_AB = new Horizon(2, "AB", 1, "AB", 23, 18, 45, 37, 3, 0, 1.3);
            Horizon horizon_B = new Horizon(3, "B", 2, "B", 20, 19, 37, 44, 2, 0, 1.4);

            Horizon horizon_2A = new Horizon(1, "A", 0, "A", 14, 19, 53, 28, 4.4, 0, 1.2);
            Horizon horizon_2AB = new Horizon(2, "AB", 1, "AB", 23, 18, 45, 37, 3, 0, 1.3);
            Horizon horizon_2B = new Horizon(3, "B", 2, "B", 20, 19, 37, 44, 2, 0, 1.4);

            Horizon horizon_3_4A = new Horizon(1, "A", 0, "A", 15, 33, 40, 26, 4.4, 0, 1.3);
            Horizon horizon_3_4B = new Horizon(2, "B", 1, "B", 20, 20, 28, 52, 4.4, 0, 1.4);

            Horizon horizon_5A = new Horizon(1, "A", 0, "A",14, 19, 53, 28, 4.4, 0, 1.2);
            Horizon horizon_5AB = new Horizon(2, "AB", 1, "AB", 23, 18, 45, 37, 3, 0, 1.3);
            Horizon horizon_5B = new Horizon(3, "B", 2, "B", 20, 19, 37, 44, 2, 0, 1.4);
            #endregion

            #region Soils Add Horizons 
            testSoil_Pivot_01.HorizonList.Add(horizon_A);
            testSoil_Pivot_01.HorizonList.Add(horizon_AB);
            testSoil_Pivot_01.HorizonList.Add(horizon_B);

            testSoil_Pivot_02.HorizonList.Add(horizon_A);
            testSoil_Pivot_02.HorizonList.Add(horizon_AB);
            testSoil_Pivot_02.HorizonList.Add(horizon_B);

            testSoil_Pivot_03.HorizonList.Add(horizon_A);
            testSoil_Pivot_03.HorizonList.Add(horizon_AB);
            testSoil_Pivot_03.HorizonList.Add(horizon_B);

            testSoil_Pivot_04.HorizonList.Add(horizon_A);
            testSoil_Pivot_04.HorizonList.Add(horizon_AB);
            testSoil_Pivot_04.HorizonList.Add(horizon_B);

            testSoil_Pivot_05.HorizonList.Add(horizon_A);
            testSoil_Pivot_05.HorizonList.Add(horizon_AB);
            testSoil_Pivot_05.HorizonList.Add(horizon_B);

            testSoil_Pivot_06.HorizonList.Add(horizon_A);
            testSoil_Pivot_06.HorizonList.Add(horizon_AB);
            testSoil_Pivot_06.HorizonList.Add(horizon_B);

            testSoil_Pivot_07.HorizonList.Add(horizon_A);
            testSoil_Pivot_07.HorizonList.Add(horizon_AB);
            testSoil_Pivot_07.HorizonList.Add(horizon_B);

            testSoil_Pivot_08.HorizonList.Add(horizon_A);
            testSoil_Pivot_08.HorizonList.Add(horizon_AB);
            testSoil_Pivot_08.HorizonList.Add(horizon_B);

            testSoil_Pivot_09.HorizonList.Add(horizon_A);
            testSoil_Pivot_09.HorizonList.Add(horizon_AB);
            testSoil_Pivot_09.HorizonList.Add(horizon_B);

            testSoil_Pivot_10.HorizonList.Add(horizon_A);
            testSoil_Pivot_10.HorizonList.Add(horizon_AB);
            testSoil_Pivot_10.HorizonList.Add(horizon_B);

            testSoil_Pivot_11.HorizonList.Add(horizon_A);
            testSoil_Pivot_11.HorizonList.Add(horizon_AB);
            testSoil_Pivot_11.HorizonList.Add(horizon_B);

            testSoil_Pivot_12.HorizonList.Add(horizon_A);
            testSoil_Pivot_12.HorizonList.Add(horizon_AB);
            testSoil_Pivot_12.HorizonList.Add(horizon_B);

            testSoil_Pivot_13.HorizonList.Add(horizon_A);
            testSoil_Pivot_13.HorizonList.Add(horizon_AB);
            testSoil_Pivot_13.HorizonList.Add(horizon_B);
            #endregion

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
            lOutputFile.FileHeader = "Table with all the lIrrigationItem results.";
            lOutputFile.FileTitles = pTitles;
            lOutputFile.FileMessages = pMessages;
            lOutputFile.FileFooter = "Finish all the information.";

            //Writes the CSV file in the FilePath
            lOutputFile.WriteFile(lMethod, lDescription, lTime);


        }

        #endregion


    }
}


