﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IrrigationAdvisor.Models.Management;

namespace IrrigationAdvisor.Tests.Models.Management
{
    [TestClass]
    public class CropIrrigationWeatherRecordsTest
    {
        [TestMethod]
        public void cropIrrigationWeatherRecordsTest()
        {
            CropIrrigationWeather lCropIrrigationWeather = new CropIrrigationWeather();
            CropIrrigationWeatherRecords lCropIrrigationWeatherRecords = new CropIrrigationWeatherRecords();
            
            DailyRecord lDailyRecord01 = new DailyRecord();
            lDailyRecord01.DateHour = new DateTime(2014, 11, 1);
            lDailyRecord01.Rain.Input = 1.1;
            lDailyRecord01.GrowingDegree = 3;
            lDailyRecord01.EvapotranspirationCrop = new IrrigationAdvisor.Models.Water.WaterOutput(3, new DateTime(2014, 11, 3), 0, DateTime.Now);
            
            DailyRecord lDailyRecord02 = new DailyRecord();
            lDailyRecord02.DateHour = new DateTime(2014, 11, 2);
            lDailyRecord02.Rain.Input = 2.2;
            lDailyRecord02.EvapotranspirationCrop = new IrrigationAdvisor.Models.Water.WaterOutput(2, new DateTime(2014, 11, 3), 0, DateTime.Now);
            
            DailyRecord lDailyRecord03 = new DailyRecord();
            lDailyRecord03.DateHour = new DateTime(2014, 11, 3);
            lDailyRecord03.Rain.Input = 3.3;
            lDailyRecord03.EvapotranspirationCrop = new IrrigationAdvisor.Models.Water.WaterOutput(6,new DateTime(2014,11,3),0,DateTime.Now);
            DailyRecord lDailyRecord04 = new DailyRecord();
            lDailyRecord04.DateHour = new DateTime(2014, 11, 4);
            lDailyRecord04.Rain.Input = 4.4;
            lDailyRecord04.Observations = "prueba obs";
            
            DailyRecord lDailyRecord05 = new DailyRecord();
            lDailyRecord05.DateHour = new DateTime(2014, 11, 5);
            lDailyRecord05.Rain.Input = 5.5;
            lDailyRecord05.Rain.ExtraInput = 5.5;

            
            lCropIrrigationWeatherRecords.addDailyRecord(lDailyRecord01);
            lCropIrrigationWeatherRecords.addDailyRecord(lDailyRecord02);
            lCropIrrigationWeatherRecords.addDailyRecord(lDailyRecord03);
            lCropIrrigationWeatherRecords.addDailyRecord(lDailyRecord04);
            lCropIrrigationWeatherRecords.addDailyRecord(lDailyRecord05);

            Assert.AreEqual(lCropIrrigationWeatherRecords.getEffectiveRain(new DateTime(2014, 11, 1)), 1.1);
            Assert.AreEqual(lCropIrrigationWeatherRecords.getEffectiveRain(new DateTime(2014, 11, 5)), 11);
            
            Assert.AreEqual(lCropIrrigationWeatherRecords.getGrowingDegree(new DateTime(2014, 11, 1)), 3);
            Assert.AreEqual(lCropIrrigationWeatherRecords.getEvapotranspirationCrop(new DateTime(2014, 11, 3)), 6);
            Assert.AreEqual(lCropIrrigationWeatherRecords.getObservations(new DateTime(2014, 11, 4)), "prueba obs");
            Assert.AreEqual(lCropIrrigationWeatherRecords.getLastThreeDaysOfEvapotranspirationCrop(new DateTime(2014, 11, 3)), 11);
            
        }
    }
}
