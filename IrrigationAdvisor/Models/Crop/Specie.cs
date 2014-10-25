using IrrigationAdvisor.Models.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace IrrigationAdvisor.Models.Crop
{
    /// <summary>
    /// Create: 2014-10-14
    /// Author: rodouy - monicarle
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
        ///     - name: the name of the specie
        ///     - region: region of the specie
        ///     - baseTemperature: base temperature of the specie for the region of the instance
        ///     
        /// </summary>
        private string name;
        private double baseTemperature;
        private Region region;

        #endregion

        #region Properties
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
            this.Name = "noname";
            this.Region = new Region();
            this.BaseTemperature = 0;
        }
        public Specie(String name, Region region, double baseTemperature)
        {
            this.Name = name;
            this.Region = region;
            this.BaseTemperature = baseTemperature;
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        #endregion
    }
}