using System;
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
            CropIrrigationWeatherRecord lCropIrrigationWeatherRecords = new CropIrrigationWeatherRecord();
            
            DailyRecord lDailyRecord01 = new DailyRecord();
            lDailyRecord01.DateHour = new DateTime(2014, 11, 1);
            lDailyRecord01.Rain.Input = 1.1;
            lDailyRecord01.GrowingDegree = 3;
            lDailyRecord01.EvapotranspirationCrop = new IrrigationAdvisor.Models.Water.WaterOutput(3, new DateTime(2014, 11, 3), 0, DateTime.Now);
            
            DailyRecord lDailyRecord02 = new DailyRecord();
            lDailyRecord02.DateHour = new DateTime(2014, 11, 2);
            lDailyRecord02.Rain.Input = 2.2;
            lDailyRecord02.GrowingDegree = 3;
            lDailyRecord02.EvapotranspirationCrop.Input = 2;
            
            DailyRecord lDailyRecord03 = new DailyRecord();
            lDailyRecord03.DateHour = new DateTime(2014, 11, 3);
            lDailyRecord03.Rain.Input = 3.3;
            lDailyRecord03.GrowingDegree = 4;
            lDailyRecord03.EvapotranspirationCrop.Input = 6;
            DailyRecord lDailyRecord04 = new DailyRecord();
            lDailyRecord04.DateHour = new DateTime(2014, 11, 4);
            lDailyRecord04.Rain.Input = 4.4;
            lDailyRecord04.GrowingDegree = 4;
            lDailyRecord04.ModifiedGrowingDegree = -2;
            lDailyRecord04.Observations = "prueba obs";
            
            DailyRecord lDailyRecord05 = new DailyRecord();
            lDailyRecord05.DateHour = new DateTime(2014, 11, 5);
            lDailyRecord05.Rain.Input = 5.5;
            lDailyRecord05.GrowingDegree = 3;
            lDailyRecord05.Irrigation.Input = 10;
            lDailyRecord05.Rain.ExtraInput = 5.5;
            lDailyRecord05.ModifiedGrowingDegree = 5;

            /////Se privatizo el metodo
            //lCropIrrigationWeatherRecords.AddDailyRecord(lDailyRecord01);
            //lCropIrrigationWeatherRecords.AddDailyRecord(lDailyRecord02);
            //lCropIrrigationWeatherRecords.AddDailyRecord(lDailyRecord03);
            //lCropIrrigationWeatherRecords.AddDailyRecord(lDailyRecord04);
            //lCropIrrigationWeatherRecords.AddDailyRecord(lDailyRecord05);

            Assert.AreEqual(lCropIrrigationWeatherRecords.GetEffectiveRainByDate(new DateTime(2014, 11, 1)), 1.1);
            Assert.AreEqual(lCropIrrigationWeatherRecords.GetEffectiveRainByDate(new DateTime(2014, 11, 5)), 11);
            
            Assert.AreEqual(lCropIrrigationWeatherRecords.getGrowingDegree(new DateTime(2014, 11, 1)), 3);
            Assert.AreEqual(lCropIrrigationWeatherRecords.getEvapotranspirationCrop(new DateTime(2014, 11, 3)), 6);
            Assert.AreEqual(lCropIrrigationWeatherRecords.getObservations(new DateTime(2014, 11, 4)), "prueba obs");
            Assert.AreEqual(lCropIrrigationWeatherRecords.GetLastThreeDaysOfEvapotranspirationCrop(new DateTime(2014, 11, 3)), 11);


            Assert.AreEqual(lCropIrrigationWeatherRecords.GrowingDegreeDaysAcumulated, 17);
            Assert.AreEqual(lCropIrrigationWeatherRecords.GrowingDegreeDaysModified, 3);
            Assert.AreEqual(lCropIrrigationWeather.TotalEvapotranspirationCrop, 11);
            Assert.AreEqual(lCropIrrigationWeather.TotalEffectiveRain, 22);
            Assert.AreEqual(lCropIrrigationWeather.TotalIrrigation, 10);
            Assert.AreEqual(lCropIrrigationWeatherRecords.LastWaterInputDate, new DateTime(2014,11,5));
            
        }
    }
}
