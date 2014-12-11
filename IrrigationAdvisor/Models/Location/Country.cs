using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Location
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
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String
    ///     - cities List <Location>
    ///     - cities List <Region>
    ///     - capital City
    ///     
    /// Methods:
    ///     - Country()      -- constructor
    ///     - Country(name)  -- consturctor with parameters
    ///     - SetCapital(City): bool
    ///     - add(City)
    /// 
    /// </summary>
    public class Country
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - id int
        ///     - name: the name of the country
        ///     - cities List <Location>
        ///     - cities List <Region>
        ///     - capital City
        ///     
        /// </summary>
        private int idCountry;
        private String name;
        private City capital;
        private List<City> cities;
        private List<Region> regions;

        #endregion

        #region Properties

        public int IdCountry
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

        public List<City> Cities
        {
            get { return cities; }
            set { cities = value; }
        }

        public List<Region> Regions
        {
            get { return regions; }
            set { regions = value; }
        }

        #endregion

        #region Construction
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Name of the country</param>
        /// <param name="location">Location of the country</param>
        public Country()
        {
            this.IdCountry = 0;
            this.Name = "";
            this.Capital = new City();
            this.Cities = new List<City>();
            this.Regions = new List<Region>();
        }
        public Country(int pIdCountry, String pName, City pCapital, List<City> pCities, List<Region> pRegion)
        {
            this.IdCountry = pIdCountry;
            this.Name = pName;
            this.Capital = pCapital;
            this.Cities = pCities;
            this.Regions = pRegion;
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
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