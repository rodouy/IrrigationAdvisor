using IrrigationAdvisor.Models.Data;
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
    ///     Do the calculus to Irrigate (or not) by hidric balance mode.
    ///     
    /// References:
    ///     CropIrrigationWater
    ///     IrrigationCalculus
    ///     
    /// Dependencies:
    ///     IrrigationSystem
    /// 
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String - PK (Primary Key)
    /// 
    /// Methods:
    ///     - CalculusAvailableWater()      -- constructor
    ///     - CalculusAvailableWater(name)  -- consturctor with parameters
    ///    
    /// </summary>
    public class CalculusAvailableWater 
    {
        #region Consts
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
        public CalculusAvailableWater()
        {

        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        /// <summary>
        /// If the Hydric Balance is lower than the Water Threhold we need to Irrigate
        /// The water Threhold is the half of the Available Water
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <returns></returns>
        public bool IrrigateByHydricBalance(CropIrrigationWeather pCropIrrigationWeather)
        {
            bool lReturn = false;
            double lAvailableWater;
            double lHydricBalance;
            double lPermanentWiltingPoint;
            double lThreshold;
            double lMinEvapotrasnpirationToIrrigate;
            double lEvapotrAcum;

            lAvailableWater = pCropIrrigationWeather.GetSoilAvailableWaterCapacity();
            lPermanentWiltingPoint = pCropIrrigationWeather.GetSoilPermanentWiltingPoint();
            //This is the Threshold to determinate the need of lIrrigationItem
            lThreshold = Math.Round(lAvailableWater * InitialTables.PERCENTAGE_LIMIT_OF_AVAILABLE_WATER_CAPACITY, 2) + lPermanentWiltingPoint;

            lMinEvapotrasnpirationToIrrigate = pCropIrrigationWeather.Crop.MinEvapotranspirationToIrrigate;

            lEvapotrAcum = pCropIrrigationWeather.GetTotalEvapotranspirationCropFromLastWaterInput();
            
            lHydricBalance = pCropIrrigationWeather.GetHydricBalance();
            
            if (lHydricBalance <= lThreshold && lEvapotrAcum >= lMinEvapotrasnpirationToIrrigate)
            {
                lReturn = true;
            }

            return lReturn;
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