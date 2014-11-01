using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IrrigationAdvisor.Models.Water
{
    /// <summary>
    /// Create: 2014-10-30
    /// Author: monicarle
    /// Description: 
    ///     Describes an Output of water over a Crop
    ///     
    /// References:
    ///     none
    ///     
    /// Dependencies:
    ///     DailyRecord
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - input double
    ///     - date DateTime
    ///     - extraInput double
    ///     - extraDate DateTime
    /// 
    /// Methods:
    ///     - WaterOutput()      -- constructor
    ///     - WaterOutput(input, date, extraInput, extraDate)  -- consturctor with parameters
    ///     - getInputType()
    /// 
    /// </summary>
    public class WaterOutput
    {
        #region Consts

        private String TYPE = "OUTPUT";

        #endregion

        #region Fields

        private double input;
        private DateTime date;
        private double extraInput;
        private DateTime extraDate;

        #endregion

        #region Properties
        public double Input
        {
            get { return input; }
            set { input = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public double ExtraInput
        {
            get { return extraInput; }
            set { extraInput = value; }
        }

        public DateTime ExtraDate
        {
            get { return extraDate; }
            set { extraDate = value; }
        }

        #endregion

        #region Construction

        public WaterOutput()
        {
            this.Date = DateTime.Now;
            this.Input = 0;
            this.ExtraDate = DateTime.Now;
            this.ExtraInput = 0;
        }

        public WaterOutput(double pInput, DateTime pDate, double pExtraInput, DateTime pExtraDate)
        {
            this.Input = pInput;
            this.Date = pDate;
            this.ExtraInput = pExtraInput;
            this.ExtraDate = pExtraDate;
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        public String getInputType()
        {
            return this.TYPE;
        }
        #endregion

        #region Overrides
        #endregion

    }
}
