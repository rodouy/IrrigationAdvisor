using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Management
{
    /// <summary>
    /// Create: 2014-10-27
    /// Author:  monicarle
    /// Description: 
    ///     Is the fusion of: a WheatherStation, a Crop and an IrrigationUnit
    ///     
    /// References:
    ///     WheatherStation
    ///     Crop
    ///     IrrigationUnit
    ///     
    /// Dependencies:
    ///     DailyRecord
    ///     IrrigationRecords
    ///     IrrigationCalculus
    ///     IrrigationForecast
    /// 
    /// TODO:
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - irrigationUnit IrrigationUnit - PK
    ///     - crop Crop                     - PK
    ///     - mainWeatherStation WeatherStation
    ///     - alternativeWeatherStation WeatherStation
    /// 
    /// Methods:
    ///     - CropIrrigationWeather()      -- constructor
    ///     - CropIrrigationWeather(irrigationUnit, crop, mainWeatherStation, alternativeWeatherStation)  -- consturctor with parameters
    ///     - getRegion(): Region
    ///     - getDaysAfterSowing(): int- getBaseTemperature(): double
    ///     - getMaxEvapotranspirationToIrrigate(): double
    /// 
    /// </summary>
    public class CropIrrigationWeather
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - irrigationUnit: IrrigationUnit
        ///     - crop: Crop
        ///     - mainWeatherStation: WeatherStation
        ///     - alternativeWeatherStation: WeatherStation
        /// </summary>

        private Irrigation.IrrigationUnit irrigationUnit;
        private Crop.Crop crop;
        private WeatherStation.WeatherStation mainWeatherStation;
        private WeatherStation.WeatherStation alternativeWeatherStation;
        #endregion

        #region Properties
        public Irrigation.IrrigationUnit IrrigationUnit
        {
            get { return irrigationUnit; }
            set { irrigationUnit = value; }
        }

        public Crop.Crop Crop
        {
            get { return crop; }
            set { crop = value; }
        }
        
        public WeatherStation.WeatherStation MainWeatherStation
        {
            get { return mainWeatherStation; }
            set { mainWeatherStation = value; }
        }
        
        public WeatherStation.WeatherStation AlternativeWeatherStation
        {
            get { return alternativeWeatherStation; }
            set { alternativeWeatherStation = value; }
        }

        #endregion

        #region Construction

        public CropIrrigationWeather() 
        {
            this.IrrigationUnit = new Irrigation.IrrigationUnit();
            this.Crop=new Crop.Crop();
            this.MainWeatherStation = new WeatherStation.WeatherStation();
            this.AlternativeWeatherStation = new WeatherStation.WeatherStation();
        }

        public CropIrrigationWeather(Irrigation.IrrigationUnit pIrrigationUnit,
            Crop.Crop pCrop, WeatherStation.WeatherStation pMainWS,
            WeatherStation.WeatherStation pAlternativeWS)
        {
            this.IrrigationUnit = pIrrigationUnit;
            this.Crop = pCrop;
            this.MainWeatherStation = pMainWS;
            this.AlternativeWeatherStation = pAlternativeWS;
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        public Location.Region getRegion() 
        {
            return this.irrigationUnit.Location.Region;
        }

        public int getDaysAfterSowing()
        {
            return this.Crop.getDaysAfterSowing();
        }

        public double getBaseTemperature() 
        {
            return this.Crop.getBaseTemperature();
        }

        public double getMaxEvapotranspirationToIrrigate()
        {
            return this.Crop.MaxEvapotranspirationToIrrigate;
        }
        #endregion

        #region Overrides
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            CropIrrigationWeather lCropIrrigationWeather = obj as CropIrrigationWeather;
            return this.Crop.Equals(lCropIrrigationWeather.Crop) &&
                this.IrrigationUnit.Equals(lCropIrrigationWeather.IrrigationUnit);
        }

        public override int GetHashCode()
        {
            return this.Crop.GetHashCode();
        }
        #endregion

    }
}