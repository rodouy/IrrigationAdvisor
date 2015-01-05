using IrrigationAdvisor.Models.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Crop
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
    ///     - idSoil
    ///     - name String
    ///     - location Location
    ///     - horizons List<Horizon>
    /// 
    /// Methods:
    ///     - Soil()      -- constructor
    ///     - Soil(location, horizons)  -- consturctor with parameters
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
        private Location.Location location;
        private List<Horizon> horizons;
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
       
        public Location.Location Location
        {
            get { return location; }
            set { location = value; }
        }
        public List<Horizon> Horizons
        {
            get { return horizons; }
            set { horizons = value; }
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
            this.Horizons = new List<Horizon>();
            this.TestDate = DateTime.MinValue;
            this.DepthLimit = 0;
            
            
        }

        public Soil(long pId, String pName, String pDescription, Location.Location pLocation, DateTime pTestDate, double pDepthLimit)
        {
            this.IdSoil = pId;
            this.Name = pName;
            this.Description = pDescription;
            this.Location = pLocation;
            this.Horizons = new List<Horizon>();
            this.TestDate = pTestDate;
            this.DepthLimit = pDepthLimit;

        }
        public Soil (int pId,String pName,Location.Location pLocation,List <Horizon > pListHorizon)
    
         {
            this.IdSoil = pId;
            this.Name = pName ;
            this.Location = pLocation;
            this.Horizons = pListHorizon;
            
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
                query = this.horizons.OrderBy(lHorizon => lHorizon.Order);
                foreach (Horizon lHorizon in query)
                {
                    //To the root substract the passed horizon depth
                    lRemainRoot = pRootDepth - lRootDepthSum;
                    lRootDepthSum += lHorizon.HorizonLayerDepth;
                    switch (pSoilLayer)
                    {
                        case SoilLayer.AvailableWater:
                            lLastHorizonLayerCapacity = lHorizon.getAvailableWaterCapacity();
                            break;
                        case SoilLayer.FieldCapacity:
                            lLastHorizonLayerCapacity = lHorizon.getFieldCapacity();
                            break;
                        case SoilLayer.PermanentWiltingPoint:
                            lLastHorizonLayerCapacity = lHorizon.getPermanentWiltingPoint();
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
                //If the root is bigger than all the horizons i have defined
                if (lRootDepthSum < pRootDepth)
                {
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
            foreach (Horizon lHorizon in this.horizons)
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

            IEnumerable<Horizon> query = this.horizons.OrderBy(lHorizon => lHorizon.Order);
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

        #endregion

        #region Public Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
        public double  getFieldCapacity(double pRootDepth)
        {
            double lReturnFieldCapacity = 0;
            
            lReturnFieldCapacity = this.getLayerCapacityByProrationOfHorizon(pRootDepth, SoilLayer.FieldCapacity);
            return lReturnFieldCapacity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
        public double getPermanentWiltingPoint(double pRootDepth)
        {
            double lReturnPermanentWiltingPoingSum = 0;
            
            lReturnPermanentWiltingPoingSum = this.getLayerCapacityByProrationOfHorizon(pRootDepth, SoilLayer.PermanentWiltingPoint);
            return lReturnPermanentWiltingPoingSum;
        }

        /// <summary>
        /// Return the Available Water of the soil calculating the Available water of each Horizon
        /// </summary>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
        public double getAvailableWaterCapacityByProration(double pRootDepth)
        {
            double lReturnAvalilableWaterCapSum = 0;
            
            lReturnAvalilableWaterCapSum = this.getLayerCapacityByProrationOfHorizon(pRootDepth, SoilLayer.AvailableWater);
            return lReturnAvalilableWaterCapSum;
        }

        /// <summary>
        /// Return the Available Water of the soil as the difference between the Field Capacity and the Permanent WiltingPoint
        /// </summary>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
         public double getAvailableWaterCapacity(double pRootDepth)
         {
            double lReturn;
            lReturn = this.getFieldCapacity(pRootDepth) - this.getPermanentWiltingPoint(pRootDepth);
            return lReturn;
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
               foreach(Horizon lHorizon in this.Horizons)
               {
                   lReturn += lHorizon.ToString()+ Environment.NewLine;
               }
            return lReturn;

        }
        #endregion

    }
}