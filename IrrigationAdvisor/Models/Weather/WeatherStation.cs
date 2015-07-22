using IrrigationAdvisor.Models.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IrrigationAdvisor.Models.Utilities;

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
        ///     - weatherStationId long
        ///     - name String
        ///     - model String
        ///     - dateOfInstallation Date
        ///     - dateOfService Datetime
        ///     - updateTime Time
        ///     - wirelessTransmission int
        ///     - location Location
        ///     - giveET bool
        /// </summary>
        private long weatherStationId;
        private String name;
        private String model;
        private DateTime dateOfInstallation;
        private DateTime dateOfService;
        private DateTime updateTime;
        private int wirelessTransmission;
        private Location location;
        private bool giveET;
        private List<WeatherData> weatherDataList;

        #endregion

        #region Properties
        /// <summary>
        /// Properties of Class:
        ///     - weatherStationId long
        ///     - name String
        ///     - model String
        ///     - dateOfInstallation Date
        ///     - dateOfService Datetime
        ///     - updateTime Time
        ///     - wirelessTransmission int
        ///     - location Location
        ///     - giveET bool
        /// </summary>
         

        public long WeatherStationId
        {
            get { return weatherStationId; }
            set { weatherStationId = value; }
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

        public List<WeatherData> WeatherDataList
        {
            get { return weatherDataList; }
            set { weatherDataList = value; }
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
            this.WeatherStationId = 0;
            this.Name = "";
            this.Model = "";
            this.DateOfInstallation = DateTime.Now;
            this.DateOfService = DateTime.Now;
            this.UpdateTime = DateTime.MinValue;
            this.WirelessTransmission = 0;
            this.Location = new Location();
            this.GiveET = false;
            this.WeatherDataList = new List<WeatherData>();
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pWeatherStationId"></param>
        /// <param name="pName"></param>
        /// <param name="pModel"></param>
        /// <param name="pDateOfInstallation"></param>
        /// <param name="pDateOfService"></param>
        /// <param name="pUpdateTime"></param>
        /// <param name="pWirelessTransmission"></param>
        /// <param name="pLocation"></param>
        /// <param name="pGiveET"></param>
        public WeatherStation(
            long pWeatherStationId, String pName, String pModel,
            DateTime pDateOfInstallation, DateTime pDateOfService,
            DateTime pUpdateTime, int pWirelessTransmission,
            Location pLocation, bool pGiveET,
            List<WeatherData> pWeatherDataList)
        {
            this.WeatherStationId = pWeatherStationId;
            this.Name = pName;
            this.Model = pModel;
            this.DateOfInstallation = pDateOfInstallation;
            this.DateOfService = pDateOfService;
            this.UpdateTime = pUpdateTime;
            this.WirelessTransmission = pWirelessTransmission;
            this.Location = pLocation;
            this.GiveET = pGiveET;
            this.WeatherDataList = pWeatherDataList;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        /// <summary>
        /// Find a WeatherData with the same Year, Month, Day and Hour as Parameter
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public WeatherData FindWeatherData(DateTime pDateHour)
        {
            WeatherData lReturn;
            WeatherData lWeatherData = null;

            if(pDateHour != null)
            {
                foreach (WeatherData lWeatherDataItem in this.WeatherDataList)
                {
                    if(Utils.IsTheSameDayAndHour(pDateHour, lWeatherDataItem.Date))
                    {
                        lWeatherData = lWeatherDataItem;
                        break;
                    }
                }
            }

            lReturn = lWeatherData;
            return lReturn;
        }

        /// <summary>
        /// If WeatherData exist in list, return the WeatherData,
        /// else return null.
        /// </summary>
        /// <param name="pWeatherData"></param>
        /// <returns></returns>
        public WeatherData ExistWeatherData(WeatherData pWeatherData)
        {
            WeatherData lReturn = null;

            if(pWeatherData != null)
            {
                foreach (WeatherData lWeatherDataitem in this.WeatherDataList)
                {
                    if(lWeatherDataitem.Equals(pWeatherData))
                    {
                        lReturn = lWeatherDataitem;
                        break;
                    }
                }
            }

            return lReturn;
        }

        /// <summary>
        /// Add a new WeatherData and return it,
        /// if exists returns null.
        /// </summary>
        /// <param name="pDateTime"></param>
        /// <param name="pTemperature"></param>
        /// <param name="pSolarRadiation"></param>
        /// <param name="pTemMax"></param>
        /// <param name="pTemMin"></param>
        /// <param name="pEvapotranspiration"></param>
        /// <returns></returns>
        public WeatherData AddWeatherData(DateTime pDateTime,
                                        Double pTemperature, Double pSolarRadiation, 
                                        Double pTemMax, Double pTemMin, 
                                        Double pEvapotranspiration)
        {
            WeatherData lReturn;
            WeatherData lWeatherData = null;
            long lWeatherDataId = 0;
            try
            {
                lWeatherDataId = this.WeatherDataList.Count();
                lWeatherData = new WeatherData(lWeatherDataId, pDateTime, pTemperature, 
                                                    pTemMax, pTemMin, pSolarRadiation, 
                                                    pEvapotranspiration);
                if(this.ExistWeatherData(lWeatherData) == null)
                {
                    this.WeatherDataList.Add(lWeatherData);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in WeatherStation.AddWeatherDataToList " + e.Message);
                //TODO manage and log the exception
                throw e;
            }

            lReturn = lWeatherData;
            return lReturn;
        }


        /// <summary>
        /// Update an existing WeatherData,
        /// if not exists, return null.
        /// </summary>
        /// <param name="pDateTime"></param>
        /// <param name="pTemperature"></param>
        /// <param name="pSolarRadiation"></param>
        /// <param name="pTemMax"></param>
        /// <param name="pTemMin"></param>
        /// <param name="pEvapotranspiration"></param>
        /// <returns></returns>
        public WeatherData UpdateWeatherData(DateTime pDateTime,
                                        Double pTemperature, Double pSolarRadiation, 
                                        Double pTemMax, Double pTemMin, 
                                        Double pEvapotranspiration)
        {
            WeatherData lReturn;
            WeatherData lWeatherData = new WeatherData(0, pDateTime, pTemperature,
                                                    pSolarRadiation, pTemMax, pTemMin,
                                                    pEvapotranspiration);

            lReturn = ExistWeatherData(lWeatherData);
            if(lReturn != null)
            {
                lWeatherData.Date = pDateTime;
                lWeatherData.Temperature = pTemperature;
                lWeatherData.SolarRadiation = pSolarRadiation;
                lWeatherData.TemperatureMax = pTemMax;
                lWeatherData.TemperatureMin = pTemMin;
                lWeatherData.Evapotranspiration = pEvapotranspiration;
            }
            return lReturn;
        }

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