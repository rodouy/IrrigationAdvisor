using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using IrrigationAdvisor.Models.WeatherStation;

using System.Runtime.Serialization.Formatters.Soap;
using System.IO;


namespace IrrigationAdvisor.Tests.Models.WeatherStation
{
    [TestClass]
    public class WeatherInformationTest
    {
        //serialization
        const string FileName = @"..\..\WeatherData.xml";

        String lWebAddress = String.Empty;

        String lWebRequestData = String.Empty;

        String lWebData = String.Empty;

        [TestInitialize]
        public void TestWeatherInformationInitialize()
        {
            lWebAddress = "http://www.weatherlink.com/user/oasmet1/index.php?view=summary&headers=0";

            lWebRequestData = "";
        }

        [TestMethod]
        public void TestExtractInformationDownloadData()
        {
            WeatherInformation lWeatherInformation = new WeatherInformation(lWebAddress);
            lWeatherInformation.ExtractInfomationDownloadData();
            lWebData = lWeatherInformation.WebData;
        }

        [TestMethod]
        public void TestExtractInformationDownloadString()
        {
            WeatherInformation lWeatherInformation = new WeatherInformation(lWebAddress);
            lWeatherInformation.ExtractInfomationDownloadString();
            lWebData = lWeatherInformation.WebData;
        }

        [TestMethod]
        public void TestExtractInformationWithSerialization()
        {
            WeatherInformation lWeatherInformation = new WeatherInformation(lWebAddress);
            lWeatherInformation.ExtractInformationWithSerialization();
            if (File.Exists(FileName))
            {
                Stream TestFileStream = File.OpenRead(FileName);
                SoapFormatter deserializer = new SoapFormatter();
                lWeatherInformation.WeatherData = (WeatherData)deserializer.Deserialize(TestFileStream);
                TestFileStream.Close();
            }
            //lWeatherInformation.WeatherData.PropertyChanged += this.TemperaturePropertyChanged;

            lWeatherInformation.ExtractInfomationDownloadString();
            lWebData = lWeatherInformation.WebData;

            Stream TestFileStreamPersist = File.Create(FileName);
            SoapFormatter serializer = new SoapFormatter();
            serializer.Serialize(TestFileStreamPersist, lWeatherInformation.WeatherData);
            TestFileStreamPersist.Close();
        }

        private void TemperaturePropertyChanged(object sender,
            System.ComponentModel.PropertyChangedEventArgs e)
        {
 
        }

        /*
        [TestMethod]
        public void TestExtractInformationWebRequest()
        {
            WeatherInformation lWeatherInformation = new WeatherInformation(lWebAddress, lWebRequestData);
            lWeatherInformation.ExtractInfomationWebRequest();
            lWebData = lWeatherInformation.ResponseData;

        }
        */

    }
}
