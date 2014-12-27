using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Crop;
using IrrigationAdvisor.Models.Location;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;
namespace IrrigationAdvisor.Models.IrrigationSystem
{
    /// <summary>
    /// Create: 2014-11-01
    /// Author: monicarle
    /// Description: 
    ///     Manage all the information of the system
    ///     
    /// References:
    ///     almost all
    ///     
    /// Dependencies:
    ///     
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - cropIrrigationWeatherList List<CropIrrigationWeather>
    /// 
    /// Methods:
    ///     - IrrigationSystem()      -- constructor
    ///     
    /// </summary>
    public class IrrigationSystem
    {
        #region Index
        //Crop
        //Irrigation
        //Language
        //Location
        //Management
        //Security 
        //Utitilities
        //Water
        //WeatherStation

        #endregion

        #region Consts
        #endregion

        #region Fields

        //Crop
        private List<Pair<Region, List<PhenologicalStage>>> phenologicalStageList;


        //Irrigation
        //Language
        //Location

        //Management
        //////private List<DailyRecord> dailyRecordsList;
        private List<CropIrrigationWeather> cropIrrigationWeatherList;
        private List<CropIrrigationWeatherRecords> cropIrrigationWeatherRecordsList;

        private IrrigationCalculus irrigationCalculus;



        //Security 
        //Utitilities

        //Water
        private List<Water.WaterInput> rainList;
        private List<Water.WaterInput> irrigationList;
        private List<Pair<Region, List<EffectiveRain>>> effectiveRainList;

        
        //WeatherStation
        private List<WeatherStation.WeatherData> weatherDataList;

        #endregion

        #region Properties

        //Crop


        public List<Pair<Region, List<PhenologicalStage>>> PhenologicalStageList
        {
            get { return phenologicalStageList; }
            set { phenologicalStageList = value; }
        }
        
        //Irrigation
        //Language
        //Location
        //Management
        public List<CropIrrigationWeather> CropIrrigationWeatherList
        {
            get { return cropIrrigationWeatherList; }
            set { cropIrrigationWeatherList = value; }
        }

        public List<CropIrrigationWeatherRecords> CropIrrigationWeatherRecordsList
        {
            get { return cropIrrigationWeatherRecordsList; }
            set { cropIrrigationWeatherRecordsList = value; }
        }


        public IrrigationCalculus IrrigationCalculus
        {
            get { return irrigationCalculus; }
            set { irrigationCalculus = value; }
        }
        //Security 
        //Utitilities

        //Water
        public List<Water.WaterInput> RainList
        {
            get { return rainList; }
            set { rainList = value; }
        }

        public List<Water.WaterInput> IrrigationList
        {
            get { return irrigationList; }
            set { irrigationList = value; }
        }

        public List<Pair<Region, List<EffectiveRain>>> EffectiveRainList
        {
            get { return effectiveRainList; }
            set { effectiveRainList = value; }
        }
        

        //WeatherStation
        public List<WeatherStation.WeatherData> WeatherDataList
        {
            get { return weatherDataList; }
            set { weatherDataList = value; }
        }

        
        #endregion

        #region Construction
        //TODO Singleton???
        public IrrigationSystem()
        {

            //Crop
            this.PhenologicalStageList = new List<Pair< Region, List<PhenologicalStage>>>();
            //Irrigation

            //Language

            //Location

            //Management
            this.CropIrrigationWeatherList = new List<CropIrrigationWeather>();
            this.CropIrrigationWeatherRecordsList = new List<CropIrrigationWeatherRecords>();
            this.IrrigationCalculus = new IrrigationCalculus();
            //Security 

            //Utitilities

            //Water
            this.IrrigationList = new List<Water.WaterInput>();
            this.RainList = new List<Water.WaterInput>();
            this.effectiveRainList = new List<Pair<Region, List<EffectiveRain>>>();
            //WeatherStation
            this.WeatherDataList = new List<WeatherStation.WeatherData>();

        }

        #endregion


        #region Private Helpers

        //Crop
        //Irrigation
        //Language
        //Location
        //Management

        
        
        /// <summary>
        /// Search the CropIrrigationWeatherRecords of the CropIrrigationWeather and delegate the creation of the daily record
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="lWeatherData"></param>
        /// <param name="lMainWeatherData"></param>
        /// <param name="lAlternativeWeatherData"></param>
        /// <param name="lRain"></param>
        /// <param name="lIrrigation"></param>
        /// <param name="pObservations"></param>
        private void addDailyRecordToCropIrrigationWeather(CropIrrigationWeather pCropIrrigationWeather, 
            WeatherStation.WeatherData lWeatherData, WeatherStation.WeatherData lMainWeatherData, 
            WeatherStation.WeatherData lAlternativeWeatherData, Water.WaterInput lRain, Water.WaterInput lIrrigation, string pObservations)
        {
            foreach (CropIrrigationWeatherRecords lCropIrrigationWeatherRecord in this.CropIrrigationWeatherRecordsList)
            {
                if (lCropIrrigationWeatherRecord.CropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    lCropIrrigationWeatherRecord.addDailyRecord(lWeatherData,  lMainWeatherData, lAlternativeWeatherData,  lRain, lIrrigation, pObservations);
                }
            }

        }
        //Security 
        //Utitilities
        //Water
         
        private Water.WaterInput getIrrigationFromList(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime)
        {
            Water.WaterInput lReturn = null;
            foreach (Water.WaterInput lWaterInput in this.irrigationList)
                if (Utilities.Utils.isTheSameDay(lWaterInput.Date, pDateTime) && lWaterInput.CropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    lReturn = lWaterInput;
                    return lReturn;
                }
            return lReturn;
        }

        private Water.WaterInput getRainFromList(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime)
        {
            Water.WaterInput lReturn = null;
            foreach(Water.WaterInput lWaterInput in this.rainList)
                if(Utilities.Utils.isTheSameDay(lWaterInput.Date,pDateTime) && lWaterInput.CropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    lReturn = lWaterInput;
                    return lReturn;
                }
            return lReturn;

        }
  
        //WeatherStation
        private WeatherStation.WeatherData getWeatherDataFromList(WeatherStation.WeatherStation pWeatherStation, DateTime pDateTime) 
        {
            WeatherStation.WeatherData lReturn = null;
            foreach(WeatherStation.WeatherData lWeatherData in this.WeatherDataList)
            {
                if (lWeatherData.WeatherStation.Equals(pWeatherStation) && lWeatherData.Date.Equals(pDateTime.Date))
                {
                    lReturn = lWeatherData;
                    return lReturn;
                }
            }
            return lReturn;

        }
        /// <summary>
        /// Return the WeatherData for the available weather station.
        /// First search in the main station. If there is no data, then search in the alternative wheather station.
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pDateTime"></param>
        /// <returns></returns>
        private WeatherStation.WeatherData getAvailableWeatherStationData(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime)
        {
            WeatherStation.WeatherData lReturn = null;
            WeatherStation.WeatherData lWeatherData = getWeatherDataFromList(pCropIrrigationWeather.MainWeatherStation, pDateTime);
            if (lWeatherData != null)
            {
                lReturn = lWeatherData;
            }
            else
            {
                lWeatherData = getWeatherDataFromList(pCropIrrigationWeather.AlternativeWeatherStation, pDateTime);
                if (lWeatherData != null)
                {
                    lReturn = lWeatherData;
                }

            }
            return lReturn;
        }


        private List<EffectiveRain> getEffectiveRainList(Region pRegion)
        {
            List <EffectiveRain> lReturnEffectiveRain = new List<EffectiveRain>();
            foreach(Pair<Region, List<EffectiveRain>> lPair in this.EffectiveRainList)
            {
                if (lPair.First.Equals(pRegion))
                {
                    lReturnEffectiveRain = lPair.Second;
                    return lReturnEffectiveRain;
                }
            }
            return lReturnEffectiveRain;
        }

        #endregion

        #region Public Methods

        //Crop
        //Irrigation
        //Language
        //Location
        //Management
        /// <summary>
        /// Add to the system a new CropIrrigationWeather
        /// Aditionaly create a CropIrrigationWeatherRecords for this CropIrrigationWeather
        /// and add the first DailyRecord
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <returns></returns>
        public bool addCropIrrigWeatherToList(CropIrrigationWeather pCropIrrigationWeather) 
        {
            bool lReturn = true;
            try
            {

                //Create the CropIrrigationWeatherRecords for the CropIrrigationWeather
                CropIrrigationWeatherRecords lCropIrrigationWeatherRecords = new CropIrrigationWeatherRecords();
                List<EffectiveRain> lEffectiveRain = this.getEffectiveRainList(pCropIrrigationWeather.getRegion());
                lCropIrrigationWeatherRecords.EffectiveRain = lEffectiveRain;
                lCropIrrigationWeatherRecords.CropIrrigationWeather = pCropIrrigationWeather;
                double bhi = lCropIrrigationWeatherRecords.getInitialHidricBalance();
                lCropIrrigationWeatherRecords.HydricBalance = bhi;
                
                //Add to the system list 
                this.CropIrrigationWeatherList.Add(pCropIrrigationWeather);
                this.CropIrrigationWeatherRecordsList.Add(lCropIrrigationWeatherRecords);
                
                //Create the initial registry
                DateTime lSowingDate = pCropIrrigationWeather.Crop.SowingDate;
                this.addDailyRecordToList(pCropIrrigationWeather, lSowingDate, "Initial registry");
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
        /// Colect the weather data, irrigation data and rain data and derive the cretion of a new daily record
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pDateTime"></param>
        /// <param name="pObservations"></param>
        /// <returns></returns>
        public bool addDailyRecordToList(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime, String pObservations)
        {
            bool lReturn = false;
            WeatherStation.WeatherData lWeatherData = null;
            WeatherStation.WeatherData lMainWeatherData = getWeatherDataFromList(pCropIrrigationWeather.MainWeatherStation, pDateTime); ;
            WeatherStation.WeatherData lAlternativeWeatherData = getWeatherDataFromList(pCropIrrigationWeather.AlternativeWeatherStation, pDateTime); ;
            Water.WaterInput lRain = null;
            Water.WaterInput lIrrigation = null;
            try
            {
                //Controlo que la CropIrrigationWeather y la fecha no sean null
                if (this.CropIrrigationWeatherList.Contains(pCropIrrigationWeather) && pDateTime != null)
                {
                    lWeatherData = this.getAvailableWeatherStationData(pCropIrrigationWeather, pDateTime);
                    // Si hay datos de estacion meteorologica puedo seguir
                    if (lWeatherData != null)
                    {
                        lIrrigation = this.getIrrigationFromList(pCropIrrigationWeather, pDateTime);
                        lRain = this.getRainFromList(pCropIrrigationWeather, pDateTime);
                        this.addDailyRecordToCropIrrigationWeather(pCropIrrigationWeather, lWeatherData, lMainWeatherData, lAlternativeWeatherData, lRain, lIrrigation, pObservations);///Si ya existe registro para ese dia se sobre-escribe

                    }
                    double irrigationCalculated = this.howMuchToIrrigate(pCropIrrigationWeather);
                    if (irrigationCalculated > 0)
                    {
                        this.addIrrigationDataToList(pCropIrrigationWeather, pDateTime, this.IrrigationCalculus.PRDETERMINATED_IRRIGATION1, false);
                        this.addDailyRecordToList(pCropIrrigationWeather, pDateTime, pDateTime.ToShortDateString());
                    }

                }
                /*
                 * 
                 * irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 19), "Dia 62");
            irrigationCalculated = irrirgSys.howMuchToIrrigate(this.cropIrrigWeatherPivot5);
            if (irrigationCalculated > 0)
            {
                irrirgSys.addIrrigationDataToList(cropIrrigWeatherPivot5, new DateTime(2014, 12, 19), 20);
                irrirgSys.addDailyRecordToList(this.cropIrrigWeatherPivot5, new DateTime(2014, 12, 19), "Dia 62");
            }
            textoRetorno += "Dia 62" + printState(recP5, irrigationCalculated);
            
                 * */
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in IrrigationSystem.addDailyRecordToList " + e.Message);
                //TODO manage and log the exception
                throw e;
            }
            return lReturn;

        }



        public double howMuchToIrrigate(CropIrrigationWeather pCropIrrigationWeather)
        {
            double lReturn = 0;
            CropIrrigationWeatherRecords lCropIrrigationWeatherRecords = null;
            foreach (CropIrrigationWeatherRecords oneCropIrrigationWeatherRecords in this.CropIrrigationWeatherRecordsList)
            {
                if (oneCropIrrigationWeatherRecords.CropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    lCropIrrigationWeatherRecords = oneCropIrrigationWeatherRecords;
                }

            }
            if (lCropIrrigationWeatherRecords != null)
            {
                lReturn = this.IrrigationCalculus.howMuchToIrrigate(lCropIrrigationWeatherRecords);
            }
            return lReturn;
        }
        /// <summary>
        /// Return the Phenological Stage for a Specie in a Region given the rootDepth
        /// </summary>
        /// <param name="pDegree"></param>
        /// <param name="pRegion"></param>
        /// <param name="pSpecie"></param>
        /// <returns></returns>
        public PhenologicalStage getPhenologicalStage(double pDegree, Region pRegion, Specie pSpecie)
        {
            PhenologicalStage lReturn = null;
            List<PhenologicalStage> lPhenologicalStageListByRegion = null;
            foreach (Pair<Region , List<PhenologicalStage >> lPair in this.PhenologicalStageList)
            {
                if (lPair != null && lPair.First.Equals(pRegion))
                {
                    lPhenologicalStageListByRegion = lPair.Second;
                }
            }

            IEnumerable<PhenologicalStage> query = lPhenologicalStageListByRegion.OrderBy(lPhenologicalStage => lPhenologicalStage.MinDegree);
            foreach(PhenologicalStage lPhenStage in query)
            {
                if (lPhenStage != null && lPhenStage.Specie.Equals(pSpecie) && lPhenStage.MinDegree <= pDegree && lPhenStage.MaxDegree >= pDegree)
                {
                    lReturn = lPhenStage;
                }
            }
            return lReturn;

        }
        /// <summary>
        /// Return the List of PhenologicalStages for a Specie in a Region
        /// </summary>
        /// <param name="pRegion"></param>
        /// <param name="pSpecie"></param>
        /// <returns></returns>
        public List<PhenologicalStage> getPhenologicalStage(Region pRegion, Specie pSpecie)
        {
            List<PhenologicalStage> lReturn = new List<PhenologicalStage>();
            List<PhenologicalStage> lPhenologicalStageListByRegion = null;
            foreach (Pair<Region, List<PhenologicalStage>> lPair in this.PhenologicalStageList)
            {
                if (lPair != null && lPair.First.Equals(pRegion))
                {
                    lPhenologicalStageListByRegion = lPair.Second;
                }
            }

            IEnumerable<PhenologicalStage> query = lPhenologicalStageListByRegion.OrderBy(lPhenologicalStage => lPhenologicalStage.MinDegree);
            foreach (PhenologicalStage lPhenStage in query)
            {
                if (lPhenStage != null && lPhenStage.Specie.Equals(pSpecie))
                {
                    lReturn.Add(lPhenStage);
                }
            }
            return lReturn;

        }





        //Security 
        //Utitilities

        public String printDailyRecordsList(CropIrrigationWeatherRecords pCropIrrigationWeatherRecords)
        {
            String lReturn = Environment.NewLine + "DAILY RECORDS" + Environment.NewLine ;
                lReturn += Environment.NewLine +Environment.NewLine;

                foreach (DailyRecord lDailyrecord in pCropIrrigationWeatherRecords.DailyRecords)
                {
                    lReturn += lDailyrecord.ToString() + Environment.NewLine;
                }
            
            return lReturn;
        }

        public String printDailyrecordsList(CropIrrigationWeather pCropIrrigationWeather)
        {
            String lReturn = "";
            foreach(CropIrrigationWeatherRecords lCropIrrigationWeatherRecords in this.CropIrrigationWeatherRecordsList)
            {
                if (lCropIrrigationWeatherRecords.CropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    lReturn = printDailyRecordsList(lCropIrrigationWeatherRecords);
                }
            }
            return lReturn;
        }


        public String printWeatherDataList()
        {
            String lReturn = Environment.NewLine + "WEATHER DATA" + Environment.NewLine;
            foreach (WeatherStation.WeatherData lWeatherData in this.WeatherDataList)
            {
                lReturn += lWeatherData.ToString() + Environment.NewLine;
            }
            return lReturn;
        }
        //Water
        //WeatherStation
        public bool addWeatherDataToList(WeatherStation.WeatherStation pWeatherStation, DateTime pDateTime,
            double pTemperature, int pSolarRadiation, double pTemMax,
            double pTemMin, double pEvapotranspiration)
        {
            bool lReturn = false;
            try
            {
                WeatherStation.WeatherData lData = new WeatherStation.WeatherData(pWeatherStation, pDateTime,
                    pTemperature, pTemMax, pTemMin, pSolarRadiation, pEvapotranspiration);
                this.WeatherDataList.Add(lData);
                lReturn = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in IrrigationSystem.addWeatherData " + e.Message);
                //TODO manage and log the exception
                throw e;
            }
            return lReturn;
 
        }

        public bool addIrrigationDataToList(CropIrrigationWeather pCropIrrigationWeather,
            DateTime pDate, double pInput, bool isExtra)
        {
            bool lReturn = false;
            try
            {
                Water.WaterInput lNewIrrigation = getIrrigationFromList(pCropIrrigationWeather, pDate);
                if (lNewIrrigation == null)
                {
                    lNewIrrigation = new Water.Irrigation();
                    lNewIrrigation.CropIrrigationWeather = pCropIrrigationWeather;
                    lNewIrrigation.Date = pDate;
                    if (isExtra)
                    {
                        lNewIrrigation.ExtraInput = pInput;
                        lNewIrrigation.ExtraDate = pDate;
                    }
                    else
                    {
                        lNewIrrigation.Input = pInput;
                    }
                    this.IrrigationList.Add(lNewIrrigation);
                }// If there is an Irrigation actualize the registry
                else
                {
                    if (isExtra)
                    {
                        lNewIrrigation.ExtraInput += pInput;
                        lNewIrrigation.ExtraDate = pDate;
                    }
                    else
                    {
                        lNewIrrigation.Input += pInput;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in IrrigationSystem.addIrrigationData " + e.Message);
                //TODO manage and log the exception
                throw e;
            }
            return lReturn;
        }

        public bool addRainDataToList(CropIrrigationWeather pCropIrrigationWeather,
            DateTime pDate, double pInput)
        {
            bool lReturn = false;
            try
            {
                Water.WaterInput lNewIrrigation = getIrrigationFromList(pCropIrrigationWeather, pDate);
                if (lNewIrrigation == null)
                {

                    Water.Rain lNewRain = new Water.Rain();
                    lNewRain.CropIrrigationWeather = pCropIrrigationWeather;
                    lNewRain.Date = pDate;
                    lNewRain.Input = pInput;
                    this.RainList.Add(lNewRain);
                }
                else // If there is a Raub actualize the registry
                {
                    lNewIrrigation.ExtraInput += pInput;
                    lNewIrrigation.ExtraDate = pDate;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in IrrigationSystem.addIrrigationData " + e.Message);
                //TODO manage and log the exception
                throw e;
            }
            return lReturn;
        }
        
        #endregion

        #region Overrides
        #endregion

        public void adjustmentPhenology(CropIrrigationWeather pCropIrrigationWeather, Stage pNewStage, DateTime pDateTime)
        {
            foreach (CropIrrigationWeatherRecords lCropIrrigationWeatherRecords in this.CropIrrigationWeatherRecordsList)
            {
                if (lCropIrrigationWeatherRecords.CropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    Stage lActualStage = lCropIrrigationWeatherRecords.CropIrrigationWeather.Crop.PhenologicalStage.Stage;
                    double lModification = calculateDegreeStageDifference(lActualStage, pNewStage, pCropIrrigationWeather.Crop.Specie.Region);
                    lCropIrrigationWeatherRecords.adjustmentPhenology(pNewStage, pDateTime, lModification);
        
                }
            }

        }

        private double calculateDegreeStageDifference(Stage oldStage, Stage newStage, Region pRegion)
        {
            double oldDegree = 0;
            double newDegree = 0;

            double lReturn = 0;
            foreach (Pair<Region, List<PhenologicalStage>> lPair in this.PhenologicalStageList)
            {
                if(lPair.First.Equals(pRegion))
                {
                    List<PhenologicalStage> lPhenologicalStageList = lPair.Second;
                    foreach(PhenologicalStage lPhenologicalStage in lPhenologicalStageList)
                    {
                        if (lPhenologicalStage.Stage.Equals(oldStage))
                        {
                            oldDegree = lPhenologicalStage.getAverageDegree();
                        }
                        if (lPhenologicalStage.Stage.Equals(newStage))
                        {
                            newDegree = lPhenologicalStage.getAverageDegree();
                        }
                    }
                }

            }
            if(newDegree!=0 && oldDegree!=0)
            {
                lReturn= newDegree-oldDegree;
            }
            return lReturn;
        }
    }
}