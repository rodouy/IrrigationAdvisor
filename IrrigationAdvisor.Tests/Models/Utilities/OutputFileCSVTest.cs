using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IrrigationAdvisor.Models.Utilities;
using System.Collections.Generic;

namespace IrrigationAdvisor.Tests.Models.Utilities
{
    [TestClass]
    public class OutputFileCSVTest
    {
        [TestMethod]
        public void WriteFileTest()
        {
            String lCompareTextFromFile;
            String lCompareText;

            String lFileName = "CSVTestFile";
            String lFilePath;
            String lFolderName;
            String lDataSplit;

            List<String> lTitles;
            List<List<String>> lMessages;
            List<String> lMessage;

            String lMethod;
            String lDescription;
            String lTime;

            OutputFileCSV lOutputFile;
            
            //Create the titles and messages to put into the file
            lTitles = new List<string>();
            lTitles.Add("Number");
            lTitles.Add("Name");

            lMessages = new List<List<string>>();

            lMessage = new List<string>();
            lMessage.Add("1");
            lMessage.Add("Uno");
            lMessages.Add(lMessage);

            lMessage = new List<string>();
            lMessage.Add("2");
            lMessage.Add("Dos");
            lMessages.Add(lMessage);

            lMessage = new List<string>();
            lMessage.Add("3");
            lMessage.Add("Tres");
            lMessages.Add(lMessage);

            //Information about the file output
            lMethod = "WriteFileTest";
            lDescription = "Do the unit Test for this class";
            lTime = System.DateTime.Now.ToString();

            //create the file
            lOutputFile = new OutputFileCSV(lFileName);
            lFolderName = lOutputFile.FolderName;
            lFilePath = lOutputFile.FilePath;
            lDataSplit = lOutputFile.DataSplit;

            //Input of file information
            lOutputFile.FileHeader = "File Header inforation";
            lOutputFile.FileTitles = lTitles;
            lOutputFile.FileMessages = lMessages;
            lOutputFile.FileFooter = "File Footer information";


            lOutputFile.WriteFile(lMethod, lDescription, lTime);


            lCompareText = ((((lTime + " - ") + lFileName + " - ") + lMethod + " - ") + lDescription + lDataSplit);
            lCompareText += "\n";
            lCompareText += lOutputFile.FileHeader;
            lCompareText += "\n";
            lCompareText += lOutputFile.GetTitles();
            lCompareText += "\n";
            for (int i = 0; i < lOutputFile.FileMessages.Count; i++)
            {
                lCompareText += lOutputFile.GetMessage(i);
                lCompareText += "\n";
            }
            lCompareText += lOutputFile.FileFooter;
            lCompareText += "\n";
            lCompareText += "---------------------------------------- " + lDataSplit;
            lCompareText += "\n";

            lCompareTextFromFile = lOutputFile.ReadFile();

            Assert.AreEqual(lCompareText, lCompareTextFromFile);
            
        }
    }
}
