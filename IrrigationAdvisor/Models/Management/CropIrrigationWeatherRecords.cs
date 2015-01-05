using IrrigationAdvisor.Models.Crop;
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
    ///     - idCropIrrigationWeatherRecords: int
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
        private double totalExtraIrrigation;
        private double hydricBalance;
        private double soilHydricVolume;
        private DateTime lastWaterInputDate;
        private DateTime lastBigWaterInputDate;
        private double totalEvapotranspirationCropFromLastWaterInput;

        private String outPut;

        private List<String> titles;
        private List<List<String>> messages;
        private List<String> titlesDaily;
        private List<List<String>> messagesDaily;


        #endregion

        #region Properties

        public int IdCropIrrigationWeatherRecords
        {
            get { return idCropIrrigationWeatherRecords; }
            set { idCropIrrigationWeatherRecords = value; }
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

        public double TotalExtraIrrigation
        {
            get { return totalExtraIrrigation; }
            set { totalExtraIrrigation = value; }
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

        public CropIrrigationWeatherRecords()
        {
            this.IdCropIrrigationWeatherRecords = 0;
            this.DayAfterSowing = new Pair<int,DateTime>(1,DateTime.MinValue);
            this.CropIrrigationWeather = new CropIrrigationWeather();
            this.EffectiveRain = new List<EffectiveRain>();
            this.DailyRecords = new List<DailyRecord>();
            this.GrowingDegreeDays = 0;
            this.ModifiedGrowingDegreeDays = 0;
            this.TotalEvapotranspirationCrop = 0;
            this.TotalEffectiveRain = 0;
            this.TotalRealRain = 0;
            this.TotalIrrigation = 0; 
            this.TotalExtraIrrigation = 0;
            this.HydricBalance = this.getInitialHidricBalance();
            this.SoilHydricVolume = 0;
            this.LastWaterInputDate = DateTime.Now;
            this.TotalEvapotranspirationCropFromLastWaterInput = 0;

            this.Titles = new List<string>();
            this.Messages = new List<List<string>>();
            this.TitlesDaily = new List<string>();
            this.MessagesDaily = new List<List<string>>();

            this.outPut = printHeader(); 

        }

        public CropIrrigationWeatherRecords(int pId, Pair<int,DateTime> pDayAfterSowing, CropIrrigationWeather pCropIrrigationWeather,
            List<EffectiveRain> pEffectiveRain, List<DailyRecord> pDailyRecords, double pGrowingDegreeDays,
            double pModifiedGrowingDegreeDays, double pTotalEvapotranspirationCrop, double pTotalEffectiveRain,
            double pTotalRealRain, double pTotalIrrigation, double pTotalExtraIrrigation, double pHidricBalance, double pSoilHidricVolume,
            DateTime pLastWaterInput, double pTotalEvapotranspirationCropFromLastWaterInput)
        {
            this.IdCropIrrigationWeatherRecords = pId;
            this.DayAfterSowing = pDayAfterSowing;
            this.CropIrrigationWeather = pCropIrrigationWeather;
            this.EffectiveRain = pEffectiveRain;
            this.DailyRecords = pDailyRecords;
            this.GrowingDegreeDays = pGrowingDegreeDays;
            this.ModifiedGrowingDegreeDays = pModifiedGrowingDegreeDays;
            this.TotalEvapotranspirationCrop = pTotalEvapotranspirationCrop;
            this.TotalEffectiveRain = pTotalEffectiveRain;
            this.TotalRealRain = pTotalRealRain;
            this.TotalIrrigation = pTotalIrrigation;
            this.TotalExtraIrrigation = pTotalExtraIrrigation;
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
        private void reviewSummaryData(DailyRecord pDailyRec)
        {
            double lRootDepth;
            double lFieldCapacity;
            int lDayAfterSowing;
            bool lThereIsWaterInput;

            double lRealRain;
            double lEffectiveRain;
            double lDaysAfterBigInputWater;

            lDayAfterSowing = this.DayAfterSowing.First+1;
            this.DayAfterSowing = new Pair<int, DateTime>(lDayAfterSowing, pDailyRec.DateHour);
            this.GrowingDegreeDays += pDailyRec.GrowingDegree;
            this.ModifiedGrowingDegreeDays += pDailyRec.ModifiedGrowingDegree;
            
            
            lRootDepth = this.CropIrrigationWeather.Crop.PhenologicalStage.RootDepth;
            lFieldCapacity = this.CropIrrigationWeather.Crop.Soil.getFieldCapacity(lRootDepth);
            
            //To debug
            //if (pDailyRec.DateHour.Equals(new DateTime(2014, 12, 02)))
            //    return;



            // Evapotraspiration adjustment
            if (pDailyRec.EvapotranspirationCrop !=null)
            {
                  TotalEvapotranspirationCrop += pDailyRec.EvapotranspirationCrop.getTotalInput();
                  this.HydricBalance -= pDailyRec.EvapotranspirationCrop.getTotalInput();
            }

            //Will show if there is Water Input (Rain or Irrigation)
            lThereIsWaterInput = false;

            // Rain adjustment
            if (pDailyRec.Rain != null)
            {
                lRealRain = pDailyRec.Rain.getTotalInput();
                //Calculate Rain Effective Value
                lEffectiveRain = this.getEffectiveRainValue(pDailyRec.Rain);
                this.TotalEffectiveRain += lEffectiveRain;
                this.TotalRealRain += lRealRain;
                this.HydricBalance += lEffectiveRain;

                // If the effective rain is bigger than 10 mm set the last water input
                if (pDailyRec.Rain.Input > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    this.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.getTotalInput();
                    this.LastWaterInputDate = pDailyRec.DateHour;
                    lThereIsWaterInput = true;
                }

                if (HydricBalance >= lFieldCapacity)
                {
                    //We have to save the date to keep the hidric balance unchangable
                    this.LastBigWaterInputDate = pDailyRec.DateHour;
                }
            }
  
            // Irrigation adjustment
            if (pDailyRec.Irrigation != null)
            {
                this.TotalIrrigation += pDailyRec.Irrigation.Input;
                this.TotalExtraIrrigation += pDailyRec.Irrigation.ExtraInput;
                this.HydricBalance += pDailyRec.Irrigation.getTotalInput();

                // If the irrigation is bigger than 10 mm set the last water input
                if (pDailyRec.Irrigation.getTotalInput() > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    this.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.getTotalInput();
                    this.LastWaterInputDate = pDailyRec.DateHour;
                    lThereIsWaterInput = true;
                }
            }
           
            // If the HidricBalance is bigger than the FieldCapacity set the HidricBalance as de FieldCapacity
            if (HydricBalance >= lFieldCapacity)
            {
                this.HydricBalance = lFieldCapacity; 
            }
            
            //TotalEvapotranspirationCropFromLastWaterInput adjustment
            if(!lThereIsWaterInput)
            {
                this.TotalEvapotranspirationCropFromLastWaterInput += pDailyRec.EvapotranspirationCrop.getTotalInput();
            }

            //Update the Phenological Stage depending in Growing Degree
            reviewPhenologicalStage();

            //After a big rain the HidricBalance keep its value = FieldCapacity for two days
            lDaysAfterBigInputWater = Utilities.Utils.getDaysDifference(this.LastBigWaterInputDate, pDailyRec.DateHour);
            if (lDaysAfterBigInputWater <= InitialTables.DAYS_HIDRIC_BALANCE_UNCHANGABLE_AFTER_BIG_WATER_INPUT)
            {
                lRootDepth = this.CropIrrigationWeather.Crop.PhenologicalStage.RootDepth;
                lFieldCapacity = this.CropIrrigationWeather.Crop.Soil.getFieldCapacity(lRootDepth);
                this.HydricBalance = lFieldCapacity;
            }

        }
  

        /// <summary>
        /// Get Days after Sowing for Modified Growing Degree
        /// </summary>
        /// <returns></returns>
        private int getDaysAfterSowingForModifiedGrowingDegree()
        {
            int lReturn = 0;
            double lastGDRegistry = 0;
            DateTime lDate = DateTime.MinValue;
            //TODO Order DailyRecords list by Date
            //this.DailyRecords.OrderBy();
            foreach (DailyRecord lDailyRec in this.DailyRecords)
            {
                if (this.ModifiedGrowingDegreeDays <= lDailyRec.GrowingDegreeAcumulated && this.ModifiedGrowingDegreeDays > lastGDRegistry)
                {
                    lDate = lDailyRec.DateHour;
                    lReturn = Utilities.Utils.getDaysDifference(this.CropIrrigationWeather.Crop.SowingDate, lDate);
                    return lReturn;
                }
                lastGDRegistry = lDailyRec.GrowingDegreeAcumulated;
            }
            return lReturn;
        }

        /// <summary>
        /// Add a Daily Record 
        /// </summary>
        /// <param name="pDailyRecord"></param>
        /// <returns></returns>
        private bool addDailyRecord(DailyRecord pDailyRecord)
        {
            bool lReturn = true;
            try
            {
                int days = Utilities.Utils.getDaysDifference(this.CropIrrigationWeather.Crop.SowingDate, pDailyRecord.DateHour);
                //If it's the initial registry set the initial Hidric Balance
                if (days == 0)
                {
                    this.HydricBalance = this.getInitialHidricBalance();
                    this.DayAfterSowing = new Pair<int, DateTime>(-1, this.CropIrrigationWeather.Crop.SowingDate);
                }
                // this way part form the last state (day before)
                reviewSummaryData(pDailyRecord);
                
                this.DailyRecords.Add(pDailyRecord);
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
        /// Change the PhenologicalStage of the crop depending of the growing degree acumulated plus the adjustment
        /// </summary>
        private void reviewPhenologicalStage()
        {
            PhenologicalStage lOldPhenStage =null;
            PhenologicalStage lNewPhenStage = null;
            List<PhenologicalStage> lPhenologicalStageList;
            IEnumerable<PhenologicalStage> lPhenologicalTableOrderByMinDegree;
            double lModifiedGrowingDegreeDays;
            double lRootDepthDifference;
            double lPercentageOfAvailableWater;

            lOldPhenStage = this.CropIrrigationWeather.Crop.PhenologicalStage;
            //Order the phenological table
            lPhenologicalStageList = this.CropIrrigationWeather.Crop.PhenologicalStageList;
            lPhenologicalTableOrderByMinDegree = lPhenologicalStageList.OrderBy(lPhenologicalStage => lPhenologicalStage.MinDegree);
            //get the modified degrees days
            lModifiedGrowingDegreeDays = this.ModifiedGrowingDegreeDays;
            //Get the percentage of availableWater before to actualize the phenology state 
            lPercentageOfAvailableWater = this.getPercentageOfAvailableWater();
                
            foreach (PhenologicalStage lPhenStage in lPhenologicalTableOrderByMinDegree)
            {
                if (lPhenStage != null && lPhenStage.Specie.Equals(this.CropIrrigationWeather.Crop.Specie) 
                    && lPhenStage.MinDegree <= lModifiedGrowingDegreeDays && lPhenStage.MaxDegree >= lModifiedGrowingDegreeDays)
                {
                    lNewPhenStage = lPhenStage;
                    this.CropIrrigationWeather.Crop.PhenologicalStage = lPhenStage;
                    break;
                }
            }

            //Si aumenta la profundidad de raiz agrego al balance hidrico el agua de la nueva 
            //parte del suelo que se considera (a Capacidad de campo)
            if (lOldPhenStage!= null && lNewPhenStage != null && lOldPhenStage.RootDepth < lNewPhenStage.RootDepth)
            {
                //TODO get field capacity by horizon of soil (parameters: horizon depth, root depth difference)
                lRootDepthDifference = lNewPhenStage.RootDepth - lOldPhenStage.RootDepth;
                this.HydricBalance += this.CropIrrigationWeather.Crop.Soil.getFieldCapacity(lRootDepthDifference);
            }

            //Si disminuye la profundidad de raiz agrego al balance hidrico el agua de la nueva 
            //parte del suelo que se considera (a Capacidad de campo)
            if (lOldPhenStage != null && lNewPhenStage != null && lOldPhenStage.RootDepth > lNewPhenStage.RootDepth)
            {
                this.HydricBalance = (this.getSoilAvailableWaterCapacity() * lPercentageOfAvailableWater / 100 ) 
                                    + this.getSoilPermanentWiltingPoint();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pRain"></param>
        /// <returns></returns>
        private double  getEffectiveRainValue(WaterInput pRain)
        {
            double pReturn = 0;
            if (pRain != null)
            {
                IEnumerable<EffectiveRain> query = this.EffectiveRain.OrderBy(lEffectiveRain => lEffectiveRain.Month);
                foreach (EffectiveRain lEffectiveRain in query)
                {
                    if (pRain.Date.Month == lEffectiveRain.Month && lEffectiveRain.MinRain <= pRain.getTotalInput() && lEffectiveRain.MaxRain >= pRain.getTotalInput())
                    {
                        //Use the "Input" atribute for the effective Rain and the "ExtraInput" atribute for the rain that is not used by the crop
                        double totalInput = pRain.getTotalInput();
                        pReturn = pRain.getTotalInput() * lEffectiveRain.Percentage / 100;
                        return pReturn;
                    }
                }
            }
            return pReturn;;
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
                "\tTotRiegoExtra: " +
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
            this.Titles.Add("TotRiegoCalc");
            this.Titles.Add("TotRiegoExtra");



            return lRetrun;
        }

        


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string printState()
        {
            List<String> lMessage;

            string ret = "";
            string etcAc = this.TotalEvapotranspirationCrop + "        ";
            string etcflwi = this.TotalEvapotranspirationCropFromLastWaterInput + "        ";
            string growDegre = this.GrowingDegreeDays + "        ";
            string modGrowDegre = this.ModifiedGrowingDegreeDays + "        ";
            string effRain = this.TotalEffectiveRain + "        ";
            string totRain = this.TotalRealRain + "        ";
            string bHid = this.HydricBalance.ToString() + "        ";
            string PercentAD = this.getPercentageOfAvailableWater() + "        ";
            string AD = this.getSoilAvailableWaterCapacity() + "        ";
            string CC = this.getSoilFieldCapacity() + "        ";
            string PMP = this.getSoilPermanentWiltingPoint() + "        ";
            string totIrr = this.TotalIrrigation.ToString() + "        ";
            string totExtraIrr = this.TotalExtraIrrigation.ToString() + "        ";


            ret = this.DayAfterSowing.First.ToString() +
                " \t " + this.DayAfterSowing.Second.ToShortDateString() +
                " \t " + etcAc.Substring(0, 7) +
                " \t " + etcflwi.Substring(0, 7) +
                " \t " + growDegre.Substring(0, 7) +
                " \t " + modGrowDegre.Substring(0, 7) +
                " \t " + bHid.Substring(0, 7) +
                " \t " + PercentAD.Substring(0, 7) +
                " \t " + AD.Substring(0, 7) +
                " \t " + CC.Substring(0, 7) +
                " \t " + PMP.Substring(0, 7) +
                " \t " + effRain.Substring(0, 7) +
                " \t " + totRain.Substring(0, 7) +
                " \t " + this.LastWaterInputDate.ToShortDateString() +
                " \t\t " + this.getRootDepth() +
                " \tf " + this.CropIrrigationWeather.Crop.PhenologicalStage.Stage.Name +
                " \t " + totIrr.Substring(0, 7) +
                " \t " + totExtraIrr.Substring(0, 7) +
                Environment.NewLine;

            if (this.Messages == null)
                this.Messages = new List<List<string>>();
            lMessage = new List<string>();
            lMessage.Add(this.DayAfterSowing.First.ToString());
            lMessage.Add(this.DayAfterSowing.Second.ToShortDateString());
            lMessage.Add(etcAc.Substring(0, 7));
            lMessage.Add(etcflwi.Substring(0, 7));
            lMessage.Add(growDegre.Substring(0, 7));
            lMessage.Add(modGrowDegre.Substring(0, 7));
            lMessage.Add(bHid.Substring(0, 7));
            lMessage.Add(PercentAD.Substring(0, 7));
            lMessage.Add(AD.Substring(0, 7));
            lMessage.Add(CC.Substring(0, 7));
            lMessage.Add(PMP.Substring(0, 7));
            lMessage.Add(effRain.Substring(0, 7));
            lMessage.Add(totRain.Substring(0, 7));
            lMessage.Add(this.lastWaterInputDate.ToShortDateString());
            lMessage.Add(this.getRootDepth().ToString());
            lMessage.Add(this.CropIrrigationWeather.Crop.PhenologicalStage.Stage.Name);
            lMessage.Add(totIrr.Substring(0,7));
            lMessage.Add(totExtraIrr.Substring(0, 7));

            this.Messages.Add(lMessage);

            return ret;
        }


        private void takeOffDailyRecord(DailyRecord lRecordToDelete)
        {
            ///TODO Ajustar los datos de resumen: agregar etc y sacar rain y riego a los totales (proceso inverso a agregar uno)
            int lDayAfterSowing;
            DateTime lDateOfDayAfterSowing;
            
            lDayAfterSowing = this.DayAfterSowing.First -1;
            lDateOfDayAfterSowing = this.DayAfterSowing.Second.AddDays(-1);
            this.DayAfterSowing = new Pair<int, DateTime>(lDayAfterSowing,lDateOfDayAfterSowing);
            // Evapotraspiration revert
            if (lRecordToDelete.EvapotranspirationCrop != null)
            {
                TotalEvapotranspirationCrop -= lRecordToDelete.EvapotranspirationCrop.getTotalInput();
                this.HydricBalance += lRecordToDelete.EvapotranspirationCrop.getTotalInput();
            }

            // Rain revert
            if (lRecordToDelete.Rain != null)
            {
                double lEffectiveRain = lRecordToDelete.Rain.getTotalInput();
                double lRealRain = lRecordToDelete.Rain.getTotalInput();
                this.TotalEffectiveRain -= lEffectiveRain;
                this.TotalRealRain -= lRealRain;
                this.HydricBalance -= lEffectiveRain;
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
                this.TotalIrrigation -= lRecordToDelete.Irrigation.Input;
                this.TotalExtraIrrigation -= lRecordToDelete.Irrigation.ExtraInput;
                this.HydricBalance -= lRecordToDelete.Irrigation.getTotalInput();
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
            this.GrowingDegreeDays -= lRecordToDelete.GrowingDegree;
            this.ModifiedGrowingDegreeDays -= lRecordToDelete.ModifiedGrowingDegree;
            ////////////////////////////

        }
        
        #endregion

        #region Public Methods
        //     - getPhenologicalStage(DayGrades: double): Stage
        //     - setGrowingDegreeDays(): bool
        //     - setPhenologicalState(Stage): bool
        //     - setNewPhenologicalStage(Stage): GrowingDegreeDays: double
        //     - getPhenologicalStage(GrowingDegreeDays: double): Stage
        //     - getAvailableWater(RootDepth:double, FieldCapacity:double, PermanentWiltingPoint:double): double
        //     - getHydricBalance(): double
        //     - getSoilHydricVolume(): double


        /// <summary>
        /// Get Initial Hidric Balance
        /// </summary>
        /// <returns></returns>
        public double getInitialHidricBalance()
        {
            double lReturn = 0;
            double lFieldCapacity = this.CropIrrigationWeather.Crop.getFieldCapacity(InitialTables.INITIAL_ROOT_DEPTH);
            lReturn = lFieldCapacity;
            return lReturn;
        }

        /// <summary>
        /// Get Root Depth from Crop Phenological Stage
        /// </summary>
        /// <returns></returns>
        public double getRootDepth()
        {
            double lRootDepth = this.CropIrrigationWeather.Crop.PhenologicalStage.RootDepth;
            return lRootDepth;
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
        public void addDailyRecord(WeatherStation.WeatherData pWeatherData, WeatherStation.WeatherData pMainWeatherData, WeatherStation.WeatherData pAlternativeWeatherData, Water.WaterInput pRain, Water.WaterInput pIrrigation, string pObservations)
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
                lBaseTemperature = this.CropIrrigationWeather.Crop.getBaseTemperature();
                //Growing Degree is average temperature menous Base Temperature
                lGrowingDegree = lAverageTemp - lBaseTemperature;
                lGrowingDegreeAcumulated = this.GrowingDegreeDays + lGrowingDegree;

                //Get days after sowing for Modified Growing Degree
                lDays = this.getDaysAfterSowingForModifiedGrowingDegree();
                
                if (lDays == 0)
                {
                    Utils.getDaysDifference(this.CropIrrigationWeather.Crop.SowingDate, pWeatherData.Date);
                }

                lKC_CropCoefficient = this.CropIrrigationWeather.Crop.CropCoefficient.getKC(lDays);
                lRealEvapotraspiration = lEvapotranspiration * lKC_CropCoefficient;
                lEvapotranspirationCrop = new EvapotranspirationCrop(
                    this.CropIrrigationWeather, pWeatherData.Date, lRealEvapotraspiration);

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
                foreach (DailyRecord lDailyRecord in this.dailyRecords)
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
                    this.dailyRecords.RemoveAt(indexToRemove);
                }

                this.addDailyRecord(lNewDailyRecord);
                this.OutPut += this.printState();
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
            foreach (DailyRecord lDailyRec in this.DailyRecords)
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
        public double  getPercentageOfAvailableWater()
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
            double lRootDepth;
            double lSoilPermanentWiltingPoint;

            lRootDepth = this.getRootDepth();
            lSoilPermanentWiltingPoint = this.CropIrrigationWeather.Crop.Soil.getPermanentWiltingPoint(lRootDepth);
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

            lRootDepth = this.getRootDepth();
            lSoilAvailableWaterCapacity = this.CropIrrigationWeather.Crop.Soil.getAvailableWaterCapacity(lRootDepth);
            return lSoilAvailableWaterCapacity;
        }

        /// <summary>
        /// Get Soil Field Capacity
        /// From Crop Soil by Root Depth
        /// </summary>
        /// <returns></returns>
        public double getSoilFieldCapacity()
        {
            double lRootDepth = this.getRootDepth();
            return this.CropIrrigationWeather.Crop.Soil.getFieldCapacity(lRootDepth);
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
            foreach (DailyRecord lDailyRec in this.DailyRecords)
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

        public void addToPrintDailyRecords()
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
            foreach (DailyRecord lDR in DailyRecords)
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