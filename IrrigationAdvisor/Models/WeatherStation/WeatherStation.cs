using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.WeatherStation
{
    /// <summary>
    /// Create: 2014-10-14
    /// Author: rodouy
    /// Description: 
    ///     this class describes a Weather Station
    ///     
    /// References:
    ///     list of classes this class use
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - id int
    ///     - name String
    ///     - model String
    ///     - dateOfInstallation Date
    ///     - dateOfService Datetime
    ///     - updateTime Time
    ///     - wirelessTransmission int
    ///     - location Location
    ///     - giveET bool
    /// 
    /// Methods:
    ///     - WeatherStation()      -- constructor
    ///     - WeatherStation(name)  -- consturctor with parameters
    ///     - SetService(DateTime)  -- method to set the name field
    /// 
    /// </summary>
    public class WeatherStation
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        ///  Fields of Class:
        ///     - id int
        ///     - name String
        ///     - model String
        ///     - dateOfInstallation Date
        ///     - dateOfService Datetime
        ///     - updateTime Time
        ///     - wirelessTransmission int
        ///     - location Location
        ///     - giveET bool
        /// </summary>
        private int id;
        private String name;
        private String model;
        private DateTime dateOfInstallation;
        private DateTime dateOfService;
        private DateTime updateTime;
        private int wirelessTransmission;
        private Location.Location location;
        private bool giveET;
        
        #endregion

        #region Properties
        /// <summary>
        /// Properties of Class:
        ///     - id int
        ///     - name String
        ///     - model String
        ///     - dateOfInstallation Date
        ///     - dateOfService Datetime
        ///     - updateTime Time
        ///     - wirelessTransmission int
        ///     - location Location
        ///     - giveET bool
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Model
        {
            get { return model; }
            set { model = value; }
        }

        public DateTime DateOfInstallation
        {
            get { return dateOfInstallation; }
            set { dateOfInstallation = value; }
        }

        public DateTime DateOfService
        {
            get { return dateOfService; }
            set { dateOfService = value; }
        }
        
        public DateTime UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
        }

        public int WirelessTransmission
        {
            get { return wirelessTransmission; }
            set { wirelessTransmission = value; }
        }

        public Location.Location Location
        {
            get { return location; }
            set { location = value; }
        }

        public bool GiveET
        {
            get { return giveET; }
            set { giveET = value; }
        }
        
        #endregion

        #region Construction
        /// <summary>
        /// Constructors of WeatherStation
        /// </summary>
        public WeatherStation()
        {
            this.Id = 0;
            this.Name = "";
            this.Model = "";
            this.DateOfInstallation = DateTime.Now;
            this.DateOfService = DateTime.Now;
            this.UpdateTime = DateTime.MinValue;
            this.WirelessTransmission = 0;
            //this.Location = new Location.Location();
            this.GiveET = false;
        }

        public WeatherStation(
            int pId, String pName, String pModel,
            DateTime pDateOfInstallation, DateTime pDateOfService,
            DateTime pUpdateTime, int pWirelessTransmission,
            Location.Location pLocation, bool pGiveET
            )
        {
            this.Id = pId;
            this.Name = pName;
            this.Model = pModel;
            this.DateOfInstallation = pDateOfInstallation;
            this.DateOfService = pDateOfService;
            this.UpdateTime = pUpdateTime;
            this.WirelessTransmission = pWirelessTransmission;
            this.Location = pLocation;
            this.GiveET = pGiveET;
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