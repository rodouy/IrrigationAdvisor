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
    ///     CropIrrigationWeatherRecord
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
    ///     - CropIrrigationWeatherRecordList  List<CropIrrigationWeatherRecord> 
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
    ///     - GetSoilPermanentWiltingPoint(): double
    ///     - GetSoilAvailableWaterCapacity(): double
    ///     - GetSoilFieldCapacity(): double
    ///     - GetPercentageOfAvailableWater(): double
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

        private long cropIrrigationWeatherId;
        private IrrigationUnit irrigationUnit;
        private Crop crop;
        private WeatherStation mainWeatherStation;
        private WeatherStation alternativeWeatherStation;
        private double predeterminatedIrrigationQuantity;
        private CropIrrigationWeatherRecord cropIrrigationWeatherRecord;
        private Location location;
        private Soil soil;

        private bool usingGrowingDegreeDaysForPhenologicalAdjustment;
        private bool usingMainWeatherStation;

        #region Water

        private List<Rain> rainList;
        private List<Water.Irrigation> irrigationList;
        private List<EvapotranspirationCrop> evapotranspirationCropList;

        #endregion
        
        //Totals
        private double totalEvapotranspirationCrop;
        private double totalEffectiveRain;
        private double totalRealRain;
        private double totalIrrigation;
        private double totalIrrigationInHidricBalance;
        private double totalExtraIrrigation;
        private double totalExtraIrrigationInHidricBalance;

        #endregion

        #region Properties

        public long CropIrrigationWeaterId
        {
            get { return cropIrrigationWeatherId; }
            set { cropIrrigationWeatherId = value; }
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

        public CropIrrigationWeatherRecord CropIrrigationWeatherRecord
        {
            get { return cropIrrigationWeatherRecord; }
            set { cropIrrigationWeatherRecord = value; }
        }

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }
        
        public Soil Soil
        {
            get { return soil; }
            set { soil = value; }
        }

        public bool UsingGrowingDegreeDaysForPhenologicalAdjustment
        {
            get { return usingGrowingDegreeDaysForPhenologicalAdjustment; }
            set { usingGrowingDegreeDaysForPhenologicalAdjustment = value; }
        }


        public bool UsingMainWeatherStation
        {
            get { return usingMainWeatherStation; }
            set { usingMainWeatherStation = value; }
        }

        public List<Water.Irrigation> IrrigationList
        {
            get { return irrigationList; }
            set { irrigationList = value; }
        }

        public List<Water.Rain> RainList
        {
            get { return rainList; }
            set { rainList = value; }
        }

        public List<EvapotranspirationCrop> EvapotranspirationCropList
        {
            get { return evapotranspirationCropList; }
            set { evapotranspirationCropList = value; }
        }

        public double TotalRealRain
        {
            get { return totalRealRain; }
            set { totalRealRain = value; }
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

        public double TotalIrrigationInHidricBalance
        {
            get { return totalIrrigationInHidricBalance; }
            set { totalIrrigationInHidricBalance = value; }
        }

        public double TotalExtraIrrigation
        {
            get { return totalExtraIrrigation; }
            set { totalExtraIrrigation = value; }
        }

        public double TotalExtraIrrigationInHidricBalance
        {
            get { return totalExtraIrrigationInHidricBalance; }
            set { totalExtraIrrigationInHidricBalance = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// PredeterminatedIrrigationQuantity = 20
        /// </summary>
        public CropIrrigationWeather() 
        {
            this.CropIrrigationWeaterId = 0;
            this.IrrigationUnit = new Irrigation.IrrigationUnit();
            this.Crop = new Crop();
            this.MainWeatherStation = new WeatherStation();
            this.AlternativeWeatherStation = new WeatherStation();
            this.PredeterminatedIrrigationQuantity = 20;
            this.Location = new Location();
            this.Soil = new Soil();
            this.UsingGrowingDegreeDaysForPhenologicalAdjustment = false ;
            this.UsingMainWeatherStation = true;

            this.IrrigationList = new List<Water.Irrigation>();
            this.RainList = new List<Rain>();
            this.EvapotranspirationCropList = new List<EvapotranspirationCrop>();

            this.CropIrrigationWeatherRecord = new CropIrrigationWeatherRecord();

            this.TotalEvapotranspirationCrop = 0;
            this.TotalEffectiveRain = 0;
            this.TotalRealRain = 0;
            this.TotalIrrigation = 0;
            this.totalIrrigationInHidricBalance = 0;
            this.TotalExtraIrrigation = 0;
            this.TotalExtraIrrigationInHidricBalance = 0;
        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pCropIrrigationWeatherId"></param>
        /// <param name="pIrrigationUnit"></param>
        /// <param name="pCrop"></param>
        /// <param name="pMainWeatherStation"></param>
        /// <param name="pAlternativeWeatherStation"></param>
        /// <param name="pPredeterminatedIrrigationQuantity"></param>
        /// <param name="pLocation"></param>
        /// <param name="pSoil"></param>
        /// <param name="pTotalEvapotranspirationCrop"></param>
        /// <param name="pTotalEffectiveRain"></param>
        /// <param name="pTotalRealRain"></param>
        /// <param name="pTotalIrrigation"></param>
        /// <param name="pTotalExtraIrrigation"></param>
        public CropIrrigationWeather(long pCropIrrigationWeatherId, IrrigationUnit pIrrigationUnit,
                                Crop pCrop, WeatherStation pMainWeatherStation, WeatherStation pAlternativeWeatherStation,
                                double pPredeterminatedIrrigationQuantity, 
                                Location pLocation, Soil pSoil)
        {
            this.IrrigationUnit = pIrrigationUnit;
            this.Crop = pCrop;
            this.MainWeatherStation = pMainWeatherStation;
            this.AlternativeWeatherStation = pAlternativeWeatherStation;
            this.PredeterminatedIrrigationQuantity = pPredeterminatedIrrigationQuantity;
            this.Location = pLocation;
            this.Soil = pSoil;
            this.UsingGrowingDegreeDaysForPhenologicalAdjustment = false;
            this.UsingMainWeatherStation = true;

            this.IrrigationList = new List<Water.Irrigation>();
            this.RainList = new List<Rain>();
            this.EvapotranspirationCropList = new List<EvapotranspirationCrop>();

            this.CropIrrigationWeatherRecord = new CropIrrigationWeatherRecord();

            this.TotalEvapotranspirationCrop = 0;
            this.TotalEffectiveRain = 0;
            this.TotalRealRain = 0;
            this.TotalIrrigation = 0;
            this.TotalIrrigationInHidricBalance = 0;
            this.TotalExtraIrrigation = 0;
            this.TotalExtraIrrigationInHidricBalance = 0;
        }
        
        #endregion

        #region Private Helpers

        
        /// <summary>
        /// Change the PhenologicalStage of the crop depending of the growing degree acumulated plus the adjustment
        /// </summary>
        private void reviewPhenologicalStage()
        {
            PhenologicalStage lOldPhenStage = null;
            double lOldDepth = 0;
            PhenologicalStage lNewPhenStage = null;
            double lNewDepth = 0;
            double lModifiedGrowingDegreeDays;
            double lDepthDifference;
            double lPercentageOfAvailableWater;

            lOldPhenStage = this.CropIrrigationWeatherRecord.PhenologicalStage;
            lOldDepth = this.GetPhenologicalStageDepth(this.CropIrrigationWeatherRecord.PhenologicalStage);

            //get the modified degrees days
            lModifiedGrowingDegreeDays = this.CropIrrigationWeatherRecord.GrowingDegreeDaysModified;
            //Get the percentage of availableWater before to actualize the phenology state 
            lPercentageOfAvailableWater = this.GetPercentageOfAvailableWater();

            //Update Phenological Stage depending on the GrowingDegreeDaysModified
            this.UpdatePhenologicalStage(lModifiedGrowingDegreeDays);
            lNewDepth = this.GetPhenologicalStageDepth(this.CropIrrigationWeatherRecord.PhenologicalStage);
            lNewPhenStage = this.CropIrrigationWeatherRecord.PhenologicalStage;

            //Si aumenta la profundidad de raiz agrego al balance hidrico el agua de la nueva 
            //parte del suelo que se considera (a Capacidad de campo)
            if (lOldPhenStage != null && lNewPhenStage != null && lOldDepth < lNewDepth)
            {
                //TODO get field capacity by horizon of soil (parameters: horizon depth, root depth difference)
                lDepthDifference = lNewDepth - lOldDepth;
                this.CropIrrigationWeatherRecord.HydricBalance += this.GetFieldCapacity(lDepthDifference);
            }

            //Si disminuye la profundidad de raiz agrego al balance hidrico el agua de la nueva 
            //parte del suelo que se considera (a Capacidad de campo)
            if (lOldPhenStage != null && lNewPhenStage != null && lOldDepth > lNewDepth)
            {
                this.CropIrrigationWeatherRecord.HydricBalance = (this.GetSoilAvailableWaterCapacity() * lPercentageOfAvailableWater / 100)
                                    + this.GetSoilPermanentWiltingPoint();
            }
        }

        /// <summary>
        /// Make the lIrrigation adjustment
        /// </summary>
        /// <param name="pDailyRec"></param>
        /// <param name="pFieldCapacity"></param>
        /// <param name="pThereIsWaterInput"></param>
        /// <returns></returns>
        private bool irrigationAdjustment(DailyRecord pDailyRec, double pFieldCapacity, bool  pThereIsWaterInput)
        {
            double lEffectiveIrrigation;
            double lEffectiveIrrigationExtra;
            double lEffectiveIrrigationTotal;
            double lIrrigationEfficiency;
            double lAmountOfIrrigationNotUsed;
            int lDaysBetweenIrrigations;
            
            
            if (pDailyRec.Irrigation != null)
            {
                lDaysBetweenIrrigations = Utilities.Utils.getDaysDifference(this.CropIrrigationWeatherRecord.LastPartialWaterInputDate, pDailyRec.DailyRecordDateTime);

                // Calculate de effective lIrrigation depending on the irrigatioin efficiency of the Pivot
                lIrrigationEfficiency = this.IrrigationUnit.IrrigationEfficiency;

                //Effective Irrigation
                lEffectiveIrrigation = pDailyRec.Irrigation.Input * lIrrigationEfficiency;
                lEffectiveIrrigationExtra = pDailyRec.Irrigation.ExtraInput * lIrrigationEfficiency;
                lEffectiveIrrigationTotal = lEffectiveIrrigation + lEffectiveIrrigationExtra;

                this.TotalIrrigation += lEffectiveIrrigation;
                this.TotalIrrigationInHidricBalance += lEffectiveIrrigation;

                this.TotalExtraIrrigation += lEffectiveIrrigationExtra;
                this.TotalExtraIrrigationInHidricBalance += lEffectiveIrrigationExtra;

                //Add to Hidric Balance the lIrrigation calculated (Input) and the extra lIrrigation (ExtraInput) 
                this.CropIrrigationWeatherRecord.HydricBalance += lEffectiveIrrigationTotal;

                // If the lIrrigation is bigger than 10 mm set the last water input
                if (lEffectiveIrrigationTotal > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    this.CropIrrigationWeatherRecord.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.GetTotalInput();
                    this.CropIrrigationWeatherRecord.LastWaterInputDate = pDailyRec.DailyRecordDateTime;
                    pThereIsWaterInput = true;
                }
                // If two "partial" water inputs, between 3 days, are bigger than 10 mm then set the last water input
                else if (lDaysBetweenIrrigations <= InitialTables.DAYS_BETWEEN_TWO_PARTIAL_BIG_WATER_INPUT)
                {
                    if (lEffectiveIrrigationTotal + this.CropIrrigationWeatherRecord.LastPartialWaterInput > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                    {
                        this.CropIrrigationWeatherRecord.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.GetTotalInput();
                        this.CropIrrigationWeatherRecord.LastWaterInputDate = pDailyRec.DailyRecordDateTime;
                        pThereIsWaterInput = true;
                    }
                }
                else //Registry the effective lIrrigation and its date as a PartialWaterInput
                {
                    this.CropIrrigationWeatherRecord.LastPartialWaterInput = lEffectiveIrrigationTotal;
                    this.CropIrrigationWeatherRecord.LastPartialWaterInputDate = pDailyRec.DailyRecordDateTime;
                }

                // If the HidricBalance is bigger than the FieldCapacity set the HidricBalance as de FieldCapacity  
                // And take off the lIrrigation not used from ->  TotalIrrigation /  TotalExtraIrrigation
                if (this.CropIrrigationWeatherRecord.HydricBalance > pFieldCapacity)
                {
                    lAmountOfIrrigationNotUsed = this.CropIrrigationWeatherRecord.HydricBalance - pFieldCapacity;
                    this.CropIrrigationWeatherRecord.HydricBalance = pFieldCapacity;

                    if (lEffectiveIrrigation >= lAmountOfIrrigationNotUsed)
                    {
                        this.TotalIrrigationInHidricBalance -= lAmountOfIrrigationNotUsed;
                    }
                    else if (lEffectiveIrrigationExtra >= lAmountOfIrrigationNotUsed)
                    {
                        this.TotalExtraIrrigationInHidricBalance -= lAmountOfIrrigationNotUsed;
                    }
                    else
                    {
                        this.TotalIrrigationInHidricBalance -= lEffectiveIrrigation;
                        lAmountOfIrrigationNotUsed -= lEffectiveIrrigation;
                        this.TotalExtraIrrigationInHidricBalance -= lAmountOfIrrigationNotUsed;
                    }
                }
            }
            return pThereIsWaterInput;

        }
        
        /// <summary>
        /// Make the lRain adjustment
        /// </summary>
        /// <param name="pDailyRec"></param>
        /// <param name="pFieldCapacity"></param>
        /// <param name="pThereIsWaterInput"></param>
        /// <returns></returns>
        private bool rainAdjustment(DailyRecord pDailyRec, double pFieldCapacity, bool pThereIsWaterInput)
        {
            double lRealRain;
            double lEffectiveRain;
            double lAmountOfRainNotUsed;
            int lDaysBetweenRains;

            if (pDailyRec.Rain != null)
            {
                lDaysBetweenRains = Utilities.Utils.getDaysDifference(this.CropIrrigationWeatherRecord.LastPartialWaterInputDate, pDailyRec.DailyRecordDateTime);

                lRealRain = pDailyRec.Rain.getTotalInput();
                //Calculate Rain Effective Value
                lEffectiveRain = this.CropIrrigationWeatherRecord.GetEffectiveRainValue(pDailyRec.Rain);
                this.TotalEffectiveRain += lEffectiveRain;
                this.TotalRealRain += lRealRain;
                this.CropIrrigationWeatherRecord.HydricBalance += lEffectiveRain;

                // If the effective lRain is bigger than 10 mm then set the last water input
                if (lEffectiveRain > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    this.CropIrrigationWeatherRecord.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.GetTotalInput();
                    this.CropIrrigationWeatherRecord.LastWaterInputDate = pDailyRec.DailyRecordDateTime;
                    pThereIsWaterInput = true;
                }
                // If two "partial" water inputs, between 3 days, are bigger than 10 mm then set the last water input
                else if (lDaysBetweenRains <= InitialTables.DAYS_BETWEEN_TWO_PARTIAL_BIG_WATER_INPUT)
                {
                    if (lEffectiveRain + this.CropIrrigationWeatherRecord.LastPartialWaterInput > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                    {
                        this.CropIrrigationWeatherRecord.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.GetTotalInput();
                        this.CropIrrigationWeatherRecord.LastWaterInputDate = pDailyRec.DailyRecordDateTime;
                        pThereIsWaterInput = true;
                    }
                }
                else //Registry the effective lRain and its date as a PartialWaterInput
                {
                    this.CropIrrigationWeatherRecord.LastPartialWaterInput = lEffectiveRain;
                    this.CropIrrigationWeatherRecord.LastPartialWaterInputDate = pDailyRec.DailyRecordDateTime;
                }
                
                // If the HidricBalance is bigger than the FieldCapacity set the HidricBalance as de FieldCapacity and take off the lRain not used -> total lRain
                if (this.CropIrrigationWeatherRecord.HydricBalance >= pFieldCapacity)
                {
                    //We have to save the date to keep the hidric balance unchangable
                    this.CropIrrigationWeatherRecord.LastBigWaterInputDate = pDailyRec.DailyRecordDateTime;

                    //Take off the lRain because (HydricBalanc + lRain) is bigger than FieldCapacity
                    lAmountOfRainNotUsed = this.CropIrrigationWeatherRecord.HydricBalance - pFieldCapacity;
                    this.CropIrrigationWeatherRecord.HydricBalance = pFieldCapacity;
                    this.TotalEffectiveRain -= lAmountOfRainNotUsed;

                }
                
            }

            return pThereIsWaterInput;


        }

        /// <summary>
        /// Set the new values (after to add a new dailyRecord) for the variables used to resume the state of the crop.
        /// Use the last state (day before) to calculate the new state
        /// Review the dailyRecordList to set the data for: 
        /// - GrowingDegreeDaysAccumulated
        /// - GrowingDegreeDaysModified
        /// - TotalEvapotranspirationCrop
        /// - TotalEffectiveRain
        /// - TotalIrrigation
        /// - TotalEvapotranspirationCropFromLastWaterInput
        /// - LastWaterInput
        /// </summary>
        /// <param name="pDailyRec"></param>
        private void reviewSummaryData(DailyRecord pDailyRec)
        {
            double lFieldCapacity;
            int lDayAfterSowing;
            bool lThereIsWaterInput;

            double lDaysAfterBigInputWater;
            
            lDayAfterSowing = this.CropIrrigationWeatherRecord.DayAfterSowing + 1;
            this.CropIrrigationWeatherRecord.CropDate = pDailyRec.DailyRecordDateTime;
            this.CropIrrigationWeatherRecord.GrowingDegreeDaysAccumulated += pDailyRec.GrowingDegreeDays;
            this.CropIrrigationWeatherRecord.GrowingDegreeDaysModified += pDailyRec.GrowingDegreeDaysModified;

            //Update the Phenological Stage depending in Growing Degree
            reviewPhenologicalStage();

            lFieldCapacity = this.GetSoilFieldCapacity();

            //TODO: Erase To debug
            if (pDailyRec.DailyRecordDateTime.Equals(new DateTime(2015, 02, 03)))
            {
                //System.Diagnostics.Debugger.Break();
            }
                
            // Evapotraspiration adjustment
            if (pDailyRec.EvapotranspirationCrop != null)
            {
                this.TotalEvapotranspirationCrop += pDailyRec.EvapotranspirationCrop.GetTotalInput();
                this.CropIrrigationWeatherRecord.HydricBalance -= pDailyRec.EvapotranspirationCrop.GetTotalInput();
            }

            //Will show if there is Water Input (Rain or Irrigation)
            lThereIsWaterInput = false;

            

            // Irrigation adjustment
            lThereIsWaterInput = irrigationAdjustment(pDailyRec, lFieldCapacity, lThereIsWaterInput);

            // Rain adjustment
            lThereIsWaterInput = rainAdjustment(pDailyRec, lFieldCapacity, lThereIsWaterInput);
            

            //TotalEvapotranspirationCropFromLastWaterInput adjustment
            if (!lThereIsWaterInput)
            {
                this.CropIrrigationWeatherRecord.TotalEvapotranspirationCropFromLastWaterInput += pDailyRec.EvapotranspirationCrop.GetTotalInput();
            }

            lFieldCapacity = this.GetSoilFieldCapacity();

            //After a big lRain the HidricBalance keep its value = FieldCapacity for two days
            lDaysAfterBigInputWater = Utilities.Utils.getDaysDifference(this.CropIrrigationWeatherRecord.LastBigWaterInputDate, pDailyRec.DailyRecordDateTime);
            if (lDaysAfterBigInputWater <= InitialTables.DAYS_HIDRIC_BALANCE_UNCHANGABLE_AFTER_BIG_WATER_INPUT)
            {
                this.CropIrrigationWeatherRecord.HydricBalance = lFieldCapacity;
            }

            //The first days after sowing, hydric balance is maintained at field capacity
            if (lDayAfterSowing <= InitialTables.DAYS_HIDRIC_BALANCE_UNCHANGABLE_AFTER_SOWING)
            {
                this.CropIrrigationWeatherRecord.HydricBalance = lFieldCapacity;
            }
        }

        /// <summary>
        /// TODO add description void takeOffDailyRecord(DailyRecord pRecordToDelete)
        /// </summary>
        /// <param name="pRecordToDelete"></param>
        private void takeOffDailyRecord(DailyRecord lRecordToDelete)
        {
            ///TODO Ajustar los datos de resumen: agregar lEvapotranspirationCropInput y sacar lRain y riego a los totales (proceso inverso a agregar uno)
            int lDayAfterSowing;
            DateTime lDateOfDayAfterSowing;

            lDayAfterSowing = this.CropIrrigationWeatherRecord.DayAfterSowing - 1;
            lDateOfDayAfterSowing = this.CropIrrigationWeatherRecord.CropDate.AddDays(-1);
            //this.CropIrrigationWeatherRecord.DayAfterSowing = new Pair<int, DateTime>(lDayAfterSowing, lDateOfDayAfterSowing);
            // Evapotraspiration revert
            if (lRecordToDelete.EvapotranspirationCrop != null)
            {
                this.TotalEvapotranspirationCrop -= lRecordToDelete.EvapotranspirationCrop.GetTotalInput();
                this.CropIrrigationWeatherRecord.HydricBalance += lRecordToDelete.EvapotranspirationCrop.GetTotalInput();
            }

            // Rain revert
            if (lRecordToDelete.Rain != null)
            {
                double lEffectiveRain = lRecordToDelete.Rain.getTotalInput();
                double lRealRain = lRecordToDelete.Rain.getTotalInput();
                this.TotalEffectiveRain -= lEffectiveRain;
                this.TotalRealRain -= lRealRain;
                this.CropIrrigationWeatherRecord.HydricBalance -= lEffectiveRain;
                // If the effective lRain is bigger than 10 mm set the last water input
                //if (pRecordToDelete.Rain.Input > 10)
                //{
                //    this.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.GetTotalInput();
                //    this.LastWaterInput = pDailyRec.DailyRecordDateTime;
                //    lThereIsWaterInput = true;
                //}
            }

            // Irrigation revert
            if (lRecordToDelete.Irrigation != null)
            {
                //TODO verificar que el riego sea mayor a 10 mm para setear lThereIsWaterInput = true
                this.TotalIrrigation -= lRecordToDelete.Irrigation.Input;
                this.TotalExtraIrrigation -= lRecordToDelete.Irrigation.ExtraInput;
                this.CropIrrigationWeatherRecord.HydricBalance -= lRecordToDelete.Irrigation.getTotalInput();
                //lThereIsWaterInput = true;
            }
            // If the HidricBalance is bigger than the FieldCapacity set the HidricBalance as de FieldCapacity
            /*if (HydricBalance >= lFieldCapacity)
            {
                this.HydricBalance = lFieldCapacity; ///CAMBIO 2
                this.LastBigWaterInput = pDailyRec.DailyRecordDateTime;
            }

            //After a big lRain the HidricBalance keep its value = FieldCapacity for two days
            if (Utilities.Utils.getDaysDifference(this.LastBigWaterInput, pDailyRec.DailyRecordDateTime) < 3 && this.HydricBalance < lFieldCapacity)
            {
                this.HydricBalance = lFieldCapacity;
            }

            if (!lThereIsWaterInput)
            {
                this.TotalEvapotranspirationCropFromLastWaterInput += pDailyRec.EvapotranspirationCrop.GetTotalInput();
            }
             */

            // GrowingDegreeDaysAccumulated revert
            this.CropIrrigationWeatherRecord.GrowingDegreeDaysAccumulated -= lRecordToDelete.GrowingDegreeDays;
            this.CropIrrigationWeatherRecord.GrowingDegreeDaysModified -= lRecordToDelete.GrowingDegreeDaysModified;
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
            lSowingDate = this.CropIrrigationWeatherRecord.SowingDate;
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
            lReturn = this.Crop.GetBaseTemperature();
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
        /// Get Depth from Crop Phenological Stage (Hydric Balance Depth)
        /// </summary>
        /// <returns></returns>
        public double GetPhenologicalStageDepth(PhenologicalStage pPhenologicalStage)
        {
            double lDepth;
            lDepth = pPhenologicalStage.HydricBalanceDepth;
            if (lDepth > this.Soil.DepthLimit)
            {
                lDepth = this.Soil.DepthLimit;
            }
            return lDepth;
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
        /// <param name="pDepth"></param>
        /// <returns></returns>
        public double GetFieldCapacity(double pDepth)
        {
            double lReturn;
            lReturn = this.Soil.GetFieldCapacity(pDepth);
            return lReturn;
        }

        #region SoilData

        /// <summary>
        /// Get Soil Permanent Wilting Poing
        /// The data is obtained from Soil depending Root Depth
        /// </summary>
        /// <returns></returns>
        public double GetSoilPermanentWiltingPoint()
        {
            double lDepth;
            double lSoilPermanentWiltingPoint;

            lDepth = this.GetPhenologicalStageDepth(this.CropIrrigationWeatherRecord.PhenologicalStage);
            lSoilPermanentWiltingPoint = this.Soil.GetPermanentWiltingPoint(lDepth);
            return lSoilPermanentWiltingPoint;
        }

        /// <summary>
        /// Get Soil Available Water Capacity 
        /// From Crop Soil by Root Depth 
        /// </summary>
        /// <returns></returns>
        public double GetSoilAvailableWaterCapacity()
        {
            double lDepth;
            double lSoilAvailableWaterCapacity;

            lDepth = this.GetPhenologicalStageDepth(this.CropIrrigationWeatherRecord.PhenologicalStage);
            lSoilAvailableWaterCapacity = this.Soil.GetAvailableWaterCapacity(lDepth);
            return lSoilAvailableWaterCapacity;
        }

        /// <summary>
        /// Get Soil Field Capacity
        /// From Crop Soil by Root Depth
        /// </summary>
        /// <returns></returns>
        public double GetSoilFieldCapacity()
        {
            double lReturn;
            double lDepth = this.GetPhenologicalStageDepth(this.CropIrrigationWeatherRecord.PhenologicalStage);
            lReturn = this.Soil.GetFieldCapacity(lDepth);
            return lReturn;
        }

        #endregion

        /// <summary>
        /// Get Percentage of Hydric Balance of water in Crop
        /// 100 %  = Field Capacity
        /// </summary>
        /// <returns></returns>
        public double GetPercentageOfWaterInCrop()
        {
            double lHydricBalance;
            double lFieldCapacity;
            double lPermanentWiltingPoint;
            double lPercentageOfWater;

            lHydricBalance = this.CropIrrigationWeatherRecord.HydricBalance;
            lFieldCapacity = this.GetSoilFieldCapacity();
            lPermanentWiltingPoint = this.GetSoilPermanentWiltingPoint();

            lPercentageOfWater = Math.Round(((lHydricBalance) * 100)
                                        / (lFieldCapacity), 2);
            return lPercentageOfWater;
        }

        /// <summary>
        /// Get Available Water from Hydric Balance vs Field Capacity
        /// </summary>
        /// <returns></returns>
        public double GetPercentageOfAvailableWater()
        {
            double lHydricBalance;
            double lFieldCapacity;
            double lPermanentWiltingPoint;
            double lPercentageOfAvailableWater;

            lHydricBalance = this.CropIrrigationWeatherRecord.HydricBalance;
            lFieldCapacity = this.GetSoilFieldCapacity();
            lPermanentWiltingPoint = this.GetSoilPermanentWiltingPoint();

            lPercentageOfAvailableWater = Math.Round(((lHydricBalance - lPermanentWiltingPoint) * 100)
                                        / (lFieldCapacity - lPermanentWiltingPoint), 2);
            return lPercentageOfAvailableWater;
        }

        /// <summary>
        /// Get Initial Hidric Balance 
        /// (Fiel Capacity for Initial Root Depth)
        /// </summary>
        /// <returns></returns>
        public double GetInitialHydricBalance()
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
            Stage lStage;
            CropInformatioByDate lCropIrrigationByDate;
            
            //Order the phenological table
            lPhenologicalStageList = this.Crop.PhenologicalStageList;
            lPhenologicalTableOrderByMinDegree = lPhenologicalStageList.OrderBy(lPhenologicalStage => lPhenologicalStage.MinDegree);

            if (this.UsingGrowingDegreeDaysForPhenologicalAdjustment)
            {
                
                foreach (PhenologicalStage lPhenologicalStage in lPhenologicalTableOrderByMinDegree)
                {
                    if (lPhenologicalStage != null && lPhenologicalStage.MinDegree <= lModifiedGrowingDegreeDays
                        && lPhenologicalStage.MaxDegree >= lModifiedGrowingDegreeDays)
                    {
                        this.CropIrrigationWeatherRecord.PhenologicalStage = lPhenologicalStage;
                        lNewPhenStage = lPhenologicalStage;
                        return lNewPhenStage;
                    }
                }
            }
            else 
            {
                lCropIrrigationByDate = new CropInformatioByDate(this.Crop.Specie, this.CropIrrigationWeatherRecord.SowingDate);
                lStage = lCropIrrigationByDate.GetStage(this.CropIrrigationWeatherRecord.CropDate);
                foreach (PhenologicalStage lPhenologicalStage in lPhenologicalTableOrderByMinDegree)
                {
                    string lStageName = lPhenologicalStage.Stage.Name.ToUpper();
                    if (lPhenologicalStage != null && lStageName.Contains(lStage.Name.ToUpper()))
                    {
                        this.CropIrrigationWeatherRecord.PhenologicalStage = lPhenologicalStage;
                        lNewPhenStage = lPhenologicalStage;
                        return lNewPhenStage;
                    }
                }
            }
            return lNewPhenStage;
        }


        public Water.Irrigation GetIrrigation(DateTime pDayOfIrrigation)
        {
            Water.Irrigation lReturn = null;
            foreach (Water.Irrigation lIrrigation in this.IrrigationList)
            {
                if(Utils.isTheSameDay(lIrrigation.Date,pDayOfIrrigation))
                {
                    lReturn = lIrrigation;
                }
            }
            return lReturn;
        }

        public Water.Rain GetRain(DateTime pDayOfRain)
        {
            Water.Rain lReturn = null;
            foreach (Water.Rain lRain in this.RainList)
            {
                if (Utils.isTheSameDay(lRain.Date, pDayOfRain))
                {
                    lReturn = lRain;
                }
            }
            return lReturn;
        }

        public void AddDailyRecord(WeatherData pWeatherData,
                                    String pObservations)
        {
            try
            {
                DateTime lWeatherDate;
                Water.Irrigation lIrrigation;
                Water.Rain lRain;
                
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
                
                lWeatherDate = pWeatherData.Date;
                lIrrigation = this.GetIrrigation(lWeatherDate);
                lRain = this.GetRain(lWeatherDate);

                //Get all Temperature data
                lAverageTemp = pWeatherData.GetAverageTemperature();
                lEvapotranspiration = pWeatherData.GetEvapotranspiration();
                lBaseTemperature = this.GetBaseTemperature();
                //Growing Degree is average temperature menous Base Temperature
                lGrowingDegree = lAverageTemp - lBaseTemperature;
                lGrowingDegreeAcumulated = this.CropIrrigationWeatherRecord.GrowingDegreeDaysAccumulated + lGrowingDegree;

                //Get days after sowing for Modified Growing Degree
                lDays = this.CropIrrigationWeatherRecord.GetDaysAfterSowingForModifiedGrowingDegree();

                if (lDays == 0)
                {
                    lDays = Utils.getDaysDifference(this.CropIrrigationWeatherRecord.SowingDate, pWeatherData.Date);
                }

                


            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception in IrrigationSystem.addCropIrrigWeatherToList " + ex.Message);
                throw ex;
                //TODO manage and log the exception

            }
        }



        /// <summary>
        /// TODO explain AddDailyRecord
        /// </summary>
        /// <param name="pWeatherData"></param>
        /// <param name="pMainWeatherData"></param>
        /// <param name="pAlternativeWeatherData"></param>
        /// <param name="pRain"></param>
        /// <param name="pIrrigation"></param>
        /// <param name="pObservations"></param>
        public void AddDailyRecord(WeatherData pWeatherData, 
                                    WeatherData pMainWeatherData, 
                                    WeatherData pAlternativeWeatherData, 
                                    Water.Rain pRain, Water.Irrigation pIrrigation, 
                                    String pObservations)
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

                lAverageTemp = pWeatherData.GetAverageTemperature();
                lEvapotranspiration = pWeatherData.GetEvapotranspiration();
                lBaseTemperature = this.GetBaseTemperature();
                //Growing Degree is average temperature menous Base Temperature
                lGrowingDegree = lAverageTemp - lBaseTemperature;
                lGrowingDegreeAcumulated = this.CropIrrigationWeatherRecord.GrowingDegreeDaysAccumulated + lGrowingDegree;

                //Get days after sowing for Modified Growing Degree
                lDays = this.CropIrrigationWeatherRecord.GetDaysAfterSowingForModifiedGrowingDegree();

                if (lDays == 0)
                {
                    lDays = Utils.getDaysDifference(this.CropIrrigationWeatherRecord.SowingDate, pWeatherData.Date);
                }

                lKC_CropCoefficient = this.Crop.CropCoefficient.GetCropCoefficient(lDays);
                lRealEvapotraspiration = lEvapotranspiration * lKC_CropCoefficient;
                lEvapotranspirationCrop = new EvapotranspirationCrop(
                    this, pWeatherData.Date, lRealEvapotraspiration);
                lNewDailyRecord = null;
                
                lNewDailyRecord = new DailyRecord(pWeatherData.Date, pMainWeatherData, pAlternativeWeatherData,
                                                lDays, lDays, lGrowingDegree, lGrowingDegreeAcumulated, lGrowingDegree,
                                                pRain, pIrrigation, 
                                                lKC_CropCoefficient, lEvapotranspirationCrop,
                    pObservations);
                

                //TODO extract to a new method as "VerifyUnicityOFDailyRecord"
                //Verify if exist an older Daily Record, and if exists, replece it
                int indexToRemove = -1;
                DailyRecord lRecordToDelete = null;
                int i = 0;
                foreach (DailyRecord lDailyRecord in this.CropIrrigationWeatherRecord.DailyRecordList)
                {
                    if (Utils.isTheSameDay(lDailyRecord.DailyRecordDateTime.Date, pWeatherData.Date))
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
                    this.CropIrrigationWeatherRecord.DailyRecordList.RemoveAt(indexToRemove);
                }

                
                //If it's the initial registry set the initial Hidric Balance
                if (lDays == 0)
                {
                    this.CropIrrigationWeatherRecord.HydricBalance = this.GetInitialHydricBalance();
                    this.CropIrrigationWeatherRecord.DayAfterSowing = 0;// new Pair<int, DateTime>(-1, this.CropIrrigationWeatherRecord.SowingDate);
                }
                reviewSummaryData(lNewDailyRecord);
              

                this.CropIrrigationWeatherRecord.DailyRecordList.Add(lNewDailyRecord);
                
                this.CropIrrigationWeatherRecord.OutPut += this.CropIrrigationWeatherRecord.PrintState(this);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception in IrrigationSystem.addCropIrrigWeatherToList " + ex.Message);
                throw ex;
                //TODO manage and log the exception
                
            }
        }

        /// <summary>
        /// TODO explain AdjustmentPhenology
        /// </summary>
        /// <param name="pStage"></param>
        /// <param name="pDateTime"></param>
        /// <param name="lModification"></param>
        public void AdjustmentPhenology(Stage pStage, DateTime pDateTime, double lModification)
        {
            foreach (DailyRecord lDailyRec in this.CropIrrigationWeatherRecord.DailyRecordList)
            {
                if (Utils.isTheSameDay(pDateTime, lDailyRec.DailyRecordDateTime))
                {
                    lDailyRec.GrowingDegreeDaysModified += lModification;// +lDailyRecord.GrowingDegreeDaysModified;
                    this.CropIrrigationWeatherRecord.GrowingDegreeDaysModified += lModification;
                }
            }
        }


        /// <summary>
        /// Gives the effective lRain registered in a specific date including the input and extraInput value.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public double GetEffectiveRain(DateTime pDate)
        {
            double lRetrun = 0;

            foreach (DailyRecord lDailyRec in this.CropIrrigationWeatherRecord.DailyRecordList)
            {
                if (lDailyRec.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRec.Rain.Input + lDailyRec.Rain.ExtraInput;
                    return lRetrun;
                }
            }
            return lRetrun;
        }
        
        /// <summary>
        /// Get the Hidric Balance from CropIrrigationWeatherRecord
        /// </summary>
        /// <returns></returns>
        public double GetHydricBalance()
        {
            double lReturn = 0;
            lReturn = this.CropIrrigationWeatherRecord.HydricBalance;
            return lReturn;
        }

        public double GetTotalEvapotranspirationCropFromLastWaterInput()
        {
            double lReturn = 0;
            lReturn = this.CropIrrigationWeatherRecord.TotalEvapotranspirationCropFromLastWaterInput;
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