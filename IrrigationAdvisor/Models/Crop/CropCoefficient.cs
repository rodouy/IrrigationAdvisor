using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace IrrigationAdvisor.Models.Crop
{
    /// <summary>
    /// Create: 2014-10-14
    /// Author: rodouy - monicarle
    /// Description: 
    ///     Returns the Kc for a Specie in a Region 
    ///     It depends on the days after sowing
    ///     
    /// References:
    ///     Specie
    ///     Region
    ///     
    /// Dependencies:
    ///     Crop
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - usingTable boolean
    ///     - specie Specie
    ///     - region region
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
    ///     - CropCoefficient(specie, region, initialDays, initialKC
    ///         developmentDays, developmentKC, midSeasonDays
    ///         midSeasonKC, lateSeasonDays, lateSeasonKC)  -- consturctor with parameters
    ///     - getKC(days)     -- method to get the name KC
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
        ///     - usingTable boolean
        ///     - specie Specie
        ///     - region region
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
        private bool usingTable;
        private Specie specie;
        private Location.Region region;
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
        public bool UsingTable
        {
            get { return usingTable; }
            set { usingTable = value; }
        }
        
        public Specie Specie
        {
            get { return specie; }
            set { specie = value; }
        }
        
        public Location.Region Region
        {
            get { return region; }
            set { region = value; }
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
        /// </summary>
        public CropCoefficient()
        {
            this.UsingTable = false;
            this.Specie = new Specie();
            this.Region = new Location.Region();
            this.InitialDays = 0;
            this.InitialKC = 0;
            this.DevelopmentDays = 0;
            this.DevelopmentKC = 0;
            this.MidSeasonDays = 0;
            this.MidSeasonKC = 0;
            this.LateSeasonDays = 0;
            this.LateSeasonKC = 0;
            this.listOfKC = new DataTable("KC_"+ this.Specie.Name);
            this.makeListOfKC();

        }

        /// <summary>
        /// Constructor of ClassTemplate with parameters for a list mode
        /// </summary>
        /// <param name="pNewName"></param>
        public CropCoefficient(Specie pSpecie, Location.Region pRegion)
        {
            this.UsingTable = false ;
            this.Specie = pSpecie;
            this.Region = pRegion;
            this.listOfKC = new DataTable("KC_" + this.Specie.Name);
            this.makeListOfKC();

        }
        /// <summary>
        /// Constructor of ClassTemplate with all parameters
        /// </summary>
        /// <param name="pNewName"></param>
        public CropCoefficient(bool pUsingTable, Specie pSpecie, Location.Region pRegion, int pInitialDays,
            double pInitialDaysKC,int pDevelopmentDays , double pDevelopmentKC,
               int pMidSeasonDays, double pMidSeasonKC, int pLateSeasonDays, double pLateSeasonKC )
        {
            this.UsingTable = pUsingTable;
            this.Specie = pSpecie;
            this.Region = pRegion;
            this.InitialDays = pInitialDays;
            this.InitialKC = pInitialDaysKC;
            this.DevelopmentDays = pDevelopmentDays;
            this.DevelopmentKC = pDevelopmentKC;
            this.MidSeasonDays = pMidSeasonDays;
            this.MidSeasonKC = pMidSeasonKC;
            this.LateSeasonDays = pLateSeasonDays;
            this.LateSeasonKC = pLateSeasonKC;
            this.listOfKC = new DataTable("KC_" + this.Specie.Name);
            this.makeListOfKC();
            
        }

        #endregion

        #region Private Helpers
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

            // Make the "DayAfterSowing" column the primary key column.
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = this.ListOfKC.Columns[dayColumnName];
            this.ListOfKC.PrimaryKey = PrimaryKeyColumns;

            // Instantiate the DataSet variable.
            this.DataSetOfKC = new DataSet();
            // Add the new DataTable to the DataSet.
            this.DataSetOfKC.Tables.Add(this.ListOfKC);


        }
        private double getKCBetweenPoints(double pIntialKC,double pEndKC, int pDays, int pTotalDays) 
        {
            double lReturn = 0;
            double lValueRange = pEndKC-pIntialKC;
            lReturn = lValueRange / pTotalDays * pDays;
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
        private double getCKFromTable(int pDays)
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
            else if (pDays > this.DevelopmentDays && pDays <= this.MidSeasonDays)
            {
                lDays = pDays - this.DevelopmentDays;
                lTotalDays = this.DevelopmentDays - this.MidSeasonDays;
                pReturn = getKCBetweenPoints(this.DevelopmentKC, this.MidSeasonKC, lDays, lTotalDays);
            }
            else if (pDays <= this.MidSeasonDays)
            {
                pReturn = -1;
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
        public bool addDayToList(int pDayAfterSowing, double pKC)
        {
            bool lReturn = false;
            try
            {
                DataRow row;
                row = this.ListOfKC.NewRow();
                row[dayColumnName] = pDayAfterSowing;
                row[kCColumnName] = pKC;
                this.listOfKC.Rows.Add(row);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception in CropCoefficient.addDayToList" + e.Message);
                lReturn = false;
            }
            return lReturn;
        }
      
        /// <summary>
        /// Returns the KC for a Crop giving the days after sowing.
        /// </summary>
        /// <param name="pDays">Days after sowing of the Crop</param>
        /// <returns></returns>
        public double getKC(int pDays)
        {
            double lReturn = 0;
            if (UsingTable)
            {
                lReturn = this.getCKFromTable(pDays);
            }
            else 
            {
                lReturn = this.getKCFromList(pDays);
            }
            return lReturn;

        }
        #endregion

        #region Overrides
        #endregion

    }
}