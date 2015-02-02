using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Localization;

namespace IrrigationAdvisor.Models.Irrigation
{
    /// <summary>
    /// Create: 2014-10-26
    /// Author: monicarle
    /// Description: 
    ///     Describes an Irrigation Unit
    ///     
    /// References:
    ///     Crop
    ///     Bomb
    ///     Location
    ///     
    /// Dependencies:
    ///     CropIrrigationWeather
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String
    /// 
    /// Methods:
    ///     - ClassTemplate()      -- constructor
    ///     - ClassTemplate(name)  -- consturctor with parameters
    /// 
    /// </summary>
    public class IrrigationUnit
    {
        #region Consts
        #endregion

        #region Fields

        private long idIrrigationUnit;
        private String name;
        private String irrigationType;
        private double irrigationEfficiency;
        private List<Pair<DateTime, double>> irrigationList;
        private double surface;
        private List<Crop> cropList;
        private Bomb bomb;
        private Location location;

        #endregion

        #region Properties

        public long IdIrrigationUnit
        {
            get { return idIrrigationUnit; }
            set { idIrrigationUnit = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public String IrrigationType
        {
            get { return irrigationType; }
            set { irrigationType = value; }
        }
        
        public double IrrigationEfficiency
        {
            get { return irrigationEfficiency; }
            set { irrigationEfficiency = value; }
        }
        
        public List<Pair<DateTime, double>> IrrigationList
        {
            get { return irrigationList; }
            set { irrigationList = value; }
        }
        
        public double Surface
        {
            get { return surface; }
            set { surface = value; }
        }
        
        public List<Crop> CropList
        {
            get { return cropList; }
            set { cropList = value; }
        }
        
        public Bomb Bomb
        {
            get { return bomb; }
            set { bomb = value; }
        }
        
        public Location Location
        {
            get { return location; }
            set { location = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// TODO add description
        /// </summary>
        public IrrigationUnit()
        {
            this.IdIrrigationUnit = 0;
            this.Name = "noname";
            this.IrrigationType = "";
            this.IrrigationEfficiency = 0;
            this.IrrigationList = new List<Pair<DateTime, double>>();
            this.Surface = 0;
            this.CropList = new List<Crop>();
            this.Bomb = new Bomb();
            this.Location = new Location();
        }
        
        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pIdCrop"></param>
        /// <param name="pName"></param>
        /// <param name="pIrrigationType"></param>
        /// <param name="pIrrigationEfficiency"></param>
        /// <param name="pIrrigationList"></param>
        /// <param name="pSurface"></param>
        /// <param name="pCropList"></param>
        /// <param name="pBomb"></param>
        /// <param name="pLocation"></param>
        public IrrigationUnit(long pIdIrrigationUnit, String pName, String pIrrigationType,
            double pIrrigationEfficiency, List<Pair<DateTime, double>> pIrrigationList,
            double pSurface, List<Crop> pCropList, Bomb pBomb, Location pLocation)
        {
            this.IdIrrigationUnit = pIdIrrigationUnit;
            this.Name = pName;
            this.IrrigationType = pIrrigationType;
            this.IrrigationEfficiency = pIrrigationEfficiency;
            this.IrrigationList = pIrrigationList;
            this.Surface = pSurface;
            this.CropList = pCropList;
            this.Bomb = pBomb;
            this.Location = pLocation;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pDateTime"></param>
        /// <param name="pValue"></param>
        /// <returns></returns>
        public bool AddIrrigation(DateTime pDateTime, double pValue)
        {
            bool lReturn = false;
            try
            {
                Pair<DateTime,double> lPair = new Pair<DateTime,double>(pDateTime, pValue);
                this.IrrigationList.Add(lPair);
                lReturn = true;
            }
            catch(Exception e)
            {
                lReturn=false;
                Console.WriteLine("Error in IrrigationUnit.addIrrigation " + e.Message);
            }
            return lReturn;
        }

        #region Crop

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pCrop"></param>
        /// <returns></returns>
        public Crop ExistCrop(Crop pCrop)
        {
            Crop lReturn = null;
            if(pCrop != null)
            {
                foreach (Crop item in this.CropList)
                {
                    if(item.Equals(pCrop))
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
        /// <param name="pCrop"></param>
        /// <returns></returns>
        public Crop AddCrop(Crop pCrop)
        {
            Crop lReturn = null;
            try
            {   
                if (ExistCrop(pCrop) == null)
                {
                    this.CropList.Add(pCrop);
                    lReturn = pCrop;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error in IrrigationUnit.addCrop " + e.Message);
            }
            return lReturn;
        }

        #endregion

        /// <summary>
        /// Get Total Irrigation in List
        /// </summary>
        /// <returns></returns>
        public double GetTotalIrrigation() 
        {
            double lReturn = 0;
            foreach(Pair<DateTime,double> lIrrigation in IrrigationList)
            {
                lReturn += lIrrigation.Second;
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
            IrrigationUnit lIrrigationUnit = obj as IrrigationUnit;
            return this.Name.Equals(lIrrigationUnit.Name)
                && this.Location.Equals(lIrrigationUnit.Location)
                && this.IrrigationType.Equals(lIrrigationUnit.IrrigationType);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion

    }
}