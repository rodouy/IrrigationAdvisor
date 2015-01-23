using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Security;

namespace IrrigationAdvisor.Models.Management
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

        #region Agriculture
        #endregion

        #region Irrigation
        #endregion
        
        #region Language
        #endregion

        #region Localization
        #endregion
        
        #region Management
        #endregion
        
        #region Security
        #endregion
        
        #region Utitilities
        #endregion
        
        #region Water
        #endregion
        
        #region Weather
        #endregion

        #endregion

        #region Consts

        #region Agriculture
        #endregion

        #region Irrigation
        #endregion

        #region Language
        #endregion

        #region Localization
        #endregion

        #region Management
        #endregion

        #region Security
        #endregion

        #region Utilities
        #endregion

        #region Water
        #endregion

        #region Weather
        #endregion

        #endregion

        #region Fields
        
        #region Agriculture 
       
        private List<Crop> cropList;
        private List<Soil> soilList;
        private List<Specie> specieList;
        private List<Stage> stageList;
        private List<PhenologicalStage> phenologicalStageList;
        
        #endregion

        #region Irrigation
        
        private List<Bomb> bombList;
        private List<IrrigationUnit> irrigationUnitList;

        #endregion

        #region Language

        private List<Language.Language> languageList;
        
        #endregion

        #region Location

        private List<Country> countryList;
        private List<City> cityList;
        private List<Region> regionList;
        private List<Location> locationList;
        private List<Farm> farmList;
        
        #endregion

        #region Management

        private List<CropIrrigationWeather> cropIrrigationWeatherList;
        private List<CropIrrigationWeatherRecord> cropIrrigationWeatherRecordList;
        private IrrigationCalculus irrigationCalculus;

        #endregion

        #region Security 

        private List<User> userList;

        #endregion

        #region Utitilities
        #endregion

        #region Water

        private List<WaterInput> rainList;
        private List<WaterInput> irrigationList;
        private List<WaterInput> waterInputList;
        private List<WaterOutput> waterOutputList;

        #endregion

        #region Weather

        private List<WeatherData> weatherDataList;
        private List<WeatherStation> weatherStationList;             
        
        #endregion

        #endregion

        #region Properties

        #region Agriculture
        
        public List<Crop> CropList
        {
            get { return cropList; }
            set { cropList = value; }
        }

        public List<Soil> SoilList
        {
            get { return soilList; }
            set { soilList = value; }
        }

        public List<Specie> SpecieList
        {
            get { return specieList; }
            set { specieList = value; }
        }

        public List<Stage> StageList
        {
            get { return stageList; }
            set { stageList = value; }
        }

        public List<PhenologicalStage> PhenologicalStageList
        {
            get { return phenologicalStageList; }
            set { phenologicalStageList = value; }
        }

        #endregion

        #region Irrigation

        public List<Bomb> BombList
        {
            get { return bombList; }
            set { bombList = value; }
        }

        public List<IrrigationUnit> IrrigationUnitList
        {
            get { return irrigationUnitList; }
            set { irrigationUnitList = value; }
        }

        #endregion

        #region Language

        public List<Language.Language> LanguageList
        {
            get { return languageList; }
            set { languageList = value; }
        }

        #endregion

        #region Location

        public List<Country> CountryList
        {
            get { return countryList; }
            set { countryList = value; }
        }

        public List<City> CityList
        {
            get { return cityList; }
            set { cityList = value; }
        }

        public List<Region> RegionList
        {
            get { return regionList; }
            set { regionList = value; }
        }

        public List<Location> LocationList
        {
            get { return locationList; }
            set { locationList = value; }
        }

        public List<Farm> FarmList
        {
            get { return farmList; }
            set { farmList = value; }
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

        public List<User> UserList
        {
            get { return userList; }
            set { userList = value; }
        }

        #endregion

        #region Utitilities
        #endregion

        #region Water
        public List<WaterInput> RainList
        {
            get { return rainList; }
            set { rainList = value; }
        }

        public List<WaterInput> IrrigationList
        {
            get { return irrigationList; }
            set { irrigationList = value; }
        }

        public List<WaterInput> WaterInputList
        {
            get { return waterInputList; }
            set { waterInputList = value; }
        }

        public List<WaterOutput> WaterOutputList
        {
            get { return waterOutputList; }
            set { waterOutputList = value; }
        }

        #endregion

        #region Weather

        public List<WeatherData> WeatherDataList
        {
            get { return weatherDataList; }
            set { weatherDataList = value; }
        }

        public List<WeatherStation> WeatherStationList
        {
            get { return weatherStationList; }
            set { weatherStationList = value; }
        }
        
        #endregion
        
        #endregion

        #region Construction

        /// <summary>
        /// IrrigationSystem instance
        /// </summary>
        private static IrrigationSystem instance;

        /// <summary>
        /// Constructor of IrrigationSystem
        /// </summary>
        private IrrigationSystem()
        {

            #region Agriculture
            
            //this.PhenologicalStageList = new List<Pair< Region, List<PhenologicalStage>>>();
            this.CropList = new List<Crop>();
            this.SoilList = new List<Soil>();
            this.SpecieList = new List<Specie>();
            this.StageList = new List<Stage>();

            #endregion

            #region Irrigation

            this.BombList = new List<Bomb>();
            this.IrrigationUnitList = new List<IrrigationUnit>();

            #endregion

            #region Language

            this.LanguageList = new List<Language.Language>();

            #endregion

            #region Location

            this.CountryList = new List<Country>();
            this.CityList = new List<City>();
            this.RegionList = new List<Region>();
            this.LocationList = new List<Location>();
            this.FarmList = new List<Farm>();

            #endregion
            
            #region Management

            this.CropIrrigationWeatherList = new List<CropIrrigationWeather>();
            this.cropIrrigationWeatherRecordList = new List<CropIrrigationWeatherRecord>();
            this.IrrigationCalculus = new IrrigationCalculus();
            
            #endregion
            
            #region Security 

            this.UserList = new List<User>();

            #endregion

            #region Utitilities
            #endregion

            #region Water
            
            this.IrrigationList = new List<Water.WaterInput>();
            this.RainList = new List<Water.WaterInput>();
            this.waterInputList = new List<WaterInput>();
            this.waterOutputList = new List<WaterOutput>();

            #endregion
            
            #region Weather
            
            this.WeatherDataList = new List<WeatherData>();
            this.WeatherStationList = new List<WeatherStation>();
            
            #endregion

        }

        /// <summary>
        /// Return the instance of IrrigationSystem
        /// </summary>
        public static IrrigationSystem Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new IrrigationSystem();
                }
                return instance;
            }
        }

        #endregion

        #region Private Helpers

        #region Agriculture
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

        #region Security
        #endregion

        #region Utitilities
        #endregion

        #region Water
        
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


        #endregion

        #region Weather


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
            foreach(Region lRegion in this.RegionList)
            {
                if (lRegion.Equals(pRegion))
                {
                    lReturnEffectiveRain = lRegion.EffectiveRainList;
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

            lPhenologicalStageList = pSpecie.PhenologicalStageList;
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

        #endregion

        #region Public Methods

        #region Agriculture

        #region Crop

        /// <summary>
        /// IF Crop Exists in CropList return the Crop, else null
        /// </summary>
        /// <param name="pCrop"></param>
        /// <returns></returns>
        public Crop ExistCrop(Crop pCrop)
        {
            Crop lReturn = null;
            foreach (Crop item in this.CropList)
            {
                if(item.Equals(pCrop))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Return the Crop if added, if it is in the list, return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pPhenologicalStageList"></param>
        /// <param name="pDensity"></param>
        /// <param name="pMaxEvapotranspirationToIrrigate"></param>
        /// <returns></returns>
        public Crop AddCrop(String pName, Specie pSpecie, 
                        List<PhenologicalStage> pPhenologicalStageList, 
                        Double pDensity, Double pMaxEvapotranspirationToIrrigate)
        {
            Crop lReturn = null;
            int lIDCrop = this.CropList.Count();
            Crop lCrop = new Crop(lIDCrop, pName, pSpecie, pPhenologicalStageList, pDensity, pMaxEvapotranspirationToIrrigate);
            if (ExistCrop(lCrop) == null)
            {
                this.CropList.Add(lCrop);
                lReturn = lCrop;
            }
            return lReturn;
        }

        /// <summary>
        /// Update the crop if exists in CropList, else return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pPhenologicalStageList"></param>
        /// <param name="pDensity"></param>
        /// <param name="pMaxEvapotranspirationToIrrigate"></param>
        /// <returns></returns>
        public Crop UpdateCrop(String pName, Specie pSpecie, 
                        List<PhenologicalStage> pPhenologicalStageList, 
                        Double pDensity, Double pMaxEvapotranspirationToIrrigate)
        {
            Crop lReturn = null;
            Crop lCrop = new Crop(0, pName, pSpecie, pPhenologicalStageList, pDensity, pMaxEvapotranspirationToIrrigate);
            lReturn = ExistCrop(lCrop);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Specie = pSpecie;
                lReturn.PhenologicalStageList = pPhenologicalStageList;
                lReturn.Density = pDensity;
                lReturn.MaxEvapotranspirationToIrrigate = pMaxEvapotranspirationToIrrigate;
            }
            return lReturn;
        }

        #endregion

        #region Soil

        public Soil ExistSoil(Soil pSoil)
        {
            Soil lReturn = null;
            foreach (Soil item in this.SoilList)
            {
                if(item.Equals(pSoil))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        public Soil AddSoil()
        {
            Soil lReturn = null;
            Soil lSoil = new Soil(pIdSoil, pName, pDescription,
                pLocation, pTestDate, pDepthLimit )
            return lReturn;
        }

        #endregion

        #region Specie

        public Specie ExistSpecie(Specie pSpecie)
        {
            Specie lReturn = null;
            foreach (Specie item in SpecieList)
            {
                if(item.Equals(pSpecie))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }



        #endregion

        #region Stage

        public Stage ExistStage(Stage pStage)
        {
            Stage lReturn = null;
            foreach (Stage item in StageList)
            {
                if(item.Equals(pStage))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        #endregion

        #region Phenological Stage

        /// <summary>
        /// Return if the Phenological Stage exists in the list
        /// </summary>
        /// <param name="pPhenologicalStage"></param>
        /// <returns></returns>
        public bool ExistPhenologicalStage(PhenologicalStage pPhenologicalStage)
        {
            bool lReturn = false;
            if(pPhenologicalStage != null)
            {
                foreach (PhenologicalStage item in this.PhenologicalStageList)
                {
                    if(item.Equals(pPhenologicalStage))
                    {
                        lReturn = true;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Create a Phenological Stage
        /// </summary>
        /// <param name="pIdSoil"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pStage"></param>
        /// <param name="pMinDegree"></param>
        /// <param name="pMaxDegree"></param>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
        public PhenologicalStage CreatePhenologicalStage(int pId, Specie pSpecie, 
                                        Stage pStage, double pMinDegree, double pMaxDegree, 
                                        double pRootDepth)
        {
            PhenologicalStage lPhenologicalStage;

            lPhenologicalStage = new PhenologicalStage(pId, pSpecie, pStage, 
                                        pMinDegree, pMaxDegree, pRootDepth);
            return lPhenologicalStage;
        }


        /// <summary>
        /// TODO description adjustmentPhenology
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pNewStage"></param>
        /// <param name="pDateTime"></param>
        public void adjustmentPhenology(CropIrrigationWeather pCropIrrigationWeather, 
                                    Stage pNewStage, DateTime pDateTime)
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

        #endregion

        #endregion

        #region Irrigation
        #endregion

        #region Language
        #endregion

        #region Location

        #region Region

        /// <summary>
        /// If Region Exists in List return the Region, else null
        /// </summary>
        /// <param name="pRegion"></param>
        /// <returns></returns>
        public Region ExistRegion(Region pRegion)
        {
            Region lReturn = null;
            foreach (Region item in RegionList)
            {
                if(item.Equals(pRegion))
                {
                    lReturn = item;
                    break;
                }                
            }
            return lReturn;
        }

        /// <summary>
        /// Add a Region to List if not exists,
        /// if exists return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pPosition"></param>
        /// <param name="pEffectiveRainList"></param>
        /// <param name="pSpecieList"></param>
        /// <returns></returns>
        public Region AddRegion(String pName, Position pPosition,
            List<EffectiveRain> pEffectiveRainList, 
            List<Specie> pSpecieList)
        {
            Region lReturn = null;
            int lIDRegion = this.RegionList.Count();
            Region lRegion = new Region(lIDRegion, pName,
                pPosition, pEffectiveRainList, pSpecieList);
            if(ExistRegion(lRegion) == null)
            {
                this.RegionList.Add(lRegion);
                lReturn = lRegion;
            }
            return lReturn;
        }

        /// <summary>
        /// Update the region if exists in List, else return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pPosition"></param>
        /// <param name="pEffectiveRainList"></param>
        /// <param name="pSpecieList"></param>
        /// <returns></returns>
        public Region UpdateRegion(String pName, Position pPosition,
            List<EffectiveRain> pEffectiveRainList,
            List<Specie> pSpecieList)
        {
            Region lReturn = null;
            Region lRegion = new Region(0, pName, pPosition,
                pEffectiveRainList, pSpecieList);
            lReturn = ExistRegion(lRegion);
            if(lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Position = pPosition;
                lReturn.EffectiveRainList = pEffectiveRainList;
                lReturn.SpecieList = pSpecieList;
            }
            return lReturn;
        }

        #endregion

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


        ///// <summary>
        ///// Return the Phenological Stage for a Specie in a Region given the rootDepth
        ///// </summary>
        ///// <param name="pDegree"></param>
        ///// <param name="pRegion"></param>
        ///// <param name="pSpecie"></param>
        ///// <returns></returns>
        //public PhenologicalStage getPhenologicalStage(double pDegree, Region pRegion, Specie pSpecie)
        //{
        //    PhenologicalStage lReturn = null;
        //    List<PhenologicalStage> lPhenologicalStageListByRegion = null;
        //    foreach (Pair<Region , List<PhenologicalStage >> lPair in this.PhenologicalStageList)
        //    {
        //        if (lPair != null && lPair.First.Equals(pRegion))
        //        {
        //            lPhenologicalStageListByRegion = lPair.Second;
        //        }
        //    }

        //    IEnumerable<PhenologicalStage> query = lPhenologicalStageListByRegion.OrderBy(lPhenologicalStage => lPhenologicalStage.MinDegree);
        //    foreach(PhenologicalStage lPhenStage in query)
        //    {
        //        if (lPhenStage != null && lPhenStage.Specie.Equals(pSpecie) && lPhenStage.MinDegree <= pDegree && lPhenStage.MaxDegree >= pDegree)
        //        {
        //            lReturn = lPhenStage;
        //        }
        //    }
        //    return lReturn;

        //}


        /// <summary>
        /// Return the List of PhenologicalStageList for a Specie in a Region
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

        #region Weather

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

        

        


    }
}