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
        ///     Describes an Irrigation over a Crop
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
        public class Irrigation : WaterInput
        {
            #region Consts

            private String TYPE = "IRRIGATION";

            #endregion

            #region Fields
            #endregion

            #region Properties
            #endregion

            #region Construction
            /// <summary>
            /// Constructor of ClassTemplate
            /// </summary>
            public Irrigation()
            {

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