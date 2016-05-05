using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.Models.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IrrigationAdvisor.Models.Utilities;

namespace IrrigationAdvisor.Models.Localization
{
    /// <summary>
    /// Create: 2015-01-15
    /// Author: rodouy 
    /// Description: 
    ///     Farm Class represent the land of the user with all his elements
    ///     
    /// References:
    ///     list of classes this class use
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    /// TODO: UnitTest Farm
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - idFarm long - PK (Primary Key)
    ///     - name String
    ///     - address String
    ///     - phone String
    ///     - location Location
    ///     - has int
    ///     - soilList List<Soil>
    ///     - bombList List<Bomb>
    ///     - weatherStation WeatherStation
    ///     - referentUser User
    ///     - irrigationUnitList List<IrrigationUnit>
    /// 
    /// Methods:
    ///     - Farm()      -- constructor
    ///     - Farm(name, address, phone, location, user)  -- consturctor with parameters
    ///     
    /// </summary>
    public class Farm
    {

        #region Consts
        #endregion

        #region Fields

        private long idFarm;
        private String name;
        private String company;
        private String address;
        private String phone;
        private long positionId;
        private int has;
        private long weatherStationId;
        private WeatherStation weatherStation;
        private List<Soil> soilList;
        private List<Bomb> bombList;
        private List<IrrigationUnit> irrigationUnitList;
        private long userId;

        #endregion

        #region Properties

        public long IdFarm
        {
            get { return idFarm; }
            set { idFarm = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Company
        {
            get { return company; }
            set { company = value; }
        }
        
        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public long PositionId
        {
            get { return positionId; }
            set { positionId = value; }
        }

        public int Has
        {
            get { return has; }
            set { has = value; }
        }

        public long WeatherStationId
        {
            get { return weatherStationId; }
            set { weatherStationId = value; }
        }

        public WeatherStation WeatherStation
        {
            get { return weatherStation; }
            set { weatherStation = value; }
        }
        
        public List<Soil> SoilList
        {
            get { return soilList; }
            set { soilList = value; }
        }

        public List<Bomb> BombList
        {
            get { return bombList; }
            set { bombList = value; }
        }
        
        public List<IrrigationUnit> IrrigationUnitList
        {
            get { return irrigationUnitList; }
            set { irrigationUnitList = value; }
        }

        public long  UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor of Farm
        /// </summary>
        public Farm()
        {
            this.IdFarm = 0;
            this.Name = "NoName";
            this.Address = "";
            this.Phone = "";
            this.PositionId = 0;
            this.Has = 0;
            this.WeatherStationId = 0;
            this.WeatherStation = new WeatherStation();
            this.SoilList = new List<Soil>();
            this.BombList = new List<Bomb>();
            this.IrrigationUnitList = new List<IrrigationUnit>();
            this.UserId = 0;
        }

        /// <summary>
        /// Constructor of Farm with parameters
        /// </summary>
        /// <param name="pIdFarm"></param>
        /// <param name="pName"></param>
        /// <param name="pAddress"></param>
        /// <param name="pPhone"></param>
        /// <param name="pPositionId"></param>
        /// <param name="pHas"></param>
        /// <param name="pWeatherStation"></param>
        /// <param name="pSoilList"></param>
        /// <param name="pBombList"></param>
        /// <param name="pIrrigationUnitList"></param>
<<<<<<< HEAD
        public Farm(long pIdFarm, String pName, String pAddress,
                    String pPhone, Location pLocation, int pHas,
=======
        /// <param name="pUserId"></param>
        public Farm(long pFarmId, String pName, String pCompany,
                    String pAddress,String pPhone, long pPositionId, 
                    int pHas, WeatherStation pWeatherStation, 
>>>>>>> 58290beb60242c969fa5a51c8d9de37319de5d7c
                    List<Soil> pSoilList, List<Bomb> pBombList,
                    List<IrrigationUnit> pIrrigationUnitList,
                    long pUserId)
        {
            this.IdFarm = pIdFarm;
            this.Name = pName;
            this.Company = pCompany;
            this.Address = pAddress;
            this.Phone = pPhone;
            this.PositionId = pPositionId;
            this.Has = pHas;
            this.WeatherStationId = pWeatherStation.WeatherStationId;
            this.WeatherStation = pWeatherStation;
            this.SoilList = pSoilList;
            this.BombList = pBombList;
            this.IrrigationUnitList = pIrrigationUnitList;
            this.UserId = pUserId;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        
        #region Bomb

        /// <summary>
        /// Return if the Bomb exists in Farm Bomb List,
        /// else null
        /// </summary>
        /// <param name="pBomb"></param>
        /// <returns></returns>
        public Bomb ExistBomb(Bomb pBomb)
        {
            Bomb lReturn = null;
            if (pBomb != null)
            {
                foreach (Bomb item in this.BombList)
                {
                    if (item.Equals(pBomb))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a Bomb to Farm Bomb List,
        /// If exists return null
        /// </summary>
        /// <param name="pBomb"></param>
        public Bomb AddBomb(Bomb pBomb)
        {
            Bomb lRetrurn = null;
            if(ExistBomb(pBomb) == null)
            {
                BombList.Add(pBomb);
                lRetrurn = pBomb;
            }
            return lRetrurn;
        }

        #endregion

        #region Soil

        /// <summary>
        /// Return if the Soil exists in Farm Soil List,
        /// else null
        /// </summary>
        /// <param name="pSoil"></param>
        /// <returns></returns>
        public Soil ExistSoil(Soil pSoil)
        {
            Soil lReturn = null;
            foreach (Soil item in this.SoilList)
            {
                if(item.Equals(pSoil))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a Soil to Farm Soil List,
        /// If exists return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pDescription"></param>
        /// <param name="pLocation"></param>
        /// <param name="pTestDate"></param>
        /// <param name="pDepthLimit"></param>
        /// <returns></returns>
        public Soil AddSoil(String pName, String pDescription, long pPositionId, 
                            DateTime pTestDate, double pDepthLimit)
        {
            Soil lReturn = null;
            long lIdSoil = this.SoilList.Count();
            Soil lSoil = new Soil(lIdSoil, pName, pDescription, pPositionId, pTestDate, pDepthLimit);
            if(ExistSoil(lSoil) == null)
            {
                this.SoilList.Add(lSoil);
                lReturn = lSoil;
            }
            return lReturn;
        }

        /// <summary>
        /// Update the Soil from Farm Soil List,
        /// If do not exists return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pDescription"></param>
        /// <param name="pLocation"></param>
        /// <param name="pTestDate"></param>
        /// <param name="pDepthLimit"></param>
        /// <returns></returns>
        public Soil UpdateSoil(String pName, String pDescription, long pPositionId,
                            DateTime pTestDate, double pDepthLimit)
        {
            Soil lReturn = null;
            Soil lSoil = new Soil(0, pName, pDescription, pPositionId, pTestDate, pDepthLimit);
            lReturn = ExistSoil(lSoil);
            if(lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Description = pDescription;
                lReturn.PositionId = pPositionId;
                lReturn.TestDate = pTestDate;
                lReturn.DepthLimit = pDepthLimit;
            }
            return lReturn;
        }

        #endregion

        #region IrrigationUnit

        /// <summary>
        /// Return if the IrrigationUnit exists in Farm IrrigationUnit List,
        /// else null
        /// </summary>
        /// <param name="pIrrigationUnit"></param>
        /// <returns></returns>
        public IrrigationUnit ExistIrrigationUnit(IrrigationUnit pIrrigationUnit)
        {
            IrrigationUnit lReturn = null;
            foreach (IrrigationUnit item in this.IrrigationUnitList)
            {
                if(item.Equals(pIrrigationUnit))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a IrrigationUnit to Farm IrrigationUnit List,
        /// If exists return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pIrrigationType"></param>
        /// <param name="pIrrigationEfficiency"></param>
        /// <param name="pIrrigationList"></param>
        /// <param name="pSurface"></param>
        /// <param name="pCropList"></param>
        /// <param name="pBomb"></param>
        /// <param name="pLocation"></param>
        /// <returns></returns>
        public IrrigationUnit AddIrrigationUnit(String pName, String pIrrigationType, 
                                    double pIrrigationEfficiency, List<Pair<DateTime, double>> pIrrigationList,
                                    double pSurface, List<Crop> pCropList, long pBombId, long pPositionId)
        {
            IrrigationUnit lReturn = null;
            long lIdIrrigationUnit = this.IrrigationUnitList.Count();
            IrrigationUnit lIrrigationUnit = new IrrigationUnit(lIdIrrigationUnit,
                                            pName, pIrrigationType, pIrrigationEfficiency,
                                            pIrrigationList, pSurface, pCropList,
                                            pBombId, pPositionId);
            if(ExistIrrigationUnit(lIrrigationUnit) == null)
            {
                this.IrrigationUnitList.Add(lIrrigationUnit);
                lReturn = lIrrigationUnit;
            }
            return lReturn;
        }

        /// <summary>
        /// Update the IrrigationUnit from Farm IrrigationUnit List,
        /// If do not exists return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pIrrigationType"></param>
        /// <param name="pIrrigationEfficiency"></param>
        /// <param name="pIrrigationList"></param>
        /// <param name="pSurface"></param>
        /// <param name="pCropList"></param>
        /// <param name="pBomb"></param>
        /// <param name="pLocation"></param>
        /// <returns></returns>
        public IrrigationUnit UpdateIrrigationUnit(String pName, String pIrrigationType,
                                    double pIrrigationEfficiency, List<Pair<DateTime, double>> pIrrigationList,
                                    double pSurface, List<Crop> pCropList, long pBombId, long pPositionId)
        {
            IrrigationUnit lReturn = null;
            IrrigationUnit lIrrigationUnit = new IrrigationUnit(0,
                                            pName, pIrrigationType, pIrrigationEfficiency,
                                            pIrrigationList, pSurface, pCropList,
                                            pBombId, pPositionId);
            lReturn = ExistIrrigationUnit(lIrrigationUnit);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.IrrigationType = pIrrigationType;
                lReturn.IrrigationEfficiency = pIrrigationEfficiency;
                lReturn.IrrigationList = pIrrigationList;
                lReturn.Surface = pSurface;
                lReturn.CropList = pCropList;
                lReturn.BombId = pBombId;
                lReturn.PositionId = pPositionId;
            }
            return lReturn;
        }

        #endregion

        #endregion

        #region Overrides

        /// <summary>
        /// Overrides equals, Name, PositionId And UserId
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            Farm lFarm = obj as Farm;
            return this.Name.Equals(lFarm.Name)
                && this.PositionId.Equals(lFarm.PositionId)
                && this.UserId.Equals(lFarm.UserId);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        
        #endregion

    }
}