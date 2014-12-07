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
        [TestMethod]
        public void santaLuciaTest()
        {

            lRegion = new Region("Templada", lLocation);
            lLocation = createLocation(new Position(34, 55), new Country("Uruguay", null), lRegion, new City("Santa Lucia", null));

            lSpecieSoja = createSpecie(1, "Soja", lRegion, sojaBaseTemp);
            lSpecieMaiz = createSpecie(1, "Maiz", lRegion, maizBaseTemp);

            crearSuelosSantaLucia();
            
            irrirgSys = new IrrigationSystem();
            addPhenologicalStageListToSystem();

            crearCultivosSantaLucia();

            crearUnidadesDeRiegoSantaLucia();
            
            agregarDatosDelTiempo();

            agregarDatosDeLluvia();


            irrirgSys.addCropIrrigWeatherToList(cropIrrigWeatherPivot2);
            irrirgSys.addCropIrrigWeatherToList(cropIrrigWeatherPivot3_4);
            irrirgSys.addCropIrrigWeatherToList(cropIrrigWeatherPivot5);

            //DAILY RECORDS
            String textLogPivot2 = Environment.NewLine + Environment.NewLine;
            textLogPivot2 += " \tETCAc " +
                " \t\tETCFromLWI " +
                " \t G.Dia: " +
                " \t\t G.D. Mod: " +
                " \t\tB.Hid: " + 
                " \tTotRain: " +
                " \tTotIrrig: " +
                " \tLastWaterInput: " +
                " \tRaiz " + 
                " \tFenol " + 
                "\tIrrigCalulated: "  + Environment.NewLine;
            String textLogPivot3_4 = textLogPivot2;
            String textLogPivot5 = textLogPivot2;
            
            CropIrrigationWeatherRecords recP2 = irrirgSys.CropIrrigationWeatherRecordsList.Find(x => x.CropIrrigationWeather.Equals(cropIrrigWeatherPivot2));
            CropIrrigationWeatherRecords recP3_4 = irrirgSys.CropIrrigationWeatherRecordsList.Find(x => x.CropIrrigationWeather.Equals(cropIrrigWeatherPivot3_4));
            CropIrrigationWeatherRecords recP5 = irrirgSys.CropIrrigationWeatherRecordsList.Find(x => x.CropIrrigationWeather.Equals(cropIrrigWeatherPivot5));
            
 
            textLogPivot2 = agregarDatosPivot2_SantaLucia(textLogPivot2, recP2);
            textLogPivot3_4 = agregarDatosPivot3_4_SantaLucia(textLogPivot3_4, recP3_4);
            textLogPivot5 = agregarDatosPivot5_SantaLucia(textLogPivot5, recP5);


            textLogPivot2 += Environment.NewLine + Environment.NewLine + irrirgSys.printDailyRecordsList(recP2);
            textLogPivot3_4 += Environment.NewLine + Environment.NewLine + irrirgSys.printDailyRecordsList(recP3_4);
            textLogPivot5 += Environment.NewLine + Environment.NewLine + irrirgSys.printDailyRecordsList(recP5);
            
            //this.printSystemData(textLogPivot2);
            //this.printSystemData(textLogPivot3_4);
            this.printSystemData(textLogPivot5);

        }

        private string agregarDatosPivot3_4_SantaLucia(string textLogPivot3_4, CropIrrigationWeatherRecords recP3_4)
        {
            string textoRetorno = textLogPivot3_4;
            double irrigationCalculated = 0;
            textoRetorno += "Dia 0" + printState(recP3_4, 0);
            //Riego inicial
            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 15), 5);
            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 19), 15);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 15), "Dia 1");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot3_4);
            textoRetorno += "Dia 1" + printState(recP3_4, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 16), "Dia 21");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot3_4);
            textoRetorno += "Dia 2" + printState(recP3_4, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 17), "Dia 3");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot3_4);
            textoRetorno += "Dia 3" + printState(recP3_4, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 18), "Dia 4");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot3_4);
            textoRetorno += "Dia 4" + printState(recP3_4, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 19), "Dia 5");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot3_4);
            textoRetorno += "Dia 5" + printState(recP3_4, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 20), "Dia 6");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot3_4);
            textoRetorno += "Dia 6" + printState(recP3_4, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 21), "Dia 7");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot3_4);
            textoRetorno += "Dia 7" + printState(recP3_4, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 22), "Dia 8");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot3_4);
            textoRetorno += "Dia 8" + printState(recP3_4, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 23), "Dia 9");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot3_4);
            textoRetorno += "Dia 9" + printState(recP3_4, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 24), "Dia 10");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot3_4);
            textoRetorno += "Dia 10" + printState(recP3_4, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 25), "Dia 11");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot3_4);
            textoRetorno += "Dia 11" + printState(recP3_4, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 26), "Dia 12");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot3_4);
            textoRetorno += "Dia 12" + printState(recP3_4, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 27), "Dia 13");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot3_4);
            textoRetorno += "Dia 13" + printState(recP3_4, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 28), "Dia 14");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 14" + printState(recP3_4, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 29), "Dia 15");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 15" + printState(recP3_4, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 30), "Dia 16");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 16" + printState(recP3_4, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 1), "Dia 17");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 17" + printState(recP3_4, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 2), "Dia 18");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 18" + printState(recP3_4, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot3_4, new DateTime(2014, 12, 3), "Dia 19");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 19" + printState(recP3_4, irrigationCalculated);

            return textoRetorno;
        }

        private string agregarDatosPivot2_SantaLucia(string pTextLogPivot2, CropIrrigationWeatherRecords recP2)
        {
            string textoRetorno = pTextLogPivot2;
            double irrigationCalculated = 0;
            textoRetorno += "Dia 0" + printState(recP2, 0);
            //Riego inicial
            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPivot2, new DateTime(2014, 10, 22), 22);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 22), "Dia 1");
            textoRetorno += "Dia 1" + printState(recP2, 0);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 23), "Dia 2");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 2" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 24), "Dia 3");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 3" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 25), "Dia 4");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 4" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 26), "Dia 5");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 5" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 27), "Dia 6");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 6" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 28), "Dia 7");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 7" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 29), "Dia 8");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 8" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 30), "Dia 9");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 9" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 10, 31), "Dia 10");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 10" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 1), "Dia 11");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 11" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 2), "Dia 12");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 12" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 3), "Dia 13");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 13" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 4), "Dia 14");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 14" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 5), "Dia 15");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 15" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 6), "Dia 16");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 16" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 7), "Dia 17");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 17" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 8), "Dia 18");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 18" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 9), "Dia 19");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 19" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 10), "Dia 20");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 20" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 11), "Dia 21");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 21" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 12), "Dia 22");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 22" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 13), "Dia 23");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 23" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 14), "Dia 24");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 24" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 15), "Dia 25");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 25" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 16), "Dia 26");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 26" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 17), "Dia 27");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 27" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 18), "Dia 28");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 28" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 19), "Dia 29");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 29" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 20), "Dia 30");
            irrirgSys.adjustmentPhenology(this.cropIrrigWeatherPivot2, new Stage(1, "v2", "Sin hojas"), new DateTime(2014, 11, 20));
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 30" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 21), "Dia 31");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 31" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 22), "Dia 32");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 32" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 23), "Dia 33");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 33" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 24), "Dia 34");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 34" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 25), "Dia 35");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 35" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 26), "Dia 36");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 36" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 27), "Dia 37");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 37" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 28), "Dia 38");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 38" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 29), "Dia 39");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 39" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 11, 30), "Dia 40");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 40" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 1), "Dia 41");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 41" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 2), "Dia 42");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 42" + printState(recP2, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot2, new DateTime(2014, 12, 3), "Dia 43");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot2);
            textoRetorno += "Dia 43" + printState(recP2, irrigationCalculated);

            return textoRetorno;
        }

        private string agregarDatosPivot5_SantaLucia(string pTextLogPivot5, CropIrrigationWeatherRecords recP5)
        {
            string textoRetorno = pTextLogPivot5;
            double irrigationCalculated = 0;
            textoRetorno += "Dia 0" + printState(recP5, 0);
            //Riego inicial
            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 10, 21), 7);//?????????

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 19), "Dia 1");
            textoRetorno += "Dia 1" + printState(recP5, 0);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 20), "Dia 2");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 2" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 21), "Dia 3");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 3" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 22), "Dia 4");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 4" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 23), "Dia 5");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 5" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 24), "Dia 6");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 6" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 25), "Dia 7");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 7" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 26), "Dia 8");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 8" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 27), "Dia 9");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 9" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 28), "Dia 10");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 10" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 29), "Dia 11");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 11" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 30), "Dia 12");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 12" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 10, 31), "Dia 13");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 13" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 1), "Dia 14");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 14" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 2), "Dia 15");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 15" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 3), "Dia 16");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 16" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 4), "Dia 17");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 17" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 5), "Dia 18");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 18" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 6), "Dia 19");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 19" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 7), "Dia 20");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 20" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 8), "Dia 21");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 21" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 9), "Dia 22");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 22" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 10), "Dia 23");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 23" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 11), "Dia 24");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 24" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 12), "Dia 25");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 25" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 13), "Dia 26");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 26" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 14), "Dia 27");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 27" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 15), "Dia 28");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 28" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 16), "Dia 29");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 29" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 17), "Dia 30");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 30" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 18), "Dia 31");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 31" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 19), "Dia 32");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 32" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 20), "Dia 33");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 33" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 21), "Dia 34");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 34" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 22), "Dia 35");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 35" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 23), "Dia 36");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 36" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 24), "Dia 37");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 37" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 25), "Dia 38");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 38" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 26), "Dia 39");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 39" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 27), "Dia 40");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 40" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 28), "Dia 41");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 41" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 29), "Dia 42");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 42" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 11, 30), "Dia 43");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 43" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 1), "Dia 44");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 44" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 2), "Dia 45");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 45" + printState(recP5, irrigationCalculated);

            irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 3), "Dia 46");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            textoRetorno += "Dia 46" + printState(recP5, irrigationCalculated);

            return textoRetorno;
        }

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


            lCropCoefficientSoja = createMaizCropCoefficientWithList(lSpecieMaiz, lRegion);
            lCropCoefficientMaiz = createSojaCropCoefficientWithList(lSpecieSoja, lRegion);

            initialPhenologicalState = new PhenologicalStage(1, lSpecieMaiz, new Stage(1, "v0", "Sin hojas"), 0, 60, 5);
            
            cropMaizPivot2 = createCrop(1, "Maiz SantaLucia Pivot 2", lSpecieMaiz, lLocation, lCropCoefficientSoja, cropDensityMaiz,
                initialPhenologicalState, new DateTime(2014, 10, 21), DateTime.Now, soil_2, lMaizMaxEvaporTransptoIrrigate);

            cropSojaPivot3_4 = createCrop(1, "Soja SantaLucia Pivot 3 4", lSpecieSoja, lLocation, lCropCoefficientSoja, cropDensitySoja,
                            initialPhenologicalState, new DateTime(2014, 11, 14), DateTime.Now, soil_3_4, lSojaMaxEvaporTransptoIrrigate);

            cropSojaPivot5 = createCrop(1, "Maiz SantaLucia Pivot 5", lSpecieMaiz, lLocation, lCropCoefficientSoja, cropDensityMaiz,
                                        initialPhenologicalState, new DateTime(2014, 10, 18), DateTime.Now, soil_5, lMaizMaxEvaporTransptoIrrigate);


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

            irrirgSys.addRainDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 22), 27);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 29), 50);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot3_4, new DateTime(2014, 11, 30), 51);

            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 10, 29), 66);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 10, 31), 2.5);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 11, 1), 2.5);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 11, 2), 10);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 11, 3), 35);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 11, 22), 27);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 11, 29), 50);
            irrirgSys.addRainDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 11, 30), 51);

            
        }

        private void agregarDatosDelTiempo()
        {
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
            
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 2), 99, 0, 17, 17, 5);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2014, 12, 3), 99, 0, 17, 17, 5);

        }

        private string printState(CropIrrigationWeatherRecords rec, double pIrrigation)
        {
            string ret = "";
            string etcAc = rec.TotalEvapotranspirationCrop + "        ";
            string etcflwi = rec.TotalEvapotranspirationCropFromLastWaterInput + "        ";
            string growDegre = rec.GrowingDegreeDays + "        ";
            string modGrowDegre = rec.ModifiedGrowingDegreeDays + "        ";
            string totRain = rec.TotalEffectiveRain + "        ";
            string bHid = rec.HydricBalance.ToString() + "        ";

            ret = " \t " + etcAc.Substring(0, 7) +
                " \t " + etcflwi.Substring(0,7) +
                " \t " + growDegre.Substring(0, 7) +
                " \t\t " + modGrowDegre.Substring(0, 7) +
                " \t\t " + bHid.Substring(0, 7) +
                " \t " + totRain.Substring(0, 7) +
                " \t " + rec.TotalIrrigation +
                " \t\t " + rec.LastWaterInput.ToString() +
                " \t " + rec.getRootDepth() +
                " \tf " + rec.CropIrrigationWeather.Crop.PhenologicalStage.Stage.Name +
                " \t " + pIrrigation.ToString() + Environment.NewLine;

           

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

            irrirgSys.addIrrigationDataToList(cropIrrigWeatherPrueba, new DateTime(2014, 11, 5), 22);
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
        private void printSystemData(String pText)
        {
            TextFileLogger lTextFileLogger = new TextFileLogger();
            String lFile = "IrrigationSystemTest";
            String lMethod = "createACropIrrigationWeather";
            String lMessage = pText;
            String lTime = System.DateTime.Now.ToString();
            lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);
        }

        public void createTestingUnityPruebaInicial()
        {
            lRegion = new Region("Templada", lLocation);
            lLocation = createLocation(new Position(34, 55),new Country("Uruguay", null ), lRegion, new City("Minas",null ));

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
            
            crop = createCrop(1,"Soja en Minas", lSpecieSoja,lLocation, lCropCoefficientSoja, cropDensity,
                initialPhenologicalState, lSowingDate, DateTime.Now, lSoil, lSojaMaxEvaporTransptoIrrigate);
                
            lBomb = new Bomb("Bomba1", 1234, DateTime.Now, DateTime.Now, lLocation);
            irrigationUnit = creteIrrigationUnit(1, "Unidad de Riego de prueba", "Pivot", 
                999, new List<Utilities.Pair<DateTime, double>>(), 300, new List<Crop.Crop>(), lBomb, lLocation);
               
            weatherStation = new WeatherStation.WeatherStation(1,"WeatherStation1","Model?",DateTime.Now,DateTime.Now,DateTime.Now, 1, lLocation,true);

            cropIrrigWeatherPrueba = new CropIrrigationWeather(irrigationUnit, crop, weatherStation, null);

            
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
            lCropCoefficient.addDayToList(7,0.35);
            lCropCoefficient.addDayToList(9,0.35);
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

