using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Location;

namespace IrrigationAdvisor.Models.Crop
{
    /// <summary>
    /// Create: 2014-10-25
    /// Author: monicarle
    /// Description: 
    ///     Describes a Crop
    ///     
    /// References:
    ///     Specie
    ///     CropCoefficient
    ///     PhenologicalStage
    ///     Soil
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
    ///     - idCrop int
    ///     - name String              
    ///     - specie Specie                                 - PK
    ///     - location
    ///     - cropCoefficient CropCoefficient
    ///     - density double
    ///     - phenologiclaStage PhenologicalStage
    ///     - phenologiclaStageList List<PhenologicalStage>
    ///     - sowingDate DateTime                           - PK
    ///     - harvestDate DateTime
    ///     - soil Soil                                     - PK
    ///     - maxEvapotranspirationToIrrigate double
    ///     
    /// 
    /// 
    /// Methods:
    ///     - Crop()      -- constructor
    ///     - Crop(name, specie, cropCoefficient, density, phenologicalStage, sowingDate, harvestDate, soils, maxEvapotranspirationToIrrigate)  -- consturctor with parameters
    ///     - getRegion(): Region
    ///     - getBaseTemperature(): Double
    ///     - getDaysAfterSowing():
    ///     - getFieldCapacity(): double
    ///     - getPermanentWiltingPoint(): double
    ///     - getAvailableWaterCapacity(): double
    /// 
    /// </summary>
    public class Crop
    {
        #region Consts
        #endregion

        #region Fields

        private int idCrop;
        private String name;
        private Specie specie;
        private Location.Location location;
        private CropCoefficient cropCoefficient;
        private double density;
        private PhenologicalStage phenologicalStage;
        private List<PhenologicalStage> phenologicalStageList;
private DateTime sowingDate;
        private DateTime harvestDate;
        private Soil soil;
        private double maxEvapotranspirationToIrrigate;
        
        #endregion

        #region Properties

        public int IdCrop
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

        public Location.Location Location
        {
            get { return location; }
            set { location = value; }
        }
        
        public CropCoefficient CropCoefficient
        {
            get { return cropCoefficient; }
            set { cropCoefficient = value; }
        }
        
        public double Density
        {
            get { return density; }
            set { density = value; }
        }
        
        public PhenologicalStage PhenologicalStage
        {
            get { return phenologicalStage; }
            set { phenologicalStage = value; }
        }

        public List<PhenologicalStage> PhenologicalStageList
        {
            get { return phenologicalStageList; }
            set { phenologicalStageList = value; }
        }
        
        public DateTime SowingDate
        {
            get { return sowingDate; }
            set { sowingDate = value; }
        }
        
        public DateTime HarvestDate
        {
            get { return harvestDate; }
            set { harvestDate = value; }
        }

        public Soil Soil
        {
            get { return soil; }
            set { soil = value; }
        }
        
        public double MaxEvapotranspirationToIrrigate
        {
            get { return maxEvapotranspirationToIrrigate; }
            set { maxEvapotranspirationToIrrigate = value; }
        }

        #endregion

        #region Construction
        /// <summary>
        /// Constructor of ClassTemplate
        /// </summary>
        public Crop()
        {
            this.idCrop = 0;
            this.Name = "noname";
            this.Specie = new Specie();
            this.Location = new Location.Location();
            this.CropCoefficient = new CropCoefficient();
            this.Density = 0;
            this.PhenologicalStage = new PhenologicalStage();
            this.PhenologicalStageList = new List<PhenologicalStage>();
            this.SowingDate = DateTime.Now;
            this.HarvestDate = DateTime.Now;
            this.Soil = new Soil();
            this.MaxEvapotranspirationToIrrigate = 0;
        }

        public Crop(int pId, String pName, Specie pSpecie, Location.Location pLocation, CropCoefficient pCropCoefficient,
            double pDensity, PhenologicalStage pPhenologicalStage, List<PhenologicalStage> pPhenologicalStageList, DateTime pSowingDate,
            DateTime pHarvestDate, Soil pSoil, double pMaxEvapotranspirationToIrrigate)
        {
            this.IdCrop = pId;
            this.Name = pName;
            this.Specie = pSpecie;
            this.Location = pLocation;
            this.CropCoefficient = pCropCoefficient;
            this.Density = pDensity;
            this.PhenologicalStage = pPhenologicalStage;
            this.PhenologicalStageList = pPhenologicalStageList;
            this.SowingDate = pSowingDate;
            this.HarvestDate = pHarvestDate;
            this.Soil = pSoil;
            this.MaxEvapotranspirationToIrrigate = pMaxEvapotranspirationToIrrigate;

        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        public Region getRegion()
        {
            return this.Soil.Location.Region;
        }

        public double getBaseTemperature ()
        {
            return this.Specie.BaseTemperature;
        }

        public int getDaysAfterSowing() 
        {
            return DateTime.Now.Subtract( this.SowingDate).Days;
        }

        public double getFieldCapacity(double pRootDepth) 
        {
            return this.Soil.getFieldCapacity(pRootDepth);
        }

        public double getPermanentWiltingPoint(double pRootDepth)
        {
            return this.Soil.getPermanentWiltingPoint(pRootDepth);
        }
        /// <summary>
        /// Return the AvailableWaterCapacity.
        /// Is calculated as the FieldCapacity minus PermanentWiltingPoint of the Soil.
        /// </summary>
        /// <param name="pSoil"></param>
        /// <returns></returns>
        public double getAvailableWaterCapacity(double pRootDepth)
        {
            return this.Soil.getAvailableWaterCapacityProration(pRootDepth);
        }

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
            Crop lCrop = obj as Crop;
            return this.Soil.Equals(lCrop.Soil) &&
                this.SowingDate .Equals(lCrop.SowingDate ) && this.Specie .Equals(lCrop.Specie );
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        #endregion


    }
}