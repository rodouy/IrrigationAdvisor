using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace IrrigationAdvisor.Models.Localization
{
   
        /// <summary>
        /// Create: 2014-10-24
        /// Author: monicarle
        /// Description: 
        ///     Describes a location defined by a Position
        /// Update: 2014-12-21
        /// Author: rodouy
        /// Description:
        ///     Serilizable class
        ///     
        /// References:
        ///     Position
        ///     Country
        ///     Region
        ///     City
        ///     
        /// Dependencies:
        ///     WeatherStation
        ///     City
        ///     Region
        ///     Soil
        ///     
        /// 
        /// TODO: 
        ///     UnitTest
        ///     
        /// -----------------------------------------------------------------
        /// Fields of Class:
        ///     - locationId long
        ///     - position Position <double,double>
        ///     - country Country
        ///     - region Region
        ///     - city City
        /// 
        /// Methods:
        ///     - Location()      -- constructor
        ///     - Location(name)  -- consturctor with parameters
        ///     - distance(origin<double,double>,destinity <double, double> ): km<double>
        ///     - newPosition(origin<double,double>,km<double>): position<double, double>
        ///     - minDistance(origin<double, double>, List<Location>): Location
        /// 
        /// </summary>
    
    public partial class Location
    {
        #region Const
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - locationId: location identifier
        ///     - position: the position of the Locatioin
        ///     - country: the country of the Location
        ///     - region: the region of the Location
        ///     - city: the city of the Location
        ///     
        /// </summary>
        
        private long locationId;
        private long positionId;
        private long countryId;
        private long regionId;
        private long cityId;

        #endregion

        #region Properties

        
        public long LocationId
        {
            get { return locationId; }
            set { locationId = value; }
        }

        public long PositionId
        {
            get { return positionId; }
            set { positionId = value; }
        }

        public long CountryId
        {
            get { return countryId; }
            set { countryId = value; }
        }

        public long RegionId
        {
            get { return regionId; }
            set { regionId = value; }
        }

        public long CityId
        {
            get { return cityId; }
            set { cityId = value; }
        }


        public virtual Position Position
        {
            get;
            set;
        }

        public virtual Country Country
        {
            get;
            set;
        }

        public virtual Region Region
        {
            get;
            set;
        }

        public virtual City City
        {
            get;
            set;
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Location()
        {
            this.LocationId = 0;
            this.PositionId = 0;
            this.CountryId = 0;
            this.RegionId = 0;
            this.CityId = 0;
        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pIdLocation"></param>
        /// <param name="pPosition"></param>
        /// <param name="pCountry"></param>
        /// <param name="pRegion"></param>
        /// <param name="pCity"></param>
        public Location(long pIdLocation, Position pPosition, 
            Country pCountry, Region pRegion, City pCity )
        {
            this.LocationId = pIdLocation;
            this.PositionId = pPosition.PositionId;
            this.CountryId = pCountry.CountryId;
            this.RegionId = pRegion.RegionId;
            this.CityId = pCity.CityId;
        }

        public Location(long pLocationId, long pPositionId,
            long pCountryId, long pRegionId, long pCityId)
        {
            this.LocationId = pLocationId;
            this.PositionId = pPositionId;
            this.CountryId = pCountryId;
            this.RegionId = pRegionId;
            this.CityId = pCityId;
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods


        public double GetDistance(Location pOrigin)
        {
            double lReturn = 0;
            return lReturn;
        }

        /// TODO distance, newPosition, mindistance
        ///     - distance(origin<double,double>,destinity <double, double> ): km<double>
        ///     - newPosition(origin<double,double>,km<double>): position<double, double>
        ///     - minDistance(origin<double, double>, List<Location>): Location
        
        #endregion

        #region Overrides
        // Different region for each class override

        /// <summary>
        /// Overrides equals, Position, Country
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            Location  lLocation = obj as Location;
            return this.Position.Equals(lLocation.Position) &&
                   this.Country.Equals(lLocation.Country);
        }

        public override int GetHashCode()
        {
            return this.Position.GetHashCode();
        }

        #endregion

    }
}