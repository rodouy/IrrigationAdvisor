using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Management;

namespace IrrigationAdvisor.Models.IrrigationSystem
{
    /// <summary>
    /// Create: 2014-11-01
    /// Author: monicarle
    /// Description: 
    ///     Manage all the information of the system
    ///     
    /// References:
    ///     almost all
    ///     
    /// Dependencies:
    ///     
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - cropIrrigationWeatherList List<CropIrrigationWeather>
    /// 
    /// Methods:
    ///     - IrrigationSystem()      -- constructor
    ///     
    /// </summary>
    public class IrrigationSystem
    {
        #region Index
        //Crop
        //Irrigation
        //Language
        //Location
        //Management
        //Security 
        //Utitilities
        //Water
        //WeatherStation

        #endregion

        #region Consts
        #endregion

        #region Fields

        //Crop
        //Irrigation
        //Language
        //Location

        //Management
        private List<CropIrrigationWeather> cropIrrigationWeatherList;
        private List<DailyRecord> dailyRecordsList;
        private List<CropIrrigationWeatherRecords> cropIrrigationWeatherRecordsList;


        //Security 
        //Utitilities

        //Water
        private List<Water.WaterInput> rainList;
        private List<Water.WaterInput> irrigationList;
        private List<Water.WaterOutput> evapotranspirationList;

        
        //WeatherStation
        private List<WeatherStation.WeatherData> weatherDataList;

        #endregion

        #region Properties

        //Crop
        //Irrigation
        //Language
        //Location
        //Management
        public List<CropIrrigationWeather> CropIrrigationWeatherList
        {
            get { return cropIrrigationWeatherList; }
            set { cropIrrigationWeatherList = value; }
        }

        public List<DailyRecord> DailyRecordsList
        {
            get { return dailyRecordsList; }
            set { dailyRecordsList = value; }
        }

        public List<CropIrrigationWeatherRecords> CropIrrigationWeatherRecordsList
        {
            get { return cropIrrigationWeatherRecordsList; }
            set { cropIrrigationWeatherRecordsList = value; }
        }
        //Security 
        //Utitilities

        //Water
        public List<Water.WaterInput> RainList
        {
            get { return rainList; }
            set { rainList = value; }
        }

        public List<Water.WaterInput> IrrigationList
        {
            get { return irrigationList; }
            set { irrigationList = value; }
        }

        public List<Water.WaterOutput> EvapotranspirationList
        {
            get { return evapotranspirationList; }
            set { evapotranspirationList = value; }
        }

        //WeatherStation
        public List<WeatherStation.WeatherData> WeatherDataList
        {
            get { return weatherDataList; }
            set { weatherDataList = value; }
        }

        
        #endregion

        #region Construction
        //TODO Singleton???
        public IrrigationSystem()
        {

            //Crop
            
            //Irrigation

            //Language

            //Location

            //Management
            this.CropIrrigationWeatherList = new List<CropIrrigationWeather>();
            this.DailyRecordsList = new List<DailyRecord>();
            this.CropIrrigationWeatherRecordsList = new List<CropIrrigationWeatherRecords>();
            //Security 

            //Utitilities

            //Water
            this.EvapotranspirationList = new List<Water.WaterOutput>();
            this.IrrigationList = new List<Water.WaterInput>();
            this.RainList = new List<Water.WaterInput>();

            //WeatherStation
            this.WeatherDataList = new List<WeatherStation.WeatherData>();

        }

        #endregion


        #region Private Helpers

        //Crop
        //Irrigation
        //Language
        //Location
        //Management
        //Security 
        //Utitilities
        //Water
        private Water.WaterOutput getEvapotranspirationFromList(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime)
        {
            Water.WaterOutput lReturn = null;
            foreach (Water.WaterOutput lWaterOutput in this.EvapotranspirationList)
                if (lWaterOutput.Date.Equals(pDateTime) && lWaterOutput.CropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    lReturn = lWaterOutput;
                    return lReturn;
                }
            return lReturn;
        }
        private Water.WaterInput getIrrigationFromList(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime)
        {
            Water.WaterInput lReturn = null;
            foreach (Water.WaterInput lWaterInput in this.irrigationList)
                if (lWaterInput.Date.Equals(pDateTime) && lWaterInput.CropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    lReturn = lWaterInput;
                    return lReturn;
                }
            return lReturn;
        }

        private Water.WaterInput getRainFromList(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime)
        {
            Water.WaterInput lReturn = null;
            foreach(Water.WaterInput lWaterInput in this.rainList)
                if(lWaterInput.Date.Equals(pDateTime) && lWaterInput.CropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    lReturn = lWaterInput;
                    return lReturn;
                }
            return lReturn;

        }
  
        //WeatherStation
        private WeatherStation.WeatherData getWeatherDataFromList(WeatherStation.WeatherStation pWeatherStation, DateTime pDateTime) 
        {
            WeatherStation.WeatherData lReturn = null;
            foreach(WeatherStation.WeatherData lWeatherData in this.WeatherDataList)
            {
                if (lWeatherData.WeatherStation.Equals(pWeatherStation) && pDateTime.Date.Equals(pDateTime.Date))
                {
                    lReturn = lWeatherData;
                    return lReturn;
                }
            }
            return lReturn;

        }

        #endregion

        #region Public Methods

        //Crop
        //Irrigation
        //Language
        //Location
        //Management

        public bool addCropIrrigWeatherToList(CropIrrigationWeather pCropIrrigationWeather) 
        {
            bool lReturn = true;
            try
            {
                this.CropIrrigationWeatherList.Add(pCropIrrigationWeather);
                DateTime lDate = pCropIrrigationWeather.Crop.SowingDate;
                this.addDailyRecordToList(pCropIrrigationWeather, lDate, "Initial registry");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in IrrigationSystem.addCropIrrigWeatherToList " + e.Message);
                //TODO manage and log the exception
                throw e;
            }
            return lReturn;
        }
        public bool addDailyRecordToList(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime, String pObservations)
        {
            bool lReturn = false;
            WeatherStation.WeatherStation lWeatherStation = null;
            WeatherStation.WeatherData lMainWeatherData = null;
            WeatherStation.WeatherData lAlternativeWeatherData = null;
            double lAverageTemp = 0;
            double lBaseTemperature = 0;
            double lGrowingDegree = 0;
            double lEvapotranspiration = 0;
            Water.WaterInput lRain = null;
            Water.WaterInput lIrrigation = null;
            try
            {
                //Controlo que la CIW y la fecha no sean null
                if (this.CropIrrigationWeatherList.Contains(pCropIrrigationWeather) && pDateTime != null)
                {
                    lWeatherStation = pCropIrrigationWeather.MainWeatherStation;
                    lMainWeatherData = getWeatherDataFromList(lWeatherStation, pDateTime);
                    lAverageTemp = lMainWeatherData.getAverageTemperature();
                    lEvapotranspiration = lMainWeatherData.getEvapotranspiration();
                    if (lMainWeatherData == null)//Checque si es necesario usar estacion alternativa
                    {
                        lWeatherStation = pCropIrrigationWeather.AlternativeWeatherStation;
                        lAlternativeWeatherData = getWeatherDataFromList(lWeatherStation, pDateTime);
                        lAverageTemp = lAlternativeWeatherData.getAverageTemperature();
                        lEvapotranspiration = lAlternativeWeatherData.getEvapotranspiration();

                    }
                    // Si hay datos de estacion meteorologica puedo seguir
                    if (lMainWeatherData != null || lAlternativeWeatherData != null)
                    {

                        lBaseTemperature = pCropIrrigationWeather.Crop.getBaseTemperature();
                        lGrowingDegree = lAverageTemp - lBaseTemperature;
                        // con el dato lEvapotranspiration tengo que calcular la ETC del crop
                        // para ello tengo que ver el KC del cultivo segun los  lGrowingDegree acumulados
                        Water.WaterOutput lEvapotranspirationCrop = new Water.EvapotranspirationCrop(pCropIrrigationWeather, pDateTime, lEvapotranspiration);
                        this.EvapotranspirationList.Add(lEvapotranspirationCrop);
                        lIrrigation = this.getIrrigationFromList(pCropIrrigationWeather, pDateTime);
                        lRain = this.getRainFromList(pCropIrrigationWeather, pDateTime);
                        double lModifiedGrowingDegree = 0;
                        DailyRecord lNewDailyRecord = new DailyRecord(pCropIrrigationWeather, lMainWeatherData, lAlternativeWeatherData, pDateTime, lGrowingDegree, lModifiedGrowingDegree,
                            lEvapotranspirationCrop, lRain, lIrrigation, pObservations);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in IrrigationSystem.addDailyRecordToList " + e.Message);
                //TODO manage and log the exception
                throw e;
            }
            return lReturn;

        }





        //Security 
        //Utitilities

        public String printDailyRecordsList()
        {
            String lReturn = Environment.NewLine + "DAILY RECORDS" + Environment.NewLine ;
            foreach(DailyRecord lDailyrecord in this.DailyRecordsList)
            {
                lReturn += lDailyrecord.ToString() + Environment.NewLine;
            }
            return lReturn;
        }


        public String printWeatherDataList()
        {
            String lReturn = Environment.NewLine + "WEATHER DATA" + Environment.NewLine;
            foreach (WeatherStation.WeatherData lWeatherData in this.WeatherDataList)
            {
                lReturn += lWeatherData.ToString() + Environment.NewLine;
            }
            return lReturn;
        }
        //Water
        //WeatherStation
        public bool addWeatherDataToList(WeatherStation.WeatherStation pWeatherStation, DateTime pDateTime,
            double pTemperature, int pSolarRadiation, double pTemMax,
            double pTemMin, double pEvapotranspiration)
        {
            bool lReturn = false;
            try
            {
                WeatherStation.WeatherData lData = new WeatherStation.WeatherData(pWeatherStation, pDateTime,
                    pTemperature, pSolarRadiation, pTemMax, pTemMin, pEvapotranspiration);
                this.WeatherDataList.Add(lData);
                lReturn = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in IrrigationSystem.addWeatherData " + e.Message);
                //TODO manage and log the exception
                throw e;
            }
            return lReturn;
 
        }

        public bool addIrrigationDataToList(CropIrrigationWeather pCropIrrigationWeather,
            DateTime pDate, double pInput)
        {
            bool lReturn = false;
            try
            {
                Water.Irrigation lNewIrrigation = new Water.Irrigation();
                lNewIrrigation.CropIrrigationWeather = pCropIrrigationWeather;
                lNewIrrigation.Date = pDate;
                lNewIrrigation.Input = pInput;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in IrrigationSystem.addIrrigationData " + e.Message);
                //TODO manage and log the exception
                throw e;
            }
            return lReturn;
        }

        public bool addRainDataToList(CropIrrigationWeather pCropIrrigationWeather,
            DateTime pDate, double pInput)
        {
            bool lReturn = false;
            try
            {
                Water.Rain lNewRain = new Water.Rain();
                lNewRain.CropIrrigationWeather = pCropIrrigationWeather;
                lNewRain.Date = pDate;
                lNewRain.Input = pInput;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in IrrigationSystem.addIrrigationData " + e.Message);
                //TODO manage and log the exception
                throw e;
            }
            return lReturn;
        }
        
        #endregion

        #region Overrides
        #endregion


    }
}