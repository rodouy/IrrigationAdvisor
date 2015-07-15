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
        
        #region Agriculture
        
        private Crop crop;
        private Soil soil;
        
        //Data of Crop
        private DateTime sowingDate;
        private DateTime harvestDate;
        private DateTime cropDate;
        
        #region Crop State
        
        private PhenologicalStage phenologicalStage;
        private Double hydricBalance;
        private Double soilHydricVolume;
        private Double totalEvapotranspirationCropFromLastWaterInput;

        #endregion

        #region Calculus by Days After Sowing

        private bool usingDaysAfterSowingForPhenologicalAdjustment;
        private int dayAfterSowing;
        private int dayAfterSowingModified;
        private PhenologicalStage phenologicalStageByDayAfterSowing;
        
        #endregion

        #region Calculus by Growing Degree Days
        
        private bool usingGrowingDegreeDaysForPhenologicalAdjustment;
        private double growingDegreeDaysAccumulated;
        private double growingDegreeDaysModified;
        private PhenologicalStage phenologicalStageByGrowingDegreeDays;

        #endregion

        #endregion

        #region Irrigation

        private IrrigationUnit irrigationUnit;
        private double predeterminatedIrrigationQuantity;
        
        #endregion

        #region Localization

        private Location location;

        #endregion

        #region Water

        private List<EffectiveRain> effectiveRainList;
        private List<Rain> rainList;
        private List<Water.Irrigation> irrigationList;
        private List<EvapotranspirationCrop> evapotranspirationCropList;
        
        //Input Water Data
        private DateTime lastWaterInputDate;
        private DateTime lastBigWaterInputDate;
        private DateTime lastPartialWaterInputDate;
        private Double lastPartialWaterInput;

        #endregion

        #region Weather

        private WeatherStation mainWeatherStation;
        private WeatherStation alternativeWeatherStation;
        private bool usingMainWeatherStation;

        #endregion
        
        #region Daily Data

        private List<DailyRecord> dailyRecordList;

        #endregion

        #region Totals
        
        private double totalEvapotranspirationCrop;
        private double totalEffectiveRain;
        private double totalRealRain;
        private double totalIrrigation;
        private double totalIrrigationInHidricBalance;
        private double totalExtraIrrigation;
        private double totalExtraIrrigationInHidricBalance;

        #endregion

        #region Extra Print Data

        private String outPut;

        private List<String> titles;
        private List<List<String>> messages;
        private List<String> titlesDaily;
        private List<List<String>> messagesDaily;

        #endregion

        #endregion


        #region Properties

        public long CropIrrigationWeatherId
        {
            get { return cropIrrigationWeatherId; }
            set { cropIrrigationWeatherId = value; }
        }

        #region Agriculture

        public Crop Crop
        {
            get { return crop; }
            set { crop = value; }
        }
        
        public Soil Soil
        {
            get { return soil; }
            set { soil = value; }
        }

        #region Data of Crop

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

        public DateTime CropDate
        {
            get { return cropDate; }
            set { cropDate = value; }
        }

        #endregion

        #region CropState

        public PhenologicalStage PhenologicalStage
        {
            get { return phenologicalStage; }
            set { phenologicalStage = value; }
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

        public double TotalEvapotranspirationCropFromLastWaterInput
        {
            get { return totalEvapotranspirationCropFromLastWaterInput; }
            set { totalEvapotranspirationCropFromLastWaterInput = value; }
        }

        #endregion

        #region CalculusByDaysAfterSowing

        public bool UsingDaysAfterSowingForPhenologicalAdjustment
        {
            get { return usingDaysAfterSowingForPhenologicalAdjustment; }
            set { usingDaysAfterSowingForPhenologicalAdjustment = value; }
        }

        public int DayAfterSowing
        {
            get { return dayAfterSowing; }
            set { dayAfterSowing = value; }
        }

        public int DayAfterSowingModified
        {
            get { return dayAfterSowingModified; }
            set { dayAfterSowingModified = value; }
        }

        public PhenologicalStage PhenologicalStageByDayAfterSowing
        {
            get { return phenologicalStageByDayAfterSowing; }
            set { phenologicalStageByDayAfterSowing = value; }
        }

        #endregion

        #region CalculusByGrowingDegreeDays

        public bool UsingGrowingDegreeDaysForPhenologicalAdjustment
        {
            get { return usingGrowingDegreeDaysForPhenologicalAdjustment; }
            set { usingGrowingDegreeDaysForPhenologicalAdjustment = value; }
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

        public PhenologicalStage PhenologicalStageByGrowingDegreeDays
        {
            get { return phenologicalStageByGrowingDegreeDays; }
            set { phenologicalStageByGrowingDegreeDays = value; }
        }

        #endregion

        #endregion

        #region Irrigation
        
        public IrrigationUnit IrrigationUnit
        {
            get { return irrigationUnit; }
            set { irrigationUnit = value; }
        }

        public double PredeterminatedIrrigationQuantity
        {
            get { return predeterminatedIrrigationQuantity; }
            set { predeterminatedIrrigationQuantity = value; }
        }

        #endregion

        #region Localization
        
        public Location Location
        {
            get { return location; }
            set { location = value; }
        }
        
        #endregion

        #region Water
        
        public List<EffectiveRain> EffectiveRainList
        {
            get { return effectiveRainList; }
            set { effectiveRainList = value; }
        }
        
        public List<Water.Rain> RainList
        {
            get { return rainList; }
            set { rainList = value; }
        }

        public List<Water.Irrigation> IrrigationList
        {
            get { return irrigationList; }
            set { irrigationList = value; }
        }

        public List<EvapotranspirationCrop> EvapotranspirationCropList
        {
            get { return evapotranspirationCropList; }
            set { evapotranspirationCropList = value; }
        }

        #region Input Water Data

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

        public double LastPartialWaterInput
        {
            get { return lastPartialWaterInput; }
            set { lastPartialWaterInput = value; }
        }

        #endregion

        #endregion

        #region Weather

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

        public bool UsingMainWeatherStation
        {
            get { return usingMainWeatherStation; }
            set { usingMainWeatherStation = value; }
        }
        
        #endregion

        #region Daily Data

        public List<DailyRecord> DailyRecordList
        {
            get { return dailyRecordList; }
            //set { dailyRecordList = value; }
        }

        #endregion

        #region Totals

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

        public double TotalRealRain
        {
            get { return totalRealRain; }
            set { totalRealRain = value; }
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

        #region Extra Print Data

        public String OutPut
        {
            get { return outPut; }
            set { outPut = value; }
        }

        public List<String> Titles
        {
            get { return titles; }
            set { titles = value; }
        }

        public List<List<String>> Messages
        {
            get { return messages; }
            set { messages = value; }
        }

        public List<String> TitlesDaily
        {
            get { return titlesDaily; }
            set { titlesDaily = value; }
        }

        public List<List<String>> MessagesDaily
        {
            get { return messagesDaily; }
            set { messagesDaily = value; }
        }

        #endregion

        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// PredeterminatedIrrigationQuantity = 20
        /// </summary>
        public CropIrrigationWeather() 
        {
            this.CropIrrigationWeatherId = 0;
            
            this.Crop = new Crop();
            this.Soil = new Soil();
            
            this.SowingDate = new DateTime();
            this.HarvestDate = new DateTime();
            this.CropDate = new DateTime();

            //Crop State
            this.PhenologicalStage = new PhenologicalStage();
            this.HydricBalance = 0;
            this.SoilHydricVolume = 0;
            this.TotalEvapotranspirationCropFromLastWaterInput = 0;

            //Calculus by Days After Sowing
            this.UsingDaysAfterSowingForPhenologicalAdjustment = true;
            this.DayAfterSowing = 1;
            this.DayAfterSowingModified = 1;
            this.PhenologicalStageByDayAfterSowing = new PhenologicalStage();

            //Calculus by Growing Degree Days
            this.UsingGrowingDegreeDaysForPhenologicalAdjustment = true;
            this.GrowingDegreeDaysAccumulated = 0;
            this.GrowingDegreeDaysModified = 0;
            this.PhenologicalStageByGrowingDegreeDays = new PhenologicalStage();

            //Irrigation
            this.IrrigationUnit = new Irrigation.IrrigationUnit();
            this.PredeterminatedIrrigationQuantity = 20;
            
            //Localization
            this.Location = new Location();
            
            //Water
            this.EffectiveRainList = new List<EffectiveRain>();
            this.RainList = new List<Rain>();
            this.IrrigationList = new List<Water.Irrigation>();
            this.EvapotranspirationCropList = new List<EvapotranspirationCrop>();

            //Input Water Data
            this.LastWaterInputDate = new DateTime();
            this.LastBigWaterInputDate = new DateTime();
            this.LastPartialWaterInputDate = new DateTime();
            this.LastPartialWaterInput = 0;

            //Weather
            this.MainWeatherStation = new WeatherStation();
            this.AlternativeWeatherStation = new WeatherStation();
            this.UsingMainWeatherStation = true;

            //Daily Data
            this.dailyRecordList = new List<DailyRecord>();

            //Totals
            this.TotalEvapotranspirationCrop = 0;
            this.TotalEffectiveRain = 0;
            this.TotalRealRain = 0;
            this.TotalIrrigation = 0;
            this.totalIrrigationInHidricBalance = 0;
            this.TotalExtraIrrigation = 0;
            this.TotalExtraIrrigationInHidricBalance = 0;

            //Extra Print Data
            this.Titles = new List<string>();
            this.Messages = new List<List<string>>();
            this.TitlesDaily = new List<string>();
            this.MessagesDaily = new List<List<string>>();

            this.outPut = printHeader();

        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pCropIrrigationWeatherId"></param>
        /// <param name="pCrop"></param>
        /// <param name="pSoil"></param>
        /// <param name="pSowingDate"></param>
        /// <param name="pHarvestDate"></param>
        /// <param name="pCropDate"></param>
        /// <param name="pPhenologicalStage"></param>
        /// <param name="pHidricBalance"></param>
        /// <param name="pSoilHidricVolume"></param>
        /// <param name="pTotalEvapotranspirationCropFromLastWaterInput"></param>
        /// <param name="pUsingDaysAfterSowingForPhenologicalAdjustment"></param>
        /// <param name="pDayAfterSowing"></param>
        /// <param name="pDayAfterSowingModified"></param>
        /// <param name="pPhenologicalStageByDayAfterSowing"></param>
        /// <param name="pUsingGrowingDegreeDaysForPhenologicalAdjustment"></param>
        /// <param name="pGrowingDegreeDaysAcumulated"></param>
        /// <param name="pGrowingDegreeDaysModified"></param>
        /// <param name="pPhenologicalStageByGrowingDegreeDays"></param>
        /// <param name="pIrrigationUnit"></param>
        /// <param name="pPredeterminatedIrrigationQuantity"></param>
        /// <param name="pLocation"></param>
        /// <param name="pEffectiveRain"></param>
        /// <param name="pRainList"></param>
        /// <param name="pIrrigationList"></param>
        /// <param name="pEvapotranspirationCropList"></param>
        /// <param name="pLastWaterInputDate"></param>
        /// <param name="pLastBigWaterInputDate"></param>
        /// <param name="pLastPartialWaterInputDate"></param>
        /// <param name="pLastPartialWaterInput"></param>
        /// <param name="pMainWeatherStation"></param>
        /// <param name="pAlternativeWeatherStation"></param>
        /// <param name="pUsingMainWeatherStation"></param>
        /// <param name="pDailyRecords"></param>
        public CropIrrigationWeather(long pCropIrrigationWeatherId, Crop pCrop, Soil pSoil,
                                DateTime pSowingDate, DateTime pHarvestDate, DateTime pCropDate,
                                PhenologicalStage pPhenologicalStage, Double pHidricBalance, Double pSoilHidricVolume,
                                Double pTotalEvapotranspirationCropFromLastWaterInput,
                                bool pUsingDaysAfterSowingForPhenologicalAdjustment,
                                int pDayAfterSowing, int pDayAfterSowingModified, PhenologicalStage pPhenologicalStageByDayAfterSowing,
                                bool pUsingGrowingDegreeDaysForPhenologicalAdjustment,
                                Double pGrowingDegreeDaysAcumulated, Double pGrowingDegreeDaysModified,
                                PhenologicalStage pPhenologicalStageByGrowingDegreeDays,
                                IrrigationUnit pIrrigationUnit, Double pPredeterminatedIrrigationQuantity, Location pLocation,
                                List<EffectiveRain> pEffectiveRain, List<Rain> pRainList, 
                                List<Water.Irrigation> pIrrigationList, List<EvapotranspirationCrop> pEvapotranspirationCropList,
                                DateTime pLastWaterInputDate, DateTime pLastBigWaterInputDate, 
                                DateTime pLastPartialWaterInputDate, Double pLastPartialWaterInput,
                                WeatherStation pMainWeatherStation, WeatherStation pAlternativeWeatherStation,
                                bool pUsingMainWeatherStation, List<DailyRecord> pDailyRecords)
        {
            this.CropIrrigationWeatherId = pCropIrrigationWeatherId;
            
            this.Crop = pCrop;
            this.Soil = pSoil;

            this.SowingDate = pSowingDate;
            this.HarvestDate = pHarvestDate;
            this.CropDate = pCropDate;

            this.PhenologicalStage = pPhenologicalStage;
            this.HydricBalance = pHidricBalance;
            this.SoilHydricVolume = pSoilHidricVolume;
            this.TotalEvapotranspirationCropFromLastWaterInput = pTotalEvapotranspirationCropFromLastWaterInput;

            this.UsingDaysAfterSowingForPhenologicalAdjustment = pUsingDaysAfterSowingForPhenologicalAdjustment;
            this.DayAfterSowing = pDayAfterSowing;
            this.DayAfterSowingModified = pDayAfterSowingModified;
            this.PhenologicalStageByDayAfterSowing = pPhenologicalStageByDayAfterSowing;

            this.UsingGrowingDegreeDaysForPhenologicalAdjustment = pUsingGrowingDegreeDaysForPhenologicalAdjustment;
            this.GrowingDegreeDaysAccumulated = pGrowingDegreeDaysAcumulated;
            this.GrowingDegreeDaysModified = pGrowingDegreeDaysModified;
            this.PhenologicalStageByGrowingDegreeDays = pPhenologicalStageByGrowingDegreeDays;

            this.IrrigationUnit = pIrrigationUnit;
            this.PredeterminatedIrrigationQuantity = pPredeterminatedIrrigationQuantity;

            this.Location = pLocation;
            
            this.EffectiveRainList = pEffectiveRain;
            this.RainList = pRainList;
            this.IrrigationList = pIrrigationList;
            this.EvapotranspirationCropList = pEvapotranspirationCropList;

            this.LastWaterInputDate = pLastWaterInputDate;
            this.LastBigWaterInputDate = pLastBigWaterInputDate;
            this.LastPartialWaterInputDate = pLastPartialWaterInputDate;
            this.LastPartialWaterInput = pLastPartialWaterInput;
            
            this.MainWeatherStation = pMainWeatherStation;
            this.AlternativeWeatherStation = pAlternativeWeatherStation;
            this.UsingMainWeatherStation = pUsingMainWeatherStation;

            this.dailyRecordList = pDailyRecords;

            this.TotalEvapotranspirationCrop = 0;
            this.TotalEffectiveRain = 0;
            this.TotalRealRain = 0;
            this.TotalIrrigation = 0;
            this.TotalIrrigationInHidricBalance = 0;
            this.TotalExtraIrrigation = 0;
            this.TotalExtraIrrigationInHidricBalance = 0;
            
            this.Titles = new List<string>();
            this.Messages = new List<List<string>>();
            this.TitlesDaily = new List<string>();
            this.MessagesDaily = new List<List<string>>();
            this.outPut = "";

        }
        
        #endregion

        #region Private Helpers

        /// <summary>
        /// Calculate the GrowingDegreeDays and update the GrowingDegreeDaysAccumulated and GrowingDegreeDaysModified
        /// </summary>
        /// <param name="pBaseTemperature"></param>
        /// <param name="pAverageTemperature"></param>
        /// <returns></returns>
        private Double calculateGrowingDegreeDays(Double pBaseTemperature, Double pAverageTemperature)
        {
            Double lReturn = 0;
            Double lGrowingDegreeDays = 0;

            lGrowingDegreeDays = pAverageTemperature - pBaseTemperature;
            this.GrowingDegreeDaysAccumulated += lGrowingDegreeDays;
            this.GrowingDegreeDaysModified += lGrowingDegreeDays;

            lReturn = lGrowingDegreeDays;
            return lReturn;
        }
        
        /// <summary>
        /// Get the first DailyRecord from the list order by date with the  Growing Degree Days Accumulated
        /// greater than the parameter degrees
        /// </summary>
        /// <param name="pGrowingDegreeDays"></param>
        /// <returns></returns>
        private DailyRecord getDailyRecordByGrowingDegreeDaysAccumulated(Double pGrowingDegreeDays)
        {
            DailyRecord lRetrun = null;
            IEnumerable<DailyRecord> lDailyRecordOrderByDate = null;

            if (pGrowingDegreeDays > 0)
            {
                lDailyRecordOrderByDate = this.DailyRecordList.OrderBy(lDailyRecord => lDailyRecord.DailyRecordDateTime);

                foreach (DailyRecord lDailyRecord in lDailyRecordOrderByDate)
                {
                    //Compare Dates, is not important the Time
                    if (pGrowingDegreeDays <= lDailyRecord.GrowingDegreeDaysAccumulated)
                    {
                        lRetrun = lDailyRecord;
                    }
                }
            }

            return lRetrun;
        }

        /// <summary>
        /// Return the effectiveness of a Rain depending on:
        /// -the amount of rain 
        /// -the month of the year
        /// This information is stored as a percentage in a field called EffectiveRainList that is a List<EffectiveRain>
        /// </summary>
        /// <param name="pRain"></param>
        /// <returns></returns>
        private double getEffectiveRainValue(WaterInput pRain)
        {
            double pReturn = 0;
            if (pRain != null)
            {
                IEnumerable<EffectiveRain> lEffectiveRainListOrderByMonth = this.EffectiveRainList.OrderBy(lEffectiveRain => lEffectiveRain.Month);
                foreach (EffectiveRain lEffectiveRain in lEffectiveRainListOrderByMonth)
                {
                    if (pRain.Date.Month == lEffectiveRain.Month && lEffectiveRain.MinRain <= pRain.getTotalInput() && lEffectiveRain.MaxRain >= pRain.getTotalInput())
                    {
                        double totalInput = pRain.getTotalInput();
                        pReturn = pRain.getTotalInput() * lEffectiveRain.Percentage / 100;
                        return pReturn;
                    }
                }
            }
            return pReturn; ;
        }

        /// <summary>
        /// Change the PhenologicalStage of the crop depending of the growing degree acumulated plus the adjustment
        /// </summary>
        private void reviewPhenologicalStageByGrowingDegreeDays()
        {
            PhenologicalStage lOldPhenStage = null;
            double lOldDepth = 0;
            PhenologicalStage lNewPhenStage = null;
            double lNewDepth = 0;
            double lModifiedGrowingDegreeDays;
            double lDepthDifference;
            double lPercentageOfAvailableWater;

            lOldPhenStage = this.PhenologicalStage;
            lOldDepth = this.GetPhenologicalStageDepth(this.PhenologicalStage);

            //get the modified degrees days
            lModifiedGrowingDegreeDays = this.GrowingDegreeDaysModified;
            //Get the percentage of availableWater before to actualize the phenology state 
            lPercentageOfAvailableWater = this.GetPercentageOfAvailableWater();

            //Update Phenological Stage depending on the GrowingDegreeDaysModified
            this.UpdatePhenologicalStage(lModifiedGrowingDegreeDays);
            lNewDepth = this.GetPhenologicalStageDepth(this.PhenologicalStage);
            lNewPhenStage = this.PhenologicalStage;

            //Si aumenta la profundidad de raiz agrego al balance hidrico el agua de la nueva 
            //parte del suelo que se considera (a Capacidad de campo)
            if (lOldPhenStage != null && lNewPhenStage != null && lOldDepth < lNewDepth)
            {
                //TODO get field capacity by horizon of soil (parameters: horizon depth, root depth difference)
                lDepthDifference = lNewDepth - lOldDepth;
                this.HydricBalance += this.GetFieldCapacity(lDepthDifference);
            }

            //Si disminuye la profundidad de raiz agrego al balance hidrico el agua de la nueva 
            //parte del suelo que se considera (a Capacidad de campo)
            if (lOldPhenStage != null && lNewPhenStage != null && lOldDepth > lNewDepth)
            {
                this.HydricBalance = (this.GetSoilAvailableWaterCapacity() * lPercentageOfAvailableWater / 100)
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
                lDaysBetweenIrrigations = Utilities.Utils.GetDaysDifference(this.LastPartialWaterInputDate, pDailyRec.DailyRecordDateTime);

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
                this.HydricBalance += lEffectiveIrrigationTotal;

                // If the lIrrigation is bigger than 10 mm set the last water input
                if (lEffectiveIrrigationTotal > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    this.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.GetTotalInput();
                    this.LastWaterInputDate = pDailyRec.DailyRecordDateTime;
                    pThereIsWaterInput = true;
                }
                // If two "partial" water inputs, between 3 days, are bigger than 10 mm then set the last water input
                else if (lDaysBetweenIrrigations <= InitialTables.DAYS_BETWEEN_TWO_PARTIAL_BIG_WATER_INPUT)
                {
                    if (lEffectiveIrrigationTotal + this.LastPartialWaterInput > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                    {
                        this.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.GetTotalInput();
                        this.LastWaterInputDate = pDailyRec.DailyRecordDateTime;
                        pThereIsWaterInput = true;
                    }
                }
                else //Registry the effective lIrrigation and its date as a PartialWaterInput
                {
                    this.LastPartialWaterInput = lEffectiveIrrigationTotal;
                    this.LastPartialWaterInputDate = pDailyRec.DailyRecordDateTime;
                }

                // If the HidricBalance is bigger than the FieldCapacity set the HidricBalance as de FieldCapacity  
                // And take off the lIrrigation not used from ->  TotalIrrigation /  TotalExtraIrrigation
                if (this.HydricBalance > pFieldCapacity)
                {
                    lAmountOfIrrigationNotUsed = this.HydricBalance - pFieldCapacity;
                    this.HydricBalance = pFieldCapacity;

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
                lDaysBetweenRains = Utilities.Utils.GetDaysDifference(this.LastPartialWaterInputDate, pDailyRec.DailyRecordDateTime);

                lRealRain = pDailyRec.Rain.getTotalInput();
                //Calculate Rain Effective Value
                lEffectiveRain = this.getEffectiveRainValue(pDailyRec.Rain);
                this.TotalEffectiveRain += lEffectiveRain;
                this.TotalRealRain += lRealRain;
                this.HydricBalance += lEffectiveRain;

                // If the effective lRain is bigger than 10 mm then set the last water input
                if (lEffectiveRain > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    this.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.GetTotalInput();
                    this.LastWaterInputDate = pDailyRec.DailyRecordDateTime;
                    pThereIsWaterInput = true;
                }
                // If two "partial" water inputs, between 3 days, are bigger than 10 mm then set the last water input
                else if (lDaysBetweenRains <= InitialTables.DAYS_BETWEEN_TWO_PARTIAL_BIG_WATER_INPUT)
                {
                    if (lEffectiveRain + this.LastPartialWaterInput > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                    {
                        this.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.GetTotalInput();
                        this.LastWaterInputDate = pDailyRec.DailyRecordDateTime;
                        pThereIsWaterInput = true;
                    }
                }
                else //Registry the effective lRain and its date as a PartialWaterInput
                {
                    this.LastPartialWaterInput = lEffectiveRain;
                    this.LastPartialWaterInputDate = pDailyRec.DailyRecordDateTime;
                }
                
                // If the HidricBalance is bigger than the FieldCapacity set the HidricBalance as de FieldCapacity and take off the lRain not used -> total lRain
                if (this.HydricBalance >= pFieldCapacity)
                {
                    //We have to save the date to keep the hidric balance unchangable
                    this.LastBigWaterInputDate = pDailyRec.DailyRecordDateTime;

                    //Take off the lRain because (HydricBalanc + lRain) is bigger than FieldCapacity
                    lAmountOfRainNotUsed = this.HydricBalance - pFieldCapacity;
                    this.HydricBalance = pFieldCapacity;
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
            
            lDayAfterSowing = this.DayAfterSowing + 1;
            this.CropDate = pDailyRec.DailyRecordDateTime;
            this.GrowingDegreeDaysAccumulated += pDailyRec.GrowingDegreeDays;
            this.GrowingDegreeDaysModified += pDailyRec.GrowingDegreeDaysModified;

            //Update the Phenological Stage depending in Growing Degree
            reviewPhenologicalStageByGrowingDegreeDays();


            lFieldCapacity = this.GetSoilFieldCapacity();

            //TODO: Erase To debug
            if (pDailyRec.DailyRecordDateTime.Equals(new DateTime(2014, 12, 03)))
            {
                System.Diagnostics.Debugger.Break();
            }
                
            // Evapotraspiration adjustment
            if (pDailyRec.EvapotranspirationCrop != null)
            {
                this.TotalEvapotranspirationCrop += pDailyRec.EvapotranspirationCrop.GetTotalInput();
                this.HydricBalance -= pDailyRec.EvapotranspirationCrop.GetTotalInput();
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
                this.TotalEvapotranspirationCropFromLastWaterInput += pDailyRec.EvapotranspirationCrop.GetTotalInput();
            }

            lFieldCapacity = this.GetSoilFieldCapacity();

            //After a big lRain the HidricBalance keep its value = FieldCapacity for two days
            lDaysAfterBigInputWater = Utilities.Utils.GetDaysDifference(this.LastBigWaterInputDate, pDailyRec.DailyRecordDateTime);
            if (lDaysAfterBigInputWater <= InitialTables.DAYS_HIDRIC_BALANCE_UNCHANGABLE_AFTER_BIG_WATER_INPUT)
            {
                this.HydricBalance = lFieldCapacity;
            }

            //The first days after sowing, hydric balance is maintained at field capacity
            if (lDayAfterSowing <= InitialTables.DAYS_HIDRIC_BALANCE_UNCHANGABLE_AFTER_SOWING)
            {
                this.HydricBalance = lFieldCapacity;
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

            lDayAfterSowing = this.DayAfterSowing - 1;
            lDateOfDayAfterSowing = this.CropDate.AddDays(-1);
            //this.CropIrrigationWeatherRecord.DayAfterSowing = new Pair<int, DateTime>(lDayAfterSowing, lDateOfDayAfterSowing);
            // Evapotraspiration revert
            if (lRecordToDelete.EvapotranspirationCrop != null)
            {
                this.TotalEvapotranspirationCrop -= lRecordToDelete.EvapotranspirationCrop.GetTotalInput();
                this.HydricBalance += lRecordToDelete.EvapotranspirationCrop.GetTotalInput();
            }

            // Rain revert
            if (lRecordToDelete.Rain != null)
            {
                double lEffectiveRain = lRecordToDelete.Rain.getTotalInput();
                double lRealRain = lRecordToDelete.Rain.getTotalInput();
                this.TotalEffectiveRain -= lEffectiveRain;
                this.TotalRealRain -= lRealRain;
                this.HydricBalance -= lEffectiveRain;
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
                this.HydricBalance -= lRecordToDelete.Irrigation.getTotalInput();
                //lThereIsWaterInput = true;
            }
            // If the HidricBalance is bigger than the FieldCapacity set the HidricBalance as de FieldCapacity
            /*if (HydricBalance >= lFieldCapacity)
            {
                this.HydricBalance = lFieldCapacity; ///CAMBIO 2
                this.LastBigWaterInput = pDailyRec.DailyRecordDateTime;
            }

            //After a big lRain the HidricBalance keep its value = FieldCapacity for two days
            if (Utilities.Utils.GetDaysDifference(this.LastBigWaterInput, pDailyRec.DailyRecordDateTime) < 3 && this.HydricBalance < lFieldCapacity)
            {
                this.HydricBalance = lFieldCapacity;
            }

            if (!lThereIsWaterInput)
            {
                this.TotalEvapotranspirationCropFromLastWaterInput += pDailyRec.EvapotranspirationCrop.GetTotalInput();
            }
             */

            // GrowingDegreeDaysAccumulated revert
            this.GrowingDegreeDaysAccumulated -= lRecordToDelete.GrowingDegreeDays;
            this.GrowingDegreeDaysModified -= lRecordToDelete.GrowingDegreeDaysModified;
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

        public int GetDaysAfterSowingForModifiedGrowingDegree()
        {
            int lReturn = 0;
            double lastGDRegistry = 0;
            DateTime lDate = DateTime.MinValue;
            IEnumerable<DailyRecord> lDailyRecordOrderByDate = this.DailyRecordList.OrderBy(lDailyRec => lDailyRec.DailyRecordDateTime);

            foreach (DailyRecord lDailyRec in lDailyRecordOrderByDate)
            {
                if (this.GrowingDegreeDaysModified <= lDailyRec.GrowingDegreeDaysAccumulated && this.GrowingDegreeDaysModified > lastGDRegistry)
                {
                    lDate = lDailyRec.DailyRecordDateTime;
                    lReturn = Utilities.Utils.GetDaysDifference(this.SowingDate, lDate);
                    return lReturn;
                }
                lastGDRegistry = lDailyRec.GrowingDegreeDaysAccumulated;
            }
            return lReturn;
        }

        /// <summary>
        /// Search the DailyRecord for the date passed by parameter.
        /// If find one change the GrowingDegreeDaysModified for this DailyRecord and change the GrowingDegreeDaysModified field 
        /// adding the value passed by parameter as lModification
        /// </summary>
        /// <param name="pStage"></param>
        /// <param name="pDateTime"></param>
        /// <param name="lModification"></param>
        
        public void adjustmentPhenology(Stage pStage, DateTime pDateTime, double lModification)
        {
            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (Utils.IsTheSameDay(pDateTime, lDailyRec.DailyRecordDateTime))
                {
                    lDailyRec.GrowingDegreeDaysModified += lModification;// +lDailyRecord.GrowingDegreeDaysModified;
                    this.GrowingDegreeDaysModified += lModification;
                }
            }
        }

        /// <summary>
        /// Gives the effective lRain registered in a specific date including the input and extraInput value.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public double GetEffectiveRainByDate(DateTime pDate)
        {
            double lRetrun = 0;

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRec.Rain.Input + lDailyRec.Rain.ExtraInput;
                    break;
                }
            }

            return lRetrun;
        }

        /// <summary>
        /// Get the Daily Record by Date in the list
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public DailyRecord GetDailyRecordByDate(DateTime pDate)
        {
            DailyRecord lRetrun = null;

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRec;
                    break;
                }
            }

            return lRetrun;
        }



        /// <summary>
        /// Gives the evapoTranspiration registered in a specific date including the input and extraInput value.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public double GetEvapotranspirationCrop(DateTime pDate)
        {
            double lRetrun = 0;

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRec.EvapotranspirationCrop.Input + lDailyRec.EvapotranspirationCrop.ExtraInput;
                    break;
                }
            }
            return lRetrun;
        }

        /// <summary>
        /// Verify if exist an older Daily Record, and if exists, replece it
        /// </summary>
        /// <param name="pDailyRecordDateTime"></param>
        /// <returns></returns>
        public DailyRecord VerifyUnicityOFDailyRecord(DateTime pDailyRecordDateTime)
        {
            DailyRecord lReturn = null;

            int lIndexToRemove = -1;
            int i = 0;
            foreach (DailyRecord lDailyRecordItem in this.DailyRecordList)
            {
                if (Utils.IsTheSameDay(lDailyRecordItem.DailyRecordDateTime.Date, pDailyRecordDateTime.Date))
                {
                    lIndexToRemove = i;
                    lReturn = lDailyRecordItem;
                }
                i++;
            }
            //We have a unique record by day
            if (lIndexToRemove != -1)
            {
                takeOffDailyRecord(lReturn);
                this.DailyRecordList.RemoveAt(lIndexToRemove);
            }

            return lReturn;

        }

        public double GetLastThreeDaysOfEvapotranspirationCrop(DateTime pDate)
        {
            double lRetrun = 0;
            DateTime oneDayBefore = pDate.AddDays(-1);
            DateTime twoDaysBefore = pDate.AddDays(-2);

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DailyRecordDateTime.Date.Equals(pDate.Date) || lDailyRec.DailyRecordDateTime.Date.Equals(oneDayBefore.Date) ||
                    lDailyRec.DailyRecordDateTime.Date.Equals(twoDaysBefore.Date))
                {
                    lRetrun += lDailyRec.EvapotranspirationCrop.Input + lDailyRec.EvapotranspirationCrop.ExtraInput;
                }
            }
            return lRetrun;
        }

  


        /// <summary>
        /// Gives the growing degree registered in a specific date
        /// </summary>
        /// <param name="pDate">Date of the required information</param>
        /// <returns></returns>
        public double GetGrowingDegree(DateTime pDate)
        {
            double lRetrun = 0;

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRec.GrowingDegreeDays;
                    break;
                }
            }
            return lRetrun;
        }


        /// <summary>
                /// Gives the observation registered in a specific date.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public String GetObservations(DateTime pDate)
        {
            String lRetrun = "";
            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRec.Observations;
                    break;
                }
            }
            return lRetrun;
        }

        /// <summary>
        /// Gives the evapoTranspiration registered in a Date and the two days before, including the input and extraInput value.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        

        public void AddDailyRecordAccordingGrowinDegreeDays(WeatherData pWeatherData,
                                   WeatherData pMainWeatherData, WeatherData pAlternativeWeatherData,
                                   Double pBaseTemperature, Water.Rain pRain, Water.Irrigation pIrrigation,
                                   DateTime pLastWaterInputDate, DateTime pLastBigWaterInputDate,
                                   DateTime pLastPartialWaterInputDate, Double pLastPartialWaterInput,
                                   String pObservations)
        {
            try
            {
                DateTime lDailyRecordDateTime;
                Double lEvapotranspiration;
                Double lGrowingDegreeDays;
                DailyRecord lDailyRecord;
                int lDaysAfterSowing;
                int lDaysAfterSowingModified;
                Double lCropCoefficient;
                Double lEvapotranspirationCropInput;
                WaterOutput lEvapotranspirationCrop;
                DailyRecord lNewDailyRecord;

                lDailyRecordDateTime = pWeatherData.Date;

                lEvapotranspiration = pWeatherData.GetEvapotranspiration();
                //-1 se actualizan los grados dias
                //Growing Degree Days is average temperature menous Base Temperature                
                lGrowingDegreeDays = this.calculateGrowingDegreeDays(pBaseTemperature, pWeatherData.GetAverageTemperature());
                
                //-2 se calculan los DDS y el CropDate????
                lDaysAfterSowing = Utils.GetDaysDifference(this.SowingDate, pWeatherData.Date);
                
                //-3 obtengo el daily record a partir de los grados dias modificados
                //Get days after sowing according degrees days calculated from the accumulated degree days by Daily Records
                lDailyRecord = this.getDailyRecordByGrowingDegreeDaysAccumulated(this.GrowingDegreeDaysModified);

                //-4 calculo los DDS para luego usarlo al buscar el KC
                //If we do not modified GDD, DAS will be 0
                if (lDailyRecord == null)
                {
                    lDaysAfterSowingModified = lDaysAfterSowing;
                }
                else
                {
                    lDaysAfterSowingModified = lDailyRecord.DaysAfterSowing;
                }
                //- con los DDS obtengo el kc
                lCropCoefficient = this.Crop.CropCoefficient.GetCropCoefficient(lDaysAfterSowingModified);


                //-5 calculo ETC
                lEvapotranspirationCropInput = lEvapotranspiration * lCropCoefficient;
                lEvapotranspirationCrop = new EvapotranspirationCrop(pWeatherData.Date, lEvapotranspirationCropInput);

                //We need to update some fields for calculations:
                //  pLastWaterInputDate, pLastBigWaterInputDate, 
                //  pLastPartialWaterInputDate, pLastPartialWaterInput, 
                //  this.HydricBalance, this.SoilHydricVolume,
                //  this.TotalEvapotranspirationCropFromLastWaterInput
                lNewDailyRecord = new DailyRecord(lDailyRecordDateTime, pMainWeatherData, pAlternativeWeatherData,
                                                lDaysAfterSowing, lDaysAfterSowingModified,
                                                lGrowingDegreeDays, this.GrowingDegreeDaysAccumulated, this.GrowingDegreeDaysModified,
                                                pRain, pIrrigation, pLastWaterInputDate, pLastBigWaterInputDate,
                                                pLastPartialWaterInputDate, pLastPartialWaterInput,
                                                lEvapotranspirationCrop, this.HydricBalance, this.SoilHydricVolume,
                                                this.TotalEvapotranspirationCropFromLastWaterInput,
                                                lCropCoefficient, pObservations);

                this.VerifyUnicityOFDailyRecord(lDailyRecordDateTime);


                //If it's the initial registry set the initial Hidric Balance
                if (lDaysAfterSowing == 0)
                {
                    this.HydricBalance = this.GetInitialHydricBalance();
                    this.DayAfterSowing = 0;// new Pair<int, DateTime>(-1, this.CropIrrigationWeatherRecord.SowingDate);
                }
                reviewSummaryData(lNewDailyRecord);


                this.DailyRecordList.Add(lNewDailyRecord);

                this.OutPut += this.PrintState(this);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception in IrrigationSystem.addCropIrrigWeatherToList " + ex.Message);
                throw ex;
                //TODO manage and log the exception

            }
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

            lDepth = this.GetPhenologicalStageDepth(this.PhenologicalStage);
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

            lDepth = this.GetPhenologicalStageDepth(this.PhenologicalStage);
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
            double lDepth = this.GetPhenologicalStageDepth(this.PhenologicalStage);
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

            lHydricBalance = this.HydricBalance;
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

            lHydricBalance = this.HydricBalance;
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
            CropInformationByDate lCropIrrigationByDate;
            
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
                        this.PhenologicalStage = lPhenologicalStage;
                        lNewPhenStage = lPhenologicalStage;
                        return lNewPhenStage;
                    }
                }
            }
            else 
            {
                lCropIrrigationByDate = new CropInformationByDate(this.Crop.Specie, this.SowingDate);
                lStage = lCropIrrigationByDate.GetStage(this.CropDate);
                foreach (PhenologicalStage lPhenologicalStage in lPhenologicalTableOrderByMinDegree)
                {
                    string lStageName = lPhenologicalStage.Stage.Name.ToUpper();
                    if (lPhenologicalStage != null && lStageName.Contains(lStage.Name.ToUpper()))
                    {
                        this.PhenologicalStage = lPhenologicalStage;
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
                if(Utils.IsTheSameDay(lIrrigation.Date,pDayOfIrrigation))
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
                if (Utils.IsTheSameDay(lRain.Date, pDayOfRain))
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
                lGrowingDegreeAcumulated = this.GrowingDegreeDaysAccumulated + lGrowingDegree;

                //Get days after sowing for Modified Growing Degree
                lDays = this.GetDaysAfterSowingForModifiedGrowingDegree();

                if (lDays == 0)
                {
                    lDays = Utils.GetDaysDifference(this.SowingDate, pWeatherData.Date);
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
                lGrowingDegreeAcumulated = this.GrowingDegreeDaysAccumulated + lGrowingDegree;

                //Get days after sowing for Modified Growing Degree
                lDays = this.GetDaysAfterSowingForModifiedGrowingDegree();

                if (lDays == 0)
                {
                    lDays = Utils.GetDaysDifference(this.SowingDate, pWeatherData.Date);
                }

                lKC_CropCoefficient = this.Crop.GetCropCoefficient(lDays);
                lRealEvapotraspiration = lEvapotranspiration * lKC_CropCoefficient;
                lEvapotranspirationCrop = new EvapotranspirationCrop(
                     pWeatherData.Date, lRealEvapotraspiration);
                lNewDailyRecord = null;
                
                lNewDailyRecord = new DailyRecord(pWeatherData.Date, 
                                                pMainWeatherData,
                                                pAlternativeWeatherData,
                                                lDays,
                                                lDays, 
                                                lGrowingDegree,
                                                lGrowingDegreeAcumulated,
                                                lGrowingDegree,
                                                pRain,
                                                pIrrigation,
                                                new DateTime(),
                                                new DateTime(),
                                                new DateTime(),
                                                lKC_CropCoefficient,
                                                lEvapotranspirationCrop,
                                                0,0,0,0,"");
                

                //TODO extract to a new method as "VerifyUnicityOFDailyRecord"
                //Verify if exist an older Daily Record, and if exists, replece it
                int indexToRemove = -1;
                DailyRecord lRecordToDelete = null;
                int i = 0;
                foreach (DailyRecord lDailyRecord in this.DailyRecordList)
                {
                    if (Utils.IsTheSameDay(lDailyRecord.DailyRecordDateTime.Date, pWeatherData.Date))
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
                    this.DailyRecordList.RemoveAt(indexToRemove);
                }

                
                //If it's the initial registry set the initial Hidric Balance
                if (lDays == 0)
                {
                    this.HydricBalance = this.GetInitialHydricBalance();
                    this.DayAfterSowing = 0;// new Pair<int, DateTime>(-1, this.CropIrrigationWeatherRecord.SowingDate);
                }
                reviewSummaryData(lNewDailyRecord);
              

                this.DailyRecordList.Add(lNewDailyRecord);
                
                this.OutPut += this.PrintState(this);
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
            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (Utils.IsTheSameDay(pDateTime, lDailyRec.DailyRecordDateTime))
                {
                    lDailyRec.GrowingDegreeDaysModified += lModification;// +lDailyRecord.GrowingDegreeDaysModified;
                    this.GrowingDegreeDaysModified += lModification;
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

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
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
            lReturn = this.HydricBalance;
            return lReturn;
        }

        public double GetTotalEvapotranspirationCropFromLastWaterInput()
        {
            double lReturn = 0;
            lReturn = this.TotalEvapotranspirationCropFromLastWaterInput;
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

        #region Print

        private string printHeader()
        {
            string lRetrun = Environment.NewLine +
                "DDS " +
                "\tFecha " +
                " \t\tETCAc " +
                " \t\tETC Llu" +
                " \t G.Dia: " +
                " \t G.D. Mod: " +
                " \tB.Hid: " +
                " \t% A.D.: " +
                " \tA.D.: " +
                " \t\tCC: " +
                " \t\tPMP: " +
                " \t\tLlu Ef: " +
                " \tLluv Tot: " +
                " \tFech Ult Llu: " +
                " \t\tRaiz " +
                " \tFenol " +
                "\tTotRiegoCalc: " +
                "\tTotRiegoInBI: " +
                "\tTotRiegoExtra: " +
                "\tTotRiegoExtraInBI: " +
                Environment.NewLine;

            //Add all the Titles in a List of Strings
            if (this.Titles == null)
                this.Titles = new List<string>();
            this.Titles.Add("DDS");
            this.Titles.Add("Fecha");
            this.Titles.Add("ETc-Ac");
            this.Titles.Add("ETc-Llu");
            this.Titles.Add("GDia");
            this.Titles.Add("GDia-Mod");
            this.Titles.Add("B-Hid");
            this.Titles.Add("% Water");
            this.Titles.Add("Ag-Disp");
            this.Titles.Add("CC");
            this.Titles.Add("PMP");
            this.Titles.Add("LLu-Ef");
            this.Titles.Add("Llu-Tot");
            this.Titles.Add("Fecha-Ult-Llu");
            this.Titles.Add("Raiz");
            this.Titles.Add("Fenol");
            this.Titles.Add("RiegoCalc");
            this.Titles.Add("TipoRiego");
            this.Titles.Add("TotRiegoCalcInBI");
            this.Titles.Add("RiegoExtra");
            this.Titles.Add("TotRiegoExtraInBI");

            return lRetrun;
        }

        /// <summary>
        /// Adds data to print daily records
        /// </summary>
        public void AddToPrintDailyRecords()
        {

            List<String> lMessageDaily;

            if (this.TitlesDaily == null)
                this.TitlesDaily = new List<string>();
            this.TitlesDaily.Add("Fecha");
            this.TitlesDaily.Add("GDia");
            this.TitlesDaily.Add("ETc");
            this.TitlesDaily.Add("LLuvia");
            this.TitlesDaily.Add("Riego");
            this.TitlesDaily.Add("KC");
            this.TitlesDaily.Add("Observaciones");


            if (this.MessagesDaily == null)
                this.MessagesDaily = new List<List<string>>();
            foreach (DailyRecord lDR in DailyRecordList)
            {
                lMessageDaily = new List<string>();
                lMessageDaily.Add(lDR.DailyRecordDateTime.ToString());
                lMessageDaily.Add(lDR.GrowingDegreeDays.ToString());
                lMessageDaily.Add(lDR.EvapotranspirationCrop.GetTotalInput().ToString());
                if (lDR.Rain == null)
                {
                    lMessageDaily.Add("0");
                }
                else
                {
                    lMessageDaily.Add(lDR.Rain.getTotalInput().ToString());
                }
                if (lDR.Irrigation == null)
                {
                    lMessageDaily.Add("0");
                }
                else
                {
                    lMessageDaily.Add(lDR.Irrigation.getTotalInput().ToString());
                }
                lMessageDaily.Add(lDR.CropCoefficient.ToString());
                lMessageDaily.Add(lDR.Observations);
                this.MessagesDaily.Add(lMessageDaily);
            }
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <returns></returns>
        public string PrintState(CropIrrigationWeather pCropIrrigationWeather)
        {
            List<String> lMessage;
            string lReturn;
            string lETcAcumulated;
            string lETcFromLastWaterInput;
            string lGrowDegree;
            string lModifiedGrowingDegree;
            string lEffectiveRain;
            string lTotalRain;
            string lHydricBalance;
            string lPercentageOfAvailableWater;
            string lAvailableWater;
            string lFieldCapacity;
            string lPermanentWilingPoint;
            string lIrrigation;
            string lTypeOfIrrigation;
            string lTotIrrInHB;
            string lExtraIrrigation;
            string lTotExtraIrrInHB;


            lReturn = "";
            lETcAcumulated = pCropIrrigationWeather.TotalEvapotranspirationCrop + "        ";
            lETcFromLastWaterInput = this.TotalEvapotranspirationCropFromLastWaterInput + "        ";
            lGrowDegree = this.GrowingDegreeDaysAccumulated + "        ";
            lModifiedGrowingDegree = this.GrowingDegreeDaysModified + "        ";
            lEffectiveRain = pCropIrrigationWeather.TotalEffectiveRain + "        ";
            lTotalRain = pCropIrrigationWeather.TotalRealRain + "        ";
            lHydricBalance = this.HydricBalance.ToString() + "        ";
            lPercentageOfAvailableWater = pCropIrrigationWeather.GetPercentageOfWaterInCrop() + "        ";
            lAvailableWater = pCropIrrigationWeather.GetSoilAvailableWaterCapacity() + "        ";
            lFieldCapacity = pCropIrrigationWeather.GetSoilFieldCapacity() + "        ";
            lPermanentWilingPoint = pCropIrrigationWeather.GetSoilPermanentWiltingPoint() + "        ";

            Water.Irrigation lWaterInput = null;// = this.GetDailyRecordByDate(this.CropDate).Irrigation;
            if (lWaterInput == null)
            {
                lIrrigation = 0 + "        ";
                lExtraIrrigation = 0 + "        ";
                lTypeOfIrrigation = "                                 ";
            }
            else
            {
                lIrrigation = lWaterInput.Input.ToString() + "        ";
                lExtraIrrigation = lWaterInput.ExtraInput.ToString() + "        ";
                lTypeOfIrrigation = lWaterInput.Type.ToString() + "                                 ";
            }
            lTotIrrInHB = pCropIrrigationWeather.TotalIrrigationInHidricBalance.ToString() + "        ";
            lTotExtraIrrInHB = pCropIrrigationWeather.TotalExtraIrrigationInHidricBalance.ToString() + "        ";


            lReturn = this.DayAfterSowing.ToString() +
                " \t " + this.CropDate.ToShortDateString() +
                " \t " + lETcAcumulated.Substring(0, 7) +
                " \t " + lETcFromLastWaterInput.Substring(0, 7) +
                " \t " + lGrowDegree.Substring(0, 7) +
                " \t " + lModifiedGrowingDegree.Substring(0, 7) +
                " \t " + lHydricBalance.Substring(0, 7) +
                " \t " + lPercentageOfAvailableWater.Substring(0, 7) +
                " \t " + lAvailableWater.Substring(0, 7) +
                " \t " + lFieldCapacity.Substring(0, 7) +
                " \t " + lPermanentWilingPoint.Substring(0, 7) +
                " \t " + lEffectiveRain.Substring(0, 7) +
                " \t " + lTotalRain.Substring(0, 7) +
                " \t " + this.LastWaterInputDate.ToShortDateString() +
                " \t\t " + pCropIrrigationWeather.GetPhenologicalStageRootDepth(this.PhenologicalStage) +
                " \tf " + this.PhenologicalStage.Stage.Name +
                " \t " + lIrrigation.Substring(0, 7) +
                " \t " + lTypeOfIrrigation.Substring(0, 30) +
                " \t " + lTotIrrInHB.Substring(0, 7) +
                " \t " + lExtraIrrigation.Substring(0, 7) +
                " \t " + lTotExtraIrrInHB.Substring(0, 7) +
                Environment.NewLine;

            if (this.Messages == null)
                this.Messages = new List<List<string>>();
            lMessage = new List<string>();
            lMessage.Add(this.DayAfterSowing.ToString());
            lMessage.Add(this.CropDate.ToShortDateString());
            lMessage.Add(lETcAcumulated.Substring(0, 7));
            lMessage.Add(lETcFromLastWaterInput.Substring(0, 7));
            lMessage.Add(lGrowDegree.Substring(0, 7));
            lMessage.Add(lModifiedGrowingDegree.Substring(0, 7));
            lMessage.Add(lHydricBalance.Substring(0, 7));
            lMessage.Add(lPercentageOfAvailableWater.Substring(0, 7));
            lMessage.Add(lAvailableWater.Substring(0, 7));
            lMessage.Add(lFieldCapacity.Substring(0, 7));
            lMessage.Add(lPermanentWilingPoint.Substring(0, 7));
            lMessage.Add(lEffectiveRain.Substring(0, 7));
            lMessage.Add(lTotalRain.Substring(0, 7));
            lMessage.Add(this.lastWaterInputDate.ToShortDateString());
            lMessage.Add(pCropIrrigationWeather.GetPhenologicalStageRootDepth(this.PhenologicalStage).ToString());
            lMessage.Add(this.PhenologicalStage.Stage.Name);
            lMessage.Add(lIrrigation.Substring(0, 7));
            lMessage.Add(lTypeOfIrrigation.Substring(0, 30));
            lMessage.Add(lTotIrrInHB.Substring(0, 7));
            lMessage.Add(lExtraIrrigation.Substring(0, 7));
            lMessage.Add(lTotExtraIrrInHB.Substring(0, 7));

            this.Messages.Add(lMessage);

            return lReturn;
        }

        #endregion



    }
}