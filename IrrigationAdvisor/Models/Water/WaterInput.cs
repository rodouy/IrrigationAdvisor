using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IrrigationAdvisor.Models.Management;
using System.ComponentModel.DataAnnotations;

namespace IrrigationAdvisor.Models.Water
{
    /// <summary>
    /// Create: 2014-10-30
    /// Author: monicarle
    /// Description: 
    ///     Describes an Output of water over a Crop
    ///     
    /// References:
    ///     Rain
    ///     EvapotranspirationCrop
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

        #endregion

        #region Fields

<<<<<<< HEAD
=======
        private long waterInputId;
>>>>>>> 58290beb60242c969fa5a51c8d9de37319de5d7c
        private double input;
        private DateTime date;
        private double extraInput;
        private DateTime extraDate;
<<<<<<< HEAD
        private Management.CropIrrigationWeather cropIrrigationWeather;
=======
>>>>>>> 58290beb60242c969fa5a51c8d9de37319de5d7c

        #endregion

        #region Properties
<<<<<<< HEAD
        public double Input
=======

        [Key]
        public long WaterInputId
        {
            get { return waterInputId; }
            set { waterInputId = value; }
        }
        
        public Double Input
>>>>>>> 58290beb60242c969fa5a51c8d9de37319de5d7c
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
<<<<<<< HEAD

        public Management.CropIrrigationWeather CropIrrigationWeather
        {
            get { return cropIrrigationWeather; }
            set { cropIrrigationWeather = value; }
        }


=======
        
>>>>>>> 58290beb60242c969fa5a51c8d9de37319de5d7c
        #endregion

        #region Construction

        public WaterInput()
        {
            this.Date = DateTime.Now;
            this.Input = 0;
            this.ExtraDate = DateTime.Now;
            this.ExtraInput = 0;
        }

<<<<<<< HEAD
        public WaterInput(double pInput, DateTime pDate, double pExtraInput, DateTime pExtraDate)
=======
        /// <summary>
        /// Contructor with parameters
        /// </summary>
        /// <param name="pWaterInputId"></param>
        /// <param name="pInput"></param>
        /// <param name="pDate"></param>
        /// <param name="pExtraInput"></param>
        /// <param name="pExtraDate"></param>
        public WaterInput(long pWaterInputId, double pInput, DateTime pDate, 
                            double pExtraInput, DateTime pExtraDate)
>>>>>>> 58290beb60242c969fa5a51c8d9de37319de5d7c
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
            WaterInput lWaterInput = obj as WaterInput;
            return this.Date.Equals(lWaterInput.Date)
                && this.Input.Equals(lWaterInput.Input);
        }

        public override int GetHashCode()
        {
            return this.Date.GetHashCode();
        }

        #endregion


    }
}
