using IrrigationAdvisor.Models.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Crop
{

    /// <summary>
    /// Create: 2014-10-14
    /// Author:  monicarle
    /// Description: 
    ///     Describes a Soil
    ///     
    /// References:
    ///     Location
    ///     
    /// Dependencies:
    ///     Crop
    ///     Farm
    ///     SoilService
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String
    ///     - location Location
    ///     - order int
    ///     - horizonLayer: String
    ///     - horizonLayerDepth: double
    ///     - sand: double
    ///     - limo: double
    ///     - clay: double
    ///     - organicMatter: double
    ///     - nitrogenAnalysis: int
    ///     - fieldCapacity: double
    ///     - permanentWiltingPoint: double
    ///     - bulkDensitySoil: double
    ///     
    /// 
    /// Methods:
    ///     - ClassTemplate()      -- constructor
    ///     - ClassTemplate(name)  -- consturctor with parameters
    ///     - SetName(newName)     -- method to set the name field
    /// 
    /// </summary>
    public class Soil
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - name String
        ///     - location Location
        ///     - order int
        ///     - horizonLayer: String
        ///     - horizonLayerDepth: double
        ///     - sand: double
        ///     - limo: double
        ///     - clay: double
        ///     - organicMatter: double
        ///     - nitrogenAnalysis: int
        ///     - fieldCapacity: double
        ///     - permanentWiltingPoint: double
        ///     - bulkDensitySoil: double
        /// </summary>


        private String name;
        private Location.Location location;
        private int order;
        private String horizonLayer;
        private double horizonLayerDepth;
        private double sand;
        private double limo;
        private double clay;
        private double organicMatter;
        private double nitrogenAnalysis;
        private double fieldCapacity;
        private double permanentWiltingPoint;
        private double bulkDensitySoil;
        #endregion

        #region Properties
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public Location.Location Location
        {
            get { return location; }
            set { location = value; }
        }

        public int Order
        {
            get { return order; }
            set { order = value; }
        }
        public String HorizonLayer
        {
            get { return horizonLayer; }
            set { horizonLayer = value; }
        }

        public double HorizonLayerDepth
        {
            get { return horizonLayerDepth; }
            set { horizonLayerDepth = value; }
        }

        public double Sand
        {
            get { return sand; }
            set { sand = value; }
        }

        public double Limo
        {
            get { return limo; }
            set { limo = value; }
        }

        public double Clay
        {
            get { return clay; }
            set { clay = value; }
        }


        public double OrganicMatter
        {
            get { return organicMatter; }
            set { organicMatter = value; }
        }

        public double NitrogenAnalysis
        {
            get { return nitrogenAnalysis; }
            set { nitrogenAnalysis = value; }
        }


        public double FieldCapacity
        {
            get { return fieldCapacity; }
            set { fieldCapacity = value; }
        }

        public double PermanentWiltingPoint
        {
            get { return permanentWiltingPoint; }
            set { permanentWiltingPoint = value; }
        }
        

        public double BulkDensitySoil
        {
            get { return bulkDensitySoil; }
            set { bulkDensitySoil = value; }
        }
        #endregion

        #region Construction
        public Soil() 
        {
            this.name= "";
            this.location = null;
            this.order= 0;
            this.horizonLayer = "";
            this.horizonLayerDepth = 0;
            this.sand = 0;
            this.limo = 0;
            this.clay = 0;
            this.organicMatter = 0;
            this.nitrogenAnalysis = 0;
            this.fieldCapacity = 0;
            this.permanentWiltingPoint = 0;
            this.bulkDensitySoil = 0;
        }
        public Soil (String pName,Location.Location pLocation, int pOrder, String pHorizonLayer,
            double pHorizonLayerDepth, double pSand, double pLimo, 
            double pClay, double pOrganicMatter, double pNitrogenAnalysis, 
            double pFieldCapacity, double pPermanentWiltingPoing, double pBulkDensitySoil)
    
         {
            this.name = pName ;
            this.location = pLocation;
            this.order= pOrder;
            this.horizonLayer = pHorizonLayer;
            this.horizonLayerDepth = pHorizonLayerDepth;
            this.sand = pSand;
            this.limo = pLimo;
            this.clay = pClay;
            this.organicMatter = pOrganicMatter;
            this.nitrogenAnalysis = pNitrogenAnalysis;
            this.fieldCapacity = pFieldCapacity;
            this.permanentWiltingPoint = pPermanentWiltingPoing;
            this.bulkDensitySoil = pBulkDensitySoil;

}


        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        #endregion

        #region Overrides
        #endregion

    }
}