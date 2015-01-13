using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Localization;
namespace IrrigationAdvisor.Models.Water
{
    /// <summary>
    /// Create: 2014-12-05
    /// Author: monicarle
    /// Description: 
    ///     Return the real value of a rain depending on the date and the mm of the rain
    ///     
    /// References:
    ///     Region

    ///     
    /// Dependencies:
    ///     Crop
    ///     IrrigationSystem
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - region  - PK (Primary Key)
    ///     - month: int
    ///     - minRain: double
    ///     - maxRain: double
    ///     - percentage: double
    /// 
    /// Methods:
    ///     - ClassTemplate()      -- constructor
    ///     - ClassTemplate(name)  -- consturctor with parameters
    ///     - SetName(newName)     -- method to set the name field
    /// 
    /// </summary>
    public class EffectiveRain
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///    + month: int
        ///    + minRain: double
        ///    + maxRain: double 
        ///    + percentage: double
        /// </summary>


        private int month;
        private double minRain;
        private double maxRain;
        private double percentage;

        #endregion

        #region Properties
        
        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public double MinRain
        {
            get { return minRain; }
            set { minRain = value; }
        }

        public double MaxRain
        {
            get { return maxRain; }
            set { maxRain = value; }
        }

        public double Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }


        #endregion

        #region Construction

        public EffectiveRain()
        {
            this.Month = 0;
            this.MinRain = 0;
            this.MaxRain = 0;
            this.Percentage = 0;
        }
        public EffectiveRain(int pMonth, double pMinRain, double pMaxRain, double pPercentage)
        {
            this.Month = pMonth;
            this.MinRain = pMinRain;
            this.MaxRain = pMaxRain;
            this.Percentage = pPercentage;
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