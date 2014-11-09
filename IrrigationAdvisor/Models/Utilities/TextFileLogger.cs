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
        private const String FOLDER_NAME = "C:\\TextLog\\";
        private const String FILE_NAME = "LogTextFile.txt";
        
        #endregion

        #region Fields
        #endregion

        #region Properties
        private static String ConfigFilePath
        {
            get 
            {
                String lFilePath = "";
                lFilePath = Application.UserAppDataPath + FILE_NAME;
                lFilePath = Environment.ExpandEnvironmentVariables(FOLDER_NAME + FILE_NAME);
                return  lFilePath;}
        }
        
        #endregion

        #region Construction
        public TextFileLogger()
        {
            if (!Directory.Exists(FOLDER_NAME))
            {
                Directory.CreateDirectory(FOLDER_NAME);
            }

            if (File.Exists(ConfigFilePath))
            {
                
                File.Delete(ConfigFilePath);
            }
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        public void WriteLogFile (String pFileName, String pMethodName, String pMessage, String pTime)
        {
            //String FolderPath = Environment.ExpandEnvironmentVariables("C:\\TextLog\\LogFile.txt");
            FileStream fs = null;
            if (!File.Exists(ConfigFilePath))
            {
                using (fs = File.Create(ConfigFilePath))
                {
                    //fs.Close();
                }
            }
            else
            {
                File.Delete(ConfigFilePath);
            }
            try
            {
                if (String.IsNullOrEmpty(pTime))
                    pTime = System.DateTime.Now.ToString();
                if (!string.IsNullOrEmpty(pMessage))
                {
                    using (FileStream lFile = new FileStream(ConfigFilePath, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        lFile.Close();
                        StreamWriter lStreamWriter = new StreamWriter(ConfigFilePath, true);
                        lStreamWriter.WriteLine((((pTime + " - ") + pFileName + " - ") + pMethodName + " - ") + pMessage + "\r\n");
                        lStreamWriter.WriteLine("---------------------------------------- ");
                        lStreamWriter.Close();
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public String ReadLogFile()
        {
            //String FolderPath = Environment.ExpandEnvironmentVariables("C:\\User\\LogFile.txt");
            String lReadLog = "";
            if (File.Exists(ConfigFilePath))
            {
                try
                {
                    using (FileStream lFile = new FileStream(ConfigFilePath, FileMode.Open, FileAccess.Read))
                    {
                        lFile.Close();
                        StreamReader lStreamReader = new StreamReader(ConfigFilePath, true);
                        lReadLog = lStreamReader.ReadToEnd();
                        lStreamReader.Close();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return lReadLog;              
        }
        #endregion

        #region Overrides
        #endregion

    }
}