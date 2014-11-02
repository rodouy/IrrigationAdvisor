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
        //WeatherStation
        
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
        //WeatherStation
        
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

            //WeatherStation

        }

        #endregion


        #region Private Helpers
        #endregion

        #region Public Methods

        //Crop
        //Irrigation
        //Language
        //Location
        //Management

        public void addDailyRecord(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime)
        {
            //pCropIrrigationWeather.MainWeatherStation
        }
        //Security 
        //Utitilities
        //Water
        //WeatherStation

        #endregion

        #region Overrides
        #endregion


    }
}