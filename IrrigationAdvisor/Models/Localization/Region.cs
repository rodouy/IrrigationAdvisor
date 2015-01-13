using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Agriculture;


namespace IrrigationAdvisor.Models.Localization
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
    ///     - species: List<Specie>
    ///     - effectiveRain List <EffectiveRain>
    /// 
    /// Methods:
    ///     - Region()      -- constructor
    ///     - Region(name)  -- consturctor with parameters
    ///     - SetLocation(Location): bool
    /// 
    /// </summary>
    //[Serializable()]
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
        private long idRegion;
        private String name;
        private Position position;
        private List<Specie> species;
        private List<EffectiveRain> effectiveRains;


        #endregion

        #region Properties

        public long IdRegion
        {
            get { return idRegion; }
            set { idRegion = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<EffectiveRain> EffectiveRains
        {
            get { return effectiveRains; }
            set { effectiveRains = value; }
        }

        public List<Specie> Species
        {
            get { return species; }
            set { species = value; }
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
            this.EffectiveRains = new List<EffectiveRain>();
            this.Species = new List<Specie>();
        }
        public Region(String pName, Position pPosition)
        {
            this.Name = pName;
            this.Position = pPosition;
            this.EffectiveRains = new List<EffectiveRain>();
            this.Species = new List<Specie>();
 
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
                //&& this .Position.Equals(pRegion.Position);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        #endregion
    }
}