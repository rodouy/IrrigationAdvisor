using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Utilities
{
    /// <summary>
    /// Create: 2014-10-25
    /// Author: rodouy
    /// Description: 
    ///     Class for pair that support generics
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
    /// Example of use:
    /// Pair<String, int> pair = new Pair<String, int>("test", 2);
    /// Console.WriteLine(pair.First);   
    /// Console.WriteLine(pair.Second);
    /// 
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - first T
    ///     - second U
    /// 
    /// Methods:
    ///     - Pair()      -- constructor
    ///     - Pair(pFirst, pSecond)  -- consturctor with parameters
    ///     
    /// </summary>
    public class Pair<T, U>
    {
        #region Consts
        #endregion

        #region Fields
        private T first;
        private U second;
        #endregion

        #region Properties
        public T First
        {
            get { return first; }
            set { first = value; }
        }

        public U Second
        {
            get { return second; }
            set { second = value; }
        }
        #endregion

        #region Construction
        public Pair()
        { }

        public Pair(T pFirst, U pSecond)
        {
            this.First = pFirst;
            this.Second = pSecond;
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        #endregion

        #region Overrides
        public override bool Equals(object obj)
        {
            bool lReturn = false;
            if (obj == null)
                return false;
            if (obj == this)
                return true;
            Pair<T, U> other = obj as Pair<T, U>;
            if (other == null)
                return false;
            lReturn = (((first == null) && (other.first == null))
                        || ((first != null) && first.Equals(other.first)))
                       &&
                       (((second == null) && (other.second == null))
                        || ((second != null) && second.Equals(other.second)));

            return lReturn;
        }

        public override int GetHashCode()
        {
            int lHashCode = 0;
            if (first != null)
                lHashCode += first.GetHashCode();
            if (second != null)
                lHashCode += second.GetHashCode();
            return lHashCode;
        }
        #endregion
    }
}


