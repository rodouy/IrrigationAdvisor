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
    ///     - output double
    ///     - date DateTime         - PK
    ///     - extraOutput double
    ///     - extraDate DateTime    
    ///     - cropIrrigationWeather - PK
    ///     - type String
    /// 
    /// Methods:
    ///     - WaterInput()      -- constructor
    ///     - WaterInput(output, date, extraOutput, extraDate)  -- consturctor with parameters
    ///     - GetOutputType()
    /// 
    /// </summary>
    public class WaterInput
    {
        #region Consts

        private String TYPE = "INPUT";

        #endregion

        #region Fields

        private double input;
        private DateTime date;
        private double extraInput;
        private DateTime extraDate;
        private Management.CropIrrigationWeather cropIrrigationWeather;

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

        public Management.CropIrrigationWeather CropIrrigationWeather
        {
            get { return cropIrrigationWeather; }
            set { cropIrrigationWeather = value; }
        }


        #endregion

        #region Construction

        public WaterInput()
        {
            this.Date = DateTime.Now;
            this.Input = 0;
            this.ExtraDate = DateTime.Now;
            this.ExtraInput = 0;
        }

        public WaterInput(double pInput, DateTime pDate, double pExtraInput, DateTime pExtraDate)
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

        /// <summary>
        /// Get the Water output Type
        /// </summary>
        /// <returns></returns>
        public String GetInputType()
        {
            return this.TYPE;
        }

        /// <summary>
        /// Get the Input plus the Extra Input
        /// </summary>
        /// <returns></returns>
        public double GetTotalInput()
        {
            return this.Input + this.ExtraInput;
        }
        
        #endregion

        #region Overrides

        /// <summary>
        /// Return the Total Input
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string lReturn = this.GetTotalInput().ToString();
            return lReturn;

        }

        #endregion


    }
}
