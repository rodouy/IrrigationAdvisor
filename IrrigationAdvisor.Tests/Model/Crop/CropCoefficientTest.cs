using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IrrigationAdvisor.Models.Crop;

namespace IrrigationAdvisor.Tests.Model.Crop
{
    /// <summary>
    /// Descripción resumida de CropCoefficientTest
    /// </summary>
    [TestClass]
    public class CropCoefficientTest
    {
        [TestMethod]
        public void cropCoefficientTest()
        {
            int lDay1 = 1;
            int lDay2 = 2;
            int lDay3 = 3;
            double lKC1 = 3.5;
            double lKC2 = 3.7;
            double lKC3 = 4;

            CropCoefficient lCropCoefficient = new CropCoefficient();
            lCropCoefficient.addDayToList(lDay1, lKC1);
            lCropCoefficient.addDayToList(lDay2, lKC2);
            lCropCoefficient.addDayToList(lDay3, lKC3);

            Assert.IsTrue(lCropCoefficient.getKC(2)== lKC2);

        }
    }
}
