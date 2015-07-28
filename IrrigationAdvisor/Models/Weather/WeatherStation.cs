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
        private Utils.WeatherDataType weatherDataType;

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

        public Utils.WeatherDataType WeatherDataType
        {
            get { return weatherDataType; }
            set { weatherDataType = value; }
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
            this.WeatherDataType = Utils.WeatherDataType.AllData;
        }

        /// <summary>
        /// Constructor with all parameters
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
        /// <param name="pWeatherDataList"></param>
        /// <param name="pWeatherDataType"></param>
        public WeatherStation(
            long pWeatherStationId, String pName, String pModel,
            DateTime pDateOfInstallation, DateTime pDateOfService,
            DateTime pUpdateTime, int pWirelessTransmission,
            Location pLocation, bool pGiveET,
            List<WeatherData> pWeatherDataList,
            Utils.WeatherDataType pWeatherDataType)
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
            this.WeatherDataType = pWeatherDataType;
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Set Weather Data Type by Weather Information
        /// Depends on WetherDataType of Weather Station, 
        /// and on Temperatures and Evapotranspiration of WeatherData
        /// </summary>
        /// <param name="pWeatherData"></param>
        /// <returns></returns>
        private Utils.WeatherDataType SetWeatherDataTypeByWeatherInformation(WeatherData pWeatherData)
        {
            Utils.WeatherDataType lReturn;
            Utils.WeatherDataType lWeatherDataType;

            lWeatherDataType = Utils.WeatherDataType.NoData;
            if (this.ExistWeatherData(pWeatherData) != null)
            {
                lWeatherDataType = this.WeatherDataType;

                //If we only have Evapotranspiraton
                if (lWeatherDataType == Utils.WeatherDataType.Evapotranspiraton)
                {
                    pWeatherData.Temperature = 0;
                    pWeatherData.TemperatureMax = 0;
                    pWeatherData.TemperatureMin = 0;
                    pWeatherData.WeatherDataType = lWeatherDataType;
                }
                //If we only have Temperature
                else if (lWeatherDataType == Utils.WeatherDataType.Temperature)
                {
                    pWeatherData.Evapotranspiration = 0;
                    pWeatherData.WeatherDataType = lWeatherDataType;
                }
                else
                {
                    //Has No Data
                    if (pWeatherData.Evapotranspiration == 0 
                        && pWeatherData.TemperatureMax == 0 && pWeatherData.TemperatureMin == 0)
                    {
                        pWeatherData.WeatherDataType = Utils.WeatherDataType.NoData;
                    }
                    //No Temperature Data
                    else if (pWeatherData.TemperatureMax == 0 && pWeatherData.TemperatureMin == 0)
                    {
                        pWeatherData.WeatherDataType = Utils.WeatherDataType.Evapotranspiraton;
                    }
                    //No Evapotranspiration Data
                    else if (pWeatherData.Evapotranspiration == 0)
                    {
                        pWeatherData.WeatherDataType = Utils.WeatherDataType.Temperature;
                    }
                }
            }

            lReturn = lWeatherDataType;
            return lReturn;
        }

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
                                        Double pTemperatureMax, Double pTemperatureMin, 
                                        Double pEvapotranspiration)
        {
            WeatherData lReturn;
            WeatherData lWeatherData = null;
            Utils.WeatherDataType lWeatherDataType;
            long lWeatherDataId = 0;

            try
            {
                lWeatherDataId = this.WeatherDataList.Count();
                lWeatherDataType = this.WeatherDataType;
                
                lWeatherData = new WeatherData(lWeatherDataId, pDateTime, pTemperature,
                                                pTemperatureMax, pTemperatureMin, pSolarRadiation,
                                                pEvapotranspiration, lWeatherDataType);

                lWeatherDataType = SetWeatherDataTypeByWeatherInformation(lWeatherData);
                
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
                                        Double pTemperatureMax, Double pTemperatureMin, 
                                        Double pEvapotranspiration)
        {
            WeatherData lReturn;
            WeatherData lWeatherData = null;
            Utils.WeatherDataType lWeatherDataType;

            try
            {
                lWeatherDataType = this.WeatherDataType;
                lWeatherData = new WeatherData(0, pDateTime, pTemperature,
                                                pTemperatureMax, pTemperatureMin, pSolarRadiation,
                                                pEvapotranspiration, lWeatherDataType);

                lReturn = ExistWeatherData(lWeatherData);
                if(lReturn != null)
                {
                    lReturn.Date = pDateTime;
                    lReturn.Temperature = pTemperature;
                    lReturn.SolarRadiation = pSolarRadiation;
                    lReturn.TemperatureMax = pTemperatureMax;
                    lReturn.TemperatureMin = pTemperatureMin;
                    lReturn.Evapotranspiration = pEvapotranspiration;
                    lWeatherDataType = SetWeatherDataTypeByWeatherInformation(lReturn);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in WeatherStation.AddWeatherDataToList " + e.Message);
                //TODO manage and log the exception
                throw e;
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