﻿using System;
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
        
        #endregion



        #region Fields Santa Lucia Test

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
            
        
        #endregion

        private IrrigationSystem irrirgSys;
        /// <summary>
        /// this method is used to obtain the layout
        /// </summary>
        [TestMethod]
        public void santaLuciaTest()
        {
            Position lPosition = new Position(0,0);
            lRegion = new Region("Templada", lPosition);
            Country lCountry = new Country();
            lCountry.Name = "Uruguay";
            lLocation = createLocation(new Position(34, 55), lCountry, lRegion, new City("Santa Lucia", lPosition));

            lSpecieSoja = createSpecie(1, "Soja", lRegion, sojaBaseTemp);
            lSpecieMaiz = createSpecie(1, "Maiz", lRegion, maizBaseTemp);

            crearSuelosSantaLucia();
            
            irrirgSys = new IrrigationSystem();
            addPhenologicalStageListToSystem();
            addEffectiveRainListToSystem();
            crearCultivosSantaLucia();

            crearUnidadesDeRiegoSantaLucia();
            
            //Add Information of Weather
            agregarDatosDelTiempo();

            //Add Information of Rain
            agregarDatosDeLluvia();

            //Add Information of Irrigation
            agregarDatosDeRiego();

            //Adding to system the Irrigation Unit (pivots)
            irrirgSys.addCropIrrigWeatherToList(cropIrrigWeatherPivot2);
            irrirgSys.addCropIrrigWeatherToList(cropIrrigWeatherPivot3_4);
            irrirgSys.addCropIrrigWeatherToList(cropIrrigWeatherPivot5);

            //DAILY RECORDS
            // Titles
            /*
             * " \tETCAc " +
                " \t\tETCFromLWI " +
                " \t G.Dia: " +
                " \t G.D. Mod: " +
                " \tB.Hid: " +
                " \t% A.D.: " +
                " \tA.D.: " +
                " \t\tCC: " +
                " \t\tPMP: " +
                " \t\tEffRain: " +
                " \tTotRain: " +
                " \tTotIrrig: " +
                " \tLastWaterInput: " +
                " \tRaiz " + 
                " \tFenol " +
                "\tIrrigCalulated: " +
                "\tIrrigExtra: "
             */
            String textLogPivot2 ;
            String textLogPivot3_4 ;
            String textLogPivot5 ;
            
            //Find the records of Crop Irrigation Unit (Pivots)
            CropIrrigationWeatherRecords recP2 = irrirgSys.CropIrrigationWeatherRecordsList.Find(x => x.CropIrrigationWeather.Equals(cropIrrigWeatherPivot2));
            CropIrrigationWeatherRecords recP3_4 = irrirgSys.CropIrrigationWeatherRecordsList.Find(x => x.CropIrrigationWeather.Equals(cropIrrigWeatherPivot3_4));
            CropIrrigationWeatherRecords recP5 = irrirgSys.CropIrrigationWeatherRecordsList.Find(x => x.CropIrrigationWeather.Equals(cropIrrigWeatherPivot5));

            //Add information to Irrigation Units to calculate irrigation for each one
            agregarDatosPivot2_SantaLucia(recP2);
            agregarDatosPivot3_4_SantaLucia(recP3_4);
            agregarDatosPivot5_SantaLucia(recP5);

            //Layout from Irrigation Units
            textLogPivot2 = recP2.OutPut;
            textLogPivot3_4 = recP3_4.OutPut;
            textLogPivot5 = recP5.OutPut;

            //Layout from System the daily records
            textLogPivot2 += Environment.NewLine + Environment.NewLine + irrirgSys.printDailyRecordsList(recP2);
            textLogPivot3_4 += Environment.NewLine + Environment.NewLine + irrirgSys.printDailyRecordsList(recP3_4);
            textLogPivot5 += Environment.NewLine + Environment.NewLine + irrirgSys.printDailyRecordsList(recP5);


            //Layout in txt format
            this.printSystemData(textLogPivot2, "IrrigationSystemTestPivot2");
            this.printSystemData(textLogPivot3_4, "IrrigationSystemTestPivot3_4");
            this.printSystemData(textLogPivot5, "IrrigationSystemTestPivot5");

            //Layout in CSV format
            this.printSystemDataCSV("IrrigationSystem-TestPivot2", recP2.Titles, recP2.Messages);
            this.printSystemDataCSV("IrrigationSystem-TestPivot3_4", recP3_4.Titles, recP3_4.Messages);
            this.printSystemDataCSV("IrrigationSystem-TestPivot5", recP5.Titles, recP5.Messages);

            this.printSystemDataCSV("IrrigationSystem-DailyRecords-TestPivot2", recP2.TitlesDaily, recP2.MessagesDaily);
            this.printSystemDataCSV("IrrigationSystem-DailyRecords-TestPivot3_4", recP3_4.TitlesDaily, recP3_4.MessagesDaily);
            this.printSystemDataCSV("IrrigationSystem-DailyRecords-TestPivot5", recP5.TitlesDaily, recP5.MessagesDaily);

        }

        private void agregarDatosPivot2_SantaLucia(CropIrrigationWeatherRecords recP2)
        {
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 22), "Dia 1");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 23), "Dia 2");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 24), "Dia 3");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 25), "Dia 4");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 26), "Dia 5");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 27), "Dia 6");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 28), "Dia 7");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 29), "Dia 8");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 30), "Dia 9");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 31), "Dia 10");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 1), "Dia 11");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 2), "Dia 12");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 3), "Dia 13");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 4), "Dia 14");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 5), "Dia 15");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 6), "Dia 16");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 7), "Dia 17");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 8), "Dia 18");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 9), "Dia 19");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 10), "Dia 20");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 11), "Dia 21");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 12), "Dia 22");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 13), "Dia 23");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 14), "Dia 24");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 15), "Dia 25");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 16), "Dia 26");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 17), "Dia 27");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 18), "Dia 28");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 19), "Dia 29");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 20), "Dia 30");
            //Adjustment of Phenological Stage
            irrirgSys.adjustmentPhenology(this.cropIrrigWeatherPivot2, new Stage(1, "v2", "2 Hojas"), new DateTime(2014, 11, 20));
            
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 21), "Dia 31");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 22), "Dia 32");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 23), "Dia 33");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 24), "Dia 34");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 25), "Dia 35");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 26), "Dia 36");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 27), "Dia 37");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 28), "Dia 38");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 29), "Dia 39");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 30), "Dia 40");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 1), "Dia 41");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 2), "Dia 42");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 3), "Dia 43");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 4), "Dia 44");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 5), "Dia 45");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 6), "Dia 46");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 7), "Dia 47");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 8), "Dia 48");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 9), "Dia 49");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 10), "Dia 50");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 11), "Dia 51");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 12), "Dia 52");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 13), "Dia 53");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 14), "Dia 54");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 15), "Dia 55");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 16), "Dia 56");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 17), "Dia 57");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 18), "Dia 58");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 19), "Dia 59");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 20), "Dia 60");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 21), "Dia 61");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 22), "Dia 62");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 23), "Dia 63");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 24), "Dia 64");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 25), "Dia 65");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 26), "Dia 66");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 27), "Dia 67");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 28), "Dia 68");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 29), "Dia 69");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 30), "Dia 70");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 31), "Dia 71");
        }

        private void agregarDatosPivot3_4_SantaLucia(CropIrrigationWeatherRecords recP3_4)
        {
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 15), "Dia 1");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 16), "Dia 21");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 17), "Dia 3");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 18), "Dia 4");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 19), "Dia 5");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 20), "Dia 6");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 21), "Dia 7");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 22), "Dia 8");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 23), "Dia 9");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 24), "Dia 10");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 25), "Dia 11");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 26), "Dia 12");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 27), "Dia 13");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 28), "Dia 14");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 29), "Dia 15");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 30), "Dia 16");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 1), "Dia 17");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 2), "Dia 18");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 3), "Dia 19");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 4), "Dia 20");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 5), "Dia 21");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 6), "Dia 22");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 7), "Dia 23");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 8), "Dia 24");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 9), "Dia 25");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 10), "Dia 26");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 11), "Dia 27");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 12), "Dia 28");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 13), "Dia 29");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 14), "Dia 30");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 15), "Dia 31");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 16), "Dia 32");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 17), "Dia 33");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 18), "Dia 34");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 19), "Dia 35");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 20), "Dia 36");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 21), "Dia 37");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 22), "Dia 38");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 23), "Dia 39");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 24), "Dia 40");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 25), "Dia 41");
            //Adjustment of Phenological Stage
            irrirgSys.adjustmentPhenology(this.cropIrrigWeatherPivot3_4, new Stage(1, "v4", "4 Hojas"), new DateTime(2014, 12, 25));
            
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 26), "Dia 42");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 27), "Dia 43");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 28), "Dia 44");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 29), "Dia 45");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 30), "Dia 46");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 31), "Dia 47");
        }

        private void agregarDatosPivot5_SantaLucia(CropIrrigationWeatherRecords recP5)
        {
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 19), "Dia 1");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 20), "Dia 2");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 21), "Dia 3");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 22), "Dia 4");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 23), "Dia 5");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 24), "Dia 6");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 25), "Dia 7");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 26), "Dia 8");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 27), "Dia 9");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 28), "Dia 10");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 29), "Dia 11");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 30), "Dia 12");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 31), "Dia 13");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 1), "Dia 14");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 2), "Dia 15");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 3), "Dia 16");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 4), "Dia 17");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 5), "Dia 18");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 6), "Dia 19");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 7), "Dia 20");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 8), "Dia 21");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 9), "Dia 22");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 10), "Dia 23");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 11), "Dia 24");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 12), "Dia 25");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 13), "Dia 26");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 14), "Dia 27");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 15), "Dia 28");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 16), "Dia 29");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 17), "Dia 30");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 18), "Dia 31");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 19), "Dia 32");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 20), "Dia 33");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 21), "Dia 34");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 22), "Dia 35");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 23), "Dia 36");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 24), "Dia 37");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 25), "Dia 38");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 26), "Dia 39");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 27), "Dia 40");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 28), "Dia 41");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 29), "Dia 42");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 30), "Dia 43");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 1), "Dia 44");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 2), "Dia 45");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 3), "Dia 46");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 4), "Dia 47");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 5), "Dia 48");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 6), "Dia 49");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 7), "Dia 50");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 8), "Dia 51");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 9), "Dia 52");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 10), "Dia 53");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 11), "Dia 54");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 12), "Dia 55");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 13), "Dia 56");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 14), "Dia 57");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 15), "Dia 58");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 16), "Dia 59");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 17), "Dia 60");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 18), "Dia 61");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 19), "Dia 62");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 20), "Dia 63");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 21), "Dia 64");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 22), "Dia 65");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 23), "Dia 66");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 24), "Dia 67");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 25), "Dia 68");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 26), "Dia 69");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 27), "Dia 70");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 28), "Dia 71");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 29), "Dia 72");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 30), "Dia 73");
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 31), "Dia 74");
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

            cropIrrigWeatherPivot2 = new CropIrrigationWeather(irrigationUnit, cropMaizPivot2, weatherStation, null);
            cropIrrigWeatherPivot3_4 = new CropIrrigationWeather(irrigationUnit, cropSojaPivot3_4, weatherStation, null);
            cropIrrigWeatherPivot5 = new CropIrrigationWeather(irrigationUnit, cropSojaPivot5, weatherStation, null);


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


            lCropCoefficientMaiz = createMaizCropCoefficientWithList(lSpecieMaiz, lRegion);
            lCropCoefficientSoja = createSojaCropCoefficientWithList(lSpecieSoja, lRegion);

            initialPhenologicalState = new PhenologicalStage(1, lSpecieMaiz, new Stage(1, "v0", "Sin hojas"), 0, 60, 5);

            cropMaizPivot2 = createCrop(1, "Maiz SantaLucia Pivot 2", lSpecieMaiz, lLocation, lCropCoefficientMaiz, cropDensityMaiz,
                initialPhenologicalState, new DateTime(2014, 10, 21), DateTime.Now, soil_2, lMaizMaxEvaporTransptoIrrigate);

            cropSojaPivot3_4 = createCrop(1, "Soja SantaLucia Pivot 3 4", lSpecieSoja, lLocation, lCropCoefficientSoja, cropDensitySoja,
                            initialPhenologicalState, new DateTime(2014, 11, 14), DateTime.Now, soil_3_4, lSojaMaxEvaporTransptoIrrigate);

            cropSojaPivot5 = createCrop(1, "Maiz SantaLucia Pivot 5", lSpecieMaiz, lLocation, lCropCoefficientMaiz, cropDensityMaiz,
                                        initialPhenologicalState, new DateTime(2014, 10, 18), DateTime.Now, soil_5, lMaizMaxEvaporTransptoIrrigate);


        }

        private void agregarDatosDeRiego()
        {
            
            //Pivot 2
            //Riego inicial
            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 10, 22), 22, true);
            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 12, 17), 10, true);
            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 12, 20), 10, true);
            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 12, 24), 10, true);
            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 12, 26), 10, true);

            //PIVOT 3_4
            //Riego inicial
            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 15),  5, true);
            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 19), 15, true);
            
            //dias 14, 18 y 22 de diciembre, todos de 5 mm
            //PIVOT 5
            //Riego inicial
            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 10, 21), 7, true);//?????????
            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 12, 14), 5, true);
            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 12, 18), 5, true);
            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 12, 22), 5, true);


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
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 10, 29), 66);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 10, 31), 2.5);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 11, 1), 2.5);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 11, 2), 10);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 11, 3), 35);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 11, 22), 27);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 11, 29), 50);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 11, 30), 51);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 12, 8), 15);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 12, 21), 5);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 12, 26), 4.5);
            
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 22), 27);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 29), 50);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 30), 51);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 8), 15);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 21), 5);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 26), 4.5);

            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 10, 29), 66);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 10, 31), 2.5);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 11, 1), 2.5);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 11, 2), 10);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 11, 3), 35);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 11, 22), 27);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 11, 29), 50);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 11, 30), 51);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 12, 8), 15);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 12, 21), 5);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 12, 26), 4.5);

            //TODO: 2 Layout Rain Weather Data
            

        }

        private void agregarDatosDelTiempo()
        {
            // DATOS DEL TIEMPO
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 18), 99, 0, 19.6, 19.6, 2.4);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 19), 99, 0, 18.3, 18.3, 4.8);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 10, 20), 99, 0, 15.9, 15.9, 4.1);
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
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 20), 99, 0, 17.8, 17.8, 3.2);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 21), 99, 0, 17, 17, 2.6);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 22), 99, 0, 17.3, 17.3, 4.4);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 23), 99, 0, 19.6, 19.6, 6.2);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 24), 99, 0, 17.3, 17.3, 2.3);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 25), 99, 0, 17.2, 17.2, 5.1);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 26), 99, 0, 15.7, 15.7, 3.9);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 27), 99, 0, 17.9, 17.9, 5.3);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 28), 99, 0, 20.7, 20.7, 7);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 29), 99, 0, 24, 24, 6.2);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 11, 30), 99, 0, 19.5, 19.5, 2.2);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 1), 99, 0, 18, 18, 2.7);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 2), 99, 0, 18, 18, 2.3);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 3), 99, 0, 20.2, 20.2, 5.9);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 4), 99, 0, 21.8, 21.8, 6.3);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 5), 99, 0, 22.7, 22.7, 7.6);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 6), 99, 0, 24.7, 24.7, 7.3);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 7), 99, 0, 22.7, 22.7, 3.6);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 8), 99, 0, 21, 21, 2.5);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 9), 99, 0, 24.3, 24.3, 5.2);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 10), 99, 0, 18.8, 18.8, 4.9);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 11), 99, 0, 17.6, 17.6, 5.4);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 12), 99, 0, 20.2, 20.2, 5.2);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 13), 99, 0, 21, 21, 5.4);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 14), 99, 0, 17.5, 17.5, 5.8);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 15), 99, 0, 18.9, 18.9, 6.2);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 16), 99, 0, 22.7, 22.7, 3.7);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 17), 99, 0, 22.0, 22.0, 6.0);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 18), 99, 0, 23.2, 23.2, 6.9);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 19), 99, 0, 26.3, 26.3, 8.6);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 20), 99, 0, 22.6, 22.6, 4.5);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 21), 99, 0, 16.4, 16.4, 3.6);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 22), 99, 0, 16.2, 16.2, 5.3);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 23), 99, 0, 17.0, 17.0, 6.0);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 24), 99, 0, 19.4, 19.4, 6.8);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 25), 99, 0, 24.3, 24.3, 6.9);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 26), 99, 0, 25.1, 25.1, 3.8);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 27), 99, 0, 23.3, 23.3, 5.2);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 28), 99, 0, 24.5, 24.5, 5.8);

            //TODO: 1 Layout WeatherStation Weather Data
            
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 29), 99, 0, 23, 23, 6);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 30), 99, 0, 23, 23, 6);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 31), 99, 0, 23, 23, 6);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2015, 01, 01), 99, 0, 17, 17, 6);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2015, 01, 02), 99, 0, 17, 17, 6);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2015, 01, 03), 99, 0, 17, 17, 6);

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
            irrirgSys.addCropIrrigWeatherToList(this.cropIrrigWeatherPrueba);
            this.addRainData();
            this.addDailyRecordPruebaInicial();
            //this.printSystemData();

        }

        private void addDailyRecordPruebaInicial()
        {
            double irrigationCalculated = 0;
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPrueba, new DateTime(2014, 11, 1), "Dia uno");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPrueba, new DateTime(2014, 11, 2), "Dia dos");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPrueba, new DateTime(2014, 11, 3), "Dia tres");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPrueba, new DateTime(2014, 11, 4), "Dia cuatro");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);

            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPrueba, new DateTime(2014, 11, 5), 22,true);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPrueba, new DateTime(2014, 11, 5), "Dia cinco");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPrueba, new DateTime(2014, 11, 6), "Dia seis");
            

        }
        public void addWeatherDataPruebaInicial()
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
            irrirgSys.addRainDataToList(cropIrrigWeatherPrueba, new DateTime(2014, 11, 4), 3);
            irrirgSys.addRainDataToList(cropIrrigWeatherPrueba, new DateTime(2014, 11, 9), 8);
        }

        private void printSystemData()
        {
            TextFileLogger lTextFileLogger = new TextFileLogger();
            String lFile = "IrrigationSystemTest";
            String lMethod = "createACropIrrigationWeather";
            CropIrrigationWeatherRecords rec = irrirgSys.CropIrrigationWeatherRecordsList.Find(x => x.CropIrrigationWeather.Equals(cropIrrigWeatherPrueba));
            
            String lMessage = irrirgSys.printDailyRecordsList(rec);
            lMessage += irrirgSys.printWeatherDataList();
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
            
            double minDegree = 0;
            double maxDegree = 60;
            double rootDepth = 5;
            initialPhenologicalState = cretePhenologicalStage(1,lSpecieSoja,new Stage(1,"v0","Sin hojas"),minDegree,maxDegree,rootDepth );
           
            lCropCoefficientSoja = createSojaCropCoefficientWithList(lSpecieSoja, lRegion);

            DateTime lSowingDate = new DateTime (2014,11,01);
            double lSojaMaxEvaporTransptoIrrigate = 35;
            double cropDensity = 70;
            
            irrirgSys = new IrrigationSystem();
            addPhenologicalStageListToSystem();
            addEffectiveRainListToSystem();
            
            crop = createCrop(1,"Soja en Minas", lSpecieSoja,lLocation, lCropCoefficientSoja, cropDensity,
                initialPhenologicalState, lSowingDate, DateTime.Now, lSoil, lSojaMaxEvaporTransptoIrrigate);
                
            lBomb = new Bomb("Bomba1", 1234, DateTime.Now, DateTime.Now, lLocation);
            irrigationUnit = creteIrrigationUnit(1, "Unidad de Riego de prueba", "Pivot", 
                999, new List<Utilities.Pair<DateTime, double>>(), 300, new List<Crop.Crop>(), lBomb, lLocation);
               
            weatherStation = new WeatherStation.WeatherStation(1,"WeatherStation1","Model?",DateTime.Now,DateTime.Now,DateTime.Now, 1, lLocation,true);

            cropIrrigWeatherPrueba = new CropIrrigationWeather(irrigationUnit, crop, weatherStation, null);

            
        }

        private void addEffectiveRainListToSystem()
        {
            List<EffectiveRain> effectiveRainList = new List<EffectiveRain>();
            effectiveRainList.Add(new EffectiveRain(lRegion, 10, 0, 10, 90));
            effectiveRainList.Add(new EffectiveRain(lRegion, 10, 11, 20, 80));
            effectiveRainList.Add(new EffectiveRain(lRegion, 10, 21, 30, 80));
            effectiveRainList.Add(new EffectiveRain(lRegion, 10, 31, 40, 75));
            effectiveRainList.Add(new EffectiveRain(lRegion, 10, 41, 40, 75));
            effectiveRainList.Add(new EffectiveRain(lRegion, 10, 51, 60, 70));
            effectiveRainList.Add(new EffectiveRain(lRegion, 10, 61, 70, 65));
            effectiveRainList.Add(new EffectiveRain(lRegion, 10, 71, 80, 60));
            effectiveRainList.Add(new EffectiveRain(lRegion, 10, 81, 90, 60));
            effectiveRainList.Add(new EffectiveRain(lRegion, 10, 91, 100, 55));
            effectiveRainList.Add(new EffectiveRain(lRegion, 10, 100, 1000, 50));

            effectiveRainList.Add(new EffectiveRain(lRegion, 11, 0, 10, 90));
            effectiveRainList.Add(new EffectiveRain(lRegion, 11, 11, 20, 80));
            effectiveRainList.Add(new EffectiveRain(lRegion, 11, 21, 30, 80));
            effectiveRainList.Add(new EffectiveRain(lRegion, 11, 31, 40, 75));
            effectiveRainList.Add(new EffectiveRain(lRegion, 11, 41, 40, 75));
            effectiveRainList.Add(new EffectiveRain(lRegion, 11, 51, 60, 70));
            effectiveRainList.Add(new EffectiveRain(lRegion, 11, 61, 70, 65));
            effectiveRainList.Add(new EffectiveRain(lRegion, 11, 71, 80, 60));
            effectiveRainList.Add(new EffectiveRain(lRegion, 11, 81, 90, 60));
            effectiveRainList.Add(new EffectiveRain(lRegion, 11, 91, 100, 55));
            effectiveRainList.Add(new EffectiveRain(lRegion, 11, 100, 1000, 50));

            effectiveRainList.Add(new EffectiveRain(lRegion, 12, 0, 10, 90));
            effectiveRainList.Add(new EffectiveRain(lRegion, 12, 11, 20, 80));
            effectiveRainList.Add(new EffectiveRain(lRegion, 12, 21, 30, 85));
            effectiveRainList.Add(new EffectiveRain(lRegion, 12, 31, 40, 80));
            effectiveRainList.Add(new EffectiveRain(lRegion, 12, 41, 40, 75));
            effectiveRainList.Add(new EffectiveRain(lRegion, 12, 51, 60, 75));
            effectiveRainList.Add(new EffectiveRain(lRegion, 12, 61, 70, 70));
            effectiveRainList.Add(new EffectiveRain(lRegion, 12, 71, 80, 70));
            effectiveRainList.Add(new EffectiveRain(lRegion, 12, 81, 90, 70));
            effectiveRainList.Add(new EffectiveRain(lRegion, 12, 91, 100, 70));
            effectiveRainList.Add(new EffectiveRain(lRegion, 12, 100, 1000, 60));

            effectiveRainList.Add(new EffectiveRain(lRegion, 1, 0, 10, 90));
            effectiveRainList.Add(new EffectiveRain(lRegion, 1, 11, 20, 80));
            effectiveRainList.Add(new EffectiveRain(lRegion, 1, 21, 30, 85));
            effectiveRainList.Add(new EffectiveRain(lRegion, 1, 31, 40, 80));
            effectiveRainList.Add(new EffectiveRain(lRegion, 1, 41, 40, 75));
            effectiveRainList.Add(new EffectiveRain(lRegion, 1, 51, 60, 75));
            effectiveRainList.Add(new EffectiveRain(lRegion, 1, 61, 70, 70));
            effectiveRainList.Add(new EffectiveRain(lRegion, 1, 71, 80, 70));
            effectiveRainList.Add(new EffectiveRain(lRegion, 1, 81, 90, 70));
            effectiveRainList.Add(new EffectiveRain(lRegion, 1, 91, 100, 70));
            effectiveRainList.Add(new EffectiveRain(lRegion, 1, 100, 1000, 60));

            effectiveRainList.Add(new EffectiveRain(lRegion, 2, 0, 10, 90));
            effectiveRainList.Add(new EffectiveRain(lRegion, 2, 11, 20, 80));
            effectiveRainList.Add(new EffectiveRain(lRegion, 2, 21, 30, 85));
            effectiveRainList.Add(new EffectiveRain(lRegion, 2, 31, 40, 80));
            effectiveRainList.Add(new EffectiveRain(lRegion, 2, 41, 40, 75));
            effectiveRainList.Add(new EffectiveRain(lRegion, 2, 51, 60, 75));
            effectiveRainList.Add(new EffectiveRain(lRegion, 2, 61, 70, 70));
            effectiveRainList.Add(new EffectiveRain(lRegion, 2, 71, 80, 70));
            effectiveRainList.Add(new EffectiveRain(lRegion, 2, 81, 90, 70));
            effectiveRainList.Add(new EffectiveRain(lRegion, 2, 91, 100, 70));
            effectiveRainList.Add(new EffectiveRain(lRegion, 2, 100, 1000, 60));

            effectiveRainList.Add(new EffectiveRain(lRegion, 3, 0, 10, 90));
            effectiveRainList.Add(new EffectiveRain(lRegion, 3, 11, 20, 80));
            effectiveRainList.Add(new EffectiveRain(lRegion, 3, 21, 30, 75));
            effectiveRainList.Add(new EffectiveRain(lRegion, 3, 31, 40, 75));
            effectiveRainList.Add(new EffectiveRain(lRegion, 3, 41, 40, 75));
            effectiveRainList.Add(new EffectiveRain(lRegion, 3, 51, 60, 70));
            effectiveRainList.Add(new EffectiveRain(lRegion, 3, 61, 70, 65));
            effectiveRainList.Add(new EffectiveRain(lRegion, 3, 71, 80, 60));
            effectiveRainList.Add(new EffectiveRain(lRegion, 3, 81, 90, 60));
            effectiveRainList.Add(new EffectiveRain(lRegion, 3, 91, 100, 55));
            effectiveRainList.Add(new EffectiveRain(lRegion, 3, 100, 1000, 50));

            
            
            Pair<Region, List<EffectiveRain>> lpair = new Pair<Region, List<EffectiveRain>>(lRegion, effectiveRainList);
            this.irrirgSys.EffectiveRainList.Add(lpair);
            
        }
        
        #region Private Helpers
        private void addPhenologicalStageListToSystem()
        {
            List<PhenologicalStage> lPhenolStageList = new List<PhenologicalStage>();
            lPhenolStageList.Add(cretePhenologicalStage(0, lSpecieMaiz, new Stage(1, "v0", "Sin hojas"), 0, 59, 5));
            lPhenolStageList.Add(cretePhenologicalStage(1, lSpecieMaiz, new Stage(1, "ve", "Sin hojas"), 60, 114, 5));////CAMBIE de 5 A 6
            lPhenolStageList.Add( cretePhenologicalStage(2, lSpecieMaiz, new Stage(1, "v1", "Sin hojas"), 115, 134, 7));////CAMBIE de 5 A 8
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
            lPhenolStageList.Add(cretePhenologicalStage(45, lSpecieSoja, new Stage(1, "R6", "Sin hojas"), 1650, 2000, 45));

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
            lCropCoefficient.addDayToList(0,0.30);
            lCropCoefficient.addDayToList(1,0.31);
            lCropCoefficient.addDayToList(2,0.31);
            lCropCoefficient.addDayToList(3,0.32);
            lCropCoefficient.addDayToList(4,0.33);
            lCropCoefficient.addDayToList(5,0.34);
            lCropCoefficient.addDayToList(6,0.34);
            lCropCoefficient.addDayToList(7, 0.35);
            lCropCoefficient.addDayToList(8, 0.36);
            lCropCoefficient.addDayToList(9, 0.37);
            lCropCoefficient.addDayToList(10,0.37);
            lCropCoefficient.addDayToList(11,0.38);
            lCropCoefficient.addDayToList(12,0.39);
            lCropCoefficient.addDayToList(13,0.40);
            lCropCoefficient.addDayToList(14,0.40);
            lCropCoefficient.addDayToList(15,0.41);
            lCropCoefficient.addDayToList(16,0.42);
            lCropCoefficient.addDayToList(17,0.43);
            lCropCoefficient.addDayToList(18,0.43);
            lCropCoefficient.addDayToList(19,0.44);
            lCropCoefficient.addDayToList(20,0.45);
            lCropCoefficient.addDayToList(21,0.45);
            lCropCoefficient.addDayToList(22,0.46);
            lCropCoefficient.addDayToList(23,0.47);
            lCropCoefficient.addDayToList(24,0.48);
            lCropCoefficient.addDayToList(25,0.48);
            lCropCoefficient.addDayToList(26,0.50);
            lCropCoefficient.addDayToList(27,0.51);
            lCropCoefficient.addDayToList(28,0.51);
            lCropCoefficient.addDayToList(29,0.52);
            lCropCoefficient.addDayToList(30,0.52);
            lCropCoefficient.addDayToList(31,0.53);
            lCropCoefficient.addDayToList(32,0.54);
            lCropCoefficient.addDayToList(33,0.54);
            lCropCoefficient.addDayToList(34,0.55);
            lCropCoefficient.addDayToList(35,0.56);
            lCropCoefficient.addDayToList(36,0.57);
            lCropCoefficient.addDayToList(37,0.57);
            lCropCoefficient.addDayToList(38,0.58);
            lCropCoefficient.addDayToList(39,0.59);
            lCropCoefficient.addDayToList(40,0.59);
            lCropCoefficient.addDayToList(41,0.60);
            lCropCoefficient.addDayToList(42,0.61);
            lCropCoefficient.addDayToList(43,0.62);
            lCropCoefficient.addDayToList(44,0.62);
            lCropCoefficient.addDayToList(45,0.63);
            lCropCoefficient.addDayToList(46,0.64);
            lCropCoefficient.addDayToList(47,0.65);
            lCropCoefficient.addDayToList(48,0.65);
            lCropCoefficient.addDayToList(49,0.66);
            lCropCoefficient.addDayToList(50,0.67);
            lCropCoefficient.addDayToList(51,0.68);
            lCropCoefficient.addDayToList(52,0.68);
            lCropCoefficient.addDayToList(53,0.69);

            //corregir de aqui abajo en mas con nueva tabla
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
            lCropCoefficient.addDayToList(0,0.35);
            lCropCoefficient.addDayToList(1,0.35);
            lCropCoefficient.addDayToList(2,0.35);
            lCropCoefficient.addDayToList(3,0.35);
            lCropCoefficient.addDayToList(4,0.35);
            lCropCoefficient.addDayToList(5,0.35);
            lCropCoefficient.addDayToList(6,0.35);
            lCropCoefficient.addDayToList(7, 0.35);
            lCropCoefficient.addDayToList(8, 0.35);
            lCropCoefficient.addDayToList(9, 0.35);
            lCropCoefficient.addDayToList(10,0.35);
            lCropCoefficient.addDayToList(11,0.35);
            lCropCoefficient.addDayToList(12,0.35);
            lCropCoefficient.addDayToList(13,0.35);
            lCropCoefficient.addDayToList(14,0.35);
            lCropCoefficient.addDayToList(15,0.35);
            lCropCoefficient.addDayToList(16,0.35);
            lCropCoefficient.addDayToList(17,0.35);
            lCropCoefficient.addDayToList(18,0.35);
            lCropCoefficient.addDayToList(19,0.35);
            lCropCoefficient.addDayToList(20,0.37);
            lCropCoefficient.addDayToList(21,0.38);
            lCropCoefficient.addDayToList(22,0.40);
            lCropCoefficient.addDayToList(23,0.42);
            lCropCoefficient.addDayToList(24,0.43);
            lCropCoefficient.addDayToList(25,0.45);
            lCropCoefficient.addDayToList(26,0.47);
            lCropCoefficient.addDayToList(27,0.48);
            lCropCoefficient.addDayToList(28,0.50);
            lCropCoefficient.addDayToList(29,0.52);
            lCropCoefficient.addDayToList(30,0.53);
            lCropCoefficient.addDayToList(31,0.55);
            lCropCoefficient.addDayToList(32,0.57);
            lCropCoefficient.addDayToList(33,0.58);
            lCropCoefficient.addDayToList(34,0.60);
            lCropCoefficient.addDayToList(35,0.62);
            lCropCoefficient.addDayToList(36,0.63);
            lCropCoefficient.addDayToList(37,0.65);
            lCropCoefficient.addDayToList(38,0.67);
            lCropCoefficient.addDayToList(39,0.68);
            lCropCoefficient.addDayToList(40,0.70);
            lCropCoefficient.addDayToList(41,0.72);
            lCropCoefficient.addDayToList(42,0.73);
            lCropCoefficient.addDayToList(43,0.75);
            lCropCoefficient.addDayToList(44,0.77);
            lCropCoefficient.addDayToList(45,0.78);
            lCropCoefficient.addDayToList(46,0.80);
            lCropCoefficient.addDayToList(47,0.82);
            lCropCoefficient.addDayToList(48,0.83);
            lCropCoefficient.addDayToList(49,0.85);
            lCropCoefficient.addDayToList(50,0.87);
            lCropCoefficient.addDayToList(51,0.88);
            lCropCoefficient.addDayToList(52,0.90);
            lCropCoefficient.addDayToList(53,0.92);
            lCropCoefficient.addDayToList(54,0.93);
            lCropCoefficient.addDayToList(55,0.95);
            lCropCoefficient.addDayToList(56,0.97);
            lCropCoefficient.addDayToList(57,0.98);
            lCropCoefficient.addDayToList(58,1);
            lCropCoefficient.addDayToList(59,1.02);
            lCropCoefficient.addDayToList(60,1.03);
            lCropCoefficient.addDayToList(61,1.05);
            lCropCoefficient.addDayToList(62,1.07);
            lCropCoefficient.addDayToList(63,1.08);
            lCropCoefficient.addDayToList(64,1.10);
            lCropCoefficient.addDayToList(65,1.10);
            lCropCoefficient.addDayToList(66,1.10);
            lCropCoefficient.addDayToList(67,1.10);
            lCropCoefficient.addDayToList(68,1.10);
            lCropCoefficient.addDayToList(69,1.10);
            lCropCoefficient.addDayToList(70,1.10);
            lCropCoefficient.addDayToList(71,1.10);
            lCropCoefficient.addDayToList(72,1.10);
            lCropCoefficient.addDayToList(73,1.10);
            lCropCoefficient.addDayToList(74,1.10);
            lCropCoefficient.addDayToList(75,1.10);
            lCropCoefficient.addDayToList(76,1.10);
            lCropCoefficient.addDayToList(77,1.10);
            lCropCoefficient.addDayToList(78,1.10);
            lCropCoefficient.addDayToList(79,1.10);
            lCropCoefficient.addDayToList(80,1.10);
            lCropCoefficient.addDayToList(81,1.10);
            lCropCoefficient.addDayToList(82,1.10);
            lCropCoefficient.addDayToList(83,1.10);
            lCropCoefficient.addDayToList(84,1.10);
            lCropCoefficient.addDayToList(85, 1.10);
            lCropCoefficient.addDayToList(86, 1.10);
            lCropCoefficient.addDayToList(87, 1.10);
            lCropCoefficient.addDayToList(88, 1.10);
            lCropCoefficient.addDayToList(89, 1.10);
            lCropCoefficient.addDayToList(90, 1.10);
            lCropCoefficient.addDayToList(91, 1.10);
            lCropCoefficient.addDayToList(92, 1.10);
            lCropCoefficient.addDayToList(93, 1.10);
            lCropCoefficient.addDayToList(94, 1.10);
            lCropCoefficient.addDayToList(95, 1.10);
            lCropCoefficient.addDayToList(96, 1.10);
            lCropCoefficient.addDayToList(97, 1.10);
            lCropCoefficient.addDayToList(98, 1.10);
            lCropCoefficient.addDayToList(99, 1.10);
            lCropCoefficient.addDayToList(100, 1.10);
            lCropCoefficient.addDayToList(101,1.10);
            lCropCoefficient.addDayToList(102,1.10);
            lCropCoefficient.addDayToList(103,1.10);
            lCropCoefficient.addDayToList(104,1.10);
            lCropCoefficient.addDayToList(105,1.10);
            lCropCoefficient.addDayToList(106,1.08);
            lCropCoefficient.addDayToList(107,1.07);
            lCropCoefficient.addDayToList(108,	1.05);
            lCropCoefficient.addDayToList(109,	1.03);
            lCropCoefficient.addDayToList(110,	1.01);
            lCropCoefficient.addDayToList(111,	1.00);
            lCropCoefficient.addDayToList(112,	0.98);
            lCropCoefficient.addDayToList(113,	0.96);
            lCropCoefficient.addDayToList(114,	0.94);
            lCropCoefficient.addDayToList(115,	0.93);
            lCropCoefficient.addDayToList(116,	0.91);
            lCropCoefficient.addDayToList(117,	0.89);
            lCropCoefficient.addDayToList(118,	0.87);
            lCropCoefficient.addDayToList(119,	0.86);
            lCropCoefficient.addDayToList(120,	0.84);
            lCropCoefficient.addDayToList(121,	0.82);
            lCropCoefficient.addDayToList(122,	0.80);
            lCropCoefficient.addDayToList(123,	0.79);
            lCropCoefficient.addDayToList(124,	0.77);
            lCropCoefficient.addDayToList(125,	0.75);
            lCropCoefficient.addDayToList(126,	0.73);
            lCropCoefficient.addDayToList(127,	0.72);
            lCropCoefficient.addDayToList(128,	0.70);
            lCropCoefficient.addDayToList(129,	0.68);
            lCropCoefficient.addDayToList(130,	0.66);
            lCropCoefficient.addDayToList(131,	0.65);
            lCropCoefficient.addDayToList(132,	0.63);
            lCropCoefficient.addDayToList(133,	0.61);
            lCropCoefficient.addDayToList(134,	0.59);
            lCropCoefficient.addDayToList(135,	0.58);
            lCropCoefficient.addDayToList(136,	0.56);
            lCropCoefficient.addDayToList(137,	0.54);
            lCropCoefficient.addDayToList(138,	0.52);
            lCropCoefficient.addDayToList(139,	0.51);
            lCropCoefficient.addDayToList(140,	0.49);
            lCropCoefficient.addDayToList(141,	0.47);
            lCropCoefficient.addDayToList(142,	0.45);
            lCropCoefficient.addDayToList(143,	0.44);
            lCropCoefficient.addDayToList(144,	0.42);
            lCropCoefficient.addDayToList(145,	0.40);


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

