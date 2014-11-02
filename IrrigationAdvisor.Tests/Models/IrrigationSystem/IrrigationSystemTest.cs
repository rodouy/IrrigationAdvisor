using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IrrigationAdvisor.Models.IrrigationSystem;
using IrrigationAdvisor.Models.Crop;
using IrrigationAdvisor.Models.Location;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Irrigation;

namespace IrrigationAdvisor.Models.IrrigationSystem
{
    [TestClass]
    public class IrrigationSystemTest
    {
        [TestMethod]
        public void createACropIrrigationWeather()
        {
            Position lPosition = new Position(34, 55);
            Country lCountry = new Country("Uruguay", null );
            Region lRegion = new Region("Templada", null);
            City lCity = new City("Minas",null );
            Location.Location lLocation = new Location.Location(lPosition,lCountry, lRegion, lCity);
            
            double cornBaseTemp = 10;
            Specie lSpecie = new Specie("Maiz", lRegion, cornBaseTemp);
            Soil lSoil = new Soil();
            Stage lStage = new Stage("v0","Sin hojas");

            PhenologicalStage lPhenologicalState = new PhenologicalStage(lSpecie,lStage,0,50,8);

            CropCoefficient lCropCoefficient = new CropCoefficient(lSpecie, lRegion);
            DateTime lSowingDate = new DateTime (2014,11,15);
            double lCornMaxETtoIrr = 333;
            double cropDensity = 70;
            Crop.Crop crop = new Crop.Crop("Maiz en Minas", lSpecie, lCropCoefficient, cropDensity, 
                lPhenologicalState, lSowingDate, DateTime.Now , lSoil, lCornMaxETtoIrr);
            
            
            Bomb lBomb = new Bomb("Bomba1", 1234, DateTime.Now, DateTime.Now, lLocation);
            Irrigation.IrrigationUnit irrigationUnit = new Irrigation.IrrigationUnit(1, "Unidad de Riego de prueba", "Pivot", 
                999, new List<Utilities.Pair<DateTime, double>>(), 300, new List<Crop.Crop>(), lBomb, lLocation);
            
            WeatherStation.WeatherStation weatherStation = new WeatherStation.WeatherStation(1,"WeatherStation1","Model?",DateTime.Now,DateTime.Now,DateTime.Now, 1, lLocation,true);


            CropIrrigationWeather cropIrrigWeather = new CropIrrigationWeather(irrigationUnit, crop,weatherStation,null);

            IrrigationSystem irrirgSys = new IrrigationSystem();

            irrirgSys.CropIrrigationWeatherList.Add(cropIrrigWeather);
        }
    }
}
