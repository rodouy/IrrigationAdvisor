using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Location
{
    /// <summary>
    /// Create: 2014-10-14
    /// Author: rodouy - monicarle
    /// Description: 
    ///     Describes a city
    ///     
    /// References:
    ///     Location
    ///     
    /// Dependencies:
    ///     Country
    ///     Location
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String
    ///     - location Location
    /// 
    /// Methods:
    ///     - City()      -- constructor
    ///     - City(name)  -- consturctor with parameters
    ///     - SetLocation(Location): bool
    /// 
    /// </summary>
    public class City
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - name: the name of the city
        ///     - location: the location of the city
        ///     
        /// </summary>
        private String name;
        private Location location;


        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }

        #endregion

        #region Construction
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Name of the region</param>
        /// <param name="location">Location of the region</param>
        public City()
        {
            this.Name = "";
            this.Location = new Location();
        }
        public City(String pName, Location pLocation)
        {
            this.Name = pName;
            this.Location = pLocation;
        }
        #endregion

        #region Private Helpers
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
            return (this.Name.Equals(lCity.Name) && this .Location.Equals(lCity.Location));
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        #endregion
    }
}