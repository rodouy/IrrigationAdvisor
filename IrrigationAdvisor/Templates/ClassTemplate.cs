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
    /// TODO:
    ///     OK
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
        /// <summary>
        /// Description:
        ///     the name of the class template
        /// </summary>
        public string name;

        /// <summary>
        /// Constructor of ClassTemplate
        /// </summary>
        public ClassTemplate()
        {
            name = "noname";
        }

        /// <summary>
        /// Constructor of ClassTemplate with parameters
        /// </summary>
        /// <param name="nn">new name</param>
        public ClassTemplate(string nn)
        {
            name = nn;
        }

        /// <summary>
        /// Method to set the name field
        /// </summary>
        /// <param name="newName">new name</param>
        public void SetName(string newName)
        {
            name = newName;
        }

    }
}