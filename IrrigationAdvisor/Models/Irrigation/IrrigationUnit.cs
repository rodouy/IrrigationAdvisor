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
        private int id;
        private String name;
        private String irrigationType;
        private double irrigationEfficiency;
        private List<Pair<DateTime, double>> irrigations;
        private double surface;
        private List<Crop> irrigationCrops;
        private Bomb bomb;
        private Location location;
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
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
        
        public List<Pair<DateTime, double>> Irrigations
        {
            get { return irrigations; }
            set { irrigations = value; }
        }
        
        public double Surface
        {
            get { return surface; }
            set { surface = value; }
        }
        
        public List<Crop> IrrigationCrops
        {
            get { return irrigationCrops; }
            set { irrigationCrops = value; }
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

        public IrrigationUnit()
        {
            this.Id = 0;
            this.Name = "noname";
            this.IrrigationType = "";
            this.IrrigationEfficiency = 0;
            this.Irrigations = new List<Pair<DateTime, double>>();
            this.Surface = 0;
            this.IrrigationCrops = new List<Crop>();
            this.Bomb = new Bomb();
            this.Location = new Location();
        }
        public IrrigationUnit(int pId, String pName, String pIrrigationType,
            double pIrrigationEfficiency, List<Pair<DateTime, double>> pIrrigations,
            double pSurface, List<Crop> pIrrigationCrops, Bomb pBomb, Location pLocation)
        {
            this.Id = pId;
            this.Name = pName;
            this.IrrigationType = pIrrigationType;
            this.IrrigationEfficiency = pIrrigationEfficiency;
            this.Irrigations = pIrrigations;
            this.Surface = pSurface;
            this.IrrigationCrops = pIrrigationCrops;
            this.Bomb = pBomb;
            this.Location = pLocation;
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        public bool addIrrigation(DateTime pDateTime, double pValue)
        {
            bool lReturn = true;
            try
            {
                Pair<DateTime,double> lPair = new Pair<DateTime,double>(pDateTime,pValue);
                this.Irrigations.Add(lPair);
                //return this.Irrigations.Contains(lPair);
            }
            catch(Exception e)
            {
                lReturn=false;
                Console.WriteLine("Error in IrrigationUnit.addIrrigation " + e.Message);
            }
            return lReturn;

        }
        public bool  addCrop(Crop pCrop)
        {
            bool lReturn = true;
            try
            {
                this.IrrigationCrops.Add(pCrop);
                //return this.IrrigationCrops.Contains(pCrop);
            }
            catch(Exception e)
            {
                lReturn=false;
                Console.WriteLine("Error in IrrigationUnit.addCrop " + e.Message);
            }
            return lReturn;
        }
        public double getTotalIrrigation() 
        {
            double lReturn = 0;
            foreach(Pair<DateTime,double> lIrrigation in Irrigations)
            {
                lReturn += lIrrigation.Second;
            }
            return lReturn;
        }
        #endregion

    }
}