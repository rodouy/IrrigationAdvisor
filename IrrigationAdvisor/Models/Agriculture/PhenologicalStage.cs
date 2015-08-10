﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Agriculture
{
    /// <summary>
    /// Create: 2014-10-25
    /// Author:  monicarle
    /// Modified: 2015-01-08
    /// Author: rodouy
    /// Description: 
    ///     Describes a phenological stage
    ///     
    /// References:
    ///     Region
    ///     Specie
    ///     Stage
    ///     
    /// Dependencies:
    ///     Specie
    ///     
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - specie:  Specie   - PK
    ///     - stage:  Stage     - PK
    ///     - minDegree: double
    ///     - maxDegree: double
    ///     - rootDepth: double
    /// 
    /// Methods:
    ///     - PhenologicalStage()      -- constructor
    ///     - PhenologicalStage(specie, stage, minDegree, maxDegree, rootDepth)  -- consturctor with parameters
    ///     - SetName(newName)     -- method to set the name field
    ///     + GetAverageDegree(): double
    /// 
    /// </summary>
    public class PhenologicalStage
    {

        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - specie:  Specie
        ///     - stage:  Stage
        ///     - minDegree: double
        ///     - maxDegree: double
        ///     - rootDepth: double
        ///     
        /// </summary>
        private long idPhenologicalStage;
        private Specie specie;
        private Stage stage;
        private double minDegree;
        private double maxDegree;
        private double rootDepth;
        private double hydricBalanceDepth;

        #endregion

        #region Properties

        public long IdPhenologicalStage
        {
            get { return idPhenologicalStage; }
        }
        
        public Specie Specie
        {
            get { return specie; }
            set { specie = value; }
        }
        
        public Stage Stage
        {
            get { return stage; }
            set { stage = value; }
        }
        
        public double MinDegree
        {
            get { return minDegree; }
            set { minDegree = value; }
        }
        
        public double MaxDegree
        {
            get { return maxDegree; }
            set { maxDegree = value; }
        }
        
        public double RootDepth
        {
            get { return rootDepth; }
            set { rootDepth = value; }
        }

        public double HydricBalanceDepth
        {
            get { return hydricBalanceDepth; }
            set { hydricBalanceDepth = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public PhenologicalStage() 
        {
            this.idPhenologicalStage = 0;
            this.Specie = new Specie();
            this.Stage = new Stage();
            this.MinDegree = 0;
            this.MaxDegree = 0;
            this.RootDepth = 0;
            this.HydricBalanceDepth = 0;
        }

        /// <summary>
        /// Build an instance of a phenological stage for a specie. 
        /// It is used for a range between the max and min degree.
        /// </summary>
        /// <param name="pIDPhenologicalStage"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pStage"></param>
        /// <param name="pMinDegree"></param>
        /// <param name="pMaxDegree"></param>
        /// <param name="pDepth"></param>
        public PhenologicalStage(long pIDPhenologicalStage, Specie pSpecie, Stage pStage, 
                                Double pMinDegree, Double pMaxDegree, Double pRootDepth,
                                Double pHydricBalanceDepth)
        {
            this.idPhenologicalStage = pIDPhenologicalStage;
            this.Specie = pSpecie;
            this.Stage = pStage;
            this.MinDegree = pMinDegree;
            this.MaxDegree = pMaxDegree;
            this.RootDepth = pRootDepth;
            this.HydricBalanceDepth = pHydricBalanceDepth;
        }
        
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        /// <summary>
        /// Return the Average Degree between MinDegree and MaxDegree
        /// </summary>
        /// <returns></returns>
        public double GetAverageDegree()
        {
            double lReturn;
            lReturn= (this.MinDegree + this.MaxDegree) / 2;
            return lReturn;
        }

        /// <summary>
        /// Return the Root Depth
        /// </summary>
        /// <returns></returns>
        public double GetRootDepth()
        {
            double lRootDepth;
            lRootDepth = this.rootDepth;
            return lRootDepth;
        }

        #endregion

        #region Overrides
        // Different region for each class override

        /// <summary>
        /// Overrides equals
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
            PhenologicalStage lPhenologicalStage = obj as PhenologicalStage;
            lReturn = this.Specie.Equals(lPhenologicalStage.Specie) &&
                        this.Stage.Equals(lPhenologicalStage.Stage);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.Specie.GetHashCode();
        }

        #endregion

    }
}