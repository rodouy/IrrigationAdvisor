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
        private IrrigationCalculus irrigationCalculus;

        #endregion

        #region Security 

        private List<User> userList;

        #endregion

        #region Utitilities
        #endregion

        #region Water

        
        #endregion

        #region Weather

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
        
        #endregion

        #region Weather


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
            
            this.CropList = new List<Crop>();
            this.SoilList = new List<Soil>();
            
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
            this.IrrigationCalculus = new IrrigationCalculus();
            
            #endregion
            
            #region Security 

            this.UserList = new List<User>();

            #endregion

            #region Utitilities
            #endregion

            #region Water

            #endregion
            
            #region Weather
            
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

        #region Security
        #endregion

        #region Utitilities
        #endregion

        #region Water
        
        #endregion

        #region Weather

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pRegion"></param>
        /// <returns></returns>
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
        /// <param name="pCrop"></param>
        /// <returns></returns>
        private double calculateDegreeStageDifference(Stage oldStage, Stage newStage, Crop pCrop)
        {
            double oldDegree = 0;
            double newDegree = 0;
            double lReturn = 0;
            List<PhenologicalStage> lPhenologicalStageList;

            try
            {
                lPhenologicalStageList = pCrop.PhenologicalStageList;
                foreach (PhenologicalStage lPhenologicalStage in lPhenologicalStageList)
                {
                    if (lPhenologicalStage.Stage.Equals(oldStage))
                    {
                        oldDegree = lPhenologicalStage.GetAverageDegree();
                    }
                    if (lPhenologicalStage.Stage.Equals(newStage))
                    {
                        newDegree = lPhenologicalStage.GetAverageDegree();
                    }
                    if (newDegree != 0 && oldDegree != 0)
                    {
                        lReturn = newDegree - oldDegree;
                        break;
                    }
                }

            }
            catch (Exception)
            {
                
                throw;
            }
            return lReturn;
        }

        #endregion

        #endregion

        #region Public Methods

        #region Agriculture

        #region Crop

        /// <summary>
        /// Return the list of Crops for a Region
        /// </summary>
        /// <param name="pRegion"></param>
        /// <returns></returns>
        public List<Crop> FindCrop(Region pRegion)
        {
            List<Crop> lReturn = null;
            if(pRegion != null)
            {
                lReturn = new List<Crop>();
                foreach (Crop item in this.CropList)
                {
                    if(item.Region.Equals(pRegion))
                    {
                        lReturn.Add(item);
                    }
                }
                if(lReturn.Count == 0)
                {
                    lReturn = null;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Return the list of Crops for a Specie
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <returns></returns>
        public List<Crop> FindCrop(Specie pSpecie)
        {
            List<Crop> lReturn = null;
            if (pSpecie != null)
            {
                lReturn = new List<Crop>();
                foreach (Crop item in this.CropList)
                {
                    if (item.Specie.Equals(pSpecie))
                    {
                        lReturn.Add(item);
                    }
                }
                if (lReturn.Count == 0)
                {
                    lReturn = null;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Find Crop by Name and Specie
        /// Name and Specie are the argument for Crop Equals
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSpecie"></param>
        /// <returns></returns>
        public Crop FindCrop(Region pRegion, Specie pSpecie)
        {
            Crop lReturn = null;
            if (pRegion != null && pSpecie != null)
            {
                foreach (Crop item in this.CropList)
                {
                    if (item.Region.Equals(pRegion) && item.Specie.Equals(pSpecie))
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
        /// <param name="pRegion"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pCropCoefficient"></param>
        /// <param name="pStageList"></param>
        /// <param name="pPhenologicalStageList"></param>
        /// <param name="pDensity"></param>
        /// <param name="pMaxEvapotranspirationToIrrigate"></param>
        /// <param name="pMinEvapotranspirationToIrrigate"></param>
        /// <returns></returns>
        public Crop AddCrop(String pName, Region pRegion, Specie pSpecie, 
                        CropCoefficient pCropCoefficient, List<Stage> pStageList,
                        List<PhenologicalStage> pPhenologicalStageList, 
                        Double pDensity, Double pMaxEvapotranspirationToIrrigate, 
                        Double pMinEvapotranspirationToIrrigate)
        {
            Crop lReturn = null;
            int lCropId = this.CropList.Count();
            Crop lCrop = new Crop(lCropId, pName, pRegion, pSpecie, pCropCoefficient, pPhenologicalStageList,
                                pDensity, pMaxEvapotranspirationToIrrigate, pMinEvapotranspirationToIrrigate);
            lReturn = ExistCrop(lCrop);
            if (lReturn == null)
            {
                this.CropList.Add(lCrop);
                lReturn = lCrop;
            }
            return lReturn;
        }

        /// <summary>
        /// Return the Crop if added because do not exist, 
        ///     if exist in the list, return the crop from the list.
        /// </summary>
        /// <param name="pCrop"></param>
        /// <returns></returns>
        public Crop AddCrop(Crop pCrop)
        {
            Crop lReturn = null;
            int lCropId = this.CropList.Count();
            lReturn = ExistCrop(pCrop);
            if (lReturn == null)
            {
                pCrop.CropId = lCropId;
                this.CropList.Add(pCrop);
                lReturn = pCrop;
            }
            return lReturn;
        }

        /// <summary>
        /// Update the crop if exists in CropList, else return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pRegion"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pCropCoefficient"></param>
        /// <param name="pStageList"></param>
        /// <param name="pPhenologicalStageList"></param>
        /// <param name="pDensity"></param>
        /// <param name="pMaxEvapotranspirationToIrrigate"></param>
        /// <param name="pMinEvapotranspirationToIrrigate"></param>
        /// <returns></returns>
        public Crop UpdateCrop(String pName, Region pRegion, Specie pSpecie,
                        CropCoefficient pCropCoefficient, List<PhenologicalStage> pPhenologicalStageList, 
                        Double pDensity, Double pMaxEvapotranspirationToIrrigate, Double pMinEvapotranspirationToIrrigate)
        {
            Crop lReturn = null;
            Crop lCrop = new Crop(0, pName, pRegion, pSpecie, pCropCoefficient, pPhenologicalStageList,
                            pDensity, pMaxEvapotranspirationToIrrigate, pMinEvapotranspirationToIrrigate);
            lReturn = ExistCrop(lCrop);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Region = pRegion;
                lReturn.Specie = pSpecie;
                lReturn.CropCoefficient = pCropCoefficient;
                lReturn.UpdatePhenologicalStageList(pPhenologicalStageList);
                lReturn.Density = pDensity;
                lReturn.MaxEvapotranspirationToIrrigate = pMaxEvapotranspirationToIrrigate;
                lReturn.MinEvapotranspirationToIrrigate = pMinEvapotranspirationToIrrigate;
            }
            return lReturn;
        }

        /// <summary>
        /// Add Phenological Stage to Crop, if exist it return it.
        /// </summary>
        /// <param name="pCrop"></param>
        /// <param name="pInitialPhenologicalStage"></param>
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

        #region Phenological Stage

        /// <summary>
        /// Find A Phenological Stage by Region, Specie and Stage
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <param name="pStage"></param>
        /// <returns></returns>
        public PhenologicalStage FindPhenologicalStage(Region pRegion, 
                                            Specie pSpecie, Stage pStage)
        {
            PhenologicalStage lReturn = null;
            if (pRegion != null && pSpecie != null && pStage != null)
            {
                foreach (Crop lCropItem in this.CropList)
                {
                    if(lCropItem.Region.Equals(pRegion) && lCropItem.Specie.Equals(pSpecie))
                    {
                        foreach (PhenologicalStage item in lCropItem.PhenologicalStageList)
                        {
                            if (item.Stage.Equals(pStage))
                            {
                                lReturn = item;
                                break;
                            }
                        }
                    }
                }
            }
            return lReturn;
        }

        
        /// <summary>
        /// Adjustment of Phenology, calculating the degree stage difference
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pNewStage"></param>
        /// <param name="pDateTime"></param>
        public void AdjustmentPhenology(CropIrrigationWeather pCropIrrigationWeather, 
                                    Stage pNewStage, DateTime pDateTime)
        {
            Stage lActualStage;
            double lModification;
            foreach (CropIrrigationWeather lCropIrrigationWeather in this.CropIrrigationWeatherList)
            {
                if (lCropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    lActualStage = lCropIrrigationWeather.PhenologicalStage.Stage;
                    lModification = calculateDegreeStageDifference(lActualStage, pNewStage, pCropIrrigationWeather.Crop);
                    lCropIrrigationWeather.AdjustmentPhenology(pNewStage, pDateTime, lModification);
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
            long lIrrigationUnitId = this.irrigationUnitList.Count();
            IrrigationUnit lIrrigationUnit = new IrrigationUnit(lIrrigationUnitId, pName, pIrrigationType,
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

        /// <summary>
        /// TODO ExistLanguage description
        /// </summary>
        /// <param name="pLanguage"></param>
        /// <returns></returns>
        public Language.Language ExistLanguage(Language.Language pLanguage)
        {
            Language.Language lReturn = null;
            foreach (Language.Language item in this.LanguageList)
            {
                if(item.Equals(pLanguage))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO AddLanguage description
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public Language.Language AddLanguage(String pName)
        {
            Language.Language lReturn = null;
            long lLanguageId = this.LanguageList.Count();
            Language.Language lLanguage = new Language.Language(lLanguageId, pName);
            lReturn = ExistLanguage(lLanguage);
            if(lReturn == null)
            {
                this.LanguageList.Add(lLanguage);
                lReturn = lLanguage;
            }
            return lReturn;
        }

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
            long lCityId = this.CityList.Count();
            City lCity = new City(lCityId, pName, pPosition);
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
        /// Find Country by Name, if not exists, return null
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public Country FindCountry(String pName)
        {
            Country lReturn = null;
            if(!String.IsNullOrEmpty(pName))
            {
                foreach (Country item in this.CountryList)
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
        /// If Country exist in List return the Country, 
        /// else return null
        /// </summary>
        /// <param name="pCountry"></param>
        /// <returns></returns>
        public Country ExistCountry(Country pCountry)
        {
            Country lReturn = null;
            if (pCountry != null)
            {
                foreach (Country item in this.CountryList)
                {
                    if (item.Equals(pCountry))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a new Country and return it, if exists returns null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pCapital"></param>
        /// <param name="pLanguage"></param>
        /// <param name="pCityList"></param>
        /// <param name="pRegionList"></param>
        /// <returns></returns>
        public Country AddCountry(String pName, City pCapital, 
                                Language.Language pLanguage,
                                List<City> pCityList, List<Region> pRegionList)
        {
            Country lReturn = null;
            long lIdCountry = this.CountryList.Count();
            Country lCountry = null;

            if (!String.IsNullOrEmpty(pName) && pCapital != null)
            {
                if (pCityList == null || pRegionList == null)
                {
                    lCountry = new Country(lIdCountry, pName, pLanguage, pCapital);
                }
                else
                {
                    lCountry = new Country(lIdCountry, pName, pLanguage, pCapital,
                                            pCityList, pRegionList);
                }
                //Add Capital city to the list in Country, if exists will not repeat
                lCountry.AddCity(pCapital);
                if (ExistCountry(lCountry) == null)
                {
                    this.CountryList.Add(lCountry);
                    lReturn = lCountry;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Update Country Name, Language, Capital City, CityList, RegionList
        /// if not exist in list, return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pCapital"></param>
        /// <param name="pLanguage"></param>
        /// <param name="pCityList"></param>
        /// <param name="pRegionList"></param>
        /// <returns></returns>
        public Country UpdateCountry(String pName, City pCapital, 
                                Language.Language pLanguage, 
                                List<City> pCityList, List<Region> pRegionList)
        {
            Country lReturn = null;
            Country lCountry = new Country(0, pName, pLanguage, pCapital, pCityList, pRegionList);
            lReturn = ExistCountry(lCountry);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Language = pLanguage;
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
        /// Add Crop Irrigation Weather to System list
        /// </summary>
        /// <param name="pIrrigationUnit"></param>
        /// <param name="pCrop"></param>
        /// <param name="pMainWeatherStation"></param>
        /// <param name="pAlternativeWeatherStation"></param>
        /// <param name="pPredeterminatedIrrigationQuantity"></param>
        /// <param name="pLocation"></param>
        /// <param name="pSoil"></param>
        /// <returns></returns>
        public CropIrrigationWeather AddCropIrrigationWeather(IrrigationUnit pIrrigationUnit, 
                                                    Crop pCrop,
                                                    WeatherStation pMainWeatherStation, 
                                                    WeatherStation pAlternativeWeatherStation,
                                                    Double pPredeterminatedIrrigationQuantity, 
                                                    Location pLocation, Soil pSoil)
        {
            CropIrrigationWeather lReturn = null;
            long lCropIrrigationWeatherId = this.CropIrrigationWeatherList.Count();
            CropIrrigationWeather lCropIrrigationWeather = new CropIrrigationWeather();
            lCropIrrigationWeather.CropIrrigationWeatherId = this.CropIrrigationWeatherList.Count();
            lCropIrrigationWeather.IrrigationUnit = pIrrigationUnit;
            lCropIrrigationWeather.Crop= pCrop;
            lCropIrrigationWeather.MainWeatherStation=pMainWeatherStation;
            lCropIrrigationWeather.AlternativeWeatherStation= pAlternativeWeatherStation;
            lCropIrrigationWeather.PredeterminatedIrrigationQuantity=pPredeterminatedIrrigationQuantity;
            lCropIrrigationWeather.Location=pLocation;
            lCropIrrigationWeather.Soil= pSoil;
            
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
        /// <param name="pInitialPhenologicalStage"></param>
        /// <param name="pLocation"></param>
        /// <param name="pSowingDate"></param>
        /// <param name="pHarvestDate"></param>
        /// <param name="pSoil"></param>
        /// <returns></returns>
        public CropIrrigationWeather UpdateCropIrrigationWeather(IrrigationUnit pIrrigationUnit, Crop pCrop,
                                                    WeatherStation pMainWeatherStation, WeatherStation pAlternativeWeatherStation,
                                                    double pPredeterminatedIrrigationQuantity, 
                                                    Location pLocation, Soil pSoil)
        {
            CropIrrigationWeather lReturn = null;
            CropIrrigationWeather lCropIrrigationWeather = new CropIrrigationWeather();
            lCropIrrigationWeather.IrrigationUnit = pIrrigationUnit;
            lCropIrrigationWeather.Crop = pCrop;
            lCropIrrigationWeather.MainWeatherStation = pMainWeatherStation;
            lCropIrrigationWeather.AlternativeWeatherStation = pAlternativeWeatherStation;
            lCropIrrigationWeather.PredeterminatedIrrigationQuantity = pPredeterminatedIrrigationQuantity;
            lCropIrrigationWeather.Location= pLocation;
            lCropIrrigationWeather.Soil = pSoil;
                                                    
            lReturn = ExistCropIrrigationWeather(lCropIrrigationWeather);
            if(lReturn != null)
            {
                lReturn.IrrigationUnit = pIrrigationUnit;
                lReturn.Crop = pCrop;
                lReturn.MainWeatherStation = pMainWeatherStation;
                lReturn.AlternativeWeatherStation = pAlternativeWeatherStation;
                lReturn.PredeterminatedIrrigationQuantity = pPredeterminatedIrrigationQuantity;
                lReturn.Location = pLocation;
                lReturn.Soil = pSoil;

            }
            return lReturn;
        }

        /// <summary>
        /// Add to the system a new CropIrrigationWeather
        /// Inicialize CropIrrigationWeather
        /// and add the first DailyRecord
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <returns></returns>
        public CropIrrigationWeather InicializeCropIrrigationWeather(CropIrrigationWeather pCropIrrigationWeather,
                                                                    PhenologicalStage pInitialPhenologicalStage, 
                                                                    DateTime pSowingDate, DateTime pHarvestDate) 
        {
            CropIrrigationWeather lReturn = null;
            //CropIrrigationWeatherRecord lCropIrrigationWeatherRecord;
            List<EffectiveRain> lEffectiveRain;
            double lHydricBalance;
            try
            {

                //Create the cropIrrigationWeatherRecord for the CropIrrigationWeather
                //lCropIrrigationWeatherRecord = new CropIrrigationWeatherRecord();

                pCropIrrigationWeather.PhenologicalStage = pInitialPhenologicalStage;
                pCropIrrigationWeather.SowingDate = pSowingDate;
                pCropIrrigationWeather.HarvestDate = pHarvestDate;

                //Get Effective Rain List from Region
                lEffectiveRain = this.getEffectiveRainList(pCropIrrigationWeather.IrrigationUnit.Location.Region);
                pCropIrrigationWeather.EffectiveRainList = lEffectiveRain;
                
                //Get Initial Hidric Balance
                lHydricBalance = pCropIrrigationWeather.GetInitialHydricBalance();
                pCropIrrigationWeather.HydricBalance = lHydricBalance;

                
                //Create the initial registry
                this.addDailyRecordToList(pCropIrrigationWeather, pSowingDate, "Initial registry");
                
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
        /// Colect the weather data, lIrrigationItem data and lRainItem data and derive the cretion of a new daily record
        /// This method verify the need of lIrrigationItem, and then recreate the daily record
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pDateTime"></param>
        /// <param name="pObservations"></param>
        /// <returns></returns>
        public bool addDailyRecordToList(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime, String pObservations)
        {
            bool lReturn = false;
            WeatherData lWeatherData = null;
            
            try
            {
                //Controlo que la CropIrrigationWeather exista y la fecha no sean null
                if (this.CropIrrigationWeatherList.Contains(pCropIrrigationWeather) && pDateTime != null)
                {
                    //Get Data Weather for the available Weather Station (Main or Alternative)
                    lWeatherData = pCropIrrigationWeather.GetWeatherDataFromAvailableWeatherStation(pDateTime);

                    // Si hay datos de estacion meteorologica puedo seguir
                    if (lWeatherData != null)
                    {
                        if(pCropIrrigationWeather.CalculusMethodForPhenologicalAdjustment.Equals(
                                            Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays))
                        {
                            pCropIrrigationWeather.AddDailyRecordAccordingGrowinDegreeDays(pDateTime, pObservations);
                        }

                        if (pCropIrrigationWeather.CalculusMethodForPhenologicalAdjustment.Equals(
                                            Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing))
                        {
                            pCropIrrigationWeather.AddDailyRecordAccordingDaysAfterSowing(pDateTime, pObservations);
                        }

                        //Luego de que agrego un registro verifico si hay que regar.
                        //Si es asi se agrega el riego a la lista y se reingresa el registro diario. 
                        this.verifyNeedForIrrigation(pCropIrrigationWeather, pDateTime);
                    }
                    else 
                    {
                        
                        pCropIrrigationWeather.AddDailyRecordAccordingDaysAfterSowing(pDateTime, pObservations);
                        
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
            Pair<double, Utils.WaterInputType> lNeedForIrrigationPair;
            double lQuantityOfWaterToIrrigate;
            Utils.WaterInputType lTypeOfIrrigation;

            lNeedForIrrigationPair = this.IrrigationCalculus.HowMuchToIrrigate(pCropIrrigationWeather);
            lQuantityOfWaterToIrrigate = lNeedForIrrigationPair.First;
            lTypeOfIrrigation = lNeedForIrrigationPair.Second;

            if (lQuantityOfWaterToIrrigate > 0)
            {
                this.AddOrUpdateIrrigationDataToList(pCropIrrigationWeather, pDateTime, lNeedForIrrigationPair, false);
                this.addDailyRecordToList(pCropIrrigationWeather, pDateTime, pDateTime.ToShortDateString());
            }
        }

        

        #endregion

        #region Security 
        #endregion

        #region Utitilities

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <returns></returns>
        public String printDailyRecordsList(CropIrrigationWeather pCropIrrigationWeather)
        {
            String lReturn = Environment.NewLine + "DAILY RECORDS" + Environment.NewLine ;
            lReturn += Environment.NewLine +Environment.NewLine;

            foreach (DailyRecord lDailyrecord in pCropIrrigationWeather.DailyRecordList)
            {
                lReturn += lDailyrecord.ToString() + Environment.NewLine;
            }
            //Add all the messages and titles to print the daily records
            pCropIrrigationWeather.AddToPrintDailyRecords();
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
            lReturn = printDailyRecordsList(pCropIrrigationWeather);
            return lReturn;
        }

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <returns></returns>
        public String printWeatherDataList(WeatherStation pWeatherStation)
        {
            String lReturn = Environment.NewLine + "WEATHER DATA" + Environment.NewLine;
            foreach (WeatherData lWeatherData in pWeatherStation.WeatherDataList)
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
        /// Return the WeatherData from WeatherStation and Date (depends on the hour)
        /// </summary>
        /// <param name="pWeatherStation"></param>
        /// <param name="pDateTime"></param>
        /// <returns></returns>
        public WeatherData GetWeatherDataByWeatherStationAndDate(WeatherStation pWeatherStation, DateTime pDateTime)
        {
            WeatherData lReturn = null;

            lReturn = pWeatherStation.FindWeatherData(pDateTime);

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
                WeatherData lWeatherData;
                lWeatherData = pWeatherStation.AddWeatherData(pDateTime, pTemperature, pSolarRadiation, pTemMax, pTemMin, pEvapotranspiration);
                if(lWeatherData == null)
                {
                    pWeatherStation.UpdateWeatherData(pDateTime, pTemperature, pSolarRadiation,
                                                        pTemMax, pTemMin, pEvapotranspiration);
                }
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
        /// Create a new Weather Station from parameters,
        /// If exist return null
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

            long lWeatherStationId = this.WeatherStationList.Count();
            List<WeatherData> lWeatherDataList = new List<WeatherData>();
            WeatherStation lWeatherStation = new WeatherStation(lWeatherStationId,
                                pName, pModel, pDateOfInstallation, pDateOfService,
                                pUpdateTime, pWirelessTransmission, pLocation, pGiveET,
                                lWeatherDataList);
            if(ExistWeatherStation(lWeatherStation) == null)
            {
                this.WeatherStationList.Add(lWeatherStation);
                lReturn = lWeatherStation;
            }

            return lReturn;
        }

        /// <summary>
        /// Update the weather station,
        /// if not exist, return null.
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pModel"></param>
        /// <param name="pDateOfInstallation"></param>
        /// <param name="pDateOfService"></param>
        /// <param name="pUpdateTime"></param>
        /// <param name="pWirelessTransmission"></param>
        /// <param name="pLocation"></param>
        /// <param name="pGiveET"></param>
        /// <param name="pWeatherDataList"></param>
        /// <returns></returns>
        public WeatherStation UpdateWeatherStation(String pName, String pModel, DateTime pDateOfInstallation,
                                DateTime pDateOfService, DateTime pUpdateTime, int pWirelessTransmission,
                                Location pLocation, bool pGiveET, List<WeatherData> pWeatherDataList)
        {
            WeatherStation lReturn = null;

            WeatherStation lWeatherStation = new WeatherStation(0, pName, pModel,
                                pDateOfInstallation, pDateOfService, pUpdateTime,
                                pWirelessTransmission, pLocation, pGiveET,
                                pWeatherDataList);
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
                lReturn.WeatherDataList = pWeatherDataList;
            }

            return lReturn;
        }

        #endregion

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pIrrigationDate"></param>
        /// <param name="pQuantityOfWaterToIrrigateAndTypeOfIrrigation"></param>
        /// <param name="pIsExtraIrrigation"></param>
        /// <returns></returns>
        public void AddOrUpdateIrrigationDataToList(CropIrrigationWeather pCropIrrigationWeather,
                                                    DateTime pIrrigationDate, 
                                                    Pair<double,  Utils.WaterInputType> pQuantityOfWaterToIrrigateAndTypeOfIrrigation, 
                                                    bool pIsExtraIrrigation)
        {
            Water.Irrigation lNewIrrigation = null;
            
            try
            {
                lNewIrrigation = pCropIrrigationWeather.GetIrrigation(pIrrigationDate);
                //If there is not a registry then it is created 
                //If there is an Irrigation Registry it is actualized 
                if (lNewIrrigation == null)
                {
                    lNewIrrigation = new Water.Irrigation();
                    lNewIrrigation.Date = pIrrigationDate;
                    if (pIsExtraIrrigation)
                    {
                        lNewIrrigation.ExtraInput = pQuantityOfWaterToIrrigateAndTypeOfIrrigation.First;
                        lNewIrrigation.ExtraDate = pIrrigationDate;
                    }
                    else
                    {
                        lNewIrrigation.Input = pQuantityOfWaterToIrrigateAndTypeOfIrrigation.First;
                        
                    }
                    // Set the type of lIrrigationItem. 
                    lNewIrrigation.Type = pQuantityOfWaterToIrrigateAndTypeOfIrrigation.Second;
                    pCropIrrigationWeather.IrrigationList.Add(lNewIrrigation);
                }
                else
                {
                    if (pIsExtraIrrigation)
                    {
                        lNewIrrigation.ExtraInput += pQuantityOfWaterToIrrigateAndTypeOfIrrigation.First;
                        lNewIrrigation.ExtraDate = pIrrigationDate;
                    }
                    else
                    {
                        lNewIrrigation.Input += pQuantityOfWaterToIrrigateAndTypeOfIrrigation.First;
                    }
                    // Override the type of lIrrigationItem. 
                    lNewIrrigation.Type = pQuantityOfWaterToIrrigateAndTypeOfIrrigation.Second;
                    
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
        public Rain  AddRainDataToList(CropIrrigationWeather pCropIrrigationWeather,
                                        DateTime pDate, double pInput)
        {
            Rain lNewRain = null;
            try
            {
                lNewRain = pCropIrrigationWeather.GetRain(pDate);
                if (lNewRain == null)
                {
                    lNewRain = new Rain();
                    lNewRain.Date = pDate;
                    lNewRain.Input = pInput;
                    pCropIrrigationWeather.RainList.Add(lNewRain);
                }
                else // If there is a Raub actualize the registry
                {
                    lNewRain.ExtraInput += pInput;
                    lNewRain.ExtraDate = pDate;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in IrrigationSystem.addIrrigationData " + e.Message);
                //TODO manage and log the exception
                throw e;
            }

            return lNewRain;

        }
        
        #endregion

        #endregion

        #region Overrides
        #endregion

    }
}