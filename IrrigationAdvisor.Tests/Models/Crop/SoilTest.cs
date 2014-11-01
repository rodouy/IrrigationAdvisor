using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IrrigationAdvisor.Models.Crop;

namespace IrrigationAdvisor.Tests.Models.Crop
{
    [TestClass]
    public class SoilTest
    {
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

            double pmp10 = lSoil.getPermanentWiltingPoint(10);
            double cc10 = lSoil.getFieldCapacity(10);
            double ad10 = lSoil.getAvailableWaterCapacity(10);

            double pmp0 = lSoil.getPermanentWiltingPoint(0);
            double cc0 = lSoil.getFieldCapacity(0);
            double ad0 = lSoil.getAvailableWaterCapacity(0);
            
            //RootDeepth between the border (0) and the HorizonDepth
            Assert.AreEqual(pmp, 16.002069999999989);
            Assert.AreEqual(cc, 34.1726);
            Assert.AreEqual(ad, 18.170530000000014);
            //RootDeepth outside the horizon
            Assert.AreEqual(pmp10, 0);
            Assert.AreEqual(cc10, 0);
            Assert.AreEqual(ad10, 0);
            //RootDeepth = 0
            Assert.AreEqual(pmp0, 16.002069999999989);
            Assert.AreEqual(cc0, 34.1726);
            Assert.AreEqual(ad0, 18.170530000000014);
            
            
        }
    }
}
