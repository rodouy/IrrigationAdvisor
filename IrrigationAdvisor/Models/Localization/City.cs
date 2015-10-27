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
    ///     Describes a city
    ///     
    /// References:
    ///     Position
    ///     
    /// Dependencies:
    ///     Country
    ///     Position
    /// 
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - cityId long
    ///     - name String
    ///     - position Position
    ///     City
    /// 
    /// Methods:
    ///     - City()      -- constructor
    ///     - City(name)  -- consturctor with parameters
    ///     - SetPosition(Position): bool
    /// 
    /// </summary>
    //[Serializable()]
    public class City
    {

        #region Consts
        #endregion

        #region Fields

        /// <summary>
        /// The fields are:
        ///     - cityId: identifier
        ///     - name: the name of the city
        ///     - position: the position of the city
        /// </summary>
        private long cityId;
        private String name;
        private long positionId;
        private long countryId;

        #endregion

        #region Properties

        
        public long CityId
        {
            get { return cityId; }
            set { cityId = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public long PositionId
        {
            get { return positionId; }
            set { positionId = value;}
        }

        public virtual Position Position
        {
            get;
            set;
        }

        public long CountryId
        {
            get { return countryId; }
            set { countryId = value; }
        }

        public virtual Country Country
        {
            get;
            set;
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor by default.
        /// </summary>
        /// <param name="name">Name of the region</param>
        /// <param name="location">Location of the region</param>
        public City()
        {
            this.CityId = 0;
            this.Name = "";
            this.PositionId = 0;
            this.Position = new Position();
            this.CountryId = 1;
            this.Country = new Country();
        }

        /// <summary>
        /// Constructor with all Parameters
        /// </summary>
        /// <param name="pCityId"></param>
        /// <param name="pName"></param>
        /// <param name="pPosition"></param>
        public City(long pCityId, String pName, Position pPosition,
                    Country pCountry)
        {
            this.CityId = pCityId;
            this.Name = pName;
            this.PositionId = pPosition.PositionId;
            this.Position = pPosition;
            this.CountryId = pCountry.CountryId;
            this.Country = pCountry;
        }

        #endregion

        #region Private Helpers

        #endregion

        #region Public Methods

        //TODO: create method "change position"

        
        #endregion

        #region Overrides
        // Different region for each class override
        /// <summary>
        /// Overrides equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            City lCity = obj as City;
            return (this.Name.Equals(lCity.Name) 
                && this.PositionId.Equals(lCity.PositionId));
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion

    }
}