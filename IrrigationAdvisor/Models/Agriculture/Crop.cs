using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Localization;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IrrigationAdvisor.Models.Agriculture
{
    /// <summary>
    /// Create: 2014-10-25
    /// Author: monicarle
    /// Modified: 2015-01-08
    /// Author: rodouy
    /// Description: 
    ///     Describes a Crop in a Region of a Specie
    ///     
    /// References:
    ///     Region
    ///     Specie
    ///     CropCoefficient
    ///     PhenologicalStage
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
    ///     - cropId long
    ///     - name String   
    ///     - region Region           
    ///     - specie Specie 
    ///     - 
    ///     - phenologicalStageList List<PhenologicalStage>
    ///     - cropCoefficient CropCoefficient
    ///     - density double
    ///     - maxEvapotranspirationToIrrigate double
    ///     
    /// 
    /// Methods:
    ///     - Crop()      -- constructor
    ///     - Crop(name, Specie, density, maxEvapotranspirationToIrrigate)  -- consturctor with parameters
    ///     - GetRegion(): Region
    ///     - GetSpecie(): Specie
    ///     - GetBaseTemperature(): Double
    ///     
    /// 
    /// </summary>
    public class Crop
    {
        #region Consts
        #endregion

        #region Fields

        public long cropId;
        private String name;
        private Region region;
        private Specie specie;
        private CropCoefficient cropCoefficient;
        private List<Stage> stageList;
        private List<PhenologicalStage> phenologicalStageList;

        private double density;
        private double maxEvapotranspirationToIrrigate;
        private double minEvapotranspirationToIrrigate;
        
        #endregion

        #region Properties

        [Key]
        [Column(Order = 0)]
        public long CropId
        {
            get { return cropId; }
            set { cropId = value; }
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

        public Specie Specie
        {
            get { return specie; }
            set { specie = value; }
        }

        public CropCoefficient CropCoefficient
        {
            get { return cropCoefficient; }
            set { cropCoefficient = value; }
        }

        public List<Stage> StageList
        {
            get { return stageList; }
            set { stageList = value; }
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

        public double MinEvapotranspirationToIrrigate
        {
            get { return minEvapotranspirationToIrrigate; }
            set { minEvapotranspirationToIrrigate = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor of Crop
        /// </summary>
        public Crop()
        {
            this.cropId = 0;
            this.Name = "noName";
            this.Region = new Region();
            this.Specie = new Specie();
            this.CropCoefficient = new CropCoefficient();
            this.StageList = new List<Stage>();
            this.PhenologicalStageList = new List<PhenologicalStage>();
            this.Density = 0;
            this.MaxEvapotranspirationToIrrigate = 0;
            this.MinEvapotranspirationToIrrigate = 0;

        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pCropId"></param>
        /// <param name="pName"></param>
        /// <param name="pRegion"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pMaxEvapotranspirationToIrrigate"></param>
        /// <param name="pMinEvapotranspirationToIrrigate"></param>
        public Crop(long pIdCrop, String pName, Region pRegion, Specie pSpecie,
                    double pDensity, double pMaxEvapotranspirationToIrrigate, 
                    double pMinEvapotranspirationToIrrigate)
        {
            this.CropId = pIdCrop;
            this.Name = pName;
            this.Region = pRegion;
            this.Specie = pSpecie;
            this.CropCoefficient = new CropCoefficient();
            this.StageList = new List<Stage>();
            this.PhenologicalStageList = new List<PhenologicalStage>();
            this.Density = pDensity;
            this.MaxEvapotranspirationToIrrigate = pMaxEvapotranspirationToIrrigate;
            this.MinEvapotranspirationToIrrigate = pMinEvapotranspirationToIrrigate;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pCropId"></param>
        /// <param name="pName"></param>
        /// <param name="pRegion"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pCropCoefficient"></param>
        /// <param name="pStageList"></param>
        /// <param name="pPhenologicalStageList"></param>
        /// <param name="pDensity"></param>
        /// <param name="pMaxEvapotranspirationToIrrigate"></param>
        /// <param name="pMinEvapotranspirationToIrrigate"></param>
        public Crop(long pCropId, String pName, Region pRegion, Specie pSpecie,
                    CropCoefficient pCropCoefficient, List<Stage> pStageList,
                    List<PhenologicalStage> pPhenologicalStageList,
                    double pDensity, double pMaxEvapotranspirationToIrrigate, 
                    double pMinEvapotranspirationToIrrigate)
        {
            this.CropId = pCropId;
            this.Name = pName;
            this.Region = pRegion;
            this.Specie = pSpecie;
            this.CropCoefficient = pCropCoefficient;
            this.StageList = pStageList;
            this.PhenologicalStageList = pPhenologicalStageList;
            this.Density = pDensity;
            this.MaxEvapotranspirationToIrrigate = pMaxEvapotranspirationToIrrigate;
            this.MinEvapotranspirationToIrrigate = pMinEvapotranspirationToIrrigate;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        #region BaseTemperature

        /// <summary>
        /// Return the Base Temperature for the Specie of the Crop
        /// </summary>
        /// <returns></returns>
        public double GetBaseTemperature ()
        {
            Double lBaseTemperature = 0;
            lBaseTemperature = this.Specie.BaseTemperature;
            return lBaseTemperature;
        }

        #endregion

        #region Stage

        /// <summary>
        /// Get the initial Stage for the Crop
        /// </summary>
        /// <returns></returns>
        public Stage GetInitialStage()
        {
            Stage lReturn = null;
            if(this.StageList.Count() > 0)
            {
                lReturn = this.StageList[0];
            }
            return lReturn;
        }

        /// <summary>
        /// Find Stage by Name (Equals compare Property)
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public Stage FindStage(String pName)
        {
            Stage lReturn = null;
            if (!String.IsNullOrEmpty(pName))
            {
                foreach (Stage item in this.StageList)
                {
                    if (item.Name.Equals(pName))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// If Stage exist in List return the Stage, 
        /// else return null
        /// </summary>
        /// <param name="pStage"></param>
        /// <returns></returns>
        public Stage ExistStage(Stage pStage)
        {
            Stage lReturn = null;
            if (pStage != null)
            {
                foreach (Stage item in this.StageList)
                {
                    if (item.Equals(pStage))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a new Stage and return it, if exists returns null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pDescription"></param>
        /// <returns></returns>
        public Stage AddStage(String pName, String pDescription)
        {
            Stage lReturn = null;
            long lIdStage = this.StageList.Count();
            Stage lStage = new Stage(lIdStage, pName, pDescription);
            if (ExistStage(lStage) == null)
            {
                this.StageList.Add(lStage);
                lReturn = lStage;
            }
            return lReturn;
        }

        /// <summary>
        /// Update an existing Stage, if not exists return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pDescription"></param>
        /// <returns></returns>
        public Stage UpdateStage(String pName, String pDescription)
        {
            Stage lReturn = null;
            Stage lStage = new Stage(0, pName, pDescription);
            lReturn = ExistStage(lStage);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Description = pDescription;
            }
            return lReturn;
        }

        #endregion

        #region PhenologicalStage

        /// <summary>
        /// Get the initial Phenological Stage
        /// </summary>
        /// <returns></returns>
        public PhenologicalStage GetInitialPhenologicalStage()
        {
            PhenologicalStage lReturn = null;
            if(this.PhenologicalStageList.Count() > 0)
            {
                lReturn = this.PhenologicalStageList[0];
            }
            return lReturn;
        }

        /// <summary>
        /// Find A Phenological Stage by Specie and Stage
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <param name="pStage"></param>
        /// <returns></returns>
        public PhenologicalStage FindPhenologicalStage(Stage pStage)
        {
            PhenologicalStage lReturn = null;
            if(pStage != null)
            {
                foreach (PhenologicalStage item in this.PhenologicalStageList)
                {
                    if (item.Stage.Equals(pStage))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// If PhenologicalStage exist in List, return the PhenologicalStage, 
        /// else return null
        /// </summary>
        /// <param name="pInitialPhenologicalStage"></param>
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
        /// Add a new PhenologicalStage, if exists, return null
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <param name="pStage"></param>
        /// <param name="pMinDegree"></param>
        /// <param name="pMaxDegree"></param>
        /// <param name="pDepth"></param>
        /// <returns></returns>
        public PhenologicalStage AddPhenologicalStage(Stage pStage,
                                        double pMinDegree, double pMaxDegree, 
                                        double pRootDepth, double pHydricBalanceDepth)
        {
            PhenologicalStage lReturn = null;
            long lPhenologicalStageId = this.PhenologicalStageList.Count();
            PhenologicalStage lPhenologicalStage = new PhenologicalStage(lPhenologicalStageId,
                                                    pStage, pMinDegree, pMaxDegree,
                                                    pRootDepth, pHydricBalanceDepth);
            lReturn = ExistPhenologicalStage(lPhenologicalStage);
            if (lReturn == null)
            {
                this.PhenologicalStageList.Add(lPhenologicalStage);
                lReturn = lPhenologicalStage;
            }
            return lReturn;
        }

        /// <summary>
        /// Update all the information about an existing PhenologicalStage,
        /// if not exist, return null
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <param name="pStage"></param>
        /// <param name="pMinDegree"></param>
        /// <param name="pMaxDegree"></param>
        /// <param name="pDepth"></param>
        /// <returns></returns>
        public PhenologicalStage UpdatePhenologicalStage(Stage pStage,
                                        double pMinDegree, double pMaxDegree,
                                        double pRootDepth, double pHydricBalanceDepth)
        {
            PhenologicalStage lReturn = null;
            PhenologicalStage lPhenologicalStage = new PhenologicalStage(0, pStage,
                                                        pMinDegree, pMaxDegree, pRootDepth,
                                                        pHydricBalanceDepth);
            lReturn = ExistPhenologicalStage(lPhenologicalStage);
            if (lReturn != null)
            {
                lReturn.Stage = pStage;
                lReturn.MinDegree = pMinDegree;
                lReturn.MaxDegree = pMaxDegree;
                lReturn.RootDepth = pRootDepth;
                lReturn.HydricBalanceDepth = pHydricBalanceDepth;
            }
            return lReturn;
        }

        #endregion

        #region CropCoefficient

        /// <summary>
        /// Returns the KC for a Crop giving the days after sowing.
        /// </summary>
        /// <param name="pDaysAfterSowing"></param>
        /// <returns></returns>
        public double getKC(int pDaysAfterSowing)
        {
            double lReturn = 0;
            lReturn = this.CropCoefficient.getKC(pDaysAfterSowing);

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
            lReturn = this.Region.Equals(lCrop.Region)
                && this.Specie.Equals(lCrop.Specie);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.Specie.GetHashCode();
        }
        
        #endregion


    }
}