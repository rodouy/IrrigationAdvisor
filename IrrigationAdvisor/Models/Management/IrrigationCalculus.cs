using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Management
{
    /// <summary>
    /// Create: 2014-11-12
    /// Author: monicarle
    /// Description: 
    ///     Do the calculus to Irrigate (or not)
    ///     
    /// References:
    ///     CropIrrigationWater
    ///     
    /// Dependencies:
    ///     IrrigationSystem
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///      + cropIrrigationWeather: CropIrrigationWeather
    ///      + hydricBalance: double
    ///      + soilHydricVolume: double
    /// 
    /// Methods:
    ///     - IrrigationCalculus()      -- constructor
    ///     - IrrigationCalculus(name)  -- consturctor with parameters
    ///     - howMuchToIrrigate(dateTime, cropIrrigationWater)
    /// </summary>
    public class IrrigationCalculus
    {

        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - calculusEvapoTraspiration: CalculusEvapoTraspiration
        ///     - calculusAvailableWater: CalculusAvailableWater
        /// </summary>
        private CalculusAvailableWater calculusAvailableWater;
        private CalculusEvapotranspiration calculusEvapotranspiration;
        
        #endregion

        #region Properties
        /// <summary>
        /// The properties are:
        /// </summary>
        
        #endregion

        #region Construction
        /// <summary>
        /// Constructor of ClassTemplate
        /// </summary>
        public IrrigationCalculus()
        {
            this.calculusAvailableWater = new CalculusAvailableWater();
            this.calculusEvapotranspiration = new CalculusEvapotranspiration();
        }

        

        #endregion

        #region Private Helpers
        
       
        #endregion

        #region Public Methods
        /// <summary>
        /// Calculate how much to irrigate in a Date.
        /// Use both ways to calculate: by available water and by acumulated evapotranspirationCrop
        /// </summary>
        /// <param name="pNewName">new name</param>
        public double howMuchToIrrigate(CropIrrigationWeatherRecords pCropIrrigationWeatherRecords)
        {
            double pReturn =0;
            double irrigationEvapTrans = calculusEvapotranspiration.howMuchToIrrigate( pCropIrrigationWeatherRecords);
            double irrigationAvWater = calculusAvailableWater.howMuchToIrrigate(pCropIrrigationWeatherRecords);
            if (irrigationEvapTrans > irrigationAvWater && irrigationEvapTrans > 0)
            {
                pReturn = irrigationEvapTrans;
            }
            else if (irrigationAvWater > 0)
            {
                pReturn = irrigationAvWater;
            }
            return pReturn;;
        }

        
        #endregion

        #region Overrides

        #endregion
    }
}