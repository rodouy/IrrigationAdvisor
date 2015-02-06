﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.Models.Irrigation;


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
    ///     - GetRegion(): Region
    ///     - GetDaysAfterSowing(): int
    ///     - GetBaseTemperature(): double
    ///     - GetMaxEvapotranspirationToIrrigate(): double
    ///     - GetRootDepth(): double
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

        private long idCropIrrigationWeather;
        private IrrigationUnit irrigationUnit;
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

        public long IdCropIrrigationWeater
        {
            get { return idCropIrrigationWeather; }
            set { idCropIrrigationWeather = value; }
        }

        public IrrigationUnit IrrigationUnit
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

        /// <summary>
        /// TODO add description
        /// </summary>
        public CropIrrigationWeather() 
        {
            this.IdCropIrrigationWeater = 0;
            this.IrrigationUnit = new Irrigation.IrrigationUnit();
            this.Crop = new Crop();
            this.MainWeatherStation = new WeatherStation();
            this.AlternativeWeatherStation = new WeatherStation();
            this.PredeterminatedIrrigationQuantity = 20;
            //TODO erase this.cropIrrigationWeatherRecord = new cropIrrigationWeatherRecord();//La agrega sistema
            this.PhenologicalStage = new PhenologicalStage();
            this.Location = new Location();
            this.SowingDate = new DateTime();
            this.HarvestDate = new DateTime();
            this.Soil = new Soil();
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pIdCropIrrigationWeather"></param>
        /// <param name="pIrrigationUnit"></param>
        /// <param name="pCrop"></param>
        /// <param name="pMainWeatherStation"></param>
        /// <param name="pAlternativeWeatherStation"></param>
        /// <param name="pPredeterminatedIrrigationQuantity"></param>
        /// <param name="pPhenologicalStage"></param>
        /// <param name="pLocation"></param>
        /// <param name="pSowingDate"></param>
        /// <param name="pHarvestDate"></param>
        /// <param name="pSoil"></param>
        public CropIrrigationWeather(long pIdCropIrrigationWeather, IrrigationUnit pIrrigationUnit,
            Crop pCrop, WeatherStation pMainWeatherStation, WeatherStation pAlternativeWeatherStation,
            double pPredeterminatedIrrigationQuantity, 
            //TODO erase cropIrrigationWeatherRecord pCropIrrigationWeatherRecordList,
            PhenologicalStage pPhenologicalStage, Location pLocation,
            DateTime pSowingDate, DateTime pHarvestDate, Soil pSoil)
        {
            this.IrrigationUnit = pIrrigationUnit;
            this.Crop = pCrop;
            this.MainWeatherStation = pMainWeatherStation;
            this.AlternativeWeatherStation = pAlternativeWeatherStation;
            this.PredeterminatedIrrigationQuantity = pPredeterminatedIrrigationQuantity;
            //TODO erase this.cropIrrigationWeatherRecord = pCropIrrigationWeatherRecordList; //La agrega sistema
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
            lOldRootDepth = this.GetPhenologicalStageRootDepth(this.PhenologicalStage);

            //get the modified degrees days
            lModifiedGrowingDegreeDays = this.cropIrrigationWeatherRecord.ModifiedGrowingDegreeDays;
            //Get the percentage of availableWater before to actualize the phenology state 
            lPercentageOfAvailableWater = this.getPercentageOfAvailableWater();

            //Update Phenological Stage depending on the ModifiedGrowingDegreeDays
            this.UpdatePhenologicalStage(lModifiedGrowingDegreeDays);
            lNewRootDepth = this.GetPhenologicalStageRootDepth(this.PhenologicalStage);
            lNewPhenStage = this.PhenologicalStage;

            //Si aumenta la profundidad de raiz agrego al balance hidrico el agua de la nueva 
            //parte del suelo que se considera (a Capacidad de campo)
            if (lOldPhenStage != null && lNewPhenStage != null && lOldRootDepth < lNewRootDepth)
            {
                //TODO get field capacity by horizon of soil (parameters: horizon depth, root depth difference)
                lRootDepthDifference = lNewRootDepth - lOldRootDepth;
                this.cropIrrigationWeatherRecord.HydricBalance += this.GetFieldCapacity(lRootDepthDifference);
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
            double lAmountOfIrrigationNotUsed;
            double lAmountOfRainNotUsed;

            lDayAfterSowing = this.cropIrrigationWeatherRecord.DayAfterSowing.First + 1;
            this.cropIrrigationWeatherRecord.DayAfterSowing = new Pair<int, DateTime>(lDayAfterSowing, pDailyRec.DateHour);
            this.cropIrrigationWeatherRecord.GrowingDegreeDays += pDailyRec.GrowingDegree;
            this.cropIrrigationWeatherRecord.ModifiedGrowingDegreeDays += pDailyRec.ModifiedGrowingDegree;

            //Update the Phenological Stage depending in Growing Degree
            reviewPhenologicalStage();


            lFieldCapacity = this.getSoilFieldCapacity();

            //To debug
            if (pDailyRec.DateHour.Equals(new DateTime(2014, 10, 29)))
            { }
              


            // Evapotraspiration adjustment
            if (pDailyRec.EvapotranspirationCrop != null)
            {
                this.cropIrrigationWeatherRecord.TotalEvapotranspirationCrop += pDailyRec.EvapotranspirationCrop.getTotalInput();
                this.cropIrrigationWeatherRecord.HydricBalance -= pDailyRec.EvapotranspirationCrop.getTotalInput();
            }

            //Will show if there is Water Input (Rain or Irrigation)
            lThereIsWaterInput = false;

            

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

                // If the HidricBalance is bigger than the FieldCapacity set the HidricBalance as de FieldCapacity  
                // And take off the irrigation not used from ->  TotalIrrigation /  TotalExtraIrrigation
                if (this.cropIrrigationWeatherRecord.HydricBalance > lFieldCapacity)
                {
                    lAmountOfIrrigationNotUsed = this.cropIrrigationWeatherRecord.HydricBalance - lFieldCapacity;
                    this.cropIrrigationWeatherRecord.HydricBalance = lFieldCapacity;

                    if (pDailyRec.Irrigation.Input * lIrrigationEfficiency >= lAmountOfIrrigationNotUsed)
                    {
                        this.cropIrrigationWeatherRecord.TotalIrrigation -= lAmountOfIrrigationNotUsed;
                    }
                    else if (pDailyRec.Irrigation.ExtraInput * lIrrigationEfficiency >= lAmountOfIrrigationNotUsed)
                    {
                        this.cropIrrigationWeatherRecord.TotalExtraIrrigation -= lAmountOfIrrigationNotUsed;
                    }
                    else
                    {
                        this.cropIrrigationWeatherRecord.TotalIrrigation -= pDailyRec.Irrigation.Input * lIrrigationEfficiency;
                        lAmountOfIrrigationNotUsed -= pDailyRec.Irrigation.Input * lIrrigationEfficiency;
                        this.cropIrrigationWeatherRecord.TotalExtraIrrigation -= lAmountOfIrrigationNotUsed;
 
                    }
                    
                }

            }

            // Rain adjustment
            if (pDailyRec.Rain != null)
            {
                lRealRain = pDailyRec.Rain.getTotalInput();
                //Calculate Rain Effective Value
                //TODO correction on Effective Rain, take care about HydricBalance if it is at 100%
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

                // If the HidricBalance is bigger than the FieldCapacity set the HidricBalance as de FieldCapacity and take off the rain not used -> total rain
                if (this.cropIrrigationWeatherRecord.HydricBalance >= lFieldCapacity)
                {
                    lAmountOfRainNotUsed = this.cropIrrigationWeatherRecord.HydricBalance - lFieldCapacity;
                    this.cropIrrigationWeatherRecord.HydricBalance = lFieldCapacity;
                    this.cropIrrigationWeatherRecord.TotalEffectiveRain -= lAmountOfRainNotUsed;

                }
            }

            

            //TotalEvapotranspirationCropFromLastWaterInput adjustment
            if (!lThereIsWaterInput)
            {
                this.cropIrrigationWeatherRecord.TotalEvapotranspirationCropFromLastWaterInput += pDailyRec.EvapotranspirationCrop.getTotalInput();
            }

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

  
        
        #endregion

        #region Public Methods

        /// <summary>
        /// Get Region from Crop
        /// </summary>
        /// <returns></returns>
        public Region GetRegion() 
        {
            Region lRegion;
            lRegion = this.IrrigationUnit.Location.Region;
            return lRegion;
        }

        /// <summary>
        /// Get Days After Sowing DateTime
        /// </summary>
        /// <returns></returns>
        public int GetDaysAfterSowing()
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
        public double GetBaseTemperature() 
        {
            double lReturn;
            lReturn = this.Crop.getBaseTemperature();
            return lReturn;
        }

        /// <summary>
        /// Get Max Evapotranspiration to Irrigate from Crop
        /// </summary>
        /// <returns></returns>
        public double GetMaxEvapotranspirationToIrrigate()
        {
            double lReturn;
            lReturn = this.Crop.MaxEvapotranspirationToIrrigate;
            return lReturn;
        }

        /// <summary>
        /// Get Root Depth from Crop Phenological Stage
        /// </summary>
        /// <returns></returns>
        public double GetPhenologicalStageRootDepth(PhenologicalStage pPhenologicalStage)
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
        public double GetFieldCapacity(double pRootDepth)
        {
            double lReturn;
            lReturn = this.Soil.GetFieldCapacity(pRootDepth);
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

            lRootDepth = this.GetPhenologicalStageRootDepth(this.PhenologicalStage);
            lSoilPermanentWiltingPoint = this.Soil.GetPermanentWiltingPoint(lRootDepth);
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

            lRootDepth = this.GetPhenologicalStageRootDepth(this.PhenologicalStage);
            lSoilAvailableWaterCapacity = this.Soil.GetAvailableWaterCapacity(lRootDepth);
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
            double lRootDepth = this.GetPhenologicalStageRootDepth(this.PhenologicalStage);
            lReturn = this.Soil.GetFieldCapacity(lRootDepth);
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
            
            lFieldCapacity = this.GetFieldCapacity(InitialTables.INITIAL_ROOT_DEPTH);
            lReturn = lFieldCapacity;
            return lReturn;
        }

        /// <summary>
        /// TODO Add Description
        /// </summary>
        /// <param name="lModifiedGrowingDegreeDays"></param>
        /// <returns></returns>
        public PhenologicalStage UpdatePhenologicalStage(double lModifiedGrowingDegreeDays)
        {
            List<PhenologicalStage> lPhenologicalStageList;
            IEnumerable<PhenologicalStage> lPhenologicalTableOrderByMinDegree;
            PhenologicalStage lNewPhenStage = null;

            //Order the phenological table
            lPhenologicalStageList = this.Crop.Specie.PhenologicalStageList;
            lPhenologicalTableOrderByMinDegree = lPhenologicalStageList.OrderBy(lPhenologicalStage => lPhenologicalStage.MinDegree);

            foreach (PhenologicalStage lPhenologicalStage in lPhenologicalTableOrderByMinDegree)
            {
                if (lPhenologicalStage != null && lPhenologicalStage.Specie.Equals(this.Crop.Specie) && lPhenologicalStage.MinDegree <= lModifiedGrowingDegreeDays
                    && lPhenologicalStage.MaxDegree >= lModifiedGrowingDegreeDays)
                {
                    this.PhenologicalStage = lPhenologicalStage;
                    lNewPhenStage = lPhenologicalStage;
                    return lNewPhenStage;
                }
            }

            return lNewPhenStage;
        }

        /// <summary>
        /// TODO explain addDailyRecord
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
                lBaseTemperature = this.GetBaseTemperature();
                //Growing Degree is average temperature menous Base Temperature
                lGrowingDegree = lAverageTemp - lBaseTemperature;
                lGrowingDegreeAcumulated = this.cropIrrigationWeatherRecord.GrowingDegreeDays + lGrowingDegree;

                //Get days after sowing for Modified Growing Degree
                lDays = this.cropIrrigationWeatherRecord.getDaysAfterSowingForModifiedGrowingDegree();

                if (lDays == 0)
                {
                    lDays = Utils.getDaysDifference(this.SowingDate, pWeatherData.Date);
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

                
                //If it's the initial registry set the initial Hidric Balance
                if (lDays == 0)
                {
                    this.cropIrrigationWeatherRecord.HydricBalance = this.getInitialHidricBalance();
                    this.cropIrrigationWeatherRecord.DayAfterSowing = new Pair<int, DateTime>(-1, this.SowingDate);
                }
                reviewSummaryData(lNewDailyRecord);
              

                this.cropIrrigationWeatherRecord.DailyRecords.Add(lNewDailyRecord);
                
                this.cropIrrigationWeatherRecord.OutPut += this.cropIrrigationWeatherRecord.printState();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception in IrrigationSystem.addCropIrrigWeatherToList " + ex.Message);
                throw ex;
                //TODO manage and log the exception
                
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