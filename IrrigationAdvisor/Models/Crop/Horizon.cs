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
    ///     Describes an Horizon
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
        private double HORIZON_A_FIELD_CAPACITY_GENERAL_ADJ_COEF = 21.977;
        private double HORIZON_A_FIELD_CAPACITY_SAND_ADJ_COEF = 0.168;
        private double HORIZON_A_FIELD_CAPACITY_CLAY_ADJ_COEF = 0.127;
        private double HORIZON_A_FIELD_CAPACITY_ORGANIC_MATTER_ADJ_COEF = 2.601;

        private double HORIZON_A_PERM_WILTING_POINT_GENERAL_ADJ_COEF = 58.1313;
        private double HORIZON_A_PERM_WILTING_POINT_SAND_ADJ_COEF = 0.5683;
        private double HORIZON_A_PERM_WILTING_POINT_LIMO_ADJ_COEF = 0.6414;
        private double HORIZON_A_PERM_WILTING_POINT_CLAY_ADJ_COEF = 0.9755;
        private double HORIZON_A_PERM_WILTING_POINT_ORGANIC_MATTER_ADJ_COEF = 0.3718;

        private double HORIZON_B_FIELD_CAPACITY_GENERAL_ADJ_COEF = 18.448;
        private double HORIZON_B_FIELD_CAPACITY_SAND_ADJ_COEF = 0.125;
        private double HORIZON_B_FIELD_CAPACITY_CLAY_ADJ_COEF = 0.295;
        private double HORIZON_B_FIELD_CAPACITY_ORGANIC_MATTER_ADJ_COEF = 1.923;
        
        private double HORIZON_B_PERM_WILTING_POINT_GENERAL_ADJ_COEF = 5;
        private double HORIZON_B_PERM_WILTING_POINT_ORGANIC_MATTER_ADJ_COEF = 0.74;

        
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - idHorizon int
        ///     - name String                   - PK
        ///     - order int
        ///     - horizonLayer: String
        ///     - horizonLayerDepth: double
        ///     - sand: double                  - PK
        ///     - limo: double                  - PK
        ///     - clay: double                  - PK
        ///     - organicMatter: double         - PK
        ///     - nitrogenAnalysis: int
        ///     - fieldCapacity: double
        ///     - permanentWiltingPoint: double
        ///     - bulkDensitySoil: double
        /// </summary>

        private int idHorizon;
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

        public int IdHorizon
        {
            get { return idHorizon; }
            set { idHorizon = value; }
        }
        
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
            this.IdHorizon = 0;
            this.Name = "";
            this.Order = 0;
            this.HorizonLayer = "";
            this.HorizonLayerDepth = 0;
            this.Sand = 0;
            this.Limo = 0;
            this.Clay = 0;
            this.OrganicMatter = 0;
            this.NitrogenAnalysis = 0;
            this.BulkDensitySoil = 0;
        }
        public Horizon(int pId, String pName, int pOrder, String pHorizonLayer,
            double pHorizonLayerDepth, double pSand, double pLimo,
            double pClay, double pOrganicMatter, double pNitrogenAnalysis,
             double pBulkDensitySoil)
        {
            this.IdHorizon = pId;
            this.Name = pName;
            this.Order = pOrder;
            this.HorizonLayer = pHorizonLayer;
            this.HorizonLayerDepth = pHorizonLayerDepth;
            this.Sand = pSand;
            this.Limo = pLimo;
            this.Clay = pClay;
            this.OrganicMatter = pOrganicMatter;
            this.NitrogenAnalysis = pNitrogenAnalysis;
            this.BulkDensitySoil = pBulkDensitySoil;

        }



        #endregion

        #region Private Helpers

        private bool isHorizonA()
        {
            //TODO verificar que la designacion de ser horizonte A es correcta (El horizonte AB se maneja como A)
            bool lReturn = true;
            if(!(this.order == 0 || this.Name .Equals("A") || this.Name.Equals("AB")))
            {
                lReturn = false;
            }
            return lReturn;
        }
        
        private double getFieldCapacityHorizonA()
        {
            double lReturn = 0;
            if (this.Sand != 0 && this.Clay != 0 && this.OrganicMatter != 0)
            {
                lReturn = this.HORIZON_A_FIELD_CAPACITY_GENERAL_ADJ_COEF
                            - (this.HORIZON_A_FIELD_CAPACITY_SAND_ADJ_COEF * this.Sand)
                            + (this.HORIZON_A_FIELD_CAPACITY_CLAY_ADJ_COEF * this.Clay)
                            + (this.HORIZON_A_FIELD_CAPACITY_ORGANIC_MATTER_ADJ_COEF * this.OrganicMatter);
            }
            return lReturn;
        }

        private double getPermanentWiltingPointHorizonA()
        {
            double lReturn = 0;
            if (this.Sand != 0 && this.Clay != 0 && this.OrganicMatter != 0)
            {
                lReturn = -this.HORIZON_A_PERM_WILTING_POINT_GENERAL_ADJ_COEF
                    + (this.HORIZON_A_PERM_WILTING_POINT_SAND_ADJ_COEF * this.Sand)
                    + (this.HORIZON_A_PERM_WILTING_POINT_LIMO_ADJ_COEF * this.Limo)
                    + (this.HORIZON_A_PERM_WILTING_POINT_CLAY_ADJ_COEF * this.Clay)
                    + (this.HORIZON_A_PERM_WILTING_POINT_ORGANIC_MATTER_ADJ_COEF * this.OrganicMatter);
            }
            return lReturn;
        }


        private double getFieldCapacityHorizonB()
        {
            double lReturn = 0;
            if (this.Sand != 0 && this.Clay != 0 && this.OrganicMatter != 0)
            {
                lReturn = this.HORIZON_B_FIELD_CAPACITY_GENERAL_ADJ_COEF
                            - (this.HORIZON_B_FIELD_CAPACITY_SAND_ADJ_COEF * this.Sand)
                            + (this.HORIZON_B_FIELD_CAPACITY_CLAY_ADJ_COEF * this.Clay)
                            + (this.HORIZON_B_FIELD_CAPACITY_ORGANIC_MATTER_ADJ_COEF * this.OrganicMatter);
            }
            return lReturn;
        }
        private double getPermanentWiltingPointHorizonB()
        {
            double lReturn = 0;
            if (this.Sand != 0 && this.Clay != 0 && this.OrganicMatter != 0)
            {
                lReturn = -this.HORIZON_B_PERM_WILTING_POINT_GENERAL_ADJ_COEF
                    + (this.HORIZON_B_PERM_WILTING_POINT_ORGANIC_MATTER_ADJ_COEF * this.getFieldCapacityHorizonB());
            }
            return lReturn;
        }
        #endregion

        #region Public Methods
        public double  getFieldCapacity()
        {
            double lReturn = 0;
            if (isHorizonA())
            {
                lReturn = this.getFieldCapacityHorizonA();
            }
            else
            {
                lReturn = this.getFieldCapacityHorizonB();
            } 
            return lReturn;
        }

        public double getPermanentWiltingPoint() 
        {
            double lReturn = 0;
            if (isHorizonA())
            {
                lReturn = this.getPermanentWiltingPointHorizonA();
            }
            else 
            {
                lReturn = this.getPermanentWiltingPointHorizonB();
            }
            return lReturn;
        }

        public double getAvailableWaterCapacity() 
        {
            return (this.getFieldCapacity()-this.getPermanentWiltingPoint()) * this.BulkDensitySoil ;
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

        public override string ToString()
        {
            string lReturn = this.Name + "\t\t";
            lReturn += "Sand: "+this.Sand + "\t";
            lReturn += "Limo: "+ this.Limo + "\t";
            lReturn += "Clay: "+ this.Clay + "\t";
            lReturn += "Org.Mat.: "+ this.OrganicMatter + "\t\t";
            lReturn += "BulkDen: "+ this.BulkDensitySoil + "\t";

            return lReturn;

        }
        #endregion

    }
}