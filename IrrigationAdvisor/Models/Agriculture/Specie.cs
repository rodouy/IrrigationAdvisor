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
    ///     SpecieCycleList
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
    ///     - specieCycleList SpecieCycleList
    ///     - baseTemeperature double
    ///     - 
    /// Methods: 
    ///     - Specie()      -- constructor
    ///     - Specie(specieId, name, specieCycleList, baseTemperature)  -- consturctor with parameters
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
        ///     - specieCycleList: cycle of the specie    -  PK
        ///     - baseTemperature: base temperature of the specie for the region of the instance
        ///     
        /// </summary>
        private long specieId;
        private string name;
        private long specieCycleId;
        private double baseTemperature;
        private double stressTemperature;
                
        #endregion

        #region Properties

        
        public long SpecieId
        {
            get { return specieId; }
            set { specieId = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public long SpecieCycleId
        {
            get { return specieCycleId; }
            set { specieCycleId = value; }
        }
        
        public double BaseTemperature
        {
            get { return baseTemperature; }
            set { baseTemperature = value; }
        }
        
        public double StressTemperature
        {
            get { return stressTemperature; }
            set { stressTemperature = value; }
        }

        public virtual SpecieCycle SpecieCycle
        {
            get;
            set;
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
            this.SpecieCycleId = 0;
            this.BaseTemperature = 0;
            this.StressTemperature = 0;
        }

        /// <summary>
        /// Constructor of Specie with parameters
        /// </summary>
        /// <param name="pSpecieId"></param>
        /// <param name="pName"></param>
        /// <param name="pSpecieCycle"></param>
        /// <param name="pBaseTemperature"></param>
        public Specie(long pSpecieId, String pName,  
                    long pSpecieCycleId, Double pBaseTemperature,
                    Double pStressTemperature)
        {
            this.specieId = pSpecieId;
            this.Name = pName;
            this.SpecieCycleId = pSpecieCycleId;
            this.BaseTemperature = pBaseTemperature;
            this.StressTemperature = pStressTemperature;
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