using IrrigationAdvisor.Models.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace IrrigationAdvisor.Models.Crop
{
    /// <summary>
    /// Create: 2014-10-25
    /// Author: monicarle
    /// Description: 
    ///     Describes a specie
    ///     
    /// References:
    ///     Region
    ///     
    /// Dependencies:
    ///     IrrigationRecords
    ///     Crop
    ///     CropCoefficient
    ///     PhenologicalStage
    ///     IrrigationRecords
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - id int
    ///     - name String
    ///     - region Region
    ///     - baseTemeperature double
    /// 
    /// Methods:
    /// 
    ///     - Specie()      -- constructor
    ///     - Specie(name)  -- consturctor with parameters
    ///     - setBT(double): double
    ///     - getRegion(): Region
    /// 
    /// </summary>
    public class Specie
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - idSpecie: identifier
        ///     - name: the name of the specie    -  PK
        ///     - region: region of the specie    -  PK
        ///     - baseTemperature: base temperature of the specie for the region of the instance
        ///     
        /// </summary>
        private int idSpecie;
        private string name;
        private double baseTemperature;
        private Region region;

        #endregion

        #region Properties

        public int IdSpecie
        {
            get { return idSpecie; }
            set { idSpecie = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public Region Region
        {
            get { return region; }
            set { region = value; }
        }
        
        public double BaseTemperature
        {
            get { return baseTemperature; }
            set { baseTemperature = value; }
        }




        #endregion
        #region Construction
        public Specie() 
        {
            this.IdSpecie = 0;
            this.Name = "noname";
            this.Region = new Region();
            this.BaseTemperature = 0;
        }
        public Specie(int pId, String name, Region region, double baseTemperature)
        {
            this.IdSpecie = pId;
            this.Name = name;
            this.Region = region;
            this.BaseTemperature = baseTemperature;
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
            Specie lSpecie = obj as Specie;
            return this.Name.Equals(lSpecie.Name);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        #endregion
    }
}