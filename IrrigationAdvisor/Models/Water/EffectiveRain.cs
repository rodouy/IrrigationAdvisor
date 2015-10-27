﻿using System;
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
    ///     Return the real value of a lRainItem depending on the date and the mm of the lRainItem
    ///     
    /// References:
    ///     none

    ///     
    /// Dependencies:
    ///     Region
    ///     IrrigationSystem
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - month: int   - PK (Primary Key)
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

        private long effectiveRainId;
        private String name;
        private int month;
        private Double minRain;
        private Double maxRain;
        private Double percentage;

        #endregion

        #region Properties

        
        public long EffectiveRainId
        {
            get { return effectiveRainId; }
            set { effectiveRainId = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        
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

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public EffectiveRain()
        {
            this.Name = "NoName";
            this.Month = 0;
            this.MinRain = 0;
            this.MaxRain = 0;
            this.Percentage = 0;
        }
        
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="pMonth"></param>
        /// <param name="pMinRain"></param>
        /// <param name="pMaxRain"></param>
        /// <param name="pPercentage"></param>
        public EffectiveRain(String pName, int pMonth, 
                        Double pMinRain, Double pMaxRain, 
                        Double pPercentage)
        {
            this.Name = pName;
            this.Month = pMonth;
            this.MinRain = pMinRain;
            this.MaxRain = pMaxRain;
            this.Percentage = pPercentage;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods


        public EffectiveRain UpdateEffectiveRain(String pName, 
                                                int pMonth, Double pMinRain, 
                                                Double pMaxRain, Double pPercentage)
        {
            this.Name = pName;
            this.Month = pMonth;
            this.MinRain = pMinRain;
            this.MaxRain = pMaxRain;
            this.Percentage = pPercentage;
            return this;
        }

        #endregion

        #region Overrides
        // Different region for each class override
        /// <summary>
        /// Overrides equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            EffectiveRain lEffectiveRain = obj as EffectiveRain;
            return (this.Name.Equals(lEffectiveRain.Name));
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        #endregion
    }
}