﻿/*
using IrrigationAdvisor.Models.Agriculture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Weather;

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
    ///     - cropIrrigationWeatherRecordId: int
    ///     - dayAfterSowing: Pair<int, DateTime>
    ///     - effectiveRainList: List<EffectiveRainList>
    ///     - dailyRecordList: List<DailyRecord>
    ///     - growingDegreeDaysAccumulated: double
    ///     - growingDegreeDaysModified: double
    ///     - hydricBalance: double
    ///     - soilHydricVolume: double
    ///     - lastWaterInputDate: DateTime
    ///     - lastBigWaterInputDate: DateTime
    ///     - lastPartialWaterInputDate: DateTime
    ///     - lastPartialWaterInput: double
    ///     - totalEvapotranspirationCropFromLastWaterInput: double
    ///     - phenologicalStage: PhenologicalStage
    ///     - sowingDate: DateTime
    ///     - harvestDate: DateTime
    /// 
    /// Methods:
    ///     - IrrigationRecords()      -- constructor
    ///     - IrrigationRecords(name)  -- consturctor with parameters
    ///     - GetPhenologicalStage(DayGrades: double): Stage
    ///     - setGrowingDegreeDays(): bool
    ///     - setPhenologicalState(Stage): bool
    ///     - setNewPhenologicalStage(Stage): GrowingDegreeDaysAccumulated: double
    ///     - GetRootDepth(Specie, Stage): double
    ///     - GetPhenologicalStage(GrowingDegreeDaysAccumulated: double): Stage
    ///     - getAvailableWater(RootDepth:double, FieldCapacity:double, lPermanentWiltingPoint:double): double
    ///     - GetHydricBalance(): double
    ///     - getSoilHydricVolume(): double
    ///     - GetEffectiveRain(Date): double
    ///     - GetDailyRecordGrowingDegree(Date): double
    ///     - GetEvapotranspirationCrop(Date): double
    ///     - getObservations(Date): String
    ///     - getLastThreeDaysOfEvapotranspirationCrop(): double
    ///     
    /// </summary>
    public class CropIrrigationWeatherRecord
    {

        #region Consts

        #endregion

        #region Fields

        private int cropIrrigationWeatherRecordId;
        //Data of Crop
        private DateTime sowingDate;
        private DateTime harvestDate;
        private DateTime cropDate;
        private CropCoefficient cropCoefficient;
        //Calculus by Days After Sowing
        private int dayAfterSowing;
        private int dayAfterSowingModified;
        //Calculus by Growing Degree Days
        private double growingDegreeDaysAccumulated;
        private double growingDegreeDaysModified;
        //Crop State
        private PhenologicalStage phenologicalStage;
        private PhenologicalStage phenologicalStageByDayAfterSowing;
        private PhenologicalStage phenologicalStageByGrowingDegreeDays;
        private Double hydricBalance;
        private Double soilHydricVolume;
        private Double totalEvapotranspirationCropFromLastWaterInput;
        //Output Water Data
        private List<EffectiveRain> effectiveRainList;
        private DateTime lastWaterInputDate;
        private DateTime lastBigWaterInputDate;
        private DateTime lastPartialWaterInputDate;
        private Double lastPartialWaterInput;
        //Daily Data
        private List<DailyRecord> dailyRecordList;
        

        //Extra Print Data
        private String outPut;

        private List<String> titles;
        private List<List<String>> messages;
        private List<String> titlesDaily;
        private List<List<String>> messagesDaily;


        #endregion

        #region Properties

        public int CropIrrigationWeatherRecordId
        {
            get { return cropIrrigationWeatherRecordId; }
            set { cropIrrigationWeatherRecordId = value; }
        }

        #region DataOfCrop

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

        public CropCoefficient CropCoefficient
        {
            get { return cropCoefficient; }
            set { cropCoefficient = value; }
        }

        #endregion

        #region CalculusByDaysAfterSowing

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

        #endregion

        #region CalculusByGrowingDegreeDays

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

        #region CropState

        public PhenologicalStage PhenologicalStage
        {
            get { return phenologicalStage; }
            set { phenologicalStage = value; }
        }

        public PhenologicalStage PhenologicalStageByDayAfterSowing
        {
            get { return phenologicalStageByDayAfterSowing; }
            set { phenologicalStageByDayAfterSowing = value; }
        }

        public PhenologicalStage PhenologicalStageByGrowingDegreeDays
        {
            get { return phenologicalStageByGrowingDegreeDays; }
            set { phenologicalStageByGrowingDegreeDays = value; }
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

        #region InputWaterData

        public List<EffectiveRain> EffectiveRainList
        {
            get { return effectiveRainList; }
            set { effectiveRainList = value; }
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
        
        public double LastPartialWaterInput
        {
            get { return lastPartialWaterInput; }
            set { lastPartialWaterInput = value; }
        }

        #endregion

        #region DailyData

        public List<DailyRecord> DailyRecordList
        {
            get { return dailyRecordList; }
            //set { dailyRecordList = value; }
        }

        #endregion

        #region PrintData

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
        /// Constructor of CropIrrigationWeatherRecord()
        /// </summary>
        public CropIrrigationWeatherRecord()
        {
            this.CropIrrigationWeatherRecordId = 0;
            this.SowingDate = new DateTime();
            this.HarvestDate = new DateTime();
            this.CropDate = new DateTime();
            this.CropCoefficient = new CropCoefficient();

            this.DaysAfterSowing = 1;
            this.DaysAfterSowingModified = 1;
            this.GrowingDegreeDaysAccumulated = 0;
            this.GrowingDegreeDaysModified = 0;
            
            this.PhenologicalStage = new PhenologicalStage();
            this.PhenologicalStageByDayAfterSowing = new PhenologicalStage();
            this.PhenologicalStageByGrowingDegreeDays = new PhenologicalStage();

            this.HydricBalance = 0;
            this.SoilHydricVolume = 0;
            this.TotalEvapotranspirationCropFromLastWaterInput = 0;

            this.EffectiveRainList = new List<EffectiveRain>();
            this.LastWaterInputDate = new DateTime();
            this.LastBigWaterInputDate = new DateTime();
            this.LastPartialWaterInputDate = new DateTime();
            this.LastPartialWaterInput = 0;

            this.dailyRecordList = new List<DailyRecord>();
           
            this.Titles = new List<string>();
            this.Messages = new List<List<string>>();
            this.TitlesDaily = new List<string>();
            this.MessagesDaily = new List<List<string>>();

            this.outPut = printHeader();

        }

        /// <summary>
        /// Create an instance of CropIrrigationWeatherRecord using parameters
        /// </summary>
        /// <param name="pCropIrrigationWeatherRecordId"></param>
        /// <param name="pSowingDate"></param>
        /// <param name="pHarvestDate"></param>
        /// <param name="pCropDate"></param>
        /// <param name="pCropCoefficient"></param>
        /// <param name="pDayAfterSowing"></param>
        /// <param name="pDayAfterSowingModified"></param>
        /// <param name="pGrowingDegreeDaysAcumulated"></param>
        /// <param name="pGrowingDegreeDaysModified"></param>
        /// <param name="pPhenologicalStage"></param>
        /// <param name="pPhenologicalStageByDayAfterSowing"></param>
        /// <param name="pPhenologicalStageByGrowingDegreeDays"></param>
        /// <param name="pHidricBalance"></param>
        /// <param name="pSoilHidricVolume"></param>
        /// <param name="pTotalEvapotranspirationCropFromLastWaterInput"></param>
        /// <param name="pEffectiveRain"></param>
        /// <param name="pLastWaterInputDate"></param>
        /// <param name="pLastBigWaterInputDate"></param>
        /// <param name="pLastPartialWaterInputDate"></param>
        /// <param name="pLastPartialWaterInput"></param>
        /// <param name="pDailyRecords"></param>
        public CropIrrigationWeatherRecord(int pCropIrrigationWeatherRecordId, 
                                        DateTime pSowingDate, DateTime pHarvestDate, DateTime pCropDate,
                                        CropCoefficient pCropCoefficient,
                                        int pDayAfterSowing, int pDayAfterSowingModified, 
                                        Double pGrowingDegreeDaysAcumulated, Double pGrowingDegreeDaysModified,
                                        PhenologicalStage pPhenologicalStage, PhenologicalStage pPhenologicalStageByDayAfterSowing,
                                        PhenologicalStage pPhenologicalStageByGrowingDegreeDays, 
                                        Double pHidricBalance, Double pSoilHidricVolume, 
                                        Double pTotalEvapotranspirationCropFromLastWaterInput,
                                        List<EffectiveRain> pEffectiveRain, DateTime pLastWaterInputDate, 
                                        DateTime pLastBigWaterInputDate, DateTime pLastPartialWaterInputDate,
                                        Double pLastPartialWaterInput, List<DailyRecord> pDailyRecords)
         {
            this.CropIrrigationWeatherRecordId = pCropIrrigationWeatherRecordId;
            this.SowingDate = pSowingDate;
            this.HarvestDate = pHarvestDate;
            this.CropDate = pCropDate;
            this.CropCoefficient = pCropCoefficient;

            this.DaysAfterSowing = pDayAfterSowing;
            this.DaysAfterSowingModified = pDayAfterSowingModified;
            this.GrowingDegreeDaysAccumulated = pGrowingDegreeDaysAcumulated;
            this.GrowingDegreeDaysModified = pGrowingDegreeDaysModified;

            this.PhenologicalStage = pPhenologicalStage;
            this.PhenologicalStageByDayAfterSowing = pPhenologicalStageByDayAfterSowing;
            this.PhenologicalStageByGrowingDegreeDays = pPhenologicalStageByGrowingDegreeDays;

            this.HydricBalance = pHidricBalance;
            this.SoilHydricVolume = pSoilHidricVolume;
            this.TotalEvapotranspirationCropFromLastWaterInput = pTotalEvapotranspirationCropFromLastWaterInput;

            this.EffectiveRainList = pEffectiveRain;
            this.LastWaterInputDate = pLastWaterInputDate;
            this.LastBigWaterInputDate = pLastBigWaterInputDate;
            this.LastPartialWaterInputDate = pLastPartialWaterInputDate;
            this.LastPartialWaterInput = pLastPartialWaterInput;

            this.dailyRecordList = pDailyRecords;
            
            
            
            this.Titles = new List<string>();
            this.Messages = new List<List<string>>();
            this.TitlesDaily = new List<string>();
            this.MessagesDaily = new List<List<string>>();
            this.outPut = "";

        }

        #endregion

        #region Private Helpers

        #region GrowingDegreeDays

        /// <summary>
        /// Calculating GrowingDegreeDays Adding to GrowingDegreeDaysAccumulated and to GrowingDegreeDaysModified
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


        #endregion


        #region DailyRecord

        /// <summary>
        /// Get the Daily Record by a Date from parameters (do not consider the Time)
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        private DailyRecord getDailyRecordByDate(DateTime pDate)
        {
            DailyRecord lRetrun = null;
            IEnumerable<DailyRecord> lDailyRecordOrderByDate = null;

            if (pDate != null)
            {
                lDailyRecordOrderByDate = this.DailyRecordList.OrderBy(lDailyRecordItem => lDailyRecordItem.DailyRecordDateTime);

                foreach (DailyRecord lDailyRecordToDelete in lDailyRecordOrderByDate)
                {
                    //Compare Dates, is not important the Time
                    if (lDailyRecordToDelete.DailyRecordDateTime.Date.Equals(pDate.Date))
                    {
                        lRetrun = lDailyRecordToDelete;
                        break;
                    }
                }
            }

            return lRetrun;
        }

        /// <summary>
        /// Get the Daily Record by a Growing Degree Days according to Growing degree days accumulated
        /// </summary>
        /// <param name="pGrowingDegreeDays"></param>
        /// <returns></returns>
        private DailyRecord getDailyRecordByGrowingDegreeDaysAccumulated(Double pGrowingDegreeDays)
        {
            DailyRecord lRetrun = null;
            IEnumerable<DailyRecord> lDailyRecordOrderByDate = null;
            
            if (pGrowingDegreeDays > 0)
            {
                lDailyRecordOrderByDate = this.DailyRecordList.OrderBy(lDailyRecordToDelete => lDailyRecordToDelete.DailyRecordDateTime);

                foreach (DailyRecord lDailyRecordToDelete in lDailyRecordOrderByDate)
                {
                    //Compare Dates, is not important the Time
                    if (pGrowingDegreeDays <= lDailyRecordToDelete.GrowingDegreeDaysAccumulated)
                    {
                        lRetrun = lDailyRecordToDelete;
                    }
                }
            }

            return lRetrun;
        }

        /// <summary>
        /// Get the Daily Record by days after sowing according to Days After Sowing
        /// </summary>
        /// <param name="pDaysAfterSowingModified"></param>
        /// <returns></returns>
        private DailyRecord getDailyRecordByDaysAfterSowing(int pDaysAfterSowingModified)
        {
            DailyRecord lRetrun = null;
            IEnumerable<DailyRecord> lDailyRecordOrderByDate = null;
            
            if (pDaysAfterSowingModified > 0)
            {
                lDailyRecordOrderByDate = this.DailyRecordList.OrderBy(lDailyRecordToDelete => lDailyRecordToDelete.DailyRecordDateTime);

                foreach (DailyRecord lDailyRecordToDelete in lDailyRecordOrderByDate)
                {
                    if (lDailyRecordToDelete.DaysAfterSowing == pDaysAfterSowingModified)
                    {
                        lRetrun = lDailyRecordToDelete;
                        break;
                    }
                }
            }

            return lRetrun;
        }


        #endregion



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
        /// 
        /// </summary>
        /// <param name="pRecordToDelete"></param>
        private void takeOffDailyRecordDataFromTotals(DailyRecord pRecordToDelete)
        {
            int lDayAfterSowing;
            DateTime lDateOfDayAfterSowing;

            lDayAfterSowing = this.DaysAfterSowing - 1;
            lDateOfDayAfterSowing = this.CropDate.AddDays(-1);
            // Evapotraspiration revert
            if (pRecordToDelete.EvapotranspirationCrop != null)
            {
                //this.TotalEvapotranspirationCrop -= pRecordToDelete.EvapotranspirationCrop.GetTotalOutput();
                this.HydricBalance += pRecordToDelete.EvapotranspirationCrop.GetTotalOutput();
            }

            // Rain revert
            if (pRecordToDelete.Rain != null)
            {
                double lEffectiveRain = pRecordToDelete.Rain.GetTotalInput();
                double lRealRain = pRecordToDelete.Rain.GetTotalInput();
                //this.TotalEffectiveRain -= lEffectiveRain;
                //this.TotalRealRain -= lRealRain;
                this.HydricBalance -= lEffectiveRain;
            }

            // Irrigation revert
            if (pRecordToDelete.Irrigation != null)
            {
                //this.TotalIrrigation -= pRecordToDelete.Irrigation.Output;
                //this.TotalExtraIrrigation -= pRecordToDelete.Irrigation.ExtraOutput;
                this.HydricBalance -= pRecordToDelete.Irrigation.GetTotalInput();
            }
            

            // GrowingDegreeDaysAccumulated revert
            this.GrowingDegreeDaysAccumulated -= pRecordToDelete.GrowingDegreeDays;
            this.GrowingDegreeDaysModified -= pRecordToDelete.GrowingDegreeDaysModified;
            
        }

        #endregion

        #region Public Methods
        //     - GetPhenologicalStage(DayGrades: double): Stage
        //     - setGrowingDegreeDays(): bool
        //     - setPhenologicalState(Stage): bool
        //     - setNewPhenologicalStage(Stage): GrowingDegreeDaysAccumulated: double
        //     - GetPhenologicalStage(GrowingDegreeDaysAccumulated: double): Stage
        //     - getAvailableWater(RootDepth:double, FieldCapacity:double, lPermanentWiltingPoint:double): double
        //     - GetHydricBalance(): double
        //     - getSoilHydricVolume(): double


        #region CalculusByDaysAfterSowing
        #endregion


        #region CalculusGrowingDegreeDays
        #endregion


        /// <summary>
        /// Get days after sowing according degrees days calculated from the accumulated degree days by Daily Records
        /// </summary>
        /// <returns></returns>
        public int GetDaysAfterSowingForModifiedGrowingDegreeDays()
        {
            int lReturn = 0;
            double lLastGrowingDegreeDaysRegistry = 0;
            DateTime lDate = DateTime.MinValue;
            IEnumerable<DailyRecord> lDailyRecordOrderByDate = this.DailyRecordList.OrderBy(lDailyRecordItem => lDailyRecordItem.DailyRecordDateTime);

            foreach (DailyRecord lDailyRecordItem in lDailyRecordOrderByDate)
            {
                if (this.GrowingDegreeDaysModified <= lDailyRecordItem.GrowingDegreeDaysAccumulated && this.GrowingDegreeDaysModified > lLastGrowingDegreeDaysRegistry)
                {
                    lDate = lDailyRecordItem.DailyRecordDateTime;
                    lReturn = Utilities.Utils.GetDaysDifference(this.SowingDate, lDate);
                    return lReturn;
                }
                lLastGrowingDegrelDailyRecordItemy = lDailyRecord.GrowingDegreeDaysAccumulated;
            }
            return lReturn;
        }

        /// <summary>
        /// Return the effective lRainItem for a Rain dependin on:
        /// -the amount of lRainItem 
        /// -the month of the year
        /// This information is stored as a percentage in a field called EffectiveRainList that is a List<EffectiveRainList>
        /// </summary>
        /// <param name="pRain"></param>
        /// <returns></returns>
        public double getEffectiveRainValue(WaterInput pRain)
        {
            double lReturn = 0;
            if (pRain != null)
            {
                IEnumerable<EffectiveRain> lEffectiveRainListOrderByMonth = this.EffectiveRainList.OrderBy(lEffectiveRain => lEffectiveRain.Month);
                foreach (EffectiveRain lEffectiveRain in lEffectiveRainListOrderByMonth)
                {
                    if (pRain.Date.Month == lEffectiveRain.Month && lEffectiveRain.MinRain <= pRain.GetTotalInput() && lEffectiveRain.MaxRain >= pRain.GetTotalInput())
                    {
                        double totalInput = pRain.GetTotalInput();
                        lReturn = pRain.GetTotalInput() * lEffectiveRain.Percentage / 100;
                        return lReturn;
                    }
                }
            }
            return lReturn; ;
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
            foreach (DailyRecord lDailyRecordItem in this.DailyRecordList)
            {
                if (Utils.IsTheSameDay(pDateTime, lDailyRecordItem.DailyRecordDateTime))
                {
                    lDailyRecordItem.GrowingDegreeDaysModified += lModification;/lDailyRecordToDeleteord.GrowingDegreeDaysModified;
                    this.GrowingDegreeDaysModified += lModification;
                }
            }
        }

        /// <summary>
        /// Gives the effective lRainItem registered in a specific date including outputnputextraOutputInput value.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public double GetEffectiveRainByDate(DateTime pDate)
        {
            double lRetrun = 0;

            foreach (DailyRecord lDailyRecordItem in this.DailyRecordList)
            {
                if (lDailyRecordItem.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRecordItem.Rain.Output +lDailyRecordc.RainExtraOutputt;
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

            foreach (DailyRecord lDailyRecordItem in this.DailyRecordList)
            {
                if (lDailyRecordItem.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRecordItem;
                    break;
                }
            }
            
            return lRetrun;
        }

        /// <summary>
        /// Gives the growing degree registered in a specific date
        /// </summary>
        /// <param name="pDate">Date of the required information</param>
        /// <returns></returns>
        public double GetDailyRecordGrowingDegree(DateTime pDate)
        {
            double lRetrun = 0;

            foreach (DailyRecord lDailyRecordItem in this.DailyRecordList)
            {
                if (lDailyRecordItem.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRecordItem.GrowingDegreeDays;
                    break;
                }
            }
            return lRetrun;
        }

        /// <summary>
        /// Gives the evapoTranspiration registered in a specific date including the output andextraOutputt value.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public double GetEvapotranspirationCrop(DateTime pDate)
        {
            double lRetrun = 0;

            foreach (DailyRecord lDailyRecordItem in this.DailyRecordList)
            {
                if (lDailyRecordItem.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRecordItem.EvapotranspirationCrop.Output +lDailyRecordc.EvapotranspirationCropExtraOutputt;
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
            foreach (DailyRecord lDailyRecordItem in this.DailyRecordList)
            {
                if (lDailyRecordItem.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRecordItem.Observations;
                    break;
                }
            }
            return lRetrun;
        }

        /// <summary>
        /// Gives the evapoTranspiration registered in a Date and the two days before, including the output andextraOutputt value.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public double GetLastThreeDaysOfEvapotranspirationCrop(DateTime pDate)
        {
            double lRetrun = 0;
            DateTime oneDayBefore = pDate.AddDays(-1);
            DateTime twoDaysBefore = pDate.AddDays(-2);

            foreach (DailyRecord lDailyRecordItem in this.DailyRecordList)
            {
                if (lDailyRecordItem.DailyRecordDateTime.Date.Equals(pDate.Date) || lDailyRecordItem.DailyRecordDateTime.Date.Equals(oneDayBefore.Date) ||
                    lDailyRecordItem.DailyRecordDateTime.Date.Equals(twoDaysBefore.Date))
                {
                    lRetrun += lDailyRecordItem.EvapotranspirationCrop.Output +lDailyRecordc.EvapotranspirationCropExtraOutputt;
                }
            }
            return lRetrun;
        }




        #region Daily Data
        /// <summary>
        /// Verify if exist an older Daily Record, and if exists, replece it
        /// </summary>
        /// <param name="pDailyRecordDateTime"></param>
        /// <returns></returns>
        public DailyRecord UpdateDailyRecordList(DateTime pDailyRecordDateTime)
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
                takeOffDailyRecordDataFromTotals(lReturn);
                this.DailyRecordList.RemoveAt(lIndexToRemove);
            }

            return lReturn;

        }


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
                DailyRecord lDailyRecordToDelete;
                int lDaysAfterSowingModified;
                int lDaysAfterSowingModified;
                Double lCropCoefficient;
                Double lEvapotranspirationCropInput;
                WaterOutput lEvapotranspirationCrop;
                DailyRecord lNewDailyRecord;

                lDailyRecordDateTime = pWeatherData.Date;

                lEvapotranspiration = pWeatherData.GetEvapotranspiration();
                
                //Growing Degree Days is average temperature menous Base Temperature                
                lGrowingDegreeDays = this.calculateGrowingDegreeDaysForOneDay(pBaseTemperature, pWeatherData.GetAverageTemperature());

                lDaysAfterSowingModified = Utils.GetDaysDifference(this.SowingDate, pWeatherData.Date);

                //Get days after sowing according degrees days calculated from the accumulated degree days by Daily Records
                lDailyRecordToDelete = this.getDailyRecordByGrowingDegreeDaysAccumulated(this.GrowingDegreeDaysModified);
                    
                //If we do not modified GDD, DAS will be 0
                if (lDailyRecordToDelete == null)
                {
                    lDaysAfterSowingModified = lDaysAfterSowingModified;
                }
                else 
                {
                    lDaysAfterSowingModified = lDailyRecordToDelete.DaysAfterSowing;
                }

                lCropCoefficient = this.CropCoefficient.GetCropCoefficient(lDaysAfterSowingModified);

                lEvapotranspirationCropInput = lEvapotranspiration * lCropCoefficient;
                lEvapotranspirationCrop = new EvapotranspirationCrop(pWeatherData.Date, lEvapotranspirationCropInput);

                //We need to update some fields for calculations:
                //  pLastWaterInputDate, pLastBigWaterInputDate, 
                //  pLastPartialWaterInputDate, pLastPartialWaterInput, 
                //  this.HydricBalance, this.SoilHydricVolume,
                //  this.TotalEvapotranspirationCropFromLastWaterInput
                lNewDailyRecord = new DailyRecord(lDailyRecordDateTime, pMainWeatherData, pAlternativeWeatherData,
                                                lDaysAfterSowingModified, lDaysAfterSowingModified,
                                                lGrowingDegreeDays, this.GrowingDegreeDaysAccumulated, this.GrowingDegreeDaysModified,
                                                pRain, pIrrigation, pLastWaterInputDate, pLastBigWaterInputDate, 
                                                pLastPartialWaterInputDate, pLastPartialWaterInput, 
                                                lEvapotranspirationCrop, this.HydricBalance, this.SoilHydricVolume,
                                                this.TotalEvapotranspirationCropFromLastWaterInput,
                                                lCropCoefficient, pObservations);

                this.UpdateDailyRecordList(lDailyRecordDateTime);
               

                //If it's the initial registry set the initial Hidric Balance
                if (lDaysAfterSowingModified == 0)
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

        #endregion



        #region Print

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
            string lSoilFieldCapacity;
            string lPermanentWilingPoint;
            string lIrrigationItem;
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
            lPercentageOfAvailableWater = pCropIrrigationWeather.GetPercentageOfHydricBalanceInCrop() + "        ";
            lAvailableWater = pCropIrrigationWeather.GetSoilAvailableWaterCapacity() + "        ";
            lSoilFieldCapacity = pCropIrrigationWeather.GetSoilFieldCapacity() + "        ";
            lPermanentWilingPoint = pCropIrrigationWeather.GetSoilPermanentWiltingPoint() + "        ";

            Water.Irrigation lWaterInput = this.GetDailyRecordByDate(this.CropDate).Irrigation;
            if (lWaterInput == null)
            {
                lIrrigationItem = 0 + "        ";
                lExtraIrrigation = 0 + "        ";
                lTypeOfIrrigation = "                                 ";
            }
            else
            {
                lIrrigationItem = lWaterInOutputnput.ToString() + "        ";
                lExtraIrrigation = lWaterInput.ExtraOutput.ToString() + "        ";
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
                " \t " + lSoilFieldCapacity.Substring(0, 7) +
                " \t " + lPermanentWilingPoint.Substring(0, 7) +
                " \t " + lEffectiveRain.Substring(0, 7) +
                " \t " + lTotalRain.Substring(0, 7) +
                " \t " + this.LastWaterInputDate.ToShortDateString() +
                " \t\t " + pCropIrrigationWeather.GetRootDepthTakingIntoAccountDepthLimitByPhenologicalStage(this.PhenologicalStage) +
                " \tf " + this.PhenologicalStage.Stage.Name +
                " \t " + lIrrigationItem.Substring(0, 7) +
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
            lMessage.Add(lSoilFieldCapacity.Substring(0, 7));
            lMessage.Add(lPermanentWilingPoint.Substring(0, 7));
            lMessage.Add(lEffectiveRain.Substring(0, 7));
            lMessage.Add(lTotalRain.Substring(0, 7));
            lMessage.Add(this.lastWaterInputDate.ToShortDateString());
            lMessage.Add(pCropIrrigationWeather.GetRootDepthTakingIntoAccountDepthLimitByPhenologicalStage(this.PhenologicalStage).ToString());
            lMessage.Add(this.PhenologicalStage.Stage.Name);
            lMessage.Add(lIrrigationItem.Substring(0, 7));
            lMessage.Add(lTypeOfIrrigation.Substring(0, 30));
            lMessage.Add(lTotIrrInHB.Substring(0, 7));
            lMessage.Add(lExtraIrrigation.Substring(0, 7));
            lMessage.Add(lTotExtraIrrInHB.Substring(0, 7));

            this.Messages.Add(lMessage);

            return lReturn;
        }

        #endregion

        #endregion

        #region Overrides
        #endregion


    }
}

*/