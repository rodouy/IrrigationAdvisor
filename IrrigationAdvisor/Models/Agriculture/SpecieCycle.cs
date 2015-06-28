using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Agriculture
{
     /// <summary>
    /// Create: 2015-06-14
    /// Author: rodouy - monicarle
    /// Description: 
    ///     A cycle of a Specie
    ///     
    /// References:
    ///     list of classes this class use
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    ///     Specie
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String - PK (Primary Key)
    /// 
    /// Methods:
    ///     - SpecieCycle()        -- constructor
    ///     - SpecieCycle(name)    -- consturctor with parameters
    ///     - SetName(newName)     -- method to set the name field
    /// 
    /// </summary>
    public class SpecieCycle
    {

        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - name: the name of the instance
        ///     - duration: the duration of the cycle
        ///     
        /// </summary>
        private string name;
        private double duration;

        
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

        
        public double Duration
        {
          get { return duration; }
          set { duration = value; }
        }
        #endregion

        #region Construction

        /// <summary>
        /// Constructor of SpecieCycle
        /// </summary>
        public SpecieCycle()
        {
            this.Name = "noname";
            this.Duration = 0;
        }

        /// <summary>
        /// Constructor of SpecieCycle with Name parameter
        /// </summary>
        /// <param name="pName"></param>
        public SpecieCycle(String pName)
        {
            this.Name = pName;
        }

        /// <summary>
        /// Constructor of SpecieCycle with parameters
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pDuration"></param>
        public SpecieCycle(String pName, Double pDuration)
        {
            this.Name = pName;
            this.Duration = pDuration;
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

        /// <summary>
        /// Method to set the duration of a cycle
        /// </summary>
        /// <param name="pNewDuration"></param>
        public void SetDuration(double pNewDuration)
        {
            this.Duration = pNewDuration;
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
            SpecieCycle lSpecieCycle = obj as SpecieCycle;
            return this.Name.Equals(lSpecieCycle.Name);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion

    }
}





