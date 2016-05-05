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
    ///     Specie
    /// 
    /// TODO: 
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - cropCoefficientId long
    ///     - usingTable boolean
    ///     - initialDays int
    ///     - initialKC double
    ///     - developmentDays int
    ///     - developmentKC double
    ///     - midSeasonDays int
    ///     - midSeasonKC double
    ///     - lateSeasonDays int
    ///     - lateSeasonKC double
    ///     - listOfKC List <int, double>
    ///     
    /// 
    /// Methods:
    ///     - CropCoefficient()      -- constructor
    ///     - CropCoefficient(cropCoefficientId, initialDays, initialKC
    ///         developmentDays, developmentKC, midSeasonDays
    ///         midSeasonKC, lateSeasonDays, lateSeasonKC)  -- consturctor with parameters
    ///     - GetCropCoefficient(days)     -- method to get the name KC
    /// 
    /// </summary>
    
    public class CropCoefficient
    {

        #region Consts
        private String dayColumnName = "DayAfterSowing";
        private String kCColumnName = "KC";
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - cropCoefficientId long
        ///     - usingTable boolean
        ///     - initialDays int
        ///     - initialKC double
        ///     - developmentDays int
        ///     - developmentKC double
        ///     - midSeasonDays int
        ///     - midSeasonKC double
        ///     - lateSeasonDays int
        ///     - lateSeasonKC double
        ///     - dataSetOfKC
        ///     
        /// </summary>
        private long cropCoefficientId;
        private bool usingTable;
        private int initialDays;
        private double initialKC;
        private int developmentDays;
        private double developmentKC;
        private int midSeasonDays;
        private double midSeasonKC;
        private int lateSeasonDays;
        private double lateSeasonKC;
        private DataTable listOfKC;
        private DataSet dataSetOfKC;

        #endregion

        #region Properties

        public long CropCoefficientId
        {
            get { return cropCoefficientId; }
            set { cropCoefficientId = value; }
        }

        public bool UsingTable
        {
            get { return usingTable; }
            set { usingTable = value; }
        }
        
        public int InitialDays
        {
            get { return initialDays; }
            set { initialDays = value; }
        }
        
        public double InitialKC
        {
            get { return initialKC; }
            set { initialKC = value; }
        }
        
        public int DevelopmentDays
        {
            get { return developmentDays; }
            set { developmentDays = value; }
        }
        
        public double DevelopmentKC
        {
            get { return developmentKC; }
            set { developmentKC = value; }
        }
        
        public int MidSeasonDays
        {
            get { return midSeasonDays; }
            set { midSeasonDays = value; }
        }
        
        public double MidSeasonKC
        {
            get { return midSeasonKC; }
            set { midSeasonKC = value; }
        }
        
        public int LateSeasonDays
        {
            get { return lateSeasonDays; }
            set { lateSeasonDays = value; }
        }
        
        public double LateSeasonKC
        {
            get { return lateSeasonKC; }
            set { lateSeasonKC = value; }
        }

        public DataTable ListOfKC
        {
            get { return listOfKC; }
            set { listOfKC = value; }
        }

        public DataSet DataSetOfKC
        {
            get { return dataSetOfKC; }
            set { dataSetOfKC = value; }
        }
        
        #endregion

        #region Construction

        /// <summary>
        /// Constructor of ClassTemplate
        /// UsingTable: field used to return the cropCroefficient. 
        /// - False: return the cropCoefficient from the list (day by day). 
        /// - True: return the cropCoefficient from the table (with 4 fixed points) 
        /// </summary>
        public CropCoefficient()
        {
            this.CropCoefficientId = 0;
            this.UsingTable = false;
            this.InitialDays = 0;
            this.InitialKC = 0;
            this.DevelopmentDays = 0;
            this.DevelopmentKC = 0;
            this.MidSeasonDays = 0;
            this.MidSeasonKC = 0;
            this.LateSeasonDays = 0;
            this.LateSeasonKC = 0;
            this.listOfKC = new DataTable("KC_0");
            this.makeListOfKC();

        }

        /// <summary>
        /// Constructor of ClassTemplate with all parameters
        /// </summary>
        /// <param name="pName"></param>
        public CropCoefficient(long pCropCoefficientId, bool pUsingTable, 
                                int pInitialDays, double pInitialDaysKC, 
                                int pDevelopmentDays , double pDevelopmentKC, 
                                int pMidSeasonDays, double pMidSeasonKC, 
                                int pLateSeasonDays, double pLateSeasonKC)
                                
        {
            this.CropCoefficientId = pCropCoefficientId;
            this.UsingTable = pUsingTable;
            this.InitialDays = pInitialDays;
            this.InitialKC = pInitialDaysKC;
            this.DevelopmentDays = pDevelopmentDays;
            this.DevelopmentKC = pDevelopmentKC;
            this.MidSeasonDays = pMidSeasonDays;
            this.MidSeasonKC = pMidSeasonKC;
            this.LateSeasonDays = pLateSeasonDays;
            this.LateSeasonKC = pLateSeasonKC;
            this.listOfKC = new DataTable("KC_" + pCropCoefficientId);
            this.makeListOfKC();
            
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// TODO add description
        /// </summary>
        private void makeListOfKC()
        {
            DataColumn column;
            
            // Create new DataColumn, set DataType,  
            // ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = dayColumnName;
            column.ReadOnly = true;
            column.Unique = true;
            // Add the Column to the DataColumnCollection.
            this.ListOfKC.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = kCColumnName;
            column.AutoIncrement = false;
            column.Caption = kCColumnName;
            column.ReadOnly = false;
            column.Unique = false;
            // Add the column to the table.
            this.ListOfKC.Columns.Add(column);

            // Make the "DaysAfterSowing" column the primary key column.
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = this.ListOfKC.Columns[dayColumnName];
            this.ListOfKC.PrimaryKey = PrimaryKeyColumns;

            // Instantiate the DataSet variable.
            this.DataSetOfKC = new DataSet();
            // Add the new DataTable to the DataSet.
            this.DataSetOfKC.Tables.Add(this.ListOfKC);


        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pIntialKC"></param>
        /// <param name="pEndKC"></param>
        /// <param name="pDays"></param>
        /// <param name="pTotalDays"></param>
        /// <returns></returns>
        private double getKCBetweenPoints(double pIntialKC,double pEndKC, int pDays, int pTotalDays) 
        {
            double lReturn = 0;
            double lValueRange = pEndKC-pIntialKC;
            lReturn = pIntialKC + (lValueRange / pTotalDays * pDays);
            return Math.Round(lReturn,2);
        }
        
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
                foreach (DataRow row in this.ListOfKC.Rows)
                {
                    int lDay = row.Field<int>(0);
                    if (lDay == pDays)
                    {
                        lReturn = row.Field<double>(1);
                        return lReturn;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception in CropCoefficient.getKCFromList" + e.Message);
                lReturn = -1;
            }
            return lReturn;
        }
          
        /// <summary>
        /// Return the KC using a Table with 4 fixed points
        /// </summary>
        /// <param name="pDays"></param>
        /// <returns></returns>
        private double getKCFromTable(int pDays)
        {
            double pReturn = 0;
            int lDays = 0;
            int lTotalDays = 0;
            if (pDays > 0 && pDays <= this.InitialDays)
            {
                pReturn = this.InitialKC;
            }
            else if (pDays > this.InitialDays && pDays <= this.DevelopmentDays)
            {
                lDays = pDays-this.InitialDays;
                lTotalDays = this.DevelopmentDays - this.InitialDays;
                pReturn = getKCBetweenPoints(this.initialKC, this.DevelopmentKC, lDays, lTotalDays);
            }
            else if (pDays > this.DevelopmentDays && pDays <= this.MidSeasonDays)
            {
                pReturn = this.MidSeasonKC;
            }
            else if (pDays > this.MidSeasonDays && pDays <= this.LateSeasonDays)
            {
                lDays = pDays - this.MidSeasonDays;
                lTotalDays = this.LateSeasonDays - this.MidSeasonDays;
                pReturn = getKCBetweenPoints(this.MidSeasonKC, this.LateSeasonKC, lDays, lTotalDays);
            }
            else if (pDays > this.LateSeasonDays)
            {
                pReturn = this.LateSeasonKC;
            }
            return pReturn;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Add a value to the list of KC
        /// </summary>
        /// <param name="pDayAfterSowing"></param>
        /// <param name="pKC"></param>
        /// <returns></returns>
        public bool AddKCforDayAfterSowing(int pDayAfterSowing, double pKC)
        {
            bool lReturn = false;
            try
            {
                DataRow lRow;
                lRow = this.ListOfKC.NewRow();
                lRow[dayColumnName] = pDayAfterSowing;
                lRow[kCColumnName] = pKC;
                this.ListOfKC.Rows.Add(lRow);
                lReturn = true;
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
            if (UsingTable)
            {
                lReturn = this.getKCFromTable(pDays);
            }
            else 
            {
                lReturn = this.getKCFromList(pDays);
            }
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