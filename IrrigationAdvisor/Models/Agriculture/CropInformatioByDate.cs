using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Utilities;

namespace IrrigationAdvisor.Models.Agriculture
{
    /// <summary>
    /// Create: 2015-06-06
    /// Author: monicarle
    /// Description: 
    ///     It represents a specific day in the phenology.
    ///     It depends on the sowing date, average temperature registry, 
    ///     crop coefficient
    ///     
    /// References:
    ///     ?
    ///     
    /// Dependencies:
    /// 
    ///     PhenologicalStage
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - phenologicalStage:            PhenologicalStage  - PK
    ///     - sowingDate:                   DateTime           - PK
    ///     - currentDate:                  DateTime           - PK
    ///     - accumulatedGrowingDegreeDays: double
    ///     - cropCoefficientValue:         double
    ///     
    /// Methods:
    ///     - PhenologialStageData()     -- constructor
    ///     - PhenologialStageData(???)  -- consturctor with parameters
    ///     
    /// </summary>
    public class CropInformatioByDate
    {

        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - phenologicalStage:            PhenologicalStage  - PK
        ///     - sowingDate:                   DateTime           - PK
        ///     - currentDate:                  DateTime           - PK
        ///     - accumulatedGrowingDegreeDays: double
        ///     - cropCoefficientValue:         double 
        /// CropInformatioByDate    
        /// 
        /// modelo un calculo
        /// 
        /// datos: pasar por parametro o consultar e
        /// 
        /// </summary>
        private DateTime sowingDate;
        private DateTime currentDate;
        private int daysAfterSowing;
        private double accumulatedGrowingDegreeDays;
        private Stage stage;
        private double cropCoefficientValue;
        private double rootDepth;

        #endregion

        #region Properties

        public DateTime SowingDate
        {
            get { return sowingDate; }
            set { sowingDate = value; }
        }

        public DateTime CurrentDate
        {
            get { return currentDate; }
            set { currentDate = value; }
        }

        public int DaysAfterSowing
        {
            get { return daysAfterSowing; }
            set { daysAfterSowing = value; }
        }

        public double AccumulatedGrowingDegreeDays
        {
            get { return accumulatedGrowingDegreeDays; }
            set { accumulatedGrowingDegreeDays = value; }
        }

        public Stage Stage
        {
            get { return stage; }
            set { stage = value; }
        }

        public double CropCoefficientValue
        {
            get { return cropCoefficientValue; }
            set { cropCoefficientValue = value; }
        }
        
        public double RootDepth
        {
            get { return rootDepth; }
            set { rootDepth = value; }
        }
        


        #endregion

        #region Construction
        /// <summary>
        /// Constructor of ClassTemplate
        /// </summary>
        public CropInformatioByDate()
        {
        
        }

        
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Stage getStageByDateForSoja(CropIrrigationWeather pCropIrrigationWeather, DateTime pCurrentDate)
        {
            Stage lStage = null;
            List<Pair<String, int>> lStageDurationInformation;
            int lDaysAfterSowing = 0;

            
            this.SowingDate = pCropIrrigationWeather.SowingDate;
            this.CurrentDate = pCurrentDate;
            this.DaysAfterSowing = Utils.getDaysDifference(this.SowingDate,this.CurrentDate);

            lStageDurationInformation = InitialTables.GetCropInformationByDateForSoja(pCurrentDate);
            foreach(Pair<String, int> lPairStage in lStageDurationInformation)
            {
                lDaysAfterSowing += lPairStage.Second;
                if (lDaysAfterSowing >= this.DaysAfterSowing )
                {
                    lStage = new Stage(1, lPairStage.First, "");
                }
            }
            return lStage;
        }

        public double  getAccumulatedGrowingDegreeDays(Crop pCrop)
        {

            return 0;
        }

        public double getCropCoefficient(Crop pCrop)
        {
            return 0;
        }
        #endregion

        #region Overrides
        #endregion
    }
}