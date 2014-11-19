using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Location;

namespace IrrigationAdvisor.Models.Management
{
    /// <summary>
    /// Create: 2014-10-27
    /// Author:  monicarle
    /// Description: 
    ///     Describes the daily changes on a CropIrrigationWeather
    ///     
    /// References:
    ///     CropIrrigationWeather
    ///     WeatherData
    ///     WaterOutput
    ///     WaterInput
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - cropIrrigationWeather: CropIrrigationWeather - PK
    ///     - mainWeatherData: WeatherData
    ///     - alternativeWeatherData: WeatherData
    ///     - date: DateTime                               - PK
    ///     - growingDegree: double
    ///     - totalGrowingDegree: double
    ///     - evapotranspirationCrop: WaterOutput
    ///     - rain: WaterInput
    ///     - irrigation: WaterInput 
    ///     - observations: String
    /// 
    /// Methods:
    ///     - DailyRecord()      -- constructor
    ///     - DailyRecord(name)  -- consturctor with parameters
    ///     - getDaysAfterSowing(): int
    ///     - getRegion(): Region
    ///     - getBaseTemperature(): double
    ///     - getDailyAverageTemperature(): double
    ///     - getEvapotranspiration(): double
    ///     - getCropCoefficient(): double
    ///     - getEffectiveRain(Region, rain:double, Date): double
    ///     - setObservations(String): bool
    ///      
    /// </summary>
    public class DailyRecord
    {
        #region Consts
        #endregion

        #region Fields

        private CropIrrigationWeather cropIrrigationWeather;
        private WeatherStation.WeatherData mainWeatherData;
        private WeatherStation.WeatherData alternativeWeatherData;
        private DateTime dateHour;
        private double growingDegree;
        private double modifiedGrowingDegree;
        private Water.WaterOutput evapotranspirationCrop;
        private Water.WaterInput rain;
        private Water.WaterInput irrigation;
        private String observations;

        
        #endregion

        #region Properties
        public CropIrrigationWeather CropIrrigationWeather
        {
            get { return cropIrrigationWeather; }
            set { cropIrrigationWeather = value; }
        }

        public WeatherStation.WeatherData MainWeatherData
        {
            get { return mainWeatherData; }
            set { mainWeatherData = value; }
        }

        public WeatherStation.WeatherData AlternativeWeatherData
        {
            get { return alternativeWeatherData; }
            set { alternativeWeatherData = value; }
        }
 
        public DateTime DateHour
        {
            get { return dateHour; }
            set { dateHour = value; }
        }

        public double GrowingDegree
        {
            get { return growingDegree; }
            set { growingDegree = value; }
        }

        public double ModifiedGrowingDegree
        {
            get { return modifiedGrowingDegree; }
            set { modifiedGrowingDegree = value; }
        }
        
        public  Water.WaterOutput EvapotranspirationCrop
        {
            get { return evapotranspirationCrop; }
            set { evapotranspirationCrop = value; }
        }

        public Water.WaterInput Rain
        {
            get { return rain; }
            set { rain = value; }
        }

        public Water.WaterInput Irrigation
        {
            get { return irrigation; }
            set { irrigation = value; }
        }
        
        public String Observations
        {
            get { return observations; }
            set { observations = value; }
        }
        #endregion

        #region Construction

        public DailyRecord() 
        {
            this.CropIrrigationWeather = new CropIrrigationWeather();
            this.MainWeatherData = new WeatherStation.WeatherData();
            this.AlternativeWeatherData = new WeatherStation.WeatherData();
            this.DateHour = new DateTime();
            this.GrowingDegree = 0;
            this.ModifiedGrowingDegree = 0;
            this.EvapotranspirationCrop = new Water.WaterOutput();
            this.Rain = new Water.WaterInput();
            this.Irrigation = new Water.WaterInput();
            this.Observations= "";

        }

        public DailyRecord(CropIrrigationWeather pCropIrrigationWeather, 
            WeatherStation.WeatherData pMainWeatherData, WeatherStation.WeatherData pAlternativeWeatherData,
            DateTime pDateHour, double pGrowingDegree, double pModifiedGrowingDegree, Water.WaterOutput pEvapotranspirationCrop,
            Water.WaterInput pRain, Water.WaterInput pIrrigation, String pObservations) 
        {
            this.CropIrrigationWeather = pCropIrrigationWeather;
            this.MainWeatherData = pMainWeatherData;
            this.AlternativeWeatherData = pAlternativeWeatherData;
            this.DateHour = pDateHour;
            this.GrowingDegree = pGrowingDegree;
            this.ModifiedGrowingDegree = pModifiedGrowingDegree;
            this.EvapotranspirationCrop = pEvapotranspirationCrop;
            this.Rain = pRain;
            this.Irrigation = pIrrigation;
            this.Observations = pObservations;
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        public int getDaysAfterSowing() 
        {
            return this.CropIrrigationWeather.Crop.getDaysAfterSowing();
             
        }
        public Region getRegion() 
        {
            return this.CropIrrigationWeather.Crop.getRegion();
        }
        ///     - getBaseTemperature(): double
        ///     - getDailyAverageTemperature(): double
        ///     - getEvapotranspiration(): double
        ///     - getCropCoefficient(): double
        ///     - getEffectiveRain(Region, rain:double, Date): double
        #endregion

        #region Overrides
        public override string ToString()
        {
            string lReturn = this.CropIrrigationWeather.Crop.Name +  "\t\t" +
               this.DateHour.ToString() + this.GrowingDegree + "\t\t" +
               this.EvapotranspirationCrop.getTotalInput() + "\t\t" +
               this.Rain + "\t\t" +
               this.Irrigation + "\t\t" +
               this.Observations + "\t\t";
            return lReturn;

        }
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            DailyRecord lDailyRecord = obj as DailyRecord;
            return this.CropIrrigationWeather.Equals(lDailyRecord.CropIrrigationWeather) &&
                this.DateHour.Date.Equals(lDailyRecord.DateHour.Date);
        }
        public override int GetHashCode()
        {
            return this.Observations.GetHashCode();
        }
        #endregion




    }
}