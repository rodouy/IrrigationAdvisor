using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Templates
{
    /// <summary>
    /// Create: 2014-10-14
    /// Author: rodouy - monicarle
    /// Description: 
    ///     Template of a new class summary
    ///     
    /// References:
    ///     list of classes this class use
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String
    /// 
    /// Methods:
    ///     - ClassTemplate()      -- constructor
    ///     - ClassTemplate(name)  -- consturctor with parameters
    ///     - SetName(newName)     -- method to set the name field
    /// 
    /// </summary>
    public class ClassTemplate
    {

        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - name: the name of the instance
        ///     
        /// </summary>
        private string name;
        
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

        #endregion

        #region Construction
        /// <summary>
        /// Constructor of ClassTemplate
        /// </summary>
        public ClassTemplate()
        {
            this.Name = "noname";
        }

        /// <summary>
        /// Constructor of ClassTemplate with parameters
        /// </summary>
        /// <param name="nn">new name</param>
        public ClassTemplate(string nn)
        {
            this.Name = nn;
        }

        #endregion

        #region Private Helpers
        // private methods used only to support external API Methods
        private string setUpper(string phrase)
        {
            return phrase.ToUpper();
        }

        private string setUpperFirstLetter(string phrase)
        {
            string lUpperFirstLetter = phrase;
            try
            {
                lUpperFirstLetter = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
            }
            catch (Exception)
            {                
                throw;
            }
            return lUpperFirstLetter;
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Method to set the name field
        /// </summary>
        /// <param name="newName">new name</param>
        public void SetName(string newName)
        {
            name = this.setUpper(newName);
        }

        #endregion

        #region Overrides
        // Different region for each class override
        #endregion

    }
}


/*
 *
 * 

        #region Consts
        #endregion 

        #region Fields
        #endregion 
        
        #region Properties
        #endregion 
                
        #region Construction
        #endregion 
 
        #region Private Helpers
        #endregion

        #region Public Methods
        #endregion

        #region Overrides
        #endregion

 * 
 */





