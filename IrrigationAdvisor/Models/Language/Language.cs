using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Language
{
    /// <summary>
    /// Create: 2014-10-14
    /// Author: rodouy
    /// Description: 
    ///     Languages used in the site
    ///     
    /// References:
    ///     String
    ///     
    /// Dependencies:
    ///     User
    /// 
    /// OK
    /// TODO: UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String
    /// 
    /// Methods:
    ///     - Language()            -- constructor
    ///     - Language(name)        -- consturctor with parameters
    ///     - Sting:toString()      -- method to return the name of Language
    /// 
    /// </summary>
    public class Language
    {

        #region Consts
        #endregion

        #region Fields

        /// <summary>
        /// PositionId of language
        /// </summary>
        private long languageId;

        /// <summary>
        /// name of the language
        /// </summary>
        private string name;


        #endregion

        #region Properties

        
        public long LanguageId
        {
            get { return languageId; }
            set { languageId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor of Language
        /// </summary>
        public Language()
        {
            this.LanguageId = 0;
            this.Name = "NO NAME";
        }

        /// <summary>
        /// constructor with parameter name
        /// </summary>
        /// <param name="name"></param>
        public Language(string newName)
        {
            this.LanguageId = 0;
            this.Name = newName;
        }

        public Language(long pLanguageId, String pName)
        {
            this.LanguageId = pLanguageId;
            this.Name = pName;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        
        #endregion

        #region Overrides

        /// <summary>
        /// Return the name of the language
        /// </summary>
        /// <returns>name of language</returns>
        public override string ToString()
        {
            return this.Name;
        }

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
            Language lLanguage = obj as Language;
            return (this.Name.Equals(lLanguage.Name));
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion

    }
}