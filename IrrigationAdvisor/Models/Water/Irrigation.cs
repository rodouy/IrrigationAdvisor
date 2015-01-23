using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IrrigationAdvisor.Models.Utilities;

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

            
            #endregion

            #region Fields

            private Utils.WaterInputType type;

            #endregion

            #region Properties

            public Utils.WaterInputType Type
            {
                get { return type; }
                set { type = value; }
            }

            #endregion

            #region Construction
            /// <summary>
            /// Constructor of ClassTemplate
            /// </summary>
            public Irrigation()
            {
                this.Type = Utils.WaterInputType.Irrigation;
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