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

namespace IrrigationAdvisor.Models.IrrigationSystem
{
    [TestClass]
    public class IrrigationSystemTest
    {
        #region Fields General Test
        private Region lRegion;
        private Location.Location lLocation;
        private Specie lSpecieSoja;
        private Specie lSpecieMaiz;
        private Soil lSoil;
        private PhenologicalStage lPhenologicalState;
        private CropCoefficient lCropCoefficient;
        private Crop.Crop crop;
        private Bomb lBomb;
        private Irrigation.IrrigationUnit irrigationUnit;
        private WeatherStation.WeatherStation weatherStation;
        private CropIrrigationWeather cropIrrigWeatherPivot2;
        #endregion

        #region Fields Santa Lucia Test
        private Soil soil_1;
        private Soil soil_2;
        private Soil soil_3_4;
        private Soil soil_5;

       
        double sojaBaseTemp = 8;
        double maizBaseTemp = 10;
            
        
        #endregion

        private IrrigationSystem irrirgSys;
        [TestMethod]
        public void santaLuciaTest()
        {

            lRegion = new Region("Templada", lLocation);
            lLocation = createLocation(new Position(34, 55), new Country("Uruguay", null), lRegion, new City("Santa Lucia", null));

            lSpecieSoja = createSpecie(1, "Soja", lRegion, sojaBaseTemp);
            lSpecieMaiz = createSpecie(1, "Maiz", lRegion, maizBaseTemp);
            
            soil_1 = new Soil(1, "Suelo Pivot 1", lLocation);
            soil_2 = new Soil(2, "Suelo Pivot 2", lLocation);
            soil_3_4 = new Soil(3, "Suelo Pivot 3_4", lLocation);
            soil_5 = new Soil(4, "Suelo Pivot 5", lLocation);

           // horizon_1A = new Horizon(1,"Horizonte A - Suelo 1", 1, "A",)
            Horizon horizon_2A = new Horizon(1, "A", 0, "A", 14, 19, 53, 28, 4.4, 0, 1.2);
            Horizon horizon_2AB = new Horizon(2, "AB", 1, "AB", 23, 18, 45, 37, 3, 0, 1.3);
            Horizon horizon_2B = new Horizon(3, "B", 2, "B", 20, 19, 37, 44, 2, 0, 1.4);

            soil_2.Horizons.Add(horizon_2A);
            soil_2.Horizons.Add(horizon_2AB);
            soil_2.Horizons.Add(horizon_2B);

            irrirgSys = new IrrigationSystem();
            addPhenologicalStageListToSystem();
            
            
            DateTime lSowingDate = new DateTime(2014, 11, 01);
            double lMaizMaxEvaporTransptoIrrigate = 35;
            double cropDensityMaiz = 70;
            lCropCoefficient = createMaizCropCoefficientWithList(lSpecieSoja, lRegion);
            
            lPhenologicalState = cretePhenologicalStage(1, lSpecieMaiz, new Stage(1, "v0", "Sin hojas"), 0, 60, 5);

            
            crop = createCrop(1, "Maiz SantaLucia Pivot 2", lSpecieMaiz, lLocation, lCropCoefficient, cropDensityMaiz,
                lPhenologicalState, new DateTime(2014, 10, 21), DateTime.Now, soil_2, lMaizMaxEvaporTransptoIrrigate);

            lBomb = new Bomb("Bomba1", 1234, DateTime.Now, DateTime.Now, lLocation);
            irrigationUnit = creteIrrigationUnit(1, "Unidad de Riego de prueba", "Pivot",
                999, new List<Utilities.Pair<DateTime, double>>(), 300, new List<Crop.Crop>(), lBomb, lLocation);

            weatherStation = new WeatherStation.WeatherStation(1, "WeatherStation1", "Model?", DateTime.Now, DateTime.Now, DateTime.Now, 1, lLocation, true);

            cropIrrigWeatherPivot2 = new CropIrrigationWeather(irrigationUnit, crop, weatherStation, null);


            // DATOS DEL TIEMPO
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 21), 99, 0, 16.9, 16.9, 4.8);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 22), 99, 0, 19.5, 19.5, 5.5);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 23), 99, 0, 20.1, 20.1, 5);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 24), 99, 0, 19.7, 19.7, 4.6);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 25), 99, 0, 20.1, 20.1, 5);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 26), 99, 0, 11.7, 11.7, 5.5);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 27), 99, 0, 23.5, 23.5, 6.5);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 28), 99, 0, 20, 20, 5.5);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 29), 99, 0, 15.3, 15.3, 1.9);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 30), 99, 0, 12.5, 12.5, 4.5);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 31), 99, 0, 11.3, 11.3, 3.3);

            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 1), 99, 0, 12.6, 12.6, 3.3);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 2), 99, 0, 12.4, 12.4, 2.9);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 3), 99, 0, 14.2, 14.2, 2.1);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 4), 99, 0, 12.9, 12.9, 4.8);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 5), 99, 0, 14.9, 14.9, 4.9);

            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 6), 99, 0, 16.2, 16.2, 4.8);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 7), 99, 0, 17.7, 17.7, 4.6);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 8), 99, 0, 17, 17, 5.5);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 9), 99, 0, 17.1, 17.1, 5.3);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 10), 99, 0, 19.2, 19.2, 4.4);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 11), 99, 0, 19.6, 19.6, 4.8);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 12), 99, 0, 16.1, 16.1, 5);

            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 13), 99, 0, 13, 13, 4.7);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 14), 99, 0, 15.8, 15.8, 5.5);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 15), 99, 0, 20.9, 20.9, 6.5);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 16), 99, 0, 18.3, 18.3, 5.7);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 17), 99, 0, 18.8, 18.8, 6.5);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 18), 99, 0, 21.1, 21.1, 6.5);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 19), 99, 0, 19.4, 19.4, 3.7);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 20), 99, 0, 18, 18, 5);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 21), 99, 0, 18, 18, 5);
            

            // DATOS DE LLUVIA
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 10, 29), 66);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 10, 31), 2.5);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 11, 1), 2.5);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 11, 2), 10);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 11, 3), 35);
            
            
            irrirgSys.addCropIrrigWeatherToList(cropIrrigWeatherPivot2);

            //DAILY RECORDS
            String textLog = Environment.NewLine + Environment.NewLine;
            double irrigationCalculated = 0;
            CropIrrigationWeatherRecords rec = irrirgSys.CropIrrigationWeatherRecordsList.Find(x => x.getRootDepth() > 0);
            
            textLog += "Dia 0"+ printState(rec);
 
            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 10, 22), 22);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 22), "Dia 1");
            textLog += "Dia 1" + printState(rec);
            
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 23), "Dia 2");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textLog += "Dia 2" + printState(rec);
            
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 24), "Dia 3");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textLog += "Dia 3" + printState(rec);
            
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 25), "Dia 4");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            textLog += "Dia 4" + printState(rec);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 26), "Dia 5");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            textLog += "Dia 5" + printState(rec);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 27), "Dia 6");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            textLog += "Dia 6" + printState(rec);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 28), "Dia 7");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            textLog += "Dia 7" + printState(rec);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 29), "Dia 8");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            textLog += "Dia 8" + printState(rec);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 30), "Dia 9");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            textLog += "Dia 9" + printState(rec);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 31), "Dia 10");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            textLog += "Dia 10" + printState(rec);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 1), "Dia 11");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            textLog += "Dia 11" + printState(rec);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 2), "Dia 12");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            textLog += "Dia 12" + printState(rec);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 3), "Dia 13");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            textLog += "Dia 13" + printState(rec);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 4), "Dia 14");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            textLog += "Dia 14" + printState(rec);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 5), "Dia 15");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            textLog += "Dia 15" + printState(rec);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 6), "Dia 16");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            textLog += "Dia 16" + printState(rec);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 7), "Dia 17");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            textLog += "Dia 17" + printState(rec);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 8), "Dia 18");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            textLog += "Dia 18" + printState(rec);
            
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 9), "Dia 19");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            textLog += "Dia 19" + printState(rec);
            
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 10), "Dia 20");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            textLog += "Dia 20" + printState(rec);
            
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 11), "Dia 21");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textLog += "Dia 21" + printState(rec);
            
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 12), "Dia 22");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textLog += "Dia 22" + printState(rec);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 13), "Dia 22");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textLog += "Dia 23" + printState(rec);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 14), "Dia 22");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textLog += "Dia 24" + printState(rec);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 15), "Dia 22");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textLog += "Dia 25" + printState(rec);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 16), "Dia 22");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textLog += "Dia 26" + printState(rec);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 17), "Dia 22");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textLog += "Dia 27" + printState(rec);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 18), "Dia 22");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textLog += "Dia 28" + printState(rec);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 19), "Dia 22");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textLog += "Dia 29" + printState(rec);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 20), "Dia 22");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textLog += "Dia 30" + printState(rec);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 21), "Dia 22");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textLog += "Dia 31" + printState(rec);

            


            textLog += Environment.NewLine + Environment.NewLine + irrirgSys.printDailyRecordsList();
            this.printSystemData(textLog);
        }

        private string printState(CropIrrigationWeatherRecords rec)
        {
            string ret = "";
            string etcflwi = rec.TotalEvapotranspirationCropFromLastWaterInput+  "       ";
            string totRain = rec.TotalEffectiveRain + "       ";
            ret = " \tETCAc: " + rec.TotalEvapotranspirationCrop +
                " \tETCFromLWI: " + etcflwi.Substring(0,6) +
                " \t  G.Dia: " + rec.GrowingDegreeDays +
                " \tB.Hidrico: " + rec.HydricBalance.ToString() +
                " \tTotRain: " + totRain.Substring(0, 6) +
                " \tTotIrrig: " + rec.TotalIrrigation +
                " \tLastWaterInput: " + rec.LastWaterInput.ToString() +
                " \tRaiz " + rec.getRootDepth() + Environment.NewLine;
                
            return ret;
        }

        [TestMethod]
        public void systemTest()
        {
            this.createTestingUnity();
            this.addWeatherData();
            irrirgSys.addCropIrrigWeatherToList(cropIrrigWeatherPivot2);
            this.addRainData();
            this.addDailyRecord();
            this.printSystemData();

        }

        private void addDailyRecord()
        {
            double irrigationCalculated = 0;
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 1), "Dia uno");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 2), "Dia dos");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 3), "Dia tres");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 4), "Dia cuatro");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 11, 5), 22);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 5), "Dia cinco");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 6), "Dia seis");
            

        }
        public void addWeatherData()
        {
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 1), 99, 0, 30, 10, 2);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 2), 99, 0, 13, 4, 2.5);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 3), 99, 0, 11.7, 1, 3.6);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 4), 99, 0, 14.4, 5, 4.7);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 5), 99, 0, 20, 4, 4);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 6), 99, 0, 22.8, 1, 3.5);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 7), 99, 0, 10.6, 5.6, 3.8);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 8), 99, 0, 15.6, 2.8, 4.6);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 9), 99, 0, 18, 0, 2.6);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 10), 99, 0, 6, 0, 3.4);




        }

        private void addRainData()
        {
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 11, 4), 3);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 11, 9), 8);
        }

        private void printSystemData()
        {
            TextFileLogger lTextFileLogger = new TextFileLogger();
            String lFile = "IrrigationSystemTest";
            String lMethod = "createACropIrrigationWeather";
            String lMessage = irrirgSys.printDailyRecordsList();
            lMessage += irrirgSys.printWeatherDataList();
            String lTime = System.DateTime.Now.ToString();
            lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
        }
        private void printSystemData(String pText)
        {
            TextFileLogger lTextFileLogger = new TextFileLogger();
            String lFile = "IrrigationSystemTest";
            String lMethod = "createACropIrrigationWeather";
            String lMessage = pText;
            String lTime = System.DateTime.Now.ToString();
            lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
        }



        public void createTestingUnity()
        {
            lRegion = new Region("Templada", lLocation);
            lLocation = createLocation(new Position(34, 55),new Country("Uruguay", null ), lRegion, new City("Minas",null ));

            lSpecieSoja = createSpecie(1, "Soja", lRegion, sojaBaseTemp);
            lSpecieMaiz = createSpecie(2, "Maiz", lRegion, maizBaseTemp);
            
            lSoil = createSoil(lLocation);
            
            double minDegree = 0;
            double maxDegree = 60;
            double rootDepth = 5;
            lPhenologicalState = cretePhenologicalStage(1,lSpecieSoja,new Stage(1,"v0","Sin hojas"),minDegree,maxDegree,rootDepth );
           
            lCropCoefficient = createSojaCropCoefficientWithList(lSpecieSoja, lRegion);

            DateTime lSowingDate = new DateTime (2014,11,01);
            double lSojaMaxEvaporTransptoIrrigate = 35;
            double cropDensity = 70;
            
            crop = createCrop(1,"Soja en Minas", lSpecieSoja,lLocation, lCropCoefficient, cropDensity,
                lPhenologicalState, lSowingDate, DateTime.Now, lSoil, lSojaMaxEvaporTransptoIrrigate);
                
            lBomb = new Bomb("Bomba1", 1234, DateTime.Now, DateTime.Now, lLocation);
            irrigationUnit = creteIrrigationUnit(1, "Unidad de Riego de prueba", "Pivot", 
                999, new List<Utilities.Pair<DateTime, double>>(), 300, new List<Crop.Crop>(), lBomb, lLocation);
               
            weatherStation = new WeatherStation.WeatherStation(1,"WeatherStation1","Model?",DateTime.Now,DateTime.Now,DateTime.Now, 1, lLocation,true);

            cropIrrigWeatherPivot2 = new CropIrrigationWeather(irrigationUnit, crop,weatherStation,null);

            irrirgSys = new IrrigationSystem();
            addPhenologicalStageListToSystem();
            
        }


        
        #region Private Helpers
        private void addPhenologicalStageListToSystem()
        {
            List<PhenologicalStage> lPhenolStageList = new List<PhenologicalStage>();
            lPhenolStageList.Add(cretePhenologicalStage(0, lSpecieMaiz, new Stage(1, "v0", "Sin hojas"), 0, 59, 5));
            lPhenolStageList.Add( cretePhenologicalStage(1, lSpecieMaiz, new Stage(1, "ve", "Sin hojas"), 60, 114, 5));
            lPhenolStageList.Add( cretePhenologicalStage(2, lSpecieMaiz, new Stage(1, "v1", "Sin hojas"), 115, 134, 5));
            lPhenolStageList.Add( cretePhenologicalStage(3, lSpecieMaiz, new Stage(1, "v2", "Sin hojas"), 135, 179, 10));
            lPhenolStageList.Add( cretePhenologicalStage(4, lSpecieMaiz, new Stage(1, "v3", "Sin hojas"), 180, 229, 15));
            lPhenolStageList.Add( cretePhenologicalStage(5, lSpecieMaiz, new Stage(1, "v4", "Sin hojas"), 230, 289, 20));
            lPhenolStageList.Add( cretePhenologicalStage(6, lSpecieMaiz, new Stage(1, "v5", "Sin hojas"), 290, 339, 20));
            lPhenolStageList.Add( cretePhenologicalStage(7, lSpecieMaiz, new Stage(1, "v6", "Sin hojas"), 340, 404, 25));
            lPhenolStageList.Add( cretePhenologicalStage(8, lSpecieMaiz, new Stage(1, "v7", "Sin hojas"), 405, 459, 25));
            lPhenolStageList.Add( cretePhenologicalStage(9, lSpecieMaiz, new Stage(1, "v8", "Sin hojas"), 460, 519, 30));
            lPhenolStageList.Add( cretePhenologicalStage(10, lSpecieMaiz, new Stage(1, "v9", "Sin hojas"), 520, 589, 30));
            lPhenolStageList.Add( cretePhenologicalStage(11, lSpecieMaiz, new Stage(1, "v10", "Sin hojas"), 590, 649, 32));
            lPhenolStageList.Add( cretePhenologicalStage(12, lSpecieMaiz, new Stage(1, "v11", "Sin hojas"), 650, 689, 35));
            lPhenolStageList.Add( cretePhenologicalStage(13, lSpecieMaiz, new Stage(1, "v12", "Sin hojas"), 690, 714, 37));
            lPhenolStageList.Add( cretePhenologicalStage(14, lSpecieMaiz, new Stage(1, "v13", "Sin hojas"), 715, 749, 40));
            lPhenolStageList.Add( cretePhenologicalStage(15, lSpecieMaiz, new Stage(1, "v14", "Sin hojas"), 750, 764, 42));
            lPhenolStageList.Add( cretePhenologicalStage(16, lSpecieMaiz, new Stage(1, "vt", "Sin hojas"), 775, 954, 45));
            lPhenolStageList.Add( cretePhenologicalStage(17, lSpecieMaiz, new Stage(1, "R1", "Sin hojas"), 955, 1149, 45));
            lPhenolStageList.Add( cretePhenologicalStage(18, lSpecieMaiz, new Stage(1, "R2", "Sin hojas"), 1150, 1289, 45));
            lPhenolStageList.Add( cretePhenologicalStage(19, lSpecieMaiz, new Stage(1, "R3", "Sin hojas"), 1290, 1359, 45));
            lPhenolStageList.Add( cretePhenologicalStage(20, lSpecieMaiz, new Stage(1, "R4", "Sin hojas"), 1360, 1449, 45));
            lPhenolStageList.Add( cretePhenologicalStage(21, lSpecieMaiz, new Stage(1, "R5", "Sin hojas"), 1450, 1649, 45));
            lPhenolStageList.Add( cretePhenologicalStage(22, lSpecieMaiz, new Stage(1, "R6", "Sin hojas"), 1650, 2000, 45));

            lPhenolStageList.Add(cretePhenologicalStage(23, lSpecieSoja, new Stage(1, "v0", "Sin hojas"), 0, 59, 5));
            lPhenolStageList.Add( cretePhenologicalStage(24, lSpecieSoja, new Stage(1, "ve", "Sin hojas"), 60, 114, 5));
            lPhenolStageList.Add(cretePhenologicalStage(25, lSpecieSoja, new Stage(1, "v1", "Sin hojas"), 115, 134, 5));
            lPhenolStageList.Add(cretePhenologicalStage(26, lSpecieSoja, new Stage(1, "v2", "Sin hojas"), 135, 179, 10));
            lPhenolStageList.Add(cretePhenologicalStage(27, lSpecieSoja, new Stage(1, "v3", "Sin hojas"), 180, 229, 15));
            lPhenolStageList.Add(cretePhenologicalStage(28, lSpecieSoja, new Stage(1, "v4", "Sin hojas"), 230, 289, 20));
            lPhenolStageList.Add(cretePhenologicalStage(29, lSpecieSoja, new Stage(1, "v5", "Sin hojas"), 290, 339, 20));
            lPhenolStageList.Add(cretePhenologicalStage(30, lSpecieSoja, new Stage(1, "v6", "Sin hojas"), 340, 404, 25));
            lPhenolStageList.Add(cretePhenologicalStage(31, lSpecieSoja, new Stage(1, "v7", "Sin hojas"), 405, 459, 25));
            lPhenolStageList.Add(cretePhenologicalStage(32, lSpecieSoja, new Stage(1, "v8", "Sin hojas"), 460, 519, 30));
            lPhenolStageList.Add(cretePhenologicalStage(33, lSpecieSoja, new Stage(1, "v9", "Sin hojas"), 520, 589, 32));
            lPhenolStageList.Add(cretePhenologicalStage(34, lSpecieSoja, new Stage(1, "v10", "Sin hojas"), 590, 649, 35));
            lPhenolStageList.Add( cretePhenologicalStage(35, lSpecieSoja, new Stage(1, "v11", "Sin hojas"), 650, 689, 37));
            lPhenolStageList.Add(cretePhenologicalStage(36, lSpecieSoja, new Stage(1, "v12", "Sin hojas"), 690, 714, 40));
            lPhenolStageList.Add(cretePhenologicalStage(37, lSpecieSoja, new Stage(1, "v13", "Sin hojas"), 715, 749, 42));
            lPhenolStageList.Add(cretePhenologicalStage(38, lSpecieSoja, new Stage(1, "v14", "Sin hojas"), 750, 764, 45));
            lPhenolStageList.Add(cretePhenologicalStage(39, lSpecieSoja, new Stage(1, "vt", "Sin hojas"), 775, 954, 45));
            lPhenolStageList.Add(cretePhenologicalStage(40, lSpecieSoja, new Stage(1, "R1", "Sin hojas"), 955, 1149, 45));
            lPhenolStageList.Add(cretePhenologicalStage(42, lSpecieSoja, new Stage(1, "R2", "Sin hojas"), 1150, 1289, 45));
            lPhenolStageList.Add(cretePhenologicalStage(43, lSpecieSoja, new Stage(1, "R3", "Sin hojas"), 1290, 1359, 45));
            lPhenolStageList.Add(cretePhenologicalStage(44, lSpecieSoja, new Stage(1, "R4", "Sin hojas"), 1360, 1449, 45));
            lPhenolStageList.Add(cretePhenologicalStage(45, lSpecieSoja, new Stage(1, "R5", "Sin hojas"), 1450, 1649, 45));
            lPhenolStageList.Add(cretePhenologicalStage(45, lSpecieSoja, new Stage(1, "R^", "Sin hojas"), 1650, 2000, 45));

            Pair<Region, List<PhenologicalStage>> lpair = new Pair<Region, List<PhenologicalStage>>(lRegion, lPhenolStageList);
            this.irrirgSys.PhenologicalStageList.Add(lpair);
            double lRootDepth = this.irrirgSys.getPhenologicalStage(23, lRegion, lSpecieSoja).RootDepth;
            Assert.AreEqual(lRootDepth, 5);
           

        }

        private IrrigationUnit creteIrrigationUnit(int pId, string pName, string pType, int pEfficiency, List<Utilities.Pair<DateTime, double>> list1, int pSurface, List<Crop.Crop> list2, Bomb lBomb, Location.Location lLocation)
        {
            return new Irrigation.IrrigationUnit(pId, pName, pType,
             pEfficiency, new List<Utilities.Pair<DateTime, double>>(), pSurface, new List<Crop.Crop>(), lBomb, lLocation);
        }

        private Crop.Crop createCrop(int pid, string pname, Specie lSpecie, Location.Location lLocation, CropCoefficient lCropCoefficient, double cropDensity, PhenologicalStage lPhenologicalState, DateTime lSowingDate, DateTime dateTime, Soil lSoil, double lSojaMaxEvaporTransptoIrrigate)
        {
            List<PhenologicalStage> lPhenologicalStageList = irrirgSys.getPhenologicalStage(lRegion, lSpecie);
            return new Crop.Crop(pid,pname, lSpecie,lLocation, lCropCoefficient, cropDensity,
            lPhenologicalState, lPhenologicalStageList, lSowingDate, dateTime, lSoil, lSojaMaxEvaporTransptoIrrigate);
            
        }

        private CropCoefficient createSojaCropCoefficientWithList(Specie lSpecie, Region lRegion)
        {
            //KC Para soja sacado de la carpeta Calculos
            CropCoefficient lCropCoefficient  =  new CropCoefficient(lSpecie, lRegion);
            lCropCoefficient.addDayToList(0,0.40);
            lCropCoefficient.addDayToList(1,0.41);
            lCropCoefficient.addDayToList(2,0.42);
            lCropCoefficient.addDayToList(3,0.43);
            lCropCoefficient.addDayToList(4,0.44);
            lCropCoefficient.addDayToList(5,0.46);
            lCropCoefficient.addDayToList(6,0.47);
            lCropCoefficient.addDayToList(7,0.48);
            lCropCoefficient.addDayToList(9,0.50);
            lCropCoefficient.addDayToList(10,0.51);
            lCropCoefficient.addDayToList(11,0.52);
            lCropCoefficient.addDayToList(12,0.53);
            lCropCoefficient.addDayToList(13,0.54);
            lCropCoefficient.addDayToList(14,0.55);
            lCropCoefficient.addDayToList(15,0.57);
            lCropCoefficient.addDayToList(16,0.58);
            lCropCoefficient.addDayToList(17,0.59);
            lCropCoefficient.addDayToList(18,0.60);
            lCropCoefficient.addDayToList(19,0.61);
            lCropCoefficient.addDayToList(20,0.62);
            lCropCoefficient.addDayToList(21,0.63);
            lCropCoefficient.addDayToList(22,0.64);
            lCropCoefficient.addDayToList(23,0.65);
            lCropCoefficient.addDayToList(24,0.66);
            lCropCoefficient.addDayToList(25,0.68);
            lCropCoefficient.addDayToList(26,0.69);
            lCropCoefficient.addDayToList(27,0.70);
            lCropCoefficient.addDayToList(28,0.71);
            lCropCoefficient.addDayToList(29,0.72);
            lCropCoefficient.addDayToList(30,0.73);
            lCropCoefficient.addDayToList(31,0.74);
            lCropCoefficient.addDayToList(32,0.75);
            lCropCoefficient.addDayToList(33,0.76);
            lCropCoefficient.addDayToList(34,0.77);
            lCropCoefficient.addDayToList(35,0.79);
            lCropCoefficient.addDayToList(36,0.80);
            lCropCoefficient.addDayToList(37,0.81);
            lCropCoefficient.addDayToList(38,0.82);
            lCropCoefficient.addDayToList(39,0.83);
            lCropCoefficient.addDayToList(40,0.84);
            lCropCoefficient.addDayToList(41,0.85);
            lCropCoefficient.addDayToList(42,0.86);
            lCropCoefficient.addDayToList(43,0.87);
            lCropCoefficient.addDayToList(44,0.89);
            lCropCoefficient.addDayToList(45,0.90);
            lCropCoefficient.addDayToList(46,0.91);
            lCropCoefficient.addDayToList(47,0.92);
            lCropCoefficient.addDayToList(48,0.93);
            lCropCoefficient.addDayToList(49,0.94);
            lCropCoefficient.addDayToList(50,0.95);
            lCropCoefficient.addDayToList(51,0.96);
            lCropCoefficient.addDayToList(52,0.97);
            lCropCoefficient.addDayToList(53,0.98);
            lCropCoefficient.addDayToList(54,1);
            lCropCoefficient.addDayToList(55,1.01);
            lCropCoefficient.addDayToList(56,1.02);
            lCropCoefficient.addDayToList(57,1.03);
            lCropCoefficient.addDayToList(58,1.04);
            lCropCoefficient.addDayToList(59,1.05);
            lCropCoefficient.addDayToList(60,1.06);
            lCropCoefficient.addDayToList(61,1.07);
            lCropCoefficient.addDayToList(62,1.08);
            lCropCoefficient.addDayToList(63,1.09);
            lCropCoefficient.addDayToList(64,1.11);
            lCropCoefficient.addDayToList(65,1.12);
            lCropCoefficient.addDayToList(66,1.13);
            lCropCoefficient.addDayToList(67,1.14);
            lCropCoefficient.addDayToList(68,1.15);
            lCropCoefficient.addDayToList(69,1.14);
            lCropCoefficient.addDayToList(70,1.14);
            lCropCoefficient.addDayToList(71,1.13);
            lCropCoefficient.addDayToList(72,1.12);
            lCropCoefficient.addDayToList(73,1.11);
            lCropCoefficient.addDayToList(74,1.11);
            lCropCoefficient.addDayToList(75,1.10);
            lCropCoefficient.addDayToList(76,1.09);
            lCropCoefficient.addDayToList(77,1.09);
            lCropCoefficient.addDayToList(78,1.08);
            lCropCoefficient.addDayToList(79,1.07);
            lCropCoefficient.addDayToList(80,1.06);
            lCropCoefficient.addDayToList(81,1.06);
            lCropCoefficient.addDayToList(82,1.05);
            lCropCoefficient.addDayToList(83,1.04);
            lCropCoefficient.addDayToList(84,1.04);
            lCropCoefficient.addDayToList(85,1.03);
            lCropCoefficient.addDayToList(86,1.02);
            lCropCoefficient.addDayToList(87,1.01);
            lCropCoefficient.addDayToList(88,1.01);
            lCropCoefficient.addDayToList(89,1.00);
            lCropCoefficient.addDayToList(90,0.99);
            lCropCoefficient.addDayToList(91,0.99);
            lCropCoefficient.addDayToList(92,0.98);
            lCropCoefficient.addDayToList(93,0.97);
            lCropCoefficient.addDayToList(94,0.96);
            lCropCoefficient.addDayToList(95,0.96);
            lCropCoefficient.addDayToList(96,0.95);
            lCropCoefficient.addDayToList(97,0.94);
            lCropCoefficient.addDayToList(98,0.94);
            lCropCoefficient.addDayToList(99,0.93);
            lCropCoefficient.addDayToList(100,0.92);
            lCropCoefficient.addDayToList(101,0.91);
            lCropCoefficient.addDayToList(102,0.91);
            lCropCoefficient.addDayToList(103,0.90);
            lCropCoefficient.addDayToList(104,0.89);
            lCropCoefficient.addDayToList(105,0.89);
            lCropCoefficient.addDayToList(106,0.88);
            lCropCoefficient.addDayToList(107,0.87);
/*108	0,86
109	0,86
110	0,85
111	0,84
112	0,84
113	0,83
114	0,82
115	0,81
116	0,81
117	0,80
118	0,79
119	0,79
120	0,78
121	0,77
122	0,76
123	0,76
124	0,75
125	0,74
126	0,74
127	0,73
128	0,72
129	0,71
130	0,71
131	0,70
132	0,69
133	0,69
134	0,68
135	0,67
136	0,66
137	0,66
138	0,65
139	0,64
140	0,64
141	0,63
142	0,62
143	0,61
144	0,61
145	0,60
146	0,59
147	0,59
148	0,58
149	0,57
150	0,56
151	0,56
152	0,55
153	0,54
154	0,54
155	0,53
156	0,52
157	0,51
158	0,51
159	0,50
160	0,5*/

            return lCropCoefficient;

        }

        private CropCoefficient createMaizCropCoefficientWithList(Specie lSpecie, Region lRegion)
        {
            //KC Para soja sacado de la carpeta Calculos
            CropCoefficient lCropCoefficient  =  new CropCoefficient(lSpecie, lRegion);
            lCropCoefficient.addDayToList(0,0.30);
            lCropCoefficient.addDayToList(1,0.31);
            lCropCoefficient.addDayToList(2,0.32);
            lCropCoefficient.addDayToList(3,0.33);
            lCropCoefficient.addDayToList(4,0.34);
            lCropCoefficient.addDayToList(5,0.35);
            lCropCoefficient.addDayToList(6,0.37);
            lCropCoefficient.addDayToList(7,0.38);
            lCropCoefficient.addDayToList(9,0.40);
            lCropCoefficient.addDayToList(10,0.41);
            lCropCoefficient.addDayToList(11,0.42);
            lCropCoefficient.addDayToList(12,0.43);
            lCropCoefficient.addDayToList(13,0.44);
            lCropCoefficient.addDayToList(14,0.45);
            lCropCoefficient.addDayToList(15,0.46);
            lCropCoefficient.addDayToList(16,0.47);
            lCropCoefficient.addDayToList(17,0.48);
            lCropCoefficient.addDayToList(18,0.50);
            lCropCoefficient.addDayToList(19,0.51);
            lCropCoefficient.addDayToList(20,0.52);
            lCropCoefficient.addDayToList(21,0.53);
            lCropCoefficient.addDayToList(22,0.54);
            lCropCoefficient.addDayToList(23,0.55);
            lCropCoefficient.addDayToList(24,0.56);
            lCropCoefficient.addDayToList(25,0.57);
            lCropCoefficient.addDayToList(26,0.58);
            lCropCoefficient.addDayToList(27,0.59);
            lCropCoefficient.addDayToList(28,0.60);
            lCropCoefficient.addDayToList(29,0.61);
            lCropCoefficient.addDayToList(30,0.63);
            lCropCoefficient.addDayToList(31,0.64);
            lCropCoefficient.addDayToList(32,0.65);
            lCropCoefficient.addDayToList(33,0.66);
            lCropCoefficient.addDayToList(34,0.67);
            lCropCoefficient.addDayToList(35,0.68);
            lCropCoefficient.addDayToList(36,0.69);
            lCropCoefficient.addDayToList(37,0.70);
            lCropCoefficient.addDayToList(38,0.71);
            lCropCoefficient.addDayToList(39,0.72);
            lCropCoefficient.addDayToList(40,0.73);
            lCropCoefficient.addDayToList(41,0.74);
            lCropCoefficient.addDayToList(42,0.76);
            lCropCoefficient.addDayToList(43,0.77);
            lCropCoefficient.addDayToList(44,0.78);
            lCropCoefficient.addDayToList(45,0.79);
            lCropCoefficient.addDayToList(46,0.80);
            lCropCoefficient.addDayToList(47,0.81);
            lCropCoefficient.addDayToList(48,0.82);
            lCropCoefficient.addDayToList(49,0.83);
            lCropCoefficient.addDayToList(50,0.84);
            lCropCoefficient.addDayToList(51,0.85);
            lCropCoefficient.addDayToList(52,0.86);
            lCropCoefficient.addDayToList(53,0.87);
            lCropCoefficient.addDayToList(54,0.89);
            lCropCoefficient.addDayToList(55,0.90);
            lCropCoefficient.addDayToList(56,0.91);
            lCropCoefficient.addDayToList(57,0.92);
            lCropCoefficient.addDayToList(58,0.93);
            lCropCoefficient.addDayToList(59,0.94);
            lCropCoefficient.addDayToList(60,0.95);
            lCropCoefficient.addDayToList(61,0.96);
            lCropCoefficient.addDayToList(62,0.97);
            lCropCoefficient.addDayToList(63,0.98);
            lCropCoefficient.addDayToList(64,0.9);
            lCropCoefficient.addDayToList(65,1);
            lCropCoefficient.addDayToList(66,1.02);
            lCropCoefficient.addDayToList(67,1.03);
            lCropCoefficient.addDayToList(68,1.04);
            lCropCoefficient.addDayToList(69,1.05);
            lCropCoefficient.addDayToList(70,1.06);
            lCropCoefficient.addDayToList(71,1.07);
            lCropCoefficient.addDayToList(72,1.08);
            lCropCoefficient.addDayToList(73,1.09);
            lCropCoefficient.addDayToList(74,1.10);
            lCropCoefficient.addDayToList(75,1.11);
            lCropCoefficient.addDayToList(76,1.12);
            lCropCoefficient.addDayToList(77,1.13);
            lCropCoefficient.addDayToList(78,1.15);
            lCropCoefficient.addDayToList(79,1.16);
            lCropCoefficient.addDayToList(80,1.17);
            lCropCoefficient.addDayToList(81,1.18);
            lCropCoefficient.addDayToList(82,1.19);
            lCropCoefficient.addDayToList(83,1.20);
            lCropCoefficient.addDayToList(84,1.19);
            lCropCoefficient.addDayToList(85,1.17);
            lCropCoefficient.addDayToList(86,1.16);
            lCropCoefficient.addDayToList(87,1.15);
            lCropCoefficient.addDayToList(88,1.13);
            lCropCoefficient.addDayToList(89,1.12);
            lCropCoefficient.addDayToList(90,1.11);
            lCropCoefficient.addDayToList(91,1.09);
            lCropCoefficient.addDayToList(92,1.08);
            lCropCoefficient.addDayToList(93,1.07);
            lCropCoefficient.addDayToList(94,1.05);
            lCropCoefficient.addDayToList(95,1.04);
            lCropCoefficient.addDayToList(96,1.03);
            lCropCoefficient.addDayToList(97,1.01);
            lCropCoefficient.addDayToList(98,1);
            lCropCoefficient.addDayToList(99,0.99);
            lCropCoefficient.addDayToList(100,0.97);
            lCropCoefficient.addDayToList(101,0.96);
            lCropCoefficient.addDayToList(102,0.95);
            lCropCoefficient.addDayToList(103,0.93);
            lCropCoefficient.addDayToList(104,0.92);
            lCropCoefficient.addDayToList(105,0.91);
            lCropCoefficient.addDayToList(106,0.89);
            lCropCoefficient.addDayToList(107,0.88);
            /*
             * 108	0,87
109	0,85
110	0,84
111	0,83
112	0,81
113	0,80
114	0,79
115	0,78
116	0,76
117	0,75
118	0,74
119	0,72
120	0,71
121	0,70
122	0,68
123	0,67
124	0,66
125	0,64
126	0,63
127	0,62
128	0,60
129	0,59
130	0,58
131	0,56
132	0,55
133	0,54
134	0,52
135	0,51
136	0,50
137	0,48
138	0,47
139	0,46
140	0,44
141	0,43
142	0,42
143	0,40
144	0,39
145	0,38
146	0,36
147	0,35
*/
            
            return lCropCoefficient;

        }
        private PhenologicalStage cretePhenologicalStage(int p, Specie lSpecie, Stage stage, double minDegree, double maxDegree, double rootDepth)
        {
            return new PhenologicalStage(p, lSpecie, stage, minDegree, maxDegree, rootDepth);

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
            lCountry = new Country("Uruguay", null );
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

/*         KC segun grados dia acumulados
 *          lCropCoefficient.addDayToList(1, 0.5);
            lCropCoefficient.addDayToList(2, 0.5);
            lCropCoefficient.addDayToList(3, 0.35);
            lCropCoefficient.addDayToList(4, 0.35);
            lCropCoefficient.addDayToList(5, 0.38);
            lCropCoefficient.addDayToList(6, 0.4);
            lCropCoefficient.addDayToList(7, 0.45);
            lCropCoefficient.addDayToList(8, 0.5);
            lCropCoefficient.addDayToList(9, 0.67);
            lCropCoefficient.addDayToList(10, 0.8);
            lCropCoefficient.addDayToList(11, 0.85);
            lCropCoefficient.addDayToList(12, 0.9);
            lCropCoefficient.addDayToList(13, 0.95);
            lCropCoefficient.addDayToList(14, 1.05);
            lCropCoefficient.addDayToList(15, 1.1);
            lCropCoefficient.addDayToList(16, 1.1);
            lCropCoefficient.addDayToList(17, 1.1);
            lCropCoefficient.addDayToList(18, 1.1);
            lCropCoefficient.addDayToList(19, 1.1);
            lCropCoefficient.addDayToList(20, 1);
            lCropCoefficient.addDayToList(21, 0.9);
            lCropCoefficient.addDayToList(22, 0.8);
            lCropCoefficient.addDayToList(23, 0.7);
 
 
 * * datos para extender la lista empezada
 * 70	1,14
71	1,13
72	1,12
73	1,11
74	1,11
75	1,10
76	1,09
77	1,09
78	1,08
79	1,07
80	1,06
81	1,06
82	1,05
83	1,04
84	1,04
85	1,03
86	1,02
87	1,01
88	1,01
89	1,00
90	0,99
91	0,99
92	0,98
93	0,97
94	0,96
95	0,96
96	0,95
97	0,94
98	0,94
99	0,93
100	0,92
101	0,91
102	0,91
103	0,90
104	0,89
105	0,89
106	0,88
107	0,87
108	0,86
109	0,86
110	0,85
111	0,84
112	0,84
113	0,83
114	0,82
115	0,81
116	0,81
117	0,80
118	0,79
119	0,79
120	0,78
121	0,77
122	0,76
123	0,76
124	0,75
125	0,74
126	0,74
127	0,73
128	0,72
129	0,71
130	0,71
131	0,70
132	0,69
133	0,69
134	0,68
135	0,67
136	0,66
137	0,66
138	0,65
139	0,64
140	0,64
141	0,63
142	0,62
143	0,61
144	0,61
145	0,60
146	0,59
147	0,59
148	0,58
149	0,57
150	0,56
151	0,56
152	0,55
153	0,54
154	0,54
155	0,53
156	0,52
157	0,51
158	0,51
159	0,50
160	0,50

            */

