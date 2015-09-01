﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Security
{
    
    /// <summary>
    /// Create: 2014-10-21
    /// Author: monicarle
    /// Description: 
    ///     Represent the head of SiteItem to which an user is allowed to access
    ///     Is a list of items in the site, to which a rol can access.
    ///     
    /// References:
    ///     SiteItem
    ///     Access
    ///     
    /// Dependencies:
    ///     Role
    ///     IrrigationSystem
    /// 
    /// TODO:
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String
    ///     - cameFrom SiteItem
    ///     - goTo List<SiteItem> 
    ///     
    /// Methods:
    ///     - SiteMap()        
    ///     - SiteMap(name, cameForm, goTo) 
    ///     - sendSite(): SiteMap
    ///     - allAccess(Access): bool
    ///     - setAccess(SiteItem, Access): bool
    /// 
    /// </summary>
    /// 
    
    public class SiteMap
    {
        
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - name: the name of the instance
        ///     - cameFrom: the SiteItem where the intance cameFrom
        ///     - goTo: others SiteItems where the role is allowed to go
        ///     
        /// </summary>
        private long siteMapId;
        private string name;
        private SiteItem cameFrom;
        private List<SiteItem> goTo;

        #endregion

        #region Properties

        public long SiteMapId
        {
            get { return siteMapId; }
            set { siteMapId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        internal SiteItem CameFrom
        {
            get { return cameFrom; }
            set { cameFrom = value; }
        }
        internal List<SiteItem> GoTo
        {
            get { return goTo; }
            set { goTo = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor of SiteMap
        /// </summary>
        public SiteMap()
        {
            this.SiteMapId = 0;
            this.Name = "noname";
        }
        /// <summary>
        /// Constructor of SiteMap with parameters
        /// </summary>
        /// <param name="pName">Name</param>
        /// <param name="pCameFrom">Where came from</param>
        /// <param name="pGoTo">SiteItems allowed go to</param>
        internal SiteMap(string pName, SiteItem pCameFrom, List<SiteItem> pGoTo)
        {
            this.Name = pName;
            this.CameFrom = pCameFrom;
            this.GoTo = pGoTo;
        }
        
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        /// <summary>
        /// ???
        /// </summary>
        /// <param name="newName">new name</param>
        public SiteMap sendSite()
        {
            return null;
        }

        /*public bool allAccess(Access access)
        {
            bool lAvailableWaterCapacitbleWaterCapacity = false;
            try
            {
                foreach (SiteItem siteItem in GoTo)
                {
                    siteItem.Access = access;
                }
            }
            catch (Exception e)
            {
                //TODO: SiteMap allAccesss exception management 
                Console.Write("SiteMap allAccesss exception");
                throw e;
            }
            lAvailableWaterCapacitbleWaterCapacity = true;
            return lAvailableWaterCapacitbleWaterCapacity;
        }*/

        /*public bool setAccess(SiteItem pSiteItem, Access access)
        {
            bool ret = false;
            try
            {
                foreach (SiteItem lSiteItem in GoTo)
                {
                    if (lSiteItem.Equals(pSiteItem))
                    {
                        lSiteItem.Access = access;
                        ret = true;
                    }

                }
            }
            catch (Exception e)
            {
                //TODO: SiteMap allAccesss exception management 
                Console.Write("SiteMap allAccesss exception");
                throw e;
            }

            return ret;
        }*/
        
        #endregion

        #region Overrides
        #endregion

        
    }
}