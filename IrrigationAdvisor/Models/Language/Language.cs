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
    /// TODO:
    ///     OK
    ///     UnitTest
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
        /// <summary>
        /// name of the language
        /// </summary>
        private string name;

        /// <summary>
        /// Constructor of Language
        /// </summary>
        public Language();

        /// <summary>
        /// constructor with parameter name
        /// </summary>
        /// <param name="name"></param>
        public Language(string newName)
        {
            name = newName;
        }

        /// <summary>
        /// Return the name of the language
        /// </summary>
        /// <returns>name of language</returns>
        public String toString()
        {
            return name;
        }

    }
}