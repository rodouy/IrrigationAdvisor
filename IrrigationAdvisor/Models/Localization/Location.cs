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
        ///     - idLocation long
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
    //[Serializable()]
    public class Location
    {
        #region Const
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - idLocation: location identifier
        ///     - position: the position of the Locatioin
        ///     - country: the country of the Location
        ///     - region: the region of the Location
        ///     - city: the city of the Location
        ///     
        /// </summary>
        private long idLocation;
        private Position position;
        private Country country;
        private Region region;
        private City city;

        #endregion

        #region Properties

        public long IdLocation
        {
            get { return idLocation; }
            set { idLocation = value; }
        }

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

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Location()
        {
            this.IdLocation = 0;
            this.Position = new Position(0,0);
            this.Country = new Country();
            this.Region = new Region();
            this.City = new City();
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
            this.IdLocation = pIdLocation;
            this.Position = pPosition;
            this.Country = pCountry;
            this.Region = pRegion;
            this.City = pCity;
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