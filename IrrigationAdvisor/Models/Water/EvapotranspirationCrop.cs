using IrrigationAdvisor.Models.Management;
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
    ///     Describes the EvapoTranspiration over a Crop
    ///     
    /// References:
    ///     WaterOutput
    ///     
    /// Dependencies:
    ///     
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - type String
    /// 
    /// Methods:
    ///     - EvapotranspirationCrop()      -- constructor
    ///     - GetType()
    /// 
    /// </summary>
    public class EvapotranspirationCrop: WaterOutput
    {
        #region Consts

        private String TYPE = "EVAPOTRANSPIRATION";

        #endregion

        #region Fields
        #endregion

        #region Properties
        #endregion

        #region Construction
        public EvapotranspirationCrop() 
        {

        }

        public EvapotranspirationCrop(CropIrrigationWeather pCropIrrigationWeather, DateTime pDate, double pInput)
        {
            this.CropIrrigationWeather = pCropIrrigationWeather;
            this.Date = pDate;
            this.Input = pInput;

        }


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

        #endregion

    }
}