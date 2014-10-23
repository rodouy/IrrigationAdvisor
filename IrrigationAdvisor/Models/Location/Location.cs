using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Location
{
   
        /// <summary>
        /// Create: 2014-10-14
        /// Author: monicarle
        /// Description: 
        ///     Describes a location
        ///     
        /// References:
        ///     list of classes this class use
        ///     
        /// Dependencies:
        ///     list of classes is referenced by this class
        /// 
        /// TODO: 
        ///     UnitTest
        ///     
        /// -----------------------------------------------------------------
        /// Fields of Class:
        ///     - latidude double
        ///     - longitude double
        ///     - position <double,double>
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

        private double latitude;
        private double longitude;
        //private position Par<double ,double >;
        private Country country;

        private Region region;

        private City city;

        #endregion
        #region Properties
        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
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
        #endregion

        public Location() { }
    }
}