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
    ///     - growingDegreeDays: double
    ///     - totalGrowingDegree: double
    ///     - evapotranspirationCrop: WaterOutput
    ///     - lRain: WaterInput
    ///     - lIrrigation: WaterInput 
    ///     - observations: String
    /// 
    /// Methods:
    ///     - DailyRecord()      -- constructor
    ///     - DailyRecord(name)  -- consturctor with parameters
    ///     - GetDaysAfterSowing(): int
    ///     - GetRegion(): Region
    ///     - GetBaseTemperature(): double
    ///     - getDailyAverageTemperature(): double
    ///     - GetEvapotranspiration(): double
    ///     - getCropCoefficient(): double
    ///     - GetEffectiveRain(Region, lRain:double, Date): double
    ///     - setObservations(String): bool
    ///      
    /// </summary>
    public class DailyRecord
    {
        #region Consts
        #endregion

        #region Fields

        private DateTime dailyRecordDateTime;
        //Weather Data
        private WeatherData mainWeatherData;
        private WeatherData alternativeWeatherData;
        //Calculus by Days After Sowing
        private int daysAfterSowing;
        private int daysAfterSowingModified;
        //Calculus by Growing Degree Days
        private Double growingDegreeDays;
        private Double growingDegreeDaysAccumulated;
        private Double growingDegreeDaysModified;
        //Input Water Data
        private Water.Rain rain;
        private Water.Irrigation irrigation;
        private DateTime lastWaterInputDate;
        private DateTime lastBigWaterInputDate;       
        private DateTime lastPartialWaterInputDate;
        private Double lastPartialWaterInput;

        //Output Water Data
        private WaterOutput evapotranspirationCrop;

        //Crop State
        private Double hydricBalance;
        private Double soilHydricVolume;
        private Double totalEvapotranspirationCropFromLastWaterInput;
        private Double cropCoefficient;
        private String observations;
        
        #endregion

        #region Properties

        public DateTime DailyRecordDateTime
        {
            get { return dailyRecordDateTime; }
            set { dailyRecordDateTime = value; }
        }

        #region WeatherData

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

        #endregion

        #region CalculusByDaysAfterSowing

        public int DaysAfterSowing
        {
            get { return daysAfterSowing; }
            set { daysAfterSowing = value; }
        }

        public int DaysAfterSowingModified
        {
            get { return daysAfterSowingModified; }
            set { daysAfterSowingModified = value; }
        }

        #endregion

        #region CalculusByGrowingDegreeDays
        
        public double GrowingDegreeDays
        {
            get { return growingDegreeDays; }
            set { growingDegreeDays = value; }
        }

        public double GrowingDegreeDaysAccumulated
        {
            get { return growingDegreeDaysAccumulated; }
            set { growingDegreeDaysAccumulated = value; }
        }

        public double GrowingDegreeDaysModified
        {
            get { return growingDegreeDaysModified; }
            set { growingDegreeDaysModified = value; }
        }

        #endregion

        #region InputWaterData

        public Water.Rain Rain
        {
            get { return rain; }
            set { rain = value; }
        }
        public Water.Irrigation Irrigation
        {
            get { return irrigation; }
            set { irrigation = value; }
        }
        public DateTime LastWaterInputDate
        {
            get { return lastWaterInputDate; }
            set { lastWaterInputDate = value; }
        }
        public DateTime LastBigWaterInputDate
        {
            get { return lastBigWaterInputDate; }
            set { lastBigWaterInputDate = value; }
        }
        public DateTime LastPartialWaterInputDate
        {
            get { return lastPartialWaterInputDate; }
            set { lastPartialWaterInputDate = value; }
        }
        public Double LastPartialWaterInput
        {
            get { return lastPartialWaterInput; }
            set { lastPartialWaterInput = value; }
        }
        
        #endregion

        #region OutputWeatherData

        public WaterOutput EvapotranspirationCrop
        {
            get { return evapotranspirationCrop; }
            set { evapotranspirationCrop = value; }
        }
        #endregion

        #region CropState
        public Double HydricBalance
        {
            get { return hydricBalance; }
            set { hydricBalance = value; }
        }
        public Double SoilHydricVolume
        {
            get { return soilHydricVolume; }
            set { soilHydricVolume = value; }
        }
        public Double TotalEvapotranspirationCropFromLastWaterInput
        {
            get { return totalEvapotranspirationCropFromLastWaterInput; }
            set { totalEvapotranspirationCropFromLastWaterInput = value; }
        }
        public double CropCoefficient
        {
            get { return cropCoefficient; }
            set { cropCoefficient = value; }
        }
        public String Observations
        {
            get { return observations; }
            set { observations = value; }
        }
        #endregion

        #endregion

        #region Construction

        public DailyRecord() 
        {
            this.DailyRecordDateTime = new DateTime();

            this.MainWeatherData = new WeatherData();
            this.AlternativeWeatherData = new WeatherData();

            this.DaysAfterSowing = 0;
            this.DaysAfterSowingModified = 0;

            this.GrowingDegreeDays = 0;
            this.GrowingDegreeDaysAccumulated = 0;
            this.GrowingDegreeDaysModified = 0;

            this.Rain = new Water.Rain();
            this.Irrigation = new Water.Irrigation();
            this.LastWaterInputDate = new DateTime();
            this.LastBigWaterInputDate = new DateTime();
            this.LastPartialWaterInputDate = new DateTime();
            this.LastPartialWaterInput = 0;

            this.EvapotranspirationCrop = new WaterOutput();

            this.HydricBalance = 0;
            this.SoilHydricVolume = 0;
            this.TotalEvapotranspirationCropFromLastWaterInput = 0;
            this.CropCoefficient = 0;
            this.Observations= "";

        }


        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="pDailyRecordDateTime"></param>
        /// <param name="pMainWeatherData"></param>
        /// <param name="pAlternativeWeatherData"></param>
        /// <param name="pDaysAfterSowing"></param>
        /// <param name="pDaysAfterSowingModified"></param>
        /// <param name="pGrowingDegreeDays"></param>
        /// <param name="pGrowingDegreeDaysAccumulated"></param>
        /// <param name="pGrowingDegreeDaysModified"></param>
        /// <param name="pRain"></param>
        /// <param name="pIrrigation"></param>
        /// <param name="pLastWaterInputDate"></param>
        /// <param name="pLastBigWaterInputDate"></param>
        /// <param name="pLastPartialWaterInputDate"></param>
        /// <param name="pLastPartialWaterInput"></param>
        /// <param name="pKc"></param>
        /// <param name="pEvapotranspirationCrop"></param>
        /// <param name="pHydricBalance"></param>
        /// <param name="pSoilHydricVolume"></param>
        /// <param name="pTotalEvapotranspirationFromLastWaterInput"></param>
        /// <param name="pCropCoefficient"></param>
        /// <param name="pObservations"></param>
        public DailyRecord(DateTime pDailyRecordDateTime, WeatherData pMainWeatherData, WeatherData pAlternativeWeatherData,
                            int pDaysAfterSowing, int pDaysAfterSowingModified,
                            Double pGrowingDegreeDays, Double pGrowingDegreeDaysAccumulated, Double pGrowingDegreeDaysModified, 
                            Water.Rain pRain, Water.Irrigation pIrrigation,
                            DateTime pLastWaterInputDate, DateTime pLastBigWaterInputDate,
                            DateTime pLastPartialWaterInputDate, Double pLastPartialWaterInput,
                            Water.WaterOutput pEvapotranspirationCrop,
                            Double pHydricBalance, Double pSoilHydricVolume, Double pTotalEvapotranspirationFromLastWaterInput,
                            Double pCropCoefficient, String pObservations) 
        {
            this.DailyRecordDateTime = pDailyRecordDateTime;

            this.MainWeatherData = pMainWeatherData;
            this.AlternativeWeatherData = pAlternativeWeatherData;

            this.DaysAfterSowing = pDaysAfterSowing;
            this.DaysAfterSowingModified = pDaysAfterSowingModified;

            this.GrowingDegreeDays = pGrowingDegreeDays;
            this.GrowingDegreeDaysAccumulated = pGrowingDegreeDaysAccumulated;
            this.GrowingDegreeDaysModified = pGrowingDegreeDaysModified;

            this.Rain = pRain;
            this.Irrigation = pIrrigation;
            this.LastWaterInputDate = pLastWaterInputDate;
            this.LastBigWaterInputDate = pLastBigWaterInputDate;
            this.LastPartialWaterInputDate = pLastPartialWaterInputDate;
            this.LastPartialWaterInput = pLastPartialWaterInput;

            this.EvapotranspirationCrop = pEvapotranspirationCrop;

            this.HydricBalance = pHydricBalance;
            this.SoilHydricVolume = pSoilHydricVolume;
            this.TotalEvapotranspirationCropFromLastWaterInput = pTotalEvapotranspirationFromLastWaterInput;
            this.CropCoefficient = pCropCoefficient;
            this.Observations = pObservations;
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        //TODO DailyRecord - public methods
        ///     - GetBaseTemperature(): double
        ///     - getDailyAverageTemperature(): double
        ///     - GetEvapotranspiration(): double
        ///     - getCropCoefficient(): double
        ///     - GetEffectiveRain(Region, lRain:double, Date): double
        #endregion

        #region Overrides


        public override string ToString()
        {
            string lEvapotranspirationCrop = this.EvapotranspirationCrop.GetTotalInput().ToString() + "          ";
            string lRain = "       ";
            string lIrrigation = "       ";
            int index = 5;
            if (this.Rain != null)
            {
                lRain = this.Rain.getTotalInput().ToString() + "           ";

            } 
            if (this.Irrigation != null)
            {
                lIrrigation = this.Irrigation.getTotalInput().ToString() + "           ";

            }
            string lReturn = 
                "Fecha: " + this.DailyRecordDateTime.ToString() + "\t\t" +
                "G.Dia: " + this.GrowingDegreeDays + "\t\t" +
                "ETc:" + lEvapotranspirationCrop.Substring(0,index) + "\t\t" +
                "Lluvia: " + lRain.Substring(0, index) + "\t\t" +
                "Riego:" + lIrrigation.Substring(0, index) + "\t\t" +
                "KC:" + this.CropCoefficient + "\t\t" +
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
            return this.DailyRecordDateTime.Date.Equals(lDailyRecord.DailyRecordDateTime.Date);
        }

        public override int GetHashCode()
        {
            return this.Observations.GetHashCode();
        }

        #endregion


    }
}