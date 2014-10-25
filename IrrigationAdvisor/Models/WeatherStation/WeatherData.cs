using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.WeatherStation
{
    /// <summary>
    /// Create: 2014-10-25
    /// Author: rodouy
    /// Description: 
    ///     Data of the weather station
    ///     
    /// References:
    ///     list of classes this class use
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - WeatherStation    weatherStation
    ///     - Datetime          date
    ///     - double            temperature
    ///     - int               solarRadiation
    ///     - double            temperatureMax
    ///     - double            temperatureMin
    ///     - double            evapotranspiration
    /// 
    /// Methods:
    ///     - WeatherData()      -- constructor
    ///     - WeatherData(WeatherStation, Datetime, 
    ///         TemperatureMax double, TemperatureMin double, 
    ///         Evapotranspiration double)  -- consturctor with parameters
    ///     - getAverageTemperature(Datetime pDate) double
    ///     - getEvapotranspiration(Datetime pDate) double
    /// 
    /// </summary>
    public class WeatherData
    {

        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - WeatherStation    weatherStation
        ///     - Datetime          date
        ///     - double            temperature
        ///     - int               solarRadiation
        ///     - double            temperatureMax
        ///     - double            temperatureMin
        ///     - double            evapotranspiration
        /// </summary>
        private WeatherStation weatherStation;
        private DateTime date;
        private double temperature;
        private int solarRadiation;
        private double temperatureMax;
        private double temperatureMin;
        private double evapotranspiration;

        #endregion

        #region Properties
        public WeatherStation WeatherStation
        {
            get { return weatherStation; }
            set { weatherStation = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public double Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        public int SolarRadiation
        {
            get { return solarRadiation; }
            set { solarRadiation = value; }
        }
        public double TemperatureMax
        {
            get { return temperatureMax; }
            set { temperatureMax = value; }
        }
        public double TemperatureMin
        {
            get { return temperatureMin; }
            set { temperatureMin = value; }
        }
        public double Evapotranspiration
        {
            get { return evapotranspiration; }
            set { evapotranspiration = value; }
        }
        #endregion

        #region Construction
        public WeatherData()
        {
            this.WeatherStation = new WeatherStation();
            this.Date = DateTime.Now;
            this.Temperature = 0;
            this.SolarRadiation = 0;
            this.TemperatureMax = 0;
            this.TemperatureMin = 0;
            this.Evapotranspiration = 0;
        }

        public WeatherData
            (
            WeatherStation pWeatherStation,
            DateTime pDate,
            double pTemperature,
            int pSolarRadiation,
            double pTemperatureMax,
            double pTemperatureMin,
            double pEvapotranspiration
            )
        {
            this.WeatherStation = pWeatherStation;
            this.Date = pDate;
            this.Temperature = pTemperature;
            this.SolarRadiation = pSolarRadiation;
            this.TemperatureMax = pTemperatureMax;
            this.TemperatureMin = pTemperatureMin;
            this.Evapotranspiration = pEvapotranspiration;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        public double getAverageTemperature(DateTime pDate)
        {
            double lAverageTemperature = 0;
            try
            {
                if (this.TemperatureMax == null || this.TemperatureMin == null)
                    return 0;
                lAverageTemperature = Math.Round(this.TemperatureMax + this.TemperatureMin / 2, 2);

            }
            catch (Exception e)
            {
                
                throw e;
            } 
            return lAverageTemperature;
        }

        public double getEvapotranspiration(DateTime pDate)
        {
            double lEvapotranspiration = 0;
            try
            {
                if (pDate == null)
                    return 0;
                if (this.Evapotranspiration == null)
                    return 0;
                if (this.Evapotranspiration != 0)
                    lEvapotranspiration = this.Evapotranspiration;
                // TODO: lEvapotranspiration = do calculous for evapotranspiration;
            }
            catch (Exception e)
            {
                
                throw e;
            }
            return lEvapotranspiration;
        }
        #endregion

        #region Overrides
        #endregion

    }
}