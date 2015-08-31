using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Security
{
    /// <summary>
    /// Create: 2014-10-14
    /// Author: monicarle
    /// Description: 
    ///     Define the privileges of a group of users
    ///     
    /// References:
    ///     User
    ///     SiteMap
    ///     Menu
    ///
    /// Dependencies:
    ///     User
    ///     IrrigationSystem
    /// 
    /// TODO:
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String
    ///     - users List <User>
    ///     - site Site
    ///     - menu Menu
    /// 
    /// Methods:
    ///     
    ///     - Role()   
    ///     - Role(name, users, site, menu)  
    ///     - add(User)
    ///     - delete(User)
    ///     - sendSite: Site
    /// 
    /// </summary>
    public class Role
    {

        #region Consts
        #endregion


        #region Fields
        /// <summary>
        /// The fields are:
        ///     - name: the name of the instance
        ///     
        /// </summary>
        
        private long roleId;
        private string name;
        private List<User> users;
        private long siteId;
        private long menuId;

        #endregion


        #region Properties
        /// <summary>
        /// The properties are:
        ///     - Name: the name of the instance
        /// </summary>
        
        public long RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }

        public long SiteId
        {
            get { return siteId; }
            set { siteId = value; }
        }

        public long MenuId
        {
            get { return menuId; }
            set { menuId = value; }
        }

        #endregion

        #region Construction
        /// <summary>
        /// Constructor of ClassTemplate
        /// </summary>
        public Role()
        {
            this.roleId = 0;
            this.Name = "noname";
            this.users = null;
            this.siteId = 0;
            this.menuId = 0;
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="users"></param>
        /// <param name="pSiteId"></param>
        /// <param name="pMenuId"></param>
        public Role(long pRoleId, String pName, List<User> pUsers, 
                    long pSiteId, long pMenuId)
        {
            this.RoleId = pRoleId;
            this.name = pName;
            this.users = pUsers;
            this.siteId = pSiteId;
            this.menuId = pMenuId;
        }


        #endregion


        #region Private Helpers
        // private methods used only to support external API Methods
        /// <summary>
        /// Upper the phrase passed by parameter
        /// </summary>
        /// <param name="pPhrase"></param>
        /// <returns></returns>
        private string setUpper(string pPhrase)
        {
            return pPhrase.ToUpper();
        }

        private string setUpperFirstLetter(string pPhrase)
        {
            string lUpperFirstLetter = pPhrase;
            try
            {
                lUpperFirstLetter =
                    System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(pPhrase);
            }
            catch (Exception)
            {
                throw;
            }
            return lUpperFirstLetter;
        }

        #endregion


        #region Public Methods
        /// <summary>
        /// Method to set the name field
        /// </summary>
        /// <param name="pName">new name</param>
        public void SetName(string pNewName)
        {
            this.Name = this.setUpper(pNewName);
        }

        /// <summary>
        /// Add an user to User's list using this role
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool add(User user)
        {
            this.users.Add(user);
            return users.Contains(user);
        }
        
        /// <summary>
        /// Delete an user from the User's list using this role
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool delete(User user)
        {
            this.users.Remove(user);
            return !users.Contains(user);
        }

        /// <summary>
        /// Returns the SiteMap of a Roles
        /// </summary>
        /// <returns></returns>
        public long sendSite()
        {
            return this.siteId;
        }

        
        #endregion


        #region Overrides
        // Different region for each class override

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
            Role lPosition = obj as Role;
            return this.Name.Equals(lPosition.Name);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion


    }
}