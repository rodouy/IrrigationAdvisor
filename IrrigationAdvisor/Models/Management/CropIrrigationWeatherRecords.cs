using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Management
{
    
    /// <summary>
    /// Create: 2014-10-31
    /// Author: monicarle
    /// Description: 
    ///     Contains all the daily records of a crop 
    ///     and knows the last state of the crop
    ///     
    /// References:
    ///     CropIrrigationWeather
    ///     DailyRecord
    ///     DateTime
    ///     
    /// Dependencies:
    ///     IrrigationSystem
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - idCropIrrigationWeatherRecords: int
    ///     - cropIrrigationWeather: CropIrrigationWeather    - PK
    ///     - dailyRecords: List<DailyRecord>
    ///     - growingDegreeDays: double
    ///     - modifiedGrowingDegreeDays: double
    ///     - totalEvapotranspirationCrop: double
    ///     - totalEffectiveRain: double
    ///     - totalIrrigation: double
    ///     - hydricBalance: double
    ///     - soilHydricVolume: double
    ///     - lastWaterInput: Date
    ///     - totalEvapotranspirationCropFromLastWaterInput: double
    /// 
    /// Methods:
    ///     - IrrigationRecords()      -- constructor
    ///     - IrrigationRecords(name)  -- consturctor with parameters
    ///     - getPhenologicalStage(DayGrades: double): Stage
    ///     - setGrowingDegreeDays(): bool
    ///     - setPhenologicalState(Stage): bool
    ///     - setNewPhenologicalStage(Stage): GrowingDegreeDays: double
    ///     - getRootDepth(Specie, Stage): double
    ///     - getPhenologicalStage(GrowingDegreeDays: double): Stage
    ///     - getAvailableWater(RootDepth:double, FieldCapacity:double, PermanentWiltingPoint:double): double
    ///     - getHydricBalance(): double
    ///     - getSoilHydricVolume(): double
    ///     - getEffectiveRain(Date): double
    ///     - getGrowingDegree(Date): double
    ///     - getEvapotranspirationCrop(Date): double
    ///     - getObservations(Date): String
    ///     - getLastThreeDaysOfEvapotranspirationCrop(): double
    ///     
    /// </summary>
    public class CropIrrigationWeatherRecords
    {
    
        #region Consts
        #endregion

        #region Fields

        private int idCropIrrigationWeatherRecords;
        private CropIrrigationWeather cropIrrigationWeather;
        private List<DailyRecord> dailyRecords;
        private double growingDegreeDays;
        private double modifiedGrowingDegreeDays;
        private double totalEvapotranspirationCrop;
        private double totalEffectiveRain;
        private double totalIrrigation;
        private double hydricBalance;
        private double soilHydricVolume;
        private DateTime lastWaterInput;
        private double totalEvapotranspirationCropFromLastWaterInput;

        #endregion

        #region Properties

        public int IdCropIrrigationWeatherRecords
        {
            get { return idCropIrrigationWeatherRecords; }
            set { idCropIrrigationWeatherRecords = value; }
        }
        public CropIrrigationWeather CropIrrigationWeather
        {
            get { return cropIrrigationWeather; }
            set { cropIrrigationWeather = value; }
        }

        public List<DailyRecord> DailyRecords
        {
            get { return dailyRecords; }
            set { dailyRecords = value; }
        }

        public double GrowingDegreeDays
        {
            get { return growingDegreeDays; }
            set { growingDegreeDays = value; }
        }

        public double ModifiedGrowingDegreeDays
        {
            get { return modifiedGrowingDegreeDays; }
            set { modifiedGrowingDegreeDays = value; }
        }

        public double TotalEvapotranspirationCrop
        {
            get { return totalEvapotranspirationCrop; }
            set { totalEvapotranspirationCrop = value; }
        }

        public double TotalEffectiveRain
        {
            get { return totalEffectiveRain; }
            set { totalEffectiveRain = value; }
        }

        public double TotalIrrigation
        {
            get { return totalIrrigation; }
            set { totalIrrigation = value; }
        }
        
        public double HydricBalance
        {
            get { return hydricBalance; }
            set { hydricBalance = value; }
        }

        public double SoilHydricVolume
        {
            get { return soilHydricVolume; }
            set { soilHydricVolume = value; }
        }

        public DateTime LastWaterInput
        {
            get { return lastWaterInput; }
            set { lastWaterInput = value; }
        }

        public double TotalEvapotranspirationCropFromLastWaterInput
        {
            get { return totalEvapotranspirationCropFromLastWaterInput; }
            set { totalEvapotranspirationCropFromLastWaterInput = value; }
        }

        #endregion

        #region Construction

        public CropIrrigationWeatherRecords()
        {
            this.IdCropIrrigationWeatherRecords = 0;
            this.CropIrrigationWeather = new CropIrrigationWeather();
            this.DailyRecords = new List<DailyRecord>();
            this.GrowingDegreeDays = 0;
            this.ModifiedGrowingDegreeDays = 0;
            this.TotalEvapotranspirationCrop = 0;
            this.TotalEffectiveRain = 0;
            this.TotalIrrigation = 0;
            this.HydricBalance = 0;
            this.SoilHydricVolume = 0;
            this.LastWaterInput = DateTime.Now;
            this.TotalEvapotranspirationCropFromLastWaterInput = 0;

        }

        public CropIrrigationWeatherRecords(int pId, CropIrrigationWeather pCropIrrigationWeather,
            List<DailyRecord> pDailyRecords, double pGrowingDegreeDays,
            double pModifiedGrowingDegreeDays, double pTotalEvapotranspirationCrop,
            double pTotalEffectiveRain, double pTotalIrrigation, double pHidricBalance, double pSoilHidricVolume,
            DateTime pLastWaterInput, double pTotalEvapotranspirationCropFromLastWaterInput)
        {
            this.IdCropIrrigationWeatherRecords = pId;
            this.CropIrrigationWeather = pCropIrrigationWeather;
            this.DailyRecords = pDailyRecords;
            this.GrowingDegreeDays = pGrowingDegreeDays;
            this.ModifiedGrowingDegreeDays = pModifiedGrowingDegreeDays;
            this.TotalEvapotranspirationCrop = pTotalEvapotranspirationCrop;
            this.TotalEffectiveRain = pTotalEffectiveRain;
            this.TotalIrrigation = pTotalIrrigation;
            this.HydricBalance = pHidricBalance;
            this.SoilHydricVolume = pSoilHidricVolume;
            this.LastWaterInput = pLastWaterInput;
            this.TotalEvapotranspirationCropFromLastWaterInput = pTotalEvapotranspirationCropFromLastWaterInput;

        }

        #endregion

        #region Private Helpers

        private DateTime getLastWaterInputDate() 
        {
            DateTime lReturn = DateTime.MinValue;
            foreach (DailyRecord lDailyRec in this.DailyRecords)
            {
                if (lDailyRec.Irrigation.getTotalInput() > 0 && lDailyRec.DateHour > lReturn)
                {
                    lReturn= lDailyRec.DateHour;
                }
            }
            return lReturn;

        }

        /// <summary>
        /// Review the dailyRecords to set the data for: 
        /// - GrowingDegreeDays
        /// - ModifiedGrowingDegreeDays
        /// - TotalEvapotranspirationCrop
        /// - TotalEffectiveRain
        /// - TotalIrrigation
        /// - TotalEvapotranspirationCropFromLastWaterInput
        /// - LastWaterInput
        /// </summary>
        private void reviewResumeData()
        {
            double lGrowingDegreeDays = 0;
            double lModifiedGrowingDegreeDays = 0;
            double lTotalEvapotranspirationCrop = 0;
            double lTotalEffectiveRain = 0;
            double lTotalIrrigation =0;
            double lTotalEvapotranspirationCropFromLastWaterInput = 0;
            DateTime lLastWaterInput = this.getLastWaterInputDate(); 

            foreach (DailyRecord lDailyRec in this.DailyRecords)
            {
                lGrowingDegreeDays += lDailyRec.GrowingDegree;
                lModifiedGrowingDegreeDays += lDailyRec.ModifiedGrowingDegree;
                lTotalEvapotranspirationCrop += (lDailyRec.EvapotranspirationCrop.Input + lDailyRec.EvapotranspirationCrop.ExtraInput);
                lTotalEffectiveRain += lDailyRec.Rain.getTotalInput();
                lTotalIrrigation += lDailyRec.Irrigation.getTotalInput();
                if(lDailyRec.DateHour >= lLastWaterInput)
                {
                    lTotalEvapotranspirationCropFromLastWaterInput+= lDailyRec.EvapotranspirationCrop.getTotalInput();
                }
            }

            this.GrowingDegreeDays = lGrowingDegreeDays;
            this.ModifiedGrowingDegreeDays = lModifiedGrowingDegreeDays;
            this.TotalEvapotranspirationCrop = lTotalEvapotranspirationCrop;
            this.TotalEffectiveRain = lTotalEffectiveRain;
            this.TotalIrrigation = lTotalIrrigation;
            this.TotalEvapotranspirationCropFromLastWaterInput = lTotalEvapotranspirationCropFromLastWaterInput;
            this.LastWaterInput = lLastWaterInput;
        }
        

        #endregion

        #region Public Methods

        ///     - getPhenologicalStage(DayGrades: double): Stage
        ///     - setGrowingDegreeDays(): bool
        ///     - setPhenologicalState(Stage): bool
        ///     - setNewPhenologicalStage(Stage): GrowingDegreeDays: double
        ///     - getRootDepth(Specie, Stage): double
        ///     - getPhenologicalStage(GrowingDegreeDays: double): Stage
        ///     - getAvailableWater(RootDepth:double, FieldCapacity:double, PermanentWiltingPoint:double): double
        ///     - getHydricBalance(): double
        ///     - getSoilHydricVolume(): double

        public bool addDailyRecord(DailyRecord lDailyRecord)
        {
            bool lReturn = true;
            try
            {
                this.DailyRecords.Add(lDailyRecord);
                reviewResumeData();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in IrrigationSystem.addCropIrrigWeatherToList " + e.Message);
                //TODO manage and log the exception
                throw e;
            }
            return lReturn;
        }
/// <summary>
        /// Gives the effective rain registered in a specific date including the input and extraInput value.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public double getEffectiveRain(DateTime pDate)
        {
            double lRetrun = 0;

            foreach (DailyRecord lDailyRec in this.DailyRecords)
            {
                if (lDailyRec.DateHour.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRec.Rain.Input + lDailyRec.Rain.ExtraInput;
                    return lRetrun;
                }
            }
            return lRetrun;
        }
        /// <summary>
        /// Gives the growing degree registered in a specific date
        /// </summary>
        /// <param name="pDate">Date of the required information</param>
        /// <returns></returns>
        public double getGrowingDegree(DateTime pDate)
        {
            double lRetrun = 0;

            foreach (DailyRecord lDailyRec in this.DailyRecords)
            {
                if (lDailyRec.DateHour.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRec.GrowingDegree;
                    return lRetrun;
                }
            }
            return lRetrun;
        }
       /// <summary>
       /// Gives the evapoTranspiration registered in a specific date including the input and extraInput value.
       /// </summary>
       /// <param name="pDate"></param>
       /// <returns></returns>
        public double getEvapotranspirationCrop(DateTime pDate)
        {
            double lRetrun = 0;
            
            foreach (DailyRecord lDailyRec in this.DailyRecords)
            {
                if (lDailyRec.DateHour.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRec.EvapotranspirationCrop.Input + lDailyRec.EvapotranspirationCrop.ExtraInput;
                    return lRetrun;
                }
            }
            return lRetrun;
        }
        /// <summary>
        /// Gives the observation registered in a specific date.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public String getObservations(DateTime pDate)
        {
            String lRetrun = "";
            foreach(DailyRecord lDailyRec in this.DailyRecords)
            {
                if (lDailyRec.DateHour.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRec.Observations;
                    return lRetrun;
                }
            }
            return lRetrun;
        }
        /// <summary>
        /// Gives the evapoTranspiration registered in a Date and the two days before, including the input and extraInput value.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public double getLastThreeDaysOfEvapotranspirationCrop(DateTime pDate)
        {
            double lRetrun = 0;
            DateTime oneDayBefore = pDate.AddDays(-1);
            DateTime twoDaysBefore = pDate.AddDays(-2);

            foreach (DailyRecord lDailyRec in this.DailyRecords)
            {
                if (lDailyRec.DateHour.Date.Equals(pDate.Date) || lDailyRec.DateHour.Date.Equals(oneDayBefore.Date) ||
                    lDailyRec.DateHour.Date.Equals(twoDaysBefore.Date))
                {
                    lRetrun += lDailyRec.EvapotranspirationCrop.Input + lDailyRec.EvapotranspirationCrop.ExtraInput;
                }
            }
            return lRetrun;
        }
       


        #endregion

        #region Overrides
        #endregion
    }
}