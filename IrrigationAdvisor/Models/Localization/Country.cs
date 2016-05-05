using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Water;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Language;

namespace IrrigationAdvisor.Models.Localization
{
    /// <summary>
    /// Create: 2014-10-24
    /// Author: monicarle
    /// Description: 
    ///     Describes a country.
    ///     The capital city gives the country position.
    ///     
    /// References:
    ///     City
    ///     Region
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String
    ///     - cityList List <Location>
    ///     - regionList List <Region>
    ///     - capital City
    ///     
    /// Methods:
    ///     - Country()      -- constructor
    ///     - Country(name)  -- consturctor with parameters
    ///     - SetCapital(City): bool
    ///     - add(City)
    /// 
    /// </summary>
    //[Serializable()]
    public class Country
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - countryId long
        ///     - name: the name of the country
        ///     - language: Language.Language
        ///     - capital City
        ///     - cityList: List<City>
        ///     - regionList: List<Region>
        ///     
        /// </summary>
        private long countryId;
        private String name;
        private Language.Language language;
        private City capital;
        private List<City> cityList;
        private List<Region> regionList;

        #endregion

        #region Properties

        public long CountryId
        {
            get { return countryId; }
            set { countryId = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

<<<<<<< HEAD
        public Language.Language Language
=======
        public long LanguageId
        {
            get { return languageId; }
            set { languageId = value; }
        }
        public virtual Language.Language Language
        {
            get;
            set;
        }

        public long CapitalId
>>>>>>> 58290beb60242c969fa5a51c8d9de37319de5d7c
        {
            get { return language; }
            set { language = value; }
        }

        public City Capital
        {
            get { return capital; }
            set { capital = value; }
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

        #endregion

        #region Construction

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="name">Name of the country</param>
        /// <param name="location">Location of the country</param>
        public Country()
        {
            this.CountryId = 0;
<<<<<<< HEAD
            this.Name = "";
            this.Capital = new City();
=======
            this.Name = "NoName";
            this.LanguageId = 1;
            this.CapitalId = 1;
            this.CityList = new List<City>();
            this.RegionList = new List<Region>();
        }

        public Country(long pCountryId, String pName, 
                        long pLanguageId, 
                        long pCapitalId)
        {
            this.CountryId = pCountryId;
            this.Name = pName;
            this.LanguageId = pLanguageId;
            this.CapitalId = pCapitalId;
>>>>>>> 58290beb60242c969fa5a51c8d9de37319de5d7c
            this.CityList = new List<City>();
            this.RegionList = new List<Region>();
        }

        /// <summary>
<<<<<<< HEAD
        /// TODO add description
        /// </summary>
        /// <param name="pCountryId"></param>
        /// <param name="pName"></param>
        /// <param name="pLanguage"></param>
        /// <param name="pCapital"></param>
        public Country(long pCountryId, String pName, Language.Language pLanguage, City pCapital)
        {
            this.CountryId = pCountryId;
            this.Name = pName;
            this.Language = pLanguage;
=======
        /// Constructor with parameters
        /// </summary>
        /// <param name="pCountryId"></param>
        /// <param name="pName"></param>
        /// <param name="pLanguageId"></param>
        /// <param name="pCapitalId"></param>
        public Country(long pCountryId, String pName, 
                        Language.Language pLanguage, City pCapital)
        {
            this.CountryId = pCountryId;
            this.Name = pName;
            this.LanguageId = pLanguage.LanguageId;
            this.Language = pLanguage;
            this.CapitalId = pCapital.CityId;
>>>>>>> 58290beb60242c969fa5a51c8d9de37319de5d7c
            this.Capital = pCapital;
            this.CityList = new List<City>();
            if(pCapital != null)
            {
                this.CityList.Add(pCapital);
            }
            this.RegionList = new List<Region>();
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pCountryId"></param>
        /// <param name="pName"></param>
        /// <param name="pLanguage"></param>
        /// <param name="pCapital"></param>
        /// <param name="pCityList"></param>
        /// <param name="pRegionList"></param>
        public Country(long pCountryId, String pName, Language.Language pLanguage, City pCapital, List<City> pCityList, 
                            List<Region> pRegionList)
        {
            this.CountryId = pCountryId;
            this.Name = pName;
            this.Language = pLanguage;
            this.Capital = pCapital;
            this.CityList = pCityList;
            this.RegionList = pRegionList;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        #region Language

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pLanguage"></param>
        /// <returns></returns>
        public bool ChangeLanguage(Language.Language pLanguage)
        {
            bool lResult = false;
            if (pLanguage != null)
            {
                this.Language = pLanguage;
                lResult = true;
            }
            return lResult;
        }

        #endregion

        #region City

        /// <summary>
        /// If City exist in List return the City, 
        /// else return null
        /// </summary>
        /// <param name="pCity"></param>
        /// <returns></returns>
        public City ExistCity(City pCity)
        {
            City lReturn = null;
            if (pCity != null)
            {
                foreach (City item in this.CityList)
                {
                    if (item.Equals(pCity))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }
        
        /// <summary>
        /// Add a new City and return it, if exists returns null
        /// </summary>
        /// <param name="pCity"></param>
        /// <returns></returns>
        public City AddCity(City pCity)
        {
            City lReturn = null;
            if (pCity != null)
            {
                if (ExistCity(pCity) == null)
                {
                    this.CityList.Add(pCity);
                    lReturn = pCity;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Update City Name and Position, if not exist in list, return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pPosition"></param>
        /// <returns></returns>
<<<<<<< HEAD
        public City UpdateCity(String pName, Position pPosition)
        {
            City lReturn = null;
            City lCity = new City(0, pName, pPosition);
=======
        public City UpdateCity(String pName, Position pPosition,
                                Country pCountry)
        {
            City lReturn = null;
            City lCity = new City(0, pName, pPosition, pCountry);
>>>>>>> 58290beb60242c969fa5a51c8d9de37319de5d7c
            lReturn = ExistCity(lCity);
            if (lReturn != null)
            {
                lReturn.Name = pName;
<<<<<<< HEAD
                lReturn.Position = pPosition;
=======
                lReturn.PositionId = pPosition.PositionId;
                lReturn.Position = pPosition;
                lReturn.CountryId = pCountry.CountryId;
                lReturn.Country = pCountry;
>>>>>>> 58290beb60242c969fa5a51c8d9de37319de5d7c
            }
            return lReturn;
        }
        
        #endregion

        #region Region

        /// <summary>
        /// If Region exist in List return the Region, 
        /// else return null
        /// </summary>
        /// <param name="pRegion"></param>
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
        /// Add a new Region and return it, if exists returns null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pPosition"></param>
        /// <param name="pEffectiveRainList"></param>
        /// <param name="pSpecieList"></param>
        /// <returns></returns>
        public Region AddRegion(Region pRegion)
        {
            Region lReturn = null;
            if (pRegion != null)
            {
                if (ExistRegion(pRegion) == null)
                {
                    this.RegionList.Add(pRegion);
                    lReturn = pRegion;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Update Region, if not exists return null.
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

        #region Overrides

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            Country lCountry = obj as Country;
            return this.Name.Equals(lCountry.Name)
                && this.Capital.Equals(lCountry.Capital);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        #endregion

    }
}