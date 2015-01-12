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
    ///     - specie Specie                                 - PK
    ///     - density double
    ///     - maxEvapotranspirationToIrrigate double
    ///     
    /// 
    /// Methods:
    ///     - Crop()      -- constructor
    ///     - Crop(name, Specie, density, maxEvapotranspirationToIrrigate)  -- consturctor with parameters
    ///     - getRegion(): Region
    ///     - getBaseTemperature(): Double
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
            this.Density = 0;
            this.MaxEvapotranspirationToIrrigate = 0;
        }

        public Crop(int pId, String pName, Specie pSpecie, 
            double pDensity, double pMaxEvapotranspirationToIrrigate)
        {
            this.IdCrop = pId;
            this.Name = pName;
            this.Specie = pSpecie;
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


        #endregion

        #region Overrides
        // Different region for each class override

        /// <summary>
        /// Overrides equals
        /// name, region, specie
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