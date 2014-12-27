using IrrigationAdvisor.Models.Crop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Utilities;
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
        private double INITIAL_ROOT_DEPTH = 5;
        private double CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED = 10;

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

            this.outPut = printHeader(); ;

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
        private void reviewResumeData(DailyRecord pDailyRec)
        {
            double lRootDepth = this.CropIrrigationWeather.Crop.PhenologicalStage.RootDepth;
            double lFieldCapacity = this.CropIrrigationWeather.Crop.Soil.getFieldCapacity(lRootDepth);
            int lDayAfterSowing = this.DayAfterSowing.First+1;
            this.DayAfterSowing = new Pair<int, DateTime>(lDayAfterSowing,pDailyRec.DateHour);
            this.GrowingDegreeDays += pDailyRec.GrowingDegree;
            this.ModifiedGrowingDegreeDays += pDailyRec.ModifiedGrowingDegree;

            reviewPhenologicalStage();
            bool thereIsWaterInput = false;
            // Evapotraspiration adjustment
            if (pDailyRec.EvapotranspirationCrop !=null)
            {
                  TotalEvapotranspirationCrop += pDailyRec.EvapotranspirationCrop.getTotalInput();
                  this.HydricBalance -= pDailyRec.EvapotranspirationCrop.getTotalInput();
            }

            // Rain adjustment
            if (pDailyRec.Rain != null)
            {
                double lEffectiveRain = pDailyRec.Rain.Input;
                double lRealRain = pDailyRec.Rain.getTotalInput();
                this.TotalEffectiveRain += lEffectiveRain;
                this.TotalRealRain += lRealRain;
                this.HydricBalance += lEffectiveRain;
                // If the effective rain is bigger than 10 mm set the last water input
                if (pDailyRec.Rain.Input > CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    this.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.getTotalInput();
                    this.LastWaterInputDate = pDailyRec.DateHour;
                    thereIsWaterInput = true;
                }
            }
  
            // Irrigation adjustment
            if (pDailyRec.Irrigation != null)
            {
                //TODO verificar que el riego sea mayor a 10 mm para setear thereIsWaterInput = true
                this.TotalIrrigation += pDailyRec.Irrigation.Input;
                this.totalExtraIrrigation += pDailyRec.Irrigation.ExtraInput;
                this.HydricBalance += pDailyRec.Irrigation.getTotalInput();
                thereIsWaterInput = true;
            }
            // If the HidricBalance is bigger than the FieldCapacity set the HidricBalance as de FieldCapacity
            if (HydricBalance >= lFieldCapacity)
            {
                this.HydricBalance = lFieldCapacity; ///CAMBIO 2
                this.LastBigWaterInputDate = pDailyRec.DateHour;
            }

            //After a big rain the HidricBalance keep its value = FieldCapacity for two days
            if (Utilities.Utils.getDaysDifference(this.LastBigWaterInputDate, pDailyRec.DateHour) < 3 && this.HydricBalance < lFieldCapacity)
            {
                this.HydricBalance = lFieldCapacity;
            }

            if(!thereIsWaterInput)
            {
                this.TotalEvapotranspirationCropFromLastWaterInput += pDailyRec.EvapotranspirationCrop.getTotalInput();
            }
            
        }
  

        private int getDaysForModifiedGrowingDegree()
        {
            int lReturn = 0;
            double lastGDRegistry = 0;
            DateTime lDate = DateTime.MinValue;
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
        private bool addDailyRecord(DailyRecord lDailyRecord)
        {
            bool lReturn = true;
            try
            {
                int days = Utilities.Utils.getDaysDifference(this.CropIrrigationWeather.Crop.SowingDate, lDailyRecord.DateHour);
                //If it's the initial registry set the initial Hidric Balance
                if (days == 0)
                {
                    double lRootDepth = this.getRootDepth();
                    double lFieldCapacity = this.CropIrrigationWeather.Crop.getFieldCapacity(lRootDepth);
                    this.HydricBalance = this.getInitialHidricBalance();
                    this.DayAfterSowing = new Pair<int, DateTime>(-1, this.CropIrrigationWeather.Crop.SowingDate);
                    
                }
                this.DailyRecords.Add(lDailyRecord);
                reviewResumeData(lDailyRecord); // this way part form the last state (day before)

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
            PhenologicalStage lOldPhenStage = this.CropIrrigationWeather.Crop.PhenologicalStage;
            PhenologicalStage lNewPhenStage = null;

            List<PhenologicalStage> lPhenologicalStageList = this.CropIrrigationWeather.Crop.PhenologicalStageList;
            IEnumerable<PhenologicalStage> query = lPhenologicalStageList.OrderBy(lPhenologicalStage => lPhenologicalStage.MinDegree);
            double lDegree = this.ModifiedGrowingDegreeDays;
            foreach (PhenologicalStage lPhenStage in query)
            {
                if (lPhenStage != null && lPhenStage.Specie.Equals(this.CropIrrigationWeather.Crop.Specie) && lPhenStage.MinDegree <= lDegree && lPhenStage.MaxDegree >= lDegree)
                {
                    lNewPhenStage = lPhenStage;
                    this.CropIrrigationWeather.Crop.PhenologicalStage = lPhenStage;
                   
                }
            }
            ///Si cambio la profundidad de raiz agrego al balance hidrico el agua de la nueva parte del suelo que se considera (a Capacidad de campo)
            if (lOldPhenStage!= null && lNewPhenStage != null && lOldPhenStage.RootDepth < lNewPhenStage.RootDepth)
            {
                double lRootDepthDifference = lNewPhenStage.RootDepth - lOldPhenStage.RootDepth;
                this.HydricBalance += this.CropIrrigationWeather.Crop.Soil.getFieldCapacity(lRootDepthDifference);
            }

        }
        private WaterInput getEffectiveRainValue(WaterInput pRain)
        {
            if (pRain != null)
            {
                IEnumerable<EffectiveRain> query = this.EffectiveRain.OrderBy(lEffectiveRain => lEffectiveRain.Month);
                foreach (EffectiveRain lEffectiveRain in query)
                {
                    if (pRain.Date.Month == lEffectiveRain.Month && lEffectiveRain.MinRain <= pRain.getTotalInput() && lEffectiveRain.MaxRain >= pRain.getTotalInput())
                    {
                        //Use the "Input" atribute for the effective Rain and the "ExtraInput" atribute for the rain that is not used by the crop
                        double totalInput = pRain.getTotalInput();
                        pRain.Input = pRain.getTotalInput() * lEffectiveRain.Percentage / 100;
                        pRain.ExtraInput = totalInput - pRain.Input;
                    }
                }
            }
            return pRain;
        }
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
                "\tTotRiegoExtra: " +
                "\tTotRiegoCalc: " +
                Environment.NewLine;

            return lRetrun;
        }
        private string printState()
        {
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



            return ret;
        }
        private void takeOffDailyRecord(DailyRecord lRecordToDelete)
        {
            ///TODO Ajustar los datos de resumen: agregar etc y sacar rain y riego a los totales (proceso inverso a agregar uno)
            int lDayAfterSowing = this.DayAfterSowing.First -1;
            DateTime lDateOfDayAfterSowing = this.DayAfterSowing.Second.AddDays(-1);
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
                double lEffectiveRain = lRecordToDelete.Rain.Input;
                double lRealRain = lRecordToDelete.Rain.getTotalInput();
                this.TotalEffectiveRain -= lEffectiveRain;
                this.TotalRealRain -= lRealRain;
                this.HydricBalance -= lEffectiveRain;
                // If the effective rain is bigger than 10 mm set the last water input
                //if (lRecordToDelete.Rain.Input > 10)
                //{
                //    this.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.getTotalInput();
                //    this.LastWaterInput = pDailyRec.DateHour;
                //    thereIsWaterInput = true;
                //}
            }

            // Irrigation revert
            if (lRecordToDelete.Irrigation != null)
            {
                //TODO verificar que el riego sea mayor a 10 mm para setear thereIsWaterInput = true
                this.TotalIrrigation -= lRecordToDelete.Irrigation.getTotalInput();
                this.HydricBalance -= lRecordToDelete.Irrigation.getTotalInput();
                //thereIsWaterInput = true;
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

            if (!thereIsWaterInput)
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
            lReturn = lFieldCapacity;
            return lReturn;
        }
        public double getRootDepth()
        {
            return this.CropIrrigationWeather.Crop.PhenologicalStage.RootDepth;
        }
        public void addDailyRecord(WeatherStation.WeatherData pWeatherData, WeatherStation.WeatherData pMainWeatherData, WeatherStation.WeatherData pAlternativeWeatherData, Water.WaterInput pRain, Water.WaterInput pIrrigation, string pObservations)
        {
            double lAverageTemp = pWeatherData.getAverageTemperature();
            double lEvapotranspiration = pWeatherData.getEvapotranspiration();
            double lBaseTemperature = this.CropIrrigationWeather.Crop.getBaseTemperature();
            double lGrowingDegree = lAverageTemp - lBaseTemperature;
            double lGrowingDegreeAcumulated = this.GrowingDegreeDays + lGrowingDegree;
            //Calculate Rain Effective Value
            if (pRain != null)
            {
                pRain = this.getEffectiveRainValue(pRain);
            }
            
            int lDays = this.getDaysForModifiedGrowingDegree();
            if(lDays ==0)
            {
                Utilities.Utils.getDaysDifference(this.CropIrrigationWeather.Crop.SowingDate, pWeatherData.Date);
            }
            double lKC_CropCoefficient = this.CropIrrigationWeather.Crop.CropCoefficient.getKC(lDays);
            double lRealEvapotraspiration = lEvapotranspiration * lKC_CropCoefficient;
            Water.WaterOutput lEvapotranspirationCrop = new Water.EvapotranspirationCrop(this.CropIrrigationWeather, pWeatherData.Date, lRealEvapotraspiration);
            
            DailyRecord lNewDailyRecord = new DailyRecord(pMainWeatherData, pAlternativeWeatherData, pWeatherData.Date, lGrowingDegree, lGrowingDegreeAcumulated, lGrowingDegree, lKC_CropCoefficient,
               lEvapotranspirationCrop, pRain, pIrrigation, pObservations);
            
            int indexToRemove = -1;
            DailyRecord lRecordToDelete = null;
            int i = 0;
            foreach (DailyRecord lDailyRecord in this.dailyRecords)
            {
                if (Utilities.Utils.isTheSameDay(lDailyRecord.DateHour.Date, pWeatherData.Date))
                {
                    indexToRemove = i;
                    lRecordToDelete = lDailyRecord;
                }
                i++;
            }

            if (indexToRemove != -1)
            {
                takeOffDailyRecord(lRecordToDelete);
                this.dailyRecords.RemoveAt(indexToRemove);
                
            }
            this.addDailyRecord(lNewDailyRecord);
            this.OutPut += this.printState();
            
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
        public double  getPercentageOfAvailableWater()
        {
            double lHidricBalance = this.HydricBalance;
            double lFieldCapacity = this.getSoilFieldCapacity();
            return Math.Round((lHidricBalance * 100) / lFieldCapacity,2);
            
        }
        public double getSoilPermanentWiltingPoint()
        {
            double lRootDepth = this.getRootDepth();
            return this.CropIrrigationWeather.Crop.Soil.getPermanentWiltingPoint(lRootDepth);

        }
        public double getSoilAvailableWaterCapacity()
        {
            double lRootDepth = this.getRootDepth();
            return this.CropIrrigationWeather.Crop.Soil.getAvailableWaterCapacity(lRootDepth);

        }
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
        #endregion

        #region Overrides
        #endregion



       
    }
}