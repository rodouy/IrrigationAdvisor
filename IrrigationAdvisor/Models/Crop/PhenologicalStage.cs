using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Crop
{
    /// <summary>
    /// Create: 2014-10-25
    /// Author:  monicarle
    /// Description: 
    ///     Describes a phenological stage
    ///     
    /// References:
    ///     Specie
    ///     Stage
    ///     
    /// Dependencies:
    ///     Crop
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
    ///     + getAverageDegree(): double
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
        private int idPhenologicalStage;
        private Specie specie;
        private Stage stage;
        private double minDegree;
        private double maxDegree;
        private double rootDepth;
        #endregion

        #region Properties

        public int IdPhenologicalStage
        {
            get { return idPhenologicalStage; }
            set { idPhenologicalStage = value; }
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
            //get { return rootDepth; }
            set { rootDepth = value; }
        }

        #endregion

        #region Construction
        public PhenologicalStage() 
        {
            this.idPhenologicalStage=0;
            this.Specie = new Specie();
            this.Stage = new Stage();
            this.MinDegree = 0;
            this.MaxDegree = 0;
            this.RootDepth = 0;
        }
        /// <summary>
        /// Build an instance of a phenological stage for a specie. 
        /// It is used for a range between the max and min degree. 
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <param name="pStage"></param>
        /// <param name="pMinDegree"></param>
        /// <param name="pMaxDegree"></param>
        /// <param name="pRootDepth"></param>
        public PhenologicalStage(int pId,Specie pSpecie, Stage pStage, double pMinDegree,
            double pMaxDegree, double pRootDepth)
        {
            this.idPhenologicalStage = pId;
            this.Specie = pSpecie;
            this.Stage = pStage;
            this.MinDegree = pMinDegree;
            this.MaxDegree = pMaxDegree;
            this.RootDepth = pRootDepth;
        }
        
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double getAverageDegree()
        {
            double lReturn;
            lReturn= (this.MinDegree + this.MaxDegree) / 2;
            return lReturn;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double getRootDepth()
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
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            PhenologicalStage lPhenologicalStage = obj as PhenologicalStage;
            return this.Specie.Equals(lPhenologicalStage.Specie) &&
                this.Stage.Equals(lPhenologicalStage.Stage);
        }

        public override int GetHashCode()
        {
            return this.Specie.GetHashCode();
        }
        #endregion
    }
}