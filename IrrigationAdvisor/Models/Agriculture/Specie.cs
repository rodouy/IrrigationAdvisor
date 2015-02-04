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
    ///     - baseTemeperature double
    ///     - cropCoefficient CropCoefficient
    ///     - phenologicalStageList List<PhenologicalStage>
    /// 
    /// Methods: 
    ///     - Specie()      -- constructor
    ///     - Specie(idSpecie, name, baseTemperature)  -- consturctor with parameters
    ///     - Specie(idSpecie, name, baseTemperature, cropCoefficient, phenologicalStageList)  -- consturctor with parameters
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
        ///     - idSpecie: identifier
        ///     - name: the name of the specie    -  PK
        ///     - region: region of the specie    -  PK
        ///     - baseTemperature: base temperature of the specie for the region of the instance
        ///     - cropCoefficient: crop coefficient
        ///     - phenologicalStageList: list of phenolocical stages
        /// 
        /// </summary>
        private long idSpecie;
        private string name;
        private double baseTemperature;
        private CropCoefficient cropCoefficient;
        private List<PhenologicalStage> phenologicalStageList;

        #endregion

        #region Properties

        public long IdSpecie
        {
            get { return idSpecie; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
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

        public List<PhenologicalStage> PhenologicalStageList
        {
            get { return phenologicalStageList; }
            set { phenologicalStageList = value; }
        }
        

        #endregion
       
        #region Construction

        /// <summary>
        /// TODO add description
        /// </summary>
        public Specie() 
        {
            this.idSpecie = 0;
            this.Name = "noName";
            this.BaseTemperature = 0;
            this.CropCoefficient = new CropCoefficient();
            this.PhenologicalStageList = new List<PhenologicalStage>();
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pIdSpecie"></param>
        /// <param name="pName"></param>
        /// <param name="pBaseTemperature"></param>
        public Specie(long pIdSpecie, String pName,  
            double pBaseTemperature)
        {
            this.idSpecie = pIdSpecie;
            this.Name = pName;
            this.BaseTemperature = pBaseTemperature;
            this.CropCoefficient = new CropCoefficient();
            this.PhenologicalStageList = new List<PhenologicalStage>();
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pIdSpecie"></param>
        /// <param name="pName"></param>
        /// <param name="pBaseTemperature"></param>
        /// <param name="pCropCoefficient"></param>
        /// <param name="pPhenologicalStageList"></param>
        public Specie(long pIdSpecie, String pName,
            double pBaseTemperature, CropCoefficient pCropCoefficient,
            List<PhenologicalStage> pPhenologicalStageList)
        {
            this.idSpecie = pIdSpecie;
            this.Name = pName;
            this.BaseTemperature = pBaseTemperature;
            this.CropCoefficient = pCropCoefficient;
            this.PhenologicalStageList = pPhenologicalStageList;
        }

        #endregion

        #region Private Helpers

        
        #endregion

        #region Public Methods

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <param name="pStage"></param>
        /// <returns></returns>
        public PhenologicalStage FindPhenologicalStage(Specie pSpecie, Stage pStage)
        {
            PhenologicalStage lReturn = null;
            if (pSpecie != null && pStage != null)
            {
                foreach (PhenologicalStage item in this.PhenologicalStageList)
                {
                    if (item.Specie.Equals(pSpecie) && item.Stage.Equals(pStage))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// If PhenologicalStage exist in List return the PhenologicalStage, else null
        /// </summary>
        /// <param name="pPhenologicalStage"></param>
        /// <returns></returns>
        public PhenologicalStage ExistPhenologicalStage(PhenologicalStage pPhenologicalStage)
        {
            PhenologicalStage lReturn = null;
            foreach (PhenologicalStage item in PhenologicalStageList)
            {
                if(item.Equals(pPhenologicalStage))
                {
                    lReturn = item;
                    break;
                }
                
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <param name="pStage"></param>
        /// <param name="pMinDegree"></param>
        /// <param name="pMaxDegree"></param>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
        public PhenologicalStage AddPhenologicalStage(Specie pSpecie, Stage pStage, 
                                Double pMinDegree, Double pMaxDegree, Double pRootDepth)
        {
            PhenologicalStage lReturn = null;
            long lIDPhenologicalStage = this.PhenologicalStageList.Count();
            PhenologicalStage lPhenologicalStage = new PhenologicalStage(lIDPhenologicalStage,
                    pSpecie, pStage, pMinDegree, pMaxDegree, pRootDepth);
            lReturn = ExistPhenologicalStage(lPhenologicalStage);
            if(lReturn == null)
            {
                this.PhenologicalStageList.Add(lPhenologicalStage);
                lReturn = lPhenologicalStage;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <param name="pStage"></param>
        /// <param name="pMinDegree"></param>
        /// <param name="pMaxDegree"></param>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
        public PhenologicalStage UpdatePhenologicalStage(Specie pSpecie, Stage pStage,
                                        double pMinDegree, double pMaxDegree,
                                        double pRootDepth)
        {
            PhenologicalStage lReturn = null;
            PhenologicalStage lPhenologicalStage = new PhenologicalStage(0, pSpecie, pStage,
                                                        pMinDegree, pMaxDegree, pRootDepth);
            lReturn = ExistPhenologicalStage(lPhenologicalStage);
            if (lReturn != null)
            {
                lReturn.Specie = pSpecie;
                lReturn.Stage = pStage;
                lReturn.MinDegree = pMinDegree;
                lReturn.MaxDegree = pMaxDegree;
                lReturn.RootDepth = pRootDepth;
            }
            return lReturn;
        }

        #endregion

        #region Overrides
        // Different region for each class override

        /// <summary>
        /// Overrides equals:
        /// name
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
            lReturn = this.Name.Equals(lSpecie.Name);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion
    
    }
}