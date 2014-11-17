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
    ///     - double            temperatureMax
    ///     - double            temperatureMin
    ///     - double            temperatureDewPoint
    ///     - double            humidity
    ///     - double            humidityMax
    ///     - double            humidityMin
    ///     - double            barometer
    ///     - double            barometerMax
    ///     - double            barometerMin
    ///     - double            solarRadiation
    ///     - double            UVRadiation
    ///     - double            Rain
    ///     - double            RainDay
    ///     - double            RainMonth
    ///     - double            evapotranspiration
    ///     - double            evapotranspirationMonth
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
        ///     - double            temperatureMax
        ///     - double            temperatureMin
        ///     - double            temperatureDewPoint
        ///     - double            humidity
        ///     - double            humidityMax
        ///     - double            humidityMin
        ///     - double            barometer
        ///     - double            barometerMax
        ///     - double            barometerMin
        ///     - double            solarRadiation
        ///     - double            UVRadiation
        ///     - double            Rain
        ///     - double            RainDay
        ///     - double            RainMonth
        ///     - double            evapotranspiration
        ///     - double            evapotranspirationMonth
        /// </summary>
        private WeatherStation weatherStation;
        private DateTime date;
        private double temperature;
        private double temperatureMax;
        private double temperatureMin;
        private double temperatureDewPoint;
        private double humidity;
        private double humidityMax;
        private double humidityMin;
        private double barometer;
        private double barometerMax;
        private double barometerMin;
        private double solarRadiation;
        private double uvRadiation;
        private double rain;
        private double rainDay;
        private double rainMonth;
        private double evapotranspiration;
        private double evapotranspirationMonth;

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
        public double TemperatureDewPoint
        {
            get { return temperatureDewPoint; }
            set { temperatureDewPoint = value; }
        }
        public double Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }
        public double HumidityMax
        {
            get { return humidityMax; }
            set { humidityMax = value; }
        }
        public double HumidityMin
        {
            get { return humidityMin; }
            set { humidityMin = value; }
        }
        public double Barometer
        {
            get { return barometer; }
            set { barometer = value; }
        }
        public double BarometerMax
        {
            get { return barometerMax; }
            set { barometerMax = value; }
        }
        public double BarometerMin
        {
            get { return barometerMin; }
            set { barometerMin = value; }
        }
        public double SolarRadiation
        {
            get { return solarRadiation; }
            set { solarRadiation = value; }
        }
        public double UVRadiation
        {
            get { return uvRadiation; }
            set { uvRadiation = value; }
        }
        public double Rain
        {
            get { return rain; }
            set { rain = value; }
        }
        public double RainDay
        {
            get { return rainDay; }
            set { rainDay = value; }
        }
        public double RainMonth
        {
            get { return rainMonth; }
            set { rainMonth = value; }
        }
        public double Evapotranspiration
        {
            get { return evapotranspiration; }
            set { evapotranspiration = value; }
        }
        public double EvapotranspirationMonth
        {
            get { return evapotranspirationMonth; }
            set { evapotranspirationMonth = value; }
        }
        
        #endregion

        #region Construction
        public WeatherData()
        {
            this.WeatherStation = new WeatherStation();
            this.Date = DateTime.Now;
            this.Temperature = 0;
            this.TemperatureMax = 0;
            this.TemperatureMin = 0;
            this.TemperatureDewPoint = 0;
            this.Humidity = 0;
            this.HumidityMax = 0;
            this.HumidityMin = 0;
            this.Barometer = 0;
            this.BarometerMax = 0;
            this.BarometerMin = 0;
            this.SolarRadiation = 0;
            this.UVRadiation = 0;
            this.Rain = 0;
            this.RainDay = 0;
            this.RainMonth = 0;
            this.Evapotranspiration = 0;
            this.EvapotranspirationMonth = 0;
        }

        public WeatherData
            (
            WeatherStation pWeatherStation,
            DateTime pDate,
            double pTemperature,
            double pTemperatureMax,
            double pTemperatureMin,
            double pSolarRadiation,
            double pEvapotranspiration
            )
        {
            this.WeatherStation = pWeatherStation;
            this.Date = pDate;
            this.Temperature = pTemperature;
            this.TemperatureMax = pTemperatureMax;
            this.TemperatureMin = pTemperatureMin;
            this.TemperatureDewPoint = 0;
            this.Humidity = 0;
            this.HumidityMax = 0;
            this.HumidityMin = 0;
            this.Barometer = 0;
            this.BarometerMax = 0;
            this.BarometerMin = 0;
            this.SolarRadiation = pSolarRadiation;
            this.UVRadiation = 0;
            this.Rain = 0;
            this.RainDay = 0;
            this.RainMonth = 0;
            this.Evapotranspiration = pEvapotranspiration;
            this.EvapotranspirationMonth = 0;
        }

        public WeatherData
            (
            WeatherStation pWeatherStation,
            DateTime pDate,
            double pTemperature,
            double pTemperatureMax,
            double pTemperatureMin,
            double pTemperatureDewPoint,
            double pHumidity,
            double pHumidityMax,
            double pHumidityMin,
            double pBarometer,
            double pBarometerMax,
            double pBarometerMin,
            double pSolarRadiation,
            double pUVRadiation,
            double pRain,
            double pRainDay,
            double pRainMonth,
            double pEvapotranspiration,
            double pEvapotranspirationMonth
            )
        {
            this.WeatherStation = pWeatherStation;
            this.Date = pDate;
            this.Temperature = pTemperature;
            this.TemperatureMax = pTemperatureMax;
            this.TemperatureMin = pTemperatureMin;
            this.TemperatureDewPoint = pTemperatureDewPoint;
            this.Humidity = pHumidity;
            this.HumidityMax = pHumidityMax;
            this.HumidityMin = pHumidityMin;
            this.Barometer = pBarometer;
            this.BarometerMax = pBarometerMax;
            this.BarometerMin = pBarometerMin;
            this.SolarRadiation = pSolarRadiation;
            this.UVRadiation = pUVRadiation;
            this.Rain = pRain;
            this.RainDay = pRainDay;
            this.RainMonth = pRainMonth;
            this.Evapotranspiration = pEvapotranspiration;
            this.EvapotranspirationMonth = pEvapotranspirationMonth;
        }
        #endregion

        #region Private Helpers
        /// <summary>
        /// Get Average from two double values;
        /// </summary>
        /// <param name="pMax"></param>
        /// <param name="pMin"></param>
        /// <returns></returns>
        private double getAverage(double pMax, double pMin)
        {
            double lAverage = 0;
            try
            {
                if (pMax == null || pMin == null)
                    return 0;
                lAverage = Math.Round((pMax + pMin)/ 2, 2);
            }
            catch (Exception e)
            {                
                throw e;
            }
            return lAverage;
        }

        #endregion

        #region Public Methods
        public double getAverageTemperature()
        {
            double lAverageTemperature = 0;
            try
            {
                lAverageTemperature =
                    this.getAverage(this.TemperatureMax, this.TemperatureMin);
            }
            catch (Exception e)
            {                
                throw e;
            }
            return lAverageTemperature;
        }

        public double getAverageHumidity()
        {
            double lAverageHumidity = 0;
            try
            {
                lAverageHumidity = 
                    this.getAverage(this.HumidityMax, this.HumidityMin);
            }
            catch (Exception e)
            {                
                throw e;
            }
            return lAverageHumidity;
        }

        public double getAverageBarometer()
        {
            double lAverageBarometer = 0;
            try
            {                
                lAverageBarometer = 
                    this.getAverage(this.BarometerMax, this.BarometerMin);
            }
            catch (Exception e)
            {                
                throw e;
            }
            return lAverageBarometer;
        }



        public double getEvapotranspiration()
        {
            double lEvapotranspiration = 0;
            try
            {
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
        public override string ToString()
        {
            string lReturn = this.WeatherStation.Name + "\t\t" +
                this.Date.ToString()  + "\t\t" +
                this.Temperature  + "\t\t" +
                this.SolarRadiation   + "\t\t" +
                this.TemperatureMax  + "\t\t" +
                this.TemperatureMin + "\t\t" +
                this.Evapotranspiration  + "\t\t";
            return lReturn;
        }
        #endregion

    }
}