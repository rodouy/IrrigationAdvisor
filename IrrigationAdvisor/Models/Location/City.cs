using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Location
{
    /// <summary>
    /// Create: 2014-10-24
    /// Author: monicarle
    /// Description: 
    ///     Describes a city
    ///     
    /// References:
    ///     Position
    ///     
    /// Dependencies:
    ///     Country
    ///     Position
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - idCity int
    ///     - name String
    ///     - position Position
    ///     City
    /// 
    /// Methods:
    ///     - City()      -- constructor
    ///     - City(name)  -- consturctor with parameters
    ///     - SetPosition(Position): bool
    /// 
    /// </summary>
    public class City
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - idCity: identifier
        ///     - name: the name of the city
        ///     - position: the position of the city
        ///     
        /// </summary>
        private int idCity;
        private String name;
        private Position position;


        #endregion

        #region Properties


        public int IdCity
        {
            get { return idCity; }
            set { idCity = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Position Position
        {
            get { return position; }
            set { position = value; }
        }


        #endregion

        #region Construction
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Name of the region</param>
        /// <param name="location">Location of the region</param>
        public City()
        {
            this.Name = "";
            this.Position = new Position ();
        }
        public City(String pName, Position pPosition)
        {
            this.Name = pName;
            this.Position = pPosition;
        }
        #endregion

        #region Private Helpers
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
            City lCity = obj as City;
            return (this.Name.Equals(lCity.Name) && this .Position.Equals(lCity.Position));
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        #endregion
    }
}