using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Localization;
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
    ///     - cropIrrigationWeatherRecord
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
    ///     - CreateCropCoefficientWithList_Maiz(Specie pSpecie, Region pRegionList) 
    ///     - CreateCropCoefficientWithList_Soja(Specie pSpecie, Region pRegionList)
    ///     - AddEffectiveRainListToSystem(Region lRegion)
    ///     - CreatePhenologicalStageList(IrrigationSystem.IrrigationSystem pIrrigationSystem,
    ///                    Specie pSpecie,  Specie pSpecieSoja)
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

        //2015-02-12 DAYS_HIDRIC_BALANCE_UNCHANGABLE_AFTER_BIG_WATER_INPUT Change from 2 to 5 
        public const double DAYS_HIDRIC_BALANCE_UNCHANGABLE_AFTER_BIG_WATER_INPUT = 5;

        public const double DAYS_HIDRIC_BALANCE_UNCHANGABLE_AFTER_SOWING = 5;

        public const double PERCENTAGE_LIMIT_OF_AVAILABLE_WATER_CAPACITY = 0.10;

        public const double DAYS_BETWEEN_TWO_PARTIAL_BIG_WATER_INPUT = 3;

        #endregion

        #endregion
        
        #region Private Helpers
        #endregion

        #region Static Methods

        #region CropCoefficient

        /// <summary>
        /// TODO explain CreateCropCoefficientWithList_Maiz
        /// </summary>
        /// <returns></returns>
        public static CropCoefficient CreateCropCoefficientWithList_Maiz()
        {
            //KC Para maiz sacado de la carpeta Datos Prueba


            CropCoefficient lCropCoefficient = new CropCoefficient();
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
            lCropCoefficient.addKCforDayAfterSowing(20, 0.36);
            lCropCoefficient.addKCforDayAfterSowing(21, 0.36);
            lCropCoefficient.addKCforDayAfterSowing(22, 0.36);
            lCropCoefficient.addKCforDayAfterSowing(23, 0.37);
            lCropCoefficient.addKCforDayAfterSowing(24, 0.37);
            lCropCoefficient.addKCforDayAfterSowing(25, 0.38);
            lCropCoefficient.addKCforDayAfterSowing(26, 0.38);
            lCropCoefficient.addKCforDayAfterSowing(27, 0.39);
            lCropCoefficient.addKCforDayAfterSowing(28, 0.39);
            lCropCoefficient.addKCforDayAfterSowing(29, 0.40);
            lCropCoefficient.addKCforDayAfterSowing(30, 0.40);
            lCropCoefficient.addKCforDayAfterSowing(31, 0.41);
            lCropCoefficient.addKCforDayAfterSowing(32, 0.41);
            lCropCoefficient.addKCforDayAfterSowing(33, 0.42);
            lCropCoefficient.addKCforDayAfterSowing(34, 0.42);
            lCropCoefficient.addKCforDayAfterSowing(35, 0.43);
            lCropCoefficient.addKCforDayAfterSowing(36, 0.43);
            lCropCoefficient.addKCforDayAfterSowing(37, 0.44);
            lCropCoefficient.addKCforDayAfterSowing(38, 0.44);
            lCropCoefficient.addKCforDayAfterSowing(39, 0.45);
            lCropCoefficient.addKCforDayAfterSowing(40, 0.45);
            lCropCoefficient.addKCforDayAfterSowing(41, 0.46);
            lCropCoefficient.addKCforDayAfterSowing(42, 0.47);
            lCropCoefficient.addKCforDayAfterSowing(43, 0.48);
            lCropCoefficient.addKCforDayAfterSowing(44, 0.49);
            lCropCoefficient.addKCforDayAfterSowing(45, 0.50);///////
            lCropCoefficient.addKCforDayAfterSowing(46, 0.52);
            lCropCoefficient.addKCforDayAfterSowing(47, 0.54);
            lCropCoefficient.addKCforDayAfterSowing(48, 0.56);
            lCropCoefficient.addKCforDayAfterSowing(49, 0.58);
            lCropCoefficient.addKCforDayAfterSowing(50, 0.59);
            lCropCoefficient.addKCforDayAfterSowing(51, 0.60);////////////
            lCropCoefficient.addKCforDayAfterSowing(52, 0.62);
            lCropCoefficient.addKCforDayAfterSowing(53, 0.64);
            lCropCoefficient.addKCforDayAfterSowing(54, 0.66);
            lCropCoefficient.addKCforDayAfterSowing(55, 0.68);
            lCropCoefficient.addKCforDayAfterSowing(56, 0.70);/////
            lCropCoefficient.addKCforDayAfterSowing(57, 0.72);
            lCropCoefficient.addKCforDayAfterSowing(58, 0.74);
            lCropCoefficient.addKCforDayAfterSowing(59, 0.76);
            lCropCoefficient.addKCforDayAfterSowing(60, 0.78);
            lCropCoefficient.addKCforDayAfterSowing(61, 0.80);//////
            lCropCoefficient.addKCforDayAfterSowing(62, 0.82);
            lCropCoefficient.addKCforDayAfterSowing(63, 0.84);
            lCropCoefficient.addKCforDayAfterSowing(64, 0.86);
            lCropCoefficient.addKCforDayAfterSowing(65, 0.88);
            lCropCoefficient.addKCforDayAfterSowing(66, 0.9);
            lCropCoefficient.addKCforDayAfterSowing(67, 0.92);
            lCropCoefficient.addKCforDayAfterSowing(68, 0.95);
            lCropCoefficient.addKCforDayAfterSowing(69, 0.97);
            lCropCoefficient.addKCforDayAfterSowing(70, 1.00);
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


            #region Version Anterior a Correccion 11/01/2015
            //Version anterior a la correccion del dia 11/01/2015 segun mail de Sebastian
            /*
            CropCoefficient lCropCoefficient = new CropCoefficient(pSpecie, pRegionList);
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
            */
            #endregion

            return lCropCoefficient;

        }

        /// <summary>
        /// TODO Explain CreateCropCoefficientWithList_Soja()
        /// </summary>
        /// <returns></returns>
        public static CropCoefficient CreateCropCoefficientWithList_Soja()
        {
            //KC Para soja sacado de la carpeta Calculos
            CropCoefficient lCropCoefficient = new CropCoefficient();
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

        #region EffectiveRainList

        /// <summary>
        /// TODO Explain AddEffectiveRainListToSystem
        /// </summary>
        /// <param name="lRegion"></param>
        /// <returns></returns>
        public static List<EffectiveRain> CreateEffectiveRainListToSystem()
        {
            List<EffectiveRain> lEffectiveRainList = new List<EffectiveRain>();
            lEffectiveRainList.Add(new EffectiveRain(10, 0, 10, 90));
            lEffectiveRainList.Add(new EffectiveRain(10, 11, 20, 80));
            lEffectiveRainList.Add(new EffectiveRain(10, 21, 30, 80));
            lEffectiveRainList.Add(new EffectiveRain(10, 31, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain(10, 41, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain(10, 51, 60, 70));
            lEffectiveRainList.Add(new EffectiveRain(10, 61, 70, 65));
            lEffectiveRainList.Add(new EffectiveRain(10, 71, 80, 60));
            lEffectiveRainList.Add(new EffectiveRain(10, 81, 90, 60));
            lEffectiveRainList.Add(new EffectiveRain(10, 91, 100, 55));
            lEffectiveRainList.Add(new EffectiveRain(10, 100, 1000, 50));

            lEffectiveRainList.Add(new EffectiveRain(11, 0, 10, 90));
            lEffectiveRainList.Add(new EffectiveRain(11, 11, 20, 80));
            lEffectiveRainList.Add(new EffectiveRain(11, 21, 30, 80));
            lEffectiveRainList.Add(new EffectiveRain(11, 31, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain(11, 41, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain(11, 51, 60, 70));
            lEffectiveRainList.Add(new EffectiveRain(11, 61, 70, 65));
            lEffectiveRainList.Add(new EffectiveRain(11, 71, 80, 60));
            lEffectiveRainList.Add(new EffectiveRain(11, 81, 90, 60));
            lEffectiveRainList.Add(new EffectiveRain(11, 91, 100, 55));
            lEffectiveRainList.Add(new EffectiveRain(11, 100, 1000, 50));

            lEffectiveRainList.Add(new EffectiveRain(12, 0, 10, 90));
            lEffectiveRainList.Add(new EffectiveRain(12, 11, 20, 80));
            lEffectiveRainList.Add(new EffectiveRain(12, 21, 30, 85));
            lEffectiveRainList.Add(new EffectiveRain(12, 31, 40, 80));
            lEffectiveRainList.Add(new EffectiveRain(12, 41, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain(12, 51, 60, 75));
            lEffectiveRainList.Add(new EffectiveRain(12, 61, 70, 70));
            lEffectiveRainList.Add(new EffectiveRain(12, 71, 80, 70));
            lEffectiveRainList.Add(new EffectiveRain(12, 81, 90, 70));
            lEffectiveRainList.Add(new EffectiveRain(12, 91, 100, 70));
            lEffectiveRainList.Add(new EffectiveRain(12, 100, 1000, 60));

            lEffectiveRainList.Add(new EffectiveRain(1, 0, 10, 90));
            lEffectiveRainList.Add(new EffectiveRain(1, 11, 20, 80));
            lEffectiveRainList.Add(new EffectiveRain(1, 21, 30, 85));
            lEffectiveRainList.Add(new EffectiveRain(1, 31, 40, 80));
            lEffectiveRainList.Add(new EffectiveRain(1, 41, 50, 75));
            lEffectiveRainList.Add(new EffectiveRain(1, 51, 60, 75));
            lEffectiveRainList.Add(new EffectiveRain(1, 61, 70, 70));
            lEffectiveRainList.Add(new EffectiveRain(1, 71, 80, 70));
            lEffectiveRainList.Add(new EffectiveRain(1, 81, 90, 70));
            lEffectiveRainList.Add(new EffectiveRain(1, 91, 100, 70));
            lEffectiveRainList.Add(new EffectiveRain(1, 100, 1000, 60));

            lEffectiveRainList.Add(new EffectiveRain(2, 0, 10, 90));
            lEffectiveRainList.Add(new EffectiveRain(2, 11, 20, 80));
            lEffectiveRainList.Add(new EffectiveRain(2, 21, 30, 85));
            lEffectiveRainList.Add(new EffectiveRain(2, 31, 40, 80));
            lEffectiveRainList.Add(new EffectiveRain(2, 41, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain(2, 51, 60, 75));
            lEffectiveRainList.Add(new EffectiveRain(2, 61, 70, 70));
            lEffectiveRainList.Add(new EffectiveRain(2, 71, 80, 70));
            lEffectiveRainList.Add(new EffectiveRain(2, 81, 90, 70));
            lEffectiveRainList.Add(new EffectiveRain(2, 91, 100, 70));
            lEffectiveRainList.Add(new EffectiveRain(2, 100, 1000, 60));

            lEffectiveRainList.Add(new EffectiveRain(3, 0, 10, 90));
            lEffectiveRainList.Add(new EffectiveRain(3, 11, 20, 80));
            lEffectiveRainList.Add(new EffectiveRain(3, 21, 30, 75));
            lEffectiveRainList.Add(new EffectiveRain(3, 31, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain(3, 41, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain(3, 51, 60, 70));
            lEffectiveRainList.Add(new EffectiveRain(3, 61, 70, 65));
            lEffectiveRainList.Add(new EffectiveRain(3, 71, 80, 60));
            lEffectiveRainList.Add(new EffectiveRain(3, 81, 90, 60));
            lEffectiveRainList.Add(new EffectiveRain(3, 91, 100, 55));
            lEffectiveRainList.Add(new EffectiveRain(3, 100, 1000, 50));


            return lEffectiveRainList;
            

        }
        
        #endregion

        #region PhenologicalStage


        /// <summary>
        /// TODO explain CreatePhenologicalStageListForMaiz
        /// </summary>
        /// <param name="pCrop"></param>
        /// <returns></returns>
        public static List<PhenologicalStage> CreatePhenologicalStageListForMaiz(Crop pCrop)                        
        {
            List<PhenologicalStage> lReturn = null;
            List<PhenologicalStage> lPhenolStageList;
            double lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth;
            Stage lStage = null;

            try
            {                
                lPhenolStageList = new List<PhenologicalStage>();

                lStage = new Stage(1, "Maiz v0", "Siembra"); lMinDegree = 0; lMaxDegree = 59; lRootDepth = 7; lHydricBalanceDepth = 17;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz ve", "Emergencia"); lMinDegree = lMaxDegree + 1; lMaxDegree = 114; lRootDepth = 7; lHydricBalanceDepth = 17;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz v1", "1 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 134; lRootDepth = 7; lHydricBalanceDepth = 17;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz v2", "2 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 179; lRootDepth = 10; lHydricBalanceDepth = 20;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz v3", "3 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 229; lRootDepth = 15; lHydricBalanceDepth = 25;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz v4", "4 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 289; lRootDepth = 20; lHydricBalanceDepth = 30;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz v5", "5 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 339; lRootDepth = 20; lHydricBalanceDepth = 30;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz v6", "6 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 404; lRootDepth = 25; lHydricBalanceDepth = 35;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz v7", "7 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 459; lRootDepth = 25; lHydricBalanceDepth = 35;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz v8", "8 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 519; lRootDepth = 30; lHydricBalanceDepth = 40;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz v9", "9 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 589; lRootDepth = 32; lHydricBalanceDepth = 40;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz v10", "10 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 649; lRootDepth = 35; lHydricBalanceDepth = 40;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz v11", "11 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 689; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz v12", "12 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 714; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz v13", "13 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 749; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz v14", "14 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 764; lRootDepth = 45; lHydricBalanceDepth = 50;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz vt", "Floracion"); lMinDegree = lMaxDegree + 1; lMaxDegree = 954; lRootDepth = 45; lHydricBalanceDepth = 50;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz R1", "Estambres 50%"); lMinDegree = lMaxDegree + 1; lMaxDegree = 1149; lRootDepth = 45; lHydricBalanceDepth = 50;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz R2", "Granos hinchados"); lMinDegree = lMaxDegree + 1; lMaxDegree = 1289; lRootDepth = 45; lHydricBalanceDepth = 50;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz R3", "Estado lechoso"); lMinDegree = lMaxDegree + 1; lMaxDegree = 1359; lRootDepth = 45; lHydricBalanceDepth = 50;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz R4", "Estado pastoso"); lMinDegree = lMaxDegree + 1; lMaxDegree = 1449; lRootDepth = 45; lHydricBalanceDepth = 50;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz R5", "Estado de diente"); lMinDegree = lMaxDegree + 1; lMaxDegree = 1649; lRootDepth = 45; lHydricBalanceDepth = 50;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Maiz R6", "Madurez fisiologica"); lMinDegree = lMaxDegree + 1; lMaxDegree = 2000; lRootDepth = 45; lHydricBalanceDepth = 50;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);
                
                lReturn = lPhenolStageList;

            }
            catch (Exception e)
            {
                //TODO manage and log the exception
                throw e;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO explain CreatePhenologicalStageListForSoja
        /// </summary>
        /// <param name="pCrop"></param>
        /// <param name="pCrop_Soja"></param>
        /// <param name="pSpecieSoja"></param>
        /// <returns></returns>
        public static List<PhenologicalStage> CreatePhenologicalStageListForSoja(Crop pCrop)
        {
            List<PhenologicalStage> lReturn = null;
            List<PhenologicalStage> lPhenolStageList;
            double lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth;
            Stage lStage = null;

            try
            {
                lPhenolStageList = new List<PhenologicalStage>();

                lStage = new Stage(1, "Soja v0", "Siembra"); lMinDegree = 0; lMaxDegree = 114; lRootDepth = 7; lHydricBalanceDepth = 17;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja ve", "Emergencia"); lMinDegree = lMaxDegree + 1; lMaxDegree = 141; lRootDepth = 10; lHydricBalanceDepth = 20;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja v1", "1 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 191; lRootDepth = 10; lHydricBalanceDepth = 20;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja v2", "2 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 242; lRootDepth = 12; lHydricBalanceDepth = 22;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja v3", "3 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 313; lRootDepth = 15; lHydricBalanceDepth = 25;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja v4", "4 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 348; lRootDepth = 20; lHydricBalanceDepth = 30;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja v5", "5 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 397; lRootDepth = 20; lHydricBalanceDepth = 30;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja v6", "6 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 445; lRootDepth = 25; lHydricBalanceDepth = 35;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja v7", "7 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 471; lRootDepth = 25; lHydricBalanceDepth = 35;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja v8", "8 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 515; lRootDepth = 30; lHydricBalanceDepth = 40;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja v9", "9 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 565; lRootDepth = 32; lHydricBalanceDepth = 40;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja v10", "10 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 653; lRootDepth = 35; lHydricBalanceDepth = 40;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja v11", "11 nudo"); lMinDegree = lMaxDegree + 1; lMaxDegree = 741; lRootDepth = 35; lHydricBalanceDepth = 40;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja R1", "Inicio Floracion"); lMinDegree = lMaxDegree + 1; lMaxDegree = 843; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja R2", "Floracion Completa"); lMinDegree = lMaxDegree + 1; lMaxDegree = 911; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja R3", "Inicio Vainas"); lMinDegree = lMaxDegree + 1; lMaxDegree = 979; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja R4", "Vainas Completas"); lMinDegree = lMaxDegree + 1; lMaxDegree = 1098; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja R5", "Formacion de semillas"); lMinDegree = lMaxDegree + 1; lMaxDegree = 1217; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja R6", "Semillas Completas"); lMinDegree = lMaxDegree + 1; lMaxDegree = 1608; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja R7", "Inicio Maduracion"); lMinDegree = lMaxDegree + 1; lMaxDegree = 1999; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);

                lStage = new Stage(1, "Soja R8", "Maduracion Completa"); lMinDegree = lMaxDegree + 1; lMaxDegree = 4000; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lStage, lMinDegree, lMaxDegree, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.Description);
                
                lReturn = lPhenolStageList;

            }
            catch (Exception e)
            {
                //TODO manage and log the exception
                throw e;
            }
            return lReturn;
        }


        #endregion

        #endregion

    }
}