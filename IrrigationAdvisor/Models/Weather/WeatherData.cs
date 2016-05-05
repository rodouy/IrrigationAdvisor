using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IrrigationAdvisor.Models.Utilities;

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
    ///     - Datetime          date
    ///     - Double            temperature
    ///     - Double            temperatureMax
    ///     - Double            temperatureMin
    ///     - Double            temperatureDewPoint
    ///     - Double            humidity
    ///     - Double            humidityMax
    ///     - Double            humidityMin
    ///     - Double            barometer
    ///     - Double            barometerMax
    ///     - Double            barometerMin
    ///     - Double            solarRadiation
    ///     - Double            UVRadiation
    ///     - Double            RainDay
    ///     - Double            RainStorm
    ///     - Double            RainMonth
    ///     - Double            RainYear
    ///     - Double            evapotranspiration
    ///     - Double            evapotranspirationMonth
    ///     - Double            evapotranspirationYear
    /// 
    /// Methods:
    ///     - WeatherData()      -- constructor
    ///     - WeatherData(Datetime, 
    ///         TemperatureMax Double, TemperatureMin Double, 
    ///         Evapotranspiration Double)  -- consturctor with parameters
    ///     - GetAverageTemperature(Datetime pDate) Double
    ///     - GetEvapotranspiration(Datetime pDate) Double
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
        ///     - long              weatherDataId
        ///     - Datetime          date
        ///     - Double            temperature
        ///     - Double            temperatureMax
        ///     - Double            temperatureMin
        ///     - Double            temperatureDewPoint
        ///     - Double            humidity
        ///     - Double            humidityMax
        ///     - Double            humidityMin
        ///     - Double            barometer
        ///     - Double            barometerMax
        ///     - Double            barometerMin
        ///     - Double            solarRadiation
        ///     - Double            UVRadiation
        ///     - Double            RainDay
        ///     - Double            RainStorm
        ///     - Double            RainMonth
        ///     - Double            RainYear
        ///     - Double            evapotranspiration
        ///     - Double            evapotranspirationMonth
        ///     - Double            evapotranspirationYear
        /// </summary>

        private long weatherDataId;
        private DateTime date;
        private Double temperature;
        private Double temperatureMax;
        private Double temperatureMin;
        private Double temperatureDewPoint;
        private Double humidity;
        private Double humidityMax;
        private Double humidityMin;
        private Double barometer;
        private Double barometerMax;
        private Double barometerMin;
        private Double solarRadiation;
        private Double uvRadiation;
        private Double rainDay;
        private Double rainStorm;
        private Double rainMonth;
        private Double rainYear;
        private Double evapotranspiration;
        private Double evapotranspirationMonth;
        private Double evapotranspirationYear;
        private Utils.WeatherDataType weatherDataType;

        #endregion

        #region Properties

        public long WeatherDataId
        {
            get { return weatherDataId; }
            set { weatherDataId = value; }
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

        public Double Temperature
        {
            get { return temperature; }
            set 
            { 
                temperature = value;
                //PropertyChanged(this,
                //    new System.ComponentModel.PropertyChangedEventArgs("Temperature"));
            }
        }

        public Double TemperatureMax
        {
            get { return temperatureMax; }
            set 
            { 
                temperatureMax = value;
                //PropertyChanged(this,
                //    new System.ComponentModel.PropertyChangedEventArgs("TemperatureMax"));
            }
        }

        public Double TemperatureMin
        {
            get { return temperatureMin; }
            set 
            { 
                temperatureMin = value;
                //PropertyChanged(this,
                //    new System.ComponentModel.PropertyChangedEventArgs("TemperatureMin"));
            }
        }

        public Double TemperatureDewPoint
        {
            get { return temperatureDewPoint; }
            set 
            { 
                temperatureDewPoint = value;
                //PropertyChanged(this,
                //    new System.ComponentModel.PropertyChangedEventArgs("TemperatureDewPoint"));
            }
        }

        public Double Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }

        public Double HumidityMax
        {
            get { return humidityMax; }
            set { humidityMax = value; }
        }

        public Double HumidityMin
        {
            get { return humidityMin; }
            set { humidityMin = value; }
        }

        public Double Barometer
        {
            get { return barometer; }
            set { barometer = value; }
        }

        public Double BarometerMax
        {
            get { return barometerMax; }
            set { barometerMax = value; }
        }

        public Double BarometerMin
        {
            get { return barometerMin; }
            set { barometerMin = value; }
        }

        public Double SolarRadiation
        {
            get { return solarRadiation; }
            set { solarRadiation = value; }
        }

        public Double UVRadiation
        {
            get { return uvRadiation; }
            set { uvRadiation = value; }
        }

        public Double RainDay
        {
            get { return rainDay; }
            set { rainDay = value; }
        }

        public Double RainStorm
        {
            get { return rainStorm; }
            set { rainStorm = value; }
        }

        public Double RainMonth
        {
            get { return rainMonth; }
            set { rainMonth = value; }
        }

        public Double RainYear
        {
            get { return rainYear; }
            set { rainYear = value; }
        }

        public Double Evapotranspiration
        {
            get { return evapotranspiration; }
            set { evapotranspiration = value; }
        }

        public Double EvapotranspirationMonth
        {
            get { return evapotranspirationMonth; }
            set { evapotranspirationMonth = value; }
        }

        public Double EvapotranspirationYear
        {
            get { return evapotranspirationYear; }
            set { evapotranspirationYear = value; }
        }

        public Utils.WeatherDataType WeatherDataType
        {
            get { return weatherDataType; }
            set { weatherDataType = value; }
        }

        //[field: NonSerialized()]
        //public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public WeatherData()
        {
            this.WeatherDataId = 0;
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
            this.WeatherDataType = Utils.WeatherDataType.AllData;
        }

        /// <summary>
        /// Constructor wiht the minimum parameters
        /// </summary>
        /// <param name="pWeatherDataId"></param>
        /// <param name="pDate"></param>
        /// <param name="pTemperature"></param>
        /// <param name="pTemperatureMax"></param>
        /// <param name="pTemperatureMin"></param>
        /// <param name="pSolarRadiation"></param>
        /// <param name="pEvapotranspiration"></param>
        /// <param name="pWeatherDataType"></param>
        public WeatherData
            (
            long pWeatherDataId,
            DateTime pDate,
            Double pTemperature,
            Double pTemperatureMax,
            Double pTemperatureMin,
            Double pSolarRadiation,
            Double pEvapotranspiration,
            Utils.WeatherDataType pWeatherDataType
            )
        {
            this.WeatherDataId = pWeatherDataId;
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
            this.WeatherDataType = pWeatherDataType;
        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pWeatherDataId"></param>
        /// <param name="pDate"></param>
        /// <param name="pTemperature"></param>
        /// <param name="pTemperatureMax"></param>
        /// <param name="pTemperatureMin"></param>
        /// <param name="pTemperatureDewPoint"></param>
        /// <param name="pHumidity"></param>
        /// <param name="pHumidityMax"></param>
        /// <param name="pHumidityMin"></param>
        /// <param name="pBarometer"></param>
        /// <param name="pBarometerMax"></param>
        /// <param name="pBarometerMin"></param>
        /// <param name="pSolarRadiation"></param>
        /// <param name="pUVRadiation"></param>
        /// <param name="pRainDay"></param>
        /// <param name="pRainStorm"></param>
        /// <param name="pRainMonth"></param>
        /// <param name="pRainYear"></param>
        /// <param name="pEvapotranspiration"></param>
        /// <param name="pEvapotranspirationMonth"></param>
        /// <param name="pEvapotranspirationYear"></param>
        /// <param name="pWeatherDataType"></param>
        public WeatherData
            (
            long pWeatherDataId,
            DateTime pDate,
            Double pTemperature,
            Double pTemperatureMax,
            Double pTemperatureMin,
            Double pTemperatureDewPoint,
            Double pHumidity,
            Double pHumidityMax,
            Double pHumidityMin,
            Double pBarometer,
            Double pBarometerMax,
            Double pBarometerMin,
            Double pSolarRadiation,
            Double pUVRadiation,
            Double pRainDay,
            Double pRainStorm,
            Double pRainMonth,
            Double pRainYear,
            Double pEvapotranspiration,
            Double pEvapotranspirationMonth,
            Double pEvapotranspirationYear,
            Utils.WeatherDataType pWeatherDataType
            )
        {
            this.WeatherDataId = pWeatherDataId;
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
            this.WeatherDataType = pWeatherDataType;
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Get Average from two Double values;
        /// </summary>
        /// <param name="pMax"></param>
        /// <param name="pMin"></param>
        /// <returns></returns>
        private Double getAverage(Double pMax, Double pMin)
        {
            Double lAverage = 0;
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

        /// <summary>
        /// Get the Average Temperature between Max and Min Temperature
        /// </summary>
        /// <returns></returns>
        public Double GetAverageTemperature()
        {
            Double lAverageTemperature = 0;
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

        /// <summary>
        /// Get the Average Humidity between Max and Min Humidity
        /// </summary>
        /// <returns></returns>
        public Double GetAverageHumidity()
        {
            Double lAverageHumidity = 0;
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

        /// <summary>
        /// Get the Average Pressure between Max and Min Pressure mesure
        /// </summary>
        /// <returns></returns>
        public Double GetAverageBarometer()
        {
            Double lAverageBarometer = 0;
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

        /// <summary>
        /// Get Evapotranspiration
        /// </summary>
        /// <returns></returns>
        public Double GetEvapotranspiration()
        {
            Double lEvapotranspiration = 0;
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

        /// <summary>
        /// Overrides equals:
        /// Year, Month, Day and Hour
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool lReturn = false;
            if (obj == null || obj.GetType() != this.GetType())
            {
                return lReturn;
            }
            WeatherData lWeatherData = obj as WeatherData;
            lReturn = Utils.IsTheSameDayAndHour(lWeatherData.Date, this.Date);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.Date.GetHashCode();
        }

        #endregion

    }
}