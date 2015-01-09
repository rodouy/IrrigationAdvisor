using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Crop;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Utilities;


namespace IrrigationAdvisor.Models.Management
{
    /// <summary>
    /// Create: 2014-10-27
    /// Author:  monicarle
    /// Description: 
    ///     Is the fusion of: a WheatherStation, a Crop and an IrrigationUnit
    ///     
    /// References:
    ///     WheatherStation
    ///     Crop
    ///     IrrigationUnit
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
    ///     - cropIrrigationWeatherRecordsList  List<CropIrrigationWeatherRecords> 
    /// 
    /// Methods:
    ///     - CropIrrigationWeather()      -- constructor
    ///     - CropIrrigationWeather(irrigationUnit, crop, mainWeatherStation, alternativeWeatherStation)  -- consturctor with parameters
    ///     - getRegion(): Region
    ///     - getDaysAfterSowing(): int- getBaseTemperature(): double
    ///     - getMaxEvapotranspirationToIrrigate(): double
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
        private Crop.Crop crop;
        private WeatherStation.WeatherStation mainWeatherStation;
        private WeatherStation.WeatherStation alternativeWeatherStation;
        private double predeterminatedIrrigationQuantity;
        private CropIrrigationWeatherRecords cropIrrigationWeatherRecords;

        public CropIrrigationWeatherRecords CropIrrigationWeatherRecords
        {
            get { return cropIrrigationWeatherRecords; }
            set { cropIrrigationWeatherRecords = value; }
        }

        private PhenologicalStage phenologicalStage;
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

        public Crop.Crop Crop
        {
            get { return crop; }
            set { crop = value; }
        }
        
        public WeatherStation.WeatherStation MainWeatherStation
        {
            get { return mainWeatherStation; }
            set { mainWeatherStation = value; }
        }
        
        public WeatherStation.WeatherStation AlternativeWeatherStation
        {
            get { return alternativeWeatherStation; }
            set { alternativeWeatherStation = value; }
        }

        public double PredeterminatedIrrigationQuantity
        {
            get { return predeterminatedIrrigationQuantity; }
            set { predeterminatedIrrigationQuantity = value; }
        }


        #endregion

        #region Construction

        public CropIrrigationWeather() 
        {
            this.IrrigationUnit = new Irrigation.IrrigationUnit();
            this.Crop = new Crop.Crop();
            this.MainWeatherStation = new WeatherStation.WeatherStation();
            this.AlternativeWeatherStation = new WeatherStation.WeatherStation();
            this.PredeterminatedIrrigationQuantity = 20;
            this.CropIrrigationWeatherRecords = new List<CropIrrigationWeatherRecords>();
        }

        public CropIrrigationWeather(Irrigation.IrrigationUnit pIrrigationUnit,
            Crop.Crop pCrop, WeatherStation.WeatherStation pMainWS,
            WeatherStation.WeatherStation pAlternativeWS,
            double pPredeterminatedIrrigationQuantity, List<CropIrrigationWeatherRecords> pCropIrrigationWeatherList)
        {
            this.IrrigationUnit = pIrrigationUnit;
            this.Crop = pCrop;
            this.MainWeatherStation = pMainWS;
            this.AlternativeWeatherStation = pAlternativeWS;
            this.PredeterminatedIrrigationQuantity = pPredeterminatedIrrigationQuantity;
            this.CropIrrigationWeatherRecords = pCropIrrigationWeatherList;
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        public Location.Region getRegion() 
        {
            return this.irrigationUnit.Location.Region;
        }

        public int getDaysAfterSowing()
        {
            return this.Crop.getDaysAfterSowing();
        }

        public double getBaseTemperature() 
        {
            return this.Crop.getBaseTemperature();
        }

        public double getMaxEvapotranspirationToIrrigate()
        {
            return this.Crop.MaxEvapotranspirationToIrrigate;
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
            lSoilPermanentWiltingPoint = this.Crop.Soil.getPermanentWiltingPoint(lRootDepth);
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
            lSoilAvailableWaterCapacity = this.Crop.Soil.getAvailableWaterCapacity(lRootDepth);
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
            return this.Crop.Soil.getFieldCapacity(lRootDepth);
        }

        /// <summary>
        /// Get Root Depth from Crop Phenological Stage
        /// </summary>
        /// <returns></returns>
        public double getRootDepth()
        {
            double lRootDepth;
            lRootDepth = this.Crop.getRootDepth();
            return lRootDepth;
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

            lHidricBalance = this.CropIrrigationWeatherRecords.HydricBalance;
            lFieldCapacity = this.getSoilFieldCapacity();
            lPermanentWiltingPoint = this.getSoilPermanentWiltingPoint();

            lPercentageOfAvailableWater = Math.Round(((lHidricBalance - lPermanentWiltingPoint) * 100)
                                        / (lFieldCapacity - lPermanentWiltingPoint), 2);
            return lPercentageOfAvailableWater;
        }

        private void reviewPhenologicalStage()
        {
            PhenologicalStage lOldPhenStage = null;
            double lOldRootDepth = 0;
            PhenologicalStage lNewPhenStage = null;
            double lNewRootDepth = 0;
            double lModifiedGrowingDegreeDays;
            double lRootDepthDifference;
            double lPercentageOfAvailableWater;

            lOldPhenStage = this.Crop.PhenologicalStage;
            lOldRootDepth = this.Crop.getRootDepth();

            //get the modified degrees days
            lModifiedGrowingDegreeDays = this.CropIrrigationWeatherRecords.ModifiedGrowingDegreeDays;
            //Get the percentage of availableWater before to actualize the phenology state 
            lPercentageOfAvailableWater = this.getPercentageOfAvailableWater();

            //Actualize Phenological Stage depending on the ModifiedGrowingDegreeDays
            this.Crop.actualizePhenologicalStage(lModifiedGrowingDegreeDays);
            lNewRootDepth = this.getRootDepth();
            lNewPhenStage = this.Crop.PhenologicalStage;

            //Si aumenta la profundidad de raiz agrego al balance hidrico el agua de la nueva 
            //parte del suelo que se considera (a Capacidad de campo)
            if (lOldPhenStage != null && lNewPhenStage != null && lOldRootDepth < lNewRootDepth)
            {
                //TODO get field capacity by horizon of soil (parameters: horizon depth, root depth difference)
                lRootDepthDifference = lNewRootDepth - lOldRootDepth;
                this.CropIrrigationWeatherRecords.HydricBalance += this.Crop.getFieldCapacity(lRootDepthDifference);
            }

            //Si disminuye la profundidad de raiz agrego al balance hidrico el agua de la nueva 
            //parte del suelo que se considera (a Capacidad de campo)
            if (lOldPhenStage != null && lNewPhenStage != null && lOldRootDepth > lNewRootDepth)
            {
                this.CropIrrigationWeatherRecords.HydricBalance = (this.getSoilAvailableWaterCapacity() * lPercentageOfAvailableWater / 100)
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
            double lRootDepth;
            double lFieldCapacity;
            int lDayAfterSowing;
            bool lThereIsWaterInput;

            double lRealRain;
            double lEffectiveRain;
            double lEffectiveIrrigation;
            double lIrrigationEfficiency;
            double lDaysAfterBigInputWater;

            lDayAfterSowing = this.CropIrrigationWeatherRecords.DayAfterSowing.First + 1;
            this.CropIrrigationWeatherRecords.DayAfterSowing = new Pair<int, DateTime>(lDayAfterSowing, pDailyRec.DateHour);
            this.CropIrrigationWeatherRecords.GrowingDegreeDays += pDailyRec.GrowingDegree;
            this.CropIrrigationWeatherRecords.ModifiedGrowingDegreeDays += pDailyRec.ModifiedGrowingDegree;


            lRootDepth = this.getRootDepth();
            lFieldCapacity = this.Crop.Soil.getFieldCapacity(lRootDepth);

            //To debug
            //if (pDailyRec.DateHour.Equals(new DateTime(2014, 12, 02)))
            //    return;



            // Evapotraspiration adjustment
            if (pDailyRec.EvapotranspirationCrop != null)
            {
                this.CropIrrigationWeatherRecords.TotalEvapotranspirationCrop += pDailyRec.EvapotranspirationCrop.getTotalInput();
                this.CropIrrigationWeatherRecords.HydricBalance -= pDailyRec.EvapotranspirationCrop.getTotalInput();
            }

            //Will show if there is Water Input (Rain or Irrigation)
            lThereIsWaterInput = false;

            // Rain adjustment
            if (pDailyRec.Rain != null)
            {
                lRealRain = pDailyRec.Rain.getTotalInput();
                //Calculate Rain Effective Value
                lEffectiveRain = this.getEffectiveRainValue(pDailyRec.Rain);
                this.CropIrrigationWeatherRecords.TotalEffectiveRain += lEffectiveRain;
                this.CropIrrigationWeatherRecords.TotalRealRain += lRealRain;
                this.CropIrrigationWeatherRecords.HydricBalance += lEffectiveRain;

                // If the effective rain is bigger than 10 mm set the last water input
                if (lEffectiveRain > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    this.CropIrrigationWeatherRecords.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.getTotalInput();
                    this.CropIrrigationWeatherRecords.LastWaterInputDate = pDailyRec.DateHour;
                    lThereIsWaterInput = true;
                }

                if (this.CropIrrigationWeatherRecords.HydricBalance >= lFieldCapacity)
                {
                    //We have to save the date to keep the hidric balance unchangable
                    this.CropIrrigationWeatherRecords.LastBigWaterInputDate = pDailyRec.DateHour;
                }
            }

            // Irrigation adjustment
            if (pDailyRec.Irrigation != null)
            {
                // Calculate de effective irrigation depending on the irrigatioin efficiency of the Pivot
                lIrrigationEfficiency = this.IrrigationUnit.IrrigationEfficiency;
                this.CropIrrigationWeatherRecords.TotalIrrigation += pDailyRec.Irrigation.Input * lIrrigationEfficiency;
                this.CropIrrigationWeatherRecords.TotalExtraIrrigation += pDailyRec.Irrigation.ExtraInput * lIrrigationEfficiency;
                lEffectiveIrrigation = pDailyRec.Irrigation.getTotalInput() * lIrrigationEfficiency;
                this.CropIrrigationWeatherRecords.HydricBalance += lEffectiveIrrigation;

                // If the irrigation is bigger than 10 mm set the last water input
                if (lEffectiveIrrigation > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    this.CropIrrigationWeatherRecords.TotalEvapotranspirationCropFromLastWaterInput = pDailyRec.EvapotranspirationCrop.getTotalInput();
                    this.CropIrrigationWeatherRecords.LastWaterInputDate = pDailyRec.DateHour;
                    lThereIsWaterInput = true;
                }

            }

            // If the HidricBalance is bigger than the FieldCapacity set the HidricBalance as de FieldCapacity
            if (this.CropIrrigationWeatherRecords.HydricBalance >= lFieldCapacity)
            {
                this.CropIrrigationWeatherRecords.HydricBalance = lFieldCapacity;
            }

            //TotalEvapotranspirationCropFromLastWaterInput adjustment
            if (!lThereIsWaterInput)
            {
                this.CropIrrigationWeatherRecords.TotalEvapotranspirationCropFromLastWaterInput += pDailyRec.EvapotranspirationCrop.getTotalInput();
            }

            //Update the Phenological Stage depending in Growing Degree
            reviewPhenologicalStage();

            lRootDepth = this.CropIrrigationWeatherRecords.CropIrrigationWeather.Crop.getRootDepth();
            lFieldCapacity = this.Crop.Soil.getFieldCapacity(lRootDepth);

            //After a big rain the HidricBalance keep its value = FieldCapacity for two days
            lDaysAfterBigInputWater = Utilities.Utils.getDaysDifference(this.CropIrrigationWeatherRecords.LastBigWaterInputDate, pDailyRec.DateHour);
            if (lDaysAfterBigInputWater <= InitialTables.DAYS_HIDRIC_BALANCE_UNCHANGABLE_AFTER_BIG_WATER_INPUT)
            {
                this.CropIrrigationWeatherRecords.HydricBalance = lFieldCapacity;
            }

            //The first days after sowing, hydric balance is maintained at field capacity
            if (lDayAfterSowing <= InitialTables.DAYS_HIDRIC_BALANCE_UNCHANGABLE_AFTER_SOWING)
            {
                this.CropIrrigationWeatherRecords.HydricBalance = lFieldCapacity;
            }
        }


        private void takeOffDailyRecord(DailyRecord lRecordToDelete)
        {
            ///TODO Ajustar los datos de resumen: agregar etc y sacar rain y riego a los totales (proceso inverso a agregar uno)
            int lDayAfterSowing;
            DateTime lDateOfDayAfterSowing;

            lDayAfterSowing = this.CropIrrigationWeatherRecords.DayAfterSowing.First - 1;
            lDateOfDayAfterSowing = this.CropIrrigationWeatherRecords.DayAfterSowing.Second.AddDays(-1);
            this.CropIrrigationWeatherRecords.DayAfterSowing = new Pair<int, DateTime>(lDayAfterSowing, lDateOfDayAfterSowing);
            // Evapotraspiration revert
            if (lRecordToDelete.EvapotranspirationCrop != null)
            {
                this.CropIrrigationWeatherRecords.TotalEvapotranspirationCrop -= lRecordToDelete.EvapotranspirationCrop.getTotalInput();
                this.CropIrrigationWeatherRecords.HydricBalance += lRecordToDelete.EvapotranspirationCrop.getTotalInput();
            }

            // Rain revert
            if (lRecordToDelete.Rain != null)
            {
                double lEffectiveRain = lRecordToDelete.Rain.getTotalInput();
                double lRealRain = lRecordToDelete.Rain.getTotalInput();
                this.CropIrrigationWeatherRecords.TotalEffectiveRain -= lEffectiveRain;
                this.CropIrrigationWeatherRecords.TotalRealRain -= lRealRain;
                this.CropIrrigationWeatherRecords.HydricBalance -= lEffectiveRain;
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
                this.CropIrrigationWeatherRecords.TotalIrrigation -= lRecordToDelete.Irrigation.Input;
                this.CropIrrigationWeatherRecords.TotalExtraIrrigation -= lRecordToDelete.Irrigation.ExtraInput;
                this.CropIrrigationWeatherRecords.HydricBalance -= lRecordToDelete.Irrigation.getTotalInput();
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
            this.CropIrrigationWeatherRecords.GrowingDegreeDays -= lRecordToDelete.GrowingDegree;
            this.CropIrrigationWeatherRecords.ModifiedGrowingDegreeDays -= lRecordToDelete.ModifiedGrowingDegree;
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
                lDays = Utilities.Utils.getDaysDifference(this.Crop.SowingDate, pDailyRecord.DateHour);
                //If it's the initial registry set the initial Hidric Balance
                if (lDays == 0)
                {
                    this.CropIrrigationWeatherRecords.HydricBalance = this.getInitialHidricBalance();
                    this.CropIrrigationWeatherRecords.DayAfterSowing = new Pair<int, DateTime>(-1, this.Crop.SowingDate);
                }
                // this way part form the last state (day before)
                reviewSummaryData(pDailyRecord);

                this.CropIrrigationWeatherRecords.DailyRecords.Add(pDailyRecord);
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
        /// Get Initial Hidric Balance
        /// </summary>
        /// <returns></returns>
        public double getInitialHidricBalance()
        {
            double lReturn = 0;
            double lFieldCapacity = this.Crop.getFieldCapacity(InitialTables.INITIAL_ROOT_DEPTH);
            lReturn = lFieldCapacity;
            return lReturn;
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
        public double getHydricBalance()
        {
            double lReturn = 0;
            lReturn = this.CropIrrigationWeatherRecords.HydricBalance;
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