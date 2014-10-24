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
    ///     Describes a region
    ///     
    /// References:
    ///     Location
    ///     
    /// Dependencies:
    ///     Location
    ///     Specie
    ///     CropCoefficient
    ///     Crop
    ///     EffectiveRain
    ///     CropIrrigationWeather
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
    ///     - Region()      -- constructor
    ///     - Region(name)  -- consturctor with parameters
    ///     - SetLocation(Location): bool
    /// 
    /// </summary>
    public class Region
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - name: the name of the region
        ///     - location: the location of the region
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
        public Region()
        {
            this.Name = "";
            this.Location = new Location();
        }
        public Region(String pName, Location pLocation)
        {
            this.name = pName;
            this.location = pLocation;
        }
        #endregion

        #region Private Helpers
        #endregion
    }
}