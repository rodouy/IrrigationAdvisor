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
    /// Modified: 2015-01-08
    /// Author: rodouy
    /// Description: 
    ///     Describes a specie
    ///     
    /// References:
    ///     Region
    ///     CropCoefficient
    ///     PhenologicalStage
    ///     
    ///     
    /// Dependencies:
    ///     Crop
    ///     CropCoefficient
    ///     PhenologicalStage
    ///     IrrigationSystem
    ///     InitialTables
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - idSpecie long
    ///     - name String
    ///     - region Region
    ///     - baseTemeperature double
    ///     - cropCoefficient CropCoefficient
    ///     - phenologicalStages List<PhenologicalStage>
    /// 
    /// Methods: 
    ///     - Specie()      -- constructor
    ///     - Specie(idSpecie, name, region, baseTemperature)  -- consturctor with parameters
    ///     - Specie(idSpecie, name, region, baseTemperature, cropCoefficient, phenologicalStages)  -- consturctor with parameters
    ///     - (double): double
    ///     - (): Region
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
        ///     - cropCoefficient: crop coefficient
        ///     - phenologicalStages: list of phenolocical stages
        /// 
        /// </summary>
        private long idSpecie;
        private string name;
        private Region region;
        private double baseTemperature;
        private CropCoefficient cropCoefficient;
        private List<PhenologicalStage> phenologicalStages;

        #endregion

        #region Properties

        public long IdSpecie
        {
            get { return idSpecie; }
            set { idSpecie = value; }
        }

        public String Name
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

        public CropCoefficient CropCoefficient
        {
            get { return cropCoefficient; }
            set { cropCoefficient = value; }
        }

        public List<PhenologicalStage> PhenologicalStages
        {
            get { return phenologicalStages; }
            set { phenologicalStages = value; }
        }
        

        #endregion
       
        #region Construction

        public Specie() 
        {
            this.IdSpecie = 0;
            this.Name = "noName";
            this.Region = new Region();
            this.BaseTemperature = 0;
            this.CropCoefficient = new CropCoefficient();
            this.PhenologicalStages = new List<PhenologicalStage>();
        }

        public Specie(int pId, String pName, Region pRegion, 
            double pBaseTemperature)
        {
            this.IdSpecie = pId;
            this.Name = pName;
            this.Region = pRegion;
            this.BaseTemperature = pBaseTemperature;
            this.CropCoefficient = new CropCoefficient();
            this.PhenologicalStages = new List<PhenologicalStage>();
        }

        public Specie(int pId, String pName, Region pRegion,
            double pBaseTemperature, CropCoefficient pCropCoefficient,
            List<PhenologicalStage> pPhenologicalStages)
        {
            this.IdSpecie = pId;
            this.Name = pName;
            this.Region = pRegion;
            this.BaseTemperature = pBaseTemperature;
            this.CropCoefficient = pCropCoefficient;
            this.PhenologicalStages = pPhenologicalStages;
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
        /// name, region
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
                && this.Region.Equals(lSpecie.Region);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        #endregion
    
    }
}