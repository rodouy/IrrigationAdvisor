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
            double sojeBaseTemp = 10;
            Specie lSpecie = new Specie(1,"Soja", lRegion, sojeBaseTemp);

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
            lSoil.Location = lLocation;
            
            ///PHENOLOGICAL STAGE
            Stage lStage0 = new Stage(1,"v0","Sin hojas");
            double minDegree = 0;
            double maxDegree = 60;
            double rootDepth = 5;
            PhenologicalStage lPhenologicalState = new PhenologicalStage(1,lSpecie, lStage0, minDegree, maxDegree, rootDepth);

            ///CROP COEFFICIENT (with list)
            CropCoefficient lCropCoefficient = new CropCoefficient(lSpecie, lRegion);
            lCropCoefficient.addDayToList(0,0.40);
            lCropCoefficient.addDayToList(1,0.41);
            lCropCoefficient.addDayToList(2,0.42);
            lCropCoefficient.addDayToList(3,0.43);
            lCropCoefficient.addDayToList(4,0.44);
            lCropCoefficient.addDayToList(5,0.46);
            lCropCoefficient.addDayToList(6,0.47);
            lCropCoefficient.addDayToList(7,0.48);
            lCropCoefficient.addDayToList(9,0.50);
            lCropCoefficient.addDayToList(10,0.51);
            lCropCoefficient.addDayToList(11,0.52);
            lCropCoefficient.addDayToList(12,0.53);
            lCropCoefficient.addDayToList(13,0.54);
            lCropCoefficient.addDayToList(14,0.55);
            lCropCoefficient.addDayToList(15,0.57);
            lCropCoefficient.addDayToList(16,0.58);
            lCropCoefficient.addDayToList(17,0.59);
            lCropCoefficient.addDayToList(18,0.60);
            lCropCoefficient.addDayToList(19,0.61);
            lCropCoefficient.addDayToList(20,0.62);
            lCropCoefficient.addDayToList(21,0.63);
            lCropCoefficient.addDayToList(22,0.64);
            lCropCoefficient.addDayToList(23,0.65);
            lCropCoefficient.addDayToList(24,0.66);
            lCropCoefficient.addDayToList(25,0.68);
            lCropCoefficient.addDayToList(26,0.69);
            lCropCoefficient.addDayToList(27,0.70);
            lCropCoefficient.addDayToList(28,0.71);
            lCropCoefficient.addDayToList(29,0.72);
            lCropCoefficient.addDayToList(30,0.73);
            lCropCoefficient.addDayToList(31,0.74);
            lCropCoefficient.addDayToList(32,0.75);
            lCropCoefficient.addDayToList(33,0.76);
            lCropCoefficient.addDayToList(34,0.77);
            lCropCoefficient.addDayToList(35,0.79);
            lCropCoefficient.addDayToList(36,0.80);
            lCropCoefficient.addDayToList(37,0.81);
            lCropCoefficient.addDayToList(38,0.82);
            lCropCoefficient.addDayToList(39,0.83);
            lCropCoefficient.addDayToList(40,0.84);
            lCropCoefficient.addDayToList(41,0.85);
            lCropCoefficient.addDayToList(42,0.86);
            lCropCoefficient.addDayToList(43,0.87);
            lCropCoefficient.addDayToList(44,0.89);
            lCropCoefficient.addDayToList(45,0.90);
            lCropCoefficient.addDayToList(46,0.91);
            lCropCoefficient.addDayToList(47,0.92);
            lCropCoefficient.addDayToList(48,0.93);
            lCropCoefficient.addDayToList(49,0.94);
            lCropCoefficient.addDayToList(50,0.95);
            lCropCoefficient.addDayToList(51,0.96);
            lCropCoefficient.addDayToList(52,0.97);
            lCropCoefficient.addDayToList(53,0.98);
            lCropCoefficient.addDayToList(54,1);
            lCropCoefficient.addDayToList(55,1.01);
            lCropCoefficient.addDayToList(56,1.02);
            lCropCoefficient.addDayToList(57,1.03);
            lCropCoefficient.addDayToList(58,1.04);
            lCropCoefficient.addDayToList(59,1.05);
            lCropCoefficient.addDayToList(60,1.06);
            lCropCoefficient.addDayToList(61,1.07);
            lCropCoefficient.addDayToList(62,1.08);
            lCropCoefficient.addDayToList(63,1.09);
            lCropCoefficient.addDayToList(64,1.11);
            lCropCoefficient.addDayToList(65,1.12);
            lCropCoefficient.addDayToList(66,1.13);
            lCropCoefficient.addDayToList(67,1.14);
            lCropCoefficient.addDayToList(68,1.15);
            lCropCoefficient.addDayToList(69,1.14);
            lCropCoefficient.addDayToList(70,1.14);


            ///CROP
            DateTime lSowingDate = new DateTime (2014,11,01);
            double lSojaMaxEvaporTransptoIrrigate = 333;
            double cropDensity = 70;
            Crop.Crop crop = new Crop.Crop(1,"Maiz en Minas", lSpecie,lLocation, lCropCoefficient, cropDensity,
                lPhenologicalState, lSowingDate, DateTime.Now, lSoil, lSojaMaxEvaporTransptoIrrigate);
            
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

            ///LIST OF CropIrrigationWeather
            irrirgSys.addCropIrrigWeatherToList(cropIrrigWeather);

            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2012, 11, 1), 99, 0, 30, 10, 6.4);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2012, 11, 2), 99, 0, 13, 4, 6.4);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2012, 11, 3), 99, 0, 11.7, 1, 6.4);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2012, 11, 4), 99, 0, 14.4, 5, 6.4);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2012, 11, 5), 99, 0, 20, 4, 6.4);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2012, 11, 6), 99, 0, 22.8, 1, 6.4);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2012, 11, 7), 99, 0, 10.6, 5.6, 6.4);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2012, 11, 8), 99, 0, 15.6, 2.8, 6.4);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2012, 11, 9), 99, 0, 18, 0, 6.4);
            irrirgSys.addWeatherDataToList(weatherStation, new DateTime(2012, 11, 10), 99, 0, 6, 0, 6.4);

            irrirgSys.addRainDataToList(cropIrrigWeather, new DateTime(2012, 11, 4), 3);
            irrirgSys.addRainDataToList(cropIrrigWeather, new DateTime(2012, 11, 9), 8);


        }
    }
}

/*            lCropCoefficient.addDayToList(1, 0.5);
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
 * 
 * 70	1,14
71	1,13
72	1,12
73	1,11
74	1,11
75	1,10
76	1,09
77	1,09
78	1,08
79	1,07
80	1,06
81	1,06
82	1,05
83	1,04
84	1,04
85	1,03
86	1,02
87	1,01
88	1,01
89	1,00
90	0,99
91	0,99
92	0,98
93	0,97
94	0,96
95	0,96
96	0,95
97	0,94
98	0,94
99	0,93
100	0,92
101	0,91
102	0,91
103	0,90
104	0,89
105	0,89
106	0,88
107	0,87
108	0,86
109	0,86
110	0,85
111	0,84
112	0,84
113	0,83
114	0,82
115	0,81
116	0,81
117	0,80
118	0,79
119	0,79
120	0,78
121	0,77
122	0,76
123	0,76
124	0,75
125	0,74
126	0,74
127	0,73
128	0,72
129	0,71
130	0,71
131	0,70
132	0,69
133	0,69
134	0,68
135	0,67
136	0,66
137	0,66
138	0,65
139	0,64
140	0,64
141	0,63
142	0,62
143	0,61
144	0,61
145	0,60
146	0,59
147	0,59
148	0,58
149	0,57
150	0,56
151	0,56
152	0,55
153	0,54
154	0,54
155	0,53
156	0,52
157	0,51
158	0,51
159	0,50
160	0,50

            */

