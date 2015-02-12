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
            this.PhenologicalStageList = new List<PhenologicalStage>();

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

            this.RainList = new List<Water.WaterInput>();
            this.IrrigationList = new List<Water.WaterInput>();
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

        /// <summary>
        /// Search the cropIrrigationWeatherRecord of the CropIrrigationWeather and delegate the creation of the daily record
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pWeatherData"></param>
        /// <param name="pMainWeatherData"></param>
        /// <param name="pAlternativeWeatherData"></param>
        /// <param name="pRain"></param>
        /// <param name="plIrrigation"></param>
        /// <param name="pObservations"></param>
        private void addDailyRecordToCropIrrigationWeather(CropIrrigationWeather pCropIrrigationWeather,
                                                    WeatherData pWeatherData, WeatherData pMainWeatherData,
                                                    WeatherData pAlternativeWeatherData, WaterInput pRain,
                                                    WaterInput plIrrigation, string pObservations)
        {
            foreach (CropIrrigationWeatherRecord lCropIrrigationWeatherRecord in this.cropIrrigationWeatherRecordList)
            {
                if (lCropIrrigationWeatherRecord.CropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    pCropIrrigationWeather.addDailyRecord(pWeatherData, pMainWeatherData, pAlternativeWeatherData, pRain, plIrrigation, pObservations);
                    break;
                }
            }

        }

        #endregion

        #region Security
        #endregion

        #region Utitilities
        #endregion

        #region Water
        
        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pDateTime"></param>
        /// <returns></returns>
        private WaterInput getIrrigationFromList(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime)
        {
            Water.WaterInput lReturn = null;
            IEnumerable<WaterInput> lIrrigationListOrderByDescendingByDate;
            lIrrigationListOrderByDescendingByDate = this.irrigationList.OrderByDescending(lWaterInput => lWaterInput.Date);
            //TODO change to contains for date 
            foreach (WaterInput lWaterInput in lIrrigationListOrderByDescendingByDate)
                if (Utilities.Utils.isTheSameDay(lWaterInput.Date, pDateTime) && lWaterInput.CropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    lReturn = lWaterInput;
                    return lReturn;
                }
            return lReturn;
        }

        /// <summary>
        /// Add description
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pDateTime"></param>
        /// <returns></returns>
        private WaterInput getRainFromList(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime)
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
            WeatherData lWeatherData = GetWeatherDataByWeatherStationAndDate(pCropIrrigationWeather.MainWeatherStation, pDateTime);
            if (lWeatherData != null)
            {
                lReturn = lWeatherData;
            }
            else
            {
                lWeatherData = GetWeatherDataByWeatherStationAndDate(pCropIrrigationWeather.AlternativeWeatherStation, pDateTime);
                if (lWeatherData != null)
                {
                    lReturn = lWeatherData;
                }

            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pRegion"></param>
        /// <returns></returns>
        private List<EffectiveRain> GetEffectiveRainList(Region pRegion)
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
                    oldDegree = lPhenologicalStage.GetAverageDegree();
                }
                if (lPhenologicalStage.Stage.Equals(newStage) && lPhenologicalStage.Specie.Equals(pSpecie))
                {
                    newDegree = lPhenologicalStage.GetAverageDegree();
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
        /// Find Crop by Name and Specie
        /// Name and Specie are the argument for Crop Equals
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSpecie"></param>
        /// <returns></returns>
        public Crop FindCrop(String pName, Specie pSpecie)
        {
            Crop lReturn = null;
            if(!String.IsNullOrEmpty(pName) && pSpecie != null)
            {
                foreach (Crop item in this.CropList)
                {
                    if (item.Name.Equals(pName) && item.Specie.Equals(pSpecie))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// IF Crop Exists in CropList return the Crop, else null
        /// </summary>
        /// <param name="pCrop"></param>
        /// <returns></returns>
        public Crop ExistCrop(Crop pCrop)
        {
            Crop lReturn = null;
            if (pCrop != null)
            {
                foreach (Crop item in this.CropList)
                {
                    if (item.Equals(pCrop))
                    {
                        lReturn = item;
                        break;
                    }
                } 
            }
            return lReturn;
        }

        /// <summary>
        /// Return the Crop if added because do not exist, 
        ///     if exist in the list, return the crop from the list.
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pPhenologicalStageList"></param>
        /// <param name="pDensity"></param>
        /// <param name="pMaxEvapotranspirationToIrrigate"></param>
        /// <returns></returns>
        public Crop AddCrop(String pName, Specie pSpecie, Region pRegion,
                        List<PhenologicalStage> pPhenologicalStageList, 
                        Double pDensity, Double pMaxEvapotranspirationToIrrigate)
        {
            Crop lReturn = null;
            int lIDCrop = this.CropList.Count();
            Crop lCrop = new Crop(lIDCrop, pName, pSpecie, pRegion, pPhenologicalStageList, 
                                pDensity, pMaxEvapotranspirationToIrrigate);
            lReturn = ExistCrop(lCrop);
            if (lReturn == null)
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
        public Crop UpdateCrop(String pName, Specie pSpecie, Region pRegion,
                        List<PhenologicalStage> pPhenologicalStageList, 
                        Double pDensity, Double pMaxEvapotranspirationToIrrigate)
        {
            Crop lReturn = null;
            Crop lCrop = new Crop(0, pName, pSpecie, pRegion, pPhenologicalStageList, 
                            pDensity, pMaxEvapotranspirationToIrrigate);
            lReturn = ExistCrop(lCrop);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Specie = pSpecie;
                lReturn.Region = pRegion;
                lReturn.PhenologicalStageList = pPhenologicalStageList;
                lReturn.Density = pDensity;
                lReturn.MaxEvapotranspirationToIrrigate = pMaxEvapotranspirationToIrrigate;
            }
            return lReturn;
        }

        /// <summary>
        /// Add Phenological Stage to Crop, if exist it return it.
        /// </summary>
        /// <param name="pCrop"></param>
        /// <param name="pPhenologicalStage"></param>
        /// <returns></returns>
        public PhenologicalStage AddPhenologicalStageToCrop(Crop pCrop, PhenologicalStage pPhenologicalStage)
        {
            PhenologicalStage lReturn = null;
            if(pPhenologicalStage != null && pCrop != null)
            {
                lReturn = pCrop.ExistPhenologicalStage(pPhenologicalStage);
                if (lReturn == null)
                {
                    pCrop.PhenologicalStageList.Add(pPhenologicalStage);
                    lReturn = pPhenologicalStage;
                }
            }
            return lReturn;
        }

        #endregion

        #region Soil

        /// <summary>
        /// Find a Soil by Name and Location
        /// Name and Location are the argument for Soil Equals
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pLocation"></param>
        /// <returns></returns>
        public Soil FindSoil(String pName, Location pLocation)
        {
            Soil lReturn = null;
            if(!String.IsNullOrEmpty(pName) && pLocation != null)
            {
                foreach (Soil item in this.SoilList)
                {
                    if(item.Name.Equals(pName) && item.Location.Equals(pLocation))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// If Soil Exist in SoilList return the Soil, else null
        /// </summary>
        /// <param name="pSoil"></param>
        /// <returns></returns>
        public Soil ExistSoil(Soil pSoil)
        {
            Soil lReturn = null;
            if (pSoil != null)
            {
                foreach (Soil item in this.SoilList)
                {
                    if (item.Equals(pSoil))
                    {
                        lReturn = item;
                        break;
                    }
                } 
            }
            return lReturn;
        }

        /// <summary>
        /// Return the Soil if added because do not exist,
        ///     if exist in the list, return the soil from the list.
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pDescription"></param>
        /// <param name="pLocation"></param>
        /// <param name="pTestDate"></param>
        /// <param name="pDepthLimit"></param>
        /// <returns></returns>
        public Soil AddSoil(String pName, String pDescription,
                        Location pLocation, DateTime pTestDate,
                        double pDepthLimit)
        {
            Soil lReturn = null;
            int lIdSoil = this.SoilList.Count();
            Soil lSoil = new Soil(lIdSoil, pName, pDescription,
                                pLocation, pTestDate, pDepthLimit);
            if(ExistSoil(lSoil) == null)
            {
                this.SoilList.Add(lSoil);
                lReturn = lSoil;
            }
            return lReturn;
        }

        /// <summary>
        /// If the Soil exist in the list Update all the data of the Soil, 
        ///     if do not exist return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pDescription"></param>
        /// <param name="pLocation"></param>
        /// <param name="pTestDate"></param>
        /// <param name="pDepthLimit"></param>
        /// <returns></returns>
        public Soil UpdateSoil(String pName, String pDescription,
                        Location pLocation, DateTime pTestDate,
                        double pDepthLimit)
        {
            Soil lReturn = null;
            Soil lSoil = new Soil(0, pName, pDescription,
                                pLocation, pTestDate, pDepthLimit);
            lReturn = ExistSoil(lSoil);
            if(lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Description = pDescription;
                lReturn.Location = pLocation;
                lReturn.TestDate = pTestDate;
                lReturn.DepthLimit = pDepthLimit;
            }
            return lReturn;
        }

        #endregion

        #region Specie

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public Specie FindSpecie(String pName)
        {
            Specie lReturn = null;
            if(!String.IsNullOrEmpty(pName))
            {
                foreach (Specie item in this.SpecieList)
                {
                    if(item.Name.Equals(pName))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <returns></returns>
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

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pBaseTemperature"></param>
        /// <returns></returns>
        public Specie AddSpecie(String pName, double pBaseTemperature)
        {
            Specie lReturn = null;
            int lIdSpecie = this.SpecieList.Count();
            Specie lSpecie = new Specie(lIdSpecie, pName, pBaseTemperature, null, null);
            lReturn = ExistSpecie(lSpecie);
            if (lReturn == null)
            {
                this.SpecieList.Add(lSpecie);
                lReturn = lSpecie;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pBaseTemperature"></param>
        /// <param name="pCropCoefficient"></param>
        /// <param name="pPhenologicalStageList"></param>
        /// <returns></returns>
        public Specie AddSpecie(String pName, double pBaseTemperature,
                        CropCoefficient pCropCoefficient, 
                        List<PhenologicalStage> pPhenologicalStageList)
        {
            Specie lReturn = null;
            int lIdSpecie = this.SpecieList.Count();
            Specie lSpecie = new Specie(lIdSpecie, pName, pBaseTemperature, pCropCoefficient, 
                                    pPhenologicalStageList);
            lReturn = ExistSpecie(lSpecie);
            if(lReturn == null)
            {
                this.SpecieList.Add(lSpecie);
                lReturn = lSpecie;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pBaseTemperature"></param>
        /// <param name="pCropCoefficient"></param>
        /// <param name="pPhenologicalStageList"></param>
        /// <returns></returns>
        public Specie UpdateSpecie(String pName, double pBaseTemperature,
                        CropCoefficient pCropCoefficient,
                        List<PhenologicalStage> pPhenologicalStageList)
        {
            Specie lReturn = null;
            Specie lSpecie = new Specie(0, pName, pBaseTemperature, pCropCoefficient,
                                    pPhenologicalStageList);
            lReturn = ExistSpecie(lSpecie);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.BaseTemperature = pBaseTemperature;
                lReturn.CropCoefficient = pCropCoefficient;
                lReturn.PhenologicalStageList = pPhenologicalStageList;
            }
            return lReturn;
        }

        #endregion

        #region Stage

        /// <summary>
        /// Find Stage by Name (Equals compare Property)
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public Stage FindStage(String pName)
        {
            Stage lReturn = null;
            if(!String.IsNullOrEmpty(pName))
            {
                foreach (Stage item in this.StageList)
                {
                    if (item.Name.Equals(pName))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pStage"></param>
        /// <returns></returns>
        public Stage ExistStage(Stage pStage)
        {
            Stage lReturn = null;
            if (pStage != null)
            {
                foreach (Stage item in StageList)
                {
                    if (item.Equals(pStage))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pDescription"></param>
        /// <returns></returns>
        public Stage AddStage(String pName, String pDescription)
        {
            Stage lReturn = null;
            long lIdStage = this.StageList.Count();
            Stage lStage = new Stage(lIdStage, pName, pDescription);
            if(ExistStage(lStage) == null)
            {
                this.StageList.Add(lStage);
                lReturn = lStage;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// 
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pDescription"></param>
        /// <returns></returns>
        public Stage UpdateStage(String pName, String pDescription)
        {
            Stage lReturn = null;
            Stage lStage = new Stage(0, pName, pDescription);
            lReturn = ExistStage(lStage);
            if(lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Description = pDescription;
            }
            return lReturn;
        }

        #endregion

        #region Phenological Stage

        /// <summary>
        /// Find A Phenological Stage by Specie and Stage
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <param name="pStage"></param>
        /// <returns></returns>
        public PhenologicalStage FindPhenologicalStage(Specie pSpecie, Stage pStage)
        {
            PhenologicalStage lReturn = null;
            if (pSpecie != null && pStage != null)
            {
                foreach (PhenologicalStage item in this.PhenologicalStageList)
                {
                    if (item.Specie.Equals(pSpecie) && item.Stage.Equals(pStage))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Return if the Phenological Stage exists in the list
        /// </summary>
        /// <param name="pPhenologicalStage"></param>
        /// <returns></returns>
        public PhenologicalStage ExistPhenologicalStage(PhenologicalStage pPhenologicalStage)
        {
            PhenologicalStage lReturn = null;
            if(pPhenologicalStage != null)
            {
                foreach (PhenologicalStage item in this.PhenologicalStageList)
                {
                    if(item.Equals(pPhenologicalStage))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a Phenological Stage if not exists, else return null
        /// </summary>
        /// <param name="pIdSoil"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pStage"></param>
        /// <param name="pMinDegree"></param>
        /// <param name="pMaxDegree"></param>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
        public PhenologicalStage AddPhenologicalStage(Specie pSpecie, Stage pStage, 
                                        double pMinDegree, double pMaxDegree, 
                                        double pRootDepth, double pHydricBalanceDepth)
        {
            PhenologicalStage lReturn = null;
            long lIdPhenologicalStage = this.PhenologicalStageList.Count();
            PhenologicalStage lPhenologicalStage = new PhenologicalStage(lIdPhenologicalStage,
                                                    pSpecie, pStage, pMinDegree, pMaxDegree, 
                                                    pRootDepth, pHydricBalanceDepth);
            lReturn = ExistPhenologicalStage(lPhenologicalStage);
            if (lReturn == null)
            {
                this.PhenologicalStageList.Add(lPhenologicalStage);
                lReturn = lPhenologicalStage;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <param name="pStage"></param>
        /// <param name="pMinDegree"></param>
        /// <param name="pMaxDegree"></param>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
        public PhenologicalStage UpdatePhenologicalStage(Specie pSpecie, Stage pStage, 
                                        double pMinDegree, double pMaxDegree,
                                        double pRootDepth, double pHydricBalanceDepth)
        {
            PhenologicalStage lReturn = null;
            PhenologicalStage lPhenologicalStage = new PhenologicalStage(0, pSpecie, pStage, 
                                                        pMinDegree, pMaxDegree, pRootDepth,
                                                        pHydricBalanceDepth);
            lReturn = ExistPhenologicalStage(lPhenologicalStage);
            if(lReturn != null)
            {
                lReturn.Specie = pSpecie;
                lReturn.Stage = pStage;
                lReturn.MinDegree = pMinDegree;
                lReturn.MaxDegree = pMaxDegree;
                lReturn.RootDepth = pRootDepth;
                lReturn.HydricBalanceDepth = pHydricBalanceDepth;
            }
            return lReturn;
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

        #region Bomb

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <returns></returns>
        public Bomb FindBomb(String pName, int pSerialNumber)
        {
            Bomb lReturn = null;
            if(!String.IsNullOrEmpty(pName) && pSerialNumber != 0)
            {
                foreach (Bomb item in this.BombList)
                {
                    if(item.Name.Equals(pName) && item.SerialNumber.Equals(pSerialNumber))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pBomb"></param>
        /// <returns></returns>
        public Bomb ExistBomb(Bomb pBomb)
        {
            Bomb lResult = null;
            if(pBomb != null)
            {
                foreach (Bomb item in this.BombList)
                {
                    if(item.Equals(pBomb))
                    {
                        lResult = item;
                        break;
                    }
                }
            }
            return lResult;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSerialNumber"></param>
        /// <param name="pServiceDate"></param>
        /// <param name="pPurchaseDate"></param>
        /// <param name="pLocation"></param>
        /// <returns></returns>
        public Bomb AddBomb(String pName, int pSerialNumber, DateTime pServiceDate,
                            DateTime pPurchaseDate, Location pLocation)
        {
            Bomb lReturn = null;
            long lIdBomb = this.BombList.Count();
            Bomb lBomb = new Bomb(lIdBomb, pName, pSerialNumber, pServiceDate,
                            pPurchaseDate, pLocation);
            lReturn = ExistBomb(lBomb);
            if(lReturn == null)
            {
                this.BombList.Add(lBomb);
                lReturn = lBomb;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSerialNumber"></param>
        /// <param name="pServiceDate"></param>
        /// <param name="pPurchaseDate"></param>
        /// <param name="pLocation"></param>
        /// <returns></returns>
        public Bomb UpdateBomb(String pName, int pSerialNumber, DateTime pServiceDate,
                            DateTime pPurchaseDate, Location pLocation)
        {
            Bomb lReturn = null;
            Bomb lBomb = new Bomb(0, pName, pSerialNumber, pServiceDate,
                            pPurchaseDate, pLocation);
            lReturn = ExistBomb(lBomb);
            if(lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.SerialNumber = pSerialNumber;
                lReturn.ServiceDate = pServiceDate;
                lReturn.PurchaseDate = pPurchaseDate;
                lReturn.Location = pLocation;
            }
            return lReturn;
        }

        #endregion

        #region IrrigationUnit

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pLocation"></param>
        /// <param name="pIrrigationType"></param>
        /// <returns></returns>
        public IrrigationUnit FindIrrigationUnit(String pName, Location pLocation,
                                                String pIrrigationType)
        {
            IrrigationUnit lReturn = null;
            if(!String.IsNullOrEmpty(pName) && pLocation != null 
                                    && !String.IsNullOrEmpty(pIrrigationType))
            {
                foreach (IrrigationUnit  item in this.IrrigationUnitList)
                {
                    if(item.Name.Equals(pName) && item.Location.Equals(pLocation)
                        && item.IrrigationType.Equals(pIrrigationType))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pIrrigationUnit"></param>
        /// <returns></returns>
        public IrrigationUnit ExistIrrigationUnit(IrrigationUnit pIrrigationUnit)
        {
            IrrigationUnit lReturn = null;
            if(pIrrigationUnit != null)
            {
                foreach (IrrigationUnit item in this.IrrigationUnitList)
	            {
                    if(item.Equals(pIrrigationUnit))
                    {
                        lReturn = item;
                        break;
                    }
	            }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pIrrigationType"></param>
        /// <param name="pIrrigationEfficiency"></param>
        /// <param name="pIrrigationList"></param>
        /// <param name="pSurface"></param>
        /// <param name="pCropList"></param>
        /// <param name="pBomb"></param>
        /// <param name="pLocation"></param>
        /// <returns></returns>
        public IrrigationUnit AddIrrrigationUnit(String pName, String pIrrigationType,
                                                double pIrrigationEfficiency, 
                                                List<Pair<DateTime, double>>  pIrrigationList, 
                                                double pSurface, List<Crop> pCropList, 
                                                Bomb pBomb, Location pLocation)
        {
            IrrigationUnit lReturn = null;
            long lIdIrrigationUnit = this.irrigationUnitList.Count();
            IrrigationUnit lIrrigationUnit = new IrrigationUnit(lIdIrrigationUnit, pName, pIrrigationType,
                                                pIrrigationEfficiency, pIrrigationList, pSurface,
                                                pCropList, pBomb, pLocation);
            lReturn = ExistIrrigationUnit(lIrrigationUnit);
            if(lReturn == null)
            {
                this.IrrigationUnitList.Add(lIrrigationUnit);
                lReturn = lIrrigationUnit;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pIrrigationType"></param>
        /// <param name="pIrrigationEfficiency"></param>
        /// <param name="pIrrigationList"></param>
        /// <param name="pSurface"></param>
        /// <param name="pCropList"></param>
        /// <param name="pBomb"></param>
        /// <param name="pLocation"></param>
        /// <returns></returns>
        public IrrigationUnit UpdateIrrrigationUnit(String pName, String pIrrigationType,
                                                double pIrrigationEfficiency,
                                                List<Pair<DateTime, double>> pIrrigationList,
                                                double pSurface, List<Crop> pCropList,
                                                Bomb pBomb, Location pLocation)
        {
            IrrigationUnit lReturn = null;
            IrrigationUnit lIrrigationUnit = new IrrigationUnit(0, pName, pIrrigationType,
                                                pIrrigationEfficiency, pIrrigationList, pSurface,
                                                pCropList, pBomb, pLocation);
            lReturn = ExistIrrigationUnit(lIrrigationUnit);
            if(lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.IrrigationType = pIrrigationType;
                lReturn.IrrigationEfficiency = pIrrigationEfficiency;
                lReturn.IrrigationList = pIrrigationList;
                lReturn.Surface = pSurface;
                lReturn.CropList = pCropList;
                lReturn.Bomb = pBomb;
                lReturn.Location = pLocation;
            }
            return lReturn;
        }

        #endregion

        #endregion

        #region Language
        #endregion

        #region Localization

        #region City

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pPosition"></param>
        /// <returns></returns>
        public City FindCity(String pName, Position pPosition)
        {
            City lReturn = null;
            if(!String.IsNullOrEmpty(pName) && pPosition != null)
            {
                foreach (City item in this.CityList)
                {
                    if(item.Name.Equals(pName) && item.Position.Equals(pPosition))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pCity"></param>
        /// <returns></returns>
        public City ExistCity (City pCity)
        {
            City lReturn = null;
            foreach (City item in this.CityList)
            {
                if(item.Equals(pCity))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pPosition"></param>
        /// <returns></returns>
        public City AddCity(String pName, Position pPosition)
        {
            City lReturn = null;
            long lIdCity = this.CityList.Count();
            City lCity = new City(lIdCity, pName, pPosition);
            lReturn = ExistCity(lCity);
            if (lReturn == null)
            {
                this.CityList.Add(lCity);
                lReturn = lCity;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pCountry"></param>
        /// <param name="pCity"></param>
        /// <returns></returns>
        public City AddCityToCountry(Country pCountry, City pCity)
        {
            City lReturn = null;
            lReturn = ExistCity(pCity);
            if (lReturn != null)
            {
                pCountry.AddCity(pCity);
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pPosition"></param>
        /// <returns></returns>
        public City UpdateCity(String pName, Position pPosition)
        {
            City lReturn = null;
            City lCity = new City(0, pName, pPosition);
            lReturn = ExistCity(lCity);
            if(lReturn != null)
            {
                lReturn.Name= pName;
                lReturn.Position = pPosition;
            }
            return lReturn;
        }

        #endregion

        #region Country

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pCountry"></param>
        /// <returns></returns>
        public Country ExistCountry(Country pCountry)
        {
            Country lReturn = null;
            foreach (Country item in this.CountryList)
            {
                if (item.Equals(pCountry))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pCapital"></param>
        /// <param name="pCityList"></param>
        /// <param name="pRegionList"></param>
        /// <returns></returns>
        public Country AddCountry(String pName, City pCapital, List<City> pCityList,
                                List<Region> pRegionList)
        {
            Country lReturn = null;
            long lIdCountry = this.CountryList.Count();
            Country lCountry = null;

            if (pCityList == null || pRegionList == null)
            {
                lCountry = new Country(lIdCountry, pName, pCapital);
            }
            else
            {
                lCountry = new Country(lIdCountry, pName, pCapital, pCityList, pRegionList);
            }
            lCountry.AddCity(pCapital);
            if (ExistCountry(lCountry) == null)
            {
                this.CountryList.Add(lCountry);
                lReturn = lCountry;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pCapital"></param>
        /// <param name="pCityList"></param>
        /// <param name="pRegionList"></param>
        /// <returns></returns>
        public Country UpdateCountry(String pName, City pCapital, List<City> pCityList,
                                List<Region> pRegionList)
        {
            Country lReturn = null;
            Country lCountry = new Country(0, pName, pCapital, pCityList, pRegionList);
            lReturn = ExistCountry(lCountry);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Capital = pCapital;
                lReturn.CityList = pCityList;
                lReturn.RegionList = pRegionList;
            }
            return lReturn;
        }

        #endregion

        #region Farm

        /// <summary>
        /// TODO Add despription
        /// </summary>
        /// <param name="pFarm"></param>
        /// <returns></returns>
        public Farm ExistFarm(Farm pFarm)
        {
            Farm lReturn = null;
            foreach (Farm item in this.FarmList)
            {
                if(item.Equals(pFarm))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pAddress"></param>
        /// <param name="pPhone"></param>
        /// <param name="pLocation"></param>
        /// <param name="pHas"></param>
        /// <param name="pSoilList"></param>
        /// <param name="pBombList"></param>
        /// <param name="pWeatherStation"></param>
        /// <param name="pUser"></param>
        /// <param name="pIrrigationUnitList"></param>
        /// <returns></returns>
        public Farm AddFarm(String pName, String pAddress, String pPhone, 
                        Location pLocation, int pHas, List<Soil> pSoilList,
                        List<Bomb> pBombList, WeatherStation pWeatherStation,
                        User pUser, List<IrrigationUnit> pIrrigationUnitList)
        {
            Farm lReturn = null;
            long lIdFarm = this.FarmList.Count();
            Farm lFarm = new Farm(lIdFarm, pName, pAddress, pPhone,
                            pLocation, pHas, pSoilList, pBombList,
                            pWeatherStation, pUser, pIrrigationUnitList);
            if(ExistFarm(lFarm) == null)
            {
                this.FarmList.Add(lFarm);
                lReturn = lFarm;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pAddress"></param>
        /// <param name="pPhone"></param>
        /// <param name="pLocation"></param>
        /// <param name="pHas"></param>
        /// <param name="pSoilList"></param>
        /// <param name="pBombList"></param>
        /// <param name="pWeatherStation"></param>
        /// <param name="pUser"></param>
        /// <param name="pIrrigationUnitList"></param>
        /// <returns></returns>
        public Farm UpdateFarm(String pName, String pAddress, String pPhone,
                        Location pLocation, int pHas, List<Soil> pSoilList,
                        List<Bomb> pBombList, WeatherStation pWeatherStation,
                        User pUser, List<IrrigationUnit> pIrrigationUnitList)
        {
            Farm lReturn = null;
            Farm lFarm = new Farm(0, pName, pAddress, pPhone,
                            pLocation, pHas, pSoilList, pBombList,
                            pWeatherStation, pUser, pIrrigationUnitList);
            lReturn = ExistFarm(lFarm);
            if(lReturn != null)
            {
                lReturn.Name= pName;
                lReturn.Address = pAddress;
                lReturn.Phone = pPhone;
                lReturn.Location = pLocation;
                lReturn.Has = pHas;
                lReturn.SoilList = pSoilList;
                lReturn.BombList = pBombList;
                lReturn.WeatherStation = pWeatherStation;
                lReturn.User = pUser;
                lReturn.IrrigationUnitList = pIrrigationUnitList;
            }
            return lReturn;
        }

        #endregion

        #region Location

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pLocation"></param>
        /// <returns></returns>
        public Location ExistLocation(Location pLocation)
        {
            Location lReturn = null;
            if(pLocation != null)
            {
                foreach (Location item in this.LocationList)
                {
                    if(item.Equals(pLocation))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pPosition"></param>
        /// <param name="pCountry"></param>
        /// <param name="pRegion"></param>
        /// <param name="pCity"></param>
        /// <returns></returns>
        public Location AddLocation(Position pPosition, Country pCountry, 
                            Region pRegion, City pCity)
        {
            Location lReturn = null;
            long lIdLocation = this.LocationList.Count();
            Location lLocation = new Location(lIdLocation, pPosition, pCountry, 
                                              pRegion, pCity);
            if (ExistLocation(lLocation) == null)
            {
                this.LocationList.Add(lLocation);
                lReturn = lLocation;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pPosition"></param>
        /// <param name="pCountry"></param>
        /// <param name="pRegion"></param>
        /// <param name="pCity"></param>
        /// <returns></returns>
        public Location UpdateLocation(Position pPosition, Country pCountry,
                            Region pRegion, City pCity)
        {
            Location lReturn = null;            
            Location lLocation = new Location(0, pPosition, pCountry,
                                              pRegion, pCity);
            lReturn = ExistLocation(lLocation);
            if(lReturn != null)
            {
                lReturn.Position = pPosition;
                lReturn.Country = pCountry;
                lReturn.Region = pRegion;
                lReturn.City = pCity;
            }
            return lReturn;
        }

        #endregion

        #region Region

        /// <summary>
        /// If Region Exists in List return the Region, else null
        /// </summary>
        /// <param name="pRegionList"></param>
        /// <returns></returns>
        public Region ExistRegion(Region pRegion)
        {
            Region lReturn = null;
            if (pRegion != null)
            {
                foreach (Region item in this.RegionList)
                {
                    if (item.Equals(pRegion))
                    {
                        lReturn = item;
                        break;
                    }
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
            List<EffectiveRain> pEffectiveRainList, List<Specie> pSpecieList)
        {
            Region lReturn = null;
            int lIDRegion = this.RegionList.Count();
            Region lRegion = null;

            if (pEffectiveRainList == null || pSpecieList == null)
            {
                lRegion = new Region(lIDRegion, pName, pPosition);
            }
            else
            {
                lRegion = new Region(lIDRegion, pName, pPosition,
                         pEffectiveRainList, pSpecieList);
            }

            if (ExistRegion(lRegion) == null)
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
            if (lReturn != null)
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

        #region CropIrrigationWeather

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <returns></returns>
        public CropIrrigationWeather ExistCropIrrigationWeather(CropIrrigationWeather pCropIrrigationWeather)
        {
            CropIrrigationWeather lReturn = null;
            if(pCropIrrigationWeather != null)
            {
                foreach (CropIrrigationWeather item in this.CropIrrigationWeatherList)
                {
                    if(item.Equals(pCropIrrigationWeather))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pIrrigationUnit"></param>
        /// <param name="pCrop"></param>
        /// <param name="pMainWeatherStation"></param>
        /// <param name="pAlternativeWeatherStation"></param>
        /// <param name="pPredeterminatedIrrigationQuantity"></param>
        /// <param name="pPhenologicalStage"></param>
        /// <param name="pLocation"></param>
        /// <param name="pSowingDate"></param>
        /// <param name="pHarvestDate"></param>
        /// <param name="pSoil"></param>
        /// <returns></returns>
        public CropIrrigationWeather AddCropIrrigationWeather(IrrigationUnit pIrrigationUnit, Crop pCrop,
                                                    WeatherStation pMainWeatherStation, WeatherStation pAlternativeWeatherStation,
                                                    double pPredeterminatedIrrigationQuantity, PhenologicalStage pPhenologicalStage,
                                                    Location pLocation, DateTime pSowingDate, DateTime pHarvestDate, Soil pSoil)
        {
            CropIrrigationWeather lReturn = null;
            long lIdCropIrrigationWeather = this.CropIrrigationWeatherList.Count();
            CropIrrigationWeather lCropIrrigationWeather = new CropIrrigationWeather(lIdCropIrrigationWeather,
                                                    pIrrigationUnit, pCrop,
                                                    pMainWeatherStation, pAlternativeWeatherStation,
                                                    pPredeterminatedIrrigationQuantity, pPhenologicalStage,
                                                    pLocation, pSowingDate, pHarvestDate, pSoil);

            lReturn = ExistCropIrrigationWeather(lCropIrrigationWeather);
            if(lReturn == null)
            {
                this.CropIrrigationWeatherList.Add(lCropIrrigationWeather);
                lReturn = lCropIrrigationWeather;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pIrrigationUnit"></param>
        /// <param name="pCrop"></param>
        /// <param name="pMainWeatherStation"></param>
        /// <param name="pAlternativeWeatherStation"></param>
        /// <param name="pPredeterminatedIrrigationQuantity"></param>
        /// <param name="pPhenologicalStage"></param>
        /// <param name="pLocation"></param>
        /// <param name="pSowingDate"></param>
        /// <param name="pHarvestDate"></param>
        /// <param name="pSoil"></param>
        /// <returns></returns>
        public CropIrrigationWeather UpdateCropIrrigationWeather(IrrigationUnit pIrrigationUnit, Crop pCrop,
                                                    WeatherStation pMainWeatherStation, WeatherStation pAlternativeWeatherStation,
                                                    double pPredeterminatedIrrigationQuantity, PhenologicalStage pPhenologicalStage,
                                                    Location pLocation, DateTime pSowingDate, DateTime pHarvestDate, Soil pSoil)
        {
            CropIrrigationWeather lReturn = null;
            CropIrrigationWeather lCropIrrigationWeather = new CropIrrigationWeather(0,
                                                    pIrrigationUnit, pCrop,
                                                    pMainWeatherStation, pAlternativeWeatherStation,
                                                    pPredeterminatedIrrigationQuantity, pPhenologicalStage,
                                                    pLocation, pSowingDate, pHarvestDate, pSoil);
            lReturn = ExistCropIrrigationWeather(lCropIrrigationWeather);
            if(lReturn != null)
            {
                lReturn.IrrigationUnit = pIrrigationUnit;
                lReturn.Crop = pCrop;
                lReturn.MainWeatherStation = pMainWeatherStation;
                lReturn.AlternativeWeatherStation = pAlternativeWeatherStation;
                lReturn.PredeterminatedIrrigationQuantity = pPredeterminatedIrrigationQuantity;
                lReturn.PhenologicalStage = pPhenologicalStage;
                lReturn.Location = pLocation;
                lReturn.SowingDate = pSowingDate;
                lReturn.HarvestDate = pHarvestDate;
                lReturn.Soil = pSoil;
            }
            return lReturn;
        }

        /// <summary>
        /// Add to the system a new CropIrrigationWeather
        /// Aditionaly create a cropIrrigationWeatherRecord for this CropIrrigationWeather
        /// and add the first DailyRecord
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <returns></returns>
        public CropIrrigationWeather AddCropIrrigationWeatherRecord(CropIrrigationWeather pCropIrrigationWeather) 
        {
            CropIrrigationWeather lReturn = null;
            CropIrrigationWeatherRecord lCropIrrigationWeatherRecord;
            List<EffectiveRain> lEffectiveRain;
            double bhi;
            DateTime lSowingDate;
            try
            {

                //Create the cropIrrigationWeatherRecord for the CropIrrigationWeather
                lCropIrrigationWeatherRecord = new CropIrrigationWeatherRecord();

                //Get Effective Rain List from Region
                lEffectiveRain = this.GetEffectiveRainList(pCropIrrigationWeather.IrrigationUnit.Location.Region);

                lCropIrrigationWeatherRecord.EffectiveRain = lEffectiveRain;
                lCropIrrigationWeatherRecord.CropIrrigationWeather = pCropIrrigationWeather;

                //Get Initial Hidric Balance
                bhi = pCropIrrigationWeather.GetInitialHidricBalance();
                lCropIrrigationWeatherRecord.HydricBalance = bhi;

                pCropIrrigationWeather.CropIrrigationWeatherRecord = lCropIrrigationWeatherRecord;
                
                //Add to the system list 
                this.CropIrrigationWeatherList.Add(pCropIrrigationWeather);
                this.cropIrrigationWeatherRecordList.Add(lCropIrrigationWeatherRecord);
                
                //Create the initial registry
                lSowingDate = pCropIrrigationWeather.SowingDate;
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

        #endregion

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
                        lMainWeatherData = GetWeatherDataByWeatherStationAndDate(pCropIrrigationWeather.MainWeatherStation, pDateTime);
                        //Get Data Weather form Alternative Weather Station
                        lAlternativeWeatherData = GetWeatherDataByWeatherStationAndDate(pCropIrrigationWeather.AlternativeWeatherStation, pDateTime); 

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
                this.AddOrUpdateIrrigationDataToList(pCropIrrigationWeather, pDateTime, lQuantityOfWaterToIrrigate, false);
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
        ///// <param name="pRegionList"></param>
        ///// <param name="pSpecie"></param>
        ///// <returns></returns>
        //public PhenologicalStage GetPhenologicalStage(double pDegree, Region pRegionList, Specie pSpecie)
        //{
        //    PhenologicalStage lReturn = null;
        //    List<PhenologicalStage> lPhenologicalStageListByRegion = null;
        //    foreach (Pair<Region , List<PhenologicalStage >> lPair in this.PhenologicalStageList)
        //    {
        //        if (lPair != null && lPair.First.Equals(pRegionList))
        //        {
        //            lPhenologicalStageListByRegion = lPair.Second;
        //        }
        //    }

        //    IEnumerable<PhenologicalStage> query = lPhenologicalStageListByRegion.OrderBy(lPhenologicalStage => lPhenologicalStage.MinDegree);
        //    foreach(PhenologicalStage lPhenologicalStage in query)
        //    {
        //        if (lPhenologicalStage != null && lPhenologicalStage.Specie.Equals(pSpecie) && lPhenologicalStage.MinDegree <= pDegree && lPhenologicalStage.MaxDegree >= pDegree)
        //        {
        //            lReturn = lPhenologicalStage;
        //        }
        //    }
        //    return lReturn;

        //}


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

            foreach (DailyRecord lDailyrecord in pCropIrrigationWeatherRecord.DailyRecordList)
            {
                lReturn += lDailyrecord.ToString() + Environment.NewLine;
            }
            //Add all the messages and titles to print the daily records
            pCropIrrigationWeatherRecord.AddToPrintDailyRecords();
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

        #region WeatherData

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <param name="pWeatherStation"></param>
        /// <param name="pDateTime"></param>
        /// <returns></returns>
        public WeatherData GetWeatherDataByWeatherStationAndDate(WeatherStation pWeatherStation, DateTime pDateTime)
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
        public void AddWeatherDataToList(WeatherStation pWeatherStation, DateTime pDateTime,
            double pTemperature, double pSolarRadiation, double pTemMax,
            double pTemMin, double pEvapotranspiration)
        {
            
            try
            {
                WeatherData lData = new WeatherData(pWeatherStation, pDateTime,
                    pTemperature, pTemMax, pTemMin, pSolarRadiation, pEvapotranspiration);
                this.WeatherDataList.Add(lData);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in IrrigationSystem.addWeatherData " + e.Message);
                //TODO manage and log the exception
                throw e;
            }
            
        }

        #endregion

        #region WeatherStation

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pWeatherStation"></param>
        /// <returns></returns>
        public WeatherStation ExistWeatherStation (WeatherStation pWeatherStation)
        {
            WeatherStation lReturn = null;
            if(pWeatherStation != null)
            {
                foreach (WeatherStation item in this.WeatherStationList)
                {
                    if (item.Equals(pWeatherStation))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO Add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pModel"></param>
        /// <param name="pDateOfInstallation"></param>
        /// <param name="pDateOfService"></param>
        /// <param name="pUpdateTime"></param>
        /// <param name="pWirelessTransmission"></param>
        /// <param name="pLocation"></param>
        /// <param name="pGiveET"></param>
        /// <returns></returns>
        public WeatherStation AddWeatherStation (String pName, String pModel, DateTime pDateOfInstallation,
                                DateTime pDateOfService, DateTime pUpdateTime, int pWirelessTransmission,
                                Location pLocation, bool pGiveET)
        {
            WeatherStation lReturn = null;
            long lIdWeatherStation = this.WeatherStationList.Count();
            WeatherStation lWeatherStation = new WeatherStation(lIdWeatherStation,
                                pName, pModel, pDateOfInstallation, pDateOfService,
                                pUpdateTime, pWirelessTransmission, pLocation, pGiveET);
            if(ExistWeatherStation(lWeatherStation) == null)
            {
                this.WeatherStationList.Add(lWeatherStation);
                lReturn = lWeatherStation;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pModel"></param>
        /// <param name="pDateOfInstallation"></param>
        /// <param name="pDateOfService"></param>
        /// <param name="pUpdateTime"></param>
        /// <param name="pWirelessTransmission"></param>
        /// <param name="pLocation"></param>
        /// <param name="pGiveET"></param>
        /// <returns></returns>
        public WeatherStation UpdateWeatherStation(String pName, String pModel, DateTime pDateOfInstallation,
                                DateTime pDateOfService, DateTime pUpdateTime, int pWirelessTransmission,
                                Location pLocation, bool pGiveET)
        {
            WeatherStation lReturn = null;
            WeatherStation lWeatherStation = new WeatherStation(0, pName, pModel,
                                pDateOfInstallation, pDateOfService, pUpdateTime,
                                pWirelessTransmission, pLocation, pGiveET);
            lReturn = ExistWeatherStation(lWeatherStation);
            if(lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Model = pModel;
                lReturn.DateOfInstallation = pDateOfInstallation;
                lReturn.DateOfService = pDateOfService;
                lReturn.UpdateTime = pUpdateTime;
                lReturn.WirelessTransmission = pWirelessTransmission;
                lReturn.Location = pLocation;
                lReturn.GiveET = pGiveET;
            }
            return lReturn;
        }

        #endregion

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pIrrigationDate"></param>
        /// <param name="pQuantityOfWaterToIrrigate"></param>
        /// <param name="pIsExtraIrrigation"></param>
        /// <returns></returns>
        public void AddOrUpdateIrrigationDataToList(CropIrrigationWeather pCropIrrigationWeather,
            DateTime pIrrigationDate, double pQuantityOfWaterToIrrigate, bool pIsExtraIrrigation)
        {
            WaterInput lNewIrrigation = null;

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

        }


        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pDate"></param>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public void AddRainDataToList(CropIrrigationWeather pCropIrrigationWeather,
                                        DateTime pDate, double pInput)
        {
            WaterInput lNewIrrigation = null;
            try
            {
                lNewIrrigation = getIrrigationFromList(pCropIrrigationWeather, pDate);
                if (lNewIrrigation == null)
                {
                    Rain lNewRain = new Rain();
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

        }
        
        #endregion

        #endregion

        #region Overrides
        #endregion

    }
}