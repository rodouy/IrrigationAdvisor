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
            ///LOCATION
            Position lPosition = new Position(34, 55);
            Country lCountry = new Country("Uruguay", null );
            Region lRegion = new Region("Templada", null);
            City lCity = new City("Minas",null );
            Location.Location lLocation = new Location.Location(lPosition,lCountry, lRegion, lCity);
            
            ///SPECIE
            double cornBaseTemp = 10;
            Specie lSpecie = new Specie("Maiz", lRegion, cornBaseTemp);

            ///SOIL
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
            
            ///PHENOLOGICAL STAGE
            Stage lStage = new Stage("v0","Sin hojas");
            double minDegree = 0;
            double maxDegree = 60;
            double rootDepth = 5;
            PhenologicalStage lPhenologicalState = new PhenologicalStage(lSpecie, lStage, minDegree, maxDegree, rootDepth);

            ///CROP COEFFICIENT (with list)
            CropCoefficient lCropCoefficient = new CropCoefficient(lSpecie, lRegion);
            lCropCoefficient.addDayToList(1, 0.5);
            lCropCoefficient.addDayToList(2, 0.5);
            lCropCoefficient.addDayToList(3, 0.35);
            lCropCoefficient.addDayToList(4, 0.35);
            lCropCoefficient.addDayToList(5, 0.38);
            lCropCoefficient.addDayToList(6, 0.4);
            lCropCoefficient.addDayToList(7, 0.45);
            lCropCoefficient.addDayToList(8, 0.5);
            lCropCoefficient.addDayToList(9, 0.67);
            lCropCoefficient.addDayToList(10, 0.8);
            lCropCoefficient.addDayToList(11, 0.85);
            lCropCoefficient.addDayToList(12, 0.9);
            lCropCoefficient.addDayToList(13, 0.95);
            lCropCoefficient.addDayToList(14, 1.05);
            lCropCoefficient.addDayToList(15, 1.1);
            lCropCoefficient.addDayToList(16, 1.1);
            lCropCoefficient.addDayToList(17, 1.1);
            lCropCoefficient.addDayToList(18, 1.1);
            lCropCoefficient.addDayToList(19, 1.1);
            lCropCoefficient.addDayToList(20, 1);
            lCropCoefficient.addDayToList(21, 0.9);
            lCropCoefficient.addDayToList(22, 0.8);
            lCropCoefficient.addDayToList(23, 0.7);

            ///CROP
            DateTime lSowingDate = new DateTime (2014,11,15);
            double lCornMaxETtoIrr = 333;
            double cropDensity = 70;
            Crop.Crop crop = new Crop.Crop("Maiz en Minas", lSpecie, lCropCoefficient, cropDensity, 
                lPhenologicalState, lSowingDate, DateTime.Now , lSoil, lCornMaxETtoIrr);
            
            ///IRRIGATION UNIT
            Bomb lBomb = new Bomb("Bomba1", 1234, DateTime.Now, DateTime.Now, lLocation);
            Irrigation.IrrigationUnit irrigationUnit = new Irrigation.IrrigationUnit(1, "Unidad de Riego de prueba", "Pivot", 
                999, new List<Utilities.Pair<DateTime, double>>(), 300, new List<Crop.Crop>(), lBomb, lLocation);
            
            ///WEATHER STATIOM
            WeatherStation.WeatherStation weatherStation = new WeatherStation.WeatherStation(1,"WeatherStation1","Model?",DateTime.Now,DateTime.Now,DateTime.Now, 1, lLocation,true);

            ///CROPIRRIGATIONWEATHER
            CropIrrigationWeather cropIrrigWeather = new CropIrrigationWeather(irrigationUnit, crop,weatherStation,null);

            ///IRRIGATION SYSTEM
            IrrigationSystem irrirgSys = new IrrigationSystem();

            irrirgSys.CropIrrigationWeatherList.Add(cropIrrigWeather);


        }
    }
}
