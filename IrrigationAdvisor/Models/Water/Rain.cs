﻿using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Water
{
    /// <summary>
    /// Create: 2014-10-30
    /// Author: monicarle
    /// Description: 
    ///     Describes the Rain over a Crop
    ///     
    /// References:
    ///     WaterInput
    ///     
    /// Dependencies:
    ///     
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - type String
    /// 
    /// Methods:
    ///     - Rain()      -- constructor
    ///     - GetType()
    /// 
    /// </summary>
    public class Rain : WaterInput
    {
        #region Consts

        #endregion

        #region Fields

        private Utils.WaterInputType type;

        #endregion

        #region Properties

        public Utils.WaterInputType Type
        {
            get { return type; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor of Rain
        /// </summary>
        public Rain()
        {
            this.type = Utils.WaterInputType.Rain;            
        }

        public Rain(CropIrrigationWeather pCropIrrigationWeather, DateTime pDate, double pInput)
        {
            this.type = Utils.WaterInputType.Rain;
            this.CropIrrigationWeather = pCropIrrigationWeather;
            this.Date = pDate;
            this.Input = pInput;
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