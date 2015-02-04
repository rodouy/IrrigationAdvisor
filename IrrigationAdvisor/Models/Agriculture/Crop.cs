using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Localization;

namespace IrrigationAdvisor.Models.Agriculture
{
    /// <summary>
    /// Create: 2014-10-25
    /// Author: monicarle
    /// Modified: 2015-01-08
    /// Author: rodouy
    /// Description: 
    ///     Describes a Crop
    ///     
    /// References:
    ///     Specie
    ///     
    ///     
    /// Dependencies:
    ///     IrrigationUnit
    ///     CropIrrigationWeather
    ///     EquipmentService
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - idCrop long
    ///     - name String              
    ///     - specie Specie 
    ///     - region Region
    ///     - phenologicalStageList List<PhenologicalStage>
    ///     - 
    ///     - density double
    ///     - maxEvapotranspirationToIrrigate double
    ///     
    /// 
    /// Methods:
    ///     - Crop()      -- constructor
    ///     - Crop(name, Specie, density, maxEvapotranspirationToIrrigate)  -- consturctor with parameters
    ///     - GetRegion(): Region
    ///     - GetBaseTemperature(): Double
    ///     
    /// 
    /// </summary>
    public class Crop
    {
        #region Consts
        #endregion

        #region Fields

        private long idCrop;
        private String name;
        private Specie specie;
        private Region region;
        private List<PhenologicalStage> phenologicalStageList;

        private double density;
        private double maxEvapotranspirationToIrrigate;
        
        #endregion

        #region Properties

        public long IdCrop
        {
            get { return idCrop; }
            set { idCrop = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public Specie Specie
        {
            get { return specie; }
            set { specie = value; }
        }

        public Region Region
        {
            get { return region; }
            set { region = value; }
        }

        public List<PhenologicalStage> PhenologicalStageList
        {
            get { return phenologicalStageList; }
            set { phenologicalStageList = value; }
        }

        public double Density
        {
            get { return density; }
            set { density = value; }
        }

        public double MaxEvapotranspirationToIrrigate
        {
            get { return maxEvapotranspirationToIrrigate; }
            set { maxEvapotranspirationToIrrigate = value; }
        }

 
        #endregion

        #region Construction

        /// <summary>
        /// Constructor of Crop
        /// </summary>
        public Crop()
        {
            this.idCrop = 0;
            this.Name = "noName";
            this.Specie = new Specie();
            this.Region = new Region();
            this.PhenologicalStageList = new List<PhenologicalStage>();
            this.Density = 0;
            this.MaxEvapotranspirationToIrrigate = 0;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pIdCrop"></param>
        /// <param name="pName"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pRegion"></param>
        /// <param name="pMaxEvapotranspirationToIrrigate"></param>
        public Crop(long pIdCrop, String pName, Specie pSpecie, Region pRegion,
                    double pMaxEvapotranspirationToIrrigate)
        {
            this.IdCrop = pIdCrop;
            this.Name = pName;
            this.Specie = pSpecie;
            this.Region = pRegion;
            this.PhenologicalStageList=new List<PhenologicalStage>();
            this.Density = 0;
            this.MaxEvapotranspirationToIrrigate = pMaxEvapotranspirationToIrrigate;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pIdCrop"></param>
        /// <param name="pName"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pRegion"></param>
        /// <param name="pPhenologicalStageList"></param>
        /// <param name="pDensity"></param>
        /// <param name="pMaxEvapotranspirationToIrrigate"></param>
        public Crop(long pIdCrop, String pName, Specie pSpecie, Region pRegion,
            List<PhenologicalStage> pPhenologicalStageList,
            double pDensity, double pMaxEvapotranspirationToIrrigate)
        {
            this.IdCrop = pIdCrop;
            this.Name = pName;
            this.Specie = pSpecie;
            this.Region = pRegion;
            this.PhenologicalStageList = pPhenologicalStageList;
            this.Density = pDensity;
            this.MaxEvapotranspirationToIrrigate = pMaxEvapotranspirationToIrrigate;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods


        /// <summary>
        /// Return the Base Temperature for the Specie of the Crop
        /// </summary>
        /// <returns></returns>
        public double getBaseTemperature ()
        {
            Double lBaseTemperature;
            lBaseTemperature = this.Specie.BaseTemperature;
            return lBaseTemperature;
        }

        #region PhenologicalStage

        /// <summary>
        /// Find A Phenological Stage by Specie and Stage
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <param name="pStage"></param>
        /// <returns></returns>
        public PhenologicalStage FindPhenologicalStage(Specie pSpecie, Stage pStage)
        {
            PhenologicalStage lReturn = null;
            if(pSpecie != null && pStage != null)
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
        /// Return the Phenological Stage if exists in the list
        /// </summary>
        /// <param name="pPhenologicalStage"></param>
        /// <returns></returns>
        public PhenologicalStage ExistPhenologicalStage(PhenologicalStage pPhenologicalStage)
        {
            PhenologicalStage lReturn = null;
            if (pPhenologicalStage != null)
            {
                foreach (PhenologicalStage item in this.PhenologicalStageList)
                {
                    if (item.Equals(pPhenologicalStage))
                    {
                        lReturn = item;
                        break;
                    }
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
                                        double pMinDegree, double pMaxDegree, double pRootDepth)
        {
            PhenologicalStage lReturn = null;
            long lIdPhenologicalStage = this.PhenologicalStageList.Count();
            PhenologicalStage lPhenologicalStage = new PhenologicalStage(lIdPhenologicalStage,
                                                    pSpecie, pStage, pMinDegree, pMaxDegree, pRootDepth);
            lReturn = ExistPhenologicalStage(lPhenologicalStage);
            if (lReturn == null)
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

        #endregion

        #region Overrides
        // Different region for each class override

        /// <summary>
        /// Overrides equals
        /// name, specie
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool lReturn = false;
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            Crop lCrop = obj as Crop;
            lReturn = this.Name.Equals(lCrop.Name) 
                && this.Specie.Equals(lCrop.Specie);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        
        #endregion


    }
}