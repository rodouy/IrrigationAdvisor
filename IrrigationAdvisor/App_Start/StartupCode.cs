using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Language;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Weather;

namespace IrrigationAdvisor.App_Start
{
    /// <summary>
    /// Create: 2015-08-30
    /// Author: rodouy
    /// Description: 
    ///     Starup class
    ///     
    /// References:
    ///     list of classes this class use
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// 
    /// </summary>
    public class StartupCode
    {
        public IrrigationSystem IASystem { get; set; }
        
        public void Main()
        {
            IASystem = IrrigationSystem.Instance;

        }

        
    }
}