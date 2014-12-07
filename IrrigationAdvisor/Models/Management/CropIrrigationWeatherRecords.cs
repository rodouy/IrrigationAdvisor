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
    ///     - lastBigWaterInput: Date
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
        private double INITIAL_ROOT_DEPTH = 5;
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
        private DateTime lastBigWaterInput;
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

        public DateTime LastBigWaterInput
        {
            get { return lastBigWaterInput; }
            set { lastBigWaterInput = value; }
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
        
        /// <summary>
        /// Set the new values (after to add a new dailyRecord) for the variables used to resume the state of the crop.
        /// Use the last state (day before) to calculate the new state
        /// </summary>
        private void reviewResumeData(DailyRecord pDailyRec)
        {
            bool thereIsWaterInput = false;
            if (pDailyRec.EvapotranspirationCrop !=null)
            {
                  TotalEvapotranspirationCrop += pDailyRec.EvapotranspirationCrop.getTotalInput();
                  this.HydricBalance -= pDailyRec.EvapotranspirationCrop.getTotalInput();
            }
            if (pDailyRec.Rain != null)
            {
                

                // If the rain is bigger than 10 mm set the last water input
                if (pDailyRec.Rain.getTotalInput() > 10)
                {
                    this.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.getTotalInput();
                    this.LastWaterInput = pDailyRec.DateHour;
                    thereIsWaterInput = true;
                }
                double lEffectiveRain = pDailyRec.Rain.getTotalInput();
                this.TotalEffectiveRain += lEffectiveRain;
                this.HydricBalance += lEffectiveRain;

                // If the HidricBalance is bigger than the FieldCapacity set the HidricBalance as de FieldCapacity
                double lRootDepth = this.CropIrrigationWeather.Crop.PhenologicalStage.RootDepth;
                double lFieldCapacity = this.CropIrrigationWeather.Crop.Soil.getFieldCapacity(lRootDepth);
                if (HydricBalance > lFieldCapacity)
                {
                    this.HydricBalance = lFieldCapacity;
                    this.LastBigWaterInput = pDailyRec.DateHour;
                }
                //After a big rain the HidricBalance keep its value = FieldCapacity for two days
                if(Utilities.Utils.getDaysDifference(this.LastBigWaterInput,pDailyRec.DateHour)<2)
                {
                    this.HydricBalance = lFieldCapacity;
                }
                
            }
            if (pDailyRec.Irrigation != null)
            {
                this.TotalIrrigation += pDailyRec.Irrigation.getTotalInput();
                this.HydricBalance += pDailyRec.Irrigation.getTotalInput();
                thereIsWaterInput = true;
            }

            if(!thereIsWaterInput)
            {
                this.TotalEvapotranspirationCropFromLastWaterInput += pDailyRec.EvapotranspirationCrop.getTotalInput();
            }
            this.GrowingDegreeDays += pDailyRec.GrowingDegree;
            this.ModifiedGrowingDegreeDays += pDailyRec.ModifiedGrowingDegree;
            
            reviewPhenologicalStage();
        }

        
        /// <summary>
        /// Set the new values (after to add a new dailyRecord) for the variables used to resume the state of the crop.
        /// Not use the last state (day before) to calculate the new state.
        /// Recalculate from 0 using the list of DailyRecords
        /// </summary>
        private void reviewResumeData()
        {
            this.GrowingDegreeDays = 0;
            this.ModifiedGrowingDegreeDays = 0;
            this.TotalEvapotranspirationCrop = 0;
            this.TotalEffectiveRain = 0;
            this.TotalIrrigation = 0;
            this.HydricBalance = this.getInitialHidricBalance();
            this.TotalEvapotranspirationCropFromLastWaterInput = 0;
            this.LastWaterInput = this.getLastWaterInputDate();

            DateTime lLastWaterInput = this.getLastWaterInputDate();
            Specie lSpecie = this.cropIrrigationWeather.Crop.Specie;
            this.cropIrrigationWeather.Crop.PhenologicalStage = new PhenologicalStage(1, lSpecie, new Stage(1, "v0", "Sin hojas"), 0, 60, 5);
            

            IEnumerable<DailyRecord> query = this.DailyRecords.OrderBy(lDailyRec => lDailyRec.DateHour);
            foreach (DailyRecord lDailyRec in query)
            {
                this.GrowingDegreeDays += lDailyRec.GrowingDegree;
                this.ModifiedGrowingDegreeDays += lDailyRec.ModifiedGrowingDegree;
                if (lDailyRec.EvapotranspirationCrop !=null)
                {
                    this.TotalEvapotranspirationCrop += lDailyRec.EvapotranspirationCrop.getTotalInput();
                    this.HydricBalance -= lDailyRec.EvapotranspirationCrop.getTotalInput();
                }
                if (lDailyRec.Rain != null)
                {
                    double lRootDepth = this.CropIrrigationWeather.Crop.PhenologicalStage.RootDepth;
                    double lFieldCapacity = this.CropIrrigationWeather.Crop.Soil.getFieldCapacity(lRootDepth);

                    if (lDailyRec.Rain.getTotalInput() > lFieldCapacity)
                    {

                        this.TotalEffectiveRain += lFieldCapacity;
                        this.HydricBalance += lFieldCapacity;
                
                    }
                    else
                    {
                        this.totalEffectiveRain += lDailyRec.Rain.getTotalInput();
                        this.HydricBalance += lDailyRec.Rain.getTotalInput();
                    }
                    
                }
                if (lDailyRec.Irrigation != null)
                {
                    this.TotalIrrigation += lDailyRec.Irrigation.getTotalInput();
                    this.HydricBalance += lDailyRec.Irrigation.getTotalInput();
                
                }
                if (lDailyRec.DateHour >= lLastWaterInput)
                {
                    this.TotalEvapotranspirationCropFromLastWaterInput+= lDailyRec.EvapotranspirationCrop.getTotalInput();
                }
                reviewPhenologicalStage();
            }



            reviewPhenologicalStage();
        }
        
        /// <summary>
        /// Change the PhenologicalStage of the crop depending of the growing degree acumulated plus the adjustment
        /// </summary>
        private void reviewPhenologicalStage()
        {
            List<PhenologicalStage> lPhenologicalStageList = this.CropIrrigationWeather.Crop.PhenologicalStageList;
            IEnumerable<PhenologicalStage> query = lPhenologicalStageList.OrderBy(lPhenologicalStage => lPhenologicalStage.MinDegree);
            double lDegree = this.ModifiedGrowingDegreeDays;
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
            double lFieldCapacity = this.CropIrrigationWeather.Crop.getFieldCapacity(INITIAL_ROOT_DEPTH);
            lReturn = lFieldCapacity * INITIAL_ROOT_DEPTH / 10;
            return lReturn;
        }

        public double getRootDepth()
        {
            return this.CropIrrigationWeather.Crop.PhenologicalStage.RootDepth;

        }
        

        private  bool addDailyRecord(DailyRecord lDailyRecord)
        {
            bool lReturn = true;
            try
            {
                int days = Utilities.Utils.getDaysDifference(this.CropIrrigationWeather.Crop.SowingDate, lDailyRecord.DateHour);
                //If it's the initial registry set the initial Hidric Balance
                if(days == 0)
                {
                    double lRootDepth = this.getRootDepth();
                    double lFieldCapacity = this.CropIrrigationWeather.Crop.getFieldCapacity(lRootDepth);
                    this.HydricBalance = this.getInitialHidricBalance();
                }
                this.DailyRecords.Add(lDailyRecord);
                reviewResumeData(lDailyRecord); // this way part form the last state (day before)
                //reviewResumeData(); // this way recalculate all

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

        public void addDailyRecord(WeatherStation.WeatherData lWeatherData, WeatherStation.WeatherData lMainWeatherData, WeatherStation.WeatherData lAlternativeWeatherData, Water.WaterInput lRain, Water.WaterInput lIrrigation, string pObservations)
        {
            double lAverageTemp = lWeatherData.getAverageTemperature();
            double lEvapotranspiration = lWeatherData.getEvapotranspiration();
            double lBaseTemperature = this.CropIrrigationWeather.Crop.getBaseTemperature();
            double lGrowingDegree = lAverageTemp - lBaseTemperature;
            int lDays = this.getDaysForModifiedGrowingDegree();
            double lKC_CropCoefficient = this.CropIrrigationWeather.Crop.CropCoefficient.getKC(lDays);
            double lRealEvapotraspiration = lEvapotranspiration * lKC_CropCoefficient;
            Water.WaterOutput lEvapotranspirationCrop = new Water.EvapotranspirationCrop(this.CropIrrigationWeather, lWeatherData.Date, lRealEvapotraspiration);
            
            DailyRecord lNewDailyRecord = new DailyRecord(lMainWeatherData, lAlternativeWeatherData, lWeatherData.Date, lGrowingDegree, lGrowingDegree,
               lEvapotranspirationCrop, lRain, lIrrigation, pObservations);

            int indexToRemove = -1;
            int i = 0;
            foreach (DailyRecord lDailyRecord in this.dailyRecords)
            {
                if (Utilities.Utils.isTheSameDay(lDailyRecord.DateHour.Date, lWeatherData.Date))
                {
                    indexToRemove = i;
                }
                i++;
            }

            if (indexToRemove != -1)
            {
                this.dailyRecords.RemoveAt(indexToRemove);
                ///TODO Ajustar los datos de resumen: agregar etc y sacar rain y riego a los totales
            }
            this.addDailyRecord(lNewDailyRecord);
            
        }

        private int getDaysForModifiedGrowingDegree()
        {
            int lReturn = 0;
            double lastGDRegistry = 0;
            DateTime lDate = DateTime.MinValue;
            foreach (DailyRecord lDailyRec in this.DailyRecords)
            {
                if (this.ModifiedGrowingDegreeDays < lDailyRec.GrowingDegree && this.ModifiedGrowingDegreeDays> lastGDRegistry)
                {
                    lDate = lDate.Date;
                    lReturn = Utilities.Utils.getDaysDifference(this.CropIrrigationWeather.Crop.SowingDate, lDate);
                    return lReturn;
                }
                lastGDRegistry = lDailyRec.GrowingDegree;
            }
            return lReturn;
        }


        public void adjustmentPhenology(Stage pStage, DateTime pDateTime, double lModification)
        {
            foreach (DailyRecord lDailyRec in this.DailyRecords)
            {
                if (Utilities.Utils.isTheSameDay(pDateTime, lDailyRec.DateHour))
                {
                    lDailyRec.ModifiedGrowingDegree += lModification;// +lDailyRec.ModifiedGrowingDegree;
                    this.ModifiedGrowingDegreeDays += lModification;
                }
            }
        }
        #endregion

        #region Overrides
        #endregion



       
    }
}