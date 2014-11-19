using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Crop;
using IrrigationAdvisor.Models.Location;
using IrrigationAdvisor.Models.Utilities;

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
        private List<Pair<Region, List<PhenologicalStage>>> phenologicalStageList;


        //Irrigation
        //Language
        //Location

        //Management
        //////private List<DailyRecord> dailyRecordsList;
        private List<CropIrrigationWeather> cropIrrigationWeatherList;
        private List<CropIrrigationWeatherRecords> cropIrrigationWeatherRecordsList;

        private IrrigationCalculus irrigationCalculus;



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


        public List<Pair<Region, List<PhenologicalStage>>> PhenologicalStageList
        {
            get { return phenologicalStageList; }
            set { phenologicalStageList = value; }
        }
        
        //Irrigation
        //Language
        //Location
        //Management
        public List<CropIrrigationWeather> CropIrrigationWeatherList
        {
            get { return cropIrrigationWeatherList; }
            set { cropIrrigationWeatherList = value; }
        }

        public List<CropIrrigationWeatherRecords> CropIrrigationWeatherRecordsList
        {
            get { return cropIrrigationWeatherRecordsList; }
            set { cropIrrigationWeatherRecordsList = value; }
        }


        public IrrigationCalculus IrrigationCalculus
        {
            get { return irrigationCalculus; }
            set { irrigationCalculus = value; }
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
            this.PhenologicalStageList = new List<Pair< Region, List<PhenologicalStage>>>();
            //Irrigation

            //Language

            //Location

            //Management
            this.CropIrrigationWeatherList = new List<CropIrrigationWeather>();
            this.CropIrrigationWeatherRecordsList = new List<CropIrrigationWeatherRecords>();
            this.IrrigationCalculus = new IrrigationCalculus();
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pDateTime"></param>
        private void addDailyRecordToCropIrrigationWeather(CropIrrigationWeather pCropIrrigationWeather, DailyRecord pDailyRecord)
        {
            DateTime pDateTime = pDailyRecord.DateHour;
            int i = 0;
            int indexToRemove = -1;
            foreach (CropIrrigationWeatherRecords lCropIrrigationWeatherRecord in this.CropIrrigationWeatherRecordsList)
            {
                if (lCropIrrigationWeatherRecord.CropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    foreach (DailyRecord lDailyRecord in lCropIrrigationWeatherRecord.DailyRecords)
                    {
                        if (lDailyRecord.DateHour.Date.Equals(pDateTime.Date) && lDailyRecord.CropIrrigationWeather.Equals(pCropIrrigationWeather))
                        {
                            indexToRemove = i;
                        }
                        i++;
                    }
                    if (indexToRemove != -1)
                    {
                        lCropIrrigationWeatherRecord.DailyRecords.RemoveAt(indexToRemove);
                    }
                    lCropIrrigationWeatherRecord.addDailyRecord(pDailyRecord);
                }
            }

        }
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
                if (Utilities.Utils.isTheSameDay(lWaterInput.Date, pDateTime) && lWaterInput.CropIrrigationWeather.Equals(pCropIrrigationWeather))
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
                if(Utilities.Utils.isTheSameDay(lWaterInput.Date,pDateTime) && lWaterInput.CropIrrigationWeather.Equals(pCropIrrigationWeather))
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
        /// <summary>
        /// Return the WeatherData for the available weather station.
        /// First search in the main station. If there is no data, then search in the alternative wheather station.
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pDateTime"></param>
        /// <returns></returns>
        private WeatherStation.WeatherData getAvailableWeatherStationData(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime)
        {
            WeatherStation.WeatherData lReturn = null;
            WeatherStation.WeatherData lWeatherData = getWeatherDataFromList(pCropIrrigationWeather.MainWeatherStation, pDateTime);
            if (lWeatherData != null)
            {
                lReturn = lWeatherData;
            }
            else
            {
                lWeatherData = getWeatherDataFromList(pCropIrrigationWeather.AlternativeWeatherStation, pDateTime);
                if (lWeatherData != null)
                {
                    lReturn = lWeatherData;
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
                CropIrrigationWeatherRecords lCropIrrigationWeatherRecords = new CropIrrigationWeatherRecords();
                lCropIrrigationWeatherRecords.CropIrrigationWeather = pCropIrrigationWeather;
                double bhi = lCropIrrigationWeatherRecords.getInitialHidricBalance();
                lCropIrrigationWeatherRecords.HydricBalance = bhi;
                this.CropIrrigationWeatherRecordsList.Add(lCropIrrigationWeatherRecords);
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
            WeatherStation.WeatherData lWeatherData = null;
            WeatherStation.WeatherData lMainWeatherData = getWeatherDataFromList(pCropIrrigationWeather.MainWeatherStation, pDateTime); ;
            WeatherStation.WeatherData lAlternativeWeatherData = getWeatherDataFromList(pCropIrrigationWeather.AlternativeWeatherStation, pDateTime); ;
            double lAverageTemp = 0;
            double lBaseTemperature = 0;
            double lGrowingDegree = 0;
            double lEvapotranspiration = 0;
            Water.WaterInput lRain = null;
            Water.WaterInput lIrrigation = null;
            try
            {
                //Controlo que la CropIrrigationWeather y la fecha no sean null
                if (this.CropIrrigationWeatherList.Contains(pCropIrrigationWeather) && pDateTime != null)
                {
                    lWeatherData = this.getAvailableWeatherStationData(pCropIrrigationWeather, pDateTime);
                    // Si hay datos de estacion meteorologica puedo seguir
                    if (lWeatherData != null)
                    {
                        lAverageTemp = lWeatherData.getAverageTemperature();
                        lEvapotranspiration = lWeatherData.getEvapotranspiration();
                    
                        lBaseTemperature = pCropIrrigationWeather.Crop.getBaseTemperature();
                        lGrowingDegree = lAverageTemp - lBaseTemperature;
                        ////VER COMO TOMO EN CUENTA EL AJUSTE QUE SE HACE CON GRADOS DIAs
                        int lDays = Utilities.Utils.getDaysDifference(pCropIrrigationWeather.Crop.SowingDate, pDateTime);
                        double lCropCoefficient = pCropIrrigationWeather.Crop.CropCoefficient.getKC(lDays);
                        double lRealEvapotraspiration = lEvapotranspiration * lCropCoefficient;
                        // con el dato lEvapotranspiration tengo que calcular la ETC del crop
                        // para ello tengo que ver el KC del cultivo segun los  lGrowingDegree acumulados
                        Water.WaterOutput lEvapotranspirationCrop = new Water.EvapotranspirationCrop(pCropIrrigationWeather, pDateTime, lRealEvapotraspiration);
                        this.EvapotranspirationList.Add(lEvapotranspirationCrop);
                        lIrrigation = this.getIrrigationFromList(pCropIrrigationWeather, pDateTime);
                        lRain = this.getRainFromList(pCropIrrigationWeather, pDateTime);
                        double lModifiedGrowingDegree = 0;
                        
                        DailyRecord lNewDailyRecord = new DailyRecord(pCropIrrigationWeather, lMainWeatherData, lAlternativeWeatherData, pDateTime, lGrowingDegree, lModifiedGrowingDegree,
                            lEvapotranspirationCrop, lRain, lIrrigation, pObservations);
                        this.addDailyRecordToCropIrrigationWeather(pCropIrrigationWeather, lNewDailyRecord);///Si ya existe registro para ese dia se sobre-escribe

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

        public double howMuchToIrrigate(CropIrrigationWeather pCropIrrigationWeather)
        {
            double lReturn = 0;
            CropIrrigationWeatherRecords lCropIrrigationWeatherRecords = null;
            foreach (CropIrrigationWeatherRecords oneCropIrrigationWeatherRecords in this.CropIrrigationWeatherRecordsList)
            {
                if (oneCropIrrigationWeatherRecords.CropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    lCropIrrigationWeatherRecords = oneCropIrrigationWeatherRecords;
                }

            }
            if (lCropIrrigationWeatherRecords != null)
            {
                lReturn = this.IrrigationCalculus.howMuchToIrrigate(lCropIrrigationWeatherRecords);
            }
            return lReturn;
        }
        /// <summary>
        /// Return the Phenological Stage for a Specie in a Region given the rootDepth
        /// </summary>
        /// <param name="pDegree"></param>
        /// <param name="pRegion"></param>
        /// <param name="pSpecie"></param>
        /// <returns></returns>
        public PhenologicalStage getPhenologicalStage(double pDegree, Region pRegion, Specie pSpecie)
        {
            PhenologicalStage lReturn = null;
            List<PhenologicalStage> lPhenologicalStageListByRegion = null;
            foreach (Pair<Region , List<PhenologicalStage >> lPair in this.PhenologicalStageList)
            {
                if (lPair != null && lPair.First.Equals(pRegion))
                {
                    lPhenologicalStageListByRegion = lPair.Second;
                }
            }

            IEnumerable<PhenologicalStage> query = lPhenologicalStageListByRegion.OrderBy(lPhenologicalStage => lPhenologicalStage.MinDegree);
            foreach(PhenologicalStage lPhenStage in query)
            {
                if (lPhenStage != null && lPhenStage.Specie.Equals(pSpecie) && lPhenStage.MinDegree <= pDegree && lPhenStage.MaxDegree >= pDegree)
                {
                    lReturn = lPhenStage;
                }
            }
            return lReturn;

        }
        /// <summary>
        /// Return the List of Phenological Stage for a Specie in a Region
        /// </summary>
        /// <param name="pRegion"></param>
        /// <param name="pSpecie"></param>
        /// <returns></returns>
        public List<PhenologicalStage> getPhenologicalStage(Region pRegion, Specie pSpecie)
        {
            List<PhenologicalStage> lReturn = null;
            List<PhenologicalStage> lPhenologicalStageListByRegion = null;
            foreach (Pair<Region, List<PhenologicalStage>> lPair in this.PhenologicalStageList)
            {
                if (lPair != null && lPair.First.Equals(pRegion))
                {
                    lPhenologicalStageListByRegion = lPair.Second;
                }
            }

            IEnumerable<PhenologicalStage> query = lPhenologicalStageListByRegion.OrderBy(lPhenologicalStage => lPhenologicalStage.MinDegree);
            foreach (PhenologicalStage lPhenStage in query)
            {
                if (lPhenStage != null && lPhenStage.Specie.Equals(pSpecie))
                {
                    lReturn.Add(lPhenStage);
                }
            }
            return lReturn;

        }





        //Security 
        //Utitilities

        public String printDailyRecordsList()
        {
            String lReturn = Environment.NewLine + "DAILY RECORDS" + Environment.NewLine ;
            foreach (CropIrrigationWeatherRecords lCropIrrigationWeatherRecords in this.CropIrrigationWeatherRecordsList)
            {
                lReturn += Environment.NewLine +Environment.NewLine;

                foreach (DailyRecord lDailyrecord in lCropIrrigationWeatherRecords.DailyRecords)
                {
                    lReturn += lDailyrecord.ToString() + Environment.NewLine;
                }
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
                this.IrrigationList.Add(lNewIrrigation);
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
                this.RainList.Add(lNewRain);
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