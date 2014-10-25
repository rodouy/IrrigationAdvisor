using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IrrigationAdvisor.Models.Crop
{
    /// <summary>
    /// Create: 2014-10-14
    /// Author: monicarle
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
    ///     - name String
    ///     - definition String
    /// 
    /// Methods:
    ///     - Stage()      -- constructor
    ///     - Stage(name, definition)  -- consturctor with parameters
    ///     
    /// </summary>
    class Stage
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - name: the name of the stage
        ///     - description
        ///     
        /// </summary>
        private string name;
        private string description;


        
        #endregion

        #region Properties
        /// <summary>
        /// The properties are:
        ///     - Name: the name of the instance
        /// </summary>
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
            this.Name = "noname";
            this.Name = "nodescrption";

        }

        /// <summary>
        /// Constructor of ClassTemplate with parameters
        /// </summary>
        /// <param name="pNewName"></param>
        public Stage(String pName, String pDescription )
        {
            this.Name = pName;
            this.description = pDescription;
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
