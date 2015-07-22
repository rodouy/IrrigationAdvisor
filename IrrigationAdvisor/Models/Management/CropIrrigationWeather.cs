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
    ///     - GetPercentageOfAvailableWaterTakingIntoAccointPermanentWiltingPoint(): double
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
        
        #region Data of Crop
        
        private DateTime sowingDate;
        private DateTime harvestDate;
        private DateTime cropDate;

        #endregion

        #region Crop State

        private PhenologicalStage phenologicalStage;
        private Double hydricBalance;
        private Double soilHydricVolume;
        private Double totalEvapotranspirationCropFromLastWaterInput;

        #endregion

        #region Calculus of Phenological Adjustment

        private Utils.CalculusOfPhenologicalStage calculusMethodForPhenologicalAdjustment;
        private CropInformationByDate cropInformationByDate;
        private int dayAfterSowing;
        private int dayAfterSowingModified;
        private double growingDegreeDaysAccumulated;
        private double growingDegreeDaysModified;
        
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
        
        //Output Water Data
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
        private double totalIrrigationInHydricBalance;
        private double totalExtraIrrigation;
        private double totalExtraIrrigationInHydricBalance;

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

        #region Calculus of Phenological Adjustment

        public Utils.CalculusOfPhenologicalStage CalculusMethodForPhenologicalAdjustment
        {
            get { return calculusMethodForPhenologicalAdjustment; }
        }

        public CropInformationByDate CropInformationByDate
        {
            get { return cropInformationByDate; }
        }

        public int DaysAfterSowing
        {
            get { return dayAfterSowing; }
            set { dayAfterSowing = value; }
        }

        public int DaysAfterSowingModified
        {
            get { return dayAfterSowingModified; }
            set { dayAfterSowingModified = value; }
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

        #region Output Water Data

        /// <summary>
        /// Date of Rain bigger than CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED
        /// </summary>
        public DateTime LastWaterInputDate
        {
            get { return lastWaterInputDate; }
            set { lastWaterInputDate = value; }
        }

        /// <summary>
        /// Date of Rain that make the Hydric Balance bigger than Field Capacity
        /// </summary>
        public DateTime LastBigWaterInputDate
        {
            get { return lastBigWaterInputDate; }
            set { lastBigWaterInputDate = value; }
        }

        /// <summary>
        /// Date of Rain smaller than CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED
        /// </summary>
        public DateTime LastPartialWaterInputDate
        {
            get { return lastPartialWaterInputDate; }
            set { lastPartialWaterInputDate = value; }
        }

        /// <summary>
        /// Rain smaller than CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED
        /// </summary>
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

        public double TotalIrrigationInHydricBalance
        {
            get { return totalIrrigationInHydricBalance; }
            set { totalIrrigationInHydricBalance = value; }
        }

        public double TotalExtraIrrigation
        {
            get { return totalExtraIrrigation; }
            set { totalExtraIrrigation = value; }
        }

        public double TotalExtraIrrigationInHydricBalance
        {
            get { return totalExtraIrrigationInHydricBalance; }
            set { totalExtraIrrigationInHydricBalance = value; }
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

            //Calculus of Phenological Adjustment
            this.calculusMethodForPhenologicalAdjustment = Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays;
            this.cropInformationByDate = null;
            this.DaysAfterSowing = 1;
            this.DaysAfterSowingModified = 1;
            this.GrowingDegreeDaysAccumulated = 0;
            this.GrowingDegreeDaysModified = 0;
            
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

            //Output Water Data
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

            #region Totals

            this.TotalEvapotranspirationCrop = 0;
            this.TotalEffectiveRain = 0;
            this.TotalRealRain = 0;
            this.TotalIrrigation = 0;
            this.totalIrrigationInHydricBalance = 0;
            this.TotalExtraIrrigation = 0;
            this.TotalExtraIrrigationInHydricBalance = 0;
            
            #endregion


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
        /// <param name="pCalculusMethodForPhenologicalAdjustment"></param>
        /// <param name="pCropInformationByDate"></param>
        /// <param name="pDayAfterSowing"></param>
        /// <param name="pDayAfterSowingModified"></param>
        /// <param name="pGrowingDegreeDaysAcumulated"></param>
        /// <param name="pGrowingDegreeDaysModified"></param>
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
                                Utils.CalculusOfPhenologicalStage pCalculusMethodForPhenologicalAdjustment,
                                CropInformationByDate pCropInformationByDate,
                                int pDayAfterSowing, int pDayAfterSowingModified, 
                                Double pGrowingDegreeDaysAcumulated, Double pGrowingDegreeDaysModified,
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

            this.calculusMethodForPhenologicalAdjustment = pCalculusMethodForPhenologicalAdjustment;
            if(pCalculusMethodForPhenologicalAdjustment == Utilities.Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing)
            {
                this.cropInformationByDate = pCropInformationByDate;
            }
            if(pCalculusMethodForPhenologicalAdjustment == Utilities.Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays)
            {
                this.cropInformationByDate = null;
            }
            this.DaysAfterSowing = pDayAfterSowing;
            this.DaysAfterSowingModified = pDayAfterSowingModified;
            this.GrowingDegreeDaysAccumulated = pGrowingDegreeDaysAcumulated;
            this.GrowingDegreeDaysModified = pGrowingDegreeDaysModified;
            
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
            this.TotalIrrigationInHydricBalance = 0;
            this.TotalExtraIrrigation = 0;
            this.TotalExtraIrrigationInHydricBalance = 0;
            
            this.Titles = new List<string>();
            this.Messages = new List<List<string>>();
            this.TitlesDaily = new List<string>();
            this.MessagesDaily = new List<List<string>>();
            this.outPut = "";

        }
        
        #endregion

        #region Private Helpers

        /// <summary>
        /// Return the effectiveness of a Rain depending on:
        ///  the amount of rain, 
        ///  the month of the year.
        /// This information is stored as a percentage in a field called EffectiveRainList that is a List of EffectiveRain
        /// </summary>
        /// <param name="pRain"></param>
        /// <returns></returns>
        private Double getEffectiveRainValue(WaterInput pRain)
        {
            Double lReturn = 0;
            IEnumerable<EffectiveRain> lEffectiveRainListOrderByMonth = null;
            Double lRainTotalInput = 0;

            if (pRain != null)
            {
                lEffectiveRainListOrderByMonth = this.EffectiveRainList.OrderBy(lEffectiveRain => lEffectiveRain.Month);
                foreach (EffectiveRain lEffectiveRain in lEffectiveRainListOrderByMonth)
                {
                    lRainTotalInput = pRain.GetTotalInput();
                    if (lEffectiveRain.Month == pRain.Date.Month 
                        && lEffectiveRain.MinRain <= lRainTotalInput
                        && lEffectiveRain.MaxRain >= lRainTotalInput)
                    {
                        
                        lReturn = lRainTotalInput * lEffectiveRain.Percentage / 100;
                        break;
                    }
                }
            }
            return lReturn; 
        }

        /// <summary>
        /// Calculate the GrowingDegreeDays and update the GrowingDegreeDaysAccumulated and GrowingDegreeDaysModified
        /// </summary>
        /// <param name="pBaseTemperature"></param>
        /// <param name="pAverageTemperature"></param>
        /// <returns></returns>
        private Double calculateGrowingDegreeDaysForOneDay(Double pBaseTemperature, Double pAverageTemperature)
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
        /// Calculate the DaysAfterSowing and update the DaysAfterSowing and DaysAfterSowingModified
        /// </summary>
        /// <param name="pSowingDate"></param>
        /// <param name="pDate"></param>
        /// <returns></returns>
        private int calculateDaysAfterSowingForOneDay(DateTime pSowingDate, DateTime pDate)
        {
            int lReturn = 0;
            int lDaysAfterSowing = 0;

            if(pSowingDate != null && pDate != null)
            {
                if(pSowingDate < pDate)
                {
                    lDaysAfterSowing = Utils.GetDaysDifference(pSowingDate, pDate);
                    this.DaysAfterSowing += 1;
                    this.DaysAfterSowingModified = lDaysAfterSowing;
                }
            }

            lReturn = lDaysAfterSowing;
            return lReturn;
        }
        
        /// <summary>
        /// Get the first DailyRecord from the list order by date with the  Growing Degree Days Accumulated
        /// greater or equals than the parameter degrees.
        /// If is it not find, return null.
        /// </summary>
        /// <param name="pGrowingDegreeDays"></param>
        /// <returns></returns>
        private DailyRecord getDailyRecordByGrowingDegreeDaysAccumulated(Double pGrowingDegreeDays)
        {
            DailyRecord lRetrun = null;
            DailyRecord lDailyRecordByGrowingDegreeDaysAccumulated = null;
            IEnumerable<DailyRecord> lDailyRecordOrderByDate = null;

            if (pGrowingDegreeDays >= 0)
            {
                lDailyRecordOrderByDate = this.DailyRecordList.OrderBy(lDailyRecord => lDailyRecord.DailyRecordDateTime);

                foreach (DailyRecord lDailyRecordItem in lDailyRecordOrderByDate)
                {
                    //Compare Dates, is not important the Time
                    if (pGrowingDegreeDays <= lDailyRecordItem.GrowingDegreeDaysAccumulated)
                    {
                        lDailyRecordByGrowingDegreeDaysAccumulated = lDailyRecordItem;
                        break;
                    }
                }
            }

            lRetrun = lDailyRecordByGrowingDegreeDaysAccumulated;
            return lRetrun;
        }

        /// <summary>
        /// Get the first DailyRecord from the list order by date with the Days After Sowing 
        /// greater or equals than the parameter days.
        /// If is it not find, return null.
        /// </summary>
        /// <param name="pDaysAfterSowingModified"></param>
        /// <returns></returns>
        private DailyRecord getDailyRecordByDaysAfterSowingAccumulated(int pDaysAfterSowing)
        {
            DailyRecord lRetrun = null;
            IEnumerable<DailyRecord> lDailyRecordOrderByDate = null;

            if (pDaysAfterSowing >= 0)
            {
                lDailyRecordOrderByDate = this.DailyRecordList.OrderBy(lDailyRecord => lDailyRecord.DailyRecordDateTime);

                foreach (DailyRecord lDailyRecord in lDailyRecordOrderByDate)
                {
                    //Compare Dates, is not important the Time
                    if (pDaysAfterSowing <= lDailyRecord.DaysAfterSowing)
                    {
                        lRetrun = lDailyRecord;
                    }
                }
            }

            return lRetrun;
        }

        







        /// <summary>
        /// Make the Irrigation adjustment
        /// Return the Effective Irrigation added to Hydric Balance
        /// </summary>
        /// <param name="pDailyRecord"></param>
        /// <param name="pFieldCapacity"></param>
        /// <returns></returns>
        private Double irrigationAdjustment(DailyRecord pDailyRecord, Double pFieldCapacity)
        {
            Double lReturn;
            Double lEffectiveIrrigation = 0;
            Double lEffectiveIrrigationExtra = 0;
            Double lEffectiveIrrigationTotal = 0;
            Double lIrrigationEfficiency = 0;
            Double lAmountOfIrrigationNotUsed = 0;
            int lDaysBetweenIrrigations = 0;
            Double lEffectiveRain = 0;

            if (pDailyRecord.Rain != null)
            {
                lEffectiveRain = this.getEffectiveRainValue(pDailyRecord.Rain);
                if(lEffectiveRain > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    lEffectiveRain = 0;
                }
            }

            if (pDailyRecord.Irrigation != null)
            {
                lDaysBetweenIrrigations = Utilities.Utils.GetDaysDifference(this.LastPartialWaterInputDate, pDailyRecord.DailyRecordDateTime);

                // Calculate de effective Irrigation depending on the irrigation efficiency of the Pivot
                lIrrigationEfficiency = this.IrrigationUnit.IrrigationEfficiency;

                //Effective Irrigation
                lEffectiveIrrigation = pDailyRecord.Irrigation.Input * lIrrigationEfficiency;
                lEffectiveIrrigationExtra = pDailyRecord.Irrigation.ExtraInput * lIrrigationEfficiency;
                lEffectiveIrrigationTotal = lEffectiveIrrigation + lEffectiveIrrigationExtra;

                this.TotalIrrigation += lEffectiveIrrigation;
                this.TotalIrrigationInHydricBalance += lEffectiveIrrigation;

                this.TotalExtraIrrigation += lEffectiveIrrigationExtra;
                this.TotalExtraIrrigationInHydricBalance += lEffectiveIrrigationExtra;

                //Add to Hidric Balance the lIrrigationItem calculated (Output) and the extra lIrrigationItem (ExtraOutput) 
                this.HydricBalance += lEffectiveIrrigationTotal;

                // If the lIrrigationItem is bigger than 10 mm set the last water output
                if (lEffectiveIrrigationTotal > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    this.TotalEvapotranspirationCropFromLastWaterInput = 0;
                    this.LastWaterInputDate = pDailyRecord.DailyRecordDateTime;
                }
                // If two "partial" water inputs, between 3 days, are bigger than 10 mm then set the last water output
                else if (lDaysBetweenIrrigations <= InitialTables.DAYS_BETWEEN_TWO_PARTIAL_BIG_WATER_INPUT)
                {
                    if (lEffectiveIrrigationTotal + this.LastPartialWaterInput > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                    {
                        this.TotalEvapotranspirationCropFromLastWaterInput = 0;
                        this.LastWaterInputDate = pDailyRecord.DailyRecordDateTime;
                        //This irrigation is the last Partial Water
                        this.LastPartialWaterInput = lEffectiveIrrigationTotal + lEffectiveRain;
                        this.LastPartialWaterInputDate = pDailyRecord.DailyRecordDateTime;
                    }
                }
                else //Registry the effective lIrrigationItem and its date as a PartialWaterInput
                {
                    this.LastPartialWaterInput = lEffectiveIrrigationTotal + lEffectiveRain;
                    this.LastPartialWaterInputDate = pDailyRecord.DailyRecordDateTime;
                }

                // If HydricBalance is bigger than FieldCapacity set HydricBalance equals to FieldCapacity  
                // And take off the Irrigation not used from TotalIrrigation and/or TotalExtraIrrigation
                if (this.HydricBalance > pFieldCapacity)
                {
                    lAmountOfIrrigationNotUsed = this.HydricBalance - pFieldCapacity;
                    this.HydricBalance = pFieldCapacity;

                    //We can take all off from Effective Irrigatin
                    if (lEffectiveIrrigation >= lAmountOfIrrigationNotUsed)
                    {
                        this.TotalIrrigationInHydricBalance -= lAmountOfIrrigationNotUsed;
                    }
                        //We can take all off from Effective Extra Irrigation
                    else if (lEffectiveIrrigationExtra >= lAmountOfIrrigationNotUsed)
                    {
                        this.TotalExtraIrrigationInHydricBalance -= lAmountOfIrrigationNotUsed;
                    }
                        //We have to take off from Effective Irrigation and from Effective Extra irrigation
                    else
                    {
                        this.TotalIrrigationInHydricBalance -= lEffectiveIrrigation;
                        lAmountOfIrrigationNotUsed -= lEffectiveIrrigation;
                        this.TotalExtraIrrigationInHydricBalance -= lAmountOfIrrigationNotUsed;
                    }
                }
            }

            lReturn = lEffectiveIrrigationTotal - lAmountOfIrrigationNotUsed;
            return lReturn;
        }
        
        /// <summary>
        /// Make the Rain adjustment
        /// Return the Effective Rain added to Hydric Balance
        /// </summary>
        /// <param name="pDailyRecord"></param>
        /// <param name="pFieldCapacity"></param>
        /// <returns></returns>
        private Double rainAdjustment(DailyRecord pDailyRecord, Double pFieldCapacity)
        {
            Double lReturn;
            Double lRealRain = 0;
            Double lEffectiveRain = 0;
            Double lAmountOfRainNotUsed = 0;
            int lDaysBetweenRains = 0;
            Double lEffectiveIrrigationTotal = 0;
            Double lIrrigationEfficiency = 0;
            
            if(pDailyRecord.Irrigation != null)
            {
                lIrrigationEfficiency = this.IrrigationUnit.IrrigationEfficiency;
                lEffectiveIrrigationTotal = pDailyRecord.Irrigation.GetTotalInput() * lIrrigationEfficiency;

                if(lEffectiveIrrigationTotal > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    lEffectiveIrrigationTotal = 0;
                }
            }

            if (pDailyRecord.Rain != null)
            {
                lDaysBetweenRains = Utilities.Utils.GetDaysDifference(this.LastPartialWaterInputDate, pDailyRecord.DailyRecordDateTime);

                lRealRain = pDailyRecord.Rain.GetTotalInput();
                //Calculate Rain Effective Value
                lEffectiveRain = this.getEffectiveRainValue(pDailyRecord.Rain);
                this.TotalEffectiveRain += lEffectiveRain;
                this.TotalRealRain += lRealRain;
                this.HydricBalance += lEffectiveRain;

                // If the effective lRainItem is bigger than 10 mm then set the last water output
                if (lEffectiveRain > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    this.TotalEvapotranspirationCropFromLastWaterInput = 0;
                    this.LastWaterInputDate = pDailyRecord.DailyRecordDateTime;
                }
                // If two "partial" water inputs, between 3 days, are bigger than 10 mm then set the last water output
                else if (lDaysBetweenRains <= InitialTables.DAYS_BETWEEN_TWO_PARTIAL_BIG_WATER_INPUT)
                {
                    if (lEffectiveRain + this.LastPartialWaterInput > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                    {
                        this.TotalEvapotranspirationCropFromLastWaterInput = 0;
                        this.LastWaterInputDate = pDailyRecord.DailyRecordDateTime;
                        //This rain is the last Partial Water
                        this.LastPartialWaterInput = lEffectiveRain;
                        this.LastPartialWaterInputDate = pDailyRecord.DailyRecordDateTime;
                    }
                }
                else //Registry the effective Rain and its date as a PartialWaterInput
                {
                    this.LastPartialWaterInput = lEffectiveRain;
                    this.LastPartialWaterInputDate = pDailyRecord.DailyRecordDateTime;
                }
                
                // If the HidricBalance is bigger than the FieldCapacity set the HidricBalance as de FieldCapacity and take off the lRainItem not used -> total lRainItem
                if (this.HydricBalance >= pFieldCapacity)
                {
                    //We have to save the date to keep the hydric balance unchangable
                    this.LastBigWaterInputDate = pDailyRecord.DailyRecordDateTime;

                    //Take off the Rain not used in Total Effective Rain 
                    //because (HydricBalanc + Rain) is bigger than FieldCapacity
                    lAmountOfRainNotUsed = this.HydricBalance - pFieldCapacity;
                    this.HydricBalance = pFieldCapacity;
                    this.TotalEffectiveRain -= lAmountOfRainNotUsed;
                }
            }

            lReturn = lEffectiveRain - lAmountOfRainNotUsed;
            return lReturn;
        }

        /// <summary>
        /// Change the PhenologicalStage of the crop depending on:
        ///     the growing degree acumulated plus the adjustment, or
        ///     the days after sowing plus the adjustment
        /// </summary>
        private void setNewPhenologicalStageAccordingCalculusMethod()
        {
            PhenologicalStage lOldPhenologicalStage = null;
            Double lOldRootDepth = 0;
            PhenologicalStage lNewPhenologicalStage = null;
            Double lNewRootDepth = 0;
            
            Double lGrowingDegreeDaysModified = 0;
            int lDaysAfterSowingModified = 0;
            Double lRootDepthDifference = 0;
            Double lPercentageOfAvailableWater = 0;

            lOldPhenologicalStage = this.PhenologicalStage;
            lOldRootDepth = this.GetHydricBalanceDepthTakingIntoAccountSoilDepthLimit(this.PhenologicalStage);

            //get the modified degrees days
            lGrowingDegreeDaysModified = this.GrowingDegreeDaysModified;
            //Get the Days after sowing
            lDaysAfterSowingModified = this.DaysAfterSowingModified;

            //Get the percentage of available Water before update the phenology state 
            lPercentageOfAvailableWater = this.GetPercentageOfAvailableWaterTakingIntoAccointPermanentWiltingPoint();
            
            if (this.CalculusMethodForPhenologicalAdjustment == Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays)
            {
                //Get Phenological Stage depending on the GrowingDegreeDaysModified
                lNewPhenologicalStage = this.GetNewPhenologicalStage(lGrowingDegreeDaysModified);
            }
            if(this.CalculusMethodForPhenologicalAdjustment == Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing)
            {
                //Get Phenological Stage depending on the Days After Sowing
                lNewPhenologicalStage = this.GetNewPhenologicalStage(lDaysAfterSowingModified);
            }

            lNewRootDepth = this.GetHydricBalanceDepthTakingIntoAccountSoilDepthLimit(lNewPhenologicalStage);
            this.PhenologicalStage = lNewPhenologicalStage;

            //If icrease the Root Depth, we add the new water to the hydric balance,
            //the part of the soil is considered at field capacity
            if (lOldPhenologicalStage != null && lNewPhenologicalStage != null && lOldRootDepth < lNewRootDepth)
            {
                //TODO get field capacity by horizon of soil (parameters: horizon depth, root depth difference)
                lRootDepthDifference = lNewRootDepth - lOldRootDepth;
                this.HydricBalance += this.GetSoilFieldCapacity(lRootDepthDifference);
            }

            //If decrease the Root Depth, we add the new water to the hydric balance,
            //the part of the soil is considered at field capacity
            if (lOldPhenologicalStage != null && lNewPhenologicalStage != null && lOldRootDepth > lNewRootDepth)
            {
                this.HydricBalance = (this.GetSoilAvailableWaterCapacity() * lPercentageOfAvailableWater / 100)
                                    + this.GetSoilPermanentWiltingPoint();
            }
        }

        /// <summary>
        /// Set the new values (after add a new dailyRecord) for the variables used to resume the state of the crop.
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
        /// <param name="pDailyRecord"></param>
        private DailyRecord setNewValuesAndReviewSummaryData(DailyRecord pDailyRecord)
        {
            DailyRecord lReturn;
            Double lFieldCapacity;
            int lDayAfterSowing;
            int lDayAfterSowingModified;
            int lDayAfterSowingModifiedDifference;

            Double lDaysAfterBigInputWater;

            lReturn = pDailyRecord;

            lDayAfterSowing = Utils.GetDaysDifference(this.SowingDate, pDailyRecord.DailyRecordDateTime);
            lDayAfterSowingModifiedDifference = this.DaysAfterSowing - this.DaysAfterSowingModified;
            lDayAfterSowingModified = lDayAfterSowing - lDayAfterSowingModifiedDifference;

            this.CropDate = pDailyRecord.DailyRecordDateTime;
            this.DaysAfterSowing = lDayAfterSowing;
            this.DaysAfterSowingModified = lDayAfterSowingModified;

            this.GrowingDegreeDaysAccumulated += pDailyRecord.GrowingDegreeDays;
            this.GrowingDegreeDaysModified += pDailyRecord.GrowingDegreeDaysModified;

            //Update the Phenological Stage depending in Calculus Method
            setNewPhenologicalStageAccordingCalculusMethod();

            lFieldCapacity = this.GetSoilFieldCapacity();

            #region Erase - only for debug - do nothing
            //TODO: Erase To debug
            if (pDailyRecord.DailyRecordDateTime.Equals(new DateTime(2014, 12, 03)))
            {
                //System.Diagnostics.Debugger.Break();
            }
            #endregion

            // Evapotraspiration adjustment
            if (pDailyRecord.EvapotranspirationCrop != null)
            {
                this.TotalEvapotranspirationCrop += pDailyRecord.EvapotranspirationCrop.GetTotalOutput();
                this.HydricBalance -= pDailyRecord.EvapotranspirationCrop.GetTotalOutput();
            }

            // Irrigation adjustment
            irrigationAdjustment(pDailyRecord, lFieldCapacity);

            // Rain adjustment
            rainAdjustment(pDailyRecord, lFieldCapacity);
            

            //Total EvapotranspirationCrop From Last Water Input adjustment 
            //after Irrigation and Rain Adjustment
            this.TotalEvapotranspirationCropFromLastWaterInput += pDailyRecord.EvapotranspirationCrop.GetTotalOutput();

            //After a big RAIN input, the Hydric Balance keep its value = FieldCapacity for X days
            //LastBigWaterInputDate it will be inicialized after rain Adjunstment
            lDaysAfterBigInputWater = Utilities.Utils.GetDaysDifference(this.LastBigWaterInputDate, pDailyRecord.DailyRecordDateTime);
            if (lDaysAfterBigInputWater <= InitialTables.DAYS_HIDRIC_BALANCE_UNCHANGABLE_AFTER_BIG_WATER_INPUT)
            {
                this.HydricBalance = lFieldCapacity;
            }

            //The first days after sowing, hydric balance is maintained at field capacity
            if (lDayAfterSowing <= InitialTables.DAYS_HIDRIC_BALANCE_UNCHANGABLE_AFTER_SOWING)
            {
                this.HydricBalance = lFieldCapacity;
            }

            //Set DailyRecord Total Information
            lReturn.PhenologicalStage = this.PhenologicalStage;
            lReturn.HydricBalance = this.HydricBalance;

            lReturn.DaysAfterSowing = this.DaysAfterSowing;
            lReturn.DaysAfterSowingModified = this.DaysAfterSowingModified;
            lReturn.GrowingDegreeDaysAccumulated = this.GrowingDegreeDaysAccumulated;
            lReturn.GrowingDegreeDaysModified = this.GrowingDegreeDaysModified;

            lReturn.LastWaterInputDate = this.LastWaterInputDate;
            lReturn.LastBigWaterInputDate = this.LastBigWaterInputDate;
            lReturn.LastPartialWaterInputDate = this.LastPartialWaterInputDate;
            lReturn.LastPartialWaterInput = this.LastPartialWaterInput;
            lReturn.SoilHydricVolume = this.SoilHydricVolume;

            lReturn.TotalEvapotranspirationCropFromLastWaterInput = this.TotalEvapotranspirationCropFromLastWaterInput;
            lReturn.TotalEvapotranspirationCrop = this.TotalEvapotranspirationCrop;

            lReturn.TotalEffectiveRain = this.TotalEffectiveRain;
            lReturn.TotalRealRain = this.TotalRealRain;

            lReturn.TotalIrrigation = this.TotalIrrigation;
            lReturn.TotalIrrigationInHydricBalance = this.TotalIrrigationInHydricBalance;
            lReturn.TotalExtraIrrigation = this.TotalExtraIrrigation;
            lReturn.TotalExtraIrrigationInHidricBalance = this.TotalExtraIrrigationInHydricBalance;

            return lReturn;
        }

        /// <summary>
        /// Update CropIrrigationWeather Data by Daily Record of one day before Record to Delete
        /// </summary>
        /// <param name="pRecordToDelete"></param>
        private void UpdateCropIrrigationWeatherByOneDayBeforeDailyRecordData(DailyRecord pRecordToDelete)
        {
            
            int lDayAfterSowing;
            DateTime lDateOfDayAfterSowing;
            
            DailyRecord lDailyRecordBeforeRecordToDelete;

            //We are in the day before Record to Delete
            lDateOfDayAfterSowing = pRecordToDelete.DailyRecordDateTime.AddDays(-1);
            lDayAfterSowing = Utils.GetDaysDifference(this.SowingDate, lDateOfDayAfterSowing);

            lDailyRecordBeforeRecordToDelete = this.GetDailyRecordByDate(lDateOfDayAfterSowing);

            this.CropDate = lDateOfDayAfterSowing;

            this.PhenologicalStage = lDailyRecordBeforeRecordToDelete.PhenologicalStage;
            this.HydricBalance = lDailyRecordBeforeRecordToDelete.HydricBalance;

            this.DaysAfterSowing = lDayAfterSowing;
            this.DaysAfterSowingModified = lDailyRecordBeforeRecordToDelete.DaysAfterSowingModified;
            this.GrowingDegreeDaysAccumulated = lDailyRecordBeforeRecordToDelete.GrowingDegreeDaysAccumulated;
            this.GrowingDegreeDaysModified = lDailyRecordBeforeRecordToDelete.GrowingDegreeDaysModified;

            this.LastWaterInputDate = lDailyRecordBeforeRecordToDelete.LastWaterInputDate;
            this.LastBigWaterInputDate = lDailyRecordBeforeRecordToDelete.LastBigWaterInputDate;
            this.LastPartialWaterInputDate = lDailyRecordBeforeRecordToDelete.LastPartialWaterInputDate;
            this.LastPartialWaterInput = lDailyRecordBeforeRecordToDelete.LastPartialWaterInput;
            this.SoilHydricVolume = lDailyRecordBeforeRecordToDelete.SoilHydricVolume;

            this.TotalEvapotranspirationCropFromLastWaterInput = lDailyRecordBeforeRecordToDelete.TotalEvapotranspirationCropFromLastWaterInput;
            this.TotalEvapotranspirationCrop = lDailyRecordBeforeRecordToDelete.TotalEvapotranspirationCrop;

            this.TotalEffectiveRain = lDailyRecordBeforeRecordToDelete.TotalEffectiveRain;
            this.TotalRealRain = lDailyRecordBeforeRecordToDelete.TotalRealRain;

            this.TotalIrrigation = lDailyRecordBeforeRecordToDelete.TotalIrrigation;
            this.TotalIrrigationInHydricBalance = lDailyRecordBeforeRecordToDelete.TotalIrrigationInHydricBalance;

            this.TotalExtraIrrigation = lDailyRecordBeforeRecordToDelete.TotalExtraIrrigation;
            this.TotalExtraIrrigationInHydricBalance = lDailyRecordBeforeRecordToDelete.TotalExtraIrrigationInHidricBalance;

        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Set the CalculusMethodForPhenologicalAdjustment
        /// Also instanciate CropInformationByDate if the Method is by Days After Sowing, else go null.
        /// </summary>
        /// <param name="pCalculusOfPhenologicalStage"></param>
        /// <returns></returns>
        public CropInformationByDate SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage pCalculusOfPhenologicalStage)
        {
            CropInformationByDate lReturn;

            this.calculusMethodForPhenologicalAdjustment = pCalculusOfPhenologicalStage;

            if(pCalculusOfPhenologicalStage == Utilities.Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing)
            {
                this.cropInformationByDate = new CropInformationByDate(this.Crop.Specie, this.SowingDate,
                                                                    this.Crop.CropCoefficient, this.Crop.PhenologicalStageList);
            }

            if(pCalculusOfPhenologicalStage == Utilities.Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays)
            {
                this.cropInformationByDate = null;
            }

            lReturn = this.CropInformationByDate;
            return lReturn;
        }

        /// <summary>
        /// Return the Days After Sowing for Modified Growing Degree
        /// </summary>
        /// <returns></returns>
        public int GetDaysAfterSowingForGrowingDegreeDaysModified()
        {
            int lReturn = 0;
            int lDaysAfterSowing = 0;
            Double lLastGrowingDegreeDaysRegistry = 0;
            DateTime lDate = DateTime.MinValue;
            IEnumerable<DailyRecord> lDailyRecordOrderByDate;
            
            lDailyRecordOrderByDate = this.DailyRecordList.OrderBy(lDailyRecord => lDailyRecord.DailyRecordDateTime);

            foreach (DailyRecord lDailyRecordItem in lDailyRecordOrderByDate)
            {
                if (this.GrowingDegreeDaysModified <= lDailyRecordItem.GrowingDegreeDaysAccumulated 
                    && this.GrowingDegreeDaysModified > lLastGrowingDegreeDaysRegistry)
                {
                    lDate = lDailyRecordItem.DailyRecordDateTime;
                    lDaysAfterSowing = Utilities.Utils.GetDaysDifference(this.SowingDate, lDate);
                    break;
                }
                lLastGrowingDegreeDaysRegistry = lDailyRecordItem.GrowingDegreeDaysAccumulated;
            }

            lReturn = lDaysAfterSowing;
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
        

        
        public void AdjustmentPhenology(Stage pStage, DateTime pDateTime, double lModification)
        {
            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (Utils.IsTheSameDay(pDateTime, lDailyRec.DailyRecordDateTime))
                {
                    lDailyRec.GrowingDegreeDaysModified += lModification;// +lDailyRecordToDelete.GrowingDegreeDaysModified;
                    this.GrowingDegreeDaysModified += lModification;
                }
            }
        }

        /// <summary>
        /// Gives the effective lRainItem registered in a specific date including the output and extraOutput value.
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
        /// Get DailyRecord from the list order by date with Date of the record
        /// equals than the parameter date..
        /// If is it not find, return null.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public DailyRecord GetDailyRecordByDate(DateTime pDate)
        {
            DailyRecord lRetrun = null;
            IEnumerable<DailyRecord> lDailyRecordOrderByDate = null;

            if (pDate != null)
            {
                lDailyRecordOrderByDate = this.DailyRecordList.OrderBy(lDailyRecord => lDailyRecord.DailyRecordDateTime);

                foreach (DailyRecord lDailyRecord in lDailyRecordOrderByDate)
                {
                    //Compare Dates, is not important the Time
                    if (Utils.IsTheSameDay(pDate, lDailyRecord.DailyRecordDateTime))
                    {
                        lRetrun = lDailyRecord;
                    }
                }
            }

            return lRetrun;
        }

        /// <summary>
        /// Gives the evapoTranspiration registered in a specific date including the output and extraOutput value.
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
                    lRetrun = lDailyRec.EvapotranspirationCrop.Output + lDailyRec.EvapotranspirationCrop.ExtraOutput;
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
        public DailyRecord UpdateDailyRecordListUpToDate(DateTime pDailyRecordDateTime)
        {
            DailyRecord lReturn = null;
            DailyRecord lDailyRecordToDelete = null;
            IEnumerable<DailyRecord> lDailyRecordOrderByDate = null;
            int i = 0;
            int lIndexToRemove = -1;
            int lTotalDailyRecords = 0;

            if(pDailyRecordDateTime != null)
            {
                lDailyRecordOrderByDate = this.DailyRecordList.OrderBy(lDailyRecord => lDailyRecord.DailyRecordDateTime);

                foreach (DailyRecord lDailyRecordItem in lDailyRecordOrderByDate)
                {
                    if (Utils.IsTheSameDay(lDailyRecordItem.DailyRecordDateTime, pDailyRecordDateTime))
                    {
                        lDailyRecordToDelete = lDailyRecordItem;
                        lIndexToRemove = i;
                    }
                    i++;
                }
            }
            //We have a unique record by day
            if (lIndexToRemove != -1)
            {
                lTotalDailyRecords = this.DailyRecordList.Count();
                UpdateCropIrrigationWeatherByOneDayBeforeDailyRecordData(lDailyRecordToDelete);
                this.DailyRecordList.RemoveRange(lIndexToRemove, lTotalDailyRecords - lIndexToRemove);
            }

            lReturn = lDailyRecordToDelete;
            return lReturn;

        }

        /// <summary>
        /// Gives the Evapotranspiration registered in a Date 
        /// and the two days before, including the output and extraOutput value.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public Double GetLastThreeDaysOfEvapotranspirationCrop(DateTime pDate)
        {
            Double lRetrun = 0;
            DateTime oneDayBefore = pDate.AddDays(-1);
            DateTime twoDaysBefore = pDate.AddDays(-2);
            DateTime oneDayAfter = pDate.AddDays(1);
            Double lEvapotranspirationCrop = 0;

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (Utils.IsTheSameDay(lDailyRec.DailyRecordDateTime.Date, pDate.Date) 
                    || Utils.IsTheSameDay(lDailyRec.DailyRecordDateTime.Date, oneDayBefore.Date) 
                    || Utils.IsTheSameDay(lDailyRec.DailyRecordDateTime.Date, twoDaysBefore.Date))
                {
                    lEvapotranspirationCrop += lDailyRec.EvapotranspirationCrop.Output + lDailyRec.EvapotranspirationCrop.ExtraOutput;
                }
                else if(Utils.IsTheSameDay(lDailyRec.DailyRecordDateTime.Date, oneDayAfter.Date))
                {
                    break;
                }
            }

            lRetrun = lEvapotranspirationCrop;
            return lRetrun;
        }

        /// <summary>
        /// Gives the growing degree registered in a specific date.
        /// </summary>
        /// <param name="pDate">Date of the required information</param>
        /// <returns></returns>
        public Double GetDailyRecordGrowingDegree(DateTime pDate)
        {
            Double lRetrun;
            Double lGrowingDegreeDays = 0;

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lGrowingDegreeDays = lDailyRec.GrowingDegreeDays;
                    break;
                }
            }

            lRetrun = lGrowingDegreeDays;
            return lRetrun;
        }

        /// <summary>
        /// Gives the observation registered in a specific date.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public String GetDailyRecordObservations(DateTime pDate)
        {
            String lRetrun;
            String lObservations = "";

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lObservations = lDailyRec.Observations;
                    break;
                }
            }

            lRetrun = lObservations;
            return lRetrun;
        }

        /// <summary>
        /// Gives the Evapotranspiration registered in a Date 
        /// and the two days before, including the output and extraOutput value.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public WaterOutput GetDailyRecordEvapotranspiration(DateTime pDate)
        {
            WaterOutput lReturn;
            WaterOutput lEvapotranspiration = null;

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lEvapotranspiration = lDailyRec.EvapotranspirationCrop;
                    break;
                }
            }

            lReturn = lEvapotranspiration;
            return lReturn;
        }

        #region CropData

        /// <summary>
        /// Get Region from Crop
        /// </summary>
        /// <returns></returns>
        public Region GetCropRegion()
        {
            Region lReturn;
            Region lRegion = null;

            lRegion = this.Crop.Region;

            lReturn = lRegion;
            return lReturn;
        }

        /// <summary>
        /// Get Days After Sowing According to a DateTime
        /// </summary>
        /// <returns></returns>
        public int GetDaysAfterSowing(DateTime pDate)
        {
            int lReturn = 0;
            int lDaysAfterSowing = 0;
            DateTime lSowingDate;

            lSowingDate = this.SowingDate;
            lDaysAfterSowing = pDate.Subtract(lSowingDate).Days;

            lReturn = lDaysAfterSowing;
            return lReturn;
        }

        /// <summary>
        /// Get Base Temperature from Crop
        /// </summary>
        /// <returns></returns>
        public Double GetBaseTemperature() 
        {
            Double lReturn;
            Double lBaseTemperature = 0;

            lBaseTemperature = this.Crop.GetBaseTemperature();

            lReturn = lBaseTemperature;
            return lReturn;
        }

        /// <summary>
        /// Get Max Evapotranspiration to Irrigate from Crop
        /// </summary>
        /// <returns></returns>
        public Double GetMaxEvapotranspirationToIrrigate()
        {
            Double lReturn;
            Double lMaxEvapotranspirationToIrrigate = 0;

            lMaxEvapotranspirationToIrrigate = this.Crop.MaxEvapotranspirationToIrrigate;

            lReturn = lMaxEvapotranspirationToIrrigate;
            return lReturn;
        }

        /// <summary>
        /// Get Soil Depth from Crop Phenological Stage (Hydric Balance Depth)
        /// If exceed the DepthLimit of Soil, it will return the DepthLimit
        /// </summary>
        /// <returns></returns>
        public double GetHydricBalanceDepthTakingIntoAccountSoilDepthLimit(PhenologicalStage pPhenologicalStage)
        {
            Double lReturn;
            Double lDepth = 0;

            lDepth = pPhenologicalStage.HydricBalanceDepth;
            if (lDepth > this.Soil.DepthLimit)
            {
                lDepth = this.Soil.DepthLimit;
            }

            lReturn = lDepth;
            return lReturn;
        }

        /// <summary>
        /// Get Root Depth from Crop Phenological Stage if not exceed the DepthLimit of the Soil
        /// </summary>
        /// <returns></returns>
        public Double GetRootDepthTakingIntoAccountSoilDepthLimit(PhenologicalStage pPhenologicalStage)
        {
            Double lReturn;
            double lRootDepth = 0;

            lRootDepth = pPhenologicalStage.RootDepth;
            if (lRootDepth > this.Soil.DepthLimit)
            {
                lRootDepth = this.Soil.DepthLimit;
            }

            lReturn = lRootDepth;
            return lReturn;
        }

        #endregion

        #region SoilData

        /// <summary>
        /// Get the Field Capacity by Root Depth from this Soil
        /// </summary>
        /// <param name="pDepth"></param>
        /// <returns></returns>
        public Double GetSoilFieldCapacity(double pDepth)
        {
            Double lReturn;
            Double lSoilFieldCapacity = 0;

            lSoilFieldCapacity = this.Soil.GetFieldCapacity(pDepth);

            lReturn = lSoilFieldCapacity;
            return lReturn;
        }

        /// <summary>
        /// Get Soil Permanent Wilting Poing
        /// The data is obtained from Soil depending Root Depth
        /// </summary>
        /// <returns></returns>
        public Double GetSoilPermanentWiltingPoint()
        {
            Double lReturn;
            Double lDepth = 0;
            Double lSoilPermanentWiltingPoint = 0;

            lDepth = this.GetHydricBalanceDepthTakingIntoAccountSoilDepthLimit(this.PhenologicalStage);
            lSoilPermanentWiltingPoint = this.Soil.GetPermanentWiltingPoint(lDepth);

            lReturn = lSoilPermanentWiltingPoint;
            return lReturn;
        }

        /// <summary>
        /// Get Soil Available Water Capacity 
        /// From Crop Soil by Root Depth 
        /// </summary>
        /// <returns></returns>
        public Double GetSoilAvailableWaterCapacity()
        {
            Double lReturn;
            Double lDepth = 0;
            Double lSoilAvailableWaterCapacity = 0;

            lDepth = this.GetHydricBalanceDepthTakingIntoAccountSoilDepthLimit(this.PhenologicalStage);
            lSoilAvailableWaterCapacity = this.Soil.GetAvailableWaterCapacity(lDepth);

            lReturn = lSoilAvailableWaterCapacity;
            return lSoilAvailableWaterCapacity;
        }
                
        /// <summary>
        /// Get Soil Field Capacity
        /// From Crop Soil by Root Depth
        /// </summary>
        /// <returns></returns>
        public Double GetSoilFieldCapacity()
        {
            Double lReturn;
            Double lDepth = 0;
            Double lSoilFieldCapacity = 0;
            
            lDepth = this.GetHydricBalanceDepthTakingIntoAccountSoilDepthLimit(this.PhenologicalStage);
            lSoilFieldCapacity = this.Soil.GetFieldCapacity(lDepth);

            lReturn = lSoilFieldCapacity;
            return lReturn;
        }

        #endregion

        #region CropWaterData

        /// <summary>
        /// Get Percentage of Hydric Balance vs Field Capacity
        /// 100 %  = Field Capacity
        /// </summary>
        /// <returns></returns>
        public Double GetPercentageOfHydricBalance()
        {
            Double lReturn;
            Double lHydricBalance = 0;
            Double lFieldCapacity = 0;
            //Double lPermanentWiltingPoint = 0;
            Double lPercentageOfWater = 0;

            lHydricBalance = this.HydricBalance;
            lFieldCapacity = this.GetSoilFieldCapacity();
            //lPermanentWiltingPoint = this.GetSoilPermanentWiltingPoint();

            lPercentageOfWater = Math.Round(((lHydricBalance) * 100)
                                           / (lFieldCapacity), 2);

            lReturn = lPercentageOfWater;
            return lReturn;
        }

        /// <summary>
        /// Get Percentage of Available Water from Hydric Balance vs Field Capacity taking off Permanent Wilting Point
        /// </summary>
        /// <returns></returns>
        public Double GetPercentageOfAvailableWaterTakingIntoAccointPermanentWiltingPoint()
        {
            Double lReturn;
            Double lHydricBalance = 0;
            Double lFieldCapacity = 0;
            Double lPermanentWiltingPoint = 0;
            Double lPercentageOfAvailableWater = 0;

            lHydricBalance = this.HydricBalance;
            lFieldCapacity = this.GetSoilFieldCapacity();
            lPermanentWiltingPoint = this.GetSoilPermanentWiltingPoint();

            lPercentageOfAvailableWater = Math.Round(((lHydricBalance - lPermanentWiltingPoint) * 100)
                                                    / (lFieldCapacity - lPermanentWiltingPoint), 2);

            lReturn = lPercentageOfAvailableWater;
            return lReturn;
        }

        /// <summary>
        /// Get Initial Hidric Balance 
        /// (Fiel Capacity for Initial Root Depth)
        /// </summary>
        /// <returns></returns>
        public Double GetInitialHydricBalance()
        {
            Double lReturn = 0;
            Double lFieldCapacity = 0;
            
            lFieldCapacity = this.GetSoilFieldCapacity(InitialTables.INITIAL_ROOT_DEPTH);

            lReturn = lFieldCapacity;
            return lReturn;
        }

        #endregion

        #region CropIrrigationWeatherData

        /// <summary>
        /// Get Irrigation from Irrigation List By Date
        /// </summary>
        /// <param name="pDayOfIrrigation"></param>
        /// <returns></returns>
        public Water.Irrigation GetIrrigation(DateTime pDayOfIrrigation)
        {
            Water.Irrigation lReturn = null;
            Water.Irrigation lIrrigation = null;

            foreach (Water.Irrigation lIrrigationItem in this.IrrigationList)
            {
                if (Utils.IsTheSameDay(lIrrigationItem.Date, pDayOfIrrigation))
                {
                    lIrrigation = lIrrigationItem;
                    break;
                }
            }

            lReturn = lIrrigation;
            return lReturn;
        }

        /// <summary>
        /// Get Rain from Rain List By Date
        /// </summary>
        /// <param name="pDayOfRain"></param>
        /// <returns></returns>
        public Water.Rain GetRain(DateTime pDayOfRain)
        {
            Water.Rain lReturn = null;
            Water.Rain lRain = null;

            foreach (Water.Rain lRainItem in this.RainList)
            {
                if (Utils.IsTheSameDay(lRainItem.Date, pDayOfRain))
                {
                    lRain = lRainItem;
                    break;
                }
            }

            lReturn = lRain;
            return lReturn;
        }

        /// <summary>
        /// Get the Hidric Balance from CropIrrigationWeather
        /// </summary>
        /// <returns></returns>
        public Double GetHydricBalance()
        {
            Double lReturn = 0;
            Double lHydricBalance = 0;

            lHydricBalance = this.HydricBalance;

            lReturn = lHydricBalance;
            return lReturn;
        }

        /// <summary>
        /// Get Total Evapotranspiration Crop from last important water output
        /// </summary>
        /// <returns></returns>
        public Double GetTotalEvapotranspirationCropFromLastWaterInput()
        {
            Double lReturn = 0;
            Double lTotalEvapotranspirationCropFromLastWaterInput = 0;

            lTotalEvapotranspirationCropFromLastWaterInput = this.TotalEvapotranspirationCropFromLastWaterInput;

            lReturn = lTotalEvapotranspirationCropFromLastWaterInput;
            return lReturn;
        }

        #endregion

        #region Weather

        /// <summary>
        /// Return the WeatherData from the available weather station.
        /// First search in the main station. If there is no data, then search in the alternative wheather station.
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pDateTime"></param>
        /// <returns></returns>
        public WeatherData GetWeatherDataFromAvailableWeatherStation(DateTime pDateTime)
        {
            WeatherData lReturn = null;
            WeatherData lWeatherData = null;

            if (pDateTime != null)
            {
                lWeatherData = this.MainWeatherStation.FindWeatherData(pDateTime);
                if (lWeatherData == null)
                {
                    lWeatherData = this.AlternativeWeatherStation.FindWeatherData(pDateTime);
                } 
            }

            lReturn = lWeatherData;
            return lReturn;
        }

        #endregion

        /// <summary>
        /// Retrun Phenological Stage where Growing Degree Days is between Min and Max Degree
        /// </summary>
        /// <param name="pGrowingDegreeDaysModified"></param>
        /// <returns></returns>
        public PhenologicalStage GetNewPhenologicalStage(Double pGrowingDegreeDaysModified)
        {
            PhenologicalStage lReturn;
            List<PhenologicalStage> lPhenologicalStageList;
            IEnumerable<PhenologicalStage> lPhenologicalTableOrderByMinDegree;
            PhenologicalStage lNewPhenologicalStage = null;
            
            //Order the phenological table
            lPhenologicalStageList = this.Crop.PhenologicalStageList;
            lPhenologicalTableOrderByMinDegree = lPhenologicalStageList.OrderBy(lPhenologicalStage => lPhenologicalStage.MinDegree);

            foreach (PhenologicalStage lPhenologicalStage in lPhenologicalTableOrderByMinDegree)
            {
                if (lPhenologicalStage != null 
                    && lPhenologicalStage.MinDegree <= pGrowingDegreeDaysModified
                    && lPhenologicalStage.MaxDegree >= pGrowingDegreeDaysModified)
                {
                    this.PhenologicalStage = lPhenologicalStage;
                    lNewPhenologicalStage = lPhenologicalStage;
                    break;
                }
            }
            
            lReturn = lNewPhenologicalStage;
            return lReturn;
        }

        /// <summary>
        /// Return Phenological Stage where Days After Sowing is in the period of the Stage
        /// </summary>
        /// <param name="pDaysAfterSowingModified"></param>
        /// <returns></returns>
        public PhenologicalStage GetNewPhenologicalStage(int pDaysAfterSowingModified)
        {
            PhenologicalStage lReturn;
            List<PhenologicalStage> lPhenologicalStageList;
            IEnumerable<PhenologicalStage> lPhenologicalTableOrderByStageName;
            PhenologicalStage lNewPhenologicalStage = null;
            Stage lStage = null;
            String lStageName = "";
            
            //Order the phenological table by 
            lPhenologicalStageList = this.Crop.PhenologicalStageList;
            lPhenologicalTableOrderByStageName = lPhenologicalStageList.OrderBy(lPhenologicalStage => lPhenologicalStage.Stage.Name);

            //Return the strage depending in Days after Sowing
            if(this.CropInformationByDate != null)
            {
                //lStage = this.CropIrrigationByDate.GetStage(pDaysAfterSowingModified);
            }

            if(lStage != null)
            {
                foreach (PhenologicalStage lPhenologicalStage in lPhenologicalTableOrderByStageName)
                {
                    if(lPhenologicalStage != null)
                    {
                        lStageName = lPhenologicalStage.Stage.Name.ToUpper();
                        if (lStageName.Equals(lStage.Name.ToUpper()))
                        {
                            lNewPhenologicalStage = lPhenologicalStage;
                            break;
                        }
                    }
                }
            }

            lReturn = lNewPhenologicalStage;
            return lReturn;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDateTime"></param>
        /// <param name="pObservations"></param>
        public void AddDailyRecordAccordingDaysAfterSowing(DateTime pDateTime, String pObservations)
        {
            try
            {
                WeatherData lWeatherData;
                DateTime lDailyRecordDateTime;
                Double lEvapotranspiration = 0;
                Double lGrowingDegreeDays = 0;
                Double lGrowingDegreeDaysModified = 0;
                DailyRecord lDailyRecord;
                int lDaysAfterSowing = 0;
                int lDaysAfterSowingModified = 0;
                Double lCropCoefficient = 0;
                Double lEvapotranspirationCropInput = 0;
                WaterOutput lEvapotranspirationCrop = null;
                DailyRecord lNewDailyRecord = null;
                WeatherData lMainWeatherData = null;
                WeatherData lAlternativeWeatherData = null;

                lWeatherData = this.GetWeatherDataFromAvailableWeatherStation(pDateTime);
                
                lDailyRecordDateTime = pDateTime;

                //1.- Evapotranspiration
                if(lWeatherData != null)
                {
                    lEvapotranspiration = lWeatherData.GetEvapotranspiration();
                }

                //2.- Days After Sowing 
                lDaysAfterSowing = this.calculateDaysAfterSowingForOneDay(this.SowingDate, lDailyRecordDateTime);

                //3.- Growing Degree Days
                //Growing Degree Days is average temperature menous Base Temperature 
                if (lWeatherData != null)
                {
                    lGrowingDegreeDays = this.calculateGrowingDegreeDaysForOneDay(this.GetBaseTemperature(), lWeatherData.GetAverageTemperature());
                }
                else
                {
                    //lGrowingDegreeDays = InitialTables.GetGrowingDegreeDays(lDailyRecordDateTime);
                    this.GrowingDegreeDaysAccumulated += lGrowingDegreeDays;
                    this.GrowingDegreeDaysModified += lGrowingDegreeDays; 
                }

                //4.- Get Daily Record by Days After Sowing Modified
                lDailyRecord = this.getDailyRecordByDaysAfterSowingAccumulated(this.DaysAfterSowingModified);

                //5.- Get the Growing Degree Days Modifiedaccording to Days After Sowing Modified 
                //If we do not modified DAS, GDD will be 0
                if (lDailyRecord == null)
                {
                    lGrowingDegreeDaysModified = lGrowingDegreeDays;
                    lDaysAfterSowingModified = lDaysAfterSowing;
                }
                else
                {
                    lGrowingDegreeDaysModified = lDailyRecord.GrowingDegreeDaysModified;
                    lDaysAfterSowingModified = this.DaysAfterSowingModified;
                }

                //6.- Get Crop Coefficient by Days After Sowing Modified
                lCropCoefficient = this.Crop.CropCoefficient.GetCropCoefficient(lDaysAfterSowingModified);


                //7.- Calculus of Evapotranspiration Crop
                if (lWeatherData != null)
                {
                    lEvapotranspirationCropInput = lEvapotranspiration * lCropCoefficient;
                    lEvapotranspirationCrop = new EvapotranspirationCrop(lWeatherData.Date, lEvapotranspirationCropInput);
                }

                //8.- Weather Data
                lMainWeatherData = this.MainWeatherStation.FindWeatherData(lDailyRecordDateTime);
                if(this.AlternativeWeatherStation != null)
                {
                    lAlternativeWeatherData = this.AlternativeWeatherStation.FindWeatherData(lDailyRecordDateTime);
                }
                
                //9.- Water Input
                Rain lRain = this.GetRain(lDailyRecordDateTime);
                Water.Irrigation lIrrigation = this.GetIrrigation(lDailyRecordDateTime);

                //We need to update some fields for calculations:
                //  pLastWaterInputDate, pLastBigWaterInputDate, 
                //  pLastPartialWaterInputDate, pLastPartialWaterInput, 
                //  this.HydricBalance, this.SoilHydricVolume,
                //  this.TotalEvapotranspirationCropFromLastWaterInput
                lNewDailyRecord = new DailyRecord(lDailyRecordDateTime, lMainWeatherData, lAlternativeWeatherData,
                                                this.DaysAfterSowing, this.DaysAfterSowingModified,
                                                lGrowingDegreeDays, this.GrowingDegreeDaysAccumulated, this.GrowingDegreeDaysModified,
                                                lRain, lIrrigation, this.LastWaterInputDate, this.LastBigWaterInputDate,
                                                this.LastPartialWaterInputDate, this.LastPartialWaterInput,
                                                lEvapotranspirationCrop, this.PhenologicalStage, 
                                                this.HydricBalance, this.SoilHydricVolume,
                                                this.TotalEvapotranspirationCropFromLastWaterInput,
                                                lCropCoefficient, pObservations);

                this.UpdateDailyRecordListUpToDate(lDailyRecordDateTime);


                //If it's the initial registry set the initial Hidric Balance
                if (lDaysAfterSowing == 0)
                {
                    this.HydricBalance = this.GetInitialHydricBalance();
                    this.DaysAfterSowing = 0;// new Pair<int, DateTime>(-1, this.CropIrrigationWeatherRecord.SowingDate);
                }

                //Set the new values (after add a new dailyRecord) for the variables used to resume the state of the crop.
                // Use the last state (day before) to calculate the new state
                setNewValuesAndReviewSummaryData(lNewDailyRecord);


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
        /// 
        /// </summary>
        /// <param name="pDateTime"></param>
        /// <param name="pObservations"></param>
        public void AddDailyRecordAccordingGrowinDegreeDays(DateTime pDateTime, String pObservations)
        {
            try
            {
                WeatherData lWeatherData;
                DateTime lDailyRecordDateTime;
                Double lEvapotranspiration = 0;
                Double lGrowingDegreeDays = 0;
                Double lGrowingDegreeDaysModified = 0;
                DailyRecord lDailyRecord;
                int lDaysAfterSowing = 0;
                int lDaysAfterSowingModified = 0;
                Double lCropCoefficient = 0;
                Double lEvapotranspirationCropInput = 0;
                WaterOutput lEvapotranspirationCrop = null;
                DailyRecord lNewDailyRecord = null;
                WeatherData lMainWeatherData = null;
                WeatherData lAlternativeWeatherData = null;

                lWeatherData = this.GetWeatherDataFromAvailableWeatherStation(pDateTime);
                
                lDailyRecordDateTime = pDateTime;

                //1.- Evapotranspiration
                lEvapotranspiration = lWeatherData.GetEvapotranspiration();

                //2.- Days After Sowing 
                lDaysAfterSowing = this.calculateDaysAfterSowingForOneDay(this.SowingDate, lDailyRecordDateTime);

                //3.- Growing Degree Days
                //Growing Degree Days is average temperature menous Base Temperature                
                lGrowingDegreeDays = this.calculateGrowingDegreeDaysForOneDay(this.GetBaseTemperature(), lWeatherData.GetAverageTemperature());

                //4.- Get Daily Record by Growing Degrees Days Modified
                lDailyRecord = this.getDailyRecordByGrowingDegreeDaysAccumulated(this.GrowingDegreeDaysModified);

                //5.- Get the Days After Sowing Modified according to Growing Degree Days Modified
                //If we do not modified GDD, DAS will be 0
                if (lDailyRecord == null)
                {
                    lDaysAfterSowingModified = lDaysAfterSowing;
                }
                else
                {
                    lDaysAfterSowingModified = lDailyRecord.DaysAfterSowing;
                }

                //6.- Get Crop Coefficient by Days After Sowing Modified
                lCropCoefficient = this.Crop.CropCoefficient.GetCropCoefficient(lDaysAfterSowingModified);


                //7.- Calculus of Evapotranspiration Crop
                lEvapotranspirationCropInput = lEvapotranspiration * lCropCoefficient;
                lEvapotranspirationCrop = new EvapotranspirationCrop(lWeatherData.Date, lEvapotranspirationCropInput);

                //8.- Weather Data
                lMainWeatherData = this.MainWeatherStation.FindWeatherData(lDailyRecordDateTime);
                if (this.AlternativeWeatherStation != null)
                {
                    lAlternativeWeatherData = this.AlternativeWeatherStation.FindWeatherData(lDailyRecordDateTime);
                }

                //9.- Water Input
                Rain lRain = this.GetRain(lDailyRecordDateTime);
                Water.Irrigation lIrrigation = this.GetIrrigation(lDailyRecordDateTime);

                //We need to update some fields for calculations:
                //  pLastWaterInputDate, pLastBigWaterInputDate, 
                //  pLastPartialWaterInputDate, pLastPartialWaterInput, 
                //  this.HydricBalance, this.SoilHydricVolume,
                //  this.TotalEvapotranspirationCropFromLastWaterInput
                lNewDailyRecord = new DailyRecord(lDailyRecordDateTime, lMainWeatherData, lAlternativeWeatherData,
                                                this.DaysAfterSowing, this.DaysAfterSowingModified,
                                                lGrowingDegreeDays, this.GrowingDegreeDaysAccumulated, this.GrowingDegreeDaysModified,
                                                lRain, lIrrigation, this.LastWaterInputDate, this.LastBigWaterInputDate,
                                                this.LastPartialWaterInputDate, this.LastPartialWaterInput,
                                                lEvapotranspirationCrop, this.PhenologicalStage,
                                                this.HydricBalance, this.SoilHydricVolume,
                                                this.TotalEvapotranspirationCropFromLastWaterInput,
                                                lCropCoefficient, pObservations);

                this.UpdateDailyRecordListUpToDate(lDailyRecordDateTime);


                //If it's the initial registry set the initial Hidric Balance
                if (lDaysAfterSowing == 0)
                {
                    this.HydricBalance = this.GetInitialHydricBalance();
                    this.DaysAfterSowing = 0;// new Pair<int, DateTime>(-1, this.CropIrrigationWeatherRecord.SowingDate);
                }

                //Set the new values (after add a new dailyRecord) for the variables used to resume the state of the crop.
                // Use the last state (day before) to calculate the new state
                setNewValuesAndReviewSummaryData(lNewDailyRecord);


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


        /*
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
                lDays = this.GetDaysAfterSowingForGrowingDegreeDaysModified();

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
                

                //TODO extract to a new method as "UpdateDailyRecordListUpToDate"
                //Verify if exist an older Daily Record, and if exists, replece it
                int indexToRemove = -1;
                DailyRecord lRecordToDelete = null;
                int i = 0;
                foreach (DailyRecord lDailyRecordItem in this.DailyRecordList)
                {
                    if (Utils.IsTheSameDay(lDailyRecordItem.DailyRecordDateTime.Date, pWeatherData.Date))
                    {
                        indexToRemove = i;
                        lRecordToDelete = lDailyRecordItem;
                    }
                    i++;
                }
                //We have a unique record by day
                if (indexToRemove != -1)
                {
                    UpdateCropIrrigationWeatherByOneDayBeforeDailyRecordData(lRecordToDelete);
                    this.DailyRecordList.RemoveAt(indexToRemove);
                }

                
                //If it's the initial registry set the initial Hidric Balance
                if (lDays == 0)
                {
                    this.HydricBalance = this.GetInitialHydricBalance();
                    this.DaysAfterSowing = 0;// new Pair<int, DateTime>(-1, this.CropIrrigationWeatherRecord.SowingDate);
                }
                setNewValuesAndReviewSummaryData(lNewDailyRecord);
              

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
            foreach (DailyRecord lDailyRecordItem in this.DailyRecordList)
            {
                if (Utils.IsTheSameDay(pDateTime, lDailyRecordItem.DailyRecordDateTime))
                {
                    lDailyRecordItem.GrowingDegreeDaysModified += lModification;// +lDailyRecordToDelete.GrowingDegreeDaysModified;
                    this.GrowingDegreeDaysModified += lModification;
                }
            }
        }
        */

        /// <summary>
        /// Gives the effective lRainItem registered in a specific date including the output and extraOutput value.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public Double GetEffectiveRain(DateTime pDate)
        {
            Double lRetrun = 0;
            Double lEffectiveRain = 0;

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lEffectiveRain = lDailyRec.Rain.Input + lDailyRec.Rain.ExtraInput;
                    break;
                }
            }

            lRetrun = lEffectiveRain;
            return lRetrun;
        }
        
        #endregion

        #region Overrides
        public override bool Equals(object obj)
        {
            bool lReturn = false;
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            CropIrrigationWeather lCropIrrigationWeather = obj as CropIrrigationWeather;
            lReturn = this.Crop.Equals(lCropIrrigationWeather.Crop) &&
                    this.IrrigationUnit.Equals(lCropIrrigationWeather.IrrigationUnit);
            return lReturn;
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
                lMessageDaily.Add(lDR.EvapotranspirationCrop.GetTotalOutput().ToString());
                if (lDR.Rain == null)
                {
                    lMessageDaily.Add("0");
                }
                else
                {
                    lMessageDaily.Add(lDR.Rain.GetTotalInput().ToString());
                }
                if (lDR.Irrigation == null)
                {
                    lMessageDaily.Add("0");
                }
                else
                {
                    lMessageDaily.Add(lDR.Irrigation.GetTotalInput().ToString());
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
            lPercentageOfAvailableWater = pCropIrrigationWeather.GetPercentageOfHydricBalance() + "        ";
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
            lTotIrrInHB = pCropIrrigationWeather.TotalIrrigationInHydricBalance.ToString() + "        ";
            lTotExtraIrrInHB = pCropIrrigationWeather.TotalExtraIrrigationInHydricBalance.ToString() + "        ";


            lReturn = this.DaysAfterSowing.ToString() +
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
                " \t\t " + pCropIrrigationWeather.GetRootDepthTakingIntoAccountSoilDepthLimit(this.PhenologicalStage) +
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
            lMessage.Add(this.DaysAfterSowing.ToString());
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
            lMessage.Add(pCropIrrigationWeather.GetRootDepthTakingIntoAccountSoilDepthLimit(this.PhenologicalStage).ToString());
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