using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Security
{
    /// <summary>
    /// Create: 2014-10-14
    /// Author: rodouy - monicarle
    /// Description: 
    ///     Describe the user of the site
    /// 
    /// References:
    ///     Language
    ///     Farm
    ///     Role
    /// 
    /// Dependencies:
    /// 
    /// TODO:
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of User:
    ///     - name String
    ///     - surname String
    ///     - address String
    ///     - email String
    ///     - userName String
    ///     - password String
    ///     - farms List<Farm>
    ///     - language Language
    ///     - roles List<Role>
    /// 
    /// Methods:
    ///     - User()
    ///     - User(name, surname, email, password)
    ///     - changeData(name, surname, address, )
    ///     
    /// </summary>
    public class User
    {
        
        
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - userId
        ///     - name: the name of the instance
        ///     - surname
        ///     - phone
        ///     - address
        ///     - email
        ///     - userName
        ///     - password
        ///     
        /// </summary>

        private long userId;
        private String name;
        private String surname;
        private String phone;
        private String address;
        private String email;
        private String userName;
        private String password;


        #endregion

        #region Properties
        /// <summary>
        /// The properties are:
        ///     - UserId
        ///     - Name: the name of the instance
        ///     - Surname
        ///     - Phone
        ///     - Address
        ///     - EMail
        ///     - UserName
        ///     - Password
        /// </summary>
        
        
        public long UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        #endregion

        #region Construction
        /// <summary>
        /// Constructor of User
        /// </summary>
        public User()
        {
            this.UserId = 0;
            this.Name = "noname";
            this.Surname = "nosurname";
            this.Phone = "";
            this.Address = "";
            this.Email = "";
            this.UserName = "";
            this.Password = "";
        }

        /// <summary>
        /// Constructor of User with parameters
        /// </summary>
        /// <param name="pUserId"></param>
        /// <param name="pName"></param>
        /// <param name="pSurname"></param>
        /// <param name="pPhone"></param>
        /// <param name="pAddress"></param>
        /// <param name="pEmail"></param>
        /// <param name="pUserName"></param>
        /// <param name="pPassword"></param>
        public User(long pUserId, String pName, String pSurname, String pPhone,
                    String pAddress, String pEmail, String pUserName, String pPassword)
        {
            this.UserId = pUserId;
            this.Name = pName;
            this.Surname = pSurname;
            this.Phone = pPhone;
            this.Address = pAddress;
            this.Email = pEmail;
            this.UserName = pUserName;
            this.Password = pPassword;
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
            User lUser = obj as User;
            return this.UserName.Equals(lUser.UserName);
        }

        public override int GetHashCode()
        {
            return this.UserName.GetHashCode();
        }

        #endregion

        

    }
}