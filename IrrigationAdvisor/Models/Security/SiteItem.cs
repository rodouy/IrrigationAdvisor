using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IrrigationAdvisor.Models.Security
{
    public class SiteItem
    {
        
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - name: the name of the instance
        /// 
        /// </summary>
        
        private long siteItemId;
        private string name;
        
        #endregion

        #region Properties

        public long SiteItemId
        {
            get { return siteItemId; }
            set { siteItemId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor of SiteMap
        /// </summary>
        public SiteItem()
        {
            this.SiteItemId = 0;
            this.Name = "noname";
        }

        /// <summary>
        /// Constructor of SiteItem with parameters
        /// </summary>
        /// <param name="name">Name</param>
        internal SiteItem(long pSiteItemId, String pName)
        {
            this.SiteItemId = pSiteItemId;
            this.Name = pName;
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
