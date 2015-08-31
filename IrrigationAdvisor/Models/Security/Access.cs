using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;

namespace IrrigationAdvisor.Models.Security
{
    public class Access
    {
        /// <summary>
        /// Create: 2014-10-21
        /// Author: monicarle
        /// Description: 
        ///     Describes a kind of access
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
        ///     - Access()      -- constructor
        ///     - Access(name)  -- consturctor with parameters
        ///     - SetName(newName)     -- method to set the name field
        /// 
        /// </summary>
        /// 

        
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - name: the name of the instance
        ///     
        /// </summary>


        private long accessId;

        private string name;
        
        #endregion

        #region Properties
        /// <summary>
        /// The properties are:
        ///     - Name: the name of the instance
        /// </summary>

        
        public long AccessId
        {
            get { return accessId; }
            set { accessId = value; }
        }
             

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #endregion

        #region Construction
        /// <summary>
        /// Constructor of Access
        /// </summary>
        public Access()
        {
            this.accessId = 0;
            this.Name = "noname";
        }

        /// <summary>
        /// Constructor of Access with parameters
        /// </summary>
        /// <param name="pName"></param>
        public Access(long pAccessId, String pNewName)
        {
            this.accessId = pAccessId;
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
            Access lAccess = obj as Access;
            return this.Name.Equals(lAccess.Name);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion

    }
}
