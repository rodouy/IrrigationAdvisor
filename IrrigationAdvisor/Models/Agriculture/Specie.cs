using IrrigationAdvisor.Models.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace IrrigationAdvisor.Models.Agriculture
{
    /// <summary>
    /// Create: 2014-10-25
    /// Author: monicarle
    /// Modified: 2015-01-08
    /// Author: rodouy
    /// Description: 
    ///     Describes a specie
    ///     
    /// References:
    ///     SpecieCycle
    ///     
    ///     
    /// Dependencies:
    ///     Crop
    ///     IrrigationSystem
    ///     InitialTables
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - specieId long
    ///     - name String
    ///     - specieCycle SpecieCycle
    ///     - baseTemeperature double
    ///     - 
    /// Methods: 
    ///     - Specie()      -- constructor
    ///     - Specie(specieId, name, specieCycle, baseTemperature)  -- consturctor with parameters
    ///     - (double): double
    ///     - 
    /// 
    /// </summary>
    public class Specie
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - specieId: identifier
        ///     - name: the name of the specie    -  PK
        ///     - specieCycle: cycle of the specie    -  PK
        ///     - baseTemperature: base temperature of the specie for the region of the instance
        ///     
        /// </summary>
        private long specieId;
        private string name;
        private SpecieCycle specieCycle;
        private double baseTemperature;
        
        #endregion

        #region Properties

        public long SpecieId
        {
            get { return specieId; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }        
        
        public SpecieCycle SpecieCycle
        {
            get { return specieCycle; }
            set { specieCycle = value; }
        }

        public double BaseTemperature
        {
            get { return baseTemperature; }
            set { baseTemperature = value; }
        }


        #endregion
       
        #region Construction

        /// <summary>
        /// Constructor of Specie without parameters
        /// </summary>
        public Specie() 
        {
            this.specieId = 0;
            this.Name = "noName";
            this.SpecieCycle = new SpecieCycle();
            this.BaseTemperature = 0;
        }

        /// <summary>
        /// Constructor of Specie with parameters
        /// </summary>
        /// <param name="pSpecieId"></param>
        /// <param name="pName"></param>
        /// <param name="pSpecieCycleName"></param>
        /// <param name="pBaseTemperature"></param>
        public Specie(long pSpecieId, String pName,
                    String pSpecieCycleName, Double pBaseTemperature)
        {
            this.specieId = pSpecieId;
            this.Name = pName;
            this.SpecieCycle = new SpecieCycle(pSpecieCycleName);
            this.BaseTemperature = pBaseTemperature;
        }

        /// <summary>
        /// Constructor of Specie with parameters
        /// </summary>
        /// <param name="pSpecieId"></param>
        /// <param name="pName"></param>
        /// <param name="pSpecieCycle"></param>
        /// <param name="pBaseTemperature"></param>
        public Specie(long pSpecieId, String pName,  
            SpecieCycle pSpecieCycle, double pBaseTemperature)
        {
            this.specieId = pSpecieId;
            this.Name = pName;
            this.SpecieCycle = pSpecieCycle;
            this.BaseTemperature = pBaseTemperature;
        }

        
        #endregion

        #region Private Helpers

        
        #endregion

        #region Public Methods

        #endregion

        #region Overrides
        // Different region for each class override

        /// <summary>
        /// Overrides equals:
        /// name, speciecycle
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool lReturn = false;
            if (obj == null || obj.GetType() != this.GetType())
            {
                return lReturn;
            }
            Specie lSpecie = obj as Specie;
            lReturn = this.Name.Equals(lSpecie.Name)
                && this.SpecieCycle.Equals(lSpecie.SpecieCycle);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion
    
    }
}