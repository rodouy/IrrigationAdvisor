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
    ///     - name String
    /// 
    /// Methods:
    ///     - IrrigationSystem()      -- constructor
    ///     
    /// </summary>
    public class IrrigationSystem
    {
        #region Consts
        #endregion

        #region Fields

        private List<CropIrrigationWeather> cropIrrigationWeatherList;

        #endregion

        #region Properties
        public List<CropIrrigationWeather> CropIrrigationWeatherList
        {
            get { return cropIrrigationWeatherList; }
            set { cropIrrigationWeatherList = value; }
        }

        #endregion

        #region Construction

        public IrrigationSystem()
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
        #endregion

        #region Overrides
        #endregion


    }
}