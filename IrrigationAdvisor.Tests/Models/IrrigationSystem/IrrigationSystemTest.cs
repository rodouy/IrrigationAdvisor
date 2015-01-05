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
        #region Fields General Test

        private Region lRegion;
        private Location.Location lLocation;
        private Specie lSpecieSoja;
        private Specie lSpecieMaiz;
        private Soil lSoil;
        private PhenologicalStage initialPhenologicalState;
        private CropCoefficient lCropCoefficientSoja;
        private CropCoefficient lCropCoefficientMaiz;
        private Crop.Crop crop;
        private Bomb lBomb;
        private Irrigation.IrrigationUnit irrigationUnit;
        private WeatherStation.WeatherStation weatherStation;
        private CropIrrigationWeather cropIrrigWeatherPrueba;
        private List<PhenologicalStage> phenologicalStageList;
        private Pair<Region, List<PhenologicalStage>> phenologicalStagesForRegion;
        private List<EffectiveRain> effectiveRainsList;
        private Pair<Region, List<EffectiveRain>> effectiveRainsForRegion;
        
        #endregion


        #region Fields Santa Lucia Test

        enum SantaLuciaPivots
        {
            Pivot2,
            Pivot3_4,
            Pivot5
        };

        private Soil soil_1;
        private Soil soil_2;
        private Soil soil_3_4;
        private Soil soil_5;
        private Crop.Crop cropMaizPivot2;
        private Crop.Crop cropSojaPivot3_4;
        private Crop.Crop cropSojaPivot5;
        private CropIrrigationWeather cropIrrigWeatherPivot2;
        private CropIrrigationWeather cropIrrigWeatherPivot3_4;
        private CropIrrigationWeather cropIrrigWeatherPivot5;
        double sojaBaseTemp = 8;
        double maizBaseTemp = 10;
        double PREDETERMINATED_IRRIGATION = 20;

        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot2;
        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot3_4;
        private List<Pair<DateTime, Stage>> PhenologicalStageChange_Pivot5;

        private DateTime dateBeginCrop_Pivot2;
        private DateTime dateBeginCrop_Pivot3_4;
        private DateTime dateBeginCrop_Pivot5;

        #endregion

        private IrrigationSystem irrigationSystem;
        /// <summary>
        /// this method is used to obtain the layout
        /// </summary>
        [TestMethod]
        public void santaLuciaTest()
        {
            Position lPosition;
            Country lCountry;

            lPosition = new Position(0,0);
            lRegion = new Region("Templada", lPosition);
            lCountry = new Country();
            lCountry.Name = "Uruguay";
            lLocation = createLocation(new Position(34, 55), lCountry, lRegion, new City("Santa Lucia", lPosition));

            lSpecieSoja = createSpecie(1, "Soja", lRegion, sojaBaseTemp);
            lSpecieMaiz = createSpecie(1, "Maiz", lRegion, maizBaseTemp);

            dateBeginCrop_Pivot2 = new DateTime(2014, 10, 21);
            dateBeginCrop_Pivot3_4 = new DateTime(2014, 11, 14);
            dateBeginCrop_Pivot5 = new DateTime(2014, 10, 18);

            crearSuelosSantaLucia();
            
            irrigationSystem = new IrrigationSystem();

            phenologicalStageList = InitialTables.createPhenologicalStageList(irrigationSystem, lSpecieMaiz, lSpecieSoja);
            phenologicalStagesForRegion = new Pair<Region, List<PhenologicalStage>>(lRegion, phenologicalStageList);
            this.irrigationSystem.PhenologicalStageList.Add(phenologicalStagesForRegion);
            

            effectiveRainsList = InitialTables.addEffectiveRainListToSystem(lRegion);
            effectiveRainsForRegion = new Pair<Region, List<EffectiveRain>>(lRegion, effectiveRainsList);
            this.irrigationSystem.EffectiveRainList.Add(effectiveRainsForRegion);

            crearCultivosSantaLucia();

            crearUnidadesDeRiegoSantaLucia();
            
            //Add Information of Weather
            agregarDatosDelTiempo();

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

            //The start day is one day after sowing because the first day is created when the crop is created
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
            lBomb = new Bomb("Bomba1", 1234, DateTime.Now, DateTime.Now, lLocation);
            irrigationUnit = creteIrrigationUnit(1, "Unidad de Riego de prueba", "Pivot",
                999, new List<Utilities.Pair<DateTime, double>>(), 300, new List<Crop.Crop>(), lBomb, lLocation);

            weatherStation = new WeatherStation.WeatherStation(1, "WeatherStation1", "Model?", DateTime.Now, DateTime.Now, DateTime.Now, 1, lLocation, true);

            cropIrrigWeatherPivot2 = new CropIrrigationWeather(irrigationUnit, cropMaizPivot2, weatherStation, null, PREDETERMINATED_IRRIGATION);
            cropIrrigWeatherPivot3_4 = new CropIrrigationWeather(irrigationUnit, cropSojaPivot3_4, weatherStation, null, PREDETERMINATED_IRRIGATION);
            cropIrrigWeatherPivot5 = new CropIrrigationWeather(irrigationUnit, cropSojaPivot5, weatherStation, null, PREDETERMINATED_IRRIGATION);


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

            
            lCropCoefficientMaiz = Data.InitialTables.CreateMaizCropCoefficientWithList(lSpecieMaiz, lRegion);
            lCropCoefficientSoja = Data.InitialTables.CreateSojaCropCoefficientWithList(lSpecieSoja, lRegion);

            initialPhenologicalState = new PhenologicalStage(1, lSpecieMaiz, new Stage(1, "v0", "Sin hojas"), 0, 60, 5);

            cropMaizPivot2 = createCrop(1, "Maiz SantaLucia Pivot 2", lSpecieMaiz, lLocation, lCropCoefficientMaiz, cropDensityMaiz,
                initialPhenologicalState, dateBeginCrop_Pivot2, DateTime.Now, soil_2, lMaizMaxEvaporTransptoIrrigate);

            cropSojaPivot3_4 = createCrop(1, "Soja SantaLucia Pivot 3 4", lSpecieSoja, lLocation, lCropCoefficientSoja, cropDensitySoja,
                            initialPhenologicalState, dateBeginCrop_Pivot3_4, DateTime.Now, soil_3_4, lSojaMaxEvaporTransptoIrrigate);

            cropSojaPivot5 = createCrop(1, "Maiz SantaLucia Pivot 5", lSpecieMaiz, lLocation, lCropCoefficientMaiz, cropDensityMaiz,
                                        initialPhenologicalState, dateBeginCrop_Pivot5, DateTime.Now, soil_5, lMaizMaxEvaporTransptoIrrigate);


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

        private void agregarDatosDelTiempo()
        {
            WeatherStation.WeatherStation lWeatherStation;
            DateTime lLastDay;
            DateTime lNextDay;
            WeatherStation.WeatherData lWeatherData;
            double lTemperature;
            double lSolarRadiation;
            double lTemperatureMax;
            double lTemperatureMin;
            double lEvapotranspiration;
            double lEvapotranspirationLast3;
            double lEvapotranspirationLast3Weight;
            double lEvapotranspirationLast2;
            double lEvapotranspirationLast2Weight;
            double lEvapotranspirationLast1;
            double lEvapotranspirationLast1Weight;

            // DATOS DEL TIEMPO
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 18), 99, 0, 19.6, 19.6, 2.4);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 19), 99, 0, 18.3, 18.3, 4.8);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 20), 99, 0, 15.9, 15.9, 4.1);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 21), 99, 0, 16.9, 16.9, 4.8);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 22), 99, 0, 19.5, 19.5, 5.5);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 23), 99, 0, 20.1, 20.1, 5);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 24), 99, 0, 19.7, 19.7, 4.6);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 25), 99, 0, 20.1, 20.1, 5);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 26), 99, 0, 11.7, 11.7, 5.5);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 27), 99, 0, 23.5, 23.5, 6.5);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 28), 99, 0, 20, 20, 5.5);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 29), 99, 0, 15.3, 15.3, 1.9);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 30), 99, 0, 12.5, 12.5, 4.5);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 31), 99, 0, 11.3, 11.3, 3.3);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 1), 99, 0, 12.6, 12.6, 3.3);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 2), 99, 0, 12.4, 12.4, 2.9);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 3), 99, 0, 14.2, 14.2, 2.1);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 4), 99, 0, 12.9, 12.9, 4.8);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 5), 99, 0, 14.9, 14.9, 4.9);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 6), 99, 0, 16.2, 16.2, 4.8);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 7), 99, 0, 17.7, 17.7, 4.6);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 8), 99, 0, 17, 17, 5.5);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 9), 99, 0, 17.1, 17.1, 5.3);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 10), 99, 0, 19.2, 19.2, 4.4);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 11), 99, 0, 19.6, 19.6, 4.8);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 12), 99, 0, 16.1, 16.1, 5);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 13), 99, 0, 13, 13, 4.7);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 14), 99, 0, 15.8, 15.8, 5.5);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 15), 99, 0, 20.9, 20.9, 6.5);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 16), 99, 0, 18.3, 18.3, 5.7);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 17), 99, 0, 18.8, 18.8, 6.5);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 18), 99, 0, 21.1, 21.1, 6.5);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 19), 99, 0, 19.4, 19.4, 3.7);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 20), 99, 0, 17.8, 17.8, 3.2);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 21), 99, 0, 17, 17, 2.6);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 22), 99, 0, 17.3, 17.3, 4.4);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 23), 99, 0, 19.6, 19.6, 6.2);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 24), 99, 0, 17.3, 17.3, 2.3);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 25), 99, 0, 17.2, 17.2, 5.1);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 26), 99, 0, 15.7, 15.7, 3.9);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 27), 99, 0, 17.9, 17.9, 5.3);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 28), 99, 0, 20.7, 20.7, 7);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 29), 99, 0, 24, 24, 6.2);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 30), 99, 0, 19.5, 19.5, 2.2);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 1), 99, 0, 18, 18, 2.7);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 2), 99, 0, 18, 18, 2.3);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 3), 99, 0, 20.2, 20.2, 5.9);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 4), 99, 0, 21.8, 21.8, 6.3);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 5), 99, 0, 22.7, 22.7, 7.6);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 6), 99, 0, 24.7, 24.7, 7.3);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 7), 99, 0, 22.7, 22.7, 3.6);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 8), 99, 0, 21, 21, 2.5);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 9), 99, 0, 24.3, 24.3, 5.2);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 10), 99, 0, 18.8, 18.8, 4.9);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 11), 99, 0, 17.6, 17.6, 5.4);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 12), 99, 0, 20.2, 20.2, 5.2);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 13), 99, 0, 21, 21, 5.4);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 14), 99, 0, 17.5, 17.5, 5.8);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 15), 99, 0, 18.9, 18.9, 6.2);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 16), 99, 0, 22.7, 22.7, 3.7);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 17), 99, 0, 22.0, 22.0, 6.0);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 18), 99, 0, 23.2, 23.2, 6.9);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 19), 99, 0, 26.3, 26.3, 8.6);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 20), 99, 0, 22.6, 22.6, 4.5);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 21), 99, 0, 16.4, 16.4, 3.6);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 22), 99, 0, 16.2, 16.2, 5.3);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 23), 99, 0, 17.0, 17.0, 6.0);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 24), 99, 0, 19.4, 19.4, 6.8);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 25), 99, 0, 24.3, 24.3, 6.9);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 26), 99, 0, 25.1, 25.1, 3.8);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 27), 99, 0, 23.3, 23.3, 5.2);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 28), 99, 0, 24.5, 24.5, 5.8);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 29), 99, 0, 25.4, 25.4, 6.9);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 30), 99, 0, 26.6, 26.6, 7.2);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 31), 99, 0, 24.6, 24.6, 4.5);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2015, 01, 01), 99, 0, 21.3, 21.3, 4.8);

            //TODO: Step 1 Layout WeatherStation Weather Data


            //Last data record
            lWeatherStation = weatherStation;
            lLastDay = irrigationSystem.WeatherDataList[irrigationSystem.WeatherDataList.Count - 1].Date;
            lEvapotranspirationLast3Weight = 0.2;
            lEvapotranspirationLast2Weight = 0.3;
            lEvapotranspirationLast1Weight = 0.5;

            for (int i = 0; i < InitialTables.DAYS_FOR_PREDICTION; i++)
            {
                lWeatherData = irrigationSystem.getWeatherDataFromList(lWeatherStation, lLastDay);
                lNextDay = lLastDay.AddDays(1);
                lTemperature = lWeatherData.Temperature;
                lSolarRadiation = lWeatherData.SolarRadiation;
                lTemperatureMax = lWeatherData.TemperatureMax;
                lTemperatureMin = lWeatherData.TemperatureMin;

                lEvapotranspirationLast1 = lWeatherData.Evapotranspiration;
                lWeatherData = irrigationSystem.getWeatherDataFromList(lWeatherStation, lLastDay.AddDays(-1));
                lEvapotranspirationLast2 = lWeatherData.Evapotranspiration;
                lWeatherData = irrigationSystem.getWeatherDataFromList(lWeatherStation, lLastDay.AddDays(-2));
                lEvapotranspirationLast3 = lWeatherData.Evapotranspiration;

                lEvapotranspiration = Math.Round(
                    lEvapotranspirationLast3 * lEvapotranspirationLast3Weight
                    + lEvapotranspirationLast2 * lEvapotranspirationLast2Weight
                    + lEvapotranspirationLast1 * lEvapotranspirationLast1Weight, 2);

                irrigationSystem.addWeatherDataToList(weatherStation, lNextDay, lTemperature,
                                                lSolarRadiation, lTemperatureMax, lTemperatureMin,
                                                lEvapotranspiration);
                lLastDay = lLastDay.AddDays(1);
            
            }

            

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

        [TestMethod]
        public void systemTestInicial()
        {
            this.createTestingUnityPruebaInicial();
            this.addWeatherDataPruebaInicial();
            irrigationSystem.addCropIrrigWeatherToList(this.cropIrrigWeatherPrueba);
            this.addRainData();
            this.addDailyRecordPruebaInicial();
            //this.printSystemData();

        }

        private void addDailyRecordPruebaInicial()
        {
            double irrigationCalculated = 0;
            irrigationSystem.addDailyRecordToList(this.cropIrrigWeatherPrueba, new DateTime(2014, 11, 1), "Dia uno");
            irrigationCalculated = irrigationSystem.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            irrigationSystem.addDailyRecordToList(this.cropIrrigWeatherPrueba, new DateTime(2014, 11, 2), "Dia dos");
            irrigationCalculated = irrigationSystem.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            irrigationSystem.addDailyRecordToList(this.cropIrrigWeatherPrueba, new DateTime(2014, 11, 3), "Dia tres");
            irrigationCalculated = irrigationSystem.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            irrigationSystem.addDailyRecordToList(this.cropIrrigWeatherPrueba, new DateTime(2014, 11, 4), "Dia cuatro");
            irrigationCalculated = irrigationSystem.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            irrigationSystem.addOrUpdateIrrigationDataToList(cropIrrigWeatherPrueba, new DateTime(2014, 11, 5), 22,true);
            irrigationSystem.addDailyRecordToList(this.cropIrrigWeatherPrueba, new DateTime(2014, 11, 5), "Dia cinco");
            irrigationCalculated = irrigationSystem.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            irrigationSystem.addDailyRecordToList(this.cropIrrigWeatherPrueba, new DateTime(2014, 11, 6), "Dia seis");
            

        }
        public void addWeatherDataPruebaInicial()
        {
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 1), 99, 0, 30, 10, 2);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 2), 99, 0, 13, 4, 2.5);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 3), 99, 0, 11.7, 1, 3.6);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 4), 99, 0, 14.4, 5, 4.7);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 5), 99, 0, 20, 4, 4);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 6), 99, 0, 22.8, 1, 3.5);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 7), 99, 0, 10.6, 5.6, 3.8);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 8), 99, 0, 15.6, 2.8, 4.6);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 9), 99, 0, 18, 0, 2.6);
            irrigationSystem.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 10), 99, 0, 6, 0, 3.4);




        }

        private void addRainData()
        {
            irrigationSystem.addRainDataToList(cropIrrigWeatherPrueba, new DateTime(2014, 11, 4), 3);
            irrigationSystem.addRainDataToList(cropIrrigWeatherPrueba, new DateTime(2014, 11, 9), 8);
        }

        private void printSystemData()
        {
            TextFileLogger lTextFileLogger = new TextFileLogger();
            String lFile = "IrrigationSystemTest";
            String lMethod = "createACropIrrigationWeather";
            CropIrrigationWeatherRecords rec = irrigationSystem.CropIrrigationWeatherRecordsList.Find(x => x.CropIrrigationWeather.Equals(cropIrrigWeatherPrueba));
            
            String lMessage = irrigationSystem.printDailyRecordsList(rec);
            lMessage += irrigationSystem.printWeatherDataList();
            String lTime = System.DateTime.Now.ToString();
            lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
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

        public void createTestingUnityPruebaInicial()
        {
            lRegion = new Region("Templada",new Position(0,0));
            Country lCountry = new Country();
            lCountry.Name = "Uruguay";
            lLocation = createLocation(new Position(34, 55),lCountry, lRegion, new City("Minas",null ));

            lSpecieSoja = createSpecie(1, "Soja", lRegion, sojaBaseTemp);
            lSpecieMaiz = createSpecie(2, "Maiz", lRegion, maizBaseTemp);
            
            lSoil = createSoil(lLocation);
            irrigationSystem = new IrrigationSystem();
            
            double minDegree = 0;
            double maxDegree = 60;
            double rootDepth = 5;

            
            initialPhenologicalState = irrigationSystem.CreatePhenologicalStage(1, lSpecieSoja, new Stage(1, "v0", "Sin hojas"), minDegree, maxDegree, rootDepth);

            lCropCoefficientSoja = Data.InitialTables.CreateSojaCropCoefficientWithList(lSpecieSoja, lRegion);

            DateTime lSowingDate = new DateTime (2014,11,01);
            double lSojaMaxEvaporTransptoIrrigate = 35;
            double cropDensity = 70;
            
            phenologicalStageList = InitialTables.createPhenologicalStageList(irrigationSystem, lSpecieMaiz, lSpecieSoja);
            phenologicalStagesForRegion = new Pair<Region, List<PhenologicalStage>>(lRegion, phenologicalStageList);
            this.irrigationSystem.PhenologicalStageList.Add(phenologicalStagesForRegion);
            
            effectiveRainsList = InitialTables.addEffectiveRainListToSystem(lRegion);
            effectiveRainsForRegion = new Pair<Region, List<EffectiveRain>>(lRegion, effectiveRainsList);
            this.irrigationSystem.EffectiveRainList.Add(effectiveRainsForRegion);

            crop = createCrop(1,"Soja en Minas", lSpecieSoja,lLocation, lCropCoefficientSoja, cropDensity,
                initialPhenologicalState, lSowingDate, DateTime.Now, lSoil, lSojaMaxEvaporTransptoIrrigate);
                
            lBomb = new Bomb("Bomba1", 1234, DateTime.Now, DateTime.Now, lLocation);
            irrigationUnit = creteIrrigationUnit(1, "Unidad de Riego de prueba", "Pivot", 
                999, new List<Utilities.Pair<DateTime, double>>(), 300, new List<Crop.Crop>(), lBomb, lLocation);
               
            weatherStation = new WeatherStation.WeatherStation(1,"WeatherStation1","Model?",DateTime.Now,DateTime.Now,DateTime.Now, 1, lLocation,true);

            cropIrrigWeatherPrueba = new CropIrrigationWeather(irrigationUnit, crop, weatherStation, null, PREDETERMINATED_IRRIGATION);

            
        }

       
        #region Private Helpers

        private IrrigationUnit creteIrrigationUnit(int pId, string pName, string pType, int pEfficiency, 
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
 
            lPhenologicalStageList = irrigationSystem.getPhenologicalStage(lRegion, pSpecie);
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
