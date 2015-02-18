using IrrigationAdvisor.Models.Agriculture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Data;

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
    ///     - idCropIrrigationWeatherRecord: int
    ///     - cropIrrigationWeather: CropIrrigationWeather    - PK
    ///     - dailyRecords: List<DailyRecord>
    ///     - growingDegreeDays: double
    ///     - modifiedGrowingDegreeDays: double
    ///     - totalEvapotranspirationCrop: double
    ///     - totalEffectiveRain: double
    ///     - totalIrrigation: double
    ///     - totalExtraIrrigation: double
    ///     - hydricBalance: double
    ///     - soilHydricVolume: double
    ///     - lastWaterInput: Date
    ///     - lastBigWaterInput: Date
    ///     - totalEvapotranspirationCropFromLastWaterInput: double
    /// 
    /// Methods:
    ///     - IrrigationRecords()      -- constructor
    ///     - IrrigationRecords(name)  -- consturctor with parameters
    ///     - GetPhenologicalStage(DayGrades: double): Stage
    ///     - setGrowingDegreeDays(): bool
    ///     - setPhenologicalState(Stage): bool
    ///     - setNewPhenologicalStage(Stage): GrowingDegreeDays: double
    ///     - GetRootDepth(Specie, Stage): double
    ///     - GetPhenologicalStage(GrowingDegreeDays: double): Stage
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
    public class CropIrrigationWeatherRecord
    {

        #region Consts

        #endregion

        #region Fields

        private int idCropIrrigationWeatherRecord;
        private Pair<int, DateTime> dayAfterSowing;
        private List<EffectiveRain> effectiveRain;
        private CropIrrigationWeather cropIrrigationWeather;
        private List<DailyRecord> dailyRecords;
        private double growingDegreeDays;
        private double modifiedGrowingDegreeDays;
        private double totalEvapotranspirationCrop;
        private double totalEffectiveRain;
        private double totalRealRain;
        private double totalIrrigation;
        private double totalIrrigationInHidricBalance;
        private double totalExtraIrrigation;
        private double totalExtraIrrigationInHidricBalance;
        private double hydricBalance;
        private double soilHydricVolume;
        private DateTime lastWaterInputDate;
        private DateTime lastBigWaterInputDate;
        private DateTime lastPartialWaterInputDate;
        private double lastPartialWaterInput;
        private double totalEvapotranspirationCropFromLastWaterInput;

        private String outPut;

        private List<String> titles;
        private List<List<String>> messages;
        private List<String> titlesDaily;
        private List<List<String>> messagesDaily;



        #endregion

        #region Properties

        public int IdCropIrrigationWeatherRecord
        {
            get { return idCropIrrigationWeatherRecord; }
            set { idCropIrrigationWeatherRecord = value; }
        }

        public Pair<int, DateTime> DayAfterSowing
        {
            get { return dayAfterSowing; }
            set { dayAfterSowing = value; }
        }

        public CropIrrigationWeather CropIrrigationWeather
        {
            get { return cropIrrigationWeather; }
            set { cropIrrigationWeather = value; }
        }

        public List<EffectiveRain> EffectiveRain
        {
            get { return effectiveRain; }
            set { effectiveRain = value; }
        }

        public double TotalRealRain
        {
            get { return totalRealRain; }
            set { totalRealRain = value; }
        }

        public List<DailyRecord> DailyRecordList
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

        public double LastPartialWaterInput
        {
            get { return lastPartialWaterInput; }
            set { lastPartialWaterInput = value; }
        }

        public DateTime LastPartialWaterInputDate
        {
            get { return lastPartialWaterInputDate; }
            set { lastPartialWaterInputDate = value; }
        }


        public double TotalEvapotranspirationCropFromLastWaterInput
        {
            get { return totalEvapotranspirationCropFromLastWaterInput; }
            set { totalEvapotranspirationCropFromLastWaterInput = value; }
        }

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

        #region Construction

        public CropIrrigationWeatherRecord()
        {
            this.IdCropIrrigationWeatherRecord = 0;
            this.DayAfterSowing = new Pair<int, DateTime>(1, DateTime.MinValue);
            this.CropIrrigationWeather = new CropIrrigationWeather();
            this.EffectiveRain = new List<EffectiveRain>();
            this.DailyRecordList = new List<DailyRecord>();
            this.GrowingDegreeDays = 0;
            this.ModifiedGrowingDegreeDays = 0;
            this.TotalEvapotranspirationCrop = 0;
            this.TotalEffectiveRain = 0;
            this.TotalRealRain = 0;
            this.TotalIrrigation = 0;
            this.totalIrrigationInHidricBalance = 0;
            this.TotalExtraIrrigation = 0;
            this.TotalExtraIrrigationInHidricBalance = 0;
            this.HydricBalance = this.CropIrrigationWeather.GetInitialHidricBalance();
            this.SoilHydricVolume = 0;
            this.LastWaterInputDate = DateTime.Now;
            this.TotalEvapotranspirationCropFromLastWaterInput = 0;

            this.Titles = new List<string>();
            this.Messages = new List<List<string>>();
            this.TitlesDaily = new List<string>();
            this.MessagesDaily = new List<List<string>>();

            this.outPut = printHeader();

        }

        public CropIrrigationWeatherRecord(int pId, Pair<int, DateTime> pDayAfterSowing, CropIrrigationWeather pCropIrrigationWeather,
            List<EffectiveRain> pEffectiveRain, List<DailyRecord> pDailyRecords, double pGrowingDegreeDays,
            double pModifiedGrowingDegreeDays, double pTotalEvapotranspirationCrop, double pTotalEffectiveRain,
            double pTotalRealRain, double pTotalIrrigation, double pTotalExtraIrrigation, double pHidricBalance, double pSoilHidricVolume,
            DateTime pLastWaterInput, double pTotalEvapotranspirationCropFromLastWaterInput)
        {
            this.IdCropIrrigationWeatherRecord = pId;
            this.DayAfterSowing = pDayAfterSowing;
            this.CropIrrigationWeather = pCropIrrigationWeather;
            this.EffectiveRain = pEffectiveRain;
            this.DailyRecordList = pDailyRecords;
            this.GrowingDegreeDays = pGrowingDegreeDays;
            this.ModifiedGrowingDegreeDays = pModifiedGrowingDegreeDays;
            this.TotalEvapotranspirationCrop = pTotalEvapotranspirationCrop;
            this.TotalEffectiveRain = pTotalEffectiveRain;
            this.TotalRealRain = pTotalRealRain;
            this.TotalIrrigation = pTotalIrrigation;
            this.TotalIrrigationInHidricBalance = 0;
            this.TotalExtraIrrigation = pTotalExtraIrrigation;
            this.TotalExtraIrrigationInHidricBalance = 0;
            this.HydricBalance = pHidricBalance;
            this.SoilHydricVolume = pSoilHidricVolume;
            this.LastWaterInputDate = pLastWaterInput;
            this.TotalEvapotranspirationCropFromLastWaterInput = pTotalEvapotranspirationCropFromLastWaterInput;

            this.Titles = new List<string>();
            this.Messages = new List<List<string>>();
            this.TitlesDaily = new List<string>();
            this.MessagesDaily = new List<List<string>>();
            this.outPut = "";

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
            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.Irrigation != null && lDailyRec.Irrigation.getTotalInput() > 0 && lDailyRec.DateHour > lReturn)
                {
                    lReturn = lDailyRec.DateHour;
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
        /// Get Days after Sowing for Modified Growing Degree
        /// </summary>
        /// <returns></returns>
        public int getDaysAfterSowingForModifiedGrowingDegree()
        {
            int lReturn = 0;
            double lastGDRegistry = 0;
            DateTime lDate = DateTime.MinValue;
            IEnumerable<DailyRecord> lDailyRecordOrderByDate = this.DailyRecordList.OrderBy(lDailyRec => lDailyRec.DateHour);

            foreach (DailyRecord lDailyRec in lDailyRecordOrderByDate)
            {
                if (this.ModifiedGrowingDegreeDays <= lDailyRec.GrowingDegreeAcumulated && this.ModifiedGrowingDegreeDays > lastGDRegistry)
                {
                    lDate = lDailyRec.DateHour;
                    lReturn = Utilities.Utils.getDaysDifference(this.CropIrrigationWeather.SowingDate, lDate);
                    return lReturn;
                }
                lastGDRegistry = lDailyRec.GrowingDegreeAcumulated;
            }
            return lReturn;
        }



        /// <summary>
        /// Return the effective rain for a Rain dependin on:
        /// -the amount of rain 
        /// -the month of the year
        /// This information is stored as a percentage in a field called EffectiveRain that is a List<EffectiveRain>
        /// </summary>
        /// <param name="pRain"></param>
        /// <returns></returns>
        public double getEffectiveRainValue(WaterInput pRain)
        {
            double pReturn = 0;
            if (pRain != null)
            {
                IEnumerable<EffectiveRain> lEffectiveRainListOrderByMonth = this.EffectiveRain.OrderBy(lEffectiveRain => lEffectiveRain.Month);
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
        /// 
        /// </summary>
        /// <returns></returns>
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
            this.Titles.Add("% AD");
            this.Titles.Add("Ag-Disp");
            this.Titles.Add("CC");
            this.Titles.Add("PMP");
            this.Titles.Add("LLu-Ef");
            this.Titles.Add("Llu-Tot");
            this.Titles.Add("Fecha-Ult-Llu");
            this.Titles.Add("Raiz");
            this.Titles.Add("Fenol");
            this.Titles.Add("RiegoCalc");
            this.Titles.Add("TotRiegoCalcInBI");
            this.Titles.Add("RiegoExtra");
            this.Titles.Add("TotRiegoExtraInBI");

            return lRetrun;
        }




        /// <summary>
        /// TODO add description
        /// </summary>
        /// <returns></returns>
        public string printState()
        {
            List<String> lMessage;
            string lReturn;
            string lETcAcumulated ;
            string lETcFromLastWaterInput ;
            string lGrowDegree ;
            string lModifiedGrowingDegree ;
            string lEffectiveRain ;
            string lTotalRain ;
            string lHydricBalance ;
            string lPercentageOfAvailableWater ;
            string lAvailableWater;
            string lFieldCapacity;
            string lPermanentWilingPoint ;
            string lIrrigation ;
            string lTotIrrInHB ;
            string lExtraIrrigation ;
            string lTotExtraIrrInHB;


            lReturn = "";
            lETcAcumulated = this.TotalEvapotranspirationCrop + "        ";
            lETcFromLastWaterInput = this.TotalEvapotranspirationCropFromLastWaterInput + "        ";
            lGrowDegree = this.GrowingDegreeDays + "        ";
            lModifiedGrowingDegree = this.ModifiedGrowingDegreeDays + "        ";
            lEffectiveRain = this.TotalEffectiveRain + "        ";
            lTotalRain = this.TotalRealRain + "        ";
            lHydricBalance = this.HydricBalance.ToString() + "        ";
            lPercentageOfAvailableWater = this.getPercentageOfAvailableWater() + "        ";
            lAvailableWater = this.getSoilAvailableWaterCapacity() + "        ";
            lFieldCapacity = this.getSoilFieldCapacity() + "        ";
            lPermanentWilingPoint = this.getSoilPermanentWiltingPoint() + "        ";

            WaterInput lWaterInput = this.GetDailyRecordByDate(this.DayAfterSowing.Second).Irrigation;
            if (lWaterInput == null)
            {
                lIrrigation = 0 + "        ";
                lExtraIrrigation = 0 + "        ";
            }
            else
            { 
                lIrrigation = lWaterInput.Input.ToString() + "        ";
                lExtraIrrigation = lWaterInput.ExtraInput.ToString() + "        ";
            }
            lTotIrrInHB = this.TotalIrrigationInHidricBalance.ToString() + "        ";
            lTotExtraIrrInHB = this.TotalExtraIrrigationInHidricBalance.ToString() + "        ";


            lReturn = this.DayAfterSowing.First.ToString() +
                " \t " + this.DayAfterSowing.Second.ToShortDateString() +
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
                " \t\t " + this.GetRootDepth() +
                " \tf " + this.CropIrrigationWeather.PhenologicalStage.Stage.Name +
                " \t " + lIrrigation.Substring(0, 7) +
                " \t " + lTotIrrInHB.Substring(0, 7) +
                " \t " + lExtraIrrigation.Substring(0, 7) +
                " \t " + lTotExtraIrrInHB.Substring(0, 7) +
                Environment.NewLine;

            if (this.Messages == null)
                this.Messages = new List<List<string>>();
            lMessage = new List<string>();
            lMessage.Add(this.DayAfterSowing.First.ToString());
            lMessage.Add(this.DayAfterSowing.Second.ToShortDateString());
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
            lMessage.Add(this.GetRootDepth().ToString());
            lMessage.Add(this.CropIrrigationWeather.PhenologicalStage.Stage.Name);
            lMessage.Add(lIrrigation.Substring(0, 7));
            lMessage.Add(lTotIrrInHB.Substring(0, 7));
            lMessage.Add(lExtraIrrigation.Substring(0, 7));
            lMessage.Add(lTotExtraIrrInHB.Substring(0, 7));

            this.Messages.Add(lMessage);

            return lReturn;
        }


        #endregion

        #region Public Methods
        //     - GetPhenologicalStage(DayGrades: double): Stage
        //     - setGrowingDegreeDays(): bool
        //     - setPhenologicalState(Stage): bool
        //     - setNewPhenologicalStage(Stage): GrowingDegreeDays: double
        //     - GetPhenologicalStage(GrowingDegreeDays: double): Stage
        //     - getAvailableWater(RootDepth:double, FieldCapacity:double, PermanentWiltingPoint:double): double
        //     - getHydricBalance(): double
        //     - getSoilHydricVolume(): double


        /// <summary>
        /// Get Root Depth from Crop Phenological Stage
        /// </summary>
        /// <returns></returns>
        public double GetRootDepth()
        {
            double lRootDepth;
            lRootDepth = this.CropIrrigationWeather.GetPhenologicalStageRootDepth(this.CropIrrigationWeather.PhenologicalStage);
            return lRootDepth;
        }

        /// <summary>
        /// Get Depth from Crop Phenological Stage
        /// </summary>
        /// <returns></returns>
        public double GetDepth()
        {
            double lDepth;
            lDepth = this.CropIrrigationWeather.GetPhenologicalStageDepth(this.CropIrrigationWeather.PhenologicalStage);
            return lDepth;
        }

        /// <summary>
        /// Search the DailyRecord for the date passed by parameter.
        /// If find one change the ModifiedGrowingDegree for this DailyRecord and change the ModifiedGrowingDegreeDays field 
        /// adding the value passed by parameter as lModification
        /// </summary>
        /// <param name="pStage"></param>
        /// <param name="pDateTime"></param>
        /// <param name="lModification"></param>
        public void adjustmentPhenology(Stage pStage, DateTime pDateTime, double lModification)
        {
            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (Utils.isTheSameDay(pDateTime, lDailyRec.DateHour))
                {
                    lDailyRec.ModifiedGrowingDegree += lModification;// +lDailyRec.ModifiedGrowingDegree;
                    this.ModifiedGrowingDegreeDays += lModification;
                }
            }
        }

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

            lHidricBalance = this.HydricBalance;
            lFieldCapacity = this.getSoilFieldCapacity();
            lPermanentWiltingPoint = this.getSoilPermanentWiltingPoint();

            lPercentageOfAvailableWater = Math.Round(((lHidricBalance - lPermanentWiltingPoint) * 100)
                                        / (lFieldCapacity - lPermanentWiltingPoint), 2);
            return lPercentageOfAvailableWater;
        }

        /// <summary>
        /// Get Soil Permanent Wilting Poing
        /// The data is obtained from Crop Soil depending Root Depth
        /// </summary>
        /// <returns></returns>
        public double getSoilPermanentWiltingPoint()
        {
            double lSoilPermanentWiltingPoint;

            lSoilPermanentWiltingPoint = this.CropIrrigationWeather.GetSoilPermanentWiltingPoint();
            return lSoilPermanentWiltingPoint;
        }

        /// <summary>
        /// Get Soil Available Water Capacity 
        /// From Crop Soil by Root Depth 
        /// </summary>
        /// <returns></returns>
        public double getSoilAvailableWaterCapacity()
        {
            double lSoilAvailableWaterCapacity;

            lSoilAvailableWaterCapacity = this.CropIrrigationWeather.GetSoilAvailableWaterCapacity();
            return lSoilAvailableWaterCapacity;
        }

        /// <summary>
        /// Get Soil Field Capacity
        /// From Crop Soil by Root Depth
        /// </summary>
        /// <returns></returns>
        public double getSoilFieldCapacity()
        {
            double lSoilFieldCapacity;

            lSoilFieldCapacity = this.CropIrrigationWeather.GetSoilFieldCapacity();
            return lSoilFieldCapacity;
        }

        /// <summary>
        /// Gives the effective rain registered in a specific date including the input and extraInput value.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public double GetEffectiveRainByDate(DateTime pDate)
        {
            double lRetrun = 0;

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DateHour.Date.Equals(pDate.Date))
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
                if (lDailyRec.DateHour.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRec;
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
        public double getGrowingDegree(DateTime pDate)
        {
            double lRetrun = 0;

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DateHour.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRec.GrowingDegree;
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
        public double getEvapotranspirationCrop(DateTime pDate)
        {
            double lRetrun = 0;

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DateHour.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRec.EvapotranspirationCrop.Input + lDailyRec.EvapotranspirationCrop.ExtraInput;
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
        public String getObservations(DateTime pDate)
        {
            String lRetrun = "";
            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DateHour.Date.Equals(pDate.Date))
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
        public double GetLastThreeDaysOfEvapotranspirationCrop(DateTime pDate)
        {
            double lRetrun = 0;
            DateTime oneDayBefore = pDate.AddDays(-1);
            DateTime twoDaysBefore = pDate.AddDays(-2);

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DateHour.Date.Equals(pDate.Date) || lDailyRec.DateHour.Date.Equals(oneDayBefore.Date) ||
                    lDailyRec.DateHour.Date.Equals(twoDaysBefore.Date))
                {
                    lRetrun += lDailyRec.EvapotranspirationCrop.Input + lDailyRec.EvapotranspirationCrop.ExtraInput;
                }
            }
            return lRetrun;
        }

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
                lMessageDaily.Add(lDR.DateHour.ToString());
                lMessageDaily.Add(lDR.GrowingDegree.ToString());
                lMessageDaily.Add(lDR.EvapotranspirationCrop.getTotalInput().ToString());
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
                lMessageDaily.Add(lDR.Kc.ToString());
                lMessageDaily.Add(lDR.Observations);
                this.MessagesDaily.Add(lMessageDaily);
            }
        }


        #endregion

        #region Overrides
        #endregion




    }
}