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
    ///     - WaterOutput()      -- constructor
    ///     - WaterOutput(output, date, extraOutput, extraDate)  -- consturctor with parameters
    ///     - GetOutputType()
    /// 
    /// </summary>
    public abstract class WaterOutput
    {
        #region Consts

        private String TYPE = "OUTPUT";

        #endregion

        #region Fields

        private long waterOutputId;
        private Double output;
        private DateTime date;
        private Double extraOutput;
        private DateTime extraDate;
        private long cropIrrigationWeatherId;
        private Management.CropIrrigationWeather cropIrrigationWeather;


        #endregion

        #region Properties

        
        public long WaterOutputId
        {
            get { return waterOutputId; }
            set { waterOutputId = value; }
        }

        public Double Output
        {
            get { return output; }
            set { output = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public double ExtraOutput
        {
            get { return extraOutput; }
            set { extraOutput = value; }
        }

        public DateTime ExtraDate
        {
            get { return extraDate; }
            set { extraDate = value; }
        }

        public long CropIrrigationWeatherId
        {
            get { return cropIrrigationWeatherId; }
            set { cropIrrigationWeatherId = value; }
        }

        public virtual Management.CropIrrigationWeather CropIrrigationWeather
        {
            get { return cropIrrigationWeather; }
            set { cropIrrigationWeather = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Contructor without parameters
        /// </summary>
        public WaterOutput()
        {
            this.Date = DateTime.Now;
            this.Output = 0;
            this.ExtraDate = DateTime.Now;
            this.ExtraOutput = 0;
            this.CropIrrigationWeatherId = 0;
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="pOutput"></param>
        /// <param name="pDate"></param>
        /// <param name="pExtraOutput"></param>
        /// <param name="pExtraDate"></param>
        public WaterOutput(Double pOutput, DateTime pDate, Double pExtraOutput,
                            DateTime pExtraDate, long pCropIrrigationWeatherId)
        {
            this.Output = pOutput;
            this.Date = pDate;
            this.ExtraOutput = pExtraOutput;
            this.ExtraDate = pExtraDate;
            this.CropIrrigationWeatherId = pCropIrrigationWeatherId;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        /// <summary>
        /// Get the Water Output type
        /// </summary>
        /// <returns></returns>
        public String GetOutputType()
        {
            return this.TYPE;
        }

        /// <summary>
        /// Get the Output plus ExtraOutput
        /// </summary>
        /// <returns></returns>
        public double GetTotalOutput()
        {
            return this.Output + this.ExtraOutput;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Return the Total Input
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string lReturn = this.GetTotalOutput().ToString();
            return lReturn;

        }

        #endregion

    }
}
