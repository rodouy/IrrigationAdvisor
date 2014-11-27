using IrrigationAdvisor.Models.Crop;
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
            this.HydricBalance = this.getInitialHidricBalance();
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
        /// <summary>
        /// Return the most recently date of water input 
        /// </summary>
        /// <returns></returns>
        private DateTime getLastWaterInputDate() 
        {
            DateTime lReturn = DateTime.MinValue;
            foreach (DailyRecord lDailyRec in this.DailyRecords)
            {
                if (lDailyRec.Irrigation != null && lDailyRec.Irrigation.getTotalInput() > 0 && lDailyRec.DateHour > lReturn)
                {
                    lReturn= lDailyRec.DateHour;
                }
                if (lDailyRec.Rain != null && lDailyRec.Rain.getTotalInput() > 10 && lDailyRec.DateHour > lReturn)
                {
                    lReturn = lDailyRec.DateHour;
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
            double lHidricBalance = this.getInitialHidricBalance();
            double lTotalEvapotranspirationCropFromLastWaterInput = 0;
            DateTime lLastWaterInput = this.getLastWaterInputDate();

            IEnumerable<DailyRecord> query = this.DailyRecords.OrderBy(lDailyRec => lDailyRec.DateHour);
            foreach (DailyRecord lDailyRec in query)
            {
                lGrowingDegreeDays += lDailyRec.GrowingDegree;
                lModifiedGrowingDegreeDays += lDailyRec.ModifiedGrowingDegree;
                if (lDailyRec.EvapotranspirationCrop !=null)
                {
                    lTotalEvapotranspirationCrop += lDailyRec.EvapotranspirationCrop.getTotalInput();
                    lHidricBalance -= lDailyRec.EvapotranspirationCrop.getTotalInput();
                }
                if (lDailyRec.Rain != null)
                {
                    double lRootDepth = this.CropIrrigationWeather.Crop.PhenologicalStage.RootDepth;
                    double lFieldCapacity = this.CropIrrigationWeather.Crop.Soil.getFieldCapacity(lRootDepth);

                    if (lDailyRec.Rain.getTotalInput() > lFieldCapacity)
                    {

                        lTotalEffectiveRain += lFieldCapacity;
                        lHidricBalance += lFieldCapacity;
                
                    }
                    else
                    {
                        lTotalEffectiveRain += lDailyRec.Rain.getTotalInput();
                        lHidricBalance += lDailyRec.Rain.getTotalInput();
                    }
                    
                }
                if (lDailyRec.Irrigation != null)
                {
                    lTotalIrrigation += lDailyRec.Irrigation.getTotalInput();
                    lHidricBalance += lDailyRec.Irrigation.getTotalInput();
                
                }
                if (lDailyRec.DateHour >= lLastWaterInput)
                {
                    lTotalEvapotranspirationCropFromLastWaterInput+= lDailyRec.EvapotranspirationCrop.getTotalInput();
                }
            }

            this.GrowingDegreeDays = lGrowingDegreeDays;
            this.ModifiedGrowingDegreeDays = lModifiedGrowingDegreeDays;
            this.TotalEvapotranspirationCrop = lTotalEvapotranspirationCrop;
            this.TotalEffectiveRain = lTotalEffectiveRain;
            this.TotalIrrigation = lTotalIrrigation;
            this.HydricBalance = lHidricBalance;
            this.TotalEvapotranspirationCropFromLastWaterInput = lTotalEvapotranspirationCropFromLastWaterInput;
            this.LastWaterInput = lLastWaterInput;

            reviewPhenologicalStage();
        }

        private void reviewPhenologicalStage()
        {
            List<PhenologicalStage> lPhenologicalStageList = this.CropIrrigationWeather.Crop.PhenologicalStageList;
            IEnumerable<PhenologicalStage> query = lPhenologicalStageList.OrderBy(lPhenologicalStage => lPhenologicalStage.MinDegree);
            double lDegree = this.GrowingDegreeDays + this.ModifiedGrowingDegreeDays;
            foreach (PhenologicalStage lPhenStage in query)
            {
                if (lPhenStage != null && lPhenStage.Specie.Equals(this.CropIrrigationWeather.Crop.Specie) && lPhenStage.MinDegree <= lDegree && lPhenStage.MaxDegree >= lDegree)
                {
                    this.CropIrrigationWeather.Crop.PhenologicalStage = lPhenStage;
                }
            }

        }
        #endregion

        #region Public Methods

        ///     - getPhenologicalStage(DayGrades: double): Stage
        ///     - setGrowingDegreeDays(): bool
        ///     - setPhenologicalState(Stage): bool
        ///     - setNewPhenologicalStage(Stage): GrowingDegreeDays: double
        ///     - getPhenologicalStage(GrowingDegreeDays: double): Stage
        ///     - getAvailableWater(RootDepth:double, FieldCapacity:double, PermanentWiltingPoint:double): double
        ///     - getHydricBalance(): double
        ///     - getSoilHydricVolume(): double

        public double getInitialHidricBalance()
        {
            double lReturn = 0;
            double lRootDepth = 5;// this.getRootDepth();
            double lFieldCapacity = this.CropIrrigationWeather.Crop.getFieldCapacity(lRootDepth);
            lReturn = lFieldCapacity * lRootDepth / 10;
            return lReturn;
        }

        public double getRootDepth()
        {
            return this.CropIrrigationWeather.Crop.PhenologicalStage.RootDepth;

        }
        

        public bool addDailyRecord(DailyRecord lDailyRecord)
        {
            bool lReturn = true;
            try
            {
                //If it's the initial registry set the initial Hidric Balance
                if(lDailyRecord.getDaysAfterSowing() == 0)
                {
                    double lRootDepth = this.getRootDepth();
                    double lFieldCapacity = this.CropIrrigationWeather.Crop.getFieldCapacity(lRootDepth);
                    this.HydricBalance = this.getInitialHidricBalance();
                }
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