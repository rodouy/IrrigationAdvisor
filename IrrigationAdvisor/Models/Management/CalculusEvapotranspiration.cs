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
    ///     Do the calculus to Irrigate (or not) by acumulated evapotraspiration mode.
    ///     
    /// References:
    ///     CropIrrigationWater
    ///     IrrigationCalculus
    ///     
    /// Dependencies:
    ///     IrrigationSystem
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String - PK (Primary Key)
    /// 
    /// Methods:
    ///     - CalculusEvapotranspiration()      -- constructor
    ///     - CalculusEvapotranspiration(name)  -- consturctor with parameters
    ///     
    /// </summary>
    public class CalculusEvapotranspiration 
    {
        #region Consts
        private double PRDETERMINATED_IRRIGATION = 20;
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     
        /// </summary>
        
        #endregion

        #region Properties
        /// <summary>
        /// The properties are:
        /// 
        /// </summary>
        
        #endregion

        #region Construction
        public CalculusEvapotranspiration()
        {

        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        public  double howMuchToIrrigate(CropIrrigationWeatherRecords pCropIrrigationWeatherRecords)
        {
            double lReturn = 0;
            double lMaxEvapotrToIrr = pCropIrrigationWeatherRecords.CropIrrigationWeather.Crop.MaxEvapotranspirationToIrrigate;
            double lEvapotrAcum = pCropIrrigationWeatherRecords.TotalEvapotranspirationCropFromLastWaterInput;
            if (lEvapotrAcum >= lMaxEvapotrToIrr)
            {
                lReturn = this.PRDETERMINATED_IRRIGATION; ;
            }
            return lReturn; ;
        }
        #endregion

        #region Overrides
        /*public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            return super
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
         */
        
        #endregion
    }
}