﻿using System;
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
    ///     - name String
    ///     - specie Specie
    ///     - location
    ///     - cropCoefficient CropCoefficient
    ///     - density double
    ///     - phenologiclaStage PhenologicalStage
    ///     - sowingDate DateTime
    ///     - harvestDate DateTime
    ///     - soils List<Soil>
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

        private String name;
        private Specie specie;
        private Location.Location location;
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

        public double getBaseTemperature (Soil pSoil)
        {
            return this.Specie.BaseTemperature;
        }

        public int getDaysAfterSowing() 
        {
            return DateTime.Now.Subtract( this.SowingDate).Days;
        }

        public double getFieldCapacity(Soil pSoil) 
        {
            double lReturn = 0;
            foreach (Soil lSoil in this.Soils)
            {
                if (pSoil.Equals(lSoil))
                {
                    lReturn = lSoil.FieldCapacity;
                    return lReturn;
                }
            }
            return lReturn;
        }

        public double getPermanentWiltingPoint(Soil pSoil)
        {
            double lReturn = 0;
            foreach (Soil lSoil in this.Soils)
            {
                if (pSoil.Equals(lSoil))
                {
                    lReturn = lSoil.PermanentWiltingPoint;
                    return lReturn;
                }
            }
            return lReturn;
        }
        /// <summary>
        /// Return the AvailableWaterCapacity.
        /// Is calculated as the FieldCapacity minus PermanentWiltingPoint of the Soil.
        /// </summary>
        /// <param name="pSoil"></param>
        /// <returns></returns>
        public double getAvailableWaterCapacity(Soil pSoil)
        {
            double lReturn = 0;
            foreach (Soil lSoil in this.Soils)
            {
                if (pSoil.Equals(lSoil))
                {
                    lReturn = lSoil.FieldCapacity - lSoil.PermanentWiltingPoint;
                    return lReturn;
                }
            }
            return lReturn;
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
            return this.Name.Equals(lCrop.Name) &&
                this.Location.Equals(lCrop);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        #endregion


    }
}