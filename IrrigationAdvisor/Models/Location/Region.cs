using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Location
{
    /// <summary>
    /// Create: 2014-10-22
    /// Author: monicarle
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
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - idRegion int
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
        ///     - idRegion: identifier
        ///     - name: the name of the region
        ///     - location: the location of the region
        ///     
        /// </summary>
        private int idRegion;
        private String name;
        private Position position;



        #endregion

        #region Properties

        public int IdRegion
        {
            get { return idRegion; }
            set { idRegion = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Position Position
        {
            get { return position; }
            set { position = value; }
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
            this.Position = new Position();
        }
        public Region(String pName, Position pPosition)
        {
            this.Name = pName;
            this.Position = pPosition;
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
            Region lRegion = obj as Region;
            return this.Name.Equals(lRegion.Name);
               // && this .Location.Equals(lRegion.Location);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        #endregion
    }
}