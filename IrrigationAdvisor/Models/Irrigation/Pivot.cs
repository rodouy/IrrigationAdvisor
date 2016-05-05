using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Irrigation
{
    /// <summary>
    /// Create: 2014-10-26
    /// Author: monicarle
    /// Description: 
    ///     Describes a kind of Irrigation Unit with pivot
    ///     
    /// References:
    ///     IrrigationUnit
    ///     
    /// Dependencies:
    ///   
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - radius double
    /// 
    /// Methods:
    ///     - Pivot()      -- constructor
    ///     - Pivot(radius)  -- consturctor with parameters
    ///     
    /// </summary>
    public class Pivot : IrrigationUnit
    {
        #region Consts

        #endregion
        
        #region Fields

        private double radius;

        #endregion

        #region Properties

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        #endregion

        #region Construction

        public Pivot() 
        {
            this.Radius = 0;
        }

        public Pivot(double pRadius)
        {
            this.Radius = pRadius;
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