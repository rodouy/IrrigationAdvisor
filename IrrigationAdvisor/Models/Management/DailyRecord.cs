using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.Models.Water;

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

        private WeatherData mainWeatherData;
        private WeatherData alternativeWeatherData;
        private DateTime dateHour;
        private double growingDegree;
        private double growingDegreeAcumulated;
        private double modifiedGrowingDegree;
        private double kc;
        private WaterOutput evapotranspirationCrop;
        private WaterInput rain;
        private WaterInput irrigation;
        private String observations;

        
        #endregion

        #region Properties
        
        public WeatherData MainWeatherData
        {
            get { return mainWeatherData; }
            set { mainWeatherData = value; }
        }

        public WeatherData AlternativeWeatherData
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

        public double GrowingDegreeAcumulated
        {
            get { return growingDegreeAcumulated; }
            set { growingDegreeAcumulated = value; }
        }
        public double ModifiedGrowingDegree
        {
            get { return modifiedGrowingDegree; }
            set { modifiedGrowingDegree = value; }
        }

        public double Kc
        {
            get { return kc; }
            set { kc = value; }
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
            this.MainWeatherData = new WeatherData();
            this.AlternativeWeatherData = new WeatherData();
            this.DateHour = new DateTime();
            this.GrowingDegree = 0;
            this.GrowingDegreeAcumulated = 0;
            this.ModifiedGrowingDegree = 0;
            this.Kc = 0;
            this.EvapotranspirationCrop = new Water.WaterOutput();
            this.Rain = new Water.WaterInput();
            this.Irrigation = new Water.WaterInput();
            this.Observations= "";

        }

        public DailyRecord(WeatherData pMainWeatherData, WeatherData pAlternativeWeatherData,
            DateTime pDateHour, double pGrowingDegree, double pGrowingDegreeAcumulated, double pModifiedGrowingDegree, double pKc, Water.WaterOutput pEvapotranspirationCrop,
            Water.WaterInput pRain, Water.WaterInput pIrrigation, String pObservations) 
        {
            this.MainWeatherData = pMainWeatherData;
            this.AlternativeWeatherData = pAlternativeWeatherData;
            this.DateHour = pDateHour;
            this.GrowingDegree = pGrowingDegree;
            this.GrowingDegreeAcumulated = pGrowingDegreeAcumulated;
            this.ModifiedGrowingDegree = pModifiedGrowingDegree;
            this.Kc = pKc;
            this.EvapotranspirationCrop = pEvapotranspirationCrop;
            this.Rain = pRain;
            this.Irrigation = pIrrigation;
            this.Observations = pObservations;
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        //TODO DailyRecord - public methods
        ///     - getBaseTemperature(): double
        ///     - getDailyAverageTemperature(): double
        ///     - getEvapotranspiration(): double
        ///     - getCropCoefficient(): double
        ///     - getEffectiveRain(Region, rain:double, Date): double
        #endregion

        #region Overrides
        public override string ToString()
        {
            string etc = this.EvapotranspirationCrop.getTotalInput().ToString() + "          ";
            string rain = "       ";
            string irrigation = "       ";
            int index = 5;
            if (this.Rain != null)
            {
                rain = this.Rain.getTotalInput().ToString() + "           ";

            } 
            if (this.Irrigation != null)
            {
                irrigation = this.Irrigation.getTotalInput().ToString() + "           ";

            }
            string lReturn = 
                "Fecha: " + this.DateHour.ToString() + "\t\t" +
                "G.Dia: " + this.GrowingDegree + "\t\t" +
                "ETc:" + etc.Substring(0,index) + "\t\t" +
                "Lluvia: " + rain.Substring(0, index) + "\t\t" +
                "Riego:" + irrigation.Substring(0, index) + "\t\t" +
                "KC:" + this.Kc + "\t\t" +
                "Obs:  " + this.Observations + "\t\t";
            return lReturn;

        }
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            DailyRecord lDailyRecord = obj as DailyRecord;
            return this.DateHour.Date.Equals(lDailyRecord.DateHour.Date);
        }
        public override int GetHashCode()
        {
            return this.Observations.GetHashCode();
        }
        #endregion




    }
}