using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Utilities;
using System.Data;


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
    ///     CropCoefficient
    ///     CropIrrigationWeather
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
        
        private long cropInformationByDateId;

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

        
        public long CropInformationByDateId
        {
            get { return cropInformationByDateId; }
            set { cropInformationByDateId = value; }
        }

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

        public CropInformationByDate()
        {
            this.SowingDate = Utils.MIN_DATETIME;
            this.Specie = new Specie();
            this.CropCoefficient = new CropCoefficient();
            this.PhenologicalStageList = new List<PhenologicalStage>();
 
        }

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

        #region MagicTable

        public Double GetAccumulatedGrowingDegreeDays(DateTime pSowingDate, DateTime pCurrentDate,
                                                            Double pBaseTemperature)
        {
            Double lReturn = 0;
            Double lAccumulatedGrowingDegreeDays = 0;
            Double lTemperature;
            Double lGrowingDegreeDays;
            DataTable lTemperature_Information;
            DateTime lDay;

            //TODO: AddTemperatureInformation transform to method by date
            lTemperature_Information = InitialTables.AddTemperatureInformation();

            foreach (DataRow row in lTemperature_Information.Rows)
            {
                lDay = row.Field<DateTime>(0);
                if (Utils.IsBetweenDatesWithoutYear(pSowingDate, pCurrentDate, lDay))
                {
                    lTemperature = row.Field<double>(1);
                    lGrowingDegreeDays = lTemperature - pBaseTemperature;
                    lAccumulatedGrowingDegreeDays += lGrowingDegreeDays;
                }
                //TODO: break when lday > pcurrent date
            }

            lReturn = lAccumulatedGrowingDegreeDays;
            return lReturn;
        }

        /// <summary>
        /// Return the 
        /// </summary>
        /// <param name="pCurrentDate"></param>
        /// <returns></returns>
        public double GetGrowingDegreeDays(DateTime pCurrentDate, Double pBaseTemperature)
        {
            Double lReturn;
            Double lTemperature = 0;
            Double lGrowingDegreeDays = 0;
            DataTable lTemperature_Information;
            DateTime lDay;

            lTemperature_Information = InitialTables.AddTemperatureInformation();

            foreach (DataRow row in lTemperature_Information.Rows)
            {
                lDay = row.Field<DateTime>(0);
                if (Utils.IsTheSameDayWithoutYear(lDay, pCurrentDate))
                {
                    lTemperature = row.Field<double>(1);
                    lGrowingDegreeDays = lTemperature - pBaseTemperature;
                    break;
                }
            }

            lReturn = lGrowingDegreeDays;
            return lReturn;
        }

        #endregion

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
            this.AccumulatedGrowingDegreeDays = GetAccumulatedGrowingDegreeDays(this.SowingDate, this.CurrentDate, this.Specie.BaseTemperature);

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

        private void setFieldsAccordingGrowingDegreeDays(double pGrowingDegreeDays)
        {
            DateTime lCurrentDate;
            Double lGrowingDegreeDays;
            int lDaysAfterSowing;
            int lMaxDayAfterSowing;
            int lDegreeDays_PerDay;

            lMaxDayAfterSowing = InitialTables.MAX_DAY_AFTER_SOWING_TO_IRRIGATE;
            lDegreeDays_PerDay = InitialTables.DEGREE_DAYS_PER_DAY;

            lDaysAfterSowing = (int)pGrowingDegreeDays / lDegreeDays_PerDay;

            if (lDaysAfterSowing > 10)
            {
                lDaysAfterSowing = 0;
            }

            for ( ; lDaysAfterSowing < lMaxDayAfterSowing; lDaysAfterSowing++)
            {
                lCurrentDate = this.SowingDate.AddDays(lDaysAfterSowing);
                setFieldsAccordingCurrentDate(lCurrentDate);
                lGrowingDegreeDays = this.AccumulatedGrowingDegreeDays;
                if(lGrowingDegreeDays >= pGrowingDegreeDays)
                {
                    return;
                }
            }

        }

        /// <summary>
        /// TODO: to explain
        /// </summary>
        /// <param name="pGrowingDegreeDays"></param>
        /// <returns></returns>
        private PhenologicalStage setPhenologicalStage(Double pGrowingDegreeDays)
        {
            PhenologicalStage lReturn = null;
            
            foreach (PhenologicalStage lPhenologicalStage in this.PhenologicalStageList)
            {
                if(pGrowingDegreeDays >= lPhenologicalStage.MinDegree && pGrowingDegreeDays <= lPhenologicalStage.MaxDegree)
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
            List<Pair<Stage, int>> lStageDurationInDays = null;
            List<Stage> lStageList = null;

            lStageList = this.getStageList();
            if (this.Specie.Name.ToUpper().Equals("SOJA"))
            {
                lStageDurationInDays = InitialTables.GetCropInformationByDateForSoja(this.SowingDate, lStageList);
            }
            else if (this.Specie.Name.ToUpper().Equals("MAIZ"))
            {
                lStageDurationInDays = InitialTables.GetCropInformationByDateForMaiz(this.SowingDate, lStageList);
            }
            else if (this.Specie.Name.ToUpper().Equals("SORGO"))
            {
                //TODO: SORGO magic table
            }

            lReturn = lStageDurationInDays;
            return lReturn;

        }

        #endregion

        #region Public Methods


        //Information by CURRENT_DATE

        /// <summary>
        /// Return the Stage that should be a crop at a CurrentDate parameter
        /// Using information of INIA
        /// </summary>
        /// <param name="pCurrentDate"></param>
        /// <returns></returns>
        public Stage GetStage(DateTime pCurrentDate)
        {
            this.setFieldsAccordingCurrentDate(pCurrentDate);
            return this.Stage;
        }

        /// <summary>
        /// Return the CropCoefficient that should be a crop at a CurrentDate parameter
        /// Using information of INIA
        /// </summary>
        /// <param name="pCurrentDate"></param>
        /// <returns></returns>
        public Double GetCropCoefficient(DateTime pCurrentDate)
        {
            this.setFieldsAccordingCurrentDate(pCurrentDate);
            return this.CropCoefficientValue;
        }

        /// <summary>
        /// Return the Acumulated Growing Degree Days that should be a crop at a CurrentDate parameter
        /// Using information of INIA
        /// </summary>
        /// <param name="pCurrentDate"></param>
        /// <returns></returns>
        public double GetAccumulatedGrowingDegreeDays(DateTime pCurrentDate)
        {
            this.setFieldsAccordingCurrentDate(pCurrentDate);
            return this.AccumulatedGrowingDegreeDays;
        }

        /// <summary>
        /// Return the Day After Sowing that should be a crop at a CurrentDate parameter
        /// Using information of INIA
        /// </summary>
        /// <param name="pCurrentDate"></param>
        /// <returns></returns>
        public int GetDaysAfterSowing(DateTime pCurrentDate)
        {
            this.setFieldsAccordingCurrentDate(pCurrentDate);
            return this.DaysAfterSowing;
        }

        //Information By DAYS_AFTER_SOWING

        /// <summary>
        /// Return the Stage that should be a crop at a Day After Sowing parameter
        /// Using information of INIA
        /// </summary>
        /// <param name="pDayAfterSowing"></param>
        /// <returns></returns>
        public Stage GetStage(int pDayAfterSowing)
        {
            DateTime lCurrentDate = this.SowingDate.AddDays(pDayAfterSowing);
            this.setFieldsAccordingCurrentDate(lCurrentDate);
            return this.Stage;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDayAfterSowing"></param>
        /// <returns></returns>
        public Double GetCropCoefficient(int pDayAfterSowing)
        {
            DateTime lCurrentDate = this.SowingDate.AddDays(pDayAfterSowing);
            this.setFieldsAccordingCurrentDate(lCurrentDate);
            return this.CropCoefficientValue;
        
       }

        public double GetAccumulatedGrowingDegreeDays(int pDayAfterSowing)
        {
            DateTime lCurrentDate = this.SowingDate.AddDays(pDayAfterSowing);
            this.setFieldsAccordingCurrentDate(lCurrentDate);
            return this.AccumulatedGrowingDegreeDays;
        }

        public int GetDaysAfterSowing(int pDayAfterSowing)
        {
            DateTime lCurrentDate = this.SowingDate.AddDays(pDayAfterSowing);
            this.setFieldsAccordingCurrentDate(lCurrentDate);
            return this.DaysAfterSowing;
        }

        //Information By GrowingDegreeDays()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGrowingDegreeDays"></param>
        /// <returns></returns>
        public Stage GetStage(Double pGrowingDegreeDays)
        {
            this.setFieldsAccordingGrowingDegreeDays(pGrowingDegreeDays);
            return this.Stage;
        }

        public Double GetCropCoefficient(Double pGrowingDegreeDays)
        {
            this.setFieldsAccordingGrowingDegreeDays(pGrowingDegreeDays);
            return this.CropCoefficientValue;

        }

        public double GetAccumulatedGrowingDegreeDays(Double pGrowingDegreeDays)
        {
            this.setFieldsAccordingGrowingDegreeDays(pGrowingDegreeDays);
            return this.AccumulatedGrowingDegreeDays;
        }

        public int GetDaysAfterSowing(Double pGrowingDegreeDays)
        {
            this.setFieldsAccordingGrowingDegreeDays(pGrowingDegreeDays);
            return this.DaysAfterSowing;
        }

    
        #endregion

        #region Overrides
        #endregion


    }
}