using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Security
{
    /// <summary>
    /// Create: 2015-07-14
    /// Author: rodouy
    /// Description: 
    ///     Menu for the site
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
    ///     - name String - PK (Primary Key)
    /// 
    /// Methods:
    ///     - Menu()      -- constructor
    ///     - Menu(name)  -- consturctor with parameters
    ///     - SetName(newName)     -- method to set the name field
    /// 
    /// </summary>
    public class Menu
    {
        
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - name: the name of the instance
        ///     
        /// </summary>
        
        private long menuId;
        private string name;
        
        #endregion

        #region Properties
        /// <summary>
        /// The properties are:
        ///     - Name: the name of the instance
        /// </summary>
        
        
        public long MenuId
        {
            get { return menuId; }
            set { menuId = value; }
        }

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
        public Menu()
        {
            this.Name = "noname";
        }

        /// <summary>
        /// Constructor of ClassTemplate with parameters
        /// </summary>
        /// <param name="pName"></param>
        public Menu(String pNewName)
        {
            this.Name = pNewName;
        }

        #endregion

        #region Private Helpers
        // private methods used only to support external API Methods
        /// <summary>
        /// Upper the phrase passed by parameter
        /// </summary>
        /// <param name="pPhrase"></param>
        /// <returns></returns>
        private string setUpper(string pPhrase)
        {
            return pPhrase.ToUpper();
        }

        private string setUpperFirstLetter(string pPhrase)
        {
            string lUpperFirstLetter = pPhrase;
            try
            {
                lUpperFirstLetter = 
                    System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(pPhrase);
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
        /// <param name="pName">new name</param>
        public void SetName(string pNewName)
        {
            this.Name = this.setUpper(pNewName);
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
            Menu lMenu = obj as Menu;
            return this.Name.Equals(lMenu.Name);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion

        
    }
}