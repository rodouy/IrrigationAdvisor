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
    /// Create: 2014-12-26
    /// Author: rodouy 
    /// Description: 
    ///     This class is for exit with CSV format to be readed by Excel.
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
    ///     - folderName String
    ///     - fileName String
    ///     - fileHeader Sting
    ///     - fileFooter String
    /// 
    /// Methods:
    ///     - OutputFileCSV()           -- constructor
    ///     - OutputFileCSV(FileName)   -- consturctor with parameters
    ///     - AddTitle(pData)           -- method to set the titles of all the fields
    ///     - AddMessage(pData)         -- method to set the line of fields
    ///     - WriteFile()               -- method to write the file
    /// 
    /// </summary>
    public class OutputFileCSV
    {

        #region Consts

        private const String FOLDER_ROOT = "C:\\";
        private const String FOLDER_NAME = "ExitCSV\\";
        private const String FILE_NAME = "LOGcsv";
        private const String FILE_EXTENTION = ".csv";
        
        #endregion

        #region Fields

        private String folderName;
        private String folderRoot;
        private String filePath;
        private String fileName;
        private String fileHeader;
        private String fileFooter;
        private List<String> fileTitles;
        private List<List<String>> fileMessages;
        private String dataSplit;
        
        #endregion

        #region Properties

        public String FolderRoot
        {
            get { return folderRoot; }
            set { folderRoot = value; }
        }

        public String FolderName
        {
            get { return folderName; }
            set { folderName = value; }
        }

        public String FilePath
        {
            get { return filePath; }            
        }

        public String FileName
        {
            get { return fileName; }
            set 
            {
                String lFileName = value;
                if (String.IsNullOrEmpty(lFileName))
                {
                    lFileName = FILE_NAME;
                }
                fileName = lFileName; 
            }
        }

        public String FileHeader
        {
            get { return fileHeader; }
            set
            {
                String lFileHeader = value;
                if (String.IsNullOrEmpty(lFileHeader))
                {
                    lFileHeader = "NO Header" + DataSplit;
                }
                else
                {
                    if(!lFileHeader.EndsWith(DataSplit))
                        lFileHeader += DataSplit;
                }
                fileHeader = lFileHeader;
            }
        }

        public String FileFooter
        {
            get { return fileFooter; }
            set
            {
                String lFileFooter = value;
                if (String.IsNullOrEmpty(lFileFooter))
                {
                    lFileFooter = "NO Footer" + DataSplit;
                }
                else
                {
                    if(!lFileFooter.EndsWith(DataSplit))
                        lFileFooter += DataSplit;
                }
                fileFooter = lFileFooter;
            }
        }

        public List<String> FileTitles
        {
            get { return fileTitles; }
            set
            {
                List<String> lFileTitles = value;
                if (lFileTitles == null)
                {
                    throw new ArgumentNullException();
                }
                if (lFileTitles.Count < 1)
                {
                    lFileTitles.Add("NO Titles" + DataSplit);
                }
                else
                {
                    lFileTitles = this.AddDataSplit(lFileTitles);                    
                }
                                
                fileTitles = lFileTitles;
            }
        }

        public List<List<String>> FileMessages
        {
            get { return fileMessages; }
            set
            {
                List<List<String>> lFileMessages = value;
                List<String> lMessage;
                if (lFileMessages == null)
                {
                    throw new ArgumentNullException();
                }
                if (lFileMessages.Count < 1)
                {
                    lMessage = new List<string>();
                    lMessage.Add("NO Data" + DataSplit);
                    lFileMessages.Add(lMessage);
                }
                else
                {
                    lMessage = lFileMessages.First<List<String>>();
                    if (lMessage == null)
                    {
                        throw new ArgumentNullException();
                    }
                    if (lMessage.Count < 1)
                    {
                        lMessage.Add("NO Data" + DataSplit);
                        lFileMessages.Add(lMessage);
                    }
                    else
                    {
                        for (int i = 0; i < lFileMessages.Count; i++)
                        {
                            lMessage = lFileMessages[i];
                            lFileMessages[i] = AddDataSplit(lMessage);
                        }
                    }
                }
                fileMessages = lFileMessages;
            }
        }

        public String DataSplit
        {
            get { return dataSplit; }
            set 
            {
                String lDataSplit = value;
                if(String.IsNullOrEmpty(lDataSplit))
                    lDataSplit = ";";
                dataSplit = lDataSplit; 
            }
        }

        private static String ConfigFilePath
        {
            get 
            {
                String lDate = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                String lFilePath = "";
                lFilePath = Application.UserAppDataPath + FILE_NAME + FILE_EXTENTION;
                lFilePath = Environment.ExpandEnvironmentVariables(FOLDER_ROOT + FOLDER_NAME + FILE_NAME + lDate + FILE_EXTENTION);
                return  lFilePath;
            }
        }

        #endregion

        #region Construction

        public OutputFileCSV()
        {
            String lDate = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            this.FolderRoot = FOLDER_ROOT;
            this.FolderName = FOLDER_ROOT + FOLDER_NAME;

            if (!Directory.Exists(this.FolderName))
            {
                Directory.CreateDirectory(this.FolderName);
            }

            if (File.Exists(ConfigFilePath))
            {
                
                File.Delete(ConfigFilePath);
            }
            this.fileName = FILE_NAME + lDate + FILE_EXTENTION;
            this.filePath = ConfigFilePath;
            this.dataSplit = ";";
        }

        public OutputFileCSV(String pFileName)
        {
            String lDate = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            this.FolderRoot = FOLDER_ROOT;
            this.FolderName = FOLDER_ROOT + FOLDER_NAME;
            this.FileName = pFileName + lDate + FILE_EXTENTION;
            this.filePath = this.FolderName + this.FileName;
            this.dataSplit = ";";

            if (!Directory.Exists(this.FolderName))
            {
                Directory.CreateDirectory(this.FolderName);
            }

            if (File.Exists(this.FilePath))
            {
                File.Delete(this.FilePath);
            }

        }
        #endregion

        #region Private Helpers
        
        
        /// <summary>
        /// Add Data Split to a List of Strings
        /// 
        /// </summary>
        /// <param name="pData"></param>
        private List<String> AddDataSplit(List<String> pData)
        {
            List<String> lReturn = pData;
            for (int i = 0; i < pData.Count; i++)
            {
                if (!pData[i].EndsWith(DataSplit))
                    pData[i] += DataSplit;
            }
            lReturn = pData;
            return lReturn;
        }

        private String GetAllData(List<String> pData)
        {
            String lReturn = "";
            for (int i = 0; i < pData.Count; i++)
            {
                lReturn += pData[i];
            }
            return lReturn;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Add all Titles
        /// 
        /// PreCondition 
        ///     Parameter has data
        /// </summary>
        /// <param name="pData"></param>
        public void AddAllTitles(List<String> pData)
        {
            if (pData != null)
            {
                if (pData.Count > 0 || pData.Any())
                {
                    pData = this.AddDataSplit(pData);
                    this.FileTitles = pData;
                }
            }
        }

        /// <summary>
        /// Add a Title
        /// 
        /// </summary>
        /// <param name="pData"></param>
        public void AddTitle(String pData)
        {
            if (!String.IsNullOrEmpty(pData))
            {
                this.FileTitles.Add(pData);
            }
        }

        public String GetTitles()
        {
            return GetAllData(this.FileTitles);
        }

        /// <summary>
        /// Add a new Message
        /// 
        /// PreCondition
        ///     Has data
        ///     Count of String Data equal to Count of Titles
        /// </summary>
        /// <param name="pData"></param>
        public void AddMessage(List<String> pData)
        {
            if (pData != null)
            {
                if(pData.Count > 0 || pData.Any() || pData.Count == this.FileTitles.Count)
                {
                    pData = this.AddDataSplit(pData);
                    this.FileMessages.Add(pData);
                }
            }
        }

        /// <summary>
        /// Return the index Message from Messages in a string 
        /// 
        /// PreCondition
        ///     index >= 0
        ///     FileMessages has data
        /// </summary>
        /// <param name="pIndex"></param>
        /// <returns></returns>
        public String GetMessage(int pIndex)
        {
            String lReturn = "";
            if (pIndex < 0)
                pIndex = 0;
            if(this.FileMessages.Count > 0)
                lReturn = GetAllData(this.FileMessages[pIndex]);
            return lReturn;
        }


        public void WriteFile (String pMethodName, String pDescription, String pTime)
        {
            //String FolderPath = Environment.ExpandEnvironmentVariables("C:\\TextLog\\LogFile.txt");
            FileStream fs = null;
            if (!File.Exists(this.FilePath))
            {
                using (fs = File.Create(this.FilePath))
                {
                    // Do not close because we want to write on it
                    //fs.Close();
                }
            }
            else
            {
                File.Delete(this.FilePath);
            }
            try
            {
                if (String.IsNullOrEmpty(pTime))
                    pTime = System.DateTime.Now.ToString();
                if (this.FileTitles != null && this.FileTitles.Count > 0)
                {
                    using (FileStream lFile = new FileStream(this.FilePath, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        lFile.Close();
                        StreamWriter lStreamWriter = new StreamWriter(this.FilePath, true);
                        lStreamWriter.WriteLine((((pTime + " - ") + this.FileName + " - ") + pMethodName + " - ") + pDescription + DataSplit);
                        lStreamWriter.WriteLine(this.FileHeader);
                        lStreamWriter.WriteLine(this.GetTitles());
                        for (int i = 0; i < this.FileMessages.Count; i++)
			            {
                            lStreamWriter.WriteLine(this.GetMessage(i));
			 			}
                        lStreamWriter.WriteLine(this.FileFooter);
                        lStreamWriter.WriteLine("---------------------------------------- " + DataSplit);
                        lStreamWriter.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String ReadFile()
        {
            //String FolderPath = Environment.ExpandEnvironmentVariables("C:\\User\\LogFile.txt");
            String lReadLog = "";
            if (File.Exists(FilePath))
            {
                try
                {
                    using (FileStream lFile = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
                    {
                        lFile.Close();
                        StreamReader lStreamReader = new StreamReader(FilePath, true);
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
       