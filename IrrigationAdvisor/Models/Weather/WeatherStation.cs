using IrrigationAdvisor.Models.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Weather
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
    ///     - long int
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
    //[Serializable()]
    public class WeatherStation //: System.ComponentModel.INotifyPropertyChanged
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        ///  Fields of Class:
        ///     - idWeatherStation long
        ///     - name String
        ///     - model String
        ///     - dateOfInstallation Date
        ///     - dateOfService Datetime
        ///     - updateTime Time
        ///     - wirelessTransmission int
        ///     - location Location
        ///     - giveET bool
        /// </summary>
        private long idWeatherStation;
        private String name;
        private String model;
        private DateTime dateOfInstallation;
        private DateTime dateOfService;
        private DateTime updateTime;
        private int wirelessTransmission;
        private Location location;
        private bool giveET;
        
        #endregion

        #region Properties
        /// <summary>
        /// Properties of Class:
        ///     - idWeatherStation long
        ///     - name String
        ///     - model String
        ///     - dateOfInstallation Date
        ///     - dateOfService Datetime
        ///     - updateTime Time
        ///     - wirelessTransmission int
        ///     - location Location
        ///     - giveET bool
        /// </summary>
         

        public long IdWeatherStation
        {
            get { return idWeatherStation; }
            set { idWeatherStation = value; }
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

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }

        public bool GiveET
        {
            get { return giveET; }
            set { giveET = value; }
        }

        //[field: NonSerialized()]
        //public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        #endregion

        #region Construction

        /// <summary>
        /// Constructors of WeatherStation
        /// </summary>
        public WeatherStation()
        {
            this.IdWeatherStation = 0;
            this.Name = "";
            this.Model = "";
            this.DateOfInstallation = DateTime.Now;
            this.DateOfService = DateTime.Now;
            this.UpdateTime = DateTime.MinValue;
            this.WirelessTransmission = 0;
            this.Location = new Location();
            this.GiveET = false;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pIdWeatherStation"></param>
        /// <param name="pName"></param>
        /// <param name="pModel"></param>
        /// <param name="pDateOfInstallation"></param>
        /// <param name="pDateOfService"></param>
        /// <param name="pUpdateTime"></param>
        /// <param name="pWirelessTransmission"></param>
        /// <param name="pLocation"></param>
        /// <param name="pGiveET"></param>
        public WeatherStation(
            long pIdWeatherStation, String pName, String pModel,
            DateTime pDateOfInstallation, DateTime pDateOfService,
            DateTime pUpdateTime, int pWirelessTransmission,
            Location pLocation, bool pGiveET
            )
        {
            this.IdWeatherStation = pIdWeatherStation;
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

        /// <summary>
        /// Overrides equals:
        /// name, Location, Model
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool lReturn = false;
            if (obj == null || obj.GetType() != this.GetType())
            {
                return lReturn;
            }
            WeatherStation lWeatherStation = obj as WeatherStation;
            lReturn = this.Name.Equals(lWeatherStation.Name)
                    && this.Location.Equals(lWeatherStation.Location)
                    && this.Model.Equals(lWeatherStation.Model);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion

    }
}