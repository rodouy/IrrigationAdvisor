using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Location
{
    /// <summary>
    /// Create: 2014-10-22
    /// Author: rodouy
    /// Description: 
    ///     Class that describes the position (latitude, longitude)
    ///     
    /// References:
    ///     none
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    /// TODO: Dependencies, getDistance(Position pOrigin, Position pDestiny), UnitTest
    ///     
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - latitude double
    ///     - longitude double
    /// 
    /// Methods:
    ///     - Position()      -- constructor
    ///     - Position(pLatitude double, pLongitude double)  -- consturctor with parameters
    ///     - setPosition(Position)     -- method to set the name field
    ///     - getDistance(pOrigin Position, pDestiny Position) double
    /// 
    /// </summary>
    public class Position
    {
        #region Consts
        #endregion

        #region Fields
        
        /// <summary>
        /// Fields of Class:
        ///     - latitude double
        ///     - longitude double
        /// </summary>
        private double latitude;
        private double longitude;

        #endregion

        #region Properties
        /// <summary>
        /// Properties of Class:
        ///     - Latitude double read only
        ///     - Longitude double read only
        /// 
        /// </summary>
        public double Latitude
        {
            get { return latitude; }
        }

        public double Longitude
        {
            get { return longitude; }
        }
        #endregion

        #region Construction
        /// <summary>
        /// Constructors of Position
        /// </summary>
        public Position()
        {
            this.latitude = 0;
            this.longitude = 0;
        }

        public Position(double pLatitude, double pLongitude)
        {
            this.latitude = pLatitude;
            this.longitude = pLongitude;
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        /// <summary>
        /// Return the distance from two different Positions
        /// TODO: implementation
        /// </summary>
        /// <param name="pOrigin"></param>
        /// <param name="pDestiny"></param>
        /// <returns></returns>
        public double getDistance(Position pOrigin, Position pDestiny)
        {
            double lDistance = 0;
            if (pOrigin.Equals(pDestiny))
                return 0;

            return lDistance;
        }

        /// <summary>
        /// Return the new Position adding the latitude and longitude to the Origin.
        /// </summary>
        /// <param name="pOrigin"></param>
        /// <param name="pLatitude"></param>
        /// <param name="pLongitude"></param>
        /// <returns></returns>
        public Position getNewPosition(Position pOrigin, double pLatitude, double pLongitude)
        {
            double lNewLatitude = pOrigin.Latitude + pLatitude;
            double lNewLongitude = pOrigin.Longitude + pLongitude;
            Position lPosition = new Position(lNewLatitude, lNewLongitude);
            return lPosition;
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Override equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            Position lPosition = obj as Position;
            return this.latitude.Equals(lPosition.latitude)
                && this.longitude.Equals(lPosition.longitude);
        }

        public override int GetHashCode()
        {
            return this.latitude.GetHashCode() ^ this.longitude.GetHashCode() ;
        }
        #endregion
    }
}