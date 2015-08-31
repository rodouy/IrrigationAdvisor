using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IrrigationAdvisor.Models.Data;


namespace IrrigationAdvisor.Models.Agriculture
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
    ///     - soilId long
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
        #endregion

        #region Fields

        /// <summary>
        /// The fields are:
        ///     - horizonId int
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

        private long horizonId;
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
        //TODO Horizon.bulkDensitySoil question to be calculated?
        private double bulkDensitySoil;

        #endregion

        #region Properties

        
        public long HorizonId
        {
            get { return horizonId; }
            set { horizonId = value; }
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
        
        /// <summary>
        /// TODO explain method
        /// </summary>
        public Horizon()
        {
            this.HorizonId = 0;
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

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <param name="pIdHorizon"></param>
        /// <param name="pName"></param>
        /// <param name="pOrder"></param>
        /// <param name="pHorizonLayer"></param>
        /// <param name="pHorizonLayerDepth"></param>
        /// <param name="pSand"></param>
        /// <param name="pLimo"></param>
        /// <param name="pClay"></param>
        /// <param name="pOrganicMatter"></param>
        /// <param name="pNitrogenAnalysis"></param>
        /// <param name="pBulkDensitySoil"></param>
        public Horizon(long pIdHorizon, String pName, int pOrder, String pHorizonLayer,
            double pHorizonLayerDepth, double pSand, double pLimo,
            double pClay, double pOrganicMatter, double pNitrogenAnalysis,
             double pBulkDensitySoil)
        {
            this.HorizonId = pIdHorizon;
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

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <returns></returns>
        private bool isHorizonA()
        {
            //TODO verificar que la designacion de ser horizonte A es correcta (El horizonte AB se maneja como A)
            bool lReturn = true;
            if(!(this.order == 0 || this.Name.Equals("A") || this.Name.Equals("AB")))
            {
                lReturn = false;
            }
            return lReturn;
        }
        
        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <returns></returns>
        private double getFieldCapacityHorizonA()
        {
            double lReturn = 0;
            if (this.Sand != 0 && this.Clay != 0 && this.OrganicMatter != 0)
            {
                lReturn = InitialTables.HORIZON_A_FIELD_CAPACITY_GENERAL_ADJ_COEF
                            - (InitialTables.HORIZON_A_FIELD_CAPACITY_SAND_ADJ_COEF * this.Sand)
                            + (InitialTables.HORIZON_A_FIELD_CAPACITY_CLAY_ADJ_COEF * this.Clay)
                            + (InitialTables.HORIZON_A_FIELD_CAPACITY_ORGANIC_MATTER_ADJ_COEF * this.OrganicMatter);
            }
            return lReturn;
        }

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <returns></returns>
        private double getPermanentWiltingPointHorizonA()
        {
            double lReturn = 0;
            if (this.Sand != 0 && this.Clay != 0 && this.OrganicMatter != 0)
            {
                lReturn = -InitialTables.HORIZON_A_PERM_WILTING_POINT_GENERAL_ADJ_COEF
                    + (InitialTables.HORIZON_A_PERM_WILTING_POINT_SAND_ADJ_COEF * this.Sand)
                    + (InitialTables.HORIZON_A_PERM_WILTING_POINT_LIMO_ADJ_COEF * this.Limo)
                    + (InitialTables.HORIZON_A_PERM_WILTING_POINT_CLAY_ADJ_COEF * this.Clay)
                    + (InitialTables.HORIZON_A_PERM_WILTING_POINT_ORGANIC_MATTER_ADJ_COEF * this.OrganicMatter);
            }
            return lReturn;
        }

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <returns></returns>
        private double getFieldCapacityHorizonB()
        {
            double lReturn = 0;
            if (this.Sand != 0 && this.Clay != 0 && this.OrganicMatter != 0)
            {
                lReturn = InitialTables.HORIZON_B_FIELD_CAPACITY_GENERAL_ADJ_COEF
                            - (InitialTables.HORIZON_B_FIELD_CAPACITY_SAND_ADJ_COEF * this.Sand)
                            + (InitialTables.HORIZON_B_FIELD_CAPACITY_CLAY_ADJ_COEF * this.Clay)
                            + (InitialTables.HORIZON_B_FIELD_CAPACITY_ORGANIC_MATTER_ADJ_COEF * this.OrganicMatter);
            }
            return lReturn;
        }

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <returns></returns>
        private double getPermanentWiltingPointHorizonB()
        {
            double lReturn = 0;
            if (this.Sand != 0 && this.Clay != 0 && this.OrganicMatter != 0)
            {
                lReturn = (InitialTables.HORIZON_B_PERM_WILTING_POINT_ORGANIC_MATTER_ADJ_COEF 
                    * this.getFieldCapacityHorizonB())
                    - InitialTables.HORIZON_B_PERM_WILTING_POINT_GENERAL_ADJ_COEF;
            }
            return lReturn;
        }
        
        #endregion

        #region Public Methods
        
        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <returns></returns>
        public double  GetFieldCapacity()
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
            lReturn = lReturn * this.BulkDensitySoil;
            return lReturn;
        }

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <returns></returns>
        public double GetPermanentWiltingPoint() 
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
            lReturn = lReturn * this.BulkDensitySoil;
            return lReturn;
        }

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <returns></returns>
        public double GetAvailableWaterCapacity() 
        {
            double lFieldCapacity;
            double lPermanentWiltingPoint;
            double lAvailableWaterCapacity;
            lFieldCapacity = this.GetFieldCapacity();
            lPermanentWiltingPoint = this.GetPermanentWiltingPoint();
            lAvailableWaterCapacity = lFieldCapacity - lPermanentWiltingPoint;
            
            return lAvailableWaterCapacity;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Soil equals by Name, Limo, Clay, Sand and OrganicMatter
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            Horizon lHorizon = obj as Horizon;
            return this.Name.Equals(lHorizon.Name) 
                && this.Limo == lHorizon.Limo 
                && this.Clay == lHorizon.Clay 
                && this.Sand == lHorizon.Sand 
                && this.OrganicMatter == lHorizon.OrganicMatter; 
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        /// <summary>
        /// To String: Name, Sand, Limo, Clay, Organic Matter and Bulk Density
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string lReturn = this.Name + "\t\t";
            lReturn += "Sand: "+this.Sand + "\t";
            lReturn += "Limo: "+ this.Limo + "\t";
            lReturn += "Clay: "+ this.Clay + "\t";
            lReturn += "Organic Matter: "+ this.OrganicMatter + "\t\t";
            lReturn += "BulkDensity: "+ this.BulkDensitySoil + "\t";

            return lReturn;

        }
        #endregion

    }
}