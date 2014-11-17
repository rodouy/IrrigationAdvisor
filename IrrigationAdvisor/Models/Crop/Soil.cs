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
        #endregion

        #region Fields

        private int idSoil;
        private String name;
        private Location.Location location;
        private List<Horizon> horizons;

        #endregion

        #region Properties


        public int IdSoil
        {
            get { return idSoil; }
            set { idSoil = value; }
        }
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
        public List<Horizon> Horizons
        {
            get { return horizons; }
            set { horizons = value; }
        }
        
        
        #endregion

        #region Construction
        public Soil() 
        {
            this.IdSoil = 0;
            this.Name= "";
            this.Location = null;
            this.Horizons = new List<Horizon>();
            
        }

        public Soil(int pId, String pName, Location.Location pLocation)
        {
            this.IdSoil = pId;
            this.Name = pName;
            this.Location = pLocation;
            this.Horizons = new List<Horizon>();

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

        private Horizon getHorizonByOrder(int pOrder)
        {
            Horizon pReturn = new Horizon();
            foreach (Horizon lHorizon in this.horizons)
            {
                if(pOrder== lHorizon.Order)
                {
                    pReturn=lHorizon;
                    return lHorizon;
                }
            }
            return pReturn;
        }
        private Horizon getHorizonByRootDepth(double pRootDepth)
        {
            /// rehacer ordenando por horizon.order
            Horizon lReturn = new Horizon();
            double lRootDepthSum =0;
            for(int i =0; i< this.horizons.Count; i++)
            {
                Horizon lHorizon = this.getHorizonByOrder(i);
                if (lHorizon != null)
                {
                    lRootDepthSum += lHorizon.HorizonLayerDepth;
                    if (lRootDepthSum >= pRootDepth)
                    {
                        lReturn = lHorizon;
                        lReturn = lHorizon;
                        return lReturn;
                    }
                    else
                    {
                        //The HorizonLayerDepth of each horizon is relative to this horizon. Not form the surface of the soil.
                        pRootDepth -= lHorizon.HorizonLayerDepth;
                    }
                }
                
            }
            return lReturn;
        }
        #endregion

        #region Public Methods
        public double  getFieldCapacity(double pRootDepth)
        {
            Horizon lHorizon = this.getHorizonByRootDepth(pRootDepth);
            return lHorizon.getFieldCapacity();
        }
        public double getPermanentWiltingPoint(double pRootDepth)
        {
            Horizon lHorizon = this.getHorizonByRootDepth(pRootDepth);
            return lHorizon.getPermanentWiltingPoint();
        }
       
        public double getAvailableWaterCapacity(double pRootDepth)
        {
            Horizon lHorizon = this.getHorizonByRootDepth(pRootDepth);
            return lHorizon.getAvailableWaterCapacity();
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
        #endregion

    }
}