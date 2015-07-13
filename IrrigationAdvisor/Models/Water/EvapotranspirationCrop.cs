using IrrigationAdvisor.Models.Management;
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

        #endregion

        #region Fields

        private Utils.WaterOutputType type;

        #endregion

        #region Properties

        public Utils.WaterOutputType Type
        {
            get { return type; }
        }

        #endregion

        #region Construction
        public EvapotranspirationCrop() 
        {
            this.type = Utils.WaterOutputType.Evapotranspiration;
        }

        public EvapotranspirationCrop(DateTime pDate, double pInput)
        {
            this.type = Utils.WaterOutputType.Evapotranspiration;
            this.Date = pDate;
            this.Input = pInput;

        }


        #region Private Helpers
        #endregion

        #region Public Methods

        
        #endregion

        #region Overrides
        #endregion

        #endregion

    }
}