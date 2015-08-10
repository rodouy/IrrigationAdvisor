using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Weather
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
    ///     - double            RainDay
    ///     - double            RainStorm
    ///     - double            RainMonth
    ///     - double            RainYear
    ///     - double            evapotranspiration
    ///     - double            evapotranspirationMonth
    ///     - double            evapotranspirationYear
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
    //[Serializable()]
    public class WeatherData //: System.ComponentModel.INotifyPropertyChanged
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
        ///     - double            RainDay
        ///     - double            RainStorm
        ///     - double            RainMonth
        ///     - double            RainYear
        ///     - double            evapotranspiration
        ///     - double            evapotranspirationMonth
        ///     - double            evapotranspirationYear
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
        private double rainDay;
        private double rainStorm;
        private double rainMonth;
        private double rainYear;
        private double evapotranspiration;
        private double evapotranspirationMonth;
        private double evapotranspirationYear;

        #endregion

        #region Properties
        public WeatherStation WeatherStation
        {
            get { return weatherStation; }
            set 
            { 
                weatherStation = value;
                //PropertyChanged(this, 
                //    new System.ComponentModel.PropertyChangedEventArgs("WeatherStation"));
            }
        }
        public DateTime Date
        {
            get { return date; }
            set 
            { 
                date = value;
                //PropertyChanged(this,
                //    new System.ComponentModel.PropertyChangedEventArgs("Date"));
            }
        }
        public double Temperature
        {
            get { return temperature; }
            set 
            { 
                temperature = value;
                //PropertyChanged(this,
                //    new System.ComponentModel.PropertyChangedEventArgs("Temperature"));
            }
        }
        public double TemperatureMax
        {
            get { return temperatureMax; }
            set 
            { 
                temperatureMax = value;
                //PropertyChanged(this,
                //    new System.ComponentModel.PropertyChangedEventArgs("TemperatureMax"));
            }
        }
        public double TemperatureMin
        {
            get { return temperatureMin; }
            set 
            { 
                temperatureMin = value;
                //PropertyChanged(this,
                //    new System.ComponentModel.PropertyChangedEventArgs("TemperatureMin"));
            }
        }
        public double TemperatureDewPoint
        {
            get { return temperatureDewPoint; }
            set 
            { 
                temperatureDewPoint = value;
                //PropertyChanged(this,
                //    new System.ComponentModel.PropertyChangedEventArgs("TemperatureDewPoint"));
            }
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
        public double RainDay
        {
            get { return rainDay; }
            set { rainDay = value; }
        }
        public double RainStorm
        {
            get { return rainStorm; }
            set { rainStorm = value; }
        }
        public double RainMonth
        {
            get { return rainMonth; }
            set { rainMonth = value; }
        }
        public double RainYear
        {
            get { return rainYear; }
            set { rainYear = value; }
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
        public double EvapotranspirationYear
        {
            get { return evapotranspirationYear; }
            set { evapotranspirationYear = value; }
        }
        
        //[field: NonSerialized()]
        //public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
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
            this.RainDay = 0;
            this.RainStorm = 0;
            this.RainMonth = 0;
            this.RainYear = 0;
            this.Evapotranspiration = 0;
            this.EvapotranspirationMonth = 0;
            this.EvapotranspirationYear = 0;
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
            this.RainDay = 0;
            this.RainStorm = 0;
            this.RainMonth = 0;
            this.RainYear = 0;
            this.Evapotranspiration = pEvapotranspiration;
            this.EvapotranspirationMonth = 0;
            this.EvapotranspirationYear = 0;
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
            double pRainDay,
            double pRainStorm,
            double pRainMonth,
            double pRainYear,
            double pEvapotranspiration,
            double pEvapotranspirationMonth,
            double pEvapotranspirationYear
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
            this.RainDay = pRainDay;
            this.RainStorm = pRainStorm;
            this.RainMonth = pRainMonth;
            this.RainYear = pRainYear;
            this.Evapotranspiration = pEvapotranspiration;
            this.EvapotranspirationMonth = pEvapotranspirationMonth;
            this.EvapotranspirationYear = pEvapotranspirationYear;
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
                if (pMax == 0 || pMin == 0)
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
            string lReturn = 
                "Name " +
                this.WeatherStation.Name + ";" +
                "Date " +
                this.Date.ToString() + ";" +
                "Temperatures (now, max, min) " +
                this.Temperature.ToString() + ";" +
                this.TemperatureMax.ToString() + ";" +
                this.TemperatureMin.ToString() + ";" +
                "Humidity (now, max, min) " +
                this.Humidity.ToString() + ";" +
                this.HumidityMax.ToString() + ";" +
                this.HumidityMin.ToString() + ";" +
                "Barometer (now, max, min) " +
                this.Barometer.ToString() + ";" +
                this.BarometerMax.ToString() + ";" +
                this.BarometerMin.ToString() + ";" +
                "Solar Radiation " +
                this.SolarRadiation.ToString() + ";" +
                "UVRadiation " +
                this.UVRadiation.ToString() + ";" +
                "Rain (day, storm, month, year) " +
                this.RainDay.ToString() + ";" +
                this.RainStorm.ToString() + ";" +
                this.RainMonth.ToString() + ";" +
                this.RainYear.ToString() + ";" +
                "Evapotranspiration (now, month, year) " +
                this.Evapotranspiration.ToString() + ";" +
                this.EvapotranspirationMonth.ToString() + ";" +
                this.EvapotranspirationYear.ToString() + ";";
            return lReturn;
        }
        #endregion

    }
}