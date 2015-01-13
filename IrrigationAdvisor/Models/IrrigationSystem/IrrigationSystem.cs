using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Weather;
namespace IrrigationAdvisor.Models.IrrigationSystem
{
    /// <summary>
    /// Create: 2014-11-01
    /// Author: monicarle
    /// Description: 
    ///     Manage all the information of the system
    ///     s
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

        #region Crop
        #endregion

        #region Irrigation
        #endregion

        #region Language
        #endregion

        #region Location
        #endregion

        #region Management
        #endregion
       
        #region Security
        #endregion
        
        #region Utilities
        #endregion
        
        #region Water
        #endregion
       
        #region WeatherStation
        #endregion
        
        #endregion

        #region Fields

        #region Crop
        private List<Pair<Region, List<PhenologicalStage>>> phenologicalStageList;
        private List<Crop> corpList;
        private List<Specie> specieList;
        #endregion

        #region Irrigation
        #endregion

        #region Language
        #endregion

        #region Location
        private List<Region> regions;
        #endregion

        #region Management
        private List<CropIrrigationWeather> cropIrrigationWeatherList;
        private List<CropIrrigationWeatherRecord> cropIrrigationWeatherRecordList;
        private IrrigationCalculus irrigationCalculus;
        #endregion

        #region Security 
        #endregion

        #region Utitilities
        #endregion

        #region Water
        private List<Water.WaterInput> rainList;
        private List<Water.WaterInput> irrigationList;
        #endregion

        #region WeatherStation
        private List<WeatherData> weatherDataList;
        #endregion

        #endregion

        #region Properties

        #region Crop
        public List<Pair<Region, List<PhenologicalStage>>> PhenologicalStageList
        {
            get { return phenologicalStageList; }
            set { phenologicalStageList = value; }
        }
        #endregion

        #region Irrigation
        #endregion

        #region Language
        #endregion

        #region Location

        public List<Region> Regions
        {
            get { return regions; }
            set { regions = value; }
        }
        #endregion

        #region Management
        public List<CropIrrigationWeather> CropIrrigationWeatherList
        {
            get { return cropIrrigationWeatherList; }
            set { cropIrrigationWeatherList = value; }
        }

        public List<CropIrrigationWeatherRecord> CropIrrigationWeatherRecordList
        {
            get { return cropIrrigationWeatherRecordList; }
            set { cropIrrigationWeatherRecordList = value; }
        }


        public IrrigationCalculus IrrigationCalculus
        {
            get { return irrigationCalculus; }
            set { irrigationCalculus = value; }
        }
        #endregion

        #region Security
        #endregion

        #region Utitilities
        #endregion

        #region Water
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

        #endregion

        #region WeatherStation
        public List<WeatherData> WeatherDataList
        {
            get { return weatherDataList; }
            set { weatherDataList = value; }
        }
        #endregion
        
        #endregion

        #region Construction
        //TODO Singleton???
        public IrrigationSystem()
        {

            #region Crop
            this.PhenologicalStageList = new List<Pair< Region, List<PhenologicalStage>>>();
            #endregion

            #region Irrigation
            #endregion

            #region Language
            #endregion

            #region Location
            this.Regions = new List<Region>();
            #endregion
            
            #region Management
            this.CropIrrigationWeatherList = new List<CropIrrigationWeather>();
            this.cropIrrigationWeatherRecordList = new List<CropIrrigationWeatherRecord>();
            this.IrrigationCalculus = new IrrigationCalculus();
            #endregion
            
            #region Security 
            #endregion

            #region Utitilities
            #endregion

            #region Water
            this.IrrigationList = new List<Water.WaterInput>();
            this.RainList = new List<Water.WaterInput>();
            #endregion
            
            #region WeatherStation
            this.WeatherDataList = new List<WeatherData>();
            #endregion

        }

        #endregion

        #region Private Helpers

        #region Crop
        #endregion

        #region Irrigation
        #endregion

        #region Language
        #endregion
        
        #region Location
        #endregion

        #region Management
        #endregion


        /// <summary>
        /// Search the cropIrrigationWeatherRecord of the CropIrrigationWeather and delegate the creation of the daily record
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="lWeatherData"></param>
        /// <param name="lMainWeatherData"></param>
        /// <param name="lAlternativeWeatherData"></param>
        /// <param name="lRain"></param>
        /// <param name="lIrrigation"></param>
        /// <param name="pObservations"></param>
        private void addDailyRecordToCropIrrigationWeather(CropIrrigationWeather pCropIrrigationWeather, 
            WeatherData lWeatherData, WeatherData lMainWeatherData, 
            WeatherData lAlternativeWeatherData, Water.WaterInput lRain, 
            Water.WaterInput lIrrigation, string pObservations)
        {
            foreach (CropIrrigationWeatherRecord lCropIrrigationWeatherRecord in this.cropIrrigationWeatherRecordList)
            {
                if (lCropIrrigationWeatherRecord.CropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    pCropIrrigationWeather.addDailyRecord(lWeatherData, lMainWeatherData, lAlternativeWeatherData, lRain, lIrrigation, pObservations);
                }
            }

        }

        //Security 
        //Utitilities
        //Water
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pDateTime"></param>
        /// <returns></returns>
        private Water.WaterInput getIrrigationFromList(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime)
        {
            Water.WaterInput lReturn = null;
            IEnumerable<Water.WaterInput> lIrrigationListOrderByDescendingByDate;
            lIrrigationListOrderByDescendingByDate = this.irrigationList.OrderByDescending(lWaterInput => lWaterInput.Date);
            foreach (Water.WaterInput lWaterInput in lIrrigationListOrderByDescendingByDate)
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
        

        /// <summary>
        /// Return the WeatherData for the available weather station.
        /// First search in the main station. If there is no data, then search in the alternative wheather station.
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pDateTime"></param>
        /// <returns></returns>
        private WeatherData getAvailableWeatherStationData(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime)
        {
            WeatherData lReturn = null;
            WeatherData lWeatherData = getWeatherDataFromList(pCropIrrigationWeather.MainWeatherStation, pDateTime);
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
            foreach(Region lRegion in this.Regions)
            {
                if (lRegion.Equals(pRegion))
                {
                    lReturnEffectiveRain = lRegion.EffectiveRains;
                    return lReturnEffectiveRain;
                }
            }
            return lReturnEffectiveRain;
        }

        /// <summary>
        /// TODO description calculateDegreeStageDifference
        /// </summary>
        /// <param name="oldStage"></param>
        /// <param name="newStage"></param>
        /// <param name="pSpecie"></param>
        /// <returns></returns>
        private double calculateDegreeStageDifference(Stage oldStage, Stage newStage, Specie pSpecie)
        {
            double oldDegree = 0;
            double newDegree = 0;
            double lReturn = 0;
            List<PhenologicalStage> lPhenologicalStageList;

            lPhenologicalStageList = pSpecie.PhenologicalStages;
            foreach (PhenologicalStage lPhenologicalStage in lPhenologicalStageList)
            {
                if (lPhenologicalStage.Stage.Equals(oldStage) && lPhenologicalStage.Specie.Equals(pSpecie))
                {
                    oldDegree = lPhenologicalStage.getAverageDegree();
                }
                if (lPhenologicalStage.Stage.Equals(newStage) && lPhenologicalStage.Specie.Equals(pSpecie))
                {
                    newDegree = lPhenologicalStage.getAverageDegree();
                }
            }
            if (newDegree != 0 && oldDegree != 0)
            {
                lReturn = newDegree - oldDegree;
            }
            return lReturn;
        }

        #endregion

        #region Public Methods

        #region Crop
        
        public PhenologicalStage CreatePhenologicalStage(int pId, Specie pSpecie, Stage pStage, double pMinDegree, double pMaxDegree, double pRootDepth)
        {
            PhenologicalStage lPhenologicalStage;

            lPhenologicalStage = new PhenologicalStage(pId, pSpecie, pStage, pMinDegree, pMaxDegree, pRootDepth);
            return lPhenologicalStage;
        }

        #endregion

        #region Irrigation
        #endregion

        #region Language
        #endregion

        #region Location
        public bool addRegionToList(Region pRegion)
        {
            bool lReturn = false;
            try
            {
                this.Regions.Add(pRegion);

            }
            catch (Exception e)
            {
                throw e;
                //TODO Log the exception
            } return lReturn;
        }
        #endregion

        #region Management
        
        /// <summary>
        /// Add to the system a new CropIrrigationWeather
        /// Aditionaly create a cropIrrigationWeatherRecord for this CropIrrigationWeather
        /// and add the first DailyRecord
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <returns></returns>
        public bool addCropIrrigWeatherToList(CropIrrigationWeather pCropIrrigationWeather) 
        {
            bool lReturn = true;
            CropIrrigationWeatherRecord lCropIrrigationWeatherRecord;
            List<EffectiveRain> lEffectiveRain;
            double bhi;
            try
            {

                //Create the cropIrrigationWeatherRecord for the CropIrrigationWeather
                lCropIrrigationWeatherRecord = new CropIrrigationWeatherRecord();
                lEffectiveRain = this.getEffectiveRainList(pCropIrrigationWeather.IrrigationUnit.Location.Region);
                lCropIrrigationWeatherRecord.EffectiveRain = lEffectiveRain;
                lCropIrrigationWeatherRecord.CropIrrigationWeather = pCropIrrigationWeather;
                bhi = pCropIrrigationWeather.getInitialHidricBalance();
                lCropIrrigationWeatherRecord.HydricBalance = bhi;
                pCropIrrigationWeather.aCropIrrigationWeatherRecord = lCropIrrigationWeatherRecord;
                
                //Add to the system list 
                this.CropIrrigationWeatherList.Add(pCropIrrigationWeather);
                this.cropIrrigationWeatherRecordList.Add(lCropIrrigationWeatherRecord);
                
                //Create the initial registry
                DateTime lSowingDate = pCropIrrigationWeather.SowingDate;
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
        /// This method verify the need of irrigation, and then recreate the daily record
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pDateTime"></param>
        /// <param name="pObservations"></param>
        /// <returns></returns>
        public bool addDailyRecordToList(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime, String pObservations)
        {
            bool lReturn = false;
            WeatherData lWeatherData = null;
            WeatherData lMainWeatherData = null;
            WeatherData lAlternativeWeatherData = null;
            Water.WaterInput lRain = null;
            Water.WaterInput lIrrigation = null;

            try
            {
                //Controlo que la CropIrrigationWeather exista y la fecha no sean null
                if (this.CropIrrigationWeatherList.Contains(pCropIrrigationWeather) && pDateTime != null)
                {
                    //Get Data Weather for the available Weather Station (Main or Alternative)
                    lWeatherData = this.getAvailableWeatherStationData(pCropIrrigationWeather, pDateTime);
                    // Si hay datos de estacion meteorologica puedo seguir
                    if (lWeatherData != null)
                    {
                        lIrrigation = this.getIrrigationFromList(pCropIrrigationWeather, pDateTime);
                        lRain = this.getRainFromList(pCropIrrigationWeather, pDateTime);
                        //Get Data Weather form Main Weather Station
                        lMainWeatherData = getWeatherDataFromList(pCropIrrigationWeather.MainWeatherStation, pDateTime);
                        //Get Data Weather form Alternative Weather Station
                        lAlternativeWeatherData = getWeatherDataFromList(pCropIrrigationWeather.AlternativeWeatherStation, pDateTime); 

                        this.addDailyRecordToCropIrrigationWeather(pCropIrrigationWeather, lWeatherData, lMainWeatherData, lAlternativeWeatherData, lRain, lIrrigation, pObservations);///Si ya existe registro para ese dia se sobre-escribe
                        
                        //Luego de que agrego un registro verifico si hay que regar.
                        //Si es asi se agrega el riego a la lista y se reingresa el registro diario. 
                        this.verifyNeedForIrrigation(pCropIrrigationWeather, pDateTime);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in IrrigationSystem.addDailyRecordToList " + e.Message);
                //TODO manage and log the exception
                throw e;
            }
            return lReturn;

        }

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pDateTime"></param>
        public void verifyNeedForIrrigation(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime)
        {
            double lQuantityOfWaterToIrrigate;
            lQuantityOfWaterToIrrigate = this.howMuchToIrrigate(pCropIrrigationWeather);
            if (lQuantityOfWaterToIrrigate > 0)
            {
                this.addOrUpdateIrrigationDataToList(pCropIrrigationWeather, pDateTime, lQuantityOfWaterToIrrigate, false);
                this.addDailyRecordToList(pCropIrrigationWeather, pDateTime, pDateTime.ToShortDateString());
            }
        }

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <returns></returns>
        public double howMuchToIrrigate(CropIrrigationWeather pCropIrrigationWeather)
        {
            double lReturn = 0;
            CropIrrigationWeatherRecord lCropIrrigationWeatherRecord = null;
            //Find the Crop Irrigation Weather Records
            foreach (CropIrrigationWeatherRecord oneCropIrrigationWeatherRecord in this.cropIrrigationWeatherRecordList)
            {
                if (oneCropIrrigationWeatherRecord.CropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    lCropIrrigationWeatherRecord = oneCropIrrigationWeatherRecord;
                    break;
                }

            }
            //With the Crop Irrigation Weather Records Calculate how much water to irrigate
            if (lCropIrrigationWeatherRecord != null)
            {
                lReturn = this.IrrigationCalculus.howMuchToIrrigate(lCropIrrigationWeatherRecord);
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
        public List<PhenologicalStage> getPhenologicalStage(Region pRegion, Specie pSpecie,
            List<Pair<Region, List<PhenologicalStage>>> pPhenologicalStageList)
        {
            List<PhenologicalStage> lReturn = new List<PhenologicalStage>();
            List<PhenologicalStage> lPhenologicalStageListByRegion = null;
            foreach (Pair<Region, List<PhenologicalStage>> lPair in pPhenologicalStageList)
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

        #endregion

        #region Security 
        #endregion

        #region Utitilities

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <param name="pCropIrrigationWeatherRecord"></param>
        /// <returns></returns>
        public String printDailyRecordsList(CropIrrigationWeatherRecord pCropIrrigationWeatherRecord)
        {
            String lReturn = Environment.NewLine + "DAILY RECORDS" + Environment.NewLine ;
            lReturn += Environment.NewLine +Environment.NewLine;

            foreach (DailyRecord lDailyrecord in pCropIrrigationWeatherRecord.DailyRecords)
            {
                lReturn += lDailyrecord.ToString() + Environment.NewLine;
            }
            //Add all the messages and titles to print the daily records
            pCropIrrigationWeatherRecord.addToPrintDailyRecords();
            return lReturn;
        }

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <returns></returns>
        public String printDailyrecordsList(CropIrrigationWeather pCropIrrigationWeather)
        {
            String lReturn = "";
            foreach(CropIrrigationWeatherRecord lCropIrrigationWeatherRecord in this.cropIrrigationWeatherRecordList)
            {
                if (lCropIrrigationWeatherRecord.CropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    lReturn = printDailyRecordsList(lCropIrrigationWeatherRecord);
                }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <returns></returns>
        public String printWeatherDataList()
        {
            String lReturn = Environment.NewLine + "WEATHER DATA" + Environment.NewLine;
            foreach (WeatherData lWeatherData in this.WeatherDataList)
            {
                lReturn += lWeatherData.ToString() + Environment.NewLine;
            }
            return lReturn;
        }

        #endregion

        #region Water
        #endregion

        #region WeatherStation

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <param name="pWeatherStation"></param>
        /// <param name="pDateTime"></param>
        /// <returns></returns>
        public WeatherData getWeatherDataFromList(WeatherStation pWeatherStation, DateTime pDateTime)
        {
            WeatherData lReturn = null;
            IEnumerable<WeatherData> lWeatherDataListOrderByDescendingDate;
            lWeatherDataListOrderByDescendingDate = this.WeatherDataList.OrderByDescending(lWeatherData => lWeatherData.Date);
            foreach (WeatherData lWeatherData in lWeatherDataListOrderByDescendingDate)
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
        /// TODO explain method
        /// </summary>
        /// <param name="pWeatherStation"></param>
        /// <param name="pDateTime"></param>
        /// <param name="pTemperature"></param>
        /// <param name="pSolarRadiation"></param>
        /// <param name="pTemMax"></param>
        /// <param name="pTemMin"></param>
        /// <param name="pEvapotranspiration"></param>
        /// <returns></returns>
        public bool addWeatherDataToList(WeatherStation pWeatherStation, DateTime pDateTime,
            double pTemperature, double pSolarRadiation, double pTemMax,
            double pTemMin, double pEvapotranspiration)
        {
            bool lReturn = false;
            try
            {
                WeatherData lData = new WeatherData(pWeatherStation, pDateTime,
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

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pIrrigationDate"></param>
        /// <param name="pQuantityOfWaterToIrrigate"></param>
        /// <param name="pIsExtraIrrigation"></param>
        /// <returns></returns>
        public bool addOrUpdateIrrigationDataToList(CropIrrigationWeather pCropIrrigationWeather,
            DateTime pIrrigationDate, double pQuantityOfWaterToIrrigate, bool pIsExtraIrrigation)
        {
            bool lReturn = false;
            Water.WaterInput lNewIrrigation;

            try
            {
                lNewIrrigation = getIrrigationFromList(pCropIrrigationWeather, pIrrigationDate);
                //If there is not a registry then it is created 
                //If there is an Irrigation Registry it is actualized 
                if (lNewIrrigation == null)
                {
                    lNewIrrigation = new Water.Irrigation();
                    lNewIrrigation.CropIrrigationWeather = pCropIrrigationWeather;
                    lNewIrrigation.Date = pIrrigationDate;
                    if (pIsExtraIrrigation)
                    {
                        lNewIrrigation.ExtraInput = pQuantityOfWaterToIrrigate;
                        lNewIrrigation.ExtraDate = pIrrigationDate;
                    }
                    else
                    {
                        lNewIrrigation.Input = pQuantityOfWaterToIrrigate;
                    }
                    this.IrrigationList.Add(lNewIrrigation);
                }
                else
                {
                    if (pIsExtraIrrigation)
                    {
                        lNewIrrigation.ExtraInput += pQuantityOfWaterToIrrigate;
                        lNewIrrigation.ExtraDate = pIrrigationDate;
                    }
                    else
                    {
                        lNewIrrigation.Input += pQuantityOfWaterToIrrigate;
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


        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pDate"></param>
        /// <param name="pInput"></param>
        /// <returns></returns>
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

        #endregion

        #region Overrides
        #endregion

        /// <summary>
        /// TODO description adjustmentPhenology
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pNewStage"></param>
        /// <param name="pDateTime"></param>
        public void adjustmentPhenology(CropIrrigationWeather pCropIrrigationWeather, Stage pNewStage, DateTime pDateTime)
        {
            Stage lActualStage;
            double lModification;
            foreach (CropIrrigationWeatherRecord lCropIrrigationWeatherRecord in this.cropIrrigationWeatherRecordList)
            {
                if (lCropIrrigationWeatherRecord.CropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    lActualStage = lCropIrrigationWeatherRecord.CropIrrigationWeather.PhenologicalStage.Stage;
                    lModification = calculateDegreeStageDifference(lActualStage, pNewStage, pCropIrrigationWeather.Crop.Specie);
                    lCropIrrigationWeatherRecord.adjustmentPhenology(pNewStage, pDateTime, lModification);
        
                }
            }

        }

        


    }
}