using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IrrigationAdvisor.Models.Utilities;
namespace IrrigationAdvisor.Tests.Models.Utilities
{
    [TestClass]
    public class TextFileLoggerTest
    {
        [TestMethod]
        public void WriteLogFileTest()
        {
            String lCompareTextFromFile;
            String lCompareText;
            String lFile = "TextFileLoggerTest";
            String lMethod = "WriteLogFileTest";
            String lMessage = "";
            String lTime = System.DateTime.Now.ToString();

            lMessage = "Datos para grabar.";
            lMessage += "\n" + "Segunda linea con datos.";
            lMessage += "\n" + "Tercera linea con datos.";
            //lMessage += "\n" + "";
            TextFileLogger lTextFileLogger = new TextFileLogger();

            lCompareText = (((lTime + " - ") + lFile + " - ") + lMethod + " - ") + lMessage + "\r\n";
            lCompareText += "\n";
            lCompareText += "---------------------------------------- \n" + "";
            lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);

            lCompareTextFromFile = lTextFileLogger.ReadLogFile();

            Assert.AreEqual(lCompareText, lCompareTextFromFile);
                
        }
    }
}
