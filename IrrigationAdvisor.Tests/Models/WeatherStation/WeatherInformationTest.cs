using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using IrrigationAdvisor.Models.WeatherStation;

namespace IrrigationAdvisor.Tests.Models.WeatherStation
{
    [TestClass]
    public class WeatherInformationTest
    {
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
