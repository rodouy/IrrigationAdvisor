using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Weather;


namespace IrrigationAdvisor.Models.Management
{
    /// <summary>
    /// Create: 2014-10-27
    /// Author:  monicarle
    /// Modified: 2015-01-08
    /// Author:  monicarle
    /// Description: 
    ///     Is the fusion of: a WheatherStation, a Crop and an IrrigationUnit
    ///     
    /// References:
    ///     IrrigationUnit
    ///     Crop
    ///     WheatherStation
    ///     cropIrrigationWeatherRecord
    ///     PhenologicalStage
    ///     Soil
    ///     
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
    ///     - cropIrrigationWeatherRecordList  List<cropIrrigationWeatherRecord> 
    ///     - phenologicalStage PhenologicalStage
    ///     - sowingDate DateTime
    ///     - harvestDate DateTime
    ///     - soil Soil
    /// 
    /// Methods:
    ///     - CropIrrigationWeather()      -- constructor
    ///     - CropIrrigationWeather(irrigationUnit, crop, mainWeatherStation, alternativeWeatherStation,
    ///     )  -- consturctor with parameters
    ///     - getRegion(): Region
    ///     - getDaysAfterSowing(): int
    ///     - getBaseTemperature(): double
    ///     - getMaxEvapotranspirationToIrrigate(): double
    ///     - getRootDepth(): double
    ///     - getSoilPermanentWiltingPoint(): double
    ///     - getSoilAvailableWaterCapacity(): double
    ///     - getSoilFieldCapacity(): double
    ///     - getPercentageOfAvailableWater(): double
    ///     
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
        private Crop crop;
        private WeatherStation mainWeatherStation;
        private WeatherStation alternativeWeatherStation;
        private double predeterminatedIrrigationQuantity;
        private CropIrrigationWeatherRecord cropIrrigationWeatherRecord;
        private PhenologicalStage phenologicalStage;
        private Location location;
        private DateTime sowingDate;
        private DateTime harvestDate;
        private Soil soil;

        #endregion

        #region Properties

        public Irrigation.IrrigationUnit IrrigationUnit
        {
            get { return irrigationUnit; }
            set { irrigationUnit = value; }
        }

        public Crop Crop
        {
            get { return crop; }
            set { crop = value; }
        }
        
        public WeatherStation MainWeatherStation
        {
            get { return mainWeatherStation; }
            set { mainWeatherStation = value; }
        }
        
        public WeatherStation AlternativeWeatherStation
        {
            get { return alternativeWeatherStation; }
            set { alternativeWeatherStation = value; }
        }

        public double PredeterminatedIrrigationQuantity
        {
            get { return predeterminatedIrrigationQuantity; }
            set { predeterminatedIrrigationQuantity = value; }
        }

        public CropIrrigationWeatherRecord aCropIrrigationWeatherRecord
        {
            get { return cropIrrigationWeatherRecord; }
            set { cropIrrigationWeatherRecord = value; }
        }

        public PhenologicalStage PhenologicalStage
        {
            get { return phenologicalStage; }
            set { phenologicalStage = value; }
        }

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }

        public DateTime SowingDate
        {
            get { return sowingDate; }
            set { sowingDate = value; }
        }

        public DateTime HarvestDate
        {
            get { return harvestDate; }
            set { harvestDate = value; }
        }

        public Soil Soil
        {
            get { return soil; }
            set { soil = value; }
        }

        #endregion

        #region Construction

        public CropIrrigationWeather() 
        {
            this.IrrigationUnit = new Irrigation.IrrigationUnit();
            this.Crop = new Crop();
            this.MainWeatherStation = new WeatherStation();
            this.AlternativeWeatherStation = new WeatherStation();
            this.PredeterminatedIrrigationQuantity = 20;
            //this.cropIrrigationWeatherRecord = new cropIrrigationWeatherRecord();//La agrega sistema
            this.PhenologicalStage = new PhenologicalStage();
            this.Location = new Location();
            this.SowingDate = new DateTime();
            this.HarvestDate = new DateTime();
            this.Soil = new Soil();
        }

        public CropIrrigationWeather(Irrigation.IrrigationUnit pIrrigationUnit,
            Crop pCrop, WeatherStation pMainWeatherStation,
            WeatherStation pAlternativeWeatherStation,
            double pPredeterminatedIrrigationQuantity, 
            //cropIrrigationWeatherRecord pCropIrrigationWeatherRecordList,
            PhenologicalStage pPhenologicalStage, Location pLocation,
            DateTime pSowingDate, DateTime pHarvestDate, Soil pSoil)
        {
            this.IrrigationUnit = pIrrigationUnit;
            this.Crop = pCrop;
            this.MainWeatherStation = pMainWeatherStation;
            this.AlternativeWeatherStation = pAlternativeWeatherStation;
            this.PredeterminatedIrrigationQuantity = pPredeterminatedIrrigationQuantity;
            //this.cropIrrigationWeatherRecord = pCropIrrigationWeatherRecordList; //La agrega sistema
            this.PhenologicalStage = pPhenologicalStage;
            this.Location = pLocation;
            this.SowingDate = pSowingDate;
            this.HarvestDate = pHarvestDate;
            this.Soil = pSoil;
        }
        
        #endregion

        #region Private Helpers

        
        /// <summary>
        /// Change the PhenologicalStage of the crop depending of the growing degree acumulated plus the adjustment
        /// </summary>
        private void reviewPhenologicalStage()
        {
            PhenologicalStage lOldPhenStage = null;
            double lOldRootDepth = 0;
            PhenologicalStage lNewPhenStage = null;
            double lNewRootDepth = 0;
            double lModifiedGrowingDegreeDays;
            double lRootDepthDifference;
            double lPercentageOfAvailableWater;

            lOldPhenStage = this.PhenologicalStage;
            lOldRootDepth = this.getPhenologicalStageRootDepth(this.PhenologicalStage);

            //get the modified degrees days
            lModifiedGrowingDegreeDays = this.cropIrrigationWeatherRecord.ModifiedGrowingDegreeDays;
            //Get the percentage of availableWater before to actualize the phenology state 
            lPercentageOfAvailableWater = this.getPercentageOfAvailableWater();

            //Update Phenological Stage depending on the ModifiedGrowingDegreeDays
            this.UpdatePhenologicalStage(lModifiedGrowingDegreeDays);
            lNewRootDepth = this.getPhenologicalStageRootDepth(this.PhenologicalStage);
            lNewPhenStage = this.PhenologicalStage;

            //Si aumenta la profundidad de raiz agrego al balance hidrico el agua de la nueva 
            //parte del suelo que se considera (a Capacidad de campo)
            if (lOldPhenStage != null && lNewPhenStage != null && lOldRootDepth < lNewRootDepth)
            {
                //TODO get field capacity by horizon of soil (parameters: horizon depth, root depth difference)
                lRootDepthDifference = lNewRootDepth - lOldRootDepth;
                this.cropIrrigationWeatherRecord.HydricBalance += this.getFieldCapacity(lRootDepthDifference);
            }

            //Si disminuye la profundidad de raiz agrego al balance hidrico el agua de la nueva 
            //parte del suelo que se considera (a Capacidad de campo)
            if (lOldPhenStage != null && lNewPhenStage != null && lOldRootDepth > lNewRootDepth)
            {
                this.cropIrrigationWeatherRecord.HydricBalance = (this.getSoilAvailableWaterCapacity() * lPercentageOfAvailableWater / 100)
                                    + this.getSoilPermanentWiltingPoint();
            }
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
        private void reviewSummaryData(DailyRecord pDailyRec)
        {
            //double lRootDepth;
            double lFieldCapacity;
            int lDayAfterSowing;
            bool lThereIsWaterInput;

            double lRealRain;
            double lEffectiveRain;
            double lEffectiveIrrigation;
            double lIrrigationEfficiency;
            double lDaysAfterBigInputWater;

            lDayAfterSowing = this.cropIrrigationWeatherRecord.DayAfterSowing.First + 1;
            this.cropIrrigationWeatherRecord.DayAfterSowing = new Pair<int, DateTime>(lDayAfterSowing, pDailyRec.DateHour);
            this.cropIrrigationWeatherRecord.GrowingDegreeDays += pDailyRec.GrowingDegree;
            this.cropIrrigationWeatherRecord.ModifiedGrowingDegreeDays += pDailyRec.ModifiedGrowingDegree;


            lFieldCapacity = this.getSoilFieldCapacity();

            //To debug
            //if (pDailyRec.DateHour.Equals(new DateTime(2014, 12, 02)))
            //    return;



            // Evapotraspiration adjustment
            if (pDailyRec.EvapotranspirationCrop != null)
            {
                this.cropIrrigationWeatherRecord.TotalEvapotranspirationCrop += pDailyRec.EvapotranspirationCrop.getTotalInput();
                this.cropIrrigationWeatherRecord.HydricBalance -= pDailyRec.EvapotranspirationCrop.getTotalInput();
            }

            //Will show if there is Water Input (Rain or Irrigation)
            lThereIsWaterInput = false;

            // Rain adjustment
            if (pDailyRec.Rain != null)
            {
                lRealRain = pDailyRec.Rain.getTotalInput();
                //Calculate Rain Effective Value
                lEffectiveRain = this.cropIrrigationWeatherRecord.getEffectiveRainValue(pDailyRec.Rain);
                this.cropIrrigationWeatherRecord.TotalEffectiveRain += lEffectiveRain;
                this.cropIrrigationWeatherRecord.TotalRealRain += lRealRain;
                this.cropIrrigationWeatherRecord.HydricBalance += lEffectiveRain;

                // If the effective rain is bigger than 10 mm set the last water input
                if (lEffectiveRain > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    this.cropIrrigationWeatherRecord.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.getTotalInput();
                    this.cropIrrigationWeatherRecord.LastWaterInputDate = pDailyRec.DateHour;
                    lThereIsWaterInput = true;
                }

                if (this.cropIrrigationWeatherRecord.HydricBalance >= lFieldCapacity)
                {
                    //We have to save the date to keep the hidric balance unchangable
                    this.cropIrrigationWeatherRecord.LastBigWaterInputDate = pDailyRec.DateHour;
                }
            }

            // Irrigation adjustment
            if (pDailyRec.Irrigation != null)
            {
                // Calculate de effective irrigation depending on the irrigatioin efficiency of the Pivot
                lIrrigationEfficiency = this.IrrigationUnit.IrrigationEfficiency;
                this.cropIrrigationWeatherRecord.TotalIrrigation += pDailyRec.Irrigation.Input * lIrrigationEfficiency;
                this.cropIrrigationWeatherRecord.TotalExtraIrrigation += pDailyRec.Irrigation.ExtraInput * lIrrigationEfficiency;
                lEffectiveIrrigation = pDailyRec.Irrigation.getTotalInput() * lIrrigationEfficiency;
                this.cropIrrigationWeatherRecord.HydricBalance += lEffectiveIrrigation;

                // If the irrigation is bigger than 10 mm set the last water input
                if (lEffectiveIrrigation > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    this.cropIrrigationWeatherRecord.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.getTotalInput();
                    this.cropIrrigationWeatherRecord.LastWaterInputDate = pDailyRec.DateHour;
                    lThereIsWaterInput = true;
                }

            }

            // If the HidricBalance is bigger than the FieldCapacity set the HidricBalance as de FieldCapacity
            if (this.cropIrrigationWeatherRecord.HydricBalance >= lFieldCapacity)
            {
                this.cropIrrigationWeatherRecord.HydricBalance = lFieldCapacity;
            }

            //TotalEvapotranspirationCropFromLastWaterInput adjustment
            if (!lThereIsWaterInput)
            {
                this.cropIrrigationWeatherRecord.TotalEvapotranspirationCropFromLastWaterInput += pDailyRec.EvapotranspirationCrop.getTotalInput();
            }

            //Update the Phenological Stage depending in Growing Degree
            reviewPhenologicalStage();

            lFieldCapacity = this.getSoilFieldCapacity();

            //After a big rain the HidricBalance keep its value = FieldCapacity for two days
            lDaysAfterBigInputWater = Utilities.Utils.getDaysDifference(this.cropIrrigationWeatherRecord.LastBigWaterInputDate, pDailyRec.DateHour);
            if (lDaysAfterBigInputWater <= InitialTables.DAYS_HIDRIC_BALANCE_UNCHANGABLE_AFTER_BIG_WATER_INPUT)
            {
                this.cropIrrigationWeatherRecord.HydricBalance = lFieldCapacity;
            }

            //The first days after sowing, hydric balance is maintained at field capacity
            if (lDayAfterSowing <= InitialTables.DAYS_HIDRIC_BALANCE_UNCHANGABLE_AFTER_SOWING)
            {
                this.cropIrrigationWeatherRecord.HydricBalance = lFieldCapacity;
            }
        }


        private void takeOffDailyRecord(DailyRecord lRecordToDelete)
        {
            ///TODO Ajustar los datos de resumen: agregar etc y sacar rain y riego a los totales (proceso inverso a agregar uno)
            int lDayAfterSowing;
            DateTime lDateOfDayAfterSowing;

            lDayAfterSowing = this.cropIrrigationWeatherRecord.DayAfterSowing.First - 1;
            lDateOfDayAfterSowing = this.cropIrrigationWeatherRecord.DayAfterSowing.Second.AddDays(-1);
            this.cropIrrigationWeatherRecord.DayAfterSowing = new Pair<int, DateTime>(lDayAfterSowing, lDateOfDayAfterSowing);
            // Evapotraspiration revert
            if (lRecordToDelete.EvapotranspirationCrop != null)
            {
                this.cropIrrigationWeatherRecord.TotalEvapotranspirationCrop -= lRecordToDelete.EvapotranspirationCrop.getTotalInput();
                this.cropIrrigationWeatherRecord.HydricBalance += lRecordToDelete.EvapotranspirationCrop.getTotalInput();
            }

            // Rain revert
            if (lRecordToDelete.Rain != null)
            {
                double lEffectiveRain = lRecordToDelete.Rain.getTotalInput();
                double lRealRain = lRecordToDelete.Rain.getTotalInput();
                this.cropIrrigationWeatherRecord.TotalEffectiveRain -= lEffectiveRain;
                this.cropIrrigationWeatherRecord.TotalRealRain -= lRealRain;
                this.cropIrrigationWeatherRecord.HydricBalance -= lEffectiveRain;
                // If the effective rain is bigger than 10 mm set the last water input
                //if (lRecordToDelete.Rain.Input > 10)
                //{
                //    this.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.getTotalInput();
                //    this.LastWaterInput = pDailyRec.DateHour;
                //    lThereIsWaterInput = true;
                //}
            }

            // Irrigation revert
            if (lRecordToDelete.Irrigation != null)
            {
                //TODO verificar que el riego sea mayor a 10 mm para setear lThereIsWaterInput = true
                this.cropIrrigationWeatherRecord.TotalIrrigation -= lRecordToDelete.Irrigation.Input;
                this.cropIrrigationWeatherRecord.TotalExtraIrrigation -= lRecordToDelete.Irrigation.ExtraInput;
                this.cropIrrigationWeatherRecord.HydricBalance -= lRecordToDelete.Irrigation.getTotalInput();
                //lThereIsWaterInput = true;
            }
            // If the HidricBalance is bigger than the FieldCapacity set the HidricBalance as de FieldCapacity
            /*if (HydricBalance >= lFieldCapacity)
            {
                this.HydricBalance = lFieldCapacity; ///CAMBIO 2
                this.LastBigWaterInput = pDailyRec.DateHour;
            }

            //After a big rain the HidricBalance keep its value = FieldCapacity for two days
            if (Utilities.Utils.getDaysDifference(this.LastBigWaterInput, pDailyRec.DateHour) < 3 && this.HydricBalance < lFieldCapacity)
            {
                this.HydricBalance = lFieldCapacity;
            }

            if (!lThereIsWaterInput)
            {
                this.TotalEvapotranspirationCropFromLastWaterInput += pDailyRec.EvapotranspirationCrop.getTotalInput();
            }
             */

            // GrowingDegreeDays revert
            this.cropIrrigationWeatherRecord.GrowingDegreeDays -= lRecordToDelete.GrowingDegree;
            this.cropIrrigationWeatherRecord.ModifiedGrowingDegreeDays -= lRecordToDelete.ModifiedGrowingDegree;
            ////////////////////////////

        }

        /// <summary>
        /// Add a Daily Record 
        /// </summary>
        /// <param name="pDailyRecord"></param>
        /// <returns></returns>
        private bool addDailyRecord(DailyRecord pDailyRecord)
        {
            bool lReturn = true;
            int lDays = 0;
            try
            {
                lDays = Utilities.Utils.getDaysDifference(this.SowingDate, pDailyRecord.DateHour);
                //If it's the initial registry set the initial Hidric Balance
                if (lDays == 0)
                {
                    this.cropIrrigationWeatherRecord.HydricBalance = this.getInitialHidricBalance();
                    this.cropIrrigationWeatherRecord.DayAfterSowing = new Pair<int, DateTime>(-1, this.SowingDate);
                }
                // this way part form the last state (day before)
                reviewSummaryData(pDailyRecord);

                this.cropIrrigationWeatherRecord.DailyRecords.Add(pDailyRecord);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in IrrigationSystem.addCropIrrigWeatherToList " + e.Message);
                //TODO manage and log the exception
                throw e;
            }
            return lReturn;
        }

        
        #endregion

        #region Public Methods

        /// <summary>
        /// Get Region from Crop
        /// </summary>
        /// <returns></returns>
        public Region getRegion() 
        {
            Region lRegion;
            lRegion = this.IrrigationUnit.Location.Region;
            return lRegion;
        }

        /// <summary>
        /// Get Days After Sowing DateTime
        /// </summary>
        /// <returns></returns>
        public int getDaysAfterSowing()
        {
            int lDaysAfterSowing;
            DateTime lSowingDate;
            lSowingDate = this.SowingDate;
            lDaysAfterSowing = DateTime.Now.Subtract(lSowingDate).Days;
            return lDaysAfterSowing;
        }

        /// <summary>
        /// Get Base Temperature from Crop
        /// </summary>
        /// <returns></returns>
        public double getBaseTemperature() 
        {
            double lReturn;
            lReturn = this.Crop.getBaseTemperature();
            return lReturn;
        }

        /// <summary>
        /// Get Max Evapotranspiration to Irrigate from Crop
        /// </summary>
        /// <returns></returns>
        public double getMaxEvapotranspirationToIrrigate()
        {
            double lReturn;
            lReturn = this.Crop.MaxEvapotranspirationToIrrigate;
            return lReturn;
        }

        /// <summary>
        /// Get Root Depth from Crop Phenological Stage
        /// </summary>
        /// <returns></returns>
        public double getPhenologicalStageRootDepth(PhenologicalStage pPhenologicalStage)
        {
            double lRootDepth;
            lRootDepth = pPhenologicalStage.RootDepth;
            if (lRootDepth > this.Soil.DepthLimit)
            {
                lRootDepth = this.Soil.DepthLimit;
            }
            return lRootDepth;
        }

        /// <summary>
        /// Get the Field Capacity by Root Depth from this Soil
        /// </summary>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
        public double getFieldCapacity(double pRootDepth)
        {
            double lReturn;
            lReturn = this.Soil.getFieldCapacity(pRootDepth);
            return lReturn;
        }

        #region SoilData

        /// <summary>
        /// Get Soil Permanent Wilting Poing
        /// The data is obtained from Soil depending Root Depth
        /// </summary>
        /// <returns></returns>
        public double getSoilPermanentWiltingPoint()
        {
            double lRootDepth;
            double lSoilPermanentWiltingPoint;

            lRootDepth = this.getPhenologicalStageRootDepth(this.PhenologicalStage);
            lSoilPermanentWiltingPoint = this.Soil.getPermanentWiltingPoint(lRootDepth);
            return lSoilPermanentWiltingPoint;
        }

        /// <summary>
        /// Get Soil Available Water Capacity 
        /// From Crop Soil by Root Depth 
        /// </summary>
        /// <returns></returns>
        public double getSoilAvailableWaterCapacity()
        {
            double lRootDepth;
            double lSoilAvailableWaterCapacity;

            lRootDepth = this.getPhenologicalStageRootDepth(this.PhenologicalStage);
            lSoilAvailableWaterCapacity = this.Soil.getAvailableWaterCapacity(lRootDepth);
            return lSoilAvailableWaterCapacity;
        }

        /// <summary>
        /// Get Soil Field Capacity
        /// From Crop Soil by Root Depth
        /// </summary>
        /// <returns></returns>
        public double getSoilFieldCapacity()
        {
            double lReturn;
            double lRootDepth = this.getPhenologicalStageRootDepth(this.PhenologicalStage);
            lReturn = this.Soil.getFieldCapacity(lRootDepth);
            return lReturn;
        }

        #endregion

        /// <summary>
        /// Get Available Water from Hydric Balance vs Field Capacity
        /// </summary>
        /// <returns></returns>
        public double getPercentageOfAvailableWater()
        {
            double lHidricBalance;
            double lFieldCapacity;
            double lPermanentWiltingPoint;
            double lPercentageOfAvailableWater;

            lHidricBalance = this.cropIrrigationWeatherRecord.HydricBalance;
            lFieldCapacity = this.getSoilFieldCapacity();
            lPermanentWiltingPoint = this.getSoilPermanentWiltingPoint();

            lPercentageOfAvailableWater = Math.Round(((lHidricBalance - lPermanentWiltingPoint) * 100)
                                        / (lFieldCapacity - lPermanentWiltingPoint), 2);
            return lPercentageOfAvailableWater;
        }

        /// <summary>
        /// Get Initial Hidric Balance 
        /// (Fiel Capacity for Initial Root Depth)
        /// </summary>
        /// <returns></returns>
        public double getInitialHidricBalance()
        {
            double lReturn = 0;
            double lFieldCapacity = 0;
            
            lFieldCapacity = this.getFieldCapacity(InitialTables.INITIAL_ROOT_DEPTH);
            lReturn = lFieldCapacity;
            return lReturn;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lModifiedGrowingDegreeDays"></param>
        /// <returns></returns>
        public PhenologicalStage UpdatePhenologicalStage(double lModifiedGrowingDegreeDays)
        {
            List<PhenologicalStage> lPhenologicalStageList;
            IEnumerable<PhenologicalStage> lPhenologicalTableOrderByMinDegree;
            PhenologicalStage lNewPhenStage = null;

            //Order the phenological table
            lPhenologicalStageList = this.Crop.Specie.PhenologicalStages;
            lPhenologicalTableOrderByMinDegree = lPhenologicalStageList.OrderBy(lPhenologicalStage => lPhenologicalStage.MinDegree);

            foreach (PhenologicalStage lPhenStage in lPhenologicalTableOrderByMinDegree)
            {
                if (lPhenStage != null && lPhenStage.Specie.Equals(this.Crop.Specie) && lPhenStage.MinDegree <= lModifiedGrowingDegreeDays
                    && lPhenStage.MaxDegree >= lModifiedGrowingDegreeDays)
                {
                    this.PhenologicalStage = lPhenStage;
                    lNewPhenStage = lPhenStage;
                    return lNewPhenStage;
                }
            }

            return lNewPhenStage;
        }

        /// <summary>
        /// TODO explain addDailyRecord
        /// 
        /// </summary>
        /// <param name="pWeatherData"></param>
        /// <param name="pMainWeatherData"></param>
        /// <param name="pAlternativeWeatherData"></param>
        /// <param name="pRain"></param>
        /// <param name="pIrrigation"></param>
        /// <param name="pObservations"></param>
        public void addDailyRecord(WeatherData pWeatherData, 
            WeatherData pMainWeatherData, 
            WeatherData pAlternativeWeatherData, 
            Water.WaterInput pRain, Water.WaterInput pIrrigation, string pObservations)
        {
            try
            {
                double lAverageTemp;
                double lEvapotranspiration;
                double lBaseTemperature;
                double lGrowingDegree;
                double lGrowingDegreeAcumulated;
                int lDays;
                double lKC_CropCoefficient;
                double lRealEvapotraspiration;
                WaterOutput lEvapotranspirationCrop;
                DailyRecord lNewDailyRecord;

                lAverageTemp = pWeatherData.getAverageTemperature();
                lEvapotranspiration = pWeatherData.getEvapotranspiration();
                lBaseTemperature = this.getBaseTemperature();
                //Growing Degree is average temperature menous Base Temperature
                lGrowingDegree = lAverageTemp - lBaseTemperature;
                lGrowingDegreeAcumulated = this.cropIrrigationWeatherRecord.GrowingDegreeDays + lGrowingDegree;

                //Get days after sowing for Modified Growing Degree
                lDays = this.cropIrrigationWeatherRecord.getDaysAfterSowingForModifiedGrowingDegree();

                if (lDays == 0)
                {
                    Utils.getDaysDifference(this.SowingDate, pWeatherData.Date);
                }

                lKC_CropCoefficient = this.Crop.Specie.CropCoefficient.getKC(lDays);
                lRealEvapotraspiration = lEvapotranspiration * lKC_CropCoefficient;
                lEvapotranspirationCrop = new EvapotranspirationCrop(
                    this, pWeatherData.Date, lRealEvapotraspiration);

                lNewDailyRecord = new DailyRecord(
                    pMainWeatherData, pAlternativeWeatherData, pWeatherData.Date,
                    lGrowingDegree, lGrowingDegreeAcumulated, lGrowingDegree,
                    lKC_CropCoefficient, lEvapotranspirationCrop, pRain, pIrrigation,
                    pObservations);


                //TODO extract to a new method as "VerifyUnicityOFDailyRecord"
                //Verify if exist an older Daily Record, and if exists, replece it
                int indexToRemove = -1;
                DailyRecord lRecordToDelete = null;
                int i = 0;
                foreach (DailyRecord lDailyRecord in this.cropIrrigationWeatherRecord.DailyRecords)
                {
                    if (Utils.isTheSameDay(lDailyRecord.DateHour.Date, pWeatherData.Date))
                    {
                        indexToRemove = i;
                        lRecordToDelete = lDailyRecord;
                    }
                    i++;
                }
                //We have a unique record by day
                if (indexToRemove != -1)
                {
                    takeOffDailyRecord(lRecordToDelete);
                    this.cropIrrigationWeatherRecord.DailyRecords.RemoveAt(indexToRemove);
                }

                this.addDailyRecord(lNewDailyRecord);
                this.cropIrrigationWeatherRecord.OutPut += this.cropIrrigationWeatherRecord.printState();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// TODO explain adjustmentPhenology
        /// </summary>
        /// <param name="pStage"></param>
        /// <param name="pDateTime"></param>
        /// <param name="lModification"></param>
        public void adjustmentPhenology(Stage pStage, DateTime pDateTime, double lModification)
        {
            foreach (DailyRecord lDailyRec in this.cropIrrigationWeatherRecord.DailyRecords)
            {
                if (Utils.isTheSameDay(pDateTime, lDailyRec.DateHour))
                {
                    lDailyRec.ModifiedGrowingDegree += lModification;// +lDailyRec.ModifiedGrowingDegree;
                    this.cropIrrigationWeatherRecord.ModifiedGrowingDegreeDays += lModification;
                }
            }
        }




        /// <summary>
        /// Gives the effective rain registered in a specific date including the input and extraInput value.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public double getEffectiveRain(DateTime pDate)
        {
            double lRetrun = 0;

            foreach (DailyRecord lDailyRec in this.cropIrrigationWeatherRecord.DailyRecords)
            {
                if (lDailyRec.DateHour.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRec.Rain.Input + lDailyRec.Rain.ExtraInput;
                    return lRetrun;
                }
            }
            return lRetrun;
        }
        public double getHydricBalance()
        {
            double lReturn = 0;
            lReturn = this.cropIrrigationWeatherRecord.HydricBalance;
            return lReturn;
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