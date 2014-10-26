using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Location;

namespace IrrigationAdvisor.Models.Crop
{
    /// <summary>
    /// Create: 2014-10-14
    /// Author: rodouy - monicarle
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
    ///     - name String
    ///     - specie Specie
    ///     - cropCoefficient CropCoefficient
    ///     - density double
    ///     - phenologiclaStage PhenologicalStage
    ///     - sowingDate DateTime
    ///     - harvestDate DateTime
    ///     - soils List<Soil>
    ///     - maxEvapotranspirationToIrrigate double
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

        private String name;
        private Specie specie;
        private CropCoefficient cropCoefficient;
        private double density;
        private PhenologicalStage phenologicalStage;
        private DateTime sowingDate;
        private DateTime harvestDate;
        private List<Soil> soils;
        private double maxEvapotranspirationToIrrigate;
        
        #endregion

        #region Properties
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

        public List<Soil> Soils
        {
            get { return soils; }
            set { soils = value; }
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
            this.Name = "noname";
            this.Specie = new Specie();
            this.CropCoefficient = new CropCoefficient();
            this.Density = 0;
            this.PhenologicalStage = new PhenologicalStage();
            this.SowingDate = DateTime.Now;
            this.HarvestDate = DateTime.Now;
            this.Soils = new List<Soil>();
            this.MaxEvapotranspirationToIrrigate = 0;
        }

        public Crop(String pName, Specie pSpecie, CropCoefficient pCropCoefficient,
            double pDensity, PhenologicalStage pPhenologicalStage, DateTime pSowingDate,
            DateTime pHarvestDate, List <Soil> pSoils, double pMaxEvapotranspirationToIrrigate)
        {
            this.Name = pName;
            this.Specie = pSpecie;
            this.CropCoefficient = pCropCoefficient;
            this.Density = pDensity;
            this.PhenologicalStage = pPhenologicalStage;
            this.SowingDate = pSowingDate;
            this.HarvestDate = pHarvestDate;
            this.Soils = pSoils;

        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        public Region getRegion(Soil pSoil)
        {
            Region lRegion = null;
            foreach(Soil lSoil in this.Soils)
            {
                if(pSoil.Equals(lSoil))
                {
                    lRegion = lSoil.Location.Region;
                    return lRegion;
                }
            }
            return lRegion;
        }
    ///     - getRegion(): Region
    ///     - getBaseTemperature(): Double
    ///     - getDaysAfterSowing():
    ///     - getFieldCapacity(): double
    ///     - getPermanentWiltingPoint(): double
    ///     - getAvailableWaterCapacity(): double
        #endregion

        #region Overrides
        #endregion


    }
}