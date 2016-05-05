using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models
{
    /// <summary>
    /// Create: 2015-08-25
    /// Author: rodouy
    /// Description: 
    ///     Returns the CropCoefficient for a Specie in a Region 
    ///     It depends on the days after sowing
    ///     
    /// References:
    ///     
    ///     
    /// Dependencies:
    ///     Specie
    /// 
    /// TODO: 
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - cropCoefficientTableId long
    ///     - initialDays int
    ///     - initialKC double
    ///     - developmentDays int
    ///     - developmentKC double
    ///     - midSeasonDays int
    ///     - midSeasonKC double
    ///     - lateSeasonDays int
    ///     - lateSeasonKC double
    ///     
    /// 
    /// Methods:
    ///     - CropCoefficient()      -- constructor
    ///     - CropCoefficient(cropCoefficientTableId, initialDays, initialKC
    ///         developmentDays, developmentKC, midSeasonDays
    ///         midSeasonKC, lateSeasonDays, lateSeasonKC)  -- consturctor with parameters
    ///     - GetCropCoefficient(days)     -- method to get the name KC
    /// 
    /// </summary>
    public class CropCoefficientTable
    {
        
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - cropCoefficientTableId long
        ///     - initialDays int
        ///     - initialKC double
        ///     - developmentDays int
        ///     - developmentKC double
        ///     - midSeasonDays int
        ///     - midSeasonKC double
        ///     - lateSeasonDays int
        ///     - lateSeasonKC double
        ///     
        /// </summary>
        private long cropCoefficientTableId;
        private int initialDays;
        private double initialKC;
        private int developmentDays;
        private double developmentKC;
        private int midSeasonDays;
        private double midSeasonKC;
        private int lateSeasonDays;
        private double lateSeasonKC;

        #endregion

        #region Properties

        
        public long CropCoefficientTableId
        {
            get { return cropCoefficientTableId; }
            set { cropCoefficientTableId = value; }
        }
        
        public int InitialDays
        {
            get { return initialDays; }
            set { initialDays = value; }
        }
        
        public double InitialKC
        {
            get { return initialKC; }
            set { initialKC = value; }
        }
        
        public int DevelopmentDays
        {
            get { return developmentDays; }
            set { developmentDays = value; }
        }
        
        public double DevelopmentKC
        {
            get { return developmentKC; }
            set { developmentKC = value; }
        }
        
        public int MidSeasonDays
        {
            get { return midSeasonDays; }
            set { midSeasonDays = value; }
        }
        
        public double MidSeasonKC
        {
            get { return midSeasonKC; }
            set { midSeasonKC = value; }
        }
        
        public int LateSeasonDays
        {
            get { return lateSeasonDays; }
            set { lateSeasonDays = value; }
        }
        
        public double LateSeasonKC
        {
            get { return lateSeasonKC; }
            set { lateSeasonKC = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor of CropCoefficientTable
        /// UsingTable: field used to return the cropCroefficient. 
        /// - False: return the cropCoefficient from the list (day by day). 
        /// - True: return the cropCoefficient from the table (with 4 fixed points) 
        /// </summary>
        public CropCoefficientTable()
        {
            this.CropCoefficientTableId = 0;
            this.InitialDays = 0;
            this.InitialKC = 0;
            this.DevelopmentDays = 0;
            this.DevelopmentKC = 0;
            this.MidSeasonDays = 0;
            this.MidSeasonKC = 0;
            this.LateSeasonDays = 0;
            this.LateSeasonKC = 0;
        }

        /// <summary>
        /// Constructor of CropCoefficientTable with all parameters
        /// </summary>
        /// <param name="pName"></param>
        public CropCoefficientTable(long pCropCoefficientTableId, 
                                int pInitialDays, double pInitialDaysKC, 
                                int pDevelopmentDays , double pDevelopmentKC, 
                                int pMidSeasonDays, double pMidSeasonKC, 
                                int pLateSeasonDays, double pLateSeasonKC)
                                
        {
            this.CropCoefficientTableId = pCropCoefficientTableId;
            this.InitialDays = pInitialDays;
            this.InitialKC = pInitialDaysKC;
            this.DevelopmentDays = pDevelopmentDays;
            this.DevelopmentKC = pDevelopmentKC;
            this.MidSeasonDays = pMidSeasonDays;
            this.MidSeasonKC = pMidSeasonKC;
            this.LateSeasonDays = pLateSeasonDays;
            this.LateSeasonKC = pLateSeasonKC;
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Get Crop Coefficient between two point in the Graph
        /// </summary>
        /// <param name="pIntialKC"></param>
        /// <param name="pEndKC"></param>
        /// <param name="pDays"></param>
        /// <param name="pTotalDays"></param>
        /// <returns></returns>
        private double getKCBetweenPoints(double pIntialKC, double pEndKC, int pDays, int pTotalDays) 
        {
            double lReturn = 0;
            double lValueRange = pEndKC - pIntialKC;

            lReturn = pIntialKC + (lValueRange / pTotalDays * pDays);
            return Math.Round(lReturn, 2);
        }
        
        /// <summary>
        /// Return the KC using a Table with 4 fixed points
        /// </summary>
        /// <param name="pDays"></param>
        /// <returns></returns>
        private double getKCFromTable(int pDays)
        {
            double pReturn = 0;
            int lDays = 0;
            int lTotalDays = 0;
            if (pDays > 0 && pDays <= this.InitialDays)
            {
                pReturn = this.InitialKC;
            }
            else if (pDays > this.InitialDays && pDays <= this.DevelopmentDays)
            {
                lDays = pDays-this.InitialDays;
                lTotalDays = this.DevelopmentDays - this.InitialDays;
                pReturn = getKCBetweenPoints(this.initialKC, this.DevelopmentKC, lDays, lTotalDays);
            }
            else if (pDays > this.DevelopmentDays && pDays <= this.MidSeasonDays)
            {
                pReturn = this.MidSeasonKC;
            }
            else if (pDays > this.MidSeasonDays && pDays <= this.LateSeasonDays)
            {
                lDays = pDays - this.MidSeasonDays;
                lTotalDays = this.LateSeasonDays - this.MidSeasonDays;
                pReturn = getKCBetweenPoints(this.MidSeasonKC, this.LateSeasonKC, lDays, lTotalDays);
            }
            else if (pDays > this.LateSeasonDays)
            {
                pReturn = this.LateSeasonKC;
            }
            return pReturn;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Returns the KC for a Crop giving the days after sowing.
        /// </summary>
        /// <param name="pDays">Days after sowing of the Crop</param>
        /// <returns></returns>
        public double GetCropCoefficient(int pDays)
        {
            double lReturn = 0;
            
            lReturn = this.getKCFromTable(pDays);
            
            return lReturn;
        }

        #endregion

        #region Overrides
        // Different region for each class override

        /// <summary>
        /// Overrides equals
        /// name, region, specie
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool lReturn = false;
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            CropCoefficientTable lCropCoefficientTable = obj as CropCoefficientTable;
            lReturn = this.CropCoefficientTableId.Equals(lCropCoefficientTable.CropCoefficientTableId);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.CropCoefficientTableId.GetHashCode();
        }
        
        #endregion

    }
}