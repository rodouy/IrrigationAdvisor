﻿using IrrigationAdvisor.Models.Location;
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
        ///  Toma un prorrateo: por ejemplo si el horizonte A mide 10 cm y el horizonte B mide 20:
        ///  Si la raiz tiene 15 cm tomo en cuenta 2/3 del horizonte a (10 cm iniciales) y 1/3 del horizonte B (los otros 5 cm de la planta).
        ///  
        ///  Take an average: for example if the A horizon is 10 cm and horizon B is 20 cm long:
        ///  if the root is 15 cm long the results is 2/3 of horizon A (initial 10 cm) and 1/3 of horixon B (the rest of the root)
        /// </summary>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
        public double  getFieldCapacity(double pRootDepth)
        {
            double lRootDepthSum = 0;
            double lReturnFieldCapacity = 0;
            double lFactor = 0;
            bool findLastHorizon = false;
            IEnumerable<Horizon> query = this.horizons.OrderBy(lHorizon => lHorizon.Order);
            foreach (Horizon lHorizon in query)
            {

                lRootDepthSum += lHorizon.HorizonLayerDepth;
                double remainRoot = pRootDepth - (lRootDepthSum - lHorizon.HorizonLayerDepth);
                // La raiz llega/termina en este horizonte, calculo y termino
                if (lHorizon.HorizonLayerDepth > remainRoot && !findLastHorizon)
                {
                    
                    lFactor = Math.Round(remainRoot / lHorizon.HorizonLayerDepth, 2);
                    lReturnFieldCapacity += lFactor * lHorizon.getFieldCapacity() * lHorizon.HorizonLayerDepth / 10;
                    findLastHorizon = true;
                    return lReturnFieldCapacity;
                }
                else if (lRootDepthSum <= pRootDepth )// La raiz es mas grande que hasta este horizonte, calculo y sigo
                {
                    lReturnFieldCapacity += lHorizon.getFieldCapacity() * lHorizon.HorizonLayerDepth / 10;
                }
                
                //TODO ver que pasa si la raiz es mas grande que la suma de todos los horizontes
            }

            return lReturnFieldCapacity;
        }
        public double getPermanentWiltingPoint(double pRootDepth)
        {
            double lRootDepthSum = 0;
            double lReturnPermanentWPoint = 0;
            double lFactor = 0;
            bool findLastHorizon = false;
            IEnumerable<Horizon> query = this.horizons.OrderBy(lHorizon => lHorizon.Order);
            foreach (Horizon lHorizon in query)
            {

                lRootDepthSum += lHorizon.HorizonLayerDepth;
                double remainRoot = pRootDepth - (lRootDepthSum - lHorizon.HorizonLayerDepth);
                // La raiz llega/termina en este horizonte, calculo y termino
                if (lHorizon.HorizonLayerDepth > remainRoot && !findLastHorizon)
                {

                    lFactor = Math.Round(remainRoot / lHorizon.HorizonLayerDepth, 2);
                    lReturnPermanentWPoint += lFactor * lHorizon.getPermanentWiltingPoint() * lHorizon.HorizonLayerDepth / 10;
                    findLastHorizon = true;
                    return lReturnPermanentWPoint;
                }
                else if (lRootDepthSum <= pRootDepth)// La raiz es mas grande que hasta este horizonte, calculo y sigo
                {
                    lReturnPermanentWPoint += lHorizon.getPermanentWiltingPoint() * lHorizon.HorizonLayerDepth / 10;
                }

                //TODO ver que pasa si la raiz es mas grande que la suma de todos los horizontes
            }

            return lReturnPermanentWPoint;
        }
       
        public double getAvailableWaterCapacity(double pRootDepth)
        {
            double lRootDepthSum = 0;
            double lReturnAvalilableWaterCap = 0;
            double lFactor = 0;
            bool findLastHorizon = false;
            IEnumerable<Horizon> query = this.horizons.OrderBy(lHorizon => lHorizon.Order);
            foreach (Horizon lHorizon in query)
            {

                lRootDepthSum += lHorizon.HorizonLayerDepth;
                double remainRoot = pRootDepth - (lRootDepthSum - lHorizon.HorizonLayerDepth);
                // La raiz llega/termina en este horizonte, calculo y termino
                if (lHorizon.HorizonLayerDepth > remainRoot && !findLastHorizon)
                {

                    lFactor = Math.Round(remainRoot / lHorizon.HorizonLayerDepth, 2);
                    lReturnAvalilableWaterCap += lFactor * lHorizon.getAvailableWaterCapacity() * lHorizon.HorizonLayerDepth / 10;
                    findLastHorizon = true;
                    return lReturnAvalilableWaterCap;
                }
                else if (lRootDepthSum <= pRootDepth)// La raiz es mas grande que hasta este horizonte, calculo y sigo
                {
                    lReturnAvalilableWaterCap += lHorizon.getAvailableWaterCapacity() * lHorizon.HorizonLayerDepth / 10;
                }

                //TODO ver que pasa si la raiz es mas grande que la suma de todos los horizontes
            }

            return lReturnAvalilableWaterCap;
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