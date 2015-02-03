using IrrigationAdvisor.Models.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Agriculture
{

    /// <summary>
    /// Create: 2014-10-23
    /// Author:  monicarle
    /// Description: 
    ///     Describes a Soil
    ///     
    /// References:
    ///     Horizon
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
    ///     - idSoil long
    ///     - name String
    ///     - description String
    ///     - location Location
    ///     - horizonList List<Horizon>
    ///     - testDate DateTime
    ///     - depthLimit double
    /// 
    /// Methods:
    ///     - Soil()      -- constructor
    ///     - Soil(name, description location, testDate, depthLimit)  -- consturctor with parameters
    ///     - GetFieldCapacity(double: RootDepth)
    ///     - GetPermanentWiltingPoint(double: RootDepth)
    ///     - GetAvailableWaterCapacity(double: RootDepth)
    /// 
    /// </summary>
    public class Soil
    {
        #region Consts
        
     
        
        enum SoilLayer
        {
            AvailableWater,
            FieldCapacity,
            PermanentWiltingPoint,
        }
        

        #endregion

        #region Fields

        private long idSoil;
        private String name;
        private String description;
        private Location location;
        private List<Horizon> horizonList;
        private DateTime testDate;
        private double depthLimit;


        #endregion

        #region Properties

        public long IdSoil
        {
            get { return idSoil; }
            set { idSoil = value; }
        }
        
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }
       
        public Location Location
        {
            get { return location; }
            set { location = value; }
        }
        
        public List<Horizon> HorizonList
        {
            get { return horizonList; }
            set { horizonList = value; }
        }

        public DateTime TestDate
        {
            get { return testDate; }
            set { testDate = value; }
        }

        public double DepthLimit
        {
            get { return depthLimit; }
            set { depthLimit = value; }
        }

        #endregion

        #region Construction
        
        public Soil() 
        {
            this.IdSoil = 0;
            this.Name= "";
            this.Description = "";
            this.Location = null;
            this.HorizonList = new List<Horizon>();
            this.TestDate = DateTime.MinValue;
            this.DepthLimit = 0;
        }

        public Soil(long pIdSoil, String pName, String pDescription, 
            Location pLocation, DateTime pTestDate, double pDepthLimit)
        {
            this.IdSoil = pIdSoil;
            this.Name = pName;
            this.Description = pDescription;
            this.Location = pLocation;
            this.HorizonList = new List<Horizon>();
            this.TestDate = pTestDate;
            this.DepthLimit = pDepthLimit;
        }
        
        #endregion

        #region Private Helpers

        /// <summary>
        ///  Toma un prorrateo: por ejemplo si el horizonte A mide 10 cm y el horizonte B mide 20:
        ///  Si la raiz tiene 15 cm tomo en cuenta 2/3 del horizonte a (10 cm iniciales) y 1/3 del horizonte B (los otros 5 cm de la planta).
        ///  
        ///  Take an average: for example if the A horizon is 10 cm and horizon B is 20 cm long:
        ///  if the root is 15 cm long the results is 2/3 of horizon A (initial 10 cm) and 1/3 of horixon B (the rest of the root)
        /// </summary>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
        private double getLayerCapacityByProrationOfHorizon(double pRootDepth, SoilLayer pSoilLayer)
        {
            double lRootDepthSum = 0;
            double lReturnLayerWaterSum = 0;
            IEnumerable<Horizon> query;
            double lRemainRoot = 0;
            double lLastHorizonLayerCapacity = 0;
            double lLastHorizonLayerDepth = 0;
            double lFieldCapacityDepthCM = 10;

            try
            {
                query = this.horizonList.OrderBy(lHorizon => lHorizon.Order);
                foreach (Horizon lHorizon in query)
                {
                    //To the root substract the passed horizon depth
                    lRemainRoot = pRootDepth - lRootDepthSum;
                    lRootDepthSum += lHorizon.HorizonLayerDepth;
                    switch (pSoilLayer)
                    {
                        case SoilLayer.AvailableWater:
                            lLastHorizonLayerCapacity = lHorizon.GetAvailableWaterCapacity();
                            break;
                        case SoilLayer.FieldCapacity:
                            lLastHorizonLayerCapacity = lHorizon.GetFieldCapacity();
                            break;
                        case SoilLayer.PermanentWiltingPoint:
                            lLastHorizonLayerCapacity = lHorizon.GetPermanentWiltingPoint();
                            break;
                        default:
                            lLastHorizonLayerCapacity = 0;
                            break;
                    }

                    lLastHorizonLayerDepth = lHorizon.HorizonLayerDepth;
                    // La raiz es mas grande que hasta este horizonte, calculo y sigo
                    if (lRootDepthSum <= pRootDepth)
                    {
                        lReturnLayerWaterSum += lLastHorizonLayerCapacity * lLastHorizonLayerDepth / lFieldCapacityDepthCM;
                    }
                    // La raiz llega/termina en este horizonte, calculo y termino
                    else if (lHorizon.HorizonLayerDepth > lRemainRoot && lRemainRoot > 0)
                    {
                        lReturnLayerWaterSum += lLastHorizonLayerCapacity * lRemainRoot / lFieldCapacityDepthCM;
                        break;
                    }
                }
                //If the root is bigger than all the horizonList i have defined
                if (lRootDepthSum < pRootDepth)
                {
                    lRemainRoot = pRootDepth - lRootDepthSum;
                    lReturnLayerWaterSum += lLastHorizonLayerCapacity * lRemainRoot / lFieldCapacityDepthCM;
                }
            }
            catch (Exception ex)
            {
                //TODO log exception ReturnLayerWaterSum
                throw ex;
            }
            return lReturnLayerWaterSum;
        }

        /// <summary>
        /// TODO Explain getHorizonByOrder
        /// </summary>
        /// <param name="pOrder"></param>
        /// <returns></returns>
        private Horizon getHorizonByOrder(int pOrder)
        {
            Horizon pReturn = new Horizon();
            foreach (Horizon lHorizon in this.horizonList)
            {
                if(pOrder == lHorizon.Order)
                {
                    pReturn = lHorizon;
                    return lHorizon;
                }
            }
            return pReturn;
        }

        /// <summary>
        /// TODO Explain getHorizonWhereFinishRootDepth
        /// </summary>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
        private Horizon getHorizonWhereFinishRootDepth(double pRootDepth)
        {
            /// rehacer ordenando por horizon.order
            Horizon lReturn = null;
            double lRootDepthSum =0;

            IEnumerable<Horizon> query = this.horizonList.OrderBy(lHorizon => lHorizon.Order);
            foreach (Horizon lHorizon in query)
            {
                lRootDepthSum += lHorizon.HorizonLayerDepth;
                if (lRootDepthSum >= pRootDepth)
                {
                    lReturn = lHorizon;
                    return lReturn;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Return the Available Water of the soil calculating the Available water of each Horizon
        /// </summary>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
        private double getAvailableWaterCapacityByProration(double pRootDepth)
        {
            double lReturnAvalilableWaterCapSum = 0;
            double lRootDepth = pRootDepth;
            if (pRootDepth > this.DepthLimit)
            {
                lRootDepth = this.DepthLimit;
            }
            lReturnAvalilableWaterCapSum = this.getLayerCapacityByProrationOfHorizon(lRootDepth, SoilLayer.AvailableWater);
            return lReturnAvalilableWaterCapSum;
        }

        #endregion

        #region Public Methods

        #region Horizon

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pHorizon"></param>
        /// <returns></returns>
        public Horizon ExistHorizon(Horizon pHorizon)
        {
            Horizon lReturn = null;
            foreach (Horizon item in HorizonList)
            {
                if(item.Equals(pHorizon))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
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
        /// <returns></returns>
        public Horizon AddHorizon(String pName, int pOrder,
                        String pHorizonLayer, double pHorizonLayerDepth, double pSand,
                        double pLimo, double pClay, double pOrganicMatter, 
                        double pNitrogenAnalysis, double pBulkDensitySoil)
        {
            Horizon lReturn = null;
            long lIdHorizon = this.HorizonList.Count();
            Horizon lHorizon = new Horizon(lIdHorizon, pName, pOrder,
                pHorizonLayer, pHorizonLayerDepth, pSand, pLimo,
                pClay, pOrganicMatter, pNitrogenAnalysis, pBulkDensitySoil);
            if (this.ExistHorizon(lHorizon) == null)
            {
                this.HorizonList.Add(lHorizon);
                lReturn = lHorizon;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
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
        /// <returns></returns>
        public Horizon UpdateHorizon(String pName, int pOrder,
                        String pHorizonLayer, double pHorizonLayerDepth, double pSand,
                        double pLimo, double pClay, double pOrganicMatter,
                        double pNitrogenAnalysis, double pBulkDensitySoil)
        {
            Horizon lReturn = null;
            long lIdHorizon = this.HorizonList.Count();
            Horizon lHorizon = new Horizon(lIdHorizon, pName, pOrder,
                pHorizonLayer, pHorizonLayerDepth, pSand, pLimo,
                pClay, pOrganicMatter, pNitrogenAnalysis, pBulkDensitySoil);
            lReturn = this.ExistHorizon(lHorizon);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Order = pOrder;
                lReturn.HorizonLayer = pHorizonLayer;
                lReturn.HorizonLayerDepth = pHorizonLayerDepth;
                lReturn.Sand = pSand;
                lReturn.Limo = pLimo;
                lReturn.Clay = pClay;
                lReturn.OrganicMatter = pOrganicMatter;
                lReturn.NitrogenAnalysis = pNitrogenAnalysis;
                lReturn.BulkDensitySoil = pBulkDensitySoil;
            }
            return lReturn;
        }

        #endregion

        /// <summary>
        /// Return the Field Capacity, depends on RootDepth
        /// </summary>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
        public double  GetFieldCapacity(double pRootDepth)
        {
            double lReturnFieldCapacity = 0;
            double lRootDepth = pRootDepth;
            if (pRootDepth > this.DepthLimit)
            {
                lRootDepth = this.DepthLimit;
            }
            lReturnFieldCapacity = this.getLayerCapacityByProrationOfHorizon(lRootDepth, SoilLayer.FieldCapacity);
            return lReturnFieldCapacity;
        }

        /// <summary>
        /// Return the Permanent Wilting Point, depends on Root Depth
        /// </summary>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
        public double GetPermanentWiltingPoint(double pRootDepth)
        {
            double lReturnPermanentWiltingPoingSum = 0;
            double lRootDepth = pRootDepth;
            if (pRootDepth > this.DepthLimit)
            {
                lRootDepth = this.DepthLimit;
            }
            lReturnPermanentWiltingPoingSum = this.getLayerCapacityByProrationOfHorizon(lRootDepth, SoilLayer.PermanentWiltingPoint);
            return lReturnPermanentWiltingPoingSum;
        }

        /// <summary>
        /// Return the Available Water of the soil as 
        ///     the difference between the Field Capacity and the Permanent WiltingPoint
        /// </summary>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
         public double GetAvailableWaterCapacity(double pRootDepth)
         {
            double lAvailableWaterCapacity;
            double lRootDepth = pRootDepth;
            if (pRootDepth > this.DepthLimit)
            {
                lRootDepth = this.DepthLimit;
            }
            lAvailableWaterCapacity = this.GetFieldCapacity(lRootDepth) - this.GetPermanentWiltingPoint(lRootDepth);
            return lAvailableWaterCapacity;
        }


        #endregion

        #region Overrides
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            Soil lSoil = obj as Soil;
            return (this.Name.Equals(lSoil.Name)&&
                this .Location.Equals(lSoil.Location));
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        public override string ToString()
        {
            string lReturn = Environment.NewLine + Environment.NewLine + this.Name + Environment.NewLine;
               foreach(Horizon lHorizon in this.HorizonList)
               {
                   lReturn += lHorizon.ToString()+ Environment.NewLine;
               }
            return lReturn;

        }
        #endregion

    }
}