using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.Tests.Models.Data
{
    [TestClass]
    public class InitialTablesTest
    {
        
        [TestMethod]
        public void testGetCropInformationByDateForSoja() 
        {
            List<Pair<Stage, int>> result = InitialTables.GetCropInformationByDateForSoja(new DateTime(2014, 9, 24), null);

        }

        [TestMethod]
        public void testGetCropInformationByDateForMaiz()
        {
            List<Pair<Stage, int>> result = InitialTables.GetCropInformationByDateForMaiz(new DateTime(2014, 9, 24), null);
        }
    }
}
