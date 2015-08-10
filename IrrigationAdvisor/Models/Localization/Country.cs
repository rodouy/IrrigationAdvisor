using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Water;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Localization
{
    /// <summary>
    /// Create: 2014-10-24
    /// Author: monicarle
    /// Description: 
    ///     Describes a country
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
    ///     - cityList List <Region>
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
        ///     - idCountry long
        ///     - name: the name of the country
        ///     - cityList List <Location>
        ///     - cityList List <Region>
        ///     - capital City
        ///     
        /// </summary>
        private long idCountry;
        private String name;
        private City capital;
        private List<City> cityList;
        private List<Region> regionList;

        #endregion

        #region Properties

        public long IdCountry
        {
            get { return idCountry; }
            set { idCountry = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
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
            this.IdCountry = 0;
            this.Name = "";
            this.Capital = new City();
            this.CityList = new List<City>();
            this.RegionList = new List<Region>();
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pIdCountry"></param>
        /// <param name="pName"></param>
        /// <param name="pCapital"></param>
        public Country(long pIdCountry, String pName, City pCapital)
        {
            this.IdCountry = pIdCountry;
            this.Name = pName;
            this.Capital = pCapital;
            this.CityList = new List<City>();
            this.RegionList = new List<Region>();
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pIdCountry"></param>
        /// <param name="pName"></param>
        /// <param name="pCapital"></param>
        /// <param name="pCityList"></param>
        /// <param name="pRegionList"></param>
        public Country(long pIdCountry, String pName, City pCapital, List<City> pCityList, 
                            List<Region> pRegionList)
        {
            this.IdCountry = pIdCountry;
            this.Name = pName;
            this.Capital = pCapital;
            this.CityList = pCityList;
            this.RegionList = pRegionList;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        #region City

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pCity"></param>
        /// <returns></returns>
        public City ExistCity(City pCity)
        {
            City lReturn = null;
            foreach (City item in this.CityList)
            {
                if (item.Equals(pCity))
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
        /// <param name="pCity"></param>
        /// <returns></returns>
        public City AddCity(City pCity)
        {
            City lReturn = null;
            if (ExistCity(pCity) == null)
            {
                this.CityList.Add(pCity);
                lReturn = pCity;
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
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Position = pPosition;
            }
            return lReturn;
        }
        
        #endregion

        #region Region

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pRegion"></param>
        /// <returns></returns>
        public Region ExistRegion(Region pRegion)
        {
            Region lReturn = null;
            foreach (Region item in this.RegionList)
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
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pPosition"></param>
        /// <param name="pEffectiveRainList"></param>
        /// <param name="pSpecieList"></param>
        /// <returns></returns>
        public Region AddRegion(Region pRegion)
        {
            Region lReturn = null;
            if (ExistRegion(pRegion) == null)
            {
                this.RegionList.Add(pRegion);
                lReturn = pRegion;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
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