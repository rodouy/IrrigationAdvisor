using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Irrigation
{
    /// <summary>
    /// Create: 2014-10-26
    /// Author:  monicarle
    /// Description: 
    ///     Describes a Bomb used in an Irrigation Unit
    ///     
    /// References:
    ///     Location
    ///     
    /// Dependencies:
    ///     Bomb
    /// 
    /// TODO:
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String
    ///     - serialNumber int
    ///     - serviceDate DateTime
    ///     - purchaseDate DateTime
    ///     - location Location
    ///     
    /// 
    /// Methods:
    ///     - ClassTemplate()      -- constructor
    ///     - ClassTemplate(name)  -- consturctor with parameters
    ///     - SetName(newName)     -- method to set the name field
    /// 
    /// </summary>
    public class Bomb
    {
        #region Consts
        #endregion

        #region Fields

        private String name;
        private int serialNumber;
        private DateTime serviceDate;
        private DateTime purchaseDate;
        private Location.Location location;
        #endregion

        #region Properties

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }


        public DateTime ServiceDate
        {
            get { return serviceDate; }
            set { serviceDate = value; }
        }

        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set { purchaseDate = value; }
        }

        public Location.Location Location
        {
            get { return location; }
            set { location = value; }
        }
        

        #endregion

        #region Construction
        /// <summary>
        /// Constructor of ClassTemplate
        /// </summary>
        public Bomb()
        {
            this.Name = "noname";
            this.SerialNumber = 0;
            this.ServiceDate = DateTime.Now;
            this.PurchaseDate = DateTime.Now;
            this.Location = new Location.Location();

        }
        public Bomb(String pName, int pSerialNumber, DateTime pServiceDate,
            DateTime pPurchaseDate, Location.Location pLocation) 
        {
            this.Name = pName;
            this.SerialNumber = pSerialNumber;
            this.ServiceDate = pServiceDate;
            this.PurchaseDate = pPurchaseDate;
            this.Location = pLocation;
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        #endregion

        #region Overrides
        #endregion

    }
}