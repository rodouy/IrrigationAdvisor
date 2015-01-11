using IrrigationAdvisor.Models.Crop;
using IrrigationAdvisor.Models.IrrigationSystem;
using IrrigationAdvisor.Models.Location;
using IrrigationAdvisor.Models.Water;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace IrrigationAdvisor.Models.Data
{

    /// <summary>
    /// Create: 2015-01-05
    /// Author: rodouy
    /// Description: 
    ///     These class will contain all the data that initialize the system.
    ///     
    /// References:
    ///     - Specie
    ///     - Region
    ///     - IrrigationSystem
    ///     - CropCoefficient
    ///     - EffectiveRain
    ///     - PhenologicalStage
    ///     
    /// Dependencies:
    ///     - IrrigationAdvisor
    ///     - IrrigationCalculous
    ///     - Horizon
    ///     - CropIrrigationWeatherRecords
    ///     - IrrigationSystem
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     
    /// 
    /// Methods:
    ///     - CreateMaizCropCoefficientWithList(Specie pSpecie, Region pRegion) 
    ///     - CreateSojaCropCoefficientWithList(Specie pSpecie, Region pRegion)
    ///     - AddEffectiveRainListToSystem(Region lRegion)
    ///     - CreatePhenologicalStageList(IrrigationSystem.IrrigationSystem pIrrigationSystem,
    ///                    Specie pSpecieMaiz,  Specie pSpecieSoja)
    /// 
    /// </summary>
    public static class InitialTables
    {

        #region Constants

        #region IrrigationCalculous
        public const double PERCENTAGE_OF_AVAILABE_WATER_TO_IRRIGATE = 60;
        public const int DAYS_FOR_PREDICTION = 7;
        #endregion

        #region Horizon
        public const double HORIZON_A_FIELD_CAPACITY_GENERAL_ADJ_COEF = 21.977;
        public const double HORIZON_A_FIELD_CAPACITY_SAND_ADJ_COEF = 0.168;
        public const double HORIZON_A_FIELD_CAPACITY_CLAY_ADJ_COEF = 0.127;
        public const double HORIZON_A_FIELD_CAPACITY_ORGANIC_MATTER_ADJ_COEF = 2.601;

        public const double HORIZON_A_PERM_WILTING_POINT_GENERAL_ADJ_COEF = 58.1313;
        public const double HORIZON_A_PERM_WILTING_POINT_SAND_ADJ_COEF = 0.5683;
        public const double HORIZON_A_PERM_WILTING_POINT_LIMO_ADJ_COEF = 0.6414;
        public const double HORIZON_A_PERM_WILTING_POINT_CLAY_ADJ_COEF = 0.9755;
        public const double HORIZON_A_PERM_WILTING_POINT_ORGANIC_MATTER_ADJ_COEF = 0.3718;

        public const double HORIZON_B_FIELD_CAPACITY_GENERAL_ADJ_COEF = 18.448;
        public const double HORIZON_B_FIELD_CAPACITY_SAND_ADJ_COEF = 0.125;
        public const double HORIZON_B_FIELD_CAPACITY_CLAY_ADJ_COEF = 0.295;
        public const double HORIZON_B_FIELD_CAPACITY_ORGANIC_MATTER_ADJ_COEF = 1.923;

        public const double HORIZON_B_PERM_WILTING_POINT_GENERAL_ADJ_COEF = 5;
        public const double HORIZON_B_PERM_WILTING_POINT_ORGANIC_MATTER_ADJ_COEF = 0.74;
        #endregion

        #region Weather
        public const double INITIAL_ROOT_DEPTH = 5;
        public const double CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED = 10;
        public const double DAYS_HIDRIC_BALANCE_UNCHANGABLE_AFTER_BIG_WATER_INPUT = 2;
        public const double DAYS_HIDRIC_BALANCE_UNCHANGABLE_AFTER_SOWING = 5;

        #endregion

        #endregion

        
        #region Private Helpers
        #endregion

        #region Static Methods

        #region CropCoefficient

        /// <summary>
        /// TODO explain CreateMaizCropCoefficientWithList
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <param name="pRegion"></param>
        /// <returns></returns>
        public static CropCoefficient CreateMaizCropCoefficientWithList(Specie pSpecie, Region pRegion)
        {
            //KC Para maiz sacado de la carpeta Calculos
            CropCoefficient lCropCoefficient = new CropCoefficient(pSpecie, pRegion);
            lCropCoefficient.addKCforDayAfterSowing(0, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(1, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(2, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(3, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(4, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(5, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(6, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(7, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(8, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(9, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(10, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(11, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(12, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(13, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(14, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(15, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(16, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(17, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(18, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(19, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(20, 0.37);
            lCropCoefficient.addKCforDayAfterSowing(21, 0.38);
            lCropCoefficient.addKCforDayAfterSowing(22, 0.40);
            lCropCoefficient.addKCforDayAfterSowing(23, 0.42);
            lCropCoefficient.addKCforDayAfterSowing(24, 0.43);
            lCropCoefficient.addKCforDayAfterSowing(25, 0.45);
            lCropCoefficient.addKCforDayAfterSowing(26, 0.47);
            lCropCoefficient.addKCforDayAfterSowing(27, 0.48);
            lCropCoefficient.addKCforDayAfterSowing(28, 0.50);
            lCropCoefficient.addKCforDayAfterSowing(29, 0.52);
            lCropCoefficient.addKCforDayAfterSowing(30, 0.53);
            lCropCoefficient.addKCforDayAfterSowing(31, 0.55);
            lCropCoefficient.addKCforDayAfterSowing(32, 0.57);
            lCropCoefficient.addKCforDayAfterSowing(33, 0.58);
            lCropCoefficient.addKCforDayAfterSowing(34, 0.60);
            lCropCoefficient.addKCforDayAfterSowing(35, 0.62);
            lCropCoefficient.addKCforDayAfterSowing(36, 0.63);
            lCropCoefficient.addKCforDayAfterSowing(37, 0.65);
            lCropCoefficient.addKCforDayAfterSowing(38, 0.67);
            lCropCoefficient.addKCforDayAfterSowing(39, 0.68);
            lCropCoefficient.addKCforDayAfterSowing(40, 0.70);
            lCropCoefficient.addKCforDayAfterSowing(41, 0.72);
            lCropCoefficient.addKCforDayAfterSowing(42, 0.73);
            lCropCoefficient.addKCforDayAfterSowing(43, 0.75);
            lCropCoefficient.addKCforDayAfterSowing(44, 0.77);
            lCropCoefficient.addKCforDayAfterSowing(45, 0.78);
            lCropCoefficient.addKCforDayAfterSowing(46, 0.80);
            lCropCoefficient.addKCforDayAfterSowing(47, 0.82);
            lCropCoefficient.addKCforDayAfterSowing(48, 0.83);
            lCropCoefficient.addKCforDayAfterSowing(49, 0.85);
            lCropCoefficient.addKCforDayAfterSowing(50, 0.87);
            lCropCoefficient.addKCforDayAfterSowing(51, 0.88);
            lCropCoefficient.addKCforDayAfterSowing(52, 0.90);
            lCropCoefficient.addKCforDayAfterSowing(53, 0.92);
            lCropCoefficient.addKCforDayAfterSowing(54, 0.93);
            lCropCoefficient.addKCforDayAfterSowing(55, 0.95);
            lCropCoefficient.addKCforDayAfterSowing(56, 0.97);
            lCropCoefficient.addKCforDayAfterSowing(57, 0.98);
            lCropCoefficient.addKCforDayAfterSowing(58, 1);
            lCropCoefficient.addKCforDayAfterSowing(59, 1.02);
            lCropCoefficient.addKCforDayAfterSowing(60, 1.03);
            lCropCoefficient.addKCforDayAfterSowing(61, 1.05);
            lCropCoefficient.addKCforDayAfterSowing(62, 1.07);
            lCropCoefficient.addKCforDayAfterSowing(63, 1.08);
            lCropCoefficient.addKCforDayAfterSowing(64, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(65, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(66, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(67, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(68, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(69, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(70, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(71, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(72, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(73, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(74, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(75, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(76, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(77, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(78, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(79, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(80, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(81, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(82, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(83, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(84, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(85, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(86, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(87, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(88, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(89, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(90, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(91, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(92, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(93, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(94, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(95, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(96, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(97, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(98, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(99, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(100, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(101, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(102, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(103, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(104, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(105, 1.10);
            lCropCoefficient.addKCforDayAfterSowing(106, 1.08);
            lCropCoefficient.addKCforDayAfterSowing(107, 1.07);
            lCropCoefficient.addKCforDayAfterSowing(108, 1.05);
            lCropCoefficient.addKCforDayAfterSowing(109, 1.03);
            lCropCoefficient.addKCforDayAfterSowing(110, 1.01);
            lCropCoefficient.addKCforDayAfterSowing(111, 1.00);
            lCropCoefficient.addKCforDayAfterSowing(112, 0.98);
            lCropCoefficient.addKCforDayAfterSowing(113, 0.96);
            lCropCoefficient.addKCforDayAfterSowing(114, 0.94);
            lCropCoefficient.addKCforDayAfterSowing(115, 0.93);
            lCropCoefficient.addKCforDayAfterSowing(116, 0.91);
            lCropCoefficient.addKCforDayAfterSowing(117, 0.89);
            lCropCoefficient.addKCforDayAfterSowing(118, 0.87);
            lCropCoefficient.addKCforDayAfterSowing(119, 0.86);
            lCropCoefficient.addKCforDayAfterSowing(120, 0.84);
            lCropCoefficient.addKCforDayAfterSowing(121, 0.82);
            lCropCoefficient.addKCforDayAfterSowing(122, 0.80);
            lCropCoefficient.addKCforDayAfterSowing(123, 0.79);
            lCropCoefficient.addKCforDayAfterSowing(124, 0.77);
            lCropCoefficient.addKCforDayAfterSowing(125, 0.75);
            lCropCoefficient.addKCforDayAfterSowing(126, 0.73);
            lCropCoefficient.addKCforDayAfterSowing(127, 0.72);
            lCropCoefficient.addKCforDayAfterSowing(128, 0.70);
            lCropCoefficient.addKCforDayAfterSowing(129, 0.68);
            lCropCoefficient.addKCforDayAfterSowing(130, 0.66);
            lCropCoefficient.addKCforDayAfterSowing(131, 0.65);
            lCropCoefficient.addKCforDayAfterSowing(132, 0.63);
            lCropCoefficient.addKCforDayAfterSowing(133, 0.61);
            lCropCoefficient.addKCforDayAfterSowing(134, 0.59);
            lCropCoefficient.addKCforDayAfterSowing(135, 0.58);
            lCropCoefficient.addKCforDayAfterSowing(136, 0.56);
            lCropCoefficient.addKCforDayAfterSowing(137, 0.54);
            lCropCoefficient.addKCforDayAfterSowing(138, 0.52);
            lCropCoefficient.addKCforDayAfterSowing(139, 0.51);
            lCropCoefficient.addKCforDayAfterSowing(140, 0.49);
            lCropCoefficient.addKCforDayAfterSowing(141, 0.47);
            lCropCoefficient.addKCforDayAfterSowing(142, 0.45);
            lCropCoefficient.addKCforDayAfterSowing(143, 0.44);
            lCropCoefficient.addKCforDayAfterSowing(144, 0.42);
            lCropCoefficient.addKCforDayAfterSowing(145, 0.40);


            return lCropCoefficient;

        }

        /// <summary>
        /// TODO Explain CreateSojaCropCoefficientWithList(Specie pSpecie, Region pRegion)
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <param name="pRegion"></param>
        /// <returns></returns>
        public static CropCoefficient CreateSojaCropCoefficientWithList(Specie pSpecie, Region pRegion)
        {
            //KC Para soja sacado de la carpeta Calculos
            CropCoefficient lCropCoefficient = new CropCoefficient(pSpecie, pRegion);
            lCropCoefficient.addKCforDayAfterSowing(0, 0.30);
            lCropCoefficient.addKCforDayAfterSowing(1, 0.31);
            lCropCoefficient.addKCforDayAfterSowing(2, 0.31);
            lCropCoefficient.addKCforDayAfterSowing(3, 0.32);
            lCropCoefficient.addKCforDayAfterSowing(4, 0.33);
            lCropCoefficient.addKCforDayAfterSowing(5, 0.34);
            lCropCoefficient.addKCforDayAfterSowing(6, 0.34);
            lCropCoefficient.addKCforDayAfterSowing(7, 0.35);
            lCropCoefficient.addKCforDayAfterSowing(8, 0.36);
            lCropCoefficient.addKCforDayAfterSowing(9, 0.37);
            lCropCoefficient.addKCforDayAfterSowing(10, 0.37);
            lCropCoefficient.addKCforDayAfterSowing(11, 0.38);
            lCropCoefficient.addKCforDayAfterSowing(12, 0.39);
            lCropCoefficient.addKCforDayAfterSowing(13, 0.40);
            lCropCoefficient.addKCforDayAfterSowing(14, 0.40);
            lCropCoefficient.addKCforDayAfterSowing(15, 0.41);
            lCropCoefficient.addKCforDayAfterSowing(16, 0.42);
            lCropCoefficient.addKCforDayAfterSowing(17, 0.43);
            lCropCoefficient.addKCforDayAfterSowing(18, 0.43);
            lCropCoefficient.addKCforDayAfterSowing(19, 0.44);
            lCropCoefficient.addKCforDayAfterSowing(20, 0.45);
            lCropCoefficient.addKCforDayAfterSowing(21, 0.45);
            lCropCoefficient.addKCforDayAfterSowing(22, 0.46);
            lCropCoefficient.addKCforDayAfterSowing(23, 0.47);
            lCropCoefficient.addKCforDayAfterSowing(24, 0.48);
            lCropCoefficient.addKCforDayAfterSowing(25, 0.48);
            lCropCoefficient.addKCforDayAfterSowing(26, 0.50);
            lCropCoefficient.addKCforDayAfterSowing(27, 0.51);
            lCropCoefficient.addKCforDayAfterSowing(28, 0.51);
            lCropCoefficient.addKCforDayAfterSowing(29, 0.52);
            lCropCoefficient.addKCforDayAfterSowing(30, 0.52);
            lCropCoefficient.addKCforDayAfterSowing(31, 0.53);
            lCropCoefficient.addKCforDayAfterSowing(32, 0.54);
            lCropCoefficient.addKCforDayAfterSowing(33, 0.54);
            lCropCoefficient.addKCforDayAfterSowing(34, 0.55);
            lCropCoefficient.addKCforDayAfterSowing(35, 0.56);
            lCropCoefficient.addKCforDayAfterSowing(36, 0.57);
            lCropCoefficient.addKCforDayAfterSowing(37, 0.57);
            lCropCoefficient.addKCforDayAfterSowing(38, 0.58);
            lCropCoefficient.addKCforDayAfterSowing(39, 0.59);
            lCropCoefficient.addKCforDayAfterSowing(40, 0.59);
            lCropCoefficient.addKCforDayAfterSowing(41, 0.60);
            lCropCoefficient.addKCforDayAfterSowing(42, 0.61);
            lCropCoefficient.addKCforDayAfterSowing(43, 0.62);
            lCropCoefficient.addKCforDayAfterSowing(44, 0.62);
            lCropCoefficient.addKCforDayAfterSowing(45, 0.63);
            lCropCoefficient.addKCforDayAfterSowing(46, 0.64);
            lCropCoefficient.addKCforDayAfterSowing(47, 0.65);
            lCropCoefficient.addKCforDayAfterSowing(48, 0.65);
            lCropCoefficient.addKCforDayAfterSowing(49, 0.66);
            lCropCoefficient.addKCforDayAfterSowing(50, 0.67);
            lCropCoefficient.addKCforDayAfterSowing(51, 0.68);
            lCropCoefficient.addKCforDayAfterSowing(52, 0.68);
            lCropCoefficient.addKCforDayAfterSowing(53, 0.69);
            lCropCoefficient.addKCforDayAfterSowing(54, 0.70);
            lCropCoefficient.addKCforDayAfterSowing(55, 0.71);
            lCropCoefficient.addKCforDayAfterSowing(56, 0.71);
            lCropCoefficient.addKCforDayAfterSowing(57, 0.72);
            lCropCoefficient.addKCforDayAfterSowing(58, 0.73);
            lCropCoefficient.addKCforDayAfterSowing(59, 0.73);
            lCropCoefficient.addKCforDayAfterSowing(60, 0.74);
            lCropCoefficient.addKCforDayAfterSowing(61, 0.75);
            lCropCoefficient.addKCforDayAfterSowing(62, 0.76);
            lCropCoefficient.addKCforDayAfterSowing(63, 0.76);
            lCropCoefficient.addKCforDayAfterSowing(64, 0.77);
            lCropCoefficient.addKCforDayAfterSowing(65, 0.78);
            lCropCoefficient.addKCforDayAfterSowing(66, 0.79);
            lCropCoefficient.addKCforDayAfterSowing(67, 0.79);
            lCropCoefficient.addKCforDayAfterSowing(68, 0.80);
            lCropCoefficient.addKCforDayAfterSowing(69, 0.81);
            lCropCoefficient.addKCforDayAfterSowing(70, 0.82);
            lCropCoefficient.addKCforDayAfterSowing(71, 0.82);
            lCropCoefficient.addKCforDayAfterSowing(72, 0.83);
            lCropCoefficient.addKCforDayAfterSowing(73, 0.84);
            lCropCoefficient.addKCforDayAfterSowing(74, 0.85);
            lCropCoefficient.addKCforDayAfterSowing(75, 0.85);
            lCropCoefficient.addKCforDayAfterSowing(76, 0.86);
            lCropCoefficient.addKCforDayAfterSowing(77, 0.87);
            lCropCoefficient.addKCforDayAfterSowing(78, 0.87);
            lCropCoefficient.addKCforDayAfterSowing(79, 0.88);
            lCropCoefficient.addKCforDayAfterSowing(80, 0.89);
            lCropCoefficient.addKCforDayAfterSowing(81, 0.90);
            lCropCoefficient.addKCforDayAfterSowing(82, 0.90);
            lCropCoefficient.addKCforDayAfterSowing(83, 0.91);
            lCropCoefficient.addKCforDayAfterSowing(84, 0.92);
            lCropCoefficient.addKCforDayAfterSowing(85, 0.93);
            lCropCoefficient.addKCforDayAfterSowing(86, 0.93);
            lCropCoefficient.addKCforDayAfterSowing(87, 0.94);
            lCropCoefficient.addKCforDayAfterSowing(88, 0.95);
            lCropCoefficient.addKCforDayAfterSowing(89, 0.96);
            lCropCoefficient.addKCforDayAfterSowing(90, 0.96);
            lCropCoefficient.addKCforDayAfterSowing(91, 0.97);
            lCropCoefficient.addKCforDayAfterSowing(92, 0.98);
            lCropCoefficient.addKCforDayAfterSowing(93, 0.99);
            lCropCoefficient.addKCforDayAfterSowing(94, 0.99);
            lCropCoefficient.addKCforDayAfterSowing(95, 1.00);
            lCropCoefficient.addKCforDayAfterSowing(96, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(97, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(98, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(99, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(100, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(101, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(102, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(103, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(104, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(105, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(106, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(107, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(108, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(109, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(110, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(111, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(112, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(113, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(114, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(115, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(112, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(113, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(114, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(115, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(116, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(117, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(118, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(119, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(120, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(121, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(122, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(123, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(124, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(125, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(126, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(127, 1.15);
            lCropCoefficient.addKCforDayAfterSowing(128, 1.13);
            lCropCoefficient.addKCforDayAfterSowing(129, 1.11);
            lCropCoefficient.addKCforDayAfterSowing(130, 1.09);
            lCropCoefficient.addKCforDayAfterSowing(131, 1.07);
            lCropCoefficient.addKCforDayAfterSowing(132, 1.05);
            lCropCoefficient.addKCforDayAfterSowing(133, 1.03);
            lCropCoefficient.addKCforDayAfterSowing(134, 1.01);
            lCropCoefficient.addKCforDayAfterSowing(135, 0.99);
            lCropCoefficient.addKCforDayAfterSowing(136, 0.97);
            lCropCoefficient.addKCforDayAfterSowing(137, 0.95);
            lCropCoefficient.addKCforDayAfterSowing(138, 0.93);
            lCropCoefficient.addKCforDayAfterSowing(139, 0.91);
            lCropCoefficient.addKCforDayAfterSowing(140, 0.89);
            lCropCoefficient.addKCforDayAfterSowing(141, 0.87);
            lCropCoefficient.addKCforDayAfterSowing(142, 0.85);
            lCropCoefficient.addKCforDayAfterSowing(143, 0.83);
            lCropCoefficient.addKCforDayAfterSowing(144, 0.80);
            lCropCoefficient.addKCforDayAfterSowing(145, 0.78);

            return lCropCoefficient;

        }

        #endregion

        #region EffectiveRains

        /// <summary>
        /// TODO Explain AddEffectiveRainListToSystem
        /// </summary>
        /// <param name="lRegion"></param>
        /// <returns></returns>
        public static List<EffectiveRain> AddEffectiveRainListToSystem(Region lRegion)
        {
            List<EffectiveRain> lEffectiveRainList = new List<EffectiveRain>();
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 10, 0, 10, 90));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 10, 11, 20, 80));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 10, 21, 30, 80));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 10, 31, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 10, 41, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 10, 51, 60, 70));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 10, 61, 70, 65));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 10, 71, 80, 60));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 10, 81, 90, 60));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 10, 91, 100, 55));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 10, 100, 1000, 50));

            lEffectiveRainList.Add(new EffectiveRain(lRegion, 11, 0, 10, 90));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 11, 11, 20, 80));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 11, 21, 30, 80));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 11, 31, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 11, 41, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 11, 51, 60, 70));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 11, 61, 70, 65));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 11, 71, 80, 60));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 11, 81, 90, 60));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 11, 91, 100, 55));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 11, 100, 1000, 50));

            lEffectiveRainList.Add(new EffectiveRain(lRegion, 12, 0, 10, 90));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 12, 11, 20, 80));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 12, 21, 30, 85));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 12, 31, 40, 80));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 12, 41, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 12, 51, 60, 75));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 12, 61, 70, 70));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 12, 71, 80, 70));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 12, 81, 90, 70));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 12, 91, 100, 70));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 12, 100, 1000, 60));

            lEffectiveRainList.Add(new EffectiveRain(lRegion, 1, 0, 10, 90));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 1, 11, 20, 80));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 1, 21, 30, 85));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 1, 31, 40, 80));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 1, 41, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 1, 51, 60, 75));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 1, 61, 70, 70));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 1, 71, 80, 70));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 1, 81, 90, 70));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 1, 91, 100, 70));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 1, 100, 1000, 60));

            lEffectiveRainList.Add(new EffectiveRain(lRegion, 2, 0, 10, 90));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 2, 11, 20, 80));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 2, 21, 30, 85));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 2, 31, 40, 80));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 2, 41, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 2, 51, 60, 75));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 2, 61, 70, 70));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 2, 71, 80, 70));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 2, 81, 90, 70));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 2, 91, 100, 70));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 2, 100, 1000, 60));

            lEffectiveRainList.Add(new EffectiveRain(lRegion, 3, 0, 10, 90));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 3, 11, 20, 80));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 3, 21, 30, 75));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 3, 31, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 3, 41, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 3, 51, 60, 70));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 3, 61, 70, 65));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 3, 71, 80, 60));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 3, 81, 90, 60));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 3, 91, 100, 55));
            lEffectiveRainList.Add(new EffectiveRain(lRegion, 3, 100, 1000, 50));


            return lEffectiveRainList;
            

        }
        
        #endregion

        #region PhenologicalStage

        /// <summary>
        /// TODO Explain CreatePhenologicalStageList
        /// </summary>
        /// <param name="pIrrigationSystem"></param>
        /// <param name="pSpecieMaiz"></param>
        /// <param name="pSpecieSoja"></param>
        /// <returns></returns>
        public static List<PhenologicalStage> CreatePhenologicalStageList(IrrigationSystem.IrrigationSystem pIrrigationSystem,
                        Specie pSpecieMaiz,  Specie pSpecieSoja)
        {
            List<PhenologicalStage> lPhenolStageList = new List<PhenologicalStage>();
            
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(0, pSpecieMaiz, new Stage(1, "v0", "Siembra"), 0, 59, 7));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(1, pSpecieMaiz, new Stage(1, "ve", "Emergencia"), 60, 114, 7));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(2, pSpecieMaiz, new Stage(1, "v1", "1 nudo"), 115, 134, 7));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(3, pSpecieMaiz, new Stage(1, "v2", "2 nudo"), 135, 179, 10));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(4, pSpecieMaiz, new Stage(1, "v3", "3 nudo"), 180, 229, 15));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(5, pSpecieMaiz, new Stage(1, "v4", "4 nudo"), 230, 289, 20));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(6, pSpecieMaiz, new Stage(1, "v5", "5 nudo"), 290, 339, 20));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(7, pSpecieMaiz, new Stage(1, "v6", "6 nudo"), 340, 404, 25));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(8, pSpecieMaiz, new Stage(1, "v7", "7 nudo"), 405, 459, 25));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(9, pSpecieMaiz, new Stage(1, "v8", "8 nudo"), 460, 519, 30));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(10, pSpecieMaiz, new Stage(1, "v9", "9 nudo"), 520, 589, 32));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(11, pSpecieMaiz, new Stage(1, "v10", "10 nudo"), 590, 649, 35));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(12, pSpecieMaiz, new Stage(1, "v11", "11 nudo"), 650, 689, 37));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(13, pSpecieMaiz, new Stage(1, "v12", "12 nudo"), 690, 714, 40));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(14, pSpecieMaiz, new Stage(1, "v13", "13 nudo"), 715, 749, 40));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(15, pSpecieMaiz, new Stage(1, "v14", "14 nudo"), 750, 764, 45));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(16, pSpecieMaiz, new Stage(1, "vt", "Floracion"), 775, 954, 45));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(17, pSpecieMaiz, new Stage(1, "R1", "Estambres 50%"), 955, 1149, 45));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(18, pSpecieMaiz, new Stage(1, "R2", "Granos hinchados"), 1150, 1289, 45));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(19, pSpecieMaiz, new Stage(1, "R3", "Estado lechoso"), 1290, 1359, 45));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(20, pSpecieMaiz, new Stage(1, "R4", "Estado pastoso"), 1360, 1449, 45));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(21, pSpecieMaiz, new Stage(1, "R5", "Estado de diente"), 1450, 1649, 45));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(22, pSpecieMaiz, new Stage(1, "R6", "Madurez fisiologica"), 1650, 2000, 45));

            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(23, pSpecieSoja, new Stage(1, "v0", "Siembra"), 0, 114, 7));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(24, pSpecieSoja, new Stage(1, "ve", "Emergencia"), 115, 141, 10));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(25, pSpecieSoja, new Stage(1, "v1", "1 nudo"), 142, 191, 10));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(26, pSpecieSoja, new Stage(1, "v2", "2 nudo"), 192, 242, 12));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(27, pSpecieSoja, new Stage(1, "v3", "3 nudo"), 243, 313, 15));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(28, pSpecieSoja, new Stage(1, "v4", "4 nudo"), 314, 348, 20));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(29, pSpecieSoja, new Stage(1, "v5", "5 nudo"), 349, 397, 20));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(30, pSpecieSoja, new Stage(1, "v6", "6 nudo"), 398, 445, 25));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(31, pSpecieSoja, new Stage(1, "v7", "7 nudo"), 446, 471, 25));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(32, pSpecieSoja, new Stage(1, "v8", "8 nudo"), 472, 515, 30));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(33, pSpecieSoja, new Stage(1, "v9", "9 nudo"), 516, 565, 32));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(34, pSpecieSoja, new Stage(1, "v10", "10 nudo"), 566, 653, 35));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(34, pSpecieSoja, new Stage(1, "v11", "11 nudo"), 654, 741, 35));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(40, pSpecieSoja, new Stage(1, "R1", "Inicio Floracion"), 742, 843, 45));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(42, pSpecieSoja, new Stage(1, "R2", "Floracion Completa"), 845, 911, 45));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(43, pSpecieSoja, new Stage(1, "R3", "Inicio Vainas"), 812, 879, 45));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(44, pSpecieSoja, new Stage(1, "R4", "Vainas Completas"), 980, 1098, 45));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(45, pSpecieSoja, new Stage(1, "R5", "Formacion de semillas"), 1099, 1217, 45));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(45, pSpecieSoja, new Stage(1, "R6", "Semillas Completas"), 1218, 1608, 45));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(45, pSpecieSoja, new Stage(1, "R7", "Inicio Maduracion"), 1609, 1999, 45));
            lPhenolStageList.Add(pIrrigationSystem.CreatePhenologicalStage(45, pSpecieSoja, new Stage(1, "R8", "Maduracion Completa"), 2000, 4000, 45));
            return lPhenolStageList;
        }

        #endregion

        #endregion


    }
}