using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IrrigationAdvisor.Models.IrrigationSystem;
using IrrigationAdvisor.Models.Crop;
using IrrigationAdvisor.Models.Location;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;

using IrrigationAdvisor.Models.Data;

namespace IrrigationAdvisor.Models.IrrigationSystem
{
    [TestClass]
    public class IrrigationSystemTest
    {
        #region Fields Santa Lucia Test
        private Position testPosition;
        private Country testCountry;
        private Region testRegion;
        private Location.Location testLocation;
        private Specie testSpecieSoja;
        private Specie testSpecieMaiz;

        private Soil soil_1;
        private Soil soil_2;
        private Soil soil_3_4;
        private Soil soil_5;
        private PhenologicalStage testInitialPhenologicalState;
        private CropCoefficient testCropCoefficientSoja;
        private CropCoefficient testCropCoefficientMaiz;
        private Bomb testBomb;
        private WeatherStation.WeatherStation testWeatherStation;
        
        
        enum SantaLuciaPivots
        {
            Pivot2,
            Pivot3_4,
            Pivot5
        };
        private Irrigation.IrrigationUnit testIU_Pivot_2;
        private Irrigation.IrrigationUnit testIU_Pivot_3_4;
        private Irrigation.IrrigationUnit testIU_Pivot_5;
        
        private Crop.Crop cropMaizPivot2;
        private Crop.Crop cropSojaPivot3_4;
        private Crop.Crop cropSojaPivot5;
        private CropIrrigationWeather cropIrrigWeatherPivot2;
        private CropIrrigationWeather cropIrrigWeatherPivot3_4;
        private CropIrrigationWeather cropIrrigWeatherPivot5;
        
        private double testSojaBaseTemp = 8;
        private double testMaizBaseTemp = 10;
        private double testPREDETERMINATED_IRRIGATION = 20;

        private List<PhenologicalStage> testPhenologicalStageList;
        private Pair<Region, List<PhenologicalStage>> testPhenologicalStagesForRegion;
        private List<EffectiveRain> testEffectiveRainsList;
        private Pair<Region, List<EffectiveRain>> testEffectiveRainsForRegion;
        

        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot2;
        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot3_4;
        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot5;

        private DateTime dateBeginCrop_Pivot2;
        private DateTime dateBeginCrop_Pivot3_4;
        private DateTime dateBeginCrop_Pivot5;

        private DateTime testWeatherDataStartDate;

        #endregion

        private IrrigationSystem irrigationSystem;
        /// <summary>
        /// this method is used to obtain the layout
        /// </summary>
        [TestMethod]
        public void santaLuciaTest()
        {   
            testWeatherDataStartDate = new DateTime(2014, 10, 18);

            testPosition = new Position(0,0);
            testRegion = new Region("Templada", testPosition);
            testCountry = new Country();
            testCountry.Name = "Uruguay";
            testLocation = createLocation(new Position(34, 55), testCountry, testRegion, new City("Santa Lucia", testPosition));

            testSpecieSoja = createSpecie(1, "Soja", testRegion, testSojaBaseTemp);
            testSpecieMaiz = createSpecie(1, "Maiz", testRegion, testMaizBaseTemp);

            dateBeginCrop_Pivot2 = new DateTime(2014, 10, 21);
            dateBeginCrop_Pivot3_4 = new DateTime(2014, 11, 14);
            dateBeginCrop_Pivot5 = new DateTime(2014, 10, 18);

            crearSuelosSantaLucia();
            
            irrigationSystem = new IrrigationSystem();

            testPhenologicalStageList = InitialTables.CreatePhenologicalStageList(irrigationSystem, testSpecieMaiz, testSpecieSoja);
            testPhenologicalStagesForRegion = new Pair<Region, List<PhenologicalStage>>(testRegion, testPhenologicalStageList);
            this.irrigationSystem.PhenologicalStageList.Add(testPhenologicalStagesForRegion);
            

            testEffectiveRainsList = InitialTables.AddEffectiveRainListToSystem(testRegion);
            testEffectiveRainsForRegion = new Pair<Region, List<EffectiveRain>>(testRegion, testEffectiveRainsList);
            this.irrigationSystem.EffectiveRainList.Add(testEffectiveRainsForRegion);

            crearCultivosSantaLucia();

            crearUnidadesDeRiegoSantaLucia();
            
            //Add Information of Weather
            ExternalData.AgregarDatosDelTiempo(irrigationSystem, testWeatherStation, testWeatherDataStartDate);

            //Add Information of Rain
            agregarDatosDeLluvia();

            //Add Information of Irrigation
            agregarDatosDeRiego();

            //Adding to system the Irrigation Unit (pivots)
            irrigationSystem.addCropIrrigWeatherToList(cropIrrigWeatherPivot2);
            irrigationSystem.addCropIrrigWeatherToList(cropIrrigWeatherPivot3_4);
            irrigationSystem.addCropIrrigWeatherToList(cropIrrigWeatherPivot5);

            
            String textLogPivot2 ;
            String textLogPivot3_4 ;
            String textLogPivot5 ;
            
            //Find the records of Crop Irrigation Unit (Pivots)
            CropIrrigationWeatherRecords recP2 = irrigationSystem.CropIrrigationWeatherRecordsList.Find(x => x.CropIrrigationWeather.Equals(cropIrrigWeatherPivot2));
            CropIrrigationWeatherRecords recP3_4 = irrigationSystem.CropIrrigationWeatherRecordsList.Find(x => x.CropIrrigationWeather.Equals(cropIrrigWeatherPivot3_4));
            CropIrrigationWeatherRecords recP5 = irrigationSystem.CropIrrigationWeatherRecordsList.Find(x => x.CropIrrigationWeather.Equals(cropIrrigWeatherPivot5));

            //Add Phenological Stege Ajustements
            PhenologicalStageChange_Pivot2 = AddListOfPhenologicalStageAdjustments(SantaLuciaPivots.Pivot2);
            PhenologicalStageChange_Pivot3_4 = AddListOfPhenologicalStageAdjustments(SantaLuciaPivots.Pivot3_4);
            PhenologicalStageChange_Pivot5 = AddListOfPhenologicalStageAdjustments(SantaLuciaPivots.Pivot5);

            //Add information to Irrigation Units to calculate irrigation for each one
            AddDataIrrigationUnit(cropIrrigWeatherPivot2, SantaLuciaPivots.Pivot2);
            AddDataIrrigationUnit(cropIrrigWeatherPivot3_4, SantaLuciaPivots.Pivot3_4);
            AddDataIrrigationUnit(cropIrrigWeatherPivot5, SantaLuciaPivots.Pivot5);
            
            //Layout from Irrigation Units
            textLogPivot2 = recP2.OutPut;
            textLogPivot3_4 = recP3_4.OutPut;
            textLogPivot5 = recP5.OutPut;

            //Layout from System the daily records
            textLogPivot2 += Environment.NewLine + Environment.NewLine + irrigationSystem.printDailyRecordsList(recP2);
            textLogPivot3_4 += Environment.NewLine + Environment.NewLine + irrigationSystem.printDailyRecordsList(recP3_4);
            textLogPivot5 += Environment.NewLine + Environment.NewLine + irrigationSystem.printDailyRecordsList(recP5);


            //Layout in txt format
            this.printSystemData(textLogPivot2, "IrrigationSystemTestPivot2");
            this.printSystemData(textLogPivot3_4, "IrrigationSystemTestPivot3_4");
            this.printSystemData(textLogPivot5, "IrrigationSystemTestPivot5");

            //Layout in CSV format
            this.printSystemDataCSV("IrrigationSystem-TestPivot2-", recP2.Titles, recP2.Messages);
            this.printSystemDataCSV("IrrigationSystem-TestPivot3_4-", recP3_4.Titles, recP3_4.Messages);
            this.printSystemDataCSV("IrrigationSystem-TestPivot5-", recP5.Titles, recP5.Messages);

            this.printSystemDataCSV("IrrigationSystem-DailyRecords-TestPivot2-", recP2.TitlesDaily, recP2.MessagesDaily);
            this.printSystemDataCSV("IrrigationSystem-DailyRecords-TestPivot3_4-", recP3_4.TitlesDaily, recP3_4.MessagesDaily);
            this.printSystemDataCSV("IrrigationSystem-DailyRecords-TestPivot5-", recP5.TitlesDaily, recP5.MessagesDaily);

        }

        private List<Pair<DateTime, Stage>> AddListOfPhenologicalStageAdjustments(SantaLuciaPivots pPivot)
        {
            List<Pair<DateTime, Stage>> lPhenologicalStageChange;
            DateTime lDateTimeToChange;
            Stage lStageToChange;

            lPhenologicalStageChange = new List<Pair<DateTime, Stage>>();
            if (pPivot.Equals(SantaLuciaPivots.Pivot2))
            {
                //First Change
                lDateTimeToChange = new DateTime(2014, 11, 20);
                lStageToChange = new Stage(1, "v2", "2 Hojas");
                lPhenologicalStageChange.Add(new Pair<DateTime, Stage>(lDateTimeToChange, lStageToChange));
                //Second Change
                //lDateTimeToChange = new DateTime(2014, 11, 20);
                //lStageToChange = new Stage(1, "v2", "2 Hojas");
                //lPhenologicalStageChange.Add(new Pair<DateTime, Stage>(lDateTimeToChange, lStageToChange));
            }
            
            if (pPivot.Equals(SantaLuciaPivots.Pivot3_4))
            {
                //First Change
                lDateTimeToChange = new DateTime(2014, 12, 25);
                lStageToChange = new Stage(1, "v4", "4 Hojas");
                lPhenologicalStageChange.Add(new Pair<DateTime, Stage>(lDateTimeToChange, lStageToChange));
                //Second Change
                //lDateTimeToChange = new DateTime(2014, 12, 25);
                //lStageToChange = new Stage(1, "v4", "4 Hojas");
                //lPhenologicalStageChange.Add(new Pair<DateTime, Stage>(lDateTimeToChange, lStageToChange));
            }

            if (pPivot.Equals(SantaLuciaPivots.Pivot5))
            {
                //First Change
                //lDateTimeToChange = new DateTime(2015, 1, 5);
                //lStageToChange = new Stage(1, "v9", "9 Hojas");
                //lPhenologicalStageChange.Add(new Pair<DateTime, Stage>(lDateTimeToChange, lStageToChange));
                
            }
            return lPhenologicalStageChange;
        }

        /// <summary>
        /// Adds Data to Irrigation Unit
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pPivot"></param>
        private void AddDataIrrigationUnit(CropIrrigationWeather pCropIrrigationWeather, SantaLuciaPivots pPivot)
        {
            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            CropIrrigationWeather lCropIrrigationWeather;
            DateTime lDateOfRecord;
            String lObservation;

            //The start day is one day after sowing because the first day is created when the testCrop is created
            lFromDate = pCropIrrigationWeather.Crop.SowingDate.AddDays(1);
            lToDate = DateTime.Now.AddDays(7);

            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;
            lCropIrrigationWeather = pCropIrrigationWeather;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);
                irrigationSystem.addDailyRecordToList(lCropIrrigationWeather, lDateOfRecord, lObservation);

                if (pPivot.Equals(SantaLuciaPivots.Pivot2))
                {
                    //Adjustment of Phenological Stage for Pivot2
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot2)
                    {
                        if (item.First.Equals(lDateOfRecord))
                        {
                            irrigationSystem.adjustmentPhenology(lCropIrrigationWeather, item.Second, lDateOfRecord);
                            break;
                        }
                    }
                }
                if (pPivot.Equals(SantaLuciaPivots.Pivot3_4))
                {
                    //Adjustment of Phenological Stage for Pivot3_4
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot3_4)
                    {
                        if (item.First.Equals(lDateOfRecord))
                        {
                            irrigationSystem.adjustmentPhenology(lCropIrrigationWeather, item.Second, lDateOfRecord);
                            break;
                        }
                    }
                }
                if (pPivot.Equals(SantaLuciaPivots.Pivot5))
                {
                    //Adjustment of Phenological Stage for Pivot5
                    foreach (Pair<DateTime, Stage> item in PhenologicalStageChange_Pivot5)
                    {
                        if (item.First.Equals(lDateOfRecord))
                        {
                            irrigationSystem.adjustmentPhenology(lCropIrrigationWeather, item.Second, lDateOfRecord);
                            break;
                        }
                    }
                }
            }
        }

        

        /// <summary>
        /// 
        /// </summary>
        private void crearUnidadesDeRiegoSantaLucia()
        {
            testBomb = new Bomb("Bomba1", 1234, DateTime.Now, DateTime.Now, testLocation);

            testIU_Pivot_2 = creteIrrigationUnit(1, "Pivot 2", "Pivot",
                            0.85, new List<Utilities.Pair<DateTime, double>>(), 300, 
                            new List<Crop.Crop>(), testBomb, testLocation);

            testIU_Pivot_3_4 = creteIrrigationUnit(2, "Pivot 3 y 4", "Pivot",
                            0.85, new List<Utilities.Pair<DateTime, double>>(), 300, 
                            new List<Crop.Crop>(), testBomb, testLocation);

            testIU_Pivot_5 = creteIrrigationUnit(3, "Pivot 5", "Pivot",
                            0.85, new List<Utilities.Pair<DateTime, double>>(), 300, 
                            new List<Crop.Crop>(), testBomb, testLocation);

            testWeatherStation = new WeatherStation.WeatherStation(1, "WeatherStation1", "Model?", DateTime.Now, DateTime.Now, DateTime.Now, 1, testLocation, true);

            cropIrrigWeatherPivot2 = new CropIrrigationWeather(testIU_Pivot_2, cropMaizPivot2, testWeatherStation, null, testPREDETERMINATED_IRRIGATION);
            cropIrrigWeatherPivot3_4 = new CropIrrigationWeather(testIU_Pivot_3_4, cropSojaPivot3_4, testWeatherStation, null, testPREDETERMINATED_IRRIGATION);
            cropIrrigWeatherPivot5 = new CropIrrigationWeather(testIU_Pivot_5, cropSojaPivot5, testWeatherStation, null, testPREDETERMINATED_IRRIGATION);


        }

        private void crearCultivosSantaLucia()
        {
            /*
             * 2.- Densidad de cultivo:
                2.1.- Maíz:
                Predeterminada 80.000 pl/ha
                Alta: más de 90.000 pl/ha. En este caso tomar el kc correspondiente a región Árida
                Baja: por el momento nada
 
                2.2.- Soja
                Predeterminada: 350.000 pl/ha
                Alta: más de 400.000 pl/ha. En este caso tomar kc correspondiente a región Árida
                Baja: por el momento nada
             */
            double lMaizMaxEvaporTransptoIrrigate = 35;
            double lSojaMaxEvaporTransptoIrrigate = 35;
            double cropDensityMaiz = 80000;
            double cropDensitySoja = 350000;

            
            testCropCoefficientMaiz = Data.InitialTables.CreateMaizCropCoefficientWithList(testSpecieMaiz, testRegion);
            testCropCoefficientSoja = Data.InitialTables.CreateSojaCropCoefficientWithList(testSpecieSoja, testRegion);

            testInitialPhenologicalState = new PhenologicalStage(1, testSpecieMaiz, new Stage(1, "v0", "Sin hojas"), 0, 60, 5);

            cropMaizPivot2 = createCrop(1, "Maiz SantaLucia Pivot 2", testSpecieMaiz, testLocation, testCropCoefficientMaiz, cropDensityMaiz,
                testInitialPhenologicalState, dateBeginCrop_Pivot2, DateTime.Now, soil_2, lMaizMaxEvaporTransptoIrrigate);

            cropSojaPivot3_4 = createCrop(1, "Soja SantaLucia Pivot 3 4", testSpecieSoja, testLocation, testCropCoefficientSoja, cropDensitySoja,
                            testInitialPhenologicalState, dateBeginCrop_Pivot3_4, DateTime.Now, soil_3_4, lSojaMaxEvaporTransptoIrrigate);

            cropSojaPivot5 = createCrop(1, "Maiz SantaLucia Pivot 5", testSpecieMaiz, testLocation, testCropCoefficientMaiz, cropDensityMaiz,
                                        testInitialPhenologicalState, dateBeginCrop_Pivot5, DateTime.Now, soil_5, lMaizMaxEvaporTransptoIrrigate);


        }

        private void agregarDatosDeRiego()
        {
            
            //Pivot 2
            //Riego inicial
            irrigationSystem.addOrUpdateIrrigationDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 10, 22), 22, true);
            irrigationSystem.addOrUpdateIrrigationDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 12, 17), 10, true);
            irrigationSystem.addOrUpdateIrrigationDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 12, 20), 10, true);
            irrigationSystem.addOrUpdateIrrigationDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 12, 24), 10, true);
            irrigationSystem.addOrUpdateIrrigationDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 12, 26), 10, true);

            //PIVOT 3_4
            //Riego inicial
            irrigationSystem.addOrUpdateIrrigationDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 15),  5, true);
            irrigationSystem.addOrUpdateIrrigationDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 19), 15, true);
            
            //dias 14, 18 y 22 de diciembre, todos de 5 mm
            //PIVOT 5
            //Riego inicial
            irrigationSystem.addOrUpdateIrrigationDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 10, 19), 7, true);
            irrigationSystem.addOrUpdateIrrigationDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 10, 21), 7, true);
            irrigationSystem.addOrUpdateIrrigationDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 12, 14), 5, true);
            irrigationSystem.addOrUpdateIrrigationDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 12, 18), 5, true);
            irrigationSystem.addOrUpdateIrrigationDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 12, 22), 5, true);


            //TODO: 3 Layout Irrigation Weather Data

        }

        private void crearSuelosSantaLucia()
        {
            soil_1 = new Soil(1, "Suelo Pivot 1", "Suelo Pivot 1", testLocation, DateTime.MinValue, 30);
            soil_2 = new Soil(2, "Suelo Pivot 2", "Suelo Pivot 2", testLocation, DateTime.MinValue, 30);
            soil_3_4 = new Soil(3, "Suelo Pivot 3_4", "Suelo Pivot 3_4", testLocation, DateTime.MinValue, 30);
            soil_5 = new Soil(4, "Suelo Pivot 5", "Suelo Pivot 5", testLocation, DateTime.MinValue, 30);

            // horizon_1A = new Horizon(1,"Horizonte A - Suelo 1", 1, "A",)
            Horizon horizon_2A = new Horizon(1, "A", 0, "A", 14, 19, 53, 28, 4.4, 0, 1.2);
            Horizon horizon_2AB = new Horizon(2, "AB", 1, "AB", 23, 18, 45, 37, 3, 0, 1.3);
            Horizon horizon_2B = new Horizon(3, "B", 2, "B", 20, 19, 37, 44, 2, 0, 1.4);

            soil_2.Horizons.Add(horizon_2A);
            soil_2.Horizons.Add(horizon_2AB);
            soil_2.Horizons.Add(horizon_2B);

            Horizon horizon_3_4A = new Horizon(1, "A", 0, "A", 15, 33, 40, 26, 4.4, 0, 1.3);
            Horizon horizon_3_4B = new Horizon(2, "B", 1, "B", 20, 20, 28, 52, 4.4, 0, 1.4);

            soil_3_4.Horizons.Add(horizon_3_4A);
            soil_3_4.Horizons.Add(horizon_3_4B);

            Horizon horizon_5A = new Horizon(1, "A", 0, "A",14, 19, 53, 28, 4.4, 0, 1.2);
            Horizon horizon_5AB = new Horizon(2, "AB", 1, "AB", 23, 18, 45, 37, 3, 0, 1.3);
            Horizon horizon_5B = new Horizon(3, "B", 2, "B", 20, 19, 37, 44, 2, 0, 1.4);

            soil_5.Horizons.Add(horizon_5A);
            soil_5.Horizons.Add(horizon_5AB);
            soil_5.Horizons.Add(horizon_5B);


        }

        private void agregarDatosDeLluvia()
        {
            // DATOS DE LLUVIA
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 10, 29), 66);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 10, 31), 2.5);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 11, 1), 2.5);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 11, 2), 10);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 11, 3), 35);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 11, 22), 27);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 11, 29), 50);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 11, 30), 51);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 12, 8), 15);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 12, 21), 5);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 12, 23), 5);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 12, 26), 4.5);
            
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 22), 27);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 29), 50);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 30), 51);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 8), 15);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 21), 5);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 23), 5);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 26), 4.5);

            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 10, 29), 66);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 10, 31), 2.5);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 11, 1), 2.5);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 11, 2), 10);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 11, 3), 35);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 11, 22), 27);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 11, 29), 50);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 11, 30), 51);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 12, 8), 15);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 12, 21), 5);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 12, 23), 5);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 12, 26), 4.5);

            //TODO: 2 Layout Rain Weather Data
            

        }


        private string printState(CropIrrigationWeatherRecords rec)
        {
            string ret = "";
            string etcAc = rec.TotalEvapotranspirationCrop + "        ";
            string etcflwi = rec.TotalEvapotranspirationCropFromLastWaterInput + "        ";
            string growDegre = rec.GrowingDegreeDays + "        ";
            string modGrowDegre = rec.ModifiedGrowingDegreeDays + "        ";
            string effRain = rec.TotalEffectiveRain + "        ";
            string totRain = rec.TotalRealRain + "        ";
            string bHid = rec.HydricBalance.ToString() + "        ";
            string PercentAD = rec.getPercentageOfAvailableWater() + "        ";
            string AD = rec.getSoilAvailableWaterCapacity() + "        ";
            string CC = rec.getSoilFieldCapacity() + "        ";
            string PMP = rec.getSoilPermanentWiltingPoint() + "        ";
            string totIrr = rec.TotalIrrigation.ToString();
            string totExtraIrr = rec.TotalExtraIrrigation.ToString();

            
            ret = " \t " + etcAc.Substring(0, 7) +
                " \t " + etcflwi.Substring(0,7) +
                " \t " + growDegre.Substring(0, 7) +
                " \t " + modGrowDegre.Substring(0, 7) +
                " \t " + bHid.Substring(0, 7) +
                " \t " + PercentAD.Substring(0, 7) +
                " \t " + AD.Substring(0, 7) +
                " \t " + CC.Substring(0, 7) +
                " \t " + PMP.Substring(0, 7) +
                " \t " + effRain.Substring(0, 7) +
                " \t " + totRain.Substring(0, 7) +
                " \t " + rec.TotalIrrigation +
                " \t\t " + rec.LastWaterInputDate.ToString() +
                " \t " + rec.getRootDepth() +
                " \tf " + rec.CropIrrigationWeather.Crop.PhenologicalStage.Stage.Name +
                " \t " + totIrr.Substring(0, 7) +
                " \t " + totExtraIrr.Substring(0, 7) +
                Environment.NewLine;

           

            return ret;
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
            
            //Input of file information
            lOutputFile.FileHeader = "Table with all the irrigation results.";
            lOutputFile.FileTitles = pTitles;
            lOutputFile.FileMessages = pMessages;
            lOutputFile.FileFooter = "Finish all the information.";

            //Writes the CSV file in the FilePath
            lOutputFile.WriteFile(lMethod, lDescription, lTime);


        }


       
        #region Private Helpers

        private IrrigationUnit creteIrrigationUnit(int pId, string pName, string pType, double pEfficiency, 
                                                    List<Utilities.Pair<DateTime, double>> list1, int pSurface, 
                                                    List<Crop.Crop> list2, Bomb lBomb, Location.Location lLocation)
        {
            Irrigation.IrrigationUnit lIrrigationUnit;
            List<Utilities.Pair<DateTime, Double>> lIrrigations;
            List<Crop.Crop> lIrrigationCrops;

            lIrrigations = new List<Utilities.Pair<DateTime, Double>>();
            lIrrigationCrops =  new List<Crop.Crop>();

            lIrrigationUnit = new Irrigation.IrrigationUnit(pId, pName, pType, pEfficiency, lIrrigations, 
                                                            pSurface, lIrrigationCrops, lBomb, lLocation);
            return lIrrigationUnit;
        }

        private Crop.Crop createCrop(int pId, String pName, Specie pSpecie, Location.Location lLocation, CropCoefficient lCropCoefficient, 
                                    Double cropDensity, PhenologicalStage lPhenologicalState, DateTime lSowingDate, 
                                    DateTime dateTime, Soil lSoil, Double lSojaMaxEvaporTransptoIrrigate)
        {
            List<PhenologicalStage> lPhenologicalStageList;
            Crop.Crop lCrop;
 
            lPhenologicalStageList = irrigationSystem.getPhenologicalStage(testRegion, pSpecie, this.irrigationSystem.PhenologicalStageList);
            lCrop = new Crop.Crop(pId, pName, pSpecie, lLocation, lCropCoefficient, cropDensity,
                                    lPhenologicalState, lPhenologicalStageList, lSowingDate, 
                                    dateTime, lSoil, lSojaMaxEvaporTransptoIrrigate);
            return lCrop;           
        }

        
        

        private Soil createSoil(Location.Location lLocation)
        {
            double sand = 17.3;
            double limo = 53.9;
            double clay = 28.8;
            double organicMatter = 4.4;
            Horizon lHorizon = new Horizon();
            lHorizon.Sand = sand;
            lHorizon.Limo = limo;
            lHorizon.Clay = clay;
            lHorizon.OrganicMatter = organicMatter;
            lHorizon.HorizonLayer = "A";
            lHorizon.Order = 0;
            lHorizon.HorizonLayerDepth = 5.3;
            Soil lSoil = new Soil();
            lSoil.Horizons.Add(lHorizon);
            lSoil.Location = lLocation;
            return lSoil;
        }

        public Location.Location createLocation(Position lPosition,Country lCountry, Region lRegion, City lCity)
        {
            lPosition = new Position(34, 55);
            lCountry = new Country();
            lCountry.Name = "Uruguay";
            lRegion = new Region("Templada", null);
            lCity = new City("Minas",null );
            Location.Location lLocation = new Location.Location(lPosition,lCountry, lRegion, lCity);
            return lLocation;
        }

        public Specie createSpecie(int pId, String  pName, Region  pRegion, double pBaseTemp)
        {
            Specie lSpecie = new Specie(pId, pName, pRegion, pBaseTemp);
            return lSpecie;
        }
        #endregion

    }
}
