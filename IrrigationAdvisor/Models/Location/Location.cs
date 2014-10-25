using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace IrrigationAdvisor.Models.Location
{
   
        /// <summary>
        /// Create: 2014-10-14
        /// Author: monicarle
        /// Description: 
        ///     Describes a location defined by a Position
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
        /// 
    public class Location
    {
        #region Const
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - position: the position of the Locatioin
        ///     - country: the country of the Location
        ///     - region: the region of the Location
        ///     - city: the city of the Location
        ///     
        /// </summary>
        private Position position;
        private Country country;
        private Region region;
        private City city;

        #endregion

        #region Properties

        public Position Position
        {
            get { return position; }
            set { position = value; }
        }
        
        public Country Country
        {
            get { return country; }
            set { country = value; }
        }

        public Region Region
        {
            get { return region; }
            set { region = value; }
        }

        public City City
        {
            get { return city; }
            set { city = value; }
        }

        #endregion

        #region Construction
        public Location()
        {
            this.Position = new Position(0,0);
            this.Country = new Country();
            this.Region = new Region();
            this.City = new City ();

        }
        public Location(Position pPosition, 
            Country pCountry, Region pRegion, City pCity )
        {
            this.Position = pPosition;
            this.Country = pCountry;
            this.Region = pRegion;
            this.City = pCity;
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
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
            Location  lLocation = obj as Location;
            return this.Position.Equals(lLocation.Position);
        }

        public override int GetHashCode()
        {
            return this.Position.GetHashCode();
        }
        #endregion
    }
}