using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using IrrigationAdvisor.Models.Localization;


namespace IrrigationAdvisor.Models.Agriculture
{
    /// <summary>
    /// Create: 2014-10-26
    /// Author: monicarle
    /// Modified: 2015-01-08
    /// Author: rodouy
    /// Description: 
    ///     Returns the CropCoefficient for a Specie in a Region 
    ///     It depends on the days after sowing
    ///     
    /// References:
    ///     
    ///     
    /// Dependencies:
    ///     Crop
    ///     CropInformationByDate
    ///     IrrigationUnit
    /// 
    /// TODO: 
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - cropCoefficientId long
    ///     - kcList List<double>
    ///     
    /// 
    /// Methods:
    ///     - CropCoefficient()      -- constructor
    ///     - CropCoefficient(cropCoefficientId, kcList)  -- consturctor with parameters
    ///     - GetCropCoefficient(days)     -- method to get the name KC
    /// 
    /// </summary>
    
    public class CropCoefficient
    {

        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - cropCoefficientId long
        ///     - kcList List<double>
        ///     
        /// </summary>
        private long cropCoefficientId;
        private List<double> kcList;

        
        #endregion

        #region Properties
                
        public long CropCoefficientId
        {
            get { return cropCoefficientId; }
            set { cropCoefficientId = value; }
        }

        public List<double> KCList
        {
            get { return kcList; }
            set { kcList = value; }
        }
        
        
        #endregion

        #region Construction

        /// <summary>
        /// Constructor of CropCoefficient
        /// UsingTable: field used to return the cropCroefficient. 
        /// - False: return the cropCoefficient from the list (day by day). 
        /// - True: return the cropCoefficient from the table (with 4 fixed points) 
        /// </summary>
        public CropCoefficient()
        {
            this.CropCoefficientId = 0;
            this.KCList = new List<double>();
            this.KCList.Add(0);
        }

        /// <summary>
        /// Constructor of CropCoefficient with all parameters
        /// </summary>
        /// <param name="pName"></param>
        public CropCoefficient(long pCropCoefficientId, List<double> pKCList)
                                
        {
            this.CropCoefficientId = pCropCoefficientId;
            this.KCList = pKCList;            
        }

        #endregion

        #region Private Helpers

        
        /// <summary>
        /// Returns the KC using a List with a value for each Day After Sowing
        /// </summary>
        /// <param name="pDays"></param>
        /// <returns></returns>
        private double getKCFromList (int pDays)
        {
            double lReturn = 0;
            try
            {
                lReturn = this.KCList[pDays];
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception in CropCoefficient.getKCFromList" + e.Message);
                lReturn = -1;
            }
            return lReturn;
        }
          
        
        #endregion

        #region Public Methods

        /// <summary>
        /// Add or Update a value to the list of KC
        /// Index 0 value == 0;
        /// </summary>
        /// <param name="pDayAfterSowing"></param>
        /// <param name="pKC"></param>
        /// <returns></returns>
        public bool AddOrUpdateKCforDayAfterSowing(int pDayAfterSowing, double pKC)
        {
            bool lReturn = false;
            int lMaxIndex = 0;
            try
            {
                lMaxIndex = this.KCList.Count();
                if(pDayAfterSowing < lMaxIndex)
                {
                    this.KCList[pDayAfterSowing] = pKC;
                    lReturn = true;
                }
                else if(pDayAfterSowing == lMaxIndex )
                {
                    this.KCList.Add(pKC);
                    lReturn = true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception in CropCoefficient.addDayToList" + e.Message);
            }
            return lReturn;
        }
      
        /// <summary>
        /// Returns the KC for a Crop giving the days after sowing.
        /// </summary>
        /// <param name="pDays">Days after sowing of the Crop</param>
        /// <returns></returns>
        public double GetCropCoefficient(int pDays)
        {
            double lReturn = 0;
            lReturn = this.getKCFromList(pDays);
            
            return lReturn;
        }

        #endregion

        #region Overrides
        // Different region for each class override

        /// <summary>
        /// Overrides equals
        /// name, region, specie
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool lReturn = false;
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            CropCoefficient lCropCoefficient = obj as CropCoefficient;
            lReturn = this.CropCoefficientId.Equals(lCropCoefficient.CropCoefficientId);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.CropCoefficientId.GetHashCode();
        }
        
        #endregion

    }
}