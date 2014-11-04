using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Management;

namespace IrrigationAdvisor.Models.IrrigationSystem
{
    /// <summary>
    /// Create: 2014-11-01
    /// Author: monicarle
    /// Description: 
    ///     Manage all the information of the system
    ///     
    /// References:
    ///     almost all
    ///     
    /// Dependencies:
    ///     
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - cropIrrigationWeatherList List<CropIrrigationWeather>
    /// 
    /// Methods:
    ///     - IrrigationSystem()      -- constructor
    ///     
    /// </summary>
    public class IrrigationSystem
    {
        #region Index
        //Crop
        //Irrigation
        //Language
        //Location
        //Management
        //Security 
        //Utitilities
        //Water
        //WeatherStation

        #endregion

        #region Consts
        #endregion

        #region Fields

        //Crop
        //Irrigation
        //Language
        //Location

        //Management
        private List<CropIrrigationWeather> cropIrrigationWeatherList;
        
        //Security 
        //Utitilities

        //Water
        private List<Water.WaterInput> rainList;
        private List<Water.WaterInput> irrigationList;
        private List<Water.WaterOutput> evapotranspirationList;

        
        //WeatherStation
        private List<WeatherStation.WeatherData> weatherDataList;

        #endregion

        #region Properties

        //Crop
        //Irrigation
        //Language
        //Location
        //Management
        public List<CropIrrigationWeather> CropIrrigationWeatherList
        {
            get { return cropIrrigationWeatherList; }
            set { cropIrrigationWeatherList = value; }
        }

        //Security 
        //Utitilities

        //Water
        public List<Water.WaterInput> RainList
        {
            get { return rainList; }
            set { rainList = value; }
        }

        public List<Water.WaterInput> IrrigationList
        {
            get { return irrigationList; }
            set { irrigationList = value; }
        }

        public List<Water.WaterOutput> EvapotranspirationList
        {
            get { return evapotranspirationList; }
            set { evapotranspirationList = value; }
        }

        //WeatherStation
        public List<WeatherStation.WeatherData> WeatherDataList
        {
            get { return weatherDataList; }
            set { weatherDataList = value; }
        }

        
        #endregion

        #region Construction

        public IrrigationSystem()
        {

            


            //Crop
            this.cropIrrigationWeatherList = new List<CropIrrigationWeather>();
            
            //Irrigation

            //Language

            //Location

            //Management

            //Security 

            //Utitilities

            //Water
            this.EvapotranspirationList = new List<Water.WaterOutput>();
            this.IrrigationList = new List<Water.WaterInput>();
            this.RainList = new List<Water.WaterInput>();

            //WeatherStation
            this.WeatherDataList = new List<WeatherStation.WeatherData>();

        }

        #endregion


        #region Private Helpers
        private WeatherStation.WeatherData getWeatherData(WeatherStation.WeatherStation pWeatherStation, DateTime pDateTime) 
        {
            WeatherStation.WeatherData lReturn = null;
            foreach(WeatherStation.WeatherData lWeatherData in this.WeatherDataList)
            {
                if (lWeatherData.WeatherStation.Equals(pWeatherStation) && pDateTime.Date.Equals(pDateTime.Date))
                {
                    lReturn = lWeatherData;
                    return lReturn;
                }
            }
            return lReturn;

        }
        #endregion

        #region Public Methods

        //Crop
        //Irrigation
        //Language
        //Location
        //Management

        public bool addDailyRecord(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime, String pObservations)
        {
            bool lReturn = false;
            WeatherStation.WeatherStation lWeatherStation = null;
            WeatherStation.WeatherData lMainWeatherData = null;
            WeatherStation.WeatherData lAlternativeWeatherData = null;
            double lAverageTemp = 0;
            double lBaseTemperature = 0;
            double lGrowingDegree = 0;
            Water.WaterOutput lEvapotranspirationCrop = null;
            Water.WaterInput lRain = null;
            Water.WaterInput lIrrigation = null;


            if (this.CropIrrigationWeatherList.Contains(pCropIrrigationWeather) && pDateTime != null)
            {
                lWeatherStation = pCropIrrigationWeather.MainWeatherStation;
                lMainWeatherData = getWeatherData(lWeatherStation,pDateTime);
                lAverageTemp = lMainWeatherData.getAverageTemperature(pDateTime);
                if (lMainWeatherData == null)
                {
                    lWeatherStation = pCropIrrigationWeather.AlternativeWeatherStation;
                    lAlternativeWeatherData = getWeatherData(lWeatherStation,pDateTime);
                    lAverageTemp = lAlternativeWeatherData.getAverageTemperature(pDateTime);
                }

                if(lMainWeatherData != null || lAlternativeWeatherData!=null)
                {

                    lBaseTemperature = pCropIrrigationWeather.Crop.getBaseTemperature();
                    lGrowingDegree = lAverageTemp - lBaseTemperature;
                    DailyRecord lNewDailyRecord = new DailyRecord(pCropIrrigationWeather , lMainWeatherData, lAlternativeWeatherData,pDateTime, lGrowingDegree, 
                        lEvapotranspirationCrop, lRain, lIrrigation, pObservations);
                }
                
            }
            return lReturn;

        }

        //Security 
        //Utitilities
        //Water
        //WeatherStation
        public bool addWeatherData(WeatherStation.WeatherStation pWeatherStation, DateTime pDateTime,
            double pTemperature, int pSolarRadiation, double pTemMax,
            double pTemMin, double pEvapotranspiration)
        {
            bool lReturn = false;
            try
            {
                WeatherStation.WeatherData lData = new WeatherStation.WeatherData(pWeatherStation, pDateTime,
                    pTemperature, pSolarRadiation, pTemMax, pTemMin, pEvapotranspiration);
                this.WeatherDataList.Add(lData);
                lReturn = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in IrrigationSystem.addWeatherData " + e.Message);
                //TODO manage exception
                throw e;
            }
            return lReturn;
 
        }

        #endregion

        #region Overrides
        #endregion


    }
}