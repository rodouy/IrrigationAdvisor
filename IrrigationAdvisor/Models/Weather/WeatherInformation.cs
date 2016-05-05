using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace IrrigationAdvisor.Models.Weather
{
    public class WeatherInformation
    {
        #region Consts
        #endregion

        #region Fields
        
        private bool isTemperature = false;
        private bool isTemperatureMax = false;
        private bool isTemperatureMin = false;
        private bool isTemperatureDewPoint = false;
        private bool isHumidity = false;
        private bool isHumidityMax = false;
        private bool isHumidityMin = false;
        private bool isBarometer = false;
        private bool isBarometerMax = false;
        private bool isBarometerMin = false;
        private bool isSolarRadiation = false;
        private bool isSolarRadiationDay = false;
        private bool isUVRadiation = false;
        //private bool isRain = false;
        private bool isRainDay = false;
        private bool isRainStorm = false;
        private bool isRainMonth = false;
        private bool isRainYear = false;
        private bool isEvapotranspiration = false;
        private bool isEvapotranspirationMonth = false;
        private bool isEvapotranspirationYear = false;


        private WebClient webClient;
        private String webAddress;
        private byte[] raw;
        private String webData;
        //private WebRequest webRequest;
        private String requestData;
        private String responseData;


        private WeatherData weatherData;

        #endregion

        #region Properties
        
        public String WebAddress
        {
            get { return webAddress; }
            set { webAddress = value; }
        }

        public String WebData
        {
            get { return webData; }
            set { webData = value; }
        }

        public String RequestData
        {
            get { return requestData; }
            set { requestData = value; }
        }

        public String ResponseData
        {
            get { return responseData; }
            set { responseData = value; }
        }

        public WeatherData WeatherData
        {
            get { return weatherData; }
            set { weatherData = value; }
        }

        #endregion

        #region Construction
        public WeatherInformation(String pWebAddress)
        {
            webClient = new WebClient();

            WebAddress = pWebAddress;

        }

        /*
        public WeatherInformation(String pWebAddress, String pRequestData)
        {
            webClient = new WebClient();

            WebAddress = pWebAddress;

            RequestData = pRequestData;

            webRequest = (HttpWebRequest)WebRequest.Create(WebAddress);

            ResponseData = String.Empty;

        }
        */

        #endregion

        #region Private Helpers

        private String ExtractInformationFromData(
            String pInformationName)
        {
            String lReturn = String.Empty;
            try
            {
                if (!String.IsNullOrEmpty(this.WebData))
                {
                    //Find all matches in file.
                    MatchCollection lMatchCollection =
                        Regex.Matches(this.WebData,
                        @"(<td.*?>.*?</td>)", 
                        RegexOptions.Singleline);
                    //Loop over each match
                    this.WeatherData = new WeatherData();
                    foreach (Match iMatch in lMatchCollection)
                    {
                        String lValue = iMatch.Groups[1].Value;

                        //Look Outside Temperature information
                        SearchTemperatures(lValue);

                        //Look Outside Humidity information
                        SearchHumidity(lValue);

                        //Look Barometer information
                        SearchBarometers(lValue);

                        //Look Radiation information
                        SearchRadiations(lValue);

                        //Look Rain information
                        SearchRains(lValue);

                        //Look ET information
                        SearchETs(lValue);

                    }
                    lReturn = this.WeatherData.ToString();
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }


            return lReturn;
        }

        private void SearchTemperatures(String pValue)
        {
            if (this.isTemperature && pValue.Length > 2 && pValue.Contains(" C"))
            {
                this.WeatherData.Temperature = ObtainTemperature(pValue);
                this.isTemperature = false;
            }
            else if (this.isTemperatureMax && pValue.Length > 2 && pValue.Contains(" C"))
            {
                this.WeatherData.TemperatureMax = ObtainTemperature(pValue);
                this.isTemperatureMax = false;
            }
            else if (this.isTemperatureMin && pValue.Length > 2 && pValue.Contains(" C"))
            {
                this.WeatherData.TemperatureMin = ObtainTemperature(pValue);
                this.isTemperatureMin = false;
            }
            else if (this.isTemperatureDewPoint && pValue.Length > 2 && pValue.Contains(" C"))
            {
                this.WeatherData.TemperatureDewPoint = ObtainTemperature(pValue);
                this.isTemperatureDewPoint = false;
            }
            if (pValue.Contains("Outside Temp"))
            {
                this.isTemperature = true;
                this.isTemperatureMax = true;
                this.isTemperatureMin = true;
            }
            if (pValue.Contains("Dew Point"))
            {
                this.isTemperatureDewPoint = true;
            }

        }

        private void SearchHumidity(String pValue)
        {
            if (this.isHumidity && pValue.Length > 2 && pValue.Contains("%"))
            {
                this.WeatherData.Humidity = ObtainHumidity(pValue);
                this.isHumidity = false;
            }
            else if (this.isHumidityMax && pValue.Length > 2 && pValue.Contains("%"))
            {
                this.WeatherData.HumidityMax = ObtainHumidity(pValue);
                this.isHumidityMax = false;
            }
            else if (this.isHumidityMin && pValue.Length > 2 && pValue.Contains("%"))
            {
                this.WeatherData.HumidityMin = ObtainHumidity(pValue);
                this.isHumidityMin = false;
            }
            if (pValue.Contains("Outside Humidity"))
            {
                this.isHumidity = true;
                this.isHumidityMax = true;
                this.isHumidityMin = true;
            }
        }

        private void SearchBarometers(String pValue)
        {
            if (this.isBarometer && pValue.Length > 2 && pValue.Contains("hPa"))
            {
                this.WeatherData.Barometer = ObtainBarometer(pValue);
                this.isBarometer = false;
            }
            else if (this.isBarometerMax && pValue.Length > 2 && pValue.Contains("hPa"))
            {
                this.WeatherData.BarometerMax = ObtainBarometer(pValue);
                this.isBarometerMax = false;
            }
            else if (this.isBarometerMin && pValue.Length > 2 && pValue.Contains("hPa"))
            {
                this.WeatherData.BarometerMin = ObtainBarometer(pValue);
                this.isBarometerMin = false;
            }
            if (pValue.Contains("Barometer"))
            {
                this.isBarometer = true;
                this.isBarometerMax = true;
                this.isBarometerMin = true;
            }
        }

        private void SearchRadiations(String pValue)
        {
            if (this.isSolarRadiation && pValue.Length > 2 && pValue.Contains(" W/m"))
            {
                this.WeatherData.SolarRadiation = ObtainSolarRadiation(pValue);
                this.isSolarRadiation = false;
            }
            else if (this.isSolarRadiationDay && pValue.Length > 2 && pValue.Contains(" W/m"))
            {
                this.WeatherData.SolarRadiation = ObtainSolarRadiation(pValue);
                this.isSolarRadiationDay = false;
            }
            else if (this.isUVRadiation && pValue.Length > 2 && pValue.Contains(" Index"))
            {
                this.WeatherData.UVRadiation = ObtainUVRadiation(pValue);
                this.isUVRadiation = false;
            }
            if (pValue.Contains("Solar Radiation"))
            {
                this.isSolarRadiation = true;
                this.isSolarRadiationDay = true;
            }
            if (pValue.Contains("UV Radiation"))
            {
                this.isUVRadiation = true;
            }
        }

        private void SearchRains(String pValue)
        {
            if (this.isRainDay && pValue.Length > 2 && pValue.Contains("mm<"))
            {
                this.WeatherData.RainDay = ObtainRain(pValue);
                this.isRainDay = false;
            }
            else if (this.isRainStorm && pValue.Length > 2 && pValue.Contains("mm<"))
            {
                this.WeatherData.RainStorm = ObtainRain(pValue);
                this.isRainStorm = false;
            }
            else if (this.isRainMonth && pValue.Length > 2 && pValue.Contains("mm<"))
            {
                this.WeatherData.RainMonth = ObtainRain(pValue);
                this.isRainMonth = false;
            }
            else if (this.isRainYear && pValue.Length > 2 && pValue.Contains("mm<"))
            {
                this.WeatherData.RainYear = ObtainRain(pValue);
                this.isRainYear = false;
            }
            if (pValue.Contains(">Rain<"))
            {
                this.isRainDay = true;
                this.isRainStorm = true;
                this.isRainMonth = true;
                this.isRainYear = true;
            }
        }

        private void SearchETs(String pValue)
        {
            if (this.isEvapotranspiration && pValue.Length > 2 && pValue.Contains("mm<"))
            {
                this.WeatherData.Evapotranspiration = ObtainET(pValue);
                this.isEvapotranspiration = false;
            }
            else if (this.isEvapotranspirationMonth && pValue.Length > 2 && pValue.Contains("mm<"))
            {
                this.WeatherData.EvapotranspirationMonth = ObtainET(pValue);
                this.isEvapotranspirationMonth = false;
            }
            else if (this.isEvapotranspirationYear && pValue.Length > 2 && pValue.Contains("mm<"))
            {
                this.WeatherData.EvapotranspirationYear = ObtainET(pValue);
                this.isEvapotranspirationYear = false;
            }
            if (pValue.Contains(">ET<"))
            {
                this.isEvapotranspiration = true;
                this.isEvapotranspirationMonth = true;
                this.isEvapotranspirationYear = true;
            }
        }

        /// <summary>
        /// Temperature Value format NN.N C
        /// </summary>
        /// <param name="pTemperatureValue"></param>
        /// <returns></returns>
        private double ObtainTemperature(string pTemperatureValue)
        {
            double lTemperatureResult = 0;
            string lTemperature = "";
            lTemperature = pTemperatureValue;
            lTemperature = lTemperature.Remove(0, lTemperature.LastIndexOf("\">") + 2);
            int lIndexOf = lTemperature.LastIndexOf(" C");
            lTemperature = lTemperature.Remove(lIndexOf, lTemperature.Length - lIndexOf).Trim();
            lTemperatureResult = Double.Parse(lTemperature);
            return lTemperatureResult;
        }

        private double ObtainHumidity(string pHumidityValue)
        {
            double lHumidityResult = 0;
            string lHumidity = "";
            lHumidity = pHumidityValue;
            lHumidity = lHumidity.Remove(0, lHumidity.LastIndexOf("\">") + 2);
            int lIndexOf = lHumidity.LastIndexOf("%");
            lHumidity = lHumidity.Remove(lIndexOf, lHumidity.Length - lIndexOf).Trim();
            lHumidityResult = Double.Parse(lHumidity) / 100;
            return lHumidityResult;
        }

        private double ObtainBarometer(string pBarometerValue)
        {
            double lBarometerResult = 0;
            string lBarometer = "";
            lBarometer = pBarometerValue;
            lBarometer = lBarometer.Remove(0, lBarometer.LastIndexOf("\">") + 2);
            int lIndexOf = lBarometer.LastIndexOf("hPa");
            lBarometer = lBarometer.Remove(lIndexOf, lBarometer.Length - lIndexOf).Trim();
            lBarometerResult = Double.Parse(lBarometer);
            return lBarometerResult;
        }

        private double ObtainSolarRadiation(string pSolarRadiationValue)
        {
            double lSolarRadiationResult = 0;
            string lSolarRadiation = "";
            lSolarRadiation = pSolarRadiationValue;
            lSolarRadiation = lSolarRadiation.Remove(0, lSolarRadiation.IndexOf("\">") + 2);
            int lIndexOf = lSolarRadiation.LastIndexOf(" W/m");
            lSolarRadiation = lSolarRadiation.Remove(lIndexOf, lSolarRadiation.Length - lIndexOf).Trim();
            lSolarRadiationResult = Double.Parse(lSolarRadiation);
            return lSolarRadiationResult;
        }

        private double ObtainUVRadiation(string pUVRadiationValue)
        {
            double lUVRadiationResult = 0;
            string lUVRadiation = "";
            lUVRadiation = pUVRadiationValue;
            lUVRadiation = lUVRadiation.Remove(0, lUVRadiation.LastIndexOf("\">") + 2);
            int lIndexOf = lUVRadiation.LastIndexOf(" Index");
            lUVRadiation = lUVRadiation.Remove(lIndexOf, lUVRadiation.Length - lIndexOf).Trim();
            lUVRadiationResult = Double.Parse(lUVRadiation);
            return lUVRadiationResult;
        }

        private double ObtainRain(string pRainValue)
        {
            double lRainResult = 0;
            string lRain = "";
            lRain = pRainValue;
            lRain = lRain.Remove(0, lRain.LastIndexOf("\">") + 2);
            int lIndexOf = lRain.LastIndexOf("mm<");
            lRain = lRain.Remove(lIndexOf, lRain.Length - lIndexOf).Trim();
            lRainResult = Double.Parse(lRain);
            return lRainResult;
        }

        private double ObtainET(string pETValue)
        {
            double lETResult = 0;
            string lET = "";
            lET = pETValue;
            lET = lET.Remove(0, lET.LastIndexOf("\">") + 2);
            int lIndexOf = lET.LastIndexOf("mm<");
            lET = lET.Remove(lIndexOf, lET.Length - lIndexOf).Trim();
            lETResult = Double.Parse(lET);
            return lETResult;
        }

        #endregion

        #region Public Methods
        public void ExtractInfomationDownloadData()
        {
            raw = webClient.DownloadData(WebAddress);

            WebData = Encoding.UTF8.GetString(raw);

        }
        public void ExtractInfomationDownloadString()
        {
            WebData = webClient.DownloadString(WebAddress);

            String lData = this.ExtractInformationFromData(WebData);
        }

        public void ExtractInformationWithSerialization()
        {
            WebData = webClient.DownloadString(WebAddress);

            String lData = this.ExtractInformationFromData(WebData);

        }

        /*
        public void ExtractInfomationWebRequest()
        {
            using (StreamWriter lStreamWriter = new StreamWriter(webRequest.GetRequestStream(), Encoding.UTF8))
            {
                //lStreamWriter.Write(RequestData);
            }

            HttpWebResponse lHttpWebResponse = (HttpWebResponse)webRequest.GetResponse();
            using (StreamReader lResponseReader = new StreamReader(lHttpWebResponse.GetResponseStream()))
            {
                ResponseData = lResponseReader.ReadToEnd();
            }
        }
         * */




        #endregion

        #region Overrides
        #endregion

    }
}