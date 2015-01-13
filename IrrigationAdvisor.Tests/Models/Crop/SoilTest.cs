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
            lSoil.Horizons.Add(lHorizonA);
            lSoil.Horizons.Add(lHorizonAB);
            lSoil.Horizons.Add(lHorizonB);
            lHorizonA.getPermanentWiltingPoint();
            lHorizonAB.getAvailableWaterCapacity();
            lHorizonB.getFieldCapacity();
            
            TextFileLogger lTextFileLogger = new TextFileLogger();
            String lFile = "SoilTest";
            String lMethod = "soilTestSantaLucia";
            String lMessage = lSoil.ToString();

            double cc1 = lSoil.getFieldCapacity(5);
            double cc2 = lSoil.getFieldCapacity(20);
            double cc3 = lSoil.getFieldCapacity(45);
            double cc4 = lSoil.getFieldCapacity(57);
            double cc5 = lSoil.getFieldCapacity(65);

            double pmp1 = lSoil.getPermanentWiltingPoint(5);
            double pmp2 = lSoil.getPermanentWiltingPoint(35);
            double pmp3 = lSoil.getPermanentWiltingPoint(45);
            double pmp4 = lSoil.getPermanentWiltingPoint(57);
            double pmp5 = lSoil.getPermanentWiltingPoint(65);

            double ad1 = lSoil.getAvailableWaterCapacity(5);
            double ad2 = lSoil.getAvailableWaterCapacity(20);
            double ad3 = lSoil.getAvailableWaterCapacity(45);
            double ad4 = lSoil.getAvailableWaterCapacity(57);
            double ad5 = lSoil.getAvailableWaterCapacity(65);



            
            lMessage += Environment.NewLine + Environment.NewLine + "Capacidad Campo (%peso)" + Environment.NewLine;
            lMessage += "CC Horizon A \t" + lHorizonA.getFieldCapacity() + Environment.NewLine;
            lMessage += "CC Horizon AB \t" + lHorizonAB.getFieldCapacity() + Environment.NewLine;
            lMessage += "CC Horizon B \t" + lHorizonB.getFieldCapacity() + Environment.NewLine;

            lMessage += Environment.NewLine + Environment.NewLine + "Punto Marchitacion Permanente (%peso)" + Environment.NewLine;
            lMessage += "PMP Horizon A \t" + lHorizonA.getPermanentWiltingPoint() + Environment.NewLine;
            lMessage += "PMP Horizon AB \t" + lHorizonAB.getPermanentWiltingPoint() + Environment.NewLine;
            lMessage += "PMP Horizon B \t" + lHorizonB.getPermanentWiltingPoint() + Environment.NewLine;


            lMessage += Environment.NewLine + Environment.NewLine + "Agua Disponible (%vol)" + Environment.NewLine;
            lMessage += "AD Horizon A \t" + lHorizonA.getAvailableWaterCapacity() + Environment.NewLine;
            lMessage += "AD Horizon AB \t" + lHorizonAB.getAvailableWaterCapacity() + Environment.NewLine;
            lMessage += "AD Horizon B \t" + lHorizonB.getAvailableWaterCapacity() + Environment.NewLine;


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

            Assert.AreEqual(lHorizonA.getAvailableWaterCapacity(), 21.809856000000011);
            Assert.AreEqual(lHorizonAB.getAvailableWaterCapacity(), 17.270500000000009);

            Assert.AreEqual(lHorizonB.getFieldCapacity(), 13.315680000000002);
            Assert.AreEqual(lHorizonB.getPermanentWiltingPoint(), 13.315680000000002);
            Assert.AreEqual(lHorizonB.getAvailableWaterCapacity(), 13.315680000000002);

            Assert.AreEqual(lHorizonB1.getFieldCapacity(), 13.315680000000002);
            Assert.AreEqual(lHorizonB1.getPermanentWiltingPoint(), 13.315680000000002);
            Assert.AreEqual(lHorizonB1.getAvailableWaterCapacity(), 13.315680000000002);

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
            lSoil.Horizons.Add(lHorizon);

            double pmp = lSoil.getPermanentWiltingPoint(5);
            double cc = lSoil.getFieldCapacity(5);
            double ad = lSoil.getAvailableWaterCapacity(5);

            //double pmp10 = testSoil.getPermanentWiltingPoint(10);
            double cc10 = lSoil.getFieldCapacity(10);
            //double ad10 = testSoil.getAvailableWaterCapacity(10);

            double pmp0 = lSoil.getPermanentWiltingPoint(0);
            double cc0 = lSoil.getFieldCapacity(0);
            double ad0 = lSoil.getAvailableWaterCapacity(0);
            
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
