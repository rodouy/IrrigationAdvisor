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
    ///     Describes a kind of Irrigation Unit with sprinkler
    ///     
    /// References:
    ///     Crop
    ///     Bomb
    ///     Location
    ///     
    /// Dependencies:
    ///   
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - width double
    ///     - lenght double
    /// 
    /// Methods:
    ///     - ClassTemplate()      -- constructor
    ///     - ClassTemplate(name)  -- consturctor with parameters
    ///     - SetName(newName)     -- method to set the name field
    /// 
    /// </summary>
    public class Sprinkler
    {
        #region Fields

        private double width;
        private double length;

        #endregion

        #region Properties
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        #endregion

        #region Construction

        public Sprinkler()
        {
            this.Width = 0;
            this.Length = 0;
        }

        public Sprinkler(double pWidth, double pLength )
        {
            this.Width = pWidth;
            this.Length = pLength;
        }
        #endregion
    }
}