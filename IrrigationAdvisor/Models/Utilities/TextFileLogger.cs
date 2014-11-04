using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.IO;
using System.Text;
using System.Windows.Forms;

namespace IrrigationAdvisor.Models.Utilities
{
    /// <summary>
    /// Create: 2014-10-26
    /// Author: rodouy 
    /// Description: 
    ///     Template of a new class summary
    ///     
    /// References:
    ///     list of classes this class use
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String
    /// 
    /// Methods:
    ///     - ClassTemplate()      -- constructor
    ///     - ClassTemplate(name)  -- consturctor with parameters
    ///     - SetName(newName)     -- method to set the name field
    /// 
    /// </summary>
    public class TextFileLogger
    {

        #region Consts
        private const String FILE_NAME = "LogTextFile.txt";
        
        #endregion

        #region Fields
        #endregion

        #region Properties
        private static String ConfigFilePath
        {
            get { return Application.UserAppDataPath + FILE_NAME; }
        }
        
        #endregion

        #region Construction
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        public void WriteLogFile(String fileName, String methodName, String message)
        {
            String FolderPath = Environment.ExpandEnvironmentVariables("C:\\User\\LogFile.txt");
            FileStream fs = null;
            if (!File.Exists(ConfigFilePath))
            {
                using (fs = File.Create(ConfigFilePath))
                {
                }
            }

        }
        #endregion

        #region Overrides
        #endregion

    }
}