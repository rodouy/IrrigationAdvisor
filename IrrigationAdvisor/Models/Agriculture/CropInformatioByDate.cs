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
        private Specie specie;
        private CropCoefficient cropCoefficient;

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
        public Specie Specie
        {
            get { return specie; }
            set { specie = value; }
        }

        public CropCoefficient CropCoefficient
        {
            get { return cropCoefficient; }
            set { cropCoefficient = value; }
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
        /// Constructor of CropInformatioByDate
        /// </summary>
        public CropInformatioByDate(Specie pSpecie, DateTime  pSowingDate)
        {
            this.SowingDate = pSowingDate;
            this.Specie = pSpecie;
        }

        
        #endregion

        #region Private Helpers
        /// <summary>
        /// Given a Current Date set:
        /// - DaysAfterSowing
        /// - AccumulatedGrowingDegreeDays
        /// - Stage
        /// - CropCoefficient
        /// - RootDepth
        /// </summary>
        /// <param name="pCurrentDate"></param>
        private void setFieldsAccordingCurrentDate(DateTime pCurrentDate)
        {
            List<Pair<String, int>> lStageDurationInformation;
            int lDaysAfterSowing = 0;

            //Set DaysAfterSowing
            this.CurrentDate = pCurrentDate;
            this.DaysAfterSowing = Utils.getDaysDifference(this.SowingDate, this.CurrentDate);

            //Set accumulatedGrowingDegreeDays
            this.AccumulatedGrowingDegreeDays = InitialTables.GetAccumulatedGrowingDegreeDays(this.SowingDate,this.CurrentDate);

            //Set Stage
            lStageDurationInformation = getStageDurationInformation();
            foreach (Pair<String, int> lPairStage in lStageDurationInformation)
            {
                lDaysAfterSowing += lPairStage.Second;
                if (lDaysAfterSowing >= this.DaysAfterSowing)
                {
                    this.Stage = new Stage(1, lPairStage.First, "");
                    break;
                }
                
                
            }

            //Set cropCoefficientValue
            //this.CropCoefficientValue = this.CropCoefficient.GetCropCoefficient(this.DaysAfterSowing);

            //Set rootDepth
            
        }

        private List<Pair<string, int>> getStageDurationInformation()
        {
            //TODO Sacar hardcodeo de nombre de especies 
            List<Pair<string, int>> lReturn = null;
            if (this.Specie.Name.ToUpper().Equals("SOJA"))
            {
                lReturn = InitialTables.GetCropInformationByDateForSoja(this.SowingDate);
            }
            else if (this.Specie.Name.ToUpper().Equals("MAIZ"))
            {
                lReturn = InitialTables.GetCropInformationByDateForMaiz(this.SowingDate);
            }
            else if (this.Specie.Name.ToUpper().Equals("SORGO"))
            {

            }
            return lReturn;

        }

        #endregion

        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        
        public Stage GetStage(DateTime pCurrentDate)
        {
            this.setFieldsAccordingCurrentDate(pCurrentDate);
            return this.Stage;
        }

        public double GetAccumulatedGrowingDegreeDays(DateTime pCurrentDate)
        {
            this.setFieldsAccordingCurrentDate(pCurrentDate);
            return 0;
        }


        #endregion

        #region Overrides
        #endregion
    }
}