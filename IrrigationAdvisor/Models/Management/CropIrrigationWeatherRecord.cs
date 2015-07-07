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
    ///     - cropIrrigationWeatherRecordId: int
    ///     - cropIrrigationWeather: CropIrrigationWeather    - PK
    ///     - dailyRecordList: List<DailyRecord>
    ///     - growingDegreeDaysAcumulated: double
    ///     - growingDegreeDaysModified: double
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
    ///     - setNewPhenologicalStage(Stage): GrowingDegreeDaysAcumulated: double
    ///     - GetRootDepth(Specie, Stage): double
    ///     - GetPhenologicalStage(GrowingDegreeDaysAcumulated: double): Stage
    ///     - getAvailableWater(RootDepth:double, FieldCapacity:double, lPermanentWiltingPoint:double): double
    ///     - GetHydricBalance(): double
    ///     - getSoilHydricVolume(): double
    ///     - GetEffectiveRain(Date): double
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

        private int cropIrrigationWeatherRecordId;
        private Pair<int, DateTime> dayAfterSowing;
        private List<EffectiveRain> effectiveRain;
        private List<DailyRecord> dailyRecordList;
        private double growingDegreeDaysAcumulated;
        private double growingDegreeDaysModified;
        private double hydricBalance;
        private double soilHydricVolume;
        private DateTime lastWaterInputDate;
        private DateTime lastBigWaterInputDate;
        private DateTime lastPartialWaterInputDate;
        private double lastPartialWaterInput;
        private double totalEvapotranspirationCropFromLastWaterInput;

        private PhenologicalStage phenologicalStage;
        private DateTime sowingDate;
        private DateTime harvestDate;
        
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

        public Pair<int, DateTime> DayAfterSowing
        {
            get { return dayAfterSowing; }
            set { dayAfterSowing = value; }
        }

        public List<EffectiveRain> EffectiveRain
        {
            get { return effectiveRain; }
            set { effectiveRain = value; }
        }

        public List<DailyRecord> DailyRecordList
        {
            get { return dailyRecordList; }
            set { dailyRecordList = value; }
        }

        public double GrowingDegreeDaysAcumulated
        {
            get { return growingDegreeDaysAcumulated; }
            set { growingDegreeDaysAcumulated = value; }
        }

        public double GrowingDegreeDaysModified
        {
            get { return growingDegreeDaysModified; }
            set { growingDegreeDaysModified = value; }
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

        public double TotalEvapotranspirationCropFromLastWaterInput
        {
            get { return totalEvapotranspirationCropFromLastWaterInput; }
            set { totalEvapotranspirationCropFromLastWaterInput = value; }
        }
        
        public PhenologicalStage PhenologicalStage
        {
            get { return phenologicalStage; }
            set { phenologicalStage = value; }
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
            this.CropIrrigationWeatherRecordId = 0;
            this.DayAfterSowing = new Pair<int, DateTime>(1, DateTime.MinValue);
            this.EffectiveRain = new List<EffectiveRain>();
            this.DailyRecordList = new List<DailyRecord>();
            this.GrowingDegreeDaysAcumulated = 0;
            this.GrowingDegreeDaysModified = 0;
            this.HydricBalance = 0;
            this.SoilHydricVolume = 0;
            this.LastWaterInputDate = DateTime.Now;
            this.TotalEvapotranspirationCropFromLastWaterInput = 0;

            this.PhenologicalStage = new PhenologicalStage();
            this.SowingDate = new DateTime();
            this.HarvestDate = new DateTime();

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
        /// <param name="pDayAfterSowing"></param>
        /// <param name="pEffectiveRain"></param>
        /// <param name="pDailyRecords"></param>
        /// <param name="pGrowingDegreeDaysAcumulated"></param>
        /// <param name="pGrowingDegreeDaysModified"></param>
        /// <param name="pHidricBalance"></param>
        /// <param name="pSoilHidricVolume"></param>
        /// <param name="pLastWaterInput"></param>
        /// <param name="pTotalEvapotranspirationCropFromLastWaterInput"></param>
        /// <param name="pPhenologicalStage"></param>
        /// <param name="pSowingDate"></param>
        /// <param name="pHarvestDate"></param>
        public CropIrrigationWeatherRecord(int pCropIrrigationWeatherRecordId, Pair<int, DateTime> pDayAfterSowing,
                                        List<EffectiveRain> pEffectiveRain, List<DailyRecord> pDailyRecords, 
                                        double pGrowingDegreeDaysAcumulated, double pGrowingDegreeDaysModified, 
                                        double pHidricBalance, double pSoilHidricVolume, DateTime pLastWaterInput, 
                                        double pTotalEvapotranspirationCropFromLastWaterInput,
                                        PhenologicalStage pPhenologicalStage, 
                                        DateTime pSowingDate, DateTime pHarvestDate)
         {
            this.CropIrrigationWeatherRecordId = pCropIrrigationWeatherRecordId;
            this.DayAfterSowing = pDayAfterSowing;
            this.EffectiveRain = pEffectiveRain;
            this.DailyRecordList = pDailyRecords;
            this.GrowingDegreeDaysAcumulated = pGrowingDegreeDaysAcumulated;
            this.GrowingDegreeDaysModified = pGrowingDegreeDaysModified;
            
            this.HydricBalance = pHidricBalance;
            this.SoilHydricVolume = pSoilHidricVolume;
            this.LastWaterInputDate = pLastWaterInput;
            this.TotalEvapotranspirationCropFromLastWaterInput = pTotalEvapotranspirationCropFromLastWaterInput;
            
            this.PhenologicalStage = pPhenologicalStage;
            this.SowingDate = pSowingDate;
            this.HarvestDate = pHarvestDate;
            
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
        /// Get Days after Sowing for Modified Growing Degree
        /// </summary>
        /// <returns></returns>
        public int GetDaysAfterSowingForModifiedGrowingDegree()
        {
            int lReturn = 0;
            double lastGDRegistry = 0;
            DateTime lDate = DateTime.MinValue;
            IEnumerable<DailyRecord> lDailyRecordOrderByDate = this.DailyRecordList.OrderBy(lDailyRec => lDailyRec.DateHour);

            foreach (DailyRecord lDailyRec in lDailyRecordOrderByDate)
            {
                if (this.GrowingDegreeDaysModified <= lDailyRec.GrowingDegreeAcumulated && this.GrowingDegreeDaysModified > lastGDRegistry)
                {
                    lDate = lDailyRec.DateHour;
                    lReturn = Utilities.Utils.getDaysDifference(this.SowingDate, lDate);
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
        /// TODO add description
        /// </summary>
        /// <returns></returns>
        public string PrintState(CropIrrigationWeather pCropIrrigationWeather)
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
            string lIrrigation;
            string lTypeOfIrrigation;
            string lTotIrrInHB;
            string lExtraIrrigation ;
            string lTotExtraIrrInHB;


            lReturn = "";
            lETcAcumulated = pCropIrrigationWeather.TotalEvapotranspirationCrop + "        ";
            lETcFromLastWaterInput = this.TotalEvapotranspirationCropFromLastWaterInput + "        ";
            lGrowDegree = this.GrowingDegreeDaysAcumulated + "        ";
            lModifiedGrowingDegree = this.GrowingDegreeDaysModified + "        ";
            lEffectiveRain = pCropIrrigationWeather.TotalEffectiveRain + "        ";
            lTotalRain = pCropIrrigationWeather.TotalRealRain + "        ";
            lHydricBalance = this.HydricBalance.ToString() + "        ";
            lPercentageOfAvailableWater = pCropIrrigationWeather.GetPercentageOfWaterInCrop() + "        ";
            lAvailableWater = pCropIrrigationWeather.GetSoilAvailableWaterCapacity() + "        ";
            lFieldCapacity = pCropIrrigationWeather.GetSoilFieldCapacity() + "        ";
            lPermanentWilingPoint = pCropIrrigationWeather.GetSoilPermanentWiltingPoint() + "        ";

            Water.Irrigation lWaterInput = this.GetDailyRecordByDate(this.DayAfterSowing.Second).Irrigation;
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

        #region Public Methods
        //     - GetPhenologicalStage(DayGrades: double): Stage
        //     - setGrowingDegreeDays(): bool
        //     - setPhenologicalState(Stage): bool
        //     - setNewPhenologicalStage(Stage): GrowingDegreeDaysAcumulated: double
        //     - GetPhenologicalStage(GrowingDegreeDaysAcumulated: double): Stage
        //     - getAvailableWater(RootDepth:double, FieldCapacity:double, lPermanentWiltingPoint:double): double
        //     - GetHydricBalance(): double
        //     - getSoilHydricVolume(): double


        
        

        /// <summary>
        /// Search the DailyRecord for the date passed by parameter.
        /// If find one change the ModifiedGrowingDegree for this DailyRecord and change the GrowingDegreeDaysModified field 
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
                    this.GrowingDegreeDaysModified += lModification;
                }
            }
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