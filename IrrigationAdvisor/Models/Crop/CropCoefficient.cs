using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Crop
{
    /// <summary>
    /// Create: 2014-10-14
    /// Author: rodouy - monicarle
    /// Description: 
    ///     Returns the Kc for a Specie in a Region 
    ///     It depends on the days after sowing
    ///     
    /// References:
    ///     Specie
    ///     Region
    ///     
    /// Dependencies:
    ///     Crop
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - specie Specie
    ///     - region region
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
    ///     - CropCoefficient(specie, region, initialDays, initialKC
    ///         developmentDays, developmentKC, midSeasonDays
    ///         midSeasonKC, lateSeasonDays, lateSeasonKC)  -- consturctor with parameters
    ///     - getKC(days)     -- method to get the name KC
    /// 
    /// </summary>
    
    public class CropCoefficient
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - specie Specie
        ///     - region region
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
        private Specie specie;
        private Location.Region region;
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
        public Specie Specie
        {
            get { return specie; }
            set { specie = value; }
        }
        
        public Location.Region Region
        {
            get { return region; }
            set { region = value; }
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
        /// Constructor of ClassTemplate
        /// </summary>
        public CropCoefficient()
        {
            this.Specie = new Specie();
            this.Region = new Location.Region();
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
        /// Constructor of ClassTemplate with parameters
        /// </summary>
        /// <param name="pNewName"></param>
        public CropCoefficient(Specie pSpecie, Location.Region pRegion, int pInitialDays,
            double pInitialDaysKC,int pDevelopmentDays , double pDevelopmentKC,
               int pMidSeasonDays, double pMidSeasonKC, int pLateSeasonDays, double pLateSeasonKC )
        {
            this.Specie = pSpecie;
            this.Region = pRegion;
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
        #endregion

        #region Public Methods
        public double getKC(int days)
        {
            double pReturn = 0;
            if (days > 0 && days <= this.InitialDays)
            {
                pReturn = this.InitialKC; 
            }
            else if (days > this.InitialDays && days <= this.DevelopmentDays)
            {
                pReturn = this.InitialKC; 
            }
            else if (days > this.DevelopmentDays && days <= this.MidSeasonDays)
            {
                pReturn = this.InitialKC;
            }
            return pReturn;

        }
        #endregion

        #region Overrides
        #endregion

    }
}