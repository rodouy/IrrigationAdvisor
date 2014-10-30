using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Crop
{
    /// <summary>
    /// Create: 2014-10-28
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
    ///     - permanentWiltingPoint: double
    ///     - bulkDensitySoil: double
    ///     
    /// 
    /// Methods:
    ///     - Horizon()      -- constructor
    ///     - Horizon(name, location, order, horizonLayer, horizonLayerDepth, sand, 
    ///       limo, clay, organicMatter, nitrogenAnalysis, fieldCapacity, 
    ///       permanentWiltingPoint, bulkDensitySoil)  -- consturctor with parameters
    /// 
    /// </summary>
    public class Horizon
    {
        #region Consts
        /// <summary>
        /// 
        /// </summary>
        private double FIELD_CAPACITY_GENERAL_ADJ_COEF = 21.977;
        private double FIELD_CAPACITY_SAND_ADJ_COEF = 0.168;
        private double FIELD_CAPACITY_CLAY_ADJ_COEF = 0.127;
        private double FIELD_CAPACITY_ORGANIC_MATTER_ADJ_COEF = 2.601;
        
        private double PERM_WILTING_POINT_GENERAL_ADJ_COEF = 58.1313;
        private double PERM_WILTING_POINT_SAND_ADJ_COEF = 0.5683;
        private double PERM_WILTING_POINT_LIMO_ADJ_COEF = 0.6414;
        private double PERM_WILTING_POINT_CLAY_ADJ_COEF = 0.9755;
        private double PERM_WILTING_POINT_ORGANIC_MATTER_ADJ_COEF = 0.3718;

        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - name String
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
        private int order;
        private String horizonLayer;
        /// <summary>
        /// The HorizonLayerDepth is relative to this horizon. Not form the surface of the soil.
        /// </summary>
        private double horizonLayerDepth;
        private double sand;
        private double limo;
        private double clay;
        private double organicMatter;
        private double nitrogenAnalysis;
        private double bulkDensitySoil;
        #endregion

        #region Properties
        public String Name
        {
            get { return name; }
            set { name = value; }
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

        public double BulkDensitySoil
        {
            get { return bulkDensitySoil; }
            set { bulkDensitySoil = value; }
        }
        #endregion

        #region Construction
        public Horizon()
        {
            this.name = "";
            this.order = 0;
            this.horizonLayer = "";
            this.horizonLayerDepth = 0;
            this.sand = 0;
            this.limo = 0;
            this.clay = 0;
            this.organicMatter = 0;
            this.nitrogenAnalysis = 0;
            this.bulkDensitySoil = 0;
        }
        public Horizon(String pName, int pOrder, String pHorizonLayer,
            double pHorizonLayerDepth, double pSand, double pLimo,
            double pClay, double pOrganicMatter, double pNitrogenAnalysis,
             double pBulkDensitySoil)
        {
            this.name = pName;
            this.order = pOrder;
            this.horizonLayer = pHorizonLayer;
            this.horizonLayerDepth = pHorizonLayerDepth;
            this.sand = pSand;
            this.limo = pLimo;
            this.clay = pClay;
            this.organicMatter = pOrganicMatter;
            this.nitrogenAnalysis = pNitrogenAnalysis;
            this.bulkDensitySoil = pBulkDensitySoil;

        }



        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        public double  getFieldCapacity()
        {
            return this.FIELD_CAPACITY_GENERAL_ADJ_COEF 
                -(this.FIELD_CAPACITY_SAND_ADJ_COEF*this.Sand)
                +(this.FIELD_CAPACITY_CLAY_ADJ_COEF*this.Clay)
                +(this.FIELD_CAPACITY_ORGANIC_MATTER_ADJ_COEF*this.OrganicMatter);
        }

        public double getPermanentWiltingPoint() 
        {
            return -this.PERM_WILTING_POINT_GENERAL_ADJ_COEF
                +(this.FIELD_CAPACITY_SAND_ADJ_COEF*this.Sand)
                +(this.PERM_WILTING_POINT_LIMO_ADJ_COEF*this.Limo)
                +(this.PERM_WILTING_POINT_CLAY_ADJ_COEF*this.Clay)
                +(this.PERM_WILTING_POINT_ORGANIC_MATTER_ADJ_COEF*this.OrganicMatter);
        }
        public double getAvailableWaterCapacity() 
        {
            return this.getFieldCapacity()-this.getPermanentWiltingPoint() ;
        }
        #endregion

        #region Overrides
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            Horizon lHorizon = obj as Horizon;
            return this.Name.Equals(lHorizon.Name) &&
                this.Limo == lHorizon.Limo && this.Clay== lHorizon.Clay &&
                this.Sand == lHorizon.Sand && this.OrganicMatter==lHorizon.OrganicMatter; 
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        #endregion

    }
}