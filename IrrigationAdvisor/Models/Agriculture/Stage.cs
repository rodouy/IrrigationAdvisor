using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Agriculture
{
    
    /// <summary>
    /// Create: 2014-10-14
    /// Author: monicarle
    /// Modified: 2015-06-14
    /// Author: rodouy
    /// Description: 
    ///     Is like the label of a Phenological Stage
    ///     
    /// References:
    ///     none
    ///     
    /// Dependencies:
    ///     PhenologialStage
    ///     IrrigationRecords
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - stageId long
    ///     - name String           PK
    ///     - definition String
    /// 
    /// Methods:
    ///     - Stage()      -- constructor
    ///     - Stage(name, definition)  -- consturctor with parameters
    ///     
    /// </summary>
    public class Stage
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - stageId: identifier of state
        ///     - name: the name of the stage
        ///     - description
        ///     
        /// </summary>
        private long stageId;
        private string name;
        private string description;



        #endregion

        #region Properties
        /// <summary>
        /// The properties are:
        ///     - Name: the name of the instance
        /// </summary>

        public long StageId
        {
            get { return stageId; }
            set { stageId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
        #endregion

        #region Construction

        /// <summary>
        /// Constructor of ClassTemplate
        /// </summary>
        public Stage()
        {
            this.StageId = 0;
            this.Name = "noname";
            this.Description = "";

        }

        /// <summary>
        /// Constructor of ClassTemplate with parameters
        /// </summary>
        /// <param name="pName"></param>
        public Stage(long pStageId, String pName, String pDescription)
        {
            this.StageId = pStageId;
            this.Name = pName;
            this.Description = pDescription;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
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
            Stage lStage = obj as Stage;
            return this.Name.Equals(lStage.Name);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        #endregion

    }
}
