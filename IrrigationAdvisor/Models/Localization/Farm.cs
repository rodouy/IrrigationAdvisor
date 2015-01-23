using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.Models.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
        private String address;
        private String phone;
        private Location location;
        private int has;
        private List<Soil> soilList;
        private List<Bomb> bombList;
        private WeatherStation weatherStation;
        private User user;
        private List<IrrigationUnit> irrigationUnitList;

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

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }

        public int Has
        {
            get { return has; }
            set { has = value; }
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

        public WeatherStation WeatherStation
        {
            get { return weatherStation; }
            set { weatherStation = value; }
        }

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public List<IrrigationUnit> IrrigationUnitList
        {
            get { return irrigationUnitList; }
            set { irrigationUnitList = value; }
        }

        #endregion

        #region Construction

        public Farm()
        {
            this.IdFarm = 0;
            this.Name = "NoName";
            this.Address = "";
            this.Phone = "";
            this.Location = new Location();
            this.Has = 0;
            this.SoilList = new List<Soil>();
            this.BombList = new List<Bomb>();
            this.WeatherStation = new WeatherStation();
            this.User = new User();
            this.IrrigationUnitList = new List<IrrigationUnit>();
        }

        public Farm(int pIdFarm, String pName, String pAddress,
                    String pPhone, Location pLocation, int pHas,
                    List<Soil> pSoilList, List<Bomb> pBombList,
                    WeatherStation pWeatherStation, User pUser,
                    List<IrrigationUnit> pIrrigationUnitList)
        {
            this.IdFarm = pIdFarm;
            this.Name = pName;
            this.Address = pAddress;
            this.Phone = pPhone;
            this.Location = pLocation;
            this.Has = pHas;
            this.SoilList = pSoilList;
            this.BombList = pBombList;
            this.WeatherStation = pWeatherStation;
            this.User = pUser;
            this.IrrigationUnitList = pIrrigationUnitList;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        /// <summary>
        /// Return if a Bomb exists in Farm Bomb List
        /// </summary>
        /// <param name="pBomb"></param>
        /// <returns></returns>
        public bool ExistBomb(Bomb pBomb)
        {
            bool lReturn = false;
            if (pBomb != null)
            {
                foreach (Bomb item in this.BombList)
                {
                    if (item.Equals(pBomb))
                    {
                        lReturn = true;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a Bomb to Farm Bomb List
        /// </summary>
        /// <param name="pBomb"></param>
        public void AddBomb(Bomb pBomb)
        {
            if(pBomb != null && !this.ExistBomb(pBomb))
            {
                this.BombList.Add(pBomb);
            }
        }

        #endregion

        #region Overrides

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
            Farm lPosition = obj as Farm;
            return this.Name.Equals(lPosition.Name);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        #endregion

    }
}