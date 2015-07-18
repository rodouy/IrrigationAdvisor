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
    ///     - CropInformationByDate()     -- constructor
    ///     - CropInformationByDate(???)  -- consturctor with parameters
    ///     
    /// </summary>
    public class CropInformationByDate
    {

        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - sowingDate:                   DateTime           - PK
        ///     - currentDate:                  DateTime           - PK
        ///     - accumulatedGrowingDegreeDays: double
        ///     - cropCoefficientValue:         double 
        /// CropInformationByDate    
        /// 
        /// modelo un calculo
        /// 
        /// datos: pasar por parametro o consultar e
        /// 
        /// </summary>
        /// 
        
        //Crop Data
        private DateTime sowingDate;
        private int daysAfterSowing;
        private Specie specie;
        private CropCoefficient cropCoefficient;
        private List<PhenologicalStage> phenologicalStageList;
        
        //Current Data
        private DateTime currentDate;
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

        public List<PhenologicalStage> PhenologicalStageList
        {
            get { return phenologicalStageList; }
            set { phenologicalStageList = value; }
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
        /// Constructor of CropInformationByDate
        /// </summary>
        public CropInformationByDate(Specie pSpecie, DateTime pSowingDate, CropCoefficient pCropCoefficient, List<PhenologicalStage> pPhenologicalStageList)
        {
            this.SowingDate = pSowingDate;
            this.Specie = pSpecie;
            this.CropCoefficient = pCropCoefficient;
            this.PhenologicalStageList = pPhenologicalStageList;
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
            List<Pair<Stage, int>> lStageDurationInformation;
            int lDaysAfterSowing = 0;

            //Set DaysAfterSowing
            this.CurrentDate = pCurrentDate;
            this.DaysAfterSowing = Utils.GetDaysDifference(this.SowingDate, this.CurrentDate);

            //Set accumulatedGrowingDegreeDays
            this.AccumulatedGrowingDegreeDays = InitialTables.GetAccumulatedGrowingDegreeDays(this.SowingDate,this.CurrentDate);

            //Set Stage
            lStageDurationInformation = getStageDurationInformation();
            foreach (Pair<Stage, int> lPairStage in lStageDurationInformation)
            {
                lDaysAfterSowing += lPairStage.Second;
                if (lDaysAfterSowing >= this.DaysAfterSowing)
                {
                    this.Stage = lPairStage.First;
                    break;
                }
                
                
            }

            //Set cropCoefficientValue
            this.CropCoefficientValue = this.CropCoefficient.GetCropCoefficient(this.DaysAfterSowing);

            //Set rootDepth
            this.setPhenologicalStage(this.AccumulatedGrowingDegreeDays);
            
        }

        private PhenologicalStage setPhenologicalStage(Double pGrowingDegreeDays)
        {
            PhenologicalStage lReturn = null;
            
            foreach (PhenologicalStage lPhenologicalStage in this.PhenologicalStageList)
            {
                if(pGrowingDegreeDays <= lPhenologicalStage.MinDegree && pGrowingDegreeDays >= lPhenologicalStage.MaxDegree)
                {
                    lReturn = lPhenologicalStage;
                }
            }

            return lReturn;
        }

        private List<Stage> getStageList()
        {
            List<Stage> lReturn = new List<Stage>();
            foreach (PhenologicalStage lPhenologicalStage in this.PhenologicalStageList)
            {
                lReturn.Add(lPhenologicalStage.Stage);
            }
            return lReturn;
        }

        private List<Pair<Stage, int>> getStageDurationInformation()
        {
            //TODO Sacar hardcodeo de nombre de especies 
            List<Pair<Stage, int>> lReturn = null;
            List<Stage> lStageList = null;

            lStageList = this.getStageList();
            if (this.Specie.Name.ToUpper().Equals("SOJA"))
            {
                
                lReturn = InitialTables.GetCropInformationByDateForSoja(this.SowingDate, lStageList);
            }
            else if (this.Specie.Name.ToUpper().Equals("MAIZ"))
            {
                lReturn = InitialTables.GetCropInformationByDateForMaiz(this.SowingDate, lStageList);
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
            return this.AccumulatedGrowingDegreeDays;
        }

        public int GetDaysAfterSowing(DateTime pCurrentDate)
        {
            this.setFieldsAccordingCurrentDate(pCurrentDate);
            return this.DaysAfterSowing;
        }



        #endregion

        #region Overrides
        #endregion


    }
}