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
        /// <summary>
        /// fields of user
        /// </summary>
        private string name;
        private List<User> users;
        private SiteMap site;
        private Menu menu;

        
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="users"></param>
        /// <param name="site"></param>
        /// <param name="menu"></param>
        public Role(String name, List<User> users, SiteMap site, Menu menu)
        {
            this.name = name;
            this.users = users;
            this.site = site;
            this.menu = menu;
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
            this.users.Add(user);
            return !users.Contains(user);
        }
        /// <summary>
        /// Returns the SiteMap of a Roles
        /// </summary>
        /// <returns></returns>
        public SiteMap sendSite()
        {
            return this.site;
        }
    }
}