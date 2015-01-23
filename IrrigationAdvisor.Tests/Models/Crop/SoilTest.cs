using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Utilities;

namespace IrrigationAdvisor.Tests.Models.Agriculture
{
    [TestClass]
    public class SoilTest
    {
        [TestMethod]
        public void soilTestSantaLucia() 
        {
            Horizon lHorizonA = new Horizon(1, "A", 0, "A", 14, 19, 53, 28, 4.4, 0, 1.2);
            Horizon lHorizonAB = new Horizon(2, "AB", 1, "AB", 23, 18, 45, 37, 3, 0, 1.3);
            Horizon lHorizonB = new Horizon(3, "B", 2, "B", 20, 19, 37, 44, 2, 0, 1.4);
            Horizon lHorizonB1 = new Horizon(3, "A", 2, "B", 20, 19, 37, 44, 2, 0, 1.4);

            Soil lSoil = new Soil();
            lSoil.Name = "Suelo Pivot 2";
            lSoil.HorizonList.Add(lHorizonA);
            lSoil.HorizonList.Add(lHorizonAB);
            lSoil.HorizonList.Add(lHorizonB);
            lHorizonA.GetPermanentWiltingPoint();
            lHorizonAB.GetAvailableWaterCapacity();
            lHorizonB.GetFieldCapacity();
            
            TextFileLogger lTextFileLogger = new TextFileLogger();
            String lFile = "SoilTest";
            String lMethod = "soilTestSantaLucia";
            String lMessage = lSoil.ToString();

            double cc1 = lSoil.GetFieldCapacity(5);
            double cc2 = lSoil.GetFieldCapacity(20);
            double cc3 = lSoil.GetFieldCapacity(45);
            double cc4 = lSoil.GetFieldCapacity(57);
            double cc5 = lSoil.GetFieldCapacity(65);

            double pmp1 = lSoil.GetPermanentWiltingPoint(5);
            double pmp2 = lSoil.GetPermanentWiltingPoint(35);
            double pmp3 = lSoil.GetPermanentWiltingPoint(45);
            double pmp4 = lSoil.GetPermanentWiltingPoint(57);
            double pmp5 = lSoil.GetPermanentWiltingPoint(65);

            double ad1 = lSoil.GetAvailableWaterCapacity(5);
            double ad2 = lSoil.GetAvailableWaterCapacity(20);
            double ad3 = lSoil.GetAvailableWaterCapacity(45);
            double ad4 = lSoil.GetAvailableWaterCapacity(57);
            double ad5 = lSoil.GetAvailableWaterCapacity(65);



            
            lMessage += Environment.NewLine + Environment.NewLine + "Capacidad Campo (%peso)" + Environment.NewLine;
            lMessage += "CC Horizon A \t" + lHorizonA.GetFieldCapacity() + Environment.NewLine;
            lMessage += "CC Horizon AB \t" + lHorizonAB.GetFieldCapacity() + Environment.NewLine;
            lMessage += "CC Horizon B \t" + lHorizonB.GetFieldCapacity() + Environment.NewLine;

            lMessage += Environment.NewLine + Environment.NewLine + "Punto Marchitacion Permanente (%peso)" + Environment.NewLine;
            lMessage += "PMP Horizon A \t" + lHorizonA.GetPermanentWiltingPoint() + Environment.NewLine;
            lMessage += "PMP Horizon AB \t" + lHorizonAB.GetPermanentWiltingPoint() + Environment.NewLine;
            lMessage += "PMP Horizon B \t" + lHorizonB.GetPermanentWiltingPoint() + Environment.NewLine;


            lMessage += Environment.NewLine + Environment.NewLine + "Agua Disponible (%vol)" + Environment.NewLine;
            lMessage += "AD Horizon A \t" + lHorizonA.GetAvailableWaterCapacity() + Environment.NewLine;
            lMessage += "AD Horizon AB \t" + lHorizonAB.GetAvailableWaterCapacity() + Environment.NewLine;
            lMessage += "AD Horizon B \t" + lHorizonB.GetAvailableWaterCapacity() + Environment.NewLine;


            lMessage += Environment.NewLine + Environment.NewLine + "Capacidad de campo s/rootDepth" + Environment.NewLine;
            lMessage += "getFieldCapacity(Root: 5): " + cc1 + Environment.NewLine;
            lMessage += "getFieldCapacity(Root: 20): " + cc2 + Environment.NewLine;
            lMessage += "getFieldCapacity(Root: 45): " + cc3 + Environment.NewLine;
            lMessage += "getFieldCapacity(Root: 57): " + cc4 + Environment.NewLine;

            lMessage += Environment.NewLine + Environment.NewLine + "Punto Marchitacion Permanente s/rootDepth" + Environment.NewLine;
            lMessage += "getPermanentWiltingPoint(Root: 5): " + pmp1 + Environment.NewLine;
            lMessage += "getPermanentWiltingPoint(Root: 35): " + pmp2 + Environment.NewLine;
            lMessage += "getPermanentWiltingPoint(Root: 45): " + pmp3 + Environment.NewLine;
            lMessage += "getPermanentWiltingPoint(Root: 57): " + pmp4 + Environment.NewLine;

            lMessage += Environment.NewLine + Environment.NewLine + "Agua Disponible s/rootDepth" + Environment.NewLine;
            lMessage += "getAvailableWaterCapacityProration(Root: 5): " + ad1 + Environment.NewLine;
            lMessage += "getAvailableWaterCapacityProration(Root: 20): " + ad2 + Environment.NewLine;
            lMessage += "getAvailableWaterCapacityProration(Root: 45): " + ad3 + Environment.NewLine;
            lMessage += "getAvailableWaterCapacityProration(Root: 57): " + ad4 + Environment.NewLine;

            String lTime = System.DateTime.Now.ToString();
            lTextFileLogger.WriteLogFile(lFile, lMethod, lMessage, lTime);

            Assert.AreEqual(lHorizonA.GetAvailableWaterCapacity(), 21.809856000000011);
            Assert.AreEqual(lHorizonAB.GetAvailableWaterCapacity(), 17.270500000000009);

            Assert.AreEqual(lHorizonB.GetFieldCapacity(), 13.315680000000002);
            Assert.AreEqual(lHorizonB.GetPermanentWiltingPoint(), 13.315680000000002);
            Assert.AreEqual(lHorizonB.GetAvailableWaterCapacity(), 13.315680000000002);

            Assert.AreEqual(lHorizonB1.GetFieldCapacity(), 13.315680000000002);
            Assert.AreEqual(lHorizonB1.GetPermanentWiltingPoint(), 13.315680000000002);
            Assert.AreEqual(lHorizonB1.GetAvailableWaterCapacity(), 13.315680000000002);

            Assert.AreEqual(ad2, 40.861557400000017);
            Assert.AreEqual(ad4, 96.887308400000052);
            
        }
        [TestMethod]
        public void soilTest() 
        {
            double sand = 17.3;
            double limo = 53.9;
            double clay = 28.8;
            double organicMatter = 4.4;
            Horizon lHorizon = new Horizon();
            lHorizon.Sand = sand;
            lHorizon.Limo = limo;
            lHorizon.Clay = clay;
            lHorizon.OrganicMatter = organicMatter;
            lHorizon.HorizonLayer = "A";
            lHorizon.Order = 0;
            lHorizon.HorizonLayerDepth = 5.3;

            Soil lSoil = new Soil();
            lSoil.HorizonList.Add(lHorizon);

            double pmp = lSoil.GetPermanentWiltingPoint(5);
            double cc = lSoil.GetFieldCapacity(5);
            double ad = lSoil.GetAvailableWaterCapacity(5);

            //double pmp10 = testSoil.GetPermanentWiltingPoint(10);
            double cc10 = lSoil.GetFieldCapacity(10);
            //double ad10 = testSoil.GetAvailableWaterCapacity(10);

            double pmp0 = lSoil.GetPermanentWiltingPoint(0);
            double cc0 = lSoil.GetFieldCapacity(0);
            double ad0 = lSoil.GetAvailableWaterCapacity(0);
            
            //RootDeepth between the border (0) and the HorizonDepth
            Assert.AreEqual(pmp, 16.002069999999989);
            Assert.AreEqual(cc, 34.1726);
            Assert.AreEqual(ad, 18.170530000000014);
            //RootDeepth outside the horizon
 //           Assert.AreEqual(pmp10, 0);
            Assert.AreEqual(cc10, 34.1726);
  //          Assert.AreEqual(ad10, 0);
            //RootDeepth = 0
            Assert.AreEqual(pmp0, 16.002069999999989);
            Assert.AreEqual(cc0, 34.1726);
            Assert.AreEqual(ad0, 18.170530000000014);
            
            
        }
    }
}
