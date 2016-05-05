using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.Tests.Models.Agriculture
{
    /// <summary>
    /// Descripción resumida de CropCoefficientTest
    /// </summary>
    [TestClass]
    public class CropCoefficientTest
    {
        [TestMethod]
        public void cropCoefficientTestByList()
        {
            int lDay1 = 1;
            int lDay2 = 2;
            int lDay3 = 3;
            double lKC1 = 3.5;
            double lKC2 = 3.7;
            double lKC3 = 4;

            CropCoefficient lCropCoefficient = new CropCoefficient();
            lCropCoefficient.AddKCforDayAfterSowing(lDay1, lKC1);
            lCropCoefficient.AddKCforDayAfterSowing(lDay2, lKC2);
            lCropCoefficient.AddKCforDayAfterSowing(lDay3, lKC3);

            Assert.IsTrue(lCropCoefficient.GetCropCoefficient(1) == lKC1);
            Assert.IsTrue(lCropCoefficient.GetCropCoefficient(2) == lKC2);
            Assert.IsTrue(lCropCoefficient.GetCropCoefficient(3) == lKC3);
            
        }
        [TestMethod]
        public void cropCoefficientTestByTable()
        {
            bool lUsingTable = true;
            int lInitialDays = 5;
            double lInitialKC = 2;
            int lDevelopmentDays = 15;
            double lDevelopmentKC = 13;
            int lMidSeasonDays = 19;
            double lMidSeasonKC = 13;
            int lLateSeasonDays = 25;
            double lLateSeasonKC = 10;

            CropCoefficient lCropCoefficient = new CropCoefficient(0, lUsingTable, 
                lInitialDays, lInitialKC, lDevelopmentDays, lDevelopmentKC, 
                lMidSeasonDays, lMidSeasonKC, lLateSeasonDays, lLateSeasonKC);

            Assert.IsTrue(lCropCoefficient.GetCropCoefficient(1) == lInitialKC);
            Assert.IsTrue(lCropCoefficient.GetCropCoefficient(2) == lInitialKC);
            Assert.IsTrue(lCropCoefficient.GetCropCoefficient(5) == lInitialKC);

            Assert.IsTrue(lCropCoefficient.GetCropCoefficient(6) == 3.1);
            Assert.IsTrue(lCropCoefficient.GetCropCoefficient(10) == 7.5);

            Assert.IsTrue(lCropCoefficient.GetCropCoefficient(15) == lMidSeasonKC);
            Assert.IsTrue(lCropCoefficient.GetCropCoefficient(16) == lMidSeasonKC);
            Assert.IsTrue(lCropCoefficient.GetCropCoefficient(19) == lMidSeasonKC);

            Assert.IsTrue(lCropCoefficient.GetCropCoefficient(20) == 12.5);
            Assert.IsTrue(lCropCoefficient.GetCropCoefficient(24) == 10.5);


            Assert.IsTrue(lCropCoefficient.GetCropCoefficient(25) == lLateSeasonKC);
            Assert.IsTrue(lCropCoefficient.GetCropCoefficient(50) == lLateSeasonKC);

        }
    }
}
