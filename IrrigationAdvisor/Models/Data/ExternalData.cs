using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Weather;

namespace IrrigationAdvisor.Models.Data
{
    /// <summary>
    /// Create: 2015-01-07
    /// Author: rodouy
    /// Description: 
    ///     These class will contain all the data that came from external source.
    ///     
    /// References:
    ///     list of classes this class use
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     
    /// 
    /// Methods:
    ///     - ClassTemplate()      -- constructor
    ///     - ClassTemplate(name)  -- consturctor with parameters
    ///     - SetName(newName)     -- method to set the name field
    /// 
    /// </summary>
    public static class ExternalData
    {

        #region Consts
        #endregion

        #region Private Helpers
        #endregion

        #region Static Methods

        #region WeatherData

        public static void AddWeatherData2007(IrrigationSystem pIrrigationSystem,
                                WeatherStation pWeatherStation)
        {
            WeatherStation lWeatherStation;
            DateTime lFirstDay = new DateTime (2007, 1, 1);
            

            lWeatherStation = pWeatherStation;

            // DATOS DEL TIEMPO
            
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(000), 28.6, 0, 28.6, 28.6, 7.3);  // Month - 2007-1-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(001), 25.3, 0, 25.3, 25.3, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(002), 25.3, 0, 25.3, 25.3, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(003), 25.6, 0, 25.6, 25.6, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(004), 21.1, 0, 21.1, 21.1, 4.5);  // Month - 2007-1-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(005), 20.0, 0, 20.0, 20.0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(006), 20.7, 0, 20.7, 20.7, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(007), 22.0, 0, 22.0, 22.0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(008), 24.9, 0, 24.9, 24.9, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(009), 25.7, 0, 25.7, 25.7, 3.4);  // Month - 2007-1-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(010), 25.0, 0, 25.0, 25.0, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(011), 24.9, 0, 24.9, 24.9, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(012), 24.7, 0, 24.7, 24.7, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(013), 16.4, 0, 16.4, 16.4, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(014), 16.5, 0, 16.5, 16.5, 5.1);  // Month - 2007-1-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(015), 19.9, 0, 19.9, 19.9, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(016), 22.5, 0, 22.5, 22.5, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(017), 23.2, 0, 23.2, 23.2, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(018), 20.0, 0, 20.0, 20.0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(019), 21.5, 0, 21.5, 21.5, 5.2);  // Month - 2007-1-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(020), 20.7, 0, 20.7, 20.7, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(021), 22.0, 0, 22.0, 22.0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(022), 25.0, 0, 25.0, 25.0, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(023), 25.4, 0, 25.4, 25.4, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(024), 23.9, 0, 23.9, 23.9, 2.2);  // Month - 2007-1-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(025), 25.0, 0, 25.0, 25.0, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(026), 23.5, 0, 23.5, 23.5, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(027), 21.1, 0, 21.1, 21.1, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(028), 18.4, 0, 18.4, 18.4, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(029), 21.8, 0, 21.8, 21.8, 4.8);  // Month - 2007-1-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(030), 22.7, 0, 22.7, 22.7, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(031), 23.0, 0, 23.0, 23.0, 5.9);  // Month - 2007-2-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(032), 26.3, 0, 26.3, 26.3, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(033), 27.9, 0, 27.9, 27.9, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(034), 27.6, 0, 27.6, 27.6, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(035), 24.6, 0, 24.6, 24.6, 3.3);  // Month - 2007-2-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(036), 25.0, 0, 25.0, 25.0, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(037), 22.4, 0, 22.4, 22.4, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(038), 23.1, 0, 23.1, 23.1, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(039), 24.7, 0, 24.7, 24.7, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(040), 23.4, 0, 23.4, 23.4, 4.8);  // Month - 2007-2-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(041), 20.9, 0, 20.9, 20.9, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(042), 20.1, 0, 20.1, 20.1, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(043), 23.0, 0, 23.0, 23.0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(044), 25.5, 0, 25.5, 25.5, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(045), 26.7, 0, 26.7, 26.7, 3.6);  // Month - 2007-2-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(046), 25.0, 0, 25.0, 25.0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(047), 21.6, 0, 21.6, 21.6, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(048), 19.1, 0, 19.1, 19.1, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(049), 19.4, 0, 19.4, 19.4, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(050), 21.0, 0, 21.0, 21.0, 4.9);  // Month - 2007-2-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(051), 24.0, 0, 24.0, 24.0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(052), 24.4, 0, 24.4, 24.4, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(053), 24.1, 0, 24.1, 24.1, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(054), 23.3, 0, 23.3, 23.3, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(055), 26.9, 0, 26.9, 26.9, 5.1);  // Month - 2007-2-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(056), 26.1, 0, 26.1, 26.1, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(057), 21.5, 0, 21.5, 21.5, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(058), 22.3, 0, 22.3, 22.3, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(059), 23.0, 0, 23.0, 23.0, 1.7);  // Month - 2007-3-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(060), 18.8, 0, 18.8, 18.8, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(061), 16.1, 0, 16.1, 16.1, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(062), 17.6, 0, 17.6, 17.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(063), 21.9, 0, 21.9, 21.9, 2.9);  // Month - 2007-3-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(064), 23.4, 0, 23.4, 23.4, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(065), 23.4, 0, 23.4, 23.4, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(066), 20.8, 0, 20.8, 20.8, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(067), 20.6, 0, 20.6, 20.6, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(068), 18.3, 0, 18.3, 18.3, 2.6);  // Month - 2007-3-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(069), 20.1, 0, 20.1, 20.1, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(070), 23.2, 0, 23.2, 23.2, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(071), 22.9, 0, 22.9, 22.9, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(072), 22.0, 0, 22.0, 22.0, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(073), 22.3, 0, 22.3, 22.3, 3.2);  // Month - 2007-3-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(074), 20.3, 0, 20.3, 20.3, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(075), 19.7, 0, 19.7, 19.7, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(076), 20.0, 0, 20.0, 20.0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(077), 19.9, 0, 19.9, 19.9, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(078), 21.5, 0, 21.5, 21.5, 3.1);  // Month - 2007-3-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(079), 22.2, 0, 22.2, 22.2, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(080), 23.5, 0, 23.5, 23.5, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(081), 19.0, 0, 19.0, 19.0, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(082), 18.0, 0, 18.0, 18.0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(083), 20.5, 0, 20.5, 20.5, 2.9);  // Month - 2007-3-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(084), 22.9, 0, 22.9, 22.9, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(085), 19.8, 0, 19.8, 19.8, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(086), 20.8, 0, 20.8, 20.8, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(087), 22.2, 0, 22.2, 22.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(088), 20.7, 0, 20.7, 20.7, 1.1);  // Month - 2007-3-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(089), 20.0, 0, 20.0, 20.0, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(090), 22.5, 0, 22.5, 22.5, 2.3);  // Month - 2007-4-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(091), 22.5, 0, 22.5, 22.5, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(092), 20.4, 0, 20.4, 20.4, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(093), 18.7, 0, 18.7, 18.7, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(094), 18.0, 0, 18.0, 18.0, 2.4);  // Month - 2007-4-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(095), 19.6, 0, 19.6, 19.6, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(096), 20.7, 0, 20.7, 20.7, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(097), 17.3, 0, 17.3, 17.3, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(098), 17.2, 0, 17.2, 17.2, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(099), 17.9, 0, 17.9, 17.9, 1.4);  // Month - 2007-4-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(100), 19.3, 0, 19.3, 19.3, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(101), 15.6, 0, 15.6, 15.6, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(102), 15.4, 0, 15.4, 15.4, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(103), 17.8, 0, 17.8, 17.8, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(104), 19.8, 0, 19.8, 19.8, 1.0);  // Month - 2007-4-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(105), 20.6, 0, 20.6, 20.6, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(106), 22.7, 0, 22.7, 22.7, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(107), 25.4, 0, 25.4, 25.4, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(108), 25.6, 0, 25.6, 25.6, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(109), 19.1, 0, 19.1, 19.1, 1.0);  // Month - 2007-4-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(110), 15.4, 0, 15.4, 15.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(111), 18.3, 0, 18.3, 18.3, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(112), 16.7, 0, 16.7, 16.7, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(113), 16.8, 0, 16.8, 16.8, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(114), 14.6, 0, 14.6, 14.6, 1.1);  // Month - 2007-4-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(115), 14.5, 0, 14.5, 14.5, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(116), 12.6, 0, 12.6, 12.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(117), 14.1, 0, 14.1, 14.1, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(118), 14.1, 0, 14.1, 14.1, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(119), 16.0, 0, 16.0, 16.0, 1.3);  // Month - 2007-4-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(120), 18.2, 0, 18.2, 18.2, 0.8);  // Month - 2007-5-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(121), 17.9, 0, 17.9, 17.9, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(122), 17.5, 0, 17.5, 17.5, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(123), 17.9, 0, 17.9, 17.9, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(124), 17.8, 0, 17.8, 17.8, 0.8);  // Month - 2007-5-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(125), 14.4, 0, 14.4, 14.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(126), 11.5, 0, 11.5, 11.5, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(127), 11.3, 0, 11.3, 11.3, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(128), 10.4, 0, 10.4, 10.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(129), 09.7, 0, 09.7, 09.7, 0.7);  // Month - 2007-5-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(130), 12.8, 0, 12.8, 12.8, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(131), 11.0, 0, 11.0, 11.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(132), 10.4, 0, 10.4, 10.4, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(133), 11.1, 0, 11.1, 11.1, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(134), 13.0, 0, 13.0, 13.0, 0.6);  // Month - 2007-5-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(135), 11.9, 0, 11.9, 11.9, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(136), 09.0, 0, 09.0, 09.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(137), 10.8, 0, 10.8, 10.8, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(138), 12.6, 0, 12.6, 12.6, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(139), 12.3, 0, 12.3, 12.3, 0.7);  // Month - 2007-5-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(140), 13.3, 0, 13.3, 13.3, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(141), 11.0, 0, 11.0, 11.0, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(142), 10.7, 0, 10.7, 10.7, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(143), 09.1, 0, 09.1, 09.1, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(144), 09.2, 0, 09.2, 09.2, 0.5);  // Month - 2007-5-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(145), 09.6, 0, 09.6, 09.6, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(146), 08.0, 0, 08.0, 08.0, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(147), 06.2, 0, 06.2, 06.2, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(148), 08.0, 0, 08.0, 08.0, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(149), 08.0, 0, 08.0, 08.0, 0.4);  // Month - 2007-5-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(150), 06.8, 0, 06.8, 06.8, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(151), 09.8, 0, 09.8, 09.8, 0.4);  // Month - 2007-6-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(152), 10.3, 0, 10.3, 10.3, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(153), 13.3, 0, 13.3, 13.3, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(154), 12.5, 0, 12.5, 12.5, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(155), 13.1, 0, 13.1, 13.1, 0.7);  // Month - 2007-6-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(156), 11.0, 0, 11.0, 11.0, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(157), 06.5, 0, 06.5, 06.5, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(158), 08.0, 0, 08.0, 08.0, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(159), 12.8, 0, 12.8, 12.8, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(160), 10.1, 0, 10.1, 10.1, 0.3);  // Month - 2007-6-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(161), 09.7, 0, 09.7, 09.7, 0.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(162), 10.9, 0, 10.9, 10.9, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(163), 13.2, 0, 13.2, 13.2, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(164), 10.8, 0, 10.8, 10.8, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(165), 08.2, 0, 08.2, 08.2, 0.4);  // Month - 2007-6-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(166), 07.2, 0, 07.2, 07.2, 0.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(167), 07.4, 0, 07.4, 07.4, 0.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(168), 06.0, 0, 06.0, 06.0, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(169), 08.5, 0, 08.5, 08.5, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(170), 12.9, 0, 12.9, 12.9, 0.4);  // Month - 2007-6-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(171), 11.8, 0, 11.8, 11.8, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(172), 13.9, 0, 13.9, 13.9, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(173), 09.4, 0, 09.4, 09.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(174), 06.1, 0, 06.1, 06.1, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(175), 07.4, 0, 07.4, 07.4, 0.3);  // Month - 2007-6-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(176), 08.7, 0, 08.7, 08.7, 0.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(177), 07.7, 0, 07.7, 07.7, 0.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(178), 09.0, 0, 09.0, 09.0, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(179), 09.9, 0, 09.9, 09.9, 0.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(180), 06.7, 0, 06.7, 06.7, 0.1);  // Month - 2007-6-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(181), 06.5, 0, 06.5, 06.5, 0.1);  // Month - 2007-7-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(182), 06.1, 0, 06.1, 06.1, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(183), 06.7, 0, 06.7, 06.7, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(184), 12.2, 0, 12.2, 12.2, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(185), 17.4, 0, 17.4, 17.4, 0.6);  // Month - 2007-7-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(186), 09.1, 0, 09.1, 09.1, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(187), 07.2, 0, 07.2, 07.2, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(188), 05.7, 0, 05.7, 05.7, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(189), 05.3, 0, 05.3, 05.3, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(190), 02.9, 0, 02.9, 02.9, 0.5);  // Month - 2007-7-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(191), 04.5, 0, 04.5, 04.5, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(192), 04.6, 0, 04.6, 04.6, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(193), 06.6, 0, 06.6, 06.6, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(194), 08.1, 0, 08.1, 08.1, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(195), 07.0, 0, 07.0, 07.0, 0.3);  // Month - 2007-7-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(196), 09.5, 0, 09.5, 09.5, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(197), 11.1, 0, 11.1, 11.1, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(198), 09.5, 0, 09.5, 09.5, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(199), 13.6, 0, 13.6, 13.6, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(200), 11.4, 0, 11.4, 11.4, 1.3);  // Month - 2007-7-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(201), 09.1, 0, 09.1, 09.1, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(202), 07.9, 0, 07.9, 07.9, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(203), 06.3, 0, 06.3, 06.3, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(204), 04.5, 0, 04.5, 04.5, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(205), 03.6, 0, 03.6, 03.6, 0.4);  // Month - 2007-7-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(206), 09.6, 0, 09.6, 09.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(207), 05.0, 0, 05.0, 05.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(208), 04.3, 0, 04.3, 04.3, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(209), 04.9, 0, 04.9, 04.9, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(210), 06.9, 0, 06.9, 06.9, 0.5);  // Month - 2007-7-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(211), 08.9, 0, 08.9, 08.9, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(212), 07.2, 0, 07.2, 07.2, 0.5);  // Month - 2007-8-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(213), 07.2, 0, 07.2, 07.2, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(214), 08.2, 0, 08.2, 08.2, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(215), 06.5, 0, 06.5, 06.5, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(216), 06.9, 0, 06.9, 06.9, 0.5);  // Month - 2007-8-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(217), 07.9, 0, 07.9, 07.9, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(218), 09.8, 0, 09.8, 09.8, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(219), 11.5, 0, 11.5, 11.5, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(220), 11.3, 0, 11.3, 11.3, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(221), 06.6, 0, 06.6, 06.6, 0.6);  // Month - 2007-8-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(222), 07.4, 0, 07.4, 07.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(223), 06.6, 0, 06.6, 06.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(224), 14.9, 0, 14.9, 14.9, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(225), 19.1, 0, 19.1, 19.1, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(226), 11.0, 0, 11.0, 11.0, 0.7);  // Month - 2007-8-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(227), 08.3, 0, 08.3, 08.3, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(228), 05.5, 0, 05.5, 05.5, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(229), 08.9, 0, 08.9, 08.9, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(230), 08.5, 0, 08.5, 08.5, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(231), 05.7, 0, 05.7, 05.7, 0.7);  // Month - 2007-8-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(232), 07.4, 0, 07.4, 07.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(233), 08.0, 0, 08.0, 08.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(234), 09.7, 0, 09.7, 09.7, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(235), 10.2, 0, 10.2, 10.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(236), 12.0, 0, 12.0, 12.0, 1.2);  // Month - 2007-8-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(237), 10.4, 0, 10.4, 10.4, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(238), 10.0, 0, 10.0, 10.0, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(239), 11.4, 0, 11.4, 11.4, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(240), 07.0, 0, 07.0, 07.0, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(241), 10.3, 0, 10.3, 10.3, 1.4);  // Month - 2007-8-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(242), 12.6, 0, 12.6, 12.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(243), 14.4, 0, 14.4, 14.4, 1.0);  // Month - 2007-9-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(244), 15.0, 0, 15.0, 15.0, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(245), 18.5, 0, 18.5, 18.5, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(246), 21.2, 0, 21.2, 21.2, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(247), 12.2, 0, 12.2, 12.2, 1.0);  // Month - 2007-9-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(248), 18.7, 0, 18.7, 18.7, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(249), 22.2, 0, 22.2, 22.2, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(250), 24.0, 0, 24.0, 24.0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(251), 24.6, 0, 24.6, 24.6, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(252), 24.8, 0, 24.8, 24.8, 2.6);  // Month - 2007-9-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(253), 17.4, 0, 17.4, 17.4, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(254), 14.5, 0, 14.5, 14.5, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(255), 17.3, 0, 17.3, 17.3, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(256), 19.0, 0, 19.0, 19.0, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(257), 14.6, 0, 14.6, 14.6, 0.9);  // Month - 2007-9-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(258), 12.9, 0, 12.9, 12.9, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(259), 13.6, 0, 13.6, 13.6, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(260), 13.8, 0, 13.8, 13.8, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(261), 13.1, 0, 13.1, 13.1, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(262), 11.1, 0, 11.1, 11.1, 1.6);  // Month - 2007-9-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(263), 11.7, 0, 11.7, 11.7, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(264), 11.3, 0, 11.3, 11.3, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(265), 11.8, 0, 11.8, 11.8, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(266), 08.4, 0, 08.4, 08.4, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(267), 09.2, 0, 09.2, 09.2, 1.9);  // Month - 2007-9-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(268), 11.2, 0, 11.2, 11.2, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(269), 15.8, 0, 15.8, 15.8, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(270), 16.0, 0, 16.0, 16.0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(271), 17.6, 0, 17.6, 17.6, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(272), 17.9, 0, 17.9, 17.9, 4.3);  // Month - 2007-9-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(273), 15.5, 0, 15.5, 15.5, 1.1);  // Month - 2007-10-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(274), 19.0, 0, 19.0, 19.0, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(275), 20.3, 0, 20.3, 20.3, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(276), 21.6, 0, 21.6, 21.6, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(277), 20.2, 0, 20.2, 20.2, 1.2);  // Month - 2007-10-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(278), 15.7, 0, 15.7, 15.7, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(279), 12.9, 0, 12.9, 12.9, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(280), 13.9, 0, 13.9, 13.9, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(281), 15.1, 0, 15.1, 15.1, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(282), 14.6, 0, 14.6, 14.6, 1.3);  // Month - 2007-10-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(283), 12.6, 0, 12.6, 12.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(284), 13.2, 0, 13.2, 13.2, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(285), 13.3, 0, 13.3, 13.3, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(286), 13.4, 0, 13.4, 13.4, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(287), 15.2, 0, 15.2, 15.2, 2.6);  // Month - 2007-10-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(288), 16.0, 0, 16.0, 16.0, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(289), 19.0, 0, 19.0, 19.0, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(290), 18.5, 0, 18.5, 18.5, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(291), 19.5, 0, 19.5, 19.5, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(292), 20.0, 0, 20.0, 20.0, 3.4);  // Month - 2007-10-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(293), 17.0, 0, 17.0, 17.0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(294), 18.4, 0, 18.4, 18.4, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(295), 20.6, 0, 20.6, 20.6, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(296), 19.5, 0, 19.5, 19.5, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(297), 21.9, 0, 21.9, 21.9, 3.3);  // Month - 2007-10-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(298), 19.4, 0, 19.4, 19.4, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(299), 16.6, 0, 16.6, 16.6, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(300), 17.1, 0, 17.1, 17.1, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(301), 19.0, 0, 19.0, 19.0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(302), 20.1, 0, 20.1, 20.1, 3.9);  // Month - 2007-10-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(303), 20.2, 0, 20.2, 20.2, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(304), 15.9, 0, 15.9, 15.9, 4.6);  // Month - 2007-11-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(305), 16.6, 0, 16.6, 16.6, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(306), 19.7, 0, 19.7, 19.7, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(307), 11.5, 0, 11.5, 11.5, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(308), 15.0, 0, 15.0, 15.0, 4.6);  // Month - 2007-11-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(309), 19.2, 0, 19.2, 19.2, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(310), 21.2, 0, 21.2, 21.2, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(311), 18.7, 0, 18.7, 18.7, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(312), 17.9, 0, 17.9, 17.9, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(313), 13.2, 0, 13.2, 13.2, 2.9);  // Month - 2007-11-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(314), 11.0, 0, 11.0, 11.0, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(315), 14.5, 0, 14.5, 14.5, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(316), 13.6, 0, 13.6, 13.6, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(317), 11.7, 0, 11.7, 11.7, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(318), 12.1, 0, 12.1, 12.1, 3.9);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(319), 16.2, 0, 16.2, 16.2, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(320), 21.4, 0, 21.4, 21.4, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(321), 17.8, 0, 17.8, 17.8, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(322), 19.9, 0, 19.9, 19.9, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(323), 17.8, 0, 17.8, 17.8, 4.6);  // Month - 2007-11-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(324), 17.8, 0, 17.8, 17.8, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(325), 20.5, 0, 20.5, 20.5, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(326), 17.5, 0, 17.5, 17.5, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(327), 10.6, 0, 10.6, 10.6, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(328), 13.6, 0, 13.6, 13.6, 4.5);  // Month - 2007-11-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(329), 16.5, 0, 16.5, 16.5, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(330), 16.3, 0, 16.3, 16.3, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(331), 19.5, 0, 19.5, 19.5, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(332), 22.2, 0, 22.2, 22.2, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(333), 22.5, 0, 22.5, 22.5, 5.5);  // Month - 2007-11-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(334), 21.6, 0, 21.6, 21.6, 5.8);  // Month - 2007-12-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(335), 22.3, 0, 22.3, 22.3, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(336), 24.9, 0, 24.9, 24.9, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(337), 23.4, 0, 23.4, 23.4, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(338), 15.4, 0, 15.4, 15.4, 5.5);  // Month - 2007-12-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(339), 17.2, 0, 17.2, 17.2, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(340), 21.5, 0, 21.5, 21.5, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(341), 22.4, 0, 22.4, 22.4, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(342), 19.6, 0, 19.6, 19.6, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(343), 20.5, 0, 20.5, 20.5, 4.0);  // Month - 2007-12-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(344), 15.8, 0, 15.8, 15.8, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(345), 19.3, 0, 19.3, 19.3, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(346), 23.0, 0, 23.0, 23.0, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(347), 24.4, 0, 24.4, 24.4, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(348), 16.7, 0, 16.7, 16.7, 5.3);  // Month - 2007-12-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(349), 14.4, 0, 14.4, 14.4, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(350), 18.2, 0, 18.2, 18.2, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(351), 21.8, 0, 21.8, 21.8, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(352), 17.6, 0, 17.6, 17.6, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(353), 22.5, 0, 22.5, 22.5, 6.1);  // Month - 2007-12-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(354), 24.7, 0, 24.7, 24.7, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(355), 17.8, 0, 17.8, 17.8, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(356), 19.4, 0, 19.4, 19.4, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(357), 22.2, 0, 22.2, 22.2, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(358), 21.2, 0, 21.2, 21.2, 2.4);  // Month - 2007-12-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(359), 20.8, 0, 20.8, 20.8, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(360), 21.4, 0, 21.4, 21.4, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(361), 23.7, 0, 23.7, 23.7, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(362), 24.2, 0, 24.2, 24.2, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(363), 25.3, 0, 25.3, 25.3, 6.4);  // Month - 2007-12-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(364), 27.4, 0, 27.4, 27.4, 7.5);


            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(365), 24.3, 0, 24.3, 24.3, 4.2);  // Month - 2008-1-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(366), 27.2, 0, 27.2, 27.2, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(367), 25.7, 0, 25.7, 25.7, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(368), 19.3, 0, 19.3, 19.3, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(369), 20.4, 0, 20.4, 20.4, 5.4);  // Month - 2008-1-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(370), 22.8, 0, 22.8, 22.8, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(371), 26.9, 0, 26.9, 26.9, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(372), 28.5, 0, 28.5, 28.5, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(373), 26.0, 0, 26.0, 26.0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(374), 22.9, 0, 22.9, 22.9, 2.5);  // Month - 2008-1-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(375), 19.6, 0, 19.6, 19.6, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(376), 19.4, 0, 19.4, 19.4, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(377), 22.0, 0, 22.0, 22.0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(378), 24.8, 0, 24.8, 24.8, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(379), 27.8, 0, 27.8, 27.8, 6.6);  // Month - 2008-1-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(380), 20.2, 0, 20.2, 20.2, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(381), 18.7, 0, 18.7, 18.7, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(382), 20.5, 0, 20.5, 20.5, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(383), 17.4, 0, 17.4, 17.4, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(384), 18.9, 0, 18.9, 18.9, 4.1);  // Month - 2008-1-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(385), 22.1, 0, 22.1, 22.1, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(386), 21.0, 0, 21.0, 21.0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(387), 23.1, 0, 23.1, 23.1, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(388), 24.3, 0, 24.3, 24.3, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(389), 24.8, 0, 24.8, 24.8, 5.7);  // Month - 2008-1-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(390), 23.8, 0, 23.8, 23.8, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(391), 24.1, 0, 24.1, 24.1, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(392), 25.9, 0, 25.9, 25.9, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(393), 24.9, 0, 24.9, 24.9, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(394), 23.8, 0, 23.8, 23.8, 4.1);  // Month - 2008-1-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(395), 23.7, 0, 23.7, 23.7, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(396), 23.2, 0, 23.2, 23.2, 5.0);  // Month - 2008-2-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(397), 23.0, 0, 23.0, 23.0, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(398), 18.6, 0, 18.6, 18.6, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(399), 22.4, 0, 22.4, 22.4, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(400), 24.2, 0, 24.2, 24.2, 5.3);  // Month - 2008-2-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(401), 26.4, 0, 26.4, 26.4, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(402), 26.2, 0, 26.2, 26.2, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(403), 22.7, 0, 22.7, 22.7, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(404), 22.4, 0, 22.4, 22.4, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(405), 19.3, 0, 19.3, 19.3, 2.4);  // Month - 2008-2-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(406), 19.0, 0, 19.0, 19.0, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(407), 22.0, 0, 22.0, 22.0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(408), 22.4, 0, 22.4, 22.4, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(409), 23.7, 0, 23.7, 23.7, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(410), 25.5, 0, 25.5, 25.5, 5.1);  // Month - 2008-2-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(411), 24.4, 0, 24.4, 24.4, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(412), 24.8, 0, 24.8, 24.8, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(413), 23.5, 0, 23.5, 23.5, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(414), 24.1, 0, 24.1, 24.1, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(415), 24.3, 0, 24.3, 24.3, 4.7);  // Month - 2008-2-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(416), 25.0, 0, 25.0, 25.0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(417), 23.4, 0, 23.4, 23.4, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(418), 22.9, 0, 22.9, 22.9, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(419), 23.2, 0, 23.2, 23.2, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(420), 23.0, 0, 23.0, 23.0, 3.7);  // Month - 2008-2-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(421), 24.9, 0, 24.9, 24.9, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(422), 24.9, 0, 24.9, 24.9, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(423), 21.8, 0, 21.8, 21.8, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(424), 21.3, 0, 21.3, 21.3, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(425), 23.5, 0, 23.5, 23.5, 2.9);  // Month - 2008-3-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(426), 22.7, 0, 22.7, 22.7, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(427), 22.5, 0, 22.5, 22.5, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(428), 22.4, 0, 22.4, 22.4, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(429), 20.1, 0, 20.1, 20.1, 2.2);  // Month - 2008-3-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(430), 20.9, 0, 20.9, 20.9, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(431), 20.8, 0, 20.8, 20.8, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(432), 23.2, 0, 23.2, 23.2, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(433), 23.1, 0, 23.1, 23.1, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(434), 18.3, 0, 18.3, 18.3, 3.1);  // Month - 2008-3-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(435), 17.2, 0, 17.2, 17.2, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(436), 17.0, 0, 17.0, 17.0, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(437), 17.7, 0, 17.7, 17.7, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(438), 19.9, 0, 19.9, 19.9, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(439), 18.9, 0, 18.9, 18.9, 3.4);  // Month - 2008-3-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(440), 21.8, 0, 21.8, 21.8, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(441), 24.6, 0, 24.6, 24.6, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(442), 22.4, 0, 22.4, 22.4, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(443), 24.3, 0, 24.3, 24.3, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(444), 21.8, 0, 21.8, 21.8, 3.0);  // Month - 2008-3-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(445), 22.5, 0, 22.5, 22.5, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(446), 16.9, 0, 16.9, 16.9, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(447), 17.8, 0, 17.8, 17.8, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(448), 19.2, 0, 19.2, 19.2, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(449), 20.3, 0, 20.3, 20.3, 3.1);  // Month - 2008-3-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(450), 22.2, 0, 22.2, 22.2, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(451), 20.3, 0, 20.3, 20.3, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(452), 19.6, 0, 19.6, 19.6, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(453), 19.7, 0, 19.7, 19.7, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(454), 17.9, 0, 17.9, 17.9, 2.7);  // Month - 2008-3-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(455), 19.7, 0, 19.7, 19.7, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(456), 19.5, 0, 19.5, 19.5, 1.6);  // Month - 2008-4-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(457), 16.6, 0, 16.6, 16.6, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(458), 15.0, 0, 15.0, 15.0, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(459), 18.5, 0, 18.5, 18.5, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(460), 21.0, 0, 21.0, 21.0, 2.7);  // Month - 2008-4-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(461), 21.7, 0, 21.7, 21.7, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(462), 21.3, 0, 21.3, 21.3, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(463), 19.3, 0, 19.3, 19.3, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(464), 19.2, 0, 19.2, 19.2, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(465), 21.6, 0, 21.6, 21.6, 2.3);  // Month - 2008-4-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(466), 20.3, 0, 20.3, 20.3, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(467), 12.5, 0, 12.5, 12.5, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(468), 11.6, 0, 11.6, 11.6, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(469), 10.5, 0, 10.5, 10.5, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(470), 10.7, 0, 10.7, 10.7, 1.6);  // Month - 2008-4-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(471), 13.3, 0, 13.3, 13.3, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(472), 16.8, 0, 16.8, 16.8, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(473), 18.9, 0, 18.9, 18.9, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(474), 19.0, 0, 19.0, 19.0, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(475), 20.4, 0, 20.4, 20.4, 2.7);  // Month - 2008-4-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(476), 20.3, 0, 20.3, 20.3, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(477), 20.4, 0, 20.4, 20.4, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(478), 19.2, 0, 19.2, 19.2, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(479), 18.9, 0, 18.9, 18.9, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(480), 15.7, 0, 15.7, 15.7, 1.6);  // Month - 2008-4-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(481), 14.4, 0, 14.4, 14.4, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(482), 16.0, 0, 16.0, 16.0, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(483), 16.4, 0, 16.4, 16.4, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(484), 11.6, 0, 11.6, 11.6, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(485), 10.5, 0, 10.5, 10.5, 1.0);  // Month - 2008-4-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(486), 10.4, 0, 10.4, 10.4, 0.8);  // Month - 2008-5-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(487), 11.5, 0, 11.5, 11.5, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(488), 14.4, 0, 14.4, 14.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(489), 12.7, 0, 12.7, 12.7, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(490), 11.0, 0, 11.0, 11.0, 0.7);  // Month - 2008-5-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(491), 14.0, 0, 14.0, 14.0, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(492), 13.4, 0, 13.4, 13.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(493), 10.6, 0, 10.6, 10.6, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(494), 11.0, 0, 11.0, 11.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(495), 10.9, 0, 10.9, 10.9, 0.8);  // Month - 2008-5-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(496), 12.2, 0, 12.2, 12.2, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(497), 13.9, 0, 13.9, 13.9, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(498), 14.4, 0, 14.4, 14.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(499), 15.4, 0, 15.4, 15.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(500), 18.0, 0, 18.0, 18.0, 1.4);  // Month - 2008-5-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(501), 14.6, 0, 14.6, 14.6, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(502), 19.5, 0, 19.5, 19.5, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(503), 20.9, 0, 20.9, 20.9, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(504), 22.7, 0, 22.7, 22.7, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(505), 19.5, 0, 19.5, 19.5, 0.6);  // Month - 2008-5-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(506), 18.7, 0, 18.7, 18.7, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(507), 17.2, 0, 17.2, 17.2, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(508), 18.2, 0, 18.2, 18.2, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(509), 14.3, 0, 14.3, 14.3, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(510), 16.0, 0, 16.0, 16.0, 0.5);  // Month - 2008-5-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(511), 13.8, 0, 13.8, 13.8, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(512), 13.8, 0, 13.8, 13.8, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(513), 11.0, 0, 11.0, 11.0, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(514), 08.0, 0, 08.0, 08.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(515), 07.3, 0, 07.3, 07.3, 0.3);  // Month - 2008-5-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(516), 07.1, 0, 07.1, 07.1, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(517), 07.0, 0, 07.0, 07.0, 0.2);  // Month - 2008-6-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(518), 08.4, 0, 08.4, 08.4, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(519), 09.1, 0, 09.1, 09.1, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(520), 11.5, 0, 11.5, 11.5, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(521), 14.4, 0, 14.4, 14.4, 0.4);  // Month - 2008-6-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(522), 10.6, 0, 10.6, 10.6, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(523), 10.5, 0, 10.5, 10.5, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(524), 11.0, 0, 11.0, 11.0, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(525), 09.9, 0, 09.9, 09.9, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(526), 09.4, 0, 09.4, 09.4, 0.4);  // Month - 2008-6-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(527), 11.6, 0, 11.6, 11.6, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(528), 09.1, 0, 09.1, 09.1, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(529), 11.2, 0, 11.2, 11.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(530), 10.5, 0, 10.5, 10.5, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(531), 08.2, 0, 08.2, 08.2, 0.7);  // Month - 2008-6-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(532), 08.0, 0, 08.0, 08.0, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(533), 10.0, 0, 10.0, 10.0, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(534), 07.4, 0, 07.4, 07.4, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(535), 11.0, 0, 11.0, 11.0, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(536), 11.1, 0, 11.1, 11.1, 0.3);  // Month - 2008-6-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(537), 10.8, 0, 10.8, 10.8, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(538), 08.9, 0, 08.9, 08.9, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(539), 09.1, 0, 09.1, 09.1, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(540), 08.4, 0, 08.4, 08.4, 0.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(541), 10.8, 0, 10.8, 10.8, 0.3);  // Month - 2008-6-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(542), 12.6, 0, 12.6, 12.6, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(543), 11.7, 0, 11.7, 11.7, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(544), 10.3, 0, 10.3, 10.3, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(545), 11.4, 0, 11.4, 11.4, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(546), 14.1, 0, 14.1, 14.1, 0.4);  // Month - 2008-6-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(547), 10.6, 0, 10.6, 10.6, 0.4);  // Month - 2008-7-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(548), 09.7, 0, 09.7, 09.7, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(549), 10.2, 0, 10.2, 10.2, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(550), 09.4, 0, 09.4, 09.4, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(551), 20.3, 0, 20.3, 20.3, 1.1);  // Month - 2008-7-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(552), 16.8, 0, 16.8, 16.8, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(553), 16.0, 0, 16.0, 16.0, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(554), 13.1, 0, 13.1, 13.1, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(555), 13.2, 0, 13.2, 13.2, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(556), 13.9, 0, 13.9, 13.9, 0.4);  // Month - 2008-7-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(557), 17.2, 0, 17.2, 17.2, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(558), 18.9, 0, 18.9, 18.9, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(559), 14.8, 0, 14.8, 14.8, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(560), 14.0, 0, 14.0, 14.0, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(561), 22.5, 0, 22.5, 22.5, 1.4);  // Month - 2008-7-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(562), 19.2, 0, 19.2, 19.2, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(563), 19.2, 0, 19.2, 19.2, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(564), 10.5, 0, 10.5, 10.5, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(565), 09.1, 0, 09.1, 09.1, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(566), 08.0, 0, 08.0, 08.0, 0.8);  // Month - 2008-7-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(567), 10.2, 0, 10.2, 10.2, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(568), 10.5, 0, 10.5, 10.5, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(569), 10.6, 0, 10.6, 10.6, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(570), 10.2, 0, 10.2, 10.2, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(571), 09.2, 0, 09.2, 09.2, 0.4);  // Month - 2008-7-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(572), 09.3, 0, 09.3, 09.3, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(573), 12.0, 0, 12.0, 12.0, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(574), 14.5, 0, 14.5, 14.5, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(575), 14.8, 0, 14.8, 14.8, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(576), 13.6, 0, 13.6, 13.6, 0.5);  // Month - 2008-7-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(577), 10.5, 0, 10.5, 10.5, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(578), 10.5, 0, 10.5, 10.5, 0.4);  // Month - 2008-8-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(579), 10.9, 0, 10.9, 10.9, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(580), 07.3, 0, 07.3, 07.3, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(581), 09.8, 0, 09.8, 09.8, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(582), 08.8, 0, 08.8, 08.8, 0.8);  // Month - 2008-8-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(583), 09.3, 0, 09.3, 09.3, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(584), 08.5, 0, 08.5, 08.5, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(585), 06.9, 0, 06.9, 06.9, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(586), 08.1, 0, 08.1, 08.1, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(587), 13.9, 0, 13.9, 13.9, 1.5);  // Month - 2008-8-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(588), 16.4, 0, 16.4, 16.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(589), 07.6, 0, 07.6, 07.6, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(590), 08.2, 0, 08.2, 08.2, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(591), 11.1, 0, 11.1, 11.1, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(592), 15.4, 0, 15.4, 15.4, 0.8);  // Month - 2008-8-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(593), 17.7, 0, 17.7, 17.7, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(594), 09.1, 0, 09.1, 09.1, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(595), 07.9, 0, 07.9, 07.9, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(596), 11.6, 0, 11.6, 11.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(597), 14.3, 0, 14.3, 14.3, 0.6);  // Month - 2008-8-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(598), 09.6, 0, 09.6, 09.6, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(599), 09.5, 0, 09.5, 09.5, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(600), 10.2, 0, 10.2, 10.2, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(601), 11.6, 0, 11.6, 11.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(602), 13.2, 0, 13.2, 13.2, 1.2);  // Month - 2008-8-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(603), 13.3, 0, 13.3, 13.3, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(604), 16.9, 0, 16.9, 16.9, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(605), 11.3, 0, 11.3, 11.3, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(606), 10.5, 0, 10.5, 10.5, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(607), 12.4, 0, 12.4, 12.4, 2.0);  // Month - 2008-8-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(608), 14.9, 0, 14.9, 14.9, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(609), 16.0, 0, 16.0, 16.0, 1.6);  // Month - 2008-9-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(610), 17.6, 0, 17.6, 17.6, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(611), 10.3, 0, 10.3, 10.3, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(612), 08.5, 0, 08.5, 08.5, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(613), 06.6, 0, 06.6, 06.6, 1.0);  // Month - 2008-9-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(614), 08.0, 0, 08.0, 08.0, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(615), 11.4, 0, 11.4, 11.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(616), 10.6, 0, 10.6, 10.6, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(617), 12.3, 0, 12.3, 12.3, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(618), 13.1, 0, 13.1, 13.1, 1.3);  // Month - 2008-9-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(619), 13.5, 0, 13.5, 13.5, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(620), 09.3, 0, 09.3, 09.3, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(621), 08.3, 0, 08.3, 08.3, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(622), 10.5, 0, 10.5, 10.5, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(623), 10.0, 0, 10.0, 10.0, 1.3);  // Month - 2008-9-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(624), 11.7, 0, 11.7, 11.7, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(625), 11.7, 0, 11.7, 11.7, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(626), 13.6, 0, 13.6, 13.6, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(627), 14.3, 0, 14.3, 14.3, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(628), 12.1, 0, 12.1, 12.1, 1.1);  // Month - 2008-9-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(629), 13.2, 0, 13.2, 13.2, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(630), 15.5, 0, 15.5, 15.5, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(631), 13.2, 0, 13.2, 13.2, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(632), 14.4, 0, 14.4, 14.4, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(633), 16.0, 0, 16.0, 16.0, 2.5);  // Month - 2008-9-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(634), 17.9, 0, 17.9, 17.9, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(635), 18.3, 0, 18.3, 18.3, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(636), 18.3, 0, 18.3, 18.3, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(637), 17.2, 0, 17.2, 17.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(638), 13.6, 0, 13.6, 13.6, 1.0);  // Month - 2008-9-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(639), 16.5, 0, 16.5, 16.5, 1.5);  // Month - 2008-10-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(640), 16.6, 0, 16.6, 16.6, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(641), 15.9, 0, 15.9, 15.9, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(642), 12.1, 0, 12.1, 12.1, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(643), 11.5, 0, 11.5, 11.5, 3.0);  // Month - 2008-10-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(644), 16.3, 0, 16.3, 16.3, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(645), 09.5, 0, 09.5, 09.5, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(646), 09.4, 0, 09.4, 09.4, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(647), 14.1, 0, 14.1, 14.1, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(648), 18.0, 0, 18.0, 18.0, 3.3);  // Month - 2008-10-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(649), 21.3, 0, 21.3, 21.3, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(650), 18.2, 0, 18.2, 18.2, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(651), 17.6, 0, 17.6, 17.6, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(652), 15.9, 0, 15.9, 15.9, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(653), 14.0, 0, 14.0, 14.0, 1.3);  // Month - 2008-10-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(654), 13.2, 0, 13.2, 13.2, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(655), 12.5, 0, 12.5, 12.5, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(656), 15.4, 0, 15.4, 15.4, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(657), 17.1, 0, 17.1, 17.1, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(658), 21.6, 0, 21.6, 21.6, 4.6);  // Month - 2008-10-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(659), 19.7, 0, 19.7, 19.7, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(660), 15.5, 0, 15.5, 15.5, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(661), 16.4, 0, 16.4, 16.4, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(662), 20.1, 0, 20.1, 20.1, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(663), 19.0, 0, 19.0, 19.0, 3.0);  // Month - 2008-10-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(664), 18.4, 0, 18.4, 18.4, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(665), 14.9, 0, 14.9, 14.9, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(666), 17.0, 0, 17.0, 17.0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(667), 17.4, 0, 17.4, 17.4, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(668), 14.5, 0, 14.5, 14.5, 3.6);  // Month - 2008-10-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(669), 17.5, 0, 17.5, 17.5, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(670), 19.9, 0, 19.9, 19.9, 4.6);  // Month - 2008-11-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(671), 18.3, 0, 18.3, 18.3, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(672), 20.6, 0, 20.6, 20.6, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(673), 23.4, 0, 23.4, 23.4, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(674), 26.7, 0, 26.7, 26.7, 5.4);  // Month - 2008-11-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(675), 21.7, 0, 21.7, 21.7, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(676), 21.6, 0, 21.6, 21.6, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(677), 23.5, 0, 23.5, 23.5, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(678), 22.7, 0, 22.7, 22.7, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(679), 20.7, 0, 20.7, 20.7, 4.8);  // Month - 2008-11-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(680), 23.0, 0, 23.0, 23.0, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(681), 22.1, 0, 22.1, 22.1, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(682), 21.7, 0, 21.7, 21.7, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(683), 22.4, 0, 22.4, 22.4, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(684), 16.3, 0, 16.3, 16.3, 3.8);  // Month - 2008-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(685), 15.3, 0, 15.3, 15.3, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(686), 16.9, 0, 16.9, 16.9, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(687), 17.9, 0, 17.9, 17.9, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(688), 17.1, 0, 17.1, 17.1, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(689), 19.3, 0, 19.3, 19.3, 5.6);  // Month - 2008-11-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(690), 20.6, 0, 20.6, 20.6, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(691), 23.7, 0, 23.7, 23.7, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(692), 25.3, 0, 25.3, 25.3, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(693), 26.3, 0, 26.3, 26.3, 7.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(694), 28.1, 0, 28.1, 28.1, 6.4);  // Month - 2008-11-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(695), 26.3, 0, 26.3, 26.3, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(696), 28.4, 0, 28.4, 28.4, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(697), 27.1, 0, 27.1, 27.1, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(698), 28.4, 0, 28.4, 28.4, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(699), 27.1, 0, 27.1, 27.1, 3.1);  // Month - 2008-11-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(700), 23.1, 0, 23.1, 23.1, 2.0);  // Month - 2008-12-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(701), 22.0, 0, 22.0, 22.0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(702), 18.3, 0, 18.3, 18.3, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(703), 16.4, 0, 16.4, 16.4, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(704), 18.1, 0, 18.1, 18.1, 4.8);  // Month - 2008-12-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(705), 21.8, 0, 21.8, 21.8, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(706), 25.3, 0, 25.3, 25.3, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(707), 27.3, 0, 27.3, 27.3, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(708), 26.4, 0, 26.4, 26.4, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(709), 22.5, 0, 22.5, 22.5, 4.1);  // Month - 2008-12-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(710), 20.2, 0, 20.2, 20.2, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(711), 20.8, 0, 20.8, 20.8, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(712), 21.7, 0, 21.7, 21.7, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(713), 22.1, 0, 22.1, 22.1, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(714), 22.2, 0, 22.2, 22.2, 6.0);  // Month - 2008-12-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(715), 24.8, 0, 24.8, 24.8, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(716), 24.1, 0, 24.1, 24.1, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(717), 23.8, 0, 23.8, 23.8, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(718), 24.0, 0, 24.0, 24.0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(719), 26.8, 0, 26.8, 26.8, 7.6);  // Month - 2008-12-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(720), 24.3, 0, 24.3, 24.3, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(721), 21.1, 0, 21.1, 21.1, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(722), 22.5, 0, 22.5, 22.5, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(723), 23.5, 0, 23.5, 23.5, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(724), 22.4, 0, 22.4, 22.4, 4.3);  // Month - 2008-12-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(725), 20.8, 0, 20.8, 20.8, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(726), 26.0, 0, 26.0, 26.0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(727), 25.8, 0, 25.8, 25.8, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(728), 16.6, 0, 16.6, 16.6, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(729), 19.0, 0, 19.0, 19.0, 5.9);  // Month - 2008-12-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(730), 19.7, 0, 19.7, 19.7, 3.8);


            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(731), 18.5, 0, 18.5, 18.5, 5.0);  // Month - 2009-1-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(732), 19.6, 0, 19.6, 19.6, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(733), 19.9, 0, 19.9, 19.9, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(734), 21.4, 0, 21.4, 21.4, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(735), 26.4, 0, 26.4, 26.4, 8.0);  // Month - 2009-1-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(736), 26.2, 0, 26.2, 26.2, 8.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(737), 23.3, 0, 23.3, 23.3, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(738), 23.3, 0, 23.3, 23.3, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(739), 24.5, 0, 24.5, 24.5, 7.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(740), 23.8, 0, 23.8, 23.8, 6.9);  // Month - 2009-1-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(741), 23.0, 0, 23.0, 23.0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(742), 22.7, 0, 22.7, 22.7, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(743), 23.6, 0, 23.6, 23.6, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(744), 23.2, 0, 23.2, 23.2, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(745), 23.5, 0, 23.5, 23.5, 6.0);  // Month - 2009-1-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(746), 25.8, 0, 25.8, 25.8, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(747), 28.7, 0, 28.7, 28.7, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(748), 18.9, 0, 18.9, 18.9, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(749), 17.4, 0, 17.4, 17.4, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(750), 22.0, 0, 22.0, 22.0, 6.3);  // Month - 2009-1-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(751), 25.2, 0, 25.2, 25.2, 7.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(752), 26.0, 0, 26.0, 26.0, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(753), 27.1, 0, 27.1, 27.1, 8.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(754), 27.5, 0, 27.5, 27.5, 7.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(755), 25.9, 0, 25.9, 25.9, 4.3);  // Month - 2009-1-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(756), 23.2, 0, 23.2, 23.2, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(757), 23.2, 0, 23.2, 23.2, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(758), 23.7, 0, 23.7, 23.7, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(759), 20.8, 0, 20.8, 20.8, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(760), 20.7, 0, 20.7, 20.7, 1.6);  // Month - 2009-1-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(761), 21.5, 0, 21.5, 21.5, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(762), 18.6, 0, 18.6, 18.6, 5.1);  // Month - 2009-2-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(763), 21.5, 0, 21.5, 21.5, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(764), 23.2, 0, 23.2, 23.2, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(765), 23.0, 0, 23.0, 23.0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(766), 23.0, 0, 23.0, 23.0, 3.6);  // Month - 2009-2-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(767), 22.2, 0, 22.2, 22.2, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(768), 19.8, 0, 19.8, 19.8, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(769), 21.5, 0, 21.5, 21.5, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(770), 23.9, 0, 23.9, 23.9, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(771), 26.8, 0, 26.8, 26.8, 4.3);  // Month - 2009-2-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(772), 19.2, 0, 19.2, 19.2, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(773), 19.9, 0, 19.9, 19.9, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(774), 23.2, 0, 23.2, 23.2, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(775), 24.7, 0, 24.7, 24.7, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(776), 24.6, 0, 24.6, 24.6, 5.6);  // Month - 2009-2-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(777), 24.3, 0, 24.3, 24.3, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(778), 23.7, 0, 23.7, 23.7, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(779), 25.9, 0, 25.9, 25.9, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(780), 27.8, 0, 27.8, 27.8, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(781), 26.7, 0, 26.7, 26.7, 2.9);  // Month - 2009-2-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(782), 22.7, 0, 22.7, 22.7, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(783), 18.8, 0, 18.8, 18.8, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(784), 19.0, 0, 19.0, 19.0, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(785), 19.9, 0, 19.9, 19.9, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(786), 21.3, 0, 21.3, 21.3, 3.8);  // Month - 2009-2-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(787), 21.3, 0, 21.3, 21.3, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(788), 22.5, 0, 22.5, 22.5, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(789), 22.2, 0, 22.2, 22.2, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(790), 25.9, 0, 25.9, 25.9, 3.7);  // Month - 2009-3-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(791), 23.0, 0, 23.0, 23.0, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(792), 21.5, 0, 21.5, 21.5, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(793), 20.5, 0, 20.5, 20.5, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(794), 22.1, 0, 22.1, 22.1, 3.2);  // Month - 2009-3-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(795), 21.5, 0, 21.5, 21.5, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(796), 21.5, 0, 21.5, 21.5, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(797), 20.9, 0, 20.9, 20.9, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(798), 21.3, 0, 21.3, 21.3, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(799), 23.1, 0, 23.1, 23.1, 3.8);  // Month - 2009-3-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(800), 21.3, 0, 21.3, 21.3, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(801), 21.5, 0, 21.5, 21.5, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(802), 21.0, 0, 21.0, 21.0, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(803), 25.6, 0, 25.6, 25.6, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(804), 16.7, 0, 16.7, 16.7, 4.0);  // Month - 2009-3-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(805), 16.6, 0, 16.6, 16.6, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(806), 18.6, 0, 18.6, 18.6, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(807), 20.0, 0, 20.0, 20.0, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(808), 20.1, 0, 20.1, 20.1, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(809), 22.0, 0, 22.0, 22.0, 2.8);  // Month - 2009-3-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(810), 22.9, 0, 22.9, 22.9, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(811), 23.5, 0, 23.5, 23.5, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(812), 23.2, 0, 23.2, 23.2, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(813), 22.5, 0, 22.5, 22.5, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(814), 20.7, 0, 20.7, 20.7, 2.8);  // Month - 2009-3-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(815), 22.0, 0, 22.0, 22.0, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(816), 21.5, 0, 21.5, 21.5, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(817), 22.8, 0, 22.8, 22.8, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(818), 25.1, 0, 25.1, 25.1, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(819), 22.3, 0, 22.3, 22.3, 3.1);  // Month - 2009-3-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(820), 17.7, 0, 17.7, 17.7, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(821), 15.6, 0, 15.6, 15.6, 2.5);  // Month - 2009-4-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(822), 14.7, 0, 14.7, 14.7, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(823), 20.1, 0, 20.1, 20.1, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(824), 16.5, 0, 16.5, 16.5, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(825), 17.4, 0, 17.4, 17.4, 2.3);  // Month - 2009-4-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(826), 18.7, 0, 18.7, 18.7, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(827), 19.5, 0, 19.5, 19.5, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(828), 15.2, 0, 15.2, 15.2, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(829), 14.5, 0, 14.5, 14.5, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(830), 17.0, 0, 17.0, 17.0, 2.6);  // Month - 2009-4-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(831), 19.9, 0, 19.9, 19.9, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(832), 21.7, 0, 21.7, 21.7, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(833), 22.0, 0, 22.0, 22.0, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(834), 12.9, 0, 12.9, 12.9, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(835), 13.0, 0, 13.0, 13.0, 1.7);  // Month - 2009-4-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(836), 17.5, 0, 17.5, 17.5, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(837), 19.9, 0, 19.9, 19.9, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(838), 16.8, 0, 16.8, 16.8, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(839), 13.8, 0, 13.8, 13.8, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(840), 14.8, 0, 14.8, 14.8, 1.6);  // Month - 2009-4-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(841), 15.4, 0, 15.4, 15.4, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(842), 19.7, 0, 19.7, 19.7, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(843), 19.5, 0, 19.5, 19.5, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(844), 16.2, 0, 16.2, 16.2, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(845), 17.0, 0, 17.0, 17.0, 1.2);  // Month - 2009-4-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(846), 15.1, 0, 15.1, 15.1, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(847), 16.4, 0, 16.4, 16.4, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(848), 20.7, 0, 20.7, 20.7, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(849), 19.0, 0, 19.0, 19.0, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(850), 15.8, 0, 15.8, 15.8, 1.4);  // Month - 2009-4-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(851), 14.5, 0, 14.5, 14.5, 1.3);  // Month - 2009-5-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(852), 15.9, 0, 15.9, 15.9, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(853), 16.1, 0, 16.1, 16.1, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(854), 18.8, 0, 18.8, 18.8, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(855), 13.3, 0, 13.3, 13.3, 0.8);  // Month - 2009-5-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(856), 13.6, 0, 13.6, 13.6, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(857), 14.3, 0, 14.3, 14.3, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(858), 15.6, 0, 15.6, 15.6, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(859), 16.3, 0, 16.3, 16.3, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(860), 18.1, 0, 18.1, 18.1, 1.5);  // Month - 2009-5-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(861), 17.5, 0, 17.5, 17.5, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(862), 14.3, 0, 14.3, 14.3, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(863), 14.2, 0, 14.2, 14.2, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(864), 12.6, 0, 12.6, 12.6, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(865), 09.2, 0, 09.2, 09.2, 0.7);  // Month - 2009-5-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(866), 09.9, 0, 09.9, 09.9, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(867), 13.0, 0, 13.0, 13.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(868), 12.4, 0, 12.4, 12.4, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(869), 09.3, 0, 09.3, 09.3, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(870), 16.2, 0, 16.2, 16.2, 0.6);  // Month - 2009-5-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(871), 22.5, 0, 22.5, 22.5, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(872), 23.0, 0, 23.0, 23.0, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(873), 22.5, 0, 22.5, 22.5, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(874), 21.4, 0, 21.4, 21.4, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(875), 19.4, 0, 19.4, 19.4, 0.6);  // Month - 2009-5-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(876), 11.1, 0, 11.1, 11.1, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(877), 09.4, 0, 09.4, 09.4, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(878), 10.2, 0, 10.2, 10.2, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(879), 09.3, 0, 09.3, 09.3, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(880), 08.2, 0, 08.2, 08.2, 0.4);  // Month - 2009-5-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(881), 11.6, 0, 11.6, 11.6, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(882), 10.9, 0, 10.9, 10.9, 0.6);  // Month - 2009-6-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(883), 09.0, 0, 09.0, 09.0, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(884), 07.4, 0, 07.4, 07.4, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(885), 12.6, 0, 12.6, 12.6, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(886), 11.1, 0, 11.1, 11.1, 0.4);  // Month - 2009-6-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(887), 10.5, 0, 10.5, 10.5, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(888), 10.1, 0, 10.1, 10.1, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(889), 08.2, 0, 08.2, 08.2, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(890), 05.1, 0, 05.1, 05.1, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(891), 09.5, 0, 09.5, 09.5, 0.2);  // Month - 2009-6-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(892), 06.8, 0, 06.8, 06.8, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(893), 06.0, 0, 06.0, 06.0, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(894), 09.6, 0, 09.6, 09.6, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(895), 13.4, 0, 13.4, 13.4, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(896), 13.0, 0, 13.0, 13.0, 0.4);  // Month - 2009-6-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(897), 08.1, 0, 08.1, 08.1, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(898), 09.3, 0, 09.3, 09.3, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(899), 11.0, 0, 11.0, 11.0, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(900), 15.3, 0, 15.3, 15.3, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(901), 15.3, 0, 15.3, 15.3, 0.7);  // Month - 2009-6-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(902), 09.8, 0, 09.8, 09.8, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(903), 08.0, 0, 08.0, 08.0, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(904), 07.0, 0, 07.0, 07.0, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(905), 06.1, 0, 06.1, 06.1, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(906), 06.5, 0, 06.5, 06.5, 0.2);  // Month - 2009-6-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(907), 06.6, 0, 06.6, 06.6, 0.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(908), 07.9, 0, 07.9, 07.9, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(909), 08.8, 0, 08.8, 08.8, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(910), 12.4, 0, 12.4, 12.4, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(911), 10.4, 0, 10.4, 10.4, 0.4);  // Month - 2009-6-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(912), 11.2, 0, 11.2, 11.2, 0.4);  // Month - 2009-7-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(913), 09.3, 0, 09.3, 09.3, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(914), 10.4, 0, 10.4, 10.4, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(915), 11.1, 0, 11.1, 11.1, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(916), 14.7, 0, 14.7, 14.7, 1.0);  // Month - 2009-7-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(917), 13.9, 0, 13.9, 13.9, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(918), 15.3, 0, 15.3, 15.3, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(919), 06.8, 0, 06.8, 06.8, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(920), 06.2, 0, 06.2, 06.2, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(921), 06.0, 0, 06.0, 06.0, 0.5);  // Month - 2009-7-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(922), 06.5, 0, 06.5, 06.5, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(923), 09.6, 0, 09.6, 09.6, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(924), 08.2, 0, 08.2, 08.2, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(925), 06.5, 0, 06.5, 06.5, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(926), 05.9, 0, 05.9, 05.9, 0.5);  // Month - 2009-7-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(927), 09.0, 0, 09.0, 09.0, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(928), 11.6, 0, 11.6, 11.6, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(929), 12.0, 0, 12.0, 12.0, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(930), 14.4, 0, 14.4, 14.4, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(931), 12.6, 0, 12.6, 12.6, 0.7);  // Month - 2009-7-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(932), 13.2, 0, 13.2, 13.2, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(933), 07.6, 0, 07.6, 07.6, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(934), 05.4, 0, 05.4, 05.4, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(935), 06.3, 0, 06.3, 06.3, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(936), 06.7, 0, 06.7, 06.7, 0.8);  // Month - 2009-7-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(937), 06.4, 0, 06.4, 06.4, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(938), 09.0, 0, 09.0, 09.0, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(939), 05.6, 0, 05.6, 05.6, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(940), 05.3, 0, 05.3, 05.3, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(941), 04.0, 0, 04.0, 04.0, 0.4);  // Month - 2009-7-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(942), 03.1, 0, 03.1, 03.1, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(943), 07.5, 0, 07.5, 07.5, 0.6);  // Month - 2009-8-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(944), 11.1, 0, 11.1, 11.1, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(945), 10.0, 0, 10.0, 10.0, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(946), 13.4, 0, 13.4, 13.4, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(947), 12.6, 0, 12.6, 12.6, 0.8);  // Month - 2009-8-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(948), 08.9, 0, 08.9, 08.9, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(949), 08.3, 0, 08.3, 08.3, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(950), 07.3, 0, 07.3, 07.3, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(951), 07.0, 0, 07.0, 07.0, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(952), 10.1, 0, 10.1, 10.1, 1.2);  // Month - 2009-8-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(953), 12.6, 0, 12.6, 12.6, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(954), 14.3, 0, 14.3, 14.3, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(955), 14.8, 0, 14.8, 14.8, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(956), 19.0, 0, 19.0, 19.0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(957), 24.7, 0, 24.7, 24.7, 2.9);  // Month - 2009-8-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(958), 14.3, 0, 14.3, 14.3, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(959), 10.1, 0, 10.1, 10.1, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(960), 10.3, 0, 10.3, 10.3, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(961), 10.0, 0, 10.0, 10.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(962), 08.8, 0, 08.8, 08.8, 0.8);  // Month - 2009-8-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(963), 07.8, 0, 07.8, 07.8, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(964), 12.3, 0, 12.3, 12.3, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(965), 11.6, 0, 11.6, 11.6, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(966), 13.1, 0, 13.1, 13.1, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(967), 17.0, 0, 17.0, 17.0, 1.8);  // Month - 2009-8-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(968), 19.7, 0, 19.7, 19.7, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(969), 20.9, 0, 20.9, 20.9, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(970), 20.2, 0, 20.2, 20.2, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(971), 22.5, 0, 22.5, 22.5, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(972), 23.3, 0, 23.3, 23.3, 3.0);  // Month - 2009-8-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(973), 15.4, 0, 15.4, 15.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(974), 13.7, 0, 13.7, 13.7, 0.8);  // Month - 2009-9-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(975), 13.5, 0, 13.5, 13.5, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(976), 14.0, 0, 14.0, 14.0, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(977), 12.3, 0, 12.3, 12.3, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(978), 11.6, 0, 11.6, 11.6, 1.1);  // Month - 2009-9-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(979), 15.2, 0, 15.2, 15.2, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(980), 13.6, 0, 13.6, 13.6, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(981), 09.7, 0, 09.7, 09.7, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(982), 07.2, 0, 07.2, 07.2, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(983), 07.7, 0, 07.7, 07.7, 1.5);  // Month - 2009-9-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(984), 09.2, 0, 09.2, 09.2, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(985), 11.3, 0, 11.3, 11.3, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(986), 12.3, 0, 12.3, 12.3, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(987), 15.2, 0, 15.2, 15.2, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(988), 15.9, 0, 15.9, 15.9, 1.9);  // Month - 2009-9-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(989), 14.1, 0, 14.1, 14.1, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(990), 12.0, 0, 12.0, 12.0, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(991), 14.3, 0, 14.3, 14.3, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(992), 12.0, 0, 12.0, 12.0, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(993), 12.6, 0, 12.6, 12.6, 2.5);  // Month - 2009-9-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(994), 14.6, 0, 14.6, 14.6, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(995), 14.3, 0, 14.3, 14.3, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(996), 09.8, 0, 09.8, 09.8, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(997), 10.0, 0, 10.0, 10.0, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(998), 12.0, 0, 12.0, 12.0, 2.3);  // Month - 2009-9-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(999), 15.8, 0, 15.8, 15.8, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1000), 12.2, 0, 12.2, 12.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1001), 08.9, 0, 08.9, 08.9, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1002), 09.3, 0, 09.3, 09.3, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1003), 09.8, 0, 09.8, 09.8, 2.1);  // Month - 2009-9-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1004), 10.4, 0, 10.4, 10.4, 0.9);  // Month - 2009-10-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1005), 12.5, 0, 12.5, 12.5, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1006), 14.7, 0, 14.7, 14.7, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1007), 16.9, 0, 16.9, 16.9, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1008), 17.5, 0, 17.5, 17.5, 1.7);  // Month - 2009-10-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1009), 13.6, 0, 13.6, 13.6, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1010), 10.2, 0, 10.2, 10.2, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1011), 10.3, 0, 10.3, 10.3, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1012), 12.4, 0, 12.4, 12.4, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1013), 17.4, 0, 17.4, 17.4, 3.3);  // Month - 2009-10-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1014), 13.3, 0, 13.3, 13.3, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1015), 12.4, 0, 12.4, 12.4, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1016), 16.5, 0, 16.5, 16.5, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1017), 09.4, 0, 09.4, 09.4, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1018), 08.3, 0, 08.3, 08.3, 2.6);  // Month - 2009-10-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1019), 12.1, 0, 12.1, 12.1, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1020), 14.7, 0, 14.7, 14.7, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1021), 14.7, 0, 14.7, 14.7, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1022), 17.8, 0, 17.8, 17.8, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1023), 17.0, 0, 17.0, 17.0, 3.1);  // Month - 2009-10-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1024), 13.6, 0, 13.6, 13.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1025), 16.3, 0, 16.3, 16.3, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1026), 20.8, 0, 20.8, 20.8, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1027), 13.3, 0, 13.3, 13.3, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1028), 14.4, 0, 14.4, 14.4, 3.7);  // Month - 2009-10-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1029), 11.6, 0, 11.6, 11.6, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1030), 13.6, 0, 13.6, 13.6, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1031), 19.2, 0, 19.2, 19.2, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1032), 23.2, 0, 23.2, 23.2, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1033), 21.9, 0, 21.9, 21.9, 2.2);  // Month - 2009-10-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1034), 17.9, 0, 17.9, 17.9, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1035), 19.9, 0, 19.9, 19.9, 1.5);  // Month - 2009-11-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1036), 19.1, 0, 19.1, 19.1, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1037), 15.9, 0, 15.9, 15.9, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1038), 16.0, 0, 16.0, 16.0, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1039), 19.1, 0, 19.1, 19.1, 3.8);  // Month - 2009-11-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1040), 20.7, 0, 20.7, 20.7, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1041), 12.9, 0, 12.9, 12.9, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1042), 15.4, 0, 15.4, 15.4, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1043), 16.5, 0, 16.5, 16.5, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1044), 15.6, 0, 15.6, 15.6, 4.5);  // Month - 2009-11-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1045), 18.6, 0, 18.6, 18.6, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1046), 20.6, 0, 20.6, 20.6, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1047), 23.5, 0, 23.5, 23.5, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1048), 19.2, 0, 19.2, 19.2, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1049), 19.4, 0, 19.4, 19.4, 3.8);  // Month - 2009-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1050), 20.9, 0, 20.9, 20.9, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1051), 19.8, 0, 19.8, 19.8, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1052), 19.0, 0, 19.0, 19.0, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1053), 18.7, 0, 18.7, 18.7, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1054), 18.7, 0, 18.7, 18.7, 4.7);  // Month - 2009-11-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1055), 18.9, 0, 18.9, 18.9, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1056), 20.2, 0, 20.2, 20.2, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1057), 22.0, 0, 22.0, 22.0, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1058), 24.0, 0, 24.0, 24.0, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1059), 24.3, 0, 24.3, 24.3, 4.2);  // Month - 2009-11-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1060), 20.9, 0, 20.9, 20.9, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1061), 17.0, 0, 17.0, 17.0, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1062), 19.9, 0, 19.9, 19.9, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1063), 21.7, 0, 21.7, 21.7, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1064), 19.4, 0, 19.4, 19.4, 4.5);  // Month - 2009-11-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1065), 19.4, 0, 19.4, 19.4, 4.2);  // Month - 2009-12-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1066), 21.3, 0, 21.3, 21.3, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1067), 14.5, 0, 14.5, 14.5, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1068), 14.4, 0, 14.4, 14.4, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1069), 14.1, 0, 14.1, 14.1, 3.8);  // Month - 2009-12-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1070), 16.0, 0, 16.0, 16.0, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1071), 14.2, 0, 14.2, 14.2, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1072), 18.5, 0, 18.5, 18.5, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1073), 21.0, 0, 21.0, 21.0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1074), 22.7, 0, 22.7, 22.7, 5.5);  // Month - 2009-12-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1075), 21.2, 0, 21.2, 21.2, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1076), 17.4, 0, 17.4, 17.4, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1077), 17.7, 0, 17.7, 17.7, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1078), 20.9, 0, 20.9, 20.9, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1079), 21.3, 0, 21.3, 21.3, 4.6);  // Month - 2009-12-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1080), 19.0, 0, 19.0, 19.0, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1081), 20.9, 0, 20.9, 20.9, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1082), 23.4, 0, 23.4, 23.4, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1083), 26.5, 0, 26.5, 26.5, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1084), 21.8, 0, 21.8, 21.8, 2.1);  // Month - 2009-12-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1085), 20.1, 0, 20.1, 20.1, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1086), 22.3, 0, 22.3, 22.3, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1087), 24.4, 0, 24.4, 24.4, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1088), 21.9, 0, 21.9, 21.9, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1089), 21.1, 0, 21.1, 21.1, 3.0);  // Month - 2009-12-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1090), 23.1, 0, 23.1, 23.1, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1091), 24.1, 0, 24.1, 24.1, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1092), 23.3, 0, 23.3, 23.3, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1093), 23.3, 0, 23.3, 23.3, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1094), 20.9, 0, 20.9, 20.9, 5.9);  // Month - 2009-12-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1095), 19.5, 0, 19.5, 19.5, 5.2);


            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1096), 19.3, 0, 19.3, 19.3, 5.1);  // Month - 2010-1-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1097), 24.3, 0, 24.3, 24.3, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1098), 25.0, 0, 25.0, 25.0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1099), 24.9, 0, 24.9, 24.9, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1100), 25.2, 0, 25.2, 25.2, 5.4);  // Month - 2010-1-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1101), 18.2, 0, 18.2, 18.2, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1102), 18.0, 0, 18.0, 18.0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1103), 20.9, 0, 20.9, 20.9, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1104), 25.1, 0, 25.1, 25.1, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1105), 26.8, 0, 26.8, 26.8, 4.1);  // Month - 2010-1-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1106), 25.0, 0, 25.0, 25.0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1107), 21.4, 0, 21.4, 21.4, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1108), 21.4, 0, 21.4, 21.4, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1109), 22.5, 0, 22.5, 22.5, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1110), 23.9, 0, 23.9, 23.9, 6.0);  // Month - 2010-1-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1111), 21.4, 0, 21.4, 21.4, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1112), 24.8, 0, 24.8, 24.8, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1113), 27.0, 0, 27.0, 27.0, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1114), 22.3, 0, 22.3, 22.3, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1115), 21.4, 0, 21.4, 21.4, 5.4);  // Month - 2010-1-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1116), 23.7, 0, 23.7, 23.7, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1117), 24.9, 0, 24.9, 24.9, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1118), 24.3, 0, 24.3, 24.3, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1119), 24.2, 0, 24.2, 24.2, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1120), 25.9, 0, 25.9, 25.9, 5.8);  // Month - 2010-1-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1121), 24.5, 0, 24.5, 24.5, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1122), 24.9, 0, 24.9, 24.9, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1123), 25.7, 0, 25.7, 25.7, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1124), 26.6, 0, 26.6, 26.6, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1125), 26.6, 0, 26.6, 26.6, 4.0);  // Month - 2010-1-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1126), 25.7, 0, 25.7, 25.7, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1127), 26.7, 0, 26.7, 26.7, 5.3);  // Month - 2010-2-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1128), 25.4, 0, 25.4, 25.4, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1129), 25.8, 0, 25.8, 25.8, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1130), 23.5, 0, 23.5, 23.5, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1131), 23.2, 0, 23.2, 23.2, 1.7);  // Month - 2010-2-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1132), 23.5, 0, 23.5, 23.5, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1133), 21.9, 0, 21.9, 21.9, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1134), 23.7, 0, 23.7, 23.7, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1135), 24.1, 0, 24.1, 24.1, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1136), 24.2, 0, 24.2, 24.2, 4.9);  // Month - 2010-2-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1137), 26.7, 0, 26.7, 26.7, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1138), 26.8, 0, 26.8, 26.8, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1139), 28.1, 0, 28.1, 28.1, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1140), 21.3, 0, 21.3, 21.3, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1141), 22.6, 0, 22.6, 22.6, 3.4);  // Month - 2010-2-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1142), 20.6, 0, 20.6, 20.6, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1143), 20.4, 0, 20.4, 20.4, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1144), 22.6, 0, 22.6, 22.6, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1145), 26.0, 0, 26.0, 26.0, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1146), 25.5, 0, 25.5, 25.5, 1.7);  // Month - 2010-2-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1147), 23.0, 0, 23.0, 23.0, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1148), 24.4, 0, 24.4, 24.4, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1149), 18.1, 0, 18.1, 18.1, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1150), 16.8, 0, 16.8, 16.8, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1151), 15.7, 0, 15.7, 15.7, 3.4);  // Month - 2010-2-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1152), 17.6, 0, 17.6, 17.6, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1153), 19.8, 0, 19.8, 19.8, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1154), 19.8, 0, 19.8, 19.8, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1155), 21.1, 0, 21.1, 21.1, 3.5);  // Month - 2010-3-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1156), 24.8, 0, 24.8, 24.8, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1157), 25.0, 0, 25.0, 25.0, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1158), 24.9, 0, 24.9, 24.9, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1159), 22.8, 0, 22.8, 22.8, 3.9);  // Month - 2010-3-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1160), 21.5, 0, 21.5, 21.5, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1161), 20.7, 0, 20.7, 20.7, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1162), 21.9, 0, 21.9, 21.9, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1163), 24.4, 0, 24.4, 24.4, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1164), 23.7, 0, 23.7, 23.7, 2.6);  // Month - 2010-3-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1165), 20.2, 0, 20.2, 20.2, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1166), 18.5, 0, 18.5, 18.5, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1167), 20.3, 0, 20.3, 20.3, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1168), 20.1, 0, 20.1, 20.1, 9.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1169), 16.9, 0, 16.9, 16.9, 5.9);  // Month - 2010-3-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1170), 17.4, 0, 17.4, 17.4, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1171), 21.2, 0, 21.2, 21.2, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1172), 22.0, 0, 22.0, 22.0, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1173), 23.2, 0, 23.2, 23.2, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1174), 21.0, 0, 21.0, 21.0, 3.7);  // Month - 2010-3-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1175), 20.2, 0, 20.2, 20.2, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1176), 20.6, 0, 20.6, 20.6, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1177), 19.7, 0, 19.7, 19.7, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1178), 18.1, 0, 18.1, 18.1, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1179), 16.8, 0, 16.8, 16.8, 3.4);  // Month - 2010-3-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1180), 19.8, 0, 19.8, 19.8, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1181), 23.3, 0, 23.3, 23.3, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1182), 21.1, 0, 21.1, 21.1, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1183), 21.3, 0, 21.3, 21.3, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1184), 20.7, 0, 20.7, 20.7, 2.1);  // Month - 2010-3-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1185), 24.8, 0, 24.8, 24.8, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1186), 21.4, 0, 21.4, 21.4, 2.6);  // Month - 2010-4-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1187), 17.9, 0, 17.9, 17.9, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1188), 17.8, 0, 17.8, 17.8, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1189), 15.4, 0, 15.4, 15.4, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1190), 14.9, 0, 14.9, 14.9, 2.0);  // Month - 2010-4-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1191), 14.6, 0, 14.6, 14.6, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1192), 15.0, 0, 15.0, 15.0, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1193), 16.5, 0, 16.5, 16.5, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1194), 16.9, 0, 16.9, 16.9, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1195), 18.7, 0, 18.7, 18.7, 2.2);  // Month - 2010-4-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1196), 20.0, 0, 20.0, 20.0, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1197), 21.3, 0, 21.3, 21.3, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1198), 21.1, 0, 21.1, 21.1, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1199), 15.6, 0, 15.6, 15.6, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1200), 12.9, 0, 12.9, 12.9, 0.7);  // Month - 2010-4-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1201), 15.3, 0, 15.3, 15.3, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1202), 14.9, 0, 14.9, 14.9, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1203), 23.1, 0, 23.1, 23.1, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1204), 18.7, 0, 18.7, 18.7, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1205), 15.9, 0, 15.9, 15.9, 1.0);  // Month - 2010-4-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1206), 16.1, 0, 16.1, 16.1, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1207), 13.4, 0, 13.4, 13.4, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1208), 11.0, 0, 11.0, 11.0, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1209), 10.3, 0, 10.3, 10.3, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1210), 16.0, 0, 16.0, 16.0, 0.8);  // Month - 2010-4-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1211), 13.9, 0, 13.9, 13.9, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1212), 13.9, 0, 13.9, 13.9, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1213), 14.7, 0, 14.7, 14.7, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1214), 14.5, 0, 14.5, 14.5, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1215), 15.5, 0, 15.5, 15.5, 1.8);  // Month - 2010-4-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1216), 19.8, 0, 19.8, 19.8, 1.8);  // Month - 2010-5-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1217), 19.5, 0, 19.5, 19.5, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1218), 16.6, 0, 16.6, 16.6, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1219), 15.7, 0, 15.7, 15.7, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1220), 14.6, 0, 14.6, 14.6, 0.9);  // Month - 2010-5-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1221), 14.5, 0, 14.5, 14.5, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1222), 10.4, 0, 10.4, 10.4, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1223), 09.8, 0, 09.8, 09.8, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1224), 10.7, 0, 10.7, 10.7, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1225), 11.9, 0, 11.9, 11.9, 0.8);  // Month - 2010-5-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1226), 12.1, 0, 12.1, 12.1, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1227), 14.2, 0, 14.2, 14.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1228), 14.4, 0, 14.4, 14.4, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1229), 16.1, 0, 16.1, 16.1, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1230), 15.6, 0, 15.6, 15.6, 1.5);  // Month - 2010-5-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1231), 10.6, 0, 10.6, 10.6, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1232), 11.1, 0, 11.1, 11.1, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1233), 15.8, 0, 15.8, 15.8, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1234), 17.9, 0, 17.9, 17.9, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1235), 18.3, 0, 18.3, 18.3, 0.8);  // Month - 2010-5-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1236), 18.3, 0, 18.3, 18.3, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1237), 18.5, 0, 18.5, 18.5, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1238), 19.9, 0, 19.9, 19.9, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1239), 16.9, 0, 16.9, 16.9, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1240), 13.4, 0, 13.4, 13.4, 1.2);  // Month - 2010-5-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1241), 12.5, 0, 12.5, 12.5, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1242), 14.3, 0, 14.3, 14.3, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1243), 17.0, 0, 17.0, 17.0, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1244), 14.8, 0, 14.8, 14.8, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1245), 13.9, 0, 13.9, 13.9, 1.6);  // Month - 2010-5-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1246), 10.0, 0, 10.0, 10.0, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1247), 08.7, 0, 08.7, 08.7, 0.6);  // Month - 2010-6-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1248), 11.2, 0, 11.2, 11.2, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1249), 14.7, 0, 14.7, 14.7, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1250), 11.8, 0, 11.8, 11.8, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1251), 12.5, 0, 12.5, 12.5, 0.7);  // Month - 2010-6-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1252), 15.1, 0, 15.1, 15.1, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1253), 11.7, 0, 11.7, 11.7, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1254), 08.2, 0, 08.2, 08.2, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1255), 06.9, 0, 06.9, 06.9, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1256), 09.7, 0, 09.7, 09.7, 0.6);  // Month - 2010-6-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1257), 12.6, 0, 12.6, 12.6, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1258), 12.6, 0, 12.6, 12.6, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1259), 14.8, 0, 14.8, 14.8, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1260), 16.8, 0, 16.8, 16.8, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1261), 13.5, 0, 13.5, 13.5, 0.6);  // Month - 2010-6-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1262), 12.2, 0, 12.2, 12.2, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1263), 10.7, 0, 10.7, 10.7, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1264), 11.5, 0, 11.5, 11.5, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1265), 10.2, 0, 10.2, 10.2, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1266), 10.5, 0, 10.5, 10.5, 1.1);  // Month - 2010-6-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1267), 06.2, 0, 06.2, 06.2, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1268), 09.8, 0, 09.8, 09.8, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1269), 13.7, 0, 13.7, 13.7, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1270), 11.0, 0, 11.0, 11.0, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1271), 09.0, 0, 09.0, 09.0, 0.6);  // Month - 2010-6-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1272), 09.4, 0, 09.4, 09.4, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1273), 11.3, 0, 11.3, 11.3, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1274), 10.2, 0, 10.2, 10.2, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1275), 09.6, 0, 09.6, 09.6, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1276), 13.2, 0, 13.2, 13.2, 0.9);  // Month - 2010-6-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1277), 14.7, 0, 14.7, 14.7, 0.7);  // Month - 2010-7-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1278), 16.9, 0, 16.9, 16.9, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1279), 18.6, 0, 18.6, 18.6, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1280), 22.0, 0, 22.0, 22.0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1281), 17.0, 0, 17.0, 17.0, 1.4);  // Month - 2010-7-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1282), 15.7, 0, 15.7, 15.7, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1283), 10.2, 0, 10.2, 10.2, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1284), 10.4, 0, 10.4, 10.4, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1285), 09.3, 0, 09.3, 09.3, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1286), 06.5, 0, 06.5, 06.5, 0.5);  // Month - 2010-7-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1287), 11.0, 0, 11.0, 11.0, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1288), 08.4, 0, 08.4, 08.4, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1289), 05.2, 0, 05.2, 05.2, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1290), 06.3, 0, 06.3, 06.3, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1291), 04.5, 0, 04.5, 04.5, 0.6);  // Month - 2010-7-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1292), 05.1, 0, 05.1, 05.1, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1293), 03.9, 0, 03.9, 03.9, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1294), 10.1, 0, 10.1, 10.1, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1295), 09.7, 0, 09.7, 09.7, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1296), 09.7, 0, 09.7, 09.7, 0.8);  // Month - 2010-7-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1297), 08.0, 0, 08.0, 08.0, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1298), 07.5, 0, 07.5, 07.5, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1299), 07.6, 0, 07.6, 07.6, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1300), 08.3, 0, 08.3, 08.3, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1301), 10.3, 0, 10.3, 10.3, 0.7);  // Month - 2010-7-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1302), 09.6, 0, 09.6, 09.6, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1303), 11.0, 0, 11.0, 11.0, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1304), 11.6, 0, 11.6, 11.6, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1305), 09.1, 0, 09.1, 09.1, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1306), 12.1, 0, 12.1, 12.1, 0.8);  // Month - 2010-7-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1307), 08.9, 0, 08.9, 08.9, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1308), 06.4, 0, 06.4, 06.4, 1.2);  // Month - 2010-8-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1309), 05.4, 0, 05.4, 05.4, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1310), 05.9, 0, 05.9, 05.9, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1311), 05.6, 0, 05.6, 05.6, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1312), 08.9, 0, 08.9, 08.9, 0.9);  // Month - 2010-8-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1313), 09.3, 0, 09.3, 09.3, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1314), 08.9, 0, 08.9, 08.9, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1315), 07.7, 0, 07.7, 07.7, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1316), 09.8, 0, 09.8, 09.8, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1317), 09.2, 0, 09.2, 09.2, 1.2);  // Month - 2010-8-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1318), 09.3, 0, 09.3, 09.3, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1319), 11.2, 0, 11.2, 11.2, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1320), 08.4, 0, 08.4, 08.4, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1321), 08.4, 0, 08.4, 08.4, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1322), 07.7, 0, 07.7, 07.7, 1.1);  // Month - 2010-8-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1323), 11.6, 0, 11.6, 11.6, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1324), 14.8, 0, 14.8, 14.8, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1325), 16.5, 0, 16.5, 16.5, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1326), 11.8, 0, 11.8, 11.8, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1327), 11.0, 0, 11.0, 11.0, 1.7);  // Month - 2010-8-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1328), 15.2, 0, 15.2, 15.2, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1329), 18.4, 0, 18.4, 18.4, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1330), 18.4, 0, 18.4, 18.4, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1331), 09.6, 0, 09.6, 09.6, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1332), 09.4, 0, 09.4, 09.4, 1.3);  // Month - 2010-8-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1333), 13.4, 0, 13.4, 13.4, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1334), 14.7, 0, 14.7, 14.7, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1335), 15.1, 0, 15.1, 15.1, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1336), 10.0, 0, 10.0, 10.0, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1337), 09.9, 0, 09.9, 09.9, 2.4);  // Month - 2010-8-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1338), 14.9, 0, 14.9, 14.9, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1339), 12.3, 0, 12.3, 12.3, 1.2);  // Month - 2010-9-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1340), 10.8, 0, 10.8, 10.8, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1341), 13.8, 0, 13.8, 13.8, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1342), 10.0, 0, 10.0, 10.0, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1343), 11.8, 0, 11.8, 11.8, 2.4);  // Month - 2010-9-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1344), 14.9, 0, 14.9, 14.9, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1345), 15.6, 0, 15.6, 15.6, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1346), 15.9, 0, 15.9, 15.9, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1347), 16.4, 0, 16.4, 16.4, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1348), 19.9, 0, 19.9, 19.9, 3.0);  // Month - 2010-9-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1349), 11.8, 0, 11.8, 11.8, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1350), 10.0, 0, 10.0, 10.0, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1351), 11.3, 0, 11.3, 11.3, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1352), 11.9, 0, 11.9, 11.9, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1353), 13.9, 0, 13.9, 13.9, 2.6);  // Month - 2010-9-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1354), 13.7, 0, 13.7, 13.7, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1355), 08.8, 0, 08.8, 08.8, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1356), 10.1, 0, 10.1, 10.1, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1357), 15.4, 0, 15.4, 15.4, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1358), 17.8, 0, 17.8, 17.8, 3.1);  // Month - 2010-9-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1359), 16.3, 0, 16.3, 16.3, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1360), 17.7, 0, 17.7, 17.7, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1361), 11.8, 0, 11.8, 11.8, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1362), 11.6, 0, 11.6, 11.6, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1363), 16.3, 0, 16.3, 16.3, 2.9);  // Month - 2010-9-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1364), 16.7, 0, 16.7, 16.7, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1365), 15.5, 0, 15.5, 15.5, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1366), 14.8, 0, 14.8, 14.8, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1367), 14.8, 0, 14.8, 14.8, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1368), 13.0, 0, 13.0, 13.0, 2.5);  // Month - 2010-9-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1369), 11.8, 0, 11.8, 11.8, 2.6);  // Month - 2010-10-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1370), 12.5, 0, 12.5, 12.5, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1371), 13.8, 0, 13.8, 13.8, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1372), 15.2, 0, 15.2, 15.2, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1373), 16.1, 0, 16.1, 16.1, 3.9);  // Month - 2010-10-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1374), 17.6, 0, 17.6, 17.6, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1375), 16.5, 0, 16.5, 16.5, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1376), 14.9, 0, 14.9, 14.9, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1377), 14.8, 0, 14.8, 14.8, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1378), 14.5, 0, 14.5, 14.5, 3.1);  // Month - 2010-10-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1379), 15.1, 0, 15.1, 15.1, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1380), 16.1, 0, 16.1, 16.1, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1381), 19.4, 0, 19.4, 19.4, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1382), 16.8, 0, 16.8, 16.8, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1383), 15.9, 0, 15.9, 15.9, 1.6);  // Month - 2010-10-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1384), 14.1, 0, 14.1, 14.1, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1385), 12.9, 0, 12.9, 12.9, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1386), 14.6, 0, 14.6, 14.6, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1387), 17.1, 0, 17.1, 17.1, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1388), 19.0, 0, 19.0, 19.0, 4.7);  // Month - 2010-10-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1389), 20.0, 0, 20.0, 20.0, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1390), 12.8, 0, 12.8, 12.8, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1391), 10.5, 0, 10.5, 10.5, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1392), 13.3, 0, 13.3, 13.3, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1393), 13.6, 0, 13.6, 13.6, 3.3);  // Month - 2010-10-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1394), 12.9, 0, 12.9, 12.9, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1395), 13.5, 0, 13.5, 13.5, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1396), 16.5, 0, 16.5, 16.5, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1397), 16.3, 0, 16.3, 16.3, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1398), 15.3, 0, 15.3, 15.3, 5.8);  // Month - 2010-10-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1399), 16.1, 0, 16.1, 16.1, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1400), 14.5, 0, 14.5, 14.5, 3.8);  // Month - 2010-11-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1401), 15.7, 0, 15.7, 15.7, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1402), 20.4, 0, 20.4, 20.4, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1403), 18.0, 0, 18.0, 18.0, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1404), 17.9, 0, 17.9, 17.9, 4.3);  // Month - 2010-11-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1405), 17.9, 0, 17.9, 17.9, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1406), 22.7, 0, 22.7, 22.7, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1407), 16.9, 0, 16.9, 16.9, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1408), 12.0, 0, 12.0, 12.0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1409), 11.3, 0, 11.3, 11.3, 4.2);  // Month - 2010-11-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1410), 12.0, 0, 12.0, 12.0, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1411), 14.1, 0, 14.1, 14.1, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1412), 15.8, 0, 15.8, 15.8, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1413), 16.9, 0, 16.9, 16.9, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1414), 17.2, 0, 17.2, 17.2, 4.6);  // Month - 2010-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1415), 17.5, 0, 17.5, 17.5, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1416), 17.7, 0, 17.7, 17.7, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1417), 18.4, 0, 18.4, 18.4, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1418), 19.6, 0, 19.6, 19.6, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1419), 22.7, 0, 22.7, 22.7, 4.9);  // Month - 2010-11-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1420), 20.5, 0, 20.5, 20.5, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1421), 19.8, 0, 19.8, 19.8, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1422), 19.8, 0, 19.8, 19.8, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1423), 19.4, 0, 19.4, 19.4, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1424), 21.3, 0, 21.3, 21.3, 5.9);  // Month - 2010-11-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1425), 23.3, 0, 23.3, 23.3, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1426), 22.3, 0, 22.3, 22.3, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1427), 14.6, 0, 14.6, 14.6, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1428), 14.8, 0, 14.8, 14.8, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1429), 19.2, 0, 19.2, 19.2, 6.0);  // Month - 2010-11-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1430), 24.1, 0, 24.1, 24.1, 7.6);  // Month - 2010-12-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1431), 23.0, 0, 23.0, 23.0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1432), 19.9, 0, 19.9, 19.9, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1433), 19.6, 0, 19.6, 19.6, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1434), 19.8, 0, 19.8, 19.8, 7.2);  // Month - 2010-12-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1435), 20.7, 0, 20.7, 20.7, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1436), 24.6, 0, 24.6, 24.6, 7.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1437), 18.5, 0, 18.5, 18.5, 7.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1438), 19.2, 0, 19.2, 19.2, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1439), 22.1, 0, 22.1, 22.1, 5.1);  // Month - 2010-12-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1440), 23.0, 0, 23.0, 23.0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1441), 13.5, 0, 13.5, 13.5, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1442), 16.4, 0, 16.4, 16.4, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1443), 21.9, 0, 21.9, 21.9, 7.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1444), 23.8, 0, 23.8, 23.8, 8.0);  // Month - 2010-12-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1445), 24.0, 0, 24.0, 24.0, 8.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1446), 26.1, 0, 26.1, 26.1, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1447), 18.8, 0, 18.8, 18.8, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1448), 20.8, 0, 20.8, 20.8, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1449), 24.3, 0, 24.3, 24.3, 6.9);  // Month - 2010-12-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1450), 26.8, 0, 26.8, 26.8, 7.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1451), 26.9, 0, 26.9, 26.9, 8.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1452), 25.9, 0, 25.9, 25.9, 8.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1453), 24.0, 0, 24.0, 24.0, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1454), 26.3, 0, 26.3, 26.3, 7.7);  // Month - 2010-12-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1455), 25.9, 0, 25.9, 25.9, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1456), 27.3, 0, 27.3, 27.3, 8.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1457), 24.7, 0, 24.7, 24.7, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1458), 22.9, 0, 22.9, 22.9, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1459), 23.7, 0, 23.7, 23.7, 7.0);  // Month - 2010-12-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1460), 23.9, 0, 23.9, 23.9, 6.5);


            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1461), 22.9, 0, 22.9, 22.9, 5.8);  // Month - 2011-1-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1462), 23.9, 0, 23.9, 23.9, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1463), 24.8, 0, 24.8, 24.8, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1464), 23.5, 0, 23.5, 23.5, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1465), 25.0, 0, 25.0, 25.0, 4.0);  // Month - 2011-1-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1466), 26.1, 0, 26.1, 26.1, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1467), 24.5, 0, 24.5, 24.5, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1468), 24.8, 0, 24.8, 24.8, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1469), 24.3, 0, 24.3, 24.3, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1470), 23.2, 0, 23.2, 23.2, 6.5);  // Month - 2011-1-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1471), 24.5, 0, 24.5, 24.5, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1472), 23.0, 0, 23.0, 23.0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1473), 22.7, 0, 22.7, 22.7, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1474), 25.0, 0, 25.0, 25.0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1475), 25.3, 0, 25.3, 25.3, 7.3);  // Month - 2011-1-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1476), 28.3, 0, 28.3, 28.3, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1477), 22.7, 0, 22.7, 22.7, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1478), 21.8, 0, 21.8, 21.8, 7.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1479), 23.7, 0, 23.7, 23.7, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1480), 21.7, 0, 21.7, 21.7, 6.8);  // Month - 2011-1-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1481), 20.6, 0, 20.6, 20.6, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1482), 23.7, 0, 23.7, 23.7, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1483), 27.4, 0, 27.4, 27.4, 7.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1484), 27.2, 0, 27.2, 27.2, 7.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1485), 28.9, 0, 28.9, 28.9, 6.8);  // Month - 2011-1-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1486), 27.3, 0, 27.3, 27.3, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1487), 24.9, 0, 24.9, 24.9, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1488), 25.0, 0, 25.0, 25.0, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1489), 23.4, 0, 23.4, 23.4, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1490), 25.7, 0, 25.7, 25.7, 7.5);  // Month - 2011-1-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1491), 26.0, 0, 26.0, 26.0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1492), 19.8, 0, 19.8, 19.8, 6.0);  // Month - 2011-2-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1493), 21.5, 0, 21.5, 21.5, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1494), 26.2, 0, 26.2, 26.2, 7.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1495), 22.6, 0, 22.6, 22.6, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1496), 24.6, 0, 24.6, 24.6, 6.0);  // Month - 2011-2-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1497), 19.9, 0, 19.9, 19.9, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1498), 21.9, 0, 21.9, 21.9, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1499), 20.7, 0, 20.7, 20.7, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1500), 22.0, 0, 22.0, 22.0, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1501), 21.2, 0, 21.2, 21.2, 5.2);  // Month - 2011-2-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1502), 20.2, 0, 20.2, 20.2, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1503), 21.6, 0, 21.6, 21.6, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1504), 21.7, 0, 21.7, 21.7, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1505), 21.8, 0, 21.8, 21.8, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1506), 22.2, 0, 22.2, 22.2, 6.5);  // Month - 2011-2-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1507), 24.0, 0, 24.0, 24.0, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1508), 27.5, 0, 27.5, 27.5, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1509), 25.8, 0, 25.8, 25.8, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1510), 23.9, 0, 23.9, 23.9, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1511), 23.5, 0, 23.5, 23.5, 5.4);  // Month - 2011-2-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1512), 23.5, 0, 23.5, 23.5, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1513), 23.8, 0, 23.8, 23.8, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1514), 21.8, 0, 21.8, 21.8, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1515), 20.7, 0, 20.7, 20.7, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1516), 21.0, 0, 21.0, 21.0, 3.3);  // Month - 2011-2-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1517), 20.1, 0, 20.1, 20.1, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1518), 21.9, 0, 21.9, 21.9, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1519), 22.0, 0, 22.0, 22.0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1520), 21.0, 0, 21.0, 21.0, 4.8);  // Month - 2011-3-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1521), 22.5, 0, 22.5, 22.5, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1522), 23.4, 0, 23.4, 23.4, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1523), 24.5, 0, 24.5, 24.5, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1524), 22.9, 0, 22.9, 22.9, 4.9);  // Month - 2011-3-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1525), 23.6, 0, 23.6, 23.6, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1526), 25.3, 0, 25.3, 25.3, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1527), 25.2, 0, 25.2, 25.2, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1528), 26.1, 0, 26.1, 26.1, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1529), 25.7, 0, 25.7, 25.7, 5.0);  // Month - 2011-3-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1530), 26.7, 0, 26.7, 26.7, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1531), 26.4, 0, 26.4, 26.4, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1532), 17.8, 0, 17.8, 17.8, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1533), 15.8, 0, 15.8, 15.8, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1534), 15.9, 0, 15.9, 15.9, 3.6);  // Month - 2011-3-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1535), 21.3, 0, 21.3, 21.3, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1536), 20.7, 0, 20.7, 20.7, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1537), 19.2, 0, 19.2, 19.2, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1538), 18.3, 0, 18.3, 18.3, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1539), 20.1, 0, 20.1, 20.1, 4.4);  // Month - 2011-3-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1540), 23.4, 0, 23.4, 23.4, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1541), 25.8, 0, 25.8, 25.8, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1542), 20.1, 0, 20.1, 20.1, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1543), 19.1, 0, 19.1, 19.1, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1544), 18.0, 0, 18.0, 18.0, 2.6);  // Month - 2011-3-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1545), 20.0, 0, 20.0, 20.0, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1546), 17.1, 0, 17.1, 17.1, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1547), 15.5, 0, 15.5, 15.5, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1548), 17.3, 0, 17.3, 17.3, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1549), 18.1, 0, 18.1, 18.1, 3.6);  // Month - 2011-3-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1550), 22.2, 0, 22.2, 22.2, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1551), 21.9, 0, 21.9, 21.9, 3.1);  // Month - 2011-4-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1552), 20.5, 0, 20.5, 20.5, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1553), 20.3, 0, 20.3, 20.3, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1554), 16.7, 0, 16.7, 16.7, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1555), 16.4, 0, 16.4, 16.4, 2.9);  // Month - 2011-4-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1556), 17.4, 0, 17.4, 17.4, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1557), 18.8, 0, 18.8, 18.8, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1558), 17.4, 0, 17.4, 17.4, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1559), 17.2, 0, 17.2, 17.2, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1560), 17.7, 0, 17.7, 17.7, 2.1);  // Month - 2011-4-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1561), 21.0, 0, 21.0, 21.0, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1562), 21.9, 0, 21.9, 21.9, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1563), 22.5, 0, 22.5, 22.5, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1564), 17.4, 0, 17.4, 17.4, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1565), 15.0, 0, 15.0, 15.0, 1.3);  // Month - 2011-4-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1566), 15.5, 0, 15.5, 15.5, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1567), 17.9, 0, 17.9, 17.9, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1568), 13.8, 0, 13.8, 13.8, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1569), 15.5, 0, 15.5, 15.5, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1570), 14.2, 0, 14.2, 14.2, 1.2);  // Month - 2011-4-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1571), 17.1, 0, 17.1, 17.1, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1572), 20.3, 0, 20.3, 20.3, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1573), 13.8, 0, 13.8, 13.8, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1574), 14.6, 0, 14.6, 14.6, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1575), 16.0, 0, 16.0, 16.0, 1.9);  // Month - 2011-4-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1576), 16.0, 0, 16.0, 16.0, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1577), 18.3, 0, 18.3, 18.3, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1578), 19.4, 0, 19.4, 19.4, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1579), 20.0, 0, 20.0, 20.0, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1580), 19.5, 0, 19.5, 19.5, 1.5);  // Month - 2011-4-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1581), 14.6, 0, 14.6, 14.6, 1.5);  // Month - 2011-5-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1582), 10.8, 0, 10.8, 10.8, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1583), 10.7, 0, 10.7, 10.7, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1584), 13.5, 0, 13.5, 13.5, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1585), 13.5, 0, 13.5, 13.5, 1.4);  // Month - 2011-5-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1586), 11.8, 0, 11.8, 11.8, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1587), 14.3, 0, 14.3, 14.3, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1588), 11.2, 0, 11.2, 11.2, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1589), 09.8, 0, 09.8, 09.8, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1590), 13.7, 0, 13.7, 13.7, 1.3);  // Month - 2011-5-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1591), 15.2, 0, 15.2, 15.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1592), 15.2, 0, 15.2, 15.2, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1593), 14.1, 0, 14.1, 14.1, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1594), 14.9, 0, 14.9, 14.9, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1595), 13.9, 0, 13.9, 13.9, 1.2);  // Month - 2011-5-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1596), 11.8, 0, 11.8, 11.8, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1597), 12.6, 0, 12.6, 12.6, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1598), 14.0, 0, 14.0, 14.0, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1599), 13.6, 0, 13.6, 13.6, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1600), 17.4, 0, 17.4, 17.4, 1.5);  // Month - 2011-5-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1601), 17.0, 0, 17.0, 17.0, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1602), 16.2, 0, 16.2, 16.2, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1603), 08.9, 0, 08.9, 08.9, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1604), 10.2, 0, 10.2, 10.2, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1605), 12.4, 0, 12.4, 12.4, 1.0);  // Month - 2011-5-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1606), 11.6, 0, 11.6, 11.6, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1607), 12.4, 0, 12.4, 12.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1608), 12.0, 0, 12.0, 12.0, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1609), 09.3, 0, 09.3, 09.3, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1610), 10.9, 0, 10.9, 10.9, 1.2);  // Month - 2011-5-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1611), 12.0, 0, 12.0, 12.0, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1612), 10.2, 0, 10.2, 10.2, 0.5);  // Month - 2011-6-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1613), 10.6, 0, 10.6, 10.6, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1614), 11.1, 0, 11.1, 11.1, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1615), 06.5, 0, 06.5, 06.5, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1616), 06.3, 0, 06.3, 06.3, 0.6);  // Month - 2011-6-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1617), 06.8, 0, 06.8, 06.8, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1618), 10.5, 0, 10.5, 10.5, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1619), 10.1, 0, 10.1, 10.1, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1620), 12.0, 0, 12.0, 12.0, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1621), 11.2, 0, 11.2, 11.2, 1.0);  // Month - 2011-6-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1622), 14.7, 0, 14.7, 14.7, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1623), 11.9, 0, 11.9, 11.9, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1624), 08.3, 0, 08.3, 08.3, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1625), 07.9, 0, 07.9, 07.9, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1626), 14.7, 0, 14.7, 14.7, 1.2);  // Month - 2011-6-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1627), 15.6, 0, 15.6, 15.6, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1628), 14.0, 0, 14.0, 14.0, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1629), 14.4, 0, 14.4, 14.4, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1630), 17.5, 0, 17.5, 17.5, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1631), 11.5, 0, 11.5, 11.5, 0.8);  // Month - 2011-6-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1632), 10.4, 0, 10.4, 10.4, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1633), 10.4, 0, 10.4, 10.4, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1634), 11.5, 0, 11.5, 11.5, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1635), 09.9, 0, 09.9, 09.9, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1636), 09.8, 0, 09.8, 09.8, 1.2);  // Month - 2011-6-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1637), 08.0, 0, 08.0, 08.0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1638), 08.7, 0, 08.7, 08.7, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1639), 08.6, 0, 08.6, 08.6, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1640), 08.3, 0, 08.3, 08.3, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1641), 08.5, 0, 08.5, 08.5, 1.2);  // Month - 2011-6-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1642), 04.6, 0, 04.6, 04.6, 0.7);  // Month - 2011-7-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1643), 03.7, 0, 03.7, 03.7, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1644), 04.6, 0, 04.6, 04.6, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1645), 06.4, 0, 06.4, 06.4, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1646), 06.1, 0, 06.1, 06.1, 0.5);  // Month - 2011-7-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1647), 06.4, 0, 06.4, 06.4, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1648), 07.0, 0, 07.0, 07.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1649), 10.0, 0, 10.0, 10.0, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1650), 11.5, 0, 11.5, 11.5, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1651), 12.5, 0, 12.5, 12.5, 1.2);  // Month - 2011-7-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1652), 13.3, 0, 13.3, 13.3, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1653), 15.1, 0, 15.1, 15.1, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1654), 10.1, 0, 10.1, 10.1, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1655), 10.9, 0, 10.9, 10.9, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1656), 14.4, 0, 14.4, 14.4, 1.0);  // Month - 2011-7-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1657), 09.0, 0, 09.0, 09.0, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1658), 07.3, 0, 07.3, 07.3, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1659), 11.4, 0, 11.4, 11.4, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1660), 10.4, 0, 10.4, 10.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1661), 09.3, 0, 09.3, 09.3, 0.8);  // Month - 2011-7-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1662), 07.9, 0, 07.9, 07.9, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1663), 09.3, 0, 09.3, 09.3, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1664), 10.3, 0, 10.3, 10.3, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1665), 11.6, 0, 11.6, 11.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1666), 18.0, 0, 18.0, 18.0, 2.2);  // Month - 2011-7-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1667), 11.5, 0, 11.5, 11.5, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1668), 09.9, 0, 09.9, 09.9, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1669), 11.3, 0, 11.3, 11.3, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1670), 09.9, 0, 09.9, 09.9, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1671), 07.1, 0, 07.1, 07.1, 1.2);  // Month - 2011-7-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1672), 05.7, 0, 05.7, 05.7, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1673), 04.6, 0, 04.6, 04.6, 1.0);  // Month - 2011-8-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1674), 09.3, 0, 09.3, 09.3, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1675), 08.7, 0, 08.7, 08.7, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1676), 06.7, 0, 06.7, 06.7, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1677), 09.9, 0, 09.9, 09.9, 1.5);  // Month - 2011-8-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1678), 12.0, 0, 12.0, 12.0, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1679), 13.7, 0, 13.7, 13.7, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1680), 14.5, 0, 14.5, 14.5, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1681), 14.6, 0, 14.6, 14.6, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1682), 16.8, 0, 16.8, 16.8, 2.2);  // Month - 2011-8-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1683), 16.7, 0, 16.7, 16.7, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1684), 14.8, 0, 14.8, 14.8, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1685), 10.1, 0, 10.1, 10.1, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1686), 08.1, 0, 08.1, 08.1, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1687), 10.8, 0, 10.8, 10.8, 1.3);  // Month - 2011-8-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1688), 12.4, 0, 12.4, 12.4, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1689), 11.7, 0, 11.7, 11.7, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1690), 12.4, 0, 12.4, 12.4, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1691), 08.9, 0, 08.9, 08.9, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1692), 07.3, 0, 07.3, 07.3, 2.4);  // Month - 2011-8-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1693), 05.4, 0, 05.4, 05.4, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1694), 06.2, 0, 06.2, 06.2, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1695), 07.2, 0, 07.2, 07.2, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1696), 11.3, 0, 11.3, 11.3, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1697), 09.5, 0, 09.5, 09.5, 1.4);  // Month - 2011-8-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1698), 07.6, 0, 07.6, 07.6, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1699), 10.3, 0, 10.3, 10.3, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1700), 10.9, 0, 10.9, 10.9, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1701), 11.0, 0, 11.0, 11.0, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1702), 11.0, 0, 11.0, 11.0, 2.4);  // Month - 2011-8-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1703), 07.5, 0, 07.5, 07.5, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1704), 06.7, 0, 06.7, 06.7, 1.7);  // Month - 2011-9-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1705), 10.0, 0, 10.0, 10.0, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1706), 14.4, 0, 14.4, 14.4, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1707), 11.1, 0, 11.1, 11.1, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1708), 10.5, 0, 10.5, 10.5, 2.6);  // Month - 2011-9-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1709), 12.1, 0, 12.1, 12.1, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1710), 13.3, 0, 13.3, 13.3, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1711), 14.3, 0, 14.3, 14.3, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1712), 15.1, 0, 15.1, 15.1, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1713), 13.8, 0, 13.8, 13.8, 3.2);  // Month - 2011-9-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1714), 10.1, 0, 10.1, 10.1, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1715), 15.0, 0, 15.0, 15.0, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1716), 10.6, 0, 10.6, 10.6, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1717), 10.2, 0, 10.2, 10.2, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1718), 13.7, 0, 13.7, 13.7, 3.3);  // Month - 2011-9-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1719), 19.7, 0, 19.7, 19.7, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1720), 14.7, 0, 14.7, 14.7, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1721), 11.8, 0, 11.8, 11.8, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1722), 11.5, 0, 11.5, 11.5, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1723), 12.1, 0, 12.1, 12.1, 2.9);  // Month - 2011-9-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1724), 15.0, 0, 15.0, 15.0, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1725), 11.9, 0, 11.9, 11.9, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1726), 12.0, 0, 12.0, 12.0, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1727), 12.5, 0, 12.5, 12.5, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1728), 16.1, 0, 16.1, 16.1, 3.4);  // Month - 2011-9-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1729), 19.0, 0, 19.0, 19.0, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1730), 16.4, 0, 16.4, 16.4, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1731), 17.9, 0, 17.9, 17.9, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1732), 15.5, 0, 15.5, 15.5, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1733), 15.8, 0, 15.8, 15.8, 2.8);  // Month - 2011-9-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1734), 15.4, 0, 15.4, 15.4, 3.3);  // Month - 2011-10-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1735), 16.1, 0, 16.1, 16.1, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1736), 11.1, 0, 11.1, 11.1, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1737), 12.9, 0, 12.9, 12.9, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1738), 15.1, 0, 15.1, 15.1, 2.9);  // Month - 2011-10-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1739), 17.5, 0, 17.5, 17.5, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1740), 15.3, 0, 15.3, 15.3, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1741), 17.5, 0, 17.5, 17.5, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1742), 16.1, 0, 16.1, 16.1, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1743), 14.3, 0, 14.3, 14.3, 2.6);  // Month - 2011-10-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1744), 14.7, 0, 14.7, 14.7, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1745), 17.0, 0, 17.0, 17.0, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1746), 18.3, 0, 18.3, 18.3, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1747), 14.2, 0, 14.2, 14.2, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1748), 16.5, 0, 16.5, 16.5, 4.1);  // Month - 2011-10-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1749), 17.1, 0, 17.1, 17.1, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1750), 12.8, 0, 12.8, 12.8, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1751), 13.4, 0, 13.4, 13.4, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1752), 17.7, 0, 17.7, 17.7, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1753), 18.1, 0, 18.1, 18.1, 4.7);  // Month - 2011-10-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1754), 18.8, 0, 18.8, 18.8, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1755), 17.9, 0, 17.9, 17.9, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1756), 15.8, 0, 15.8, 15.8, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1757), 16.7, 0, 16.7, 16.7, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1758), 16.3, 0, 16.3, 16.3, 2.7);  // Month - 2011-10-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1759), 13.9, 0, 13.9, 13.9, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1760), 14.6, 0, 14.6, 14.6, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1761), 15.9, 0, 15.9, 15.9, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1762), 15.7, 0, 15.7, 15.7, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1763), 12.2, 0, 12.2, 12.2, 3.8);  // Month - 2011-10-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1764), 11.3, 0, 11.3, 11.3, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1765), 14.8, 0, 14.8, 14.8, 5.0);  // Month - 2011-11-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1766), 18.1, 0, 18.1, 18.1, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1767), 19.8, 0, 19.8, 19.8, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1768), 20.7, 0, 20.7, 20.7, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1769), 20.1, 0, 20.1, 20.1, 4.4);  // Month - 2011-11-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1770), 18.0, 0, 18.0, 18.0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1771), 17.0, 0, 17.0, 17.0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1772), 19.1, 0, 19.1, 19.1, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1773), 21.4, 0, 21.4, 21.4, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1774), 15.8, 0, 15.8, 15.8, 5.1);  // Month - 2011-11-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1775), 16.1, 0, 16.1, 16.1, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1776), 18.3, 0, 18.3, 18.3, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1777), 19.3, 0, 19.3, 19.3, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1778), 18.7, 0, 18.7, 18.7, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1779), 16.9, 0, 16.9, 16.9, 4.8);  // Month - 2011-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1780), 19.6, 0, 19.6, 19.6, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1781), 20.0, 0, 20.0, 20.0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1782), 21.0, 0, 21.0, 21.0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1783), 23.7, 0, 23.7, 23.7, 7.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1784), 23.4, 0, 23.4, 23.4, 4.1);  // Month - 2011-11-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1785), 19.4, 0, 19.4, 19.4, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1786), 18.5, 0, 18.5, 18.5, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1787), 19.0, 0, 19.0, 19.0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1788), 22.4, 0, 22.4, 22.4, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1789), 23.8, 0, 23.8, 23.8, 6.2);  // Month - 2011-11-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1790), 24.0, 0, 24.0, 24.0, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1791), 24.2, 0, 24.2, 24.2, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1792), 25.8, 0, 25.8, 25.8, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1793), 25.1, 0, 25.1, 25.1, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1794), 16.0, 0, 16.0, 16.0, 5.5);  // Month - 2011-11-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1795), 15.7, 0, 15.7, 15.7, 5.2);  // Month - 2011-12-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1796), 17.0, 0, 17.0, 17.0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1797), 18.4, 0, 18.4, 18.4, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1798), 19.9, 0, 19.9, 19.9, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1799), 22.6, 0, 22.6, 22.6, 5.9);  // Month - 2011-12-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1800), 21.2, 0, 21.2, 21.2, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1801), 18.8, 0, 18.8, 18.8, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1802), 20.0, 0, 20.0, 20.0, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1803), 20.7, 0, 20.7, 20.7, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1804), 22.8, 0, 22.8, 22.8, 6.6);  // Month - 2011-12-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1805), 23.3, 0, 23.3, 23.3, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1806), 19.3, 0, 19.3, 19.3, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1807), 19.4, 0, 19.4, 19.4, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1808), 19.1, 0, 19.1, 19.1, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1809), 19.4, 0, 19.4, 19.4, 4.2);  // Month - 2011-12-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1810), 19.5, 0, 19.5, 19.5, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1811), 18.6, 0, 18.6, 18.6, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1812), 18.2, 0, 18.2, 18.2, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1813), 21.8, 0, 21.8, 21.8, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1814), 24.5, 0, 24.5, 24.5, 6.5);  // Month - 2011-12-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1815), 27.1, 0, 27.1, 27.1, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1816), 24.3, 0, 24.3, 24.3, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1817), 16.3, 0, 16.3, 16.3, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1818), 15.0, 0, 15.0, 15.0, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1819), 16.9, 0, 16.9, 16.9, 5.7);  // Month - 2011-12-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1820), 19.7, 0, 19.7, 19.7, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1821), 21.5, 0, 21.5, 21.5, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1822), 21.5, 0, 21.5, 21.5, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1823), 22.3, 0, 22.3, 22.3, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1824), 21.5, 0, 21.5, 21.5, 5.8);  // Month - 2011-12-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1825), 22.9, 0, 22.9, 22.9, 6.8);


            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1826), 22.4, 0, 22.4, 22.4, 6.4);  // Month - 2012-1-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1827), 23.0, 0, 23.0, 23.0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1828), 19.6, 0, 19.6, 19.6, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1829), 20.0, 0, 20.0, 20.0, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1830), 23.7, 0, 23.7, 23.7, 6.9);  // Month - 2012-1-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1831), 25.2, 0, 25.2, 25.2, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1832), 22.2, 0, 22.2, 22.2, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1833), 23.5, 0, 23.5, 23.5, 7.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1834), 29.7, 0, 29.7, 29.7, 9.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1835), 31.2, 0, 31.2, 31.2, 8.8);  // Month - 2012-1-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1836), 26.0, 0, 26.0, 26.0, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1837), 19.5, 0, 19.5, 19.5, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1838), 18.0, 0, 18.0, 18.0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1839), 19.5, 0, 19.5, 19.5, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1840), 20.8, 0, 20.8, 20.8, 6.1);  // Month - 2012-1-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1841), 22.6, 0, 22.6, 22.6, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1842), 23.1, 0, 23.1, 23.1, 7.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1843), 24.7, 0, 24.7, 24.7, 7.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1844), 26.4, 0, 26.4, 26.4, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1845), 27.8, 0, 27.8, 27.8, 7.5);  // Month - 2012-1-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1846), 27.7, 0, 27.7, 27.7, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1847), 23.9, 0, 23.9, 23.9, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1848), 23.8, 0, 23.8, 23.8, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1849), 22.2, 0, 22.2, 22.2, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1850), 19.2, 0, 19.2, 19.2, 5.5);  // Month - 2012-1-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1851), 20.0, 0, 20.0, 20.0, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1852), 20.9, 0, 20.9, 20.9, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1853), 22.7, 0, 22.7, 22.7, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1854), 26.0, 0, 26.0, 26.0, 7.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1855), 26.5, 0, 26.5, 26.5, 6.5);  // Month - 2012-1-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1856), 26.2, 0, 26.2, 26.2, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1857), 27.8, 0, 27.8, 27.8, 5.0);  // Month - 2012-2-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1858), 25.0, 0, 25.0, 25.0, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1859), 25.4, 0, 25.4, 25.4, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1860), 26.9, 0, 26.9, 26.9, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1861), 24.2, 0, 24.2, 24.2, 3.0);  // Month - 2012-2-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1862), 26.3, 0, 26.3, 26.3, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1863), 28.9, 0, 28.9, 28.9, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1864), 26.5, 0, 26.5, 26.5, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1865), 21.5, 0, 21.5, 21.5, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1866), 20.2, 0, 20.2, 20.2, 5.1);  // Month - 2012-2-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1867), 19.5, 0, 19.5, 19.5, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1868), 22.5, 0, 22.5, 22.5, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1869), 24.7, 0, 24.7, 24.7, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1870), 26.2, 0, 26.2, 26.2, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1871), 27.5, 0, 27.5, 27.5, 6.4);  // Month - 2012-2-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1872), 29.2, 0, 29.2, 29.2, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1873), 22.7, 0, 22.7, 22.7, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1874), 29.0, 0, 29.0, 29.0, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1875), 25.9, 0, 25.9, 25.9, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1876), 22.0, 0, 22.0, 22.0, 2.1);  // Month - 2012-2-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1877), 20.9, 0, 20.9, 20.9, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1878), 21.1, 0, 21.1, 21.1, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1879), 19.2, 0, 19.2, 19.2, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1880), 19.6, 0, 19.6, 19.6, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1881), 22.7, 0, 22.7, 22.7, 5.3);  // Month - 2012-2-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1882), 19.7, 0, 19.7, 19.7, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1883), 21.0, 0, 21.0, 21.0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1884), 20.3, 0, 20.3, 20.3, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1885), 21.0, 0, 21.0, 21.0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1886), 20.6, 0, 20.6, 20.6, 3.2);  // Month - 2012-3-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1887), 20.1, 0, 20.1, 20.1, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1888), 22.6, 0, 22.6, 22.6, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1889), 25.1, 0, 25.1, 25.1, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1890), 26.6, 0, 26.6, 26.6, 4.8);  // Month - 2012-3-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1891), 22.5, 0, 22.5, 22.5, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1892), 25.5, 0, 25.5, 25.5, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1893), 23.3, 0, 23.3, 23.3, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1894), 23.1, 0, 23.1, 23.1, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1895), 26.4, 0, 26.4, 26.4, 4.1);  // Month - 2012-3-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1896), 25.0, 0, 25.0, 25.0, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1897), 22.5, 0, 22.5, 22.5, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1898), 20.7, 0, 20.7, 20.7, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1899), 18.9, 0, 18.9, 18.9, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1900), 18.2, 0, 18.2, 18.2, 3.5);  // Month - 2012-3-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1901), 18.9, 0, 18.9, 18.9, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1902), 20.6, 0, 20.6, 20.6, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1903), 23.6, 0, 23.6, 23.6, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1904), 25.3, 0, 25.3, 25.3, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1905), 22.0, 0, 22.0, 22.0, 2.0);  // Month - 2012-3-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1906), 21.2, 0, 21.2, 21.2, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1907), 18.3, 0, 18.3, 18.3, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1908), 16.3, 0, 16.3, 16.3, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1909), 16.9, 0, 16.9, 16.9, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1910), 17.3, 0, 17.3, 17.3, 2.6);  // Month - 2012-3-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1911), 16.5, 0, 16.5, 16.5, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1912), 14.3, 0, 14.3, 14.3, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1913), 15.6, 0, 15.6, 15.6, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1914), 16.6, 0, 16.6, 16.6, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1915), 17.2, 0, 17.2, 17.2, 3.0);  // Month - 2012-3-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1916), 19.6, 0, 19.6, 19.6, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1917), 21.0, 0, 21.0, 21.0, 3.2);  // Month - 2012-4-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1918), 21.2, 0, 21.2, 21.2, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1919), 21.4, 0, 21.4, 21.4, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1920), 20.0, 0, 20.0, 20.0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1921), 15.3, 0, 15.3, 15.3, 2.7);  // Month - 2012-4-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1922), 15.3, 0, 15.3, 15.3, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1923), 19.0, 0, 19.0, 19.0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1924), 16.8, 0, 16.8, 16.8, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1925), 17.5, 0, 17.5, 17.5, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1926), 18.8, 0, 18.8, 18.8, 1.8);  // Month - 2012-4-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1927), 20.3, 0, 20.3, 20.3, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1928), 20.1, 0, 20.1, 20.1, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1929), 18.7, 0, 18.7, 18.7, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1930), 19.5, 0, 19.5, 19.5, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1931), 17.7, 0, 17.7, 17.7, 2.2);  // Month - 2012-4-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1932), 17.9, 0, 17.9, 17.9, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1933), 19.6, 0, 19.6, 19.6, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1934), 19.0, 0, 19.0, 19.0, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1935), 21.4, 0, 21.4, 21.4, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1936), 19.7, 0, 19.7, 19.7, 2.4);  // Month - 2012-4-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1937), 14.1, 0, 14.1, 14.1, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1938), 11.9, 0, 11.9, 11.9, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1939), 10.9, 0, 10.9, 10.9, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1940), 10.0, 0, 10.0, 10.0, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1941), 09.7, 0, 09.7, 09.7, 1.4);  // Month - 2012-4-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1942), 12.6, 0, 12.6, 12.6, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1943), 13.0, 0, 13.0, 13.0, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1944), 10.6, 0, 10.6, 10.6, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1945), 09.8, 0, 09.8, 09.8, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1946), 10.7, 0, 10.7, 10.7, 1.3);  // Month - 2012-4-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1947), 11.6, 0, 11.6, 11.6, 1.6);  // Month - 2012-5-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1948), 15.2, 0, 15.2, 15.2, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1949), 17.6, 0, 17.6, 17.6, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1950), 17.3, 0, 17.3, 17.3, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1951), 16.9, 0, 16.9, 16.9, 1.6);  // Month - 2012-5-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1952), 17.9, 0, 17.9, 17.9, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1953), 19.8, 0, 19.8, 19.8, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1954), 20.0, 0, 20.0, 20.0, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1955), 18.9, 0, 18.9, 18.9, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1956), 15.0, 0, 15.0, 15.0, 0.9);  // Month - 2012-5-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1957), 15.3, 0, 15.3, 15.3, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1958), 11.4, 0, 11.4, 11.4, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1959), 11.4, 0, 11.4, 11.4, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1960), 13.3, 0, 13.3, 13.3, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1961), 14.7, 0, 14.7, 14.7, 1.5);  // Month - 2012-5-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1962), 16.5, 0, 16.5, 16.5, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1963), 17.6, 0, 17.6, 17.6, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1964), 17.3, 0, 17.3, 17.3, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1965), 17.4, 0, 17.4, 17.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1966), 18.1, 0, 18.1, 18.1, 1.1);  // Month - 2012-5-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1967), 18.4, 0, 18.4, 18.4, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1968), 18.0, 0, 18.0, 18.0, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1969), 17.0, 0, 17.0, 17.0, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1970), 16.3, 0, 16.3, 16.3, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1971), 16.8, 0, 16.8, 16.8, 1.0);  // Month - 2012-5-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1972), 16.5, 0, 16.5, 16.5, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1973), 17.2, 0, 17.2, 17.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1974), 19.4, 0, 19.4, 19.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1975), 19.0, 0, 19.0, 19.0, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1976), 12.6, 0, 12.6, 12.6, 1.1);  // Month - 2012-5-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1977), 10.8, 0, 10.8, 10.8, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1978), 09.3, 0, 09.3, 09.3, 1.1);  // Month - 2012-6-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1979), 16.4, 0, 16.4, 16.4, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1980), 09.1, 0, 09.1, 09.1, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1981), 08.3, 0, 08.3, 08.3, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1982), 08.1, 0, 08.1, 08.1, 0.7);  // Month - 2012-6-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1983), 05.8, 0, 05.8, 05.8, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1984), 05.9, 0, 05.9, 05.9, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1985), 06.1, 0, 06.1, 06.1, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1986), 06.1, 0, 06.1, 06.1, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1987), 09.0, 0, 09.0, 09.0, 1.1);  // Month - 2012-6-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1988), 09.5, 0, 09.5, 09.5, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1989), 13.7, 0, 13.7, 13.7, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1990), 18.0, 0, 18.0, 18.0, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1991), 14.8, 0, 14.8, 14.8, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1992), 11.8, 0, 11.8, 11.8, 0.9);  // Month - 2012-6-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1993), 07.1, 0, 07.1, 07.1, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1994), 06.9, 0, 06.9, 06.9, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1995), 11.2, 0, 11.2, 11.2, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1996), 10.0, 0, 10.0, 10.0, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1997), 11.1, 0, 11.1, 11.1, 0.7);  // Month - 2012-6-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1998), 11.9, 0, 11.9, 11.9, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1999), 12.0, 0, 12.0, 12.0, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2000), 11.5, 0, 11.5, 11.5, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2001), 12.8, 0, 12.8, 12.8, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2002), 08.4, 0, 08.4, 08.4, 0.5);  // Month - 2012-6-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2003), 09.8, 0, 09.8, 09.8, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2004), 16.0, 0, 16.0, 16.0, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2005), 17.4, 0, 17.4, 17.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2006), 13.0, 0, 13.0, 13.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2007), 14.2, 0, 14.2, 14.2, 1.0);  // Month - 2012-6-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2008), 19.8, 0, 19.8, 19.8, 1.2);  // Month - 2012-7-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2009), 11.9, 0, 11.9, 11.9, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2010), 07.5, 0, 07.5, 07.5, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2011), 06.6, 0, 06.6, 06.6, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2012), 05.5, 0, 05.5, 05.5, 0.6);  // Month - 2012-7-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2013), 05.1, 0, 05.1, 05.1, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2014), 05.5, 0, 05.5, 05.5, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2015), 07.6, 0, 07.6, 07.6, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2016), 06.7, 0, 06.7, 06.7, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2017), 07.6, 0, 07.6, 07.6, 0.8);  // Month - 2012-7-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2018), 04.4, 0, 04.4, 04.4, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2019), 06.8, 0, 06.8, 06.8, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2020), 09.2, 0, 09.2, 09.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2021), 06.9, 0, 06.9, 06.9, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2022), 06.1, 0, 06.1, 06.1, 0.9);  // Month - 2012-7-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2023), 05.9, 0, 05.9, 05.9, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2024), 05.3, 0, 05.3, 05.3, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2025), 07.8, 0, 07.8, 07.8, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2026), 11.5, 0, 11.5, 11.5, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2027), 11.8, 0, 11.8, 11.8, 1.1);  // Month - 2012-7-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2028), 11.7, 0, 11.7, 11.7, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2029), 06.9, 0, 06.9, 06.9, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2030), 09.5, 0, 09.5, 09.5, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2031), 06.7, 0, 06.7, 06.7, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2032), 05.9, 0, 05.9, 05.9, 1.0);  // Month - 2012-7-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2033), 07.2, 0, 07.2, 07.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2034), 04.4, 0, 04.4, 04.4, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2035), 09.2, 0, 09.2, 09.2, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2036), 05.7, 0, 05.7, 05.7, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2037), 04.8, 0, 04.8, 04.8, 1.1);  // Month - 2012-7-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2038), 09.4, 0, 09.4, 09.4, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2039), 13.8, 0, 13.8, 13.8, 0.8);  // Month - 2012-8-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2040), 11.2, 0, 11.2, 11.2, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2041), 13.0, 0, 13.0, 13.0, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2042), 09.0, 0, 09.0, 09.0, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2043), 09.4, 0, 09.4, 09.4, 0.7);  // Month - 2012-8-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2044), 10.5, 0, 10.5, 10.5, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2045), 16.7, 0, 16.7, 16.7, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2046), 14.0, 0, 14.0, 14.0, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2047), 13.3, 0, 13.3, 13.3, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2048), 15.8, 0, 15.8, 15.8, 1.4);  // Month - 2012-8-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2049), 15.9, 0, 15.9, 15.9, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2050), 12.6, 0, 12.6, 12.6, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2051), 10.3, 0, 10.3, 10.3, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2052), 13.2, 0, 13.2, 13.2, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2053), 16.6, 0, 16.6, 16.6, 1.2);  // Month - 2012-8-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2054), 17.1, 0, 17.1, 17.1, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2055), 17.4, 0, 17.4, 17.4, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2056), 18.0, 0, 18.0, 18.0, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2057), 16.2, 0, 16.2, 16.2, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2058), 13.3, 0, 13.3, 13.3, 1.1);  // Month - 2012-8-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2059), 12.1, 0, 12.1, 12.1, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2060), 16.9, 0, 16.9, 16.9, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2061), 24.5, 0, 24.5, 24.5, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2062), 15.2, 0, 15.2, 15.2, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2063), 08.2, 0, 08.2, 08.2, 1.9);  // Month - 2012-8-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2064), 08.0, 0, 08.0, 08.0, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2065), 09.4, 0, 09.4, 09.4, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2066), 09.8, 0, 09.8, 09.8, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2067), 11.9, 0, 11.9, 11.9, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2068), 14.5, 0, 14.5, 14.5, 1.7);  // Month - 2012-8-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2069), 14.5, 0, 14.5, 14.5, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2070), 16.7, 0, 16.7, 16.7, 2.1);  // Month - 2012-9-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2071), 15.9, 0, 15.9, 15.9, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2072), 11.8, 0, 11.8, 11.8, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2073), 15.8, 0, 15.8, 15.8, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2074), 12.7, 0, 12.7, 12.7, 1.5);  // Month - 2012-9-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2075), 14.0, 0, 14.0, 14.0, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2076), 17.7, 0, 17.7, 17.7, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2077), 12.9, 0, 12.9, 12.9, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2078), 11.3, 0, 11.3, 11.3, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2079), 12.4, 0, 12.4, 12.4, 2.2);  // Month - 2012-9-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2080), 14.0, 0, 14.0, 14.0, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2081), 14.8, 0, 14.8, 14.8, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2082), 17.6, 0, 17.6, 17.6, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2083), 17.0, 0, 17.0, 17.0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2084), 20.3, 0, 20.3, 20.3, 2.7);  // Month - 2012-9-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2085), 17.3, 0, 17.3, 17.3, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2086), 15.0, 0, 15.0, 15.0, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2087), 13.6, 0, 13.6, 13.6, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2088), 11.1, 0, 11.1, 11.1, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2089), 12.2, 0, 12.2, 12.2, 2.9);  // Month - 2012-9-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2090), 12.2, 0, 12.2, 12.2, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2091), 12.1, 0, 12.1, 12.1, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2092), 13.1, 0, 13.1, 13.1, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2093), 12.3, 0, 12.3, 12.3, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2094), 09.2, 0, 09.2, 09.2, 3.4);  // Month - 2012-9-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2095), 09.0, 0, 09.0, 09.0, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2096), 10.9, 0, 10.9, 10.9, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2097), 17.0, 0, 17.0, 17.0, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2098), 15.0, 0, 15.0, 15.0, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2099), 17.5, 0, 17.5, 17.5, 3.1);  // Month - 2012-9-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2100), 17.6, 0, 17.6, 17.6, 2.5);  // Month - 2012-10-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2101), 14.6, 0, 14.6, 14.6, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2102), 14.1, 0, 14.1, 14.1, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2103), 14.5, 0, 14.5, 14.5, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2104), 18.4, 0, 18.4, 18.4, 2.8);  // Month - 2012-10-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2105), 17.8, 0, 17.8, 17.8, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2106), 15.4, 0, 15.4, 15.4, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2107), 18.5, 0, 18.5, 18.5, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2108), 15.1, 0, 15.1, 15.1, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2109), 12.5, 0, 12.5, 12.5, 3.0);  // Month - 2012-10-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2110), 13.7, 0, 13.7, 13.7, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2111), 14.7, 0, 14.7, 14.7, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2112), 16.8, 0, 16.8, 16.8, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2113), 19.0, 0, 19.0, 19.0, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2114), 20.4, 0, 20.4, 20.4, 4.2);  // Month - 2012-10-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2115), 17.1, 0, 17.1, 17.1, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2116), 16.7, 0, 16.7, 16.7, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2117), 15.6, 0, 15.6, 15.6, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2118), 14.7, 0, 14.7, 14.7, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2119), 17.0, 0, 17.0, 17.0, 2.6);  // Month - 2012-10-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2120), 18.8, 0, 18.8, 18.8, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2121), 16.5, 0, 16.5, 16.5, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2122), 15.3, 0, 15.3, 15.3, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2123), 16.5, 0, 16.5, 16.5, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2124), 17.5, 0, 17.5, 17.5, 4.8);  // Month - 2012-10-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2125), 19.4, 0, 19.4, 19.4, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2126), 21.6, 0, 21.6, 21.6, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2127), 22.0, 0, 22.0, 22.0, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2128), 20.0, 0, 20.0, 20.0, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2129), 16.7, 0, 16.7, 16.7, 3.3);  // Month - 2012-10-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2130), 16.5, 0, 16.5, 16.5, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2131), 19.3, 0, 19.3, 19.3, 4.5);  // Month - 2012-11-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2132), 20.3, 0, 20.3, 20.3, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2133), 21.7, 0, 21.7, 21.7, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2134), 20.7, 0, 20.7, 20.7, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2135), 21.8, 0, 21.8, 21.8, 5.7);  // Month - 2012-11-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2136), 24.5, 0, 24.5, 24.5, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2137), 26.9, 0, 26.9, 26.9, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2138), 25.6, 0, 25.6, 25.6, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2139), 22.5, 0, 22.5, 22.5, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2140), 16.2, 0, 16.2, 16.2, 2.9);  // Month - 2012-11-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2141), 16.9, 0, 16.9, 16.9, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2142), 15.5, 0, 15.5, 15.5, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2143), 16.1, 0, 16.1, 16.1, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2144), 18.0, 0, 18.0, 18.0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2145), 17.8, 0, 17.8, 17.8, 5.1);  // Month - 2012-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2146), 20.5, 0, 20.5, 20.5, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2147), 21.3, 0, 21.3, 21.3, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2148), 22.4, 0, 22.4, 22.4, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2149), 21.5, 0, 21.5, 21.5, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2150), 22.1, 0, 22.1, 22.1, 5.5);  // Month - 2012-11-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2151), 23.3, 0, 23.3, 23.3, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2152), 20.7, 0, 20.7, 20.7, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2153), 18.1, 0, 18.1, 18.1, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2154), 18.5, 0, 18.5, 18.5, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2155), 15.3, 0, 15.3, 15.3, 5.4);  // Month - 2012-11-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2156), 16.5, 0, 16.5, 16.5, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2157), 20.8, 0, 20.8, 20.8, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2158), 19.7, 0, 19.7, 19.7, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2159), 18.5, 0, 18.5, 18.5, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2160), 20.5, 0, 20.5, 20.5, 3.2);  // Month - 2012-11-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2161), 21.2, 0, 21.2, 21.2, 6.5);  // Month - 2012-12-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2162), 23.5, 0, 23.5, 23.5, 7.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2163), 26.2, 0, 26.2, 26.2, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2164), 25.2, 0, 25.2, 25.2, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2165), 25.5, 0, 25.5, 25.5, 6.7);  // Month - 2012-12-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2166), 23.4, 0, 23.4, 23.4, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2167), 21.6, 0, 21.6, 21.6, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2168), 21.0, 0, 21.0, 21.0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2169), 22.7, 0, 22.7, 22.7, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2170), 24.5, 0, 24.5, 24.5, 5.0);  // Month - 2012-12-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2171), 21.5, 0, 21.5, 21.5, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2172), 23.5, 0, 23.5, 23.5, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2173), 22.0, 0, 22.0, 22.0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2174), 22.0, 0, 22.0, 22.0, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2175), 24.5, 0, 24.5, 24.5, 6.2);  // Month - 2012-12-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2176), 21.9, 0, 21.9, 21.9, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2177), 21.1, 0, 21.1, 21.1, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2178), 19.8, 0, 19.8, 19.8, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2179), 21.5, 0, 21.5, 21.5, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2180), 19.8, 0, 19.8, 19.8, 3.3);  // Month - 2012-12-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2181), 20.4, 0, 20.4, 20.4, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2182), 21.7, 0, 21.7, 21.7, 7.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2183), 23.6, 0, 23.6, 23.6, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2184), 29.5, 0, 29.5, 29.5, 8.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2185), 24.3, 0, 24.3, 24.3, 4.3);  // Month - 2012-12-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2186), 18.3, 0, 18.3, 18.3, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2187), 18.4, 0, 18.4, 18.4, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2188), 19.0, 0, 19.0, 19.0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2189), 22.4, 0, 22.4, 22.4, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2190), 26.0, 0, 26.0, 26.0, 7.4);  // Month - 2012-12-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2191), 26.7, 0, 26.7, 26.7, 6.4);


            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2192), 17.8, 0, 17.8, 17.8, 6.3);  // Month - 2013-1-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2193), 15.7, 0, 15.7, 15.7, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2194), 17.7, 0, 17.7, 17.7, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2195), 23.7, 0, 23.7, 23.7, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2196), 25.5, 0, 25.5, 25.5, 5.8);  // Month - 2013-1-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2197), 24.2, 0, 24.2, 24.2, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2198), 25.0, 0, 25.0, 25.0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2199), 23.6, 0, 23.6, 23.6, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2200), 22.7, 0, 22.7, 22.7, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2201), 23.3, 0, 23.3, 23.3, 6.7);  // Month - 2013-1-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2202), 23.8, 0, 23.8, 23.8, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2203), 22.8, 0, 22.8, 22.8, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2204), 23.9, 0, 23.9, 23.9, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2205), 22.9, 0, 22.9, 22.9, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2206), 23.8, 0, 23.8, 23.8, 6.7);  // Month - 2013-1-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2207), 24.2, 0, 24.2, 24.2, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2208), 24.5, 0, 24.5, 24.5, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2209), 23.2, 0, 23.2, 23.2, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2210), 21.0, 0, 21.0, 21.0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2211), 20.7, 0, 20.7, 20.7, 6.1);  // Month - 2013-1-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2212), 21.2, 0, 21.2, 21.2, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2213), 23.6, 0, 23.6, 23.6, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2214), 25.1, 0, 25.1, 25.1, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2215), 25.3, 0, 25.3, 25.3, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2216), 18.0, 0, 18.0, 18.0, 6.2);  // Month - 2013-1-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2217), 18.4, 0, 18.4, 18.4, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2218), 21.8, 0, 21.8, 21.8, 7.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2219), 25.7, 0, 25.7, 25.7, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2220), 26.7, 0, 26.7, 26.7, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2221), 25.7, 0, 25.7, 25.7, 6.4);  // Month - 2013-1-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2222), 25.9, 0, 25.9, 25.9, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2223), 27.5, 0, 27.5, 27.5, 7.1);  // Month - 2013-2-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2224), 23.5, 0, 23.5, 23.5, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2225), 16.9, 0, 16.9, 16.9, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2226), 18.0, 0, 18.0, 18.0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2227), 21.3, 0, 21.3, 21.3, 6.0);  // Month - 2013-2-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2228), 22.3, 0, 22.3, 22.3, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2229), 22.4, 0, 22.4, 22.4, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2230), 23.6, 0, 23.6, 23.6, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2231), 25.0, 0, 25.0, 25.0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2232), 26.5, 0, 26.5, 26.5, 3.7);  // Month - 2013-2-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2233), 24.7, 0, 24.7, 24.7, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2234), 25.8, 0, 25.8, 25.8, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2235), 24.7, 0, 24.7, 24.7, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2236), 24.6, 0, 24.6, 24.6, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2237), 24.7, 0, 24.7, 24.7, 5.9);  // Month - 2013-2-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2238), 26.9, 0, 26.9, 26.9, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2239), 25.6, 0, 25.6, 25.6, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2240), 19.7, 0, 19.7, 19.7, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2241), 17.7, 0, 17.7, 17.7, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2242), 20.2, 0, 20.2, 20.2, 3.1);  // Month - 2013-2-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2243), 20.1, 0, 20.1, 20.1, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2244), 20.6, 0, 20.6, 20.6, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2245), 22.2, 0, 22.2, 22.2, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2246), 22.7, 0, 22.7, 22.7, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2247), 19.1, 0, 19.1, 19.1, 5.7);  // Month - 2013-2-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2248), 16.6, 0, 16.6, 16.6, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2249), 16.6, 0, 16.6, 16.6, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2250), 16.9, 0, 16.9, 16.9, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2251), 20.9, 0, 20.9, 20.9, 5.6);  // Month - 2013-3-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2252), 21.3, 0, 21.3, 21.3, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2253), 18.7, 0, 18.7, 18.7, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2254), 16.6, 0, 16.6, 16.6, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2255), 16.9, 0, 16.9, 16.9, 4.0);  // Month - 2013-3-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2256), 19.3, 0, 19.3, 19.3, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2257), 21.8, 0, 21.8, 21.8, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2258), 23.9, 0, 23.9, 23.9, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2259), 24.5, 0, 24.5, 24.5, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2260), 18.3, 0, 18.3, 18.3, 4.5);  // Month - 2013-3-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2261), 18.4, 0, 18.4, 18.4, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2262), 15.9, 0, 15.9, 15.9, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2263), 14.5, 0, 14.5, 14.5, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2264), 13.9, 0, 13.9, 13.9, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2265), 14.4, 0, 14.4, 14.4, 2.5);  // Month - 2013-3-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2266), 13.7, 0, 13.7, 13.7, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2267), 15.0, 0, 15.0, 15.0, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2268), 16.9, 0, 16.9, 16.9, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2269), 19.6, 0, 19.6, 19.6, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2270), 18.8, 0, 18.8, 18.8, 2.0);  // Month - 2013-3-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2271), 19.7, 0, 19.7, 19.7, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2272), 15.3, 0, 15.3, 15.3, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2273), 16.2, 0, 16.2, 16.2, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2274), 18.9, 0, 18.9, 18.9, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2275), 19.0, 0, 19.0, 19.0, 2.6);  // Month - 2013-3-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2276), 17.0, 0, 17.0, 17.0, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2277), 15.4, 0, 15.4, 15.4, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2278), 17.1, 0, 17.1, 17.1, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2279), 19.2, 0, 19.2, 19.2, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2280), 21.0, 0, 21.0, 21.0, 3.4);  // Month - 2013-3-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2281), 23.3, 0, 23.3, 23.3, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2282), 22.8, 0, 22.8, 22.8, 3.5);  // Month - 2013-4-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2283), 20.9, 0, 20.9, 20.9, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2284), 20.9, 0, 20.9, 20.9, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2285), 19.3, 0, 19.3, 19.3, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2286), 19.1, 0, 19.1, 19.1, 3.0);  // Month - 2013-4-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2287), 17.0, 0, 17.0, 17.0, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2288), 13.4, 0, 13.4, 13.4, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2289), 14.3, 0, 14.3, 14.3, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2290), 15.5, 0, 15.5, 15.5, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2291), 17.0, 0, 17.0, 17.0, 3.0);  // Month - 2013-4-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2292), 18.5, 0, 18.5, 18.5, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2293), 15.7, 0, 15.7, 15.7, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2294), 12.4, 0, 12.4, 12.4, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2295), 14.8, 0, 14.8, 14.8, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2296), 15.7, 0, 15.7, 15.7, 2.4);  // Month - 2013-4-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2297), 14.2, 0, 14.2, 14.2, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2298), 13.4, 0, 13.4, 13.4, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2299), 17.4, 0, 17.4, 17.4, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2300), 18.2, 0, 18.2, 18.2, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2301), 19.3, 0, 19.3, 19.3, 2.4);  // Month - 2013-4-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2302), 18.7, 0, 18.7, 18.7, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2303), 18.2, 0, 18.2, 18.2, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2304), 20.8, 0, 20.8, 20.8, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2305), 18.5, 0, 18.5, 18.5, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2306), 19.2, 0, 19.2, 19.2, 2.0);  // Month - 2013-4-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2307), 19.5, 0, 19.5, 19.5, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2308), 19.9, 0, 19.9, 19.9, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2309), 17.7, 0, 17.7, 17.7, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2310), 15.8, 0, 15.8, 15.8, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2311), 15.9, 0, 15.9, 15.9, 1.7);  // Month - 2013-4-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2312), 15.7, 0, 15.7, 15.7, 1.5);  // Month - 2013-5-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2313), 18.6, 0, 18.6, 18.6, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2314), 15.8, 0, 15.8, 15.8, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2315), 13.8, 0, 13.8, 13.8, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2316), 12.8, 0, 12.8, 12.8, 1.7);  // Month - 2013-5-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2317), 15.3, 0, 15.3, 15.3, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2318), 11.6, 0, 11.6, 11.6, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2319), 14.4, 0, 14.4, 14.4, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2320), 17.2, 0, 17.2, 17.2, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2321), 16.6, 0, 16.6, 16.6, 2.0);  // Month - 2013-5-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2322), 17.3, 0, 17.3, 17.3, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2323), 16.0, 0, 16.0, 16.0, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2324), 12.7, 0, 12.7, 12.7, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2325), 15.4, 0, 15.4, 15.4, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2326), 10.7, 0, 10.7, 10.7, 2.9);  // Month - 2013-5-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2327), 08.0, 0, 08.0, 08.0, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2328), 08.9, 0, 08.9, 08.9, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2329), 08.8, 0, 08.8, 08.8, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2330), 11.5, 0, 11.5, 11.5, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2331), 12.3, 0, 12.3, 12.3, 1.0);  // Month - 2013-5-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2332), 12.8, 0, 12.8, 12.8, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2333), 15.4, 0, 15.4, 15.4, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2334), 14.1, 0, 14.1, 14.1, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2335), 12.8, 0, 12.8, 12.8, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2336), 10.9, 0, 10.9, 10.9, 0.8);  // Month - 2013-5-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2337), 13.4, 0, 13.4, 13.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2338), 13.5, 0, 13.5, 13.5, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2339), 14.7, 0, 14.7, 14.7, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2340), 12.1, 0, 12.1, 12.1, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2341), 12.6, 0, 12.6, 12.6, 1.8);  // Month - 2013-5-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2342), 14.3, 0, 14.3, 14.3, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2343), 14.9, 0, 14.9, 14.9, 1.3);  // Month - 2013-6-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2344), 11.7, 0, 11.7, 11.7, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2345), 12.6, 0, 12.6, 12.6, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2346), 13.9, 0, 13.9, 13.9, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2347), 13.6, 0, 13.6, 13.6, 2.4);  // Month - 2013-6-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2348), 08.8, 0, 08.8, 08.8, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2349), 10.9, 0, 10.9, 10.9, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2350), 09.2, 0, 09.2, 09.2, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2351), 09.0, 0, 09.0, 09.0, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2352), 12.5, 0, 12.5, 12.5, 0.6);  // Month - 2013-6-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2353), 14.5, 0, 14.5, 14.5, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2354), 17.4, 0, 17.4, 17.4, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2355), 18.8, 0, 18.8, 18.8, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2356), 09.5, 0, 09.5, 09.5, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2357), 08.0, 0, 08.0, 08.0, 0.8);  // Month - 2013-6-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2358), 10.4, 0, 10.4, 10.4, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2359), 10.2, 0, 10.2, 10.2, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2360), 09.5, 0, 09.5, 09.5, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2361), 05.3, 0, 05.3, 05.3, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2362), 05.3, 0, 05.3, 05.3, 0.4);  // Month - 2013-6-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2363), 07.2, 0, 07.2, 07.2, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2364), 08.5, 0, 08.5, 08.5, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2365), 07.2, 0, 07.2, 07.2, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2366), 07.4, 0, 07.4, 07.4, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2367), 09.3, 0, 09.3, 09.3, 0.7);  // Month - 2013-6-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2368), 09.3, 0, 09.3, 09.3, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2369), 12.0, 0, 12.0, 12.0, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2370), 12.2, 0, 12.2, 12.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2371), 11.0, 0, 11.0, 11.0, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2372), 08.5, 0, 08.5, 08.5, 0.7);  // Month - 2013-6-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2373), 08.8, 0, 08.8, 08.8, 0.8);  // Month - 2013-7-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2374), 12.7, 0, 12.7, 12.7, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2375), 15.3, 0, 15.3, 15.3, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2376), 13.0, 0, 13.0, 13.0, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2377), 14.5, 0, 14.5, 14.5, 0.7);  // Month - 2013-7-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2378), 13.4, 0, 13.4, 13.4, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2379), 07.6, 0, 07.6, 07.6, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2380), 07.2, 0, 07.2, 07.2, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2381), 09.2, 0, 09.2, 09.2, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2382), 13.4, 0, 13.4, 13.4, 0.8);  // Month - 2013-7-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2383), 16.4, 0, 16.4, 16.4, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2384), 10.4, 0, 10.4, 10.4, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2385), 10.7, 0, 10.7, 10.7, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2386), 08.3, 0, 08.3, 08.3, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2387), 07.9, 0, 07.9, 07.9, 0.9);  // Month - 2013-7-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2388), 13.4, 0, 13.4, 13.4, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2389), 15.4, 0, 15.4, 15.4, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2390), 11.5, 0, 11.5, 11.5, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2391), 05.3, 0, 05.3, 05.3, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2392), 04.7, 0, 04.7, 04.7, 0.9);  // Month - 2013-7-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2393), 04.5, 0, 04.5, 04.5, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2394), 05.7, 0, 05.7, 05.7, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2395), 05.7, 0, 05.7, 05.7, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2396), 06.1, 0, 06.1, 06.1, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2397), 07.5, 0, 07.5, 07.5, 1.2);  // Month - 2013-7-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2398), 08.8, 0, 08.8, 08.8, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2399), 13.0, 0, 13.0, 13.0, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2400), 10.1, 0, 10.1, 10.1, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2401), 11.7, 0, 11.7, 11.7, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2402), 13.0, 0, 13.0, 13.0, 1.5);  // Month - 2013-7-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2403), 17.0, 0, 17.0, 17.0, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2404), 10.7, 0, 10.7, 10.7, 0.9);  // Month - 2013-8-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2405), 09.0, 0, 09.0, 09.0, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2406), 08.2, 0, 08.2, 08.2, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2407), 10.2, 0, 10.2, 10.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2408), 12.4, 0, 12.4, 12.4, 1.6);  // Month - 2013-8-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2409), 10.8, 0, 10.8, 10.8, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2410), 13.1, 0, 13.1, 13.1, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2411), 08.9, 0, 08.9, 08.9, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2412), 06.8, 0, 06.8, 06.8, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2413), 06.6, 0, 06.6, 06.6, 1.3);  // Month - 2013-8-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2414), 09.1, 0, 09.1, 09.1, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2415), 11.3, 0, 11.3, 11.3, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2416), 06.5, 0, 06.5, 06.5, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2417), 05.8, 0, 05.8, 05.8, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2418), 06.9, 0, 06.9, 06.9, 1.9);  // Month - 2013-8-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2419), 08.5, 0, 08.5, 08.5, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2420), 06.5, 0, 06.5, 06.5, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2421), 11.7, 0, 11.7, 11.7, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2422), 16.7, 0, 16.7, 16.7, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2423), 17.9, 0, 17.9, 17.9, 2.5);  // Month - 2013-8-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2424), 16.3, 0, 16.3, 16.3, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2425), 09.7, 0, 09.7, 09.7, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2426), 05.2, 0, 05.2, 05.2, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2427), 05.8, 0, 05.8, 05.8, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2428), 05.9, 0, 05.9, 05.9, 1.6);  // Month - 2013-8-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2429), 06.4, 0, 06.4, 06.4, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2430), 06.7, 0, 06.7, 06.7, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2431), 14.4, 0, 14.4, 14.4, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2432), 15.5, 0, 15.5, 15.5, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2433), 17.0, 0, 17.0, 17.0, 3.2);  // Month - 2013-8-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2434), 17.1, 0, 17.1, 17.1, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2435), 16.7, 0, 16.7, 16.7, 2.6);  // Month - 2013-9-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2436), 13.0, 0, 13.0, 13.0, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2437), 08.3, 0, 08.3, 08.3, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2438), 07.8, 0, 07.8, 07.8, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2439), 12.0, 0, 12.0, 12.0, 1.8);  // Month - 2013-9-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2440), 17.5, 0, 17.5, 17.5, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2441), 16.6, 0, 16.6, 16.6, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2442), 15.3, 0, 15.3, 15.3, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2443), 18.3, 0, 18.3, 18.3, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2444), 26.9, 0, 26.9, 26.9, 4.9);  // Month - 2013-9-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2445), 27.0, 0, 27.0, 27.0, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2446), 21.6, 0, 21.6, 21.6, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2447), 11.4, 0, 11.4, 11.4, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2448), 10.3, 0, 10.3, 10.3, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2449), 10.9, 0, 10.9, 10.9, 1.5);  // Month - 2013-9-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2450), 09.8, 0, 09.8, 09.8, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2451), 07.7, 0, 07.7, 07.7, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2452), 09.4, 0, 09.4, 09.4, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2453), 12.0, 0, 12.0, 12.0, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2454), 12.2, 0, 12.2, 12.2, 2.2);  // Month - 2013-9-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2455), 11.4, 0, 11.4, 11.4, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2456), 10.4, 0, 10.4, 10.4, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2457), 08.8, 0, 08.8, 08.8, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2458), 09.3, 0, 09.3, 09.3, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2459), 09.4, 0, 09.4, 09.4, 2.6);  // Month - 2013-9-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2460), 11.1, 0, 11.1, 11.1, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2461), 14.3, 0, 14.3, 14.3, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2462), 16.5, 0, 16.5, 16.5, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2463), 12.2, 0, 12.2, 12.2, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2464), 10.3, 0, 10.3, 10.3, 2.7);  // Month - 2013-9-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2465), 10.7, 0, 10.7, 10.7, 2.7);  // Month - 2013-10-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2466), 14.0, 0, 14.0, 14.0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2467), 14.1, 0, 14.1, 14.1, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2468), 14.0, 0, 14.0, 14.0, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2469), 13.7, 0, 13.7, 13.7, 2.6);  // Month - 2013-10-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2470), 13.6, 0, 13.6, 13.6, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2471), 15.3, 0, 15.3, 15.3, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2472), 17.4, 0, 17.4, 17.4, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2473), 19.9, 0, 19.9, 19.9, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2474), 19.0, 0, 19.0, 19.0, 4.3);  // Month - 2013-10-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2475), 15.6, 0, 15.6, 15.6, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2476), 17.5, 0, 17.5, 17.5, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2477), 16.8, 0, 16.8, 16.8, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2478), 18.2, 0, 18.2, 18.2, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2479), 19.3, 0, 19.3, 19.3, 4.4);  // Month - 2013-10-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2480), 19.6, 0, 19.6, 19.6, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2481), 20.4, 0, 20.4, 20.4, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2482), 15.2, 0, 15.2, 15.2, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2483), 17.8, 0, 17.8, 17.8, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2484), 17.5, 0, 17.5, 17.5, 2.2);  // Month - 2013-10-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2485), 11.3, 0, 11.3, 11.3, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2486), 12.9, 0, 12.9, 12.9, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2487), 19.2, 0, 19.2, 19.2, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2488), 11.9, 0, 11.9, 11.9, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2489), 12.0, 0, 12.0, 12.0, 3.8);  // Month - 2013-10-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2490), 16.5, 0, 16.5, 16.5, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2491), 13.0, 0, 13.0, 13.0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2492), 13.0, 0, 13.0, 13.0, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2493), 17.6, 0, 17.6, 17.6, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2494), 18.7, 0, 18.7, 18.7, 5.4);  // Month - 2013-10-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2495), 19.9, 0, 19.9, 19.9, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2496), 19.1, 0, 19.1, 19.1, 2.1);  // Month - 2013-11-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2497), 16.7, 0, 16.7, 16.7, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2498), 15.3, 0, 15.3, 15.3, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2499), 15.1, 0, 15.1, 15.1, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2500), 15.9, 0, 15.9, 15.9, 5.1);  // Month - 2013-11-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2501), 19.5, 0, 19.5, 19.5, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2502), 20.5, 0, 20.5, 20.5, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2503), 18.9, 0, 18.9, 18.9, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2504), 19.3, 0, 19.3, 19.3, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2505), 20.6, 0, 20.6, 20.6, 3.5);  // Month - 2013-11-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2506), 17.6, 0, 17.6, 17.6, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2507), 20.5, 0, 20.5, 20.5, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2508), 18.5, 0, 18.5, 18.5, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2509), 22.5, 0, 22.5, 22.5, 7.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2510), 19.7, 0, 19.7, 19.7, 5.5);  // Month - 2013-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2511), 15.2, 0, 15.2, 15.2, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2512), 17.8, 0, 17.8, 17.8, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2513), 20.5, 0, 20.5, 20.5, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2514), 18.7, 0, 18.7, 18.7, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2515), 19.1, 0, 19.1, 19.1, 2.4);  // Month - 2013-11-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2516), 17.2, 0, 17.2, 17.2, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2517), 19.1, 0, 19.1, 19.1, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2518), 21.2, 0, 21.2, 21.2, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2519), 23.6, 0, 23.6, 23.6, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2520), 22.5, 0, 22.5, 22.5, 3.6);  // Month - 2013-11-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2521), 18.3, 0, 18.3, 18.3, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2522), 17.6, 0, 17.6, 17.6, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2523), 18.3, 0, 18.3, 18.3, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2524), 18.2, 0, 18.2, 18.2, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2525), 19.9, 0, 19.9, 19.9, 6.3);  // Month - 2013-11-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2526), 22.6, 0, 22.6, 22.6, 6.3);  // Month - 2013-12-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2527), 25.9, 0, 25.9, 25.9, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2528), 14.9, 0, 14.9, 14.9, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2529), 20.3, 0, 20.3, 20.3, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2530), 16.9, 0, 16.9, 16.9, 5.6);  // Month - 2013-12-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2531), 16.0, 0, 16.0, 16.0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2532), 20.4, 0, 20.4, 20.4, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2533), 25.7, 0, 25.7, 25.7, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2534), 20.0, 0, 20.0, 20.0, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2535), 18.3, 0, 18.3, 18.3, 4.9);  // Month - 2013-12-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2536), 18.8, 0, 18.8, 18.8, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2537), 21.0, 0, 21.0, 21.0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2538), 23.0, 0, 23.0, 23.0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2539), 24.9, 0, 24.9, 24.9, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2540), 26.3, 0, 26.3, 26.3, 6.9);  // Month - 2013-12-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2541), 26.3, 0, 26.3, 26.3, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2542), 27.0, 0, 27.0, 27.0, 7.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2543), 26.4, 0, 26.4, 26.4, 7.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2544), 24.2, 0, 24.2, 24.2, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2545), 24.1, 0, 24.1, 24.1, 6.5);  // Month - 2013-12-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2546), 24.8, 0, 24.8, 24.8, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2547), 25.9, 0, 25.9, 25.9, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2548), 26.8, 0, 26.8, 26.8, 7.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2549), 27.0, 0, 27.0, 27.0, 7.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2550), 28.8, 0, 28.8, 28.8, 8.1);  // Month - 2013-12-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2551), 30.8, 0, 30.8, 30.8, 7.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2552), 27.4, 0, 27.4, 27.4, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2553), 27.3, 0, 27.3, 27.3, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2554), 29.0, 0, 29.0, 29.0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2555), 29.3, 0, 29.3, 29.3, 8.5);  // Month - 2013-12-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2556), 24.8, 0, 24.8, 24.8, 5.4);


            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2557), 26.7, 0, 26.7, 26.7, 6.5);  // Month - 2014-1-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2558), 22.6, 0, 22.6, 22.6, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2559), 18.5, 0, 18.5, 18.5, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2560), 20.8, 0, 20.8, 20.8, 7.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2561), 24.6, 0, 24.6, 24.6, 7.0);  // Month - 2014-1-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2562), 26.8, 0, 26.8, 26.8, 8.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2563), 22.5, 0, 22.5, 22.5, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2564), 21.9, 0, 21.9, 21.9, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2565), 23.6, 0, 23.6, 23.6, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2566), 24.2, 0, 24.2, 24.2, 4.7);  // Month - 2014-1-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2567), 18.6, 0, 18.6, 18.6, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2568), 17.1, 0, 17.1, 17.1, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2569), 21.0, 0, 21.0, 21.0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2570), 22.5, 0, 22.5, 22.5, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2571), 24.3, 0, 24.3, 24.3, 6.5);  // Month - 2014-1-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2572), 26.4, 0, 26.4, 26.4, 7.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2573), 28.3, 0, 28.3, 28.3, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2574), 29.1, 0, 29.1, 29.1, 8.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2575), 24.4, 0, 24.4, 24.4, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2576), 25.8, 0, 25.8, 25.8, 5.0);  // Month - 2014-1-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2577), 24.0, 0, 24.0, 24.0, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2578), 26.6, 0, 26.6, 26.6, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2579), 28.2, 0, 28.2, 28.2, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2580), 19.2, 0, 19.2, 19.2, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2581), 16.3, 0, 16.3, 16.3, 5.4);  // Month - 2014-1-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2582), 19.6, 0, 19.6, 19.6, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2583), 22.8, 0, 22.8, 22.8, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2584), 22.7, 0, 22.7, 22.7, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2585), 24.0, 0, 24.0, 24.0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2586), 24.2, 0, 24.2, 24.2, 3.5);  // Month - 2014-1-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2587), 26.3, 0, 26.3, 26.3, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2588), 22.3, 0, 22.3, 22.3, 2.4);  // Month - 2014-2-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2589), 21.6, 0, 21.6, 21.6, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2590), 19.8, 0, 19.8, 19.8, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2591), 22.9, 0, 22.9, 22.9, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2592), 28.5, 0, 28.5, 28.5, 5.8);  // Month - 2014-2-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2593), 19.2, 0, 19.2, 19.2, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2594), 21.2, 0, 21.2, 21.2, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2595), 27.4, 0, 27.4, 27.4, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2596), 23.3, 0, 23.3, 23.3, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2597), 22.4, 0, 22.4, 22.4, 3.4);  // Month - 2014-2-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2598), 25.5, 0, 25.5, 25.5, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2599), 23.5, 0, 23.5, 23.5, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2600), 21.3, 0, 21.3, 21.3, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2601), 19.1, 0, 19.1, 19.1, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2602), 19.0, 0, 19.0, 19.0, 4.7);  // Month - 2014-2-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2603), 22.4, 0, 22.4, 22.4, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2604), 23.8, 0, 23.8, 23.8, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2605), 24.6, 0, 24.6, 24.6, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2606), 24.1, 0, 24.1, 24.1, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2607), 23.2, 0, 23.2, 23.2, 3.3);  // Month - 2014-2-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2608), 22.4, 0, 22.4, 22.4, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2609), 22.2, 0, 22.2, 22.2, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2610), 21.0, 0, 21.0, 21.0, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2611), 21.3, 0, 21.3, 21.3, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2612), 19.4, 0, 19.4, 19.4, 3.6);  // Month - 2014-2-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2613), 18.6, 0, 18.6, 18.6, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2614), 18.1, 0, 18.1, 18.1, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2615), 18.9, 0, 18.9, 18.9, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2616), 18.4, 0, 18.4, 18.4, 3.7);  // Month - 2014-3-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2617), 18.1, 0, 18.1, 18.1, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2618), 19.5, 0, 19.5, 19.5, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2619), 22.7, 0, 22.7, 22.7, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2620), 20.8, 0, 20.8, 20.8, 3.4);  // Month - 2014-3-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2621), 19.3, 0, 19.3, 19.3, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2622), 17.6, 0, 17.6, 17.6, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2623), 18.5, 0, 18.5, 18.5, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2624), 19.8, 0, 19.8, 19.8, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2625), 17.8, 0, 17.8, 17.8, 3.2);  // Month - 2014-3-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2626), 18.8, 0, 18.8, 18.8, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2627), 20.8, 0, 20.8, 20.8, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2628), 20.5, 0, 20.5, 20.5, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2629), 23.2, 0, 23.2, 23.2, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2630), 20.3, 0, 20.3, 20.3, 3.7);  // Month - 2014-3-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2631), 21.2, 0, 21.2, 21.2, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2632), 20.3, 0, 20.3, 20.3, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2633), 16.5, 0, 16.5, 16.5, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2634), 16.4, 0, 16.4, 16.4, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2635), 17.8, 0, 17.8, 17.8, 2.9);  // Month - 2014-3-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2636), 16.0, 0, 16.0, 16.0, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2637), 13.6, 0, 13.6, 13.6, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2638), 15.2, 0, 15.2, 15.2, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2639), 17.6, 0, 17.6, 17.6, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2640), 18.0, 0, 18.0, 18.0, 3.3);  // Month - 2014-3-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2641), 21.9, 0, 21.9, 21.9, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2642), 23.1, 0, 23.1, 23.1, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2643), 22.3, 0, 22.3, 22.3, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2644), 23.4, 0, 23.4, 23.4, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2645), 20.5, 0, 20.5, 20.5, 2.1);  // Month - 2014-3-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2646), 17.0, 0, 17.0, 17.0, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2647), 17.7, 0, 17.7, 17.7, 3.1);  // Month - 2014-4-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2648), 21.0, 0, 21.0, 21.0, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2649), 22.4, 0, 22.4, 22.4, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2650), 23.8, 0, 23.8, 23.8, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2651), 22.8, 0, 22.8, 22.8, 1.7);  // Month - 2014-4-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2652), 23.7, 0, 23.7, 23.7, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2653), 22.0, 0, 22.0, 22.0, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2654), 19.6, 0, 19.6, 19.6, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2655), 17.9, 0, 17.9, 17.9, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2656), 17.0, 0, 17.0, 17.0, 2.0);  // Month - 2014-4-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2657), 16.9, 0, 16.9, 16.9, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2658), 14.3, 0, 14.3, 14.3, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2659), 14.2, 0, 14.2, 14.2, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2660), 13.4, 0, 13.4, 13.4, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2661), 14.6, 0, 14.6, 14.6, 2.4);  // Month - 2014-4-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2662), 16.6, 0, 16.6, 16.6, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2663), 17.5, 0, 17.5, 17.5, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2664), 14.5, 0, 14.5, 14.5, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2665), 13.3, 0, 13.3, 13.3, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2666), 15.0, 0, 15.0, 15.0, 1.8);  // Month - 2014-4-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2667), 16.1, 0, 16.1, 16.1, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2668), 13.4, 0, 13.4, 13.4, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2669), 13.0, 0, 13.0, 13.0, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2670), 14.3, 0, 14.3, 14.3, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2671), 12.0, 0, 12.0, 12.0, 1.6);  // Month - 2014-4-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2672), 13.6, 0, 13.6, 13.6, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2673), 16.7, 0, 16.7, 16.7, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2674), 18.2, 0, 18.2, 18.2, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2675), 17.9, 0, 17.9, 17.9, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2676), 18.7, 0, 18.7, 18.7, 1.4);  // Month - 2014-4-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2677), 14.8, 0, 14.8, 14.8, 1.4);  // Month - 2014-5-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2678), 16.1, 0, 16.1, 16.1, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2679), 15.6, 0, 15.6, 15.6, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2680), 18.2, 0, 18.2, 18.2, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2681), 16.9, 0, 16.9, 16.9, 1.2);  // Month - 2014-5-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2682), 17.1, 0, 17.1, 17.1, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2683), 15.0, 0, 15.0, 15.0, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2684), 14.7, 0, 14.7, 14.7, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2685), 15.2, 0, 15.2, 15.2, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2686), 14.4, 0, 14.4, 14.4, 1.6);  // Month - 2014-5-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2687), 15.9, 0, 15.9, 15.9, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2688), 16.4, 0, 16.4, 16.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2689), 15.6, 0, 15.6, 15.6, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2690), 15.6, 0, 15.6, 15.6, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2691), 14.6, 0, 14.6, 14.6, 1.2);  // Month - 2014-5-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2692), 11.3, 0, 11.3, 11.3, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2693), 11.9, 0, 11.9, 11.9, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2694), 12.0, 0, 12.0, 12.0, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2695), 11.7, 0, 11.7, 11.7, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2696), 10.9, 0, 10.9, 10.9, 0.9);  // Month - 2014-5-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2697), 12.3, 0, 12.3, 12.3, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2698), 12.4, 0, 12.4, 12.4, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2699), 08.2, 0, 08.2, 08.2, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2700), 09.1, 0, 09.1, 09.1, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2701), 09.8, 0, 09.8, 09.8, 0.7);  // Month - 2014-5-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2702), 11.0, 0, 11.0, 11.0, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2703), 08.6, 0, 08.6, 08.6, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2704), 08.9, 0, 08.9, 08.9, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2705), 12.7, 0, 12.7, 12.7, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2706), 12.8, 0, 12.8, 12.8, 0.9);  // Month - 2014-5-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2707), 14.1, 0, 14.1, 14.1, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2708), 12.6, 0, 12.6, 12.6, 1.0);  // Month - 2014-6-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2709), 12.1, 0, 12.1, 12.1, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2710), 11.9, 0, 11.9, 11.9, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2711), 12.0, 0, 12.0, 12.0, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2712), 11.5, 0, 11.5, 11.5, 0.8);  // Month - 2014-6-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2713), 08.4, 0, 08.4, 08.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2714), 09.9, 0, 09.9, 09.9, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2715), 10.5, 0, 10.5, 10.5, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2716), 12.0, 0, 12.0, 12.0, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2717), 11.9, 0, 11.9, 11.9, 1.5);  // Month - 2014-6-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2718), 13.5, 0, 13.5, 13.5, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2719), 18.1, 0, 18.1, 18.1, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2720), 08.8, 0, 08.8, 08.8, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2721), 07.3, 0, 07.3, 07.3, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2722), 10.0, 0, 10.0, 10.0, 0.8);  // Month - 2014-6-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2723), 09.7, 0, 09.7, 09.7, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2724), 07.8, 0, 07.8, 07.8, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2725), 08.4, 0, 08.4, 08.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2726), 06.9, 0, 06.9, 06.9, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2727), 08.4, 0, 08.4, 08.4, 0.8);  // Month - 2014-6-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2728), 10.0, 0, 10.0, 10.0, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2729), 13.1, 0, 13.1, 13.1, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2730), 13.3, 0, 13.3, 13.3, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2731), 09.5, 0, 09.5, 09.5, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2732), 08.1, 0, 08.1, 08.1, 0.3);  // Month - 2014-6-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2733), 08.9, 0, 08.9, 08.9, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2734), 09.9, 0, 09.9, 09.9, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2735), 07.5, 0, 07.5, 07.5, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2736), 09.2, 0, 09.2, 09.2, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2737), 10.6, 0, 10.6, 10.6, 0.6);  // Month - 2014-6-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2738), 08.9, 0, 08.9, 08.9, 0.8);  // Month - 2014-7-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2739), 08.0, 0, 08.0, 08.0, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2740), 10.6, 0, 10.6, 10.6, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2741), 09.8, 0, 09.8, 09.8, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2742), 13.2, 0, 13.2, 13.2, 0.9);  // Month - 2014-7-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2743), 07.9, 0, 07.9, 07.9, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2744), 09.8, 0, 09.8, 09.8, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2745), 10.2, 0, 10.2, 10.2, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2746), 09.7, 0, 09.7, 09.7, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2747), 10.7, 0, 10.7, 10.7, 0.8);  // Month - 2014-7-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2748), 12.5, 0, 12.5, 12.5, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2749), 14.9, 0, 14.9, 14.9, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2750), 14.9, 0, 14.9, 14.9, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2751), 16.1, 0, 16.1, 16.1, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2752), 15.8, 0, 15.8, 15.8, 1.0);  // Month - 2014-7-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2753), 12.9, 0, 12.9, 12.9, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2754), 11.9, 0, 11.9, 11.9, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2755), 10.1, 0, 10.1, 10.1, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2756), 12.3, 0, 12.3, 12.3, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2757), 14.3, 0, 14.3, 14.3, 1.3);  // Month - 2014-7-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2758), 13.9, 0, 13.9, 13.9, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2759), 12.9, 0, 12.9, 12.9, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2760), 11.0, 0, 11.0, 11.0, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2761), 07.9, 0, 07.9, 07.9, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2762), 07.1, 0, 07.1, 07.1, 1.5);  // Month - 2014-7-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2763), 04.5, 0, 04.5, 04.5, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2764), 05.0, 0, 05.0, 05.0, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2765), 08.2, 0, 08.2, 08.2, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2766), 14.3, 0, 14.3, 14.3, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2767), 13.7, 0, 13.7, 13.7, 1.3);  // Month - 2014-7-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2768), 15.4, 0, 15.4, 15.4, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2769), 16.9, 0, 16.9, 16.9, 1.1);  // Month - 2014-8-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2770), 18.7, 0, 18.7, 18.7, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2771), 17.3, 0, 17.3, 17.3, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2772), 10.1, 0, 10.1, 10.1, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2773), 09.9, 0, 09.9, 09.9, 1.7);  // Month - 2014-8-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2774), 11.3, 0, 11.3, 11.3, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2775), 10.4, 0, 10.4, 10.4, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2776), 09.4, 0, 09.4, 09.4, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2777), 10.4, 0, 10.4, 10.4, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2778), 11.4, 0, 11.4, 11.4, 1.0);  // Month - 2014-8-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2779), 08.0, 0, 08.0, 08.0, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2780), 08.8, 0, 08.8, 08.8, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2781), 08.7, 0, 08.7, 08.7, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2782), 09.8, 0, 09.8, 09.8, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2783), 10.3, 0, 10.3, 10.3, 2.0);  // Month - 2014-8-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2784), 12.5, 0, 12.5, 12.5, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2785), 14.4, 0, 14.4, 14.4, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2786), 17.1, 0, 17.1, 17.1, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2787), 16.0, 0, 16.0, 16.0, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2788), 17.7, 0, 17.7, 17.7, 2.3);  // Month - 2014-8-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2789), 21.7, 0, 21.7, 21.7, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2790), 21.0, 0, 21.0, 21.0, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2791), 20.2, 0, 20.2, 20.2, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2792), 16.1, 0, 16.1, 16.1, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2793), 09.7, 0, 09.7, 09.7, 2.7);  // Month - 2014-8-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2794), 09.2, 0, 09.2, 09.2, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2795), 08.1, 0, 08.1, 08.1, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2796), 08.0, 0, 08.0, 08.0, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2797), 10.9, 0, 10.9, 10.9, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2798), 13.0, 0, 13.0, 13.0, 1.6);  // Month - 2014-8-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2799), 13.3, 0, 13.3, 13.3, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2800), 13.9, 0, 13.9, 13.9, 1.9);  // Month - 2014-9-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2801), 15.4, 0, 15.4, 15.4, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2802), 17.2, 0, 17.2, 17.2, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2803), 16.9, 0, 16.9, 16.9, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2804), 17.8, 0, 17.8, 17.8, 2.3);  // Month - 2014-9-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2805), 14.4, 0, 14.4, 14.4, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2806), 14.8, 0, 14.8, 14.8, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2807), 16.1, 0, 16.1, 16.1, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2808), 16.0, 0, 16.0, 16.0, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2809), 12.4, 0, 12.4, 12.4, 2.5);  // Month - 2014-9-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2810), 12.0, 0, 12.0, 12.0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2811), 12.3, 0, 12.3, 12.3, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2812), 13.5, 0, 13.5, 13.5, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2813), 14.8, 0, 14.8, 14.8, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2814), 12.4, 0, 12.4, 12.4, 2.2);  // Month - 2014-9-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2815), 12.6, 0, 12.6, 12.6, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2816), 13.3, 0, 13.3, 13.3, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2817), 15.0, 0, 15.0, 15.0, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2818), 16.3, 0, 16.3, 16.3, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2819), 13.7, 0, 13.7, 13.7, 2.7);  // Month - 2014-9-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2820), 15.4, 0, 15.4, 15.4, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2821), 15.4, 0, 15.4, 15.4, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2822), 16.2, 0, 16.2, 16.2, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2823), 16.0, 0, 16.0, 16.0, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2824), 16.7, 0, 16.7, 16.7, 3.4);  // Month - 2014-9-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2825), 11.9, 0, 11.9, 11.9, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2826), 11.5, 0, 11.5, 11.5, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2827), 15.8, 0, 15.8, 15.8, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2828), 16.4, 0, 16.4, 16.4, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2829), 16.4, 0, 16.4, 16.4, 3.2);  // Month - 2014-9-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2830), 11.5, 0, 11.5, 11.5, 2.4);  // Month - 2014-10-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2831), 10.7, 0, 10.7, 10.7, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2832), 14.1, 0, 14.1, 14.1, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2833), 16.4, 0, 16.4, 16.4, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2834), 17.2, 0, 17.2, 17.2, 2.6);  // Month - 2014-10-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2835), 17.5, 0, 17.5, 17.5, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2836), 17.3, 0, 17.3, 17.3, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2837), 19.9, 0, 19.9, 19.9, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2838), 19.2, 0, 19.2, 19.2, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2839), 12.9, 0, 12.9, 12.9, 3.4);  // Month - 2014-10-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2840), 14.5, 0, 14.5, 14.5, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2841), 15.2, 0, 15.2, 15.2, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2842), 16.5, 0, 16.5, 16.5, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2843), 18.1, 0, 18.1, 18.1, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2844), 19.6, 0, 19.6, 19.6, 4.9);  // Month - 2014-10-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2845), 20.4, 0, 20.4, 20.4, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2846), 17.7, 0, 17.7, 17.7, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2847), 19.6, 0, 19.6, 19.6, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2848), 18.3, 0, 18.3, 18.3, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2849), 15.9, 0, 15.9, 15.9, 4.1);  // Month - 2014-10-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2850), 19.2, 0, 19.2, 19.2, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2851), 21.8, 0, 21.8, 21.8, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2852), 22.0, 0, 22.0, 22.0, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2853), 22.7, 0, 22.7, 22.7, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2854), 23.0, 0, 23.0, 23.0, 5.0);  // Month - 2014-10-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2855), 24.0, 0, 24.0, 24.0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2856), 25.7, 0, 25.7, 25.7, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2857), 22.4, 0, 22.4, 22.4, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2858), 17.2, 0, 17.2, 17.2, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2859), 18.2, 0, 18.2, 18.2, 4.5);  // Month - 2014-10-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2860), 16.9, 0, 16.9, 16.9, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2861), 15.5, 0, 15.5, 15.5, 3.3);  // Month - 2014-11-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2862), 14.6, 0, 14.6, 14.6, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2863), 16.1, 0, 16.1, 16.1, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2864), 15.3, 0, 15.3, 15.3, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2865), 16.5, 0, 16.5, 16.5, 4.9);  // Month - 2014-11-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2866), 17.7, 0, 17.7, 17.7, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2867), 20.6, 0, 20.6, 20.6, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2868), 19.0, 0, 19.0, 19.0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2869), 19.2, 0, 19.2, 19.2, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2870), 21.4, 0, 21.4, 21.4, 4.4);  // Month - 2014-11-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2871), 21.4, 0, 21.4, 21.4, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2872), 17.5, 0, 17.5, 17.5, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2873), 14.5, 0, 14.5, 14.5, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2874), 17.6, 0, 17.6, 17.6, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2875), 22.8, 0, 22.8, 22.8, 6.5);  // Month - 2014-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2876), 20.7, 0, 20.7, 20.7, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2877), 20.5, 0, 20.5, 20.5, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2878), 22.5, 0, 22.5, 22.5, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2879), 22.7, 0, 22.7, 22.7, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2880), 17.8, 0, 17.8, 17.8, 3.2);  // Month - 2014-11-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2881), 17.0, 0, 17.0, 17.0, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2882), 17.3, 0, 17.3, 17.3, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2883), 19.6, 0, 19.6, 19.6, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2884), 17.3, 0, 17.3, 17.3, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2885), 17.2, 0, 17.2, 17.2, 5.1);  // Month - 2014-11-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2886), 15.7, 0, 15.7, 15.7, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2887), 17.9, 0, 17.9, 17.9, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2888), 20.7, 0, 20.7, 20.7, 7.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2889), 24.0, 0, 24.0, 24.0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2890), 19.5, 0, 19.5, 19.5, 2.2);  // Month - 2014-11-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2891), 18.0, 0, 18.0, 18.0, 2.7);  // Month - 2014-12-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2892), 18.0, 0, 18.0, 18.0, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2893), 20.2, 0, 20.2, 20.2, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2894), 21.8, 0, 21.8, 21.8, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2895), 22.7, 0, 22.7, 22.7, 7.6);  // Month - 2014-12-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2896), 24.7, 0, 24.7, 24.7, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2897), 22.7, 0, 22.7, 22.7, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2898), 21.0, 0, 21.0, 21.0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2899), 24.3, 0, 24.3, 24.3, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2900), 18.9, 0, 18.9, 18.9, 4.9);  // Month - 2014-12-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2901), 17.6, 0, 17.6, 17.6, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2902), 20.2, 0, 20.2, 20.2, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2903), 21.0, 0, 21.0, 21.0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2904), 17.5, 0, 17.5, 17.5, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2905), 18.9, 0, 18.9, 18.9, 6.2);  // Month - 2014-12-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2906), 22.7, 0, 22.7, 22.7, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2907), 22.0, 0, 22.0, 22.0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2908), 23.2, 0, 23.2, 23.2, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2909), 26.3, 0, 26.3, 26.3, 8.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2910), 22.6, 0, 22.6, 22.6, 4.5);  // Month - 2014-12-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2911), 16.4, 0, 16.4, 16.4, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2912), 16.2, 0, 16.2, 16.2, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2913), 17.0, 0, 17.0, 17.0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2914), 19.4, 0, 19.4, 19.4, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2915), 24.3, 0, 24.3, 24.3, 6.9);  // Month - 2014-12-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2916), 25.1, 0, 25.1, 25.1, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2917), 23.3, 0, 23.3, 23.3, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2918), 24.5, 0, 24.5, 24.5, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2919), 25.5, 0, 25.5, 25.5, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2920), 26.7, 0, 26.7, 26.7, 7.2);  // Month - 2014-12-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2921), 24.6, 0, 24.6, 24.6, 4.5);  

            
        }

        public static void AddWeatherData_Pivot_01(IrrigationSystem pIrrigationSystem,
                                WeatherStation pWeatherStation)
        {
            WeatherStation lWeatherStation;
            DateTime lFirstDay = new DateTime(2007, 1, 1);


            lWeatherStation = pWeatherStation;

            // DATOS DEL TIEMPO

            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(000), 28.6, 0, 28.6, 28.6, 7.3);  // Month - 2007-1-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(001), 25.3, 0, 25.3, 25.3, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(002), 25.3, 0, 25.3, 25.3, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(003), 25.6, 0, 25.6, 25.6, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(004), 21.1, 0, 21.1, 21.1, 4.5);  // Month - 2007-1-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(005), 20.0, 0, 20.0, 20.0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(006), 20.7, 0, 20.7, 20.7, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(007), 22.0, 0, 22.0, 22.0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(008), 24.9, 0, 24.9, 24.9, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(009), 25.7, 0, 25.7, 25.7, 3.4);  // Month - 2007-1-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(010), 25.0, 0, 25.0, 25.0, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(011), 24.9, 0, 24.9, 24.9, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(012), 24.7, 0, 24.7, 24.7, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(013), 16.4, 0, 16.4, 16.4, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(014), 16.5, 0, 16.5, 16.5, 5.1);  // Month - 2007-1-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(015), 19.9, 0, 19.9, 19.9, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(016), 22.5, 0, 22.5, 22.5, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(017), 23.2, 0, 23.2, 23.2, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(018), 20.0, 0, 20.0, 20.0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(019), 21.5, 0, 21.5, 21.5, 5.2);  // Month - 2007-1-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(020), 20.7, 0, 20.7, 20.7, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(021), 22.0, 0, 22.0, 22.0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(022), 25.0, 0, 25.0, 25.0, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(023), 25.4, 0, 25.4, 25.4, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(024), 23.9, 0, 23.9, 23.9, 2.2);  // Month - 2007-1-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(025), 25.0, 0, 25.0, 25.0, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(026), 23.5, 0, 23.5, 23.5, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(027), 21.1, 0, 21.1, 21.1, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(028), 18.4, 0, 18.4, 18.4, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(029), 21.8, 0, 21.8, 21.8, 4.8);  // Month - 2007-1-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(030), 22.7, 0, 22.7, 22.7, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(031), 23.0, 0, 23.0, 23.0, 5.9);  // Month - 2007-2-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(032), 26.3, 0, 26.3, 26.3, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(033), 27.9, 0, 27.9, 27.9, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(034), 27.6, 0, 27.6, 27.6, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(035), 24.6, 0, 24.6, 24.6, 3.3);  // Month - 2007-2-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(036), 25.0, 0, 25.0, 25.0, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(037), 22.4, 0, 22.4, 22.4, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(038), 23.1, 0, 23.1, 23.1, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(039), 24.7, 0, 24.7, 24.7, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(040), 23.4, 0, 23.4, 23.4, 4.8);  // Month - 2007-2-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(041), 20.9, 0, 20.9, 20.9, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(042), 20.1, 0, 20.1, 20.1, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(043), 23.0, 0, 23.0, 23.0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(044), 25.5, 0, 25.5, 25.5, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(045), 26.7, 0, 26.7, 26.7, 3.6);  // Month - 2007-2-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(046), 25.0, 0, 25.0, 25.0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(047), 21.6, 0, 21.6, 21.6, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(048), 19.1, 0, 19.1, 19.1, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(049), 19.4, 0, 19.4, 19.4, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(050), 21.0, 0, 21.0, 21.0, 4.9);  // Month - 2007-2-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(051), 24.0, 0, 24.0, 24.0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(052), 24.4, 0, 24.4, 24.4, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(053), 24.1, 0, 24.1, 24.1, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(054), 23.3, 0, 23.3, 23.3, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(055), 26.9, 0, 26.9, 26.9, 5.1);  // Month - 2007-2-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(056), 26.1, 0, 26.1, 26.1, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(057), 21.5, 0, 21.5, 21.5, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(058), 22.3, 0, 22.3, 22.3, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(059), 23.0, 0, 23.0, 23.0, 1.7);  // Month - 2007-3-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(060), 18.8, 0, 18.8, 18.8, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(061), 16.1, 0, 16.1, 16.1, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(062), 17.6, 0, 17.6, 17.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(063), 21.9, 0, 21.9, 21.9, 2.9);  // Month - 2007-3-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(064), 23.4, 0, 23.4, 23.4, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(065), 23.4, 0, 23.4, 23.4, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(066), 20.8, 0, 20.8, 20.8, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(067), 20.6, 0, 20.6, 20.6, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(068), 18.3, 0, 18.3, 18.3, 2.6);  // Month - 2007-3-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(069), 20.1, 0, 20.1, 20.1, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(070), 23.2, 0, 23.2, 23.2, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(071), 22.9, 0, 22.9, 22.9, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(072), 22.0, 0, 22.0, 22.0, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(073), 22.3, 0, 22.3, 22.3, 3.2);  // Month - 2007-3-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(074), 20.3, 0, 20.3, 20.3, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(075), 19.7, 0, 19.7, 19.7, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(076), 20.0, 0, 20.0, 20.0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(077), 19.9, 0, 19.9, 19.9, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(078), 21.5, 0, 21.5, 21.5, 3.1);  // Month - 2007-3-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(079), 22.2, 0, 22.2, 22.2, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(080), 23.5, 0, 23.5, 23.5, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(081), 19.0, 0, 19.0, 19.0, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(082), 18.0, 0, 18.0, 18.0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(083), 20.5, 0, 20.5, 20.5, 2.9);  // Month - 2007-3-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(084), 22.9, 0, 22.9, 22.9, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(085), 19.8, 0, 19.8, 19.8, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(086), 20.8, 0, 20.8, 20.8, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(087), 22.2, 0, 22.2, 22.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(088), 20.7, 0, 20.7, 20.7, 1.1);  // Month - 2007-3-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(089), 20.0, 0, 20.0, 20.0, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(090), 22.5, 0, 22.5, 22.5, 2.3);  // Month - 2007-4-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(091), 22.5, 0, 22.5, 22.5, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(092), 20.4, 0, 20.4, 20.4, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(093), 18.7, 0, 18.7, 18.7, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(094), 18.0, 0, 18.0, 18.0, 2.4);  // Month - 2007-4-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(095), 19.6, 0, 19.6, 19.6, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(096), 20.7, 0, 20.7, 20.7, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(097), 17.3, 0, 17.3, 17.3, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(098), 17.2, 0, 17.2, 17.2, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(099), 17.9, 0, 17.9, 17.9, 1.4);  // Month - 2007-4-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(100), 19.3, 0, 19.3, 19.3, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(101), 15.6, 0, 15.6, 15.6, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(102), 15.4, 0, 15.4, 15.4, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(103), 17.8, 0, 17.8, 17.8, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(104), 19.8, 0, 19.8, 19.8, 1.0);  // Month - 2007-4-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(105), 20.6, 0, 20.6, 20.6, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(106), 22.7, 0, 22.7, 22.7, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(107), 25.4, 0, 25.4, 25.4, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(108), 25.6, 0, 25.6, 25.6, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(109), 19.1, 0, 19.1, 19.1, 1.0);  // Month - 2007-4-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(110), 15.4, 0, 15.4, 15.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(111), 18.3, 0, 18.3, 18.3, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(112), 16.7, 0, 16.7, 16.7, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(113), 16.8, 0, 16.8, 16.8, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(114), 14.6, 0, 14.6, 14.6, 1.1);  // Month - 2007-4-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(115), 14.5, 0, 14.5, 14.5, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(116), 12.6, 0, 12.6, 12.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(117), 14.1, 0, 14.1, 14.1, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(118), 14.1, 0, 14.1, 14.1, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(119), 16.0, 0, 16.0, 16.0, 1.3);  // Month - 2007-4-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(120), 18.2, 0, 18.2, 18.2, 0.8);  // Month - 2007-5-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(121), 17.9, 0, 17.9, 17.9, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(122), 17.5, 0, 17.5, 17.5, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(123), 17.9, 0, 17.9, 17.9, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(124), 17.8, 0, 17.8, 17.8, 0.8);  // Month - 2007-5-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(125), 14.4, 0, 14.4, 14.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(126), 11.5, 0, 11.5, 11.5, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(127), 11.3, 0, 11.3, 11.3, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(128), 10.4, 0, 10.4, 10.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(129), 09.7, 0, 09.7, 09.7, 0.7);  // Month - 2007-5-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(130), 12.8, 0, 12.8, 12.8, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(131), 11.0, 0, 11.0, 11.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(132), 10.4, 0, 10.4, 10.4, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(133), 11.1, 0, 11.1, 11.1, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(134), 13.0, 0, 13.0, 13.0, 0.6);  // Month - 2007-5-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(135), 11.9, 0, 11.9, 11.9, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(136), 09.0, 0, 09.0, 09.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(137), 10.8, 0, 10.8, 10.8, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(138), 12.6, 0, 12.6, 12.6, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(139), 12.3, 0, 12.3, 12.3, 0.7);  // Month - 2007-5-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(140), 13.3, 0, 13.3, 13.3, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(141), 11.0, 0, 11.0, 11.0, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(142), 10.7, 0, 10.7, 10.7, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(143), 09.1, 0, 09.1, 09.1, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(144), 09.2, 0, 09.2, 09.2, 0.5);  // Month - 2007-5-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(145), 09.6, 0, 09.6, 09.6, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(146), 08.0, 0, 08.0, 08.0, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(147), 06.2, 0, 06.2, 06.2, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(148), 08.0, 0, 08.0, 08.0, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(149), 08.0, 0, 08.0, 08.0, 0.4);  // Month - 2007-5-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(150), 06.8, 0, 06.8, 06.8, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(151), 09.8, 0, 09.8, 09.8, 0.4);  // Month - 2007-6-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(152), 10.3, 0, 10.3, 10.3, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(153), 13.3, 0, 13.3, 13.3, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(154), 12.5, 0, 12.5, 12.5, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(155), 13.1, 0, 13.1, 13.1, 0.7);  // Month - 2007-6-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(156), 11.0, 0, 11.0, 11.0, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(157), 06.5, 0, 06.5, 06.5, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(158), 08.0, 0, 08.0, 08.0, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(159), 12.8, 0, 12.8, 12.8, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(160), 10.1, 0, 10.1, 10.1, 0.3);  // Month - 2007-6-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(161), 09.7, 0, 09.7, 09.7, 0.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(162), 10.9, 0, 10.9, 10.9, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(163), 13.2, 0, 13.2, 13.2, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(164), 10.8, 0, 10.8, 10.8, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(165), 08.2, 0, 08.2, 08.2, 0.4);  // Month - 2007-6-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(166), 07.2, 0, 07.2, 07.2, 0.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(167), 07.4, 0, 07.4, 07.4, 0.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(168), 06.0, 0, 06.0, 06.0, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(169), 08.5, 0, 08.5, 08.5, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(170), 12.9, 0, 12.9, 12.9, 0.4);  // Month - 2007-6-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(171), 11.8, 0, 11.8, 11.8, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(172), 13.9, 0, 13.9, 13.9, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(173), 09.4, 0, 09.4, 09.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(174), 06.1, 0, 06.1, 06.1, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(175), 07.4, 0, 07.4, 07.4, 0.3);  // Month - 2007-6-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(176), 08.7, 0, 08.7, 08.7, 0.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(177), 07.7, 0, 07.7, 07.7, 0.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(178), 09.0, 0, 09.0, 09.0, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(179), 09.9, 0, 09.9, 09.9, 0.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(180), 06.7, 0, 06.7, 06.7, 0.1);  // Month - 2007-6-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(181), 06.5, 0, 06.5, 06.5, 0.1);  // Month - 2007-7-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(182), 06.1, 0, 06.1, 06.1, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(183), 06.7, 0, 06.7, 06.7, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(184), 12.2, 0, 12.2, 12.2, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(185), 17.4, 0, 17.4, 17.4, 0.6);  // Month - 2007-7-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(186), 09.1, 0, 09.1, 09.1, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(187), 07.2, 0, 07.2, 07.2, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(188), 05.7, 0, 05.7, 05.7, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(189), 05.3, 0, 05.3, 05.3, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(190), 02.9, 0, 02.9, 02.9, 0.5);  // Month - 2007-7-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(191), 04.5, 0, 04.5, 04.5, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(192), 04.6, 0, 04.6, 04.6, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(193), 06.6, 0, 06.6, 06.6, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(194), 08.1, 0, 08.1, 08.1, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(195), 07.0, 0, 07.0, 07.0, 0.3);  // Month - 2007-7-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(196), 09.5, 0, 09.5, 09.5, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(197), 11.1, 0, 11.1, 11.1, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(198), 09.5, 0, 09.5, 09.5, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(199), 13.6, 0, 13.6, 13.6, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(200), 11.4, 0, 11.4, 11.4, 1.3);  // Month - 2007-7-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(201), 09.1, 0, 09.1, 09.1, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(202), 07.9, 0, 07.9, 07.9, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(203), 06.3, 0, 06.3, 06.3, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(204), 04.5, 0, 04.5, 04.5, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(205), 03.6, 0, 03.6, 03.6, 0.4);  // Month - 2007-7-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(206), 09.6, 0, 09.6, 09.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(207), 05.0, 0, 05.0, 05.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(208), 04.3, 0, 04.3, 04.3, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(209), 04.9, 0, 04.9, 04.9, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(210), 06.9, 0, 06.9, 06.9, 0.5);  // Month - 2007-7-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(211), 08.9, 0, 08.9, 08.9, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(212), 07.2, 0, 07.2, 07.2, 0.5);  // Month - 2007-8-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(213), 07.2, 0, 07.2, 07.2, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(214), 08.2, 0, 08.2, 08.2, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(215), 06.5, 0, 06.5, 06.5, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(216), 06.9, 0, 06.9, 06.9, 0.5);  // Month - 2007-8-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(217), 07.9, 0, 07.9, 07.9, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(218), 09.8, 0, 09.8, 09.8, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(219), 11.5, 0, 11.5, 11.5, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(220), 11.3, 0, 11.3, 11.3, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(221), 06.6, 0, 06.6, 06.6, 0.6);  // Month - 2007-8-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(222), 07.4, 0, 07.4, 07.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(223), 06.6, 0, 06.6, 06.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(224), 14.9, 0, 14.9, 14.9, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(225), 19.1, 0, 19.1, 19.1, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(226), 11.0, 0, 11.0, 11.0, 0.7);  // Month - 2007-8-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(227), 08.3, 0, 08.3, 08.3, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(228), 05.5, 0, 05.5, 05.5, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(229), 08.9, 0, 08.9, 08.9, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(230), 08.5, 0, 08.5, 08.5, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(231), 05.7, 0, 05.7, 05.7, 0.7);  // Month - 2007-8-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(232), 07.4, 0, 07.4, 07.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(233), 08.0, 0, 08.0, 08.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(234), 09.7, 0, 09.7, 09.7, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(235), 10.2, 0, 10.2, 10.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(236), 12.0, 0, 12.0, 12.0, 1.2);  // Month - 2007-8-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(237), 10.4, 0, 10.4, 10.4, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(238), 10.0, 0, 10.0, 10.0, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(239), 11.4, 0, 11.4, 11.4, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(240), 07.0, 0, 07.0, 07.0, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(241), 10.3, 0, 10.3, 10.3, 1.4);  // Month - 2007-8-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(242), 12.6, 0, 12.6, 12.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(243), 14.4, 0, 14.4, 14.4, 1.0);  // Month - 2007-9-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(244), 15.0, 0, 15.0, 15.0, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(245), 18.5, 0, 18.5, 18.5, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(246), 21.2, 0, 21.2, 21.2, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(247), 12.2, 0, 12.2, 12.2, 1.0);  // Month - 2007-9-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(248), 18.7, 0, 18.7, 18.7, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(249), 22.2, 0, 22.2, 22.2, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(250), 24.0, 0, 24.0, 24.0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(251), 24.6, 0, 24.6, 24.6, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(252), 24.8, 0, 24.8, 24.8, 2.6);  // Month - 2007-9-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(253), 17.4, 0, 17.4, 17.4, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(254), 14.5, 0, 14.5, 14.5, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(255), 17.3, 0, 17.3, 17.3, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(256), 19.0, 0, 19.0, 19.0, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(257), 14.6, 0, 14.6, 14.6, 0.9);  // Month - 2007-9-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(258), 12.9, 0, 12.9, 12.9, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(259), 13.6, 0, 13.6, 13.6, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(260), 13.8, 0, 13.8, 13.8, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(261), 13.1, 0, 13.1, 13.1, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(262), 11.1, 0, 11.1, 11.1, 1.6);  // Month - 2007-9-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(263), 11.7, 0, 11.7, 11.7, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(264), 11.3, 0, 11.3, 11.3, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(265), 11.8, 0, 11.8, 11.8, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(266), 08.4, 0, 08.4, 08.4, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(267), 09.2, 0, 09.2, 09.2, 1.9);  // Month - 2007-9-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(268), 11.2, 0, 11.2, 11.2, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(269), 15.8, 0, 15.8, 15.8, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(270), 16.0, 0, 16.0, 16.0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(271), 17.6, 0, 17.6, 17.6, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(272), 17.9, 0, 17.9, 17.9, 4.3);  // Month - 2007-9-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(273), 15.5, 0, 15.5, 15.5, 1.1);  // Month - 2007-10-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(274), 19.0, 0, 19.0, 19.0, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(275), 20.3, 0, 20.3, 20.3, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(276), 21.6, 0, 21.6, 21.6, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(277), 20.2, 0, 20.2, 20.2, 1.2);  // Month - 2007-10-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(278), 15.7, 0, 15.7, 15.7, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(279), 12.9, 0, 12.9, 12.9, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(280), 13.9, 0, 13.9, 13.9, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(281), 15.1, 0, 15.1, 15.1, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(282), 14.6, 0, 14.6, 14.6, 1.3);  // Month - 2007-10-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(283), 12.6, 0, 12.6, 12.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(284), 13.2, 0, 13.2, 13.2, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(285), 13.3, 0, 13.3, 13.3, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(286), 13.4, 0, 13.4, 13.4, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(287), 15.2, 0, 15.2, 15.2, 2.6);  // Month - 2007-10-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(288), 16.0, 0, 16.0, 16.0, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(289), 19.0, 0, 19.0, 19.0, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(290), 18.5, 0, 18.5, 18.5, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(291), 19.5, 0, 19.5, 19.5, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(292), 20.0, 0, 20.0, 20.0, 3.4);  // Month - 2007-10-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(293), 17.0, 0, 17.0, 17.0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(294), 18.4, 0, 18.4, 18.4, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(295), 20.6, 0, 20.6, 20.6, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(296), 19.5, 0, 19.5, 19.5, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(297), 21.9, 0, 21.9, 21.9, 3.3);  // Month - 2007-10-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(298), 19.4, 0, 19.4, 19.4, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(299), 16.6, 0, 16.6, 16.6, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(300), 17.1, 0, 17.1, 17.1, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(301), 19.0, 0, 19.0, 19.0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(302), 20.1, 0, 20.1, 20.1, 3.9);  // Month - 2007-10-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(303), 20.2, 0, 20.2, 20.2, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(304), 15.9, 0, 15.9, 15.9, 4.6);  // Month - 2007-11-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(305), 16.6, 0, 16.6, 16.6, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(306), 19.7, 0, 19.7, 19.7, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(307), 11.5, 0, 11.5, 11.5, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(308), 15.0, 0, 15.0, 15.0, 4.6);  // Month - 2007-11-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(309), 19.2, 0, 19.2, 19.2, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(310), 21.2, 0, 21.2, 21.2, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(311), 18.7, 0, 18.7, 18.7, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(312), 17.9, 0, 17.9, 17.9, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(313), 13.2, 0, 13.2, 13.2, 2.9);  // Month - 2007-11-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(314), 11.0, 0, 11.0, 11.0, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(315), 14.5, 0, 14.5, 14.5, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(316), 13.6, 0, 13.6, 13.6, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(317), 11.7, 0, 11.7, 11.7, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(318), 12.1, 0, 12.1, 12.1, 3.9);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(319), 16.2, 0, 16.2, 16.2, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(320), 21.4, 0, 21.4, 21.4, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(321), 17.8, 0, 17.8, 17.8, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(322), 19.9, 0, 19.9, 19.9, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(323), 17.8, 0, 17.8, 17.8, 4.6);  // Month - 2007-11-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(324), 17.8, 0, 17.8, 17.8, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(325), 20.5, 0, 20.5, 20.5, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(326), 17.5, 0, 17.5, 17.5, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(327), 10.6, 0, 10.6, 10.6, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(328), 13.6, 0, 13.6, 13.6, 4.5);  // Month - 2007-11-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(329), 16.5, 0, 16.5, 16.5, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(330), 16.3, 0, 16.3, 16.3, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(331), 19.5, 0, 19.5, 19.5, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(332), 22.2, 0, 22.2, 22.2, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(333), 22.5, 0, 22.5, 22.5, 5.5);  // Month - 2007-11-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(334), 21.6, 0, 21.6, 21.6, 5.8);  // Month - 2007-12-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(335), 22.3, 0, 22.3, 22.3, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(336), 24.9, 0, 24.9, 24.9, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(337), 23.4, 0, 23.4, 23.4, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(338), 15.4, 0, 15.4, 15.4, 5.5);  // Month - 2007-12-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(339), 17.2, 0, 17.2, 17.2, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(340), 21.5, 0, 21.5, 21.5, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(341), 22.4, 0, 22.4, 22.4, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(342), 19.6, 0, 19.6, 19.6, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(343), 20.5, 0, 20.5, 20.5, 4.0);  // Month - 2007-12-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(344), 15.8, 0, 15.8, 15.8, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(345), 19.3, 0, 19.3, 19.3, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(346), 23.0, 0, 23.0, 23.0, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(347), 24.4, 0, 24.4, 24.4, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(348), 16.7, 0, 16.7, 16.7, 5.3);  // Month - 2007-12-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(349), 14.4, 0, 14.4, 14.4, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(350), 18.2, 0, 18.2, 18.2, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(351), 21.8, 0, 21.8, 21.8, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(352), 17.6, 0, 17.6, 17.6, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(353), 22.5, 0, 22.5, 22.5, 6.1);  // Month - 2007-12-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(354), 24.7, 0, 24.7, 24.7, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(355), 17.8, 0, 17.8, 17.8, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(356), 19.4, 0, 19.4, 19.4, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(357), 22.2, 0, 22.2, 22.2, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(358), 21.2, 0, 21.2, 21.2, 2.4);  // Month - 2007-12-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(359), 20.8, 0, 20.8, 20.8, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(360), 21.4, 0, 21.4, 21.4, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(361), 23.7, 0, 23.7, 23.7, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(362), 24.2, 0, 24.2, 24.2, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(363), 25.3, 0, 25.3, 25.3, 6.4);  // Month - 2007-12-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(364), 27.4, 0, 27.4, 27.4, 7.5);


            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(365), 24.3, 0, 24.3, 24.3, 4.2);  // Month - 2008-1-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(366), 27.2, 0, 27.2, 27.2, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(367), 25.7, 0, 25.7, 25.7, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(368), 19.3, 0, 19.3, 19.3, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(369), 20.4, 0, 20.4, 20.4, 5.4);  // Month - 2008-1-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(370), 22.8, 0, 22.8, 22.8, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(371), 26.9, 0, 26.9, 26.9, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(372), 28.5, 0, 28.5, 28.5, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(373), 26.0, 0, 26.0, 26.0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(374), 22.9, 0, 22.9, 22.9, 2.5);  // Month - 2008-1-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(375), 19.6, 0, 19.6, 19.6, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(376), 19.4, 0, 19.4, 19.4, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(377), 22.0, 0, 22.0, 22.0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(378), 24.8, 0, 24.8, 24.8, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(379), 27.8, 0, 27.8, 27.8, 6.6);  // Month - 2008-1-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(380), 20.2, 0, 20.2, 20.2, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(381), 18.7, 0, 18.7, 18.7, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(382), 20.5, 0, 20.5, 20.5, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(383), 17.4, 0, 17.4, 17.4, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(384), 18.9, 0, 18.9, 18.9, 4.1);  // Month - 2008-1-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(385), 22.1, 0, 22.1, 22.1, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(386), 21.0, 0, 21.0, 21.0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(387), 23.1, 0, 23.1, 23.1, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(388), 24.3, 0, 24.3, 24.3, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(389), 24.8, 0, 24.8, 24.8, 5.7);  // Month - 2008-1-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(390), 23.8, 0, 23.8, 23.8, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(391), 24.1, 0, 24.1, 24.1, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(392), 25.9, 0, 25.9, 25.9, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(393), 24.9, 0, 24.9, 24.9, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(394), 23.8, 0, 23.8, 23.8, 4.1);  // Month - 2008-1-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(395), 23.7, 0, 23.7, 23.7, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(396), 23.2, 0, 23.2, 23.2, 5.0);  // Month - 2008-2-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(397), 23.0, 0, 23.0, 23.0, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(398), 18.6, 0, 18.6, 18.6, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(399), 22.4, 0, 22.4, 22.4, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(400), 24.2, 0, 24.2, 24.2, 5.3);  // Month - 2008-2-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(401), 26.4, 0, 26.4, 26.4, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(402), 26.2, 0, 26.2, 26.2, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(403), 22.7, 0, 22.7, 22.7, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(404), 22.4, 0, 22.4, 22.4, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(405), 19.3, 0, 19.3, 19.3, 2.4);  // Month - 2008-2-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(406), 19.0, 0, 19.0, 19.0, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(407), 22.0, 0, 22.0, 22.0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(408), 22.4, 0, 22.4, 22.4, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(409), 23.7, 0, 23.7, 23.7, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(410), 25.5, 0, 25.5, 25.5, 5.1);  // Month - 2008-2-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(411), 24.4, 0, 24.4, 24.4, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(412), 24.8, 0, 24.8, 24.8, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(413), 23.5, 0, 23.5, 23.5, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(414), 24.1, 0, 24.1, 24.1, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(415), 24.3, 0, 24.3, 24.3, 4.7);  // Month - 2008-2-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(416), 25.0, 0, 25.0, 25.0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(417), 23.4, 0, 23.4, 23.4, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(418), 22.9, 0, 22.9, 22.9, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(419), 23.2, 0, 23.2, 23.2, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(420), 23.0, 0, 23.0, 23.0, 3.7);  // Month - 2008-2-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(421), 24.9, 0, 24.9, 24.9, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(422), 24.9, 0, 24.9, 24.9, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(423), 21.8, 0, 21.8, 21.8, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(424), 21.3, 0, 21.3, 21.3, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(425), 23.5, 0, 23.5, 23.5, 2.9);  // Month - 2008-3-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(426), 22.7, 0, 22.7, 22.7, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(427), 22.5, 0, 22.5, 22.5, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(428), 22.4, 0, 22.4, 22.4, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(429), 20.1, 0, 20.1, 20.1, 2.2);  // Month - 2008-3-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(430), 20.9, 0, 20.9, 20.9, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(431), 20.8, 0, 20.8, 20.8, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(432), 23.2, 0, 23.2, 23.2, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(433), 23.1, 0, 23.1, 23.1, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(434), 18.3, 0, 18.3, 18.3, 3.1);  // Month - 2008-3-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(435), 17.2, 0, 17.2, 17.2, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(436), 17.0, 0, 17.0, 17.0, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(437), 17.7, 0, 17.7, 17.7, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(438), 19.9, 0, 19.9, 19.9, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(439), 18.9, 0, 18.9, 18.9, 3.4);  // Month - 2008-3-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(440), 21.8, 0, 21.8, 21.8, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(441), 24.6, 0, 24.6, 24.6, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(442), 22.4, 0, 22.4, 22.4, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(443), 24.3, 0, 24.3, 24.3, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(444), 21.8, 0, 21.8, 21.8, 3.0);  // Month - 2008-3-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(445), 22.5, 0, 22.5, 22.5, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(446), 16.9, 0, 16.9, 16.9, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(447), 17.8, 0, 17.8, 17.8, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(448), 19.2, 0, 19.2, 19.2, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(449), 20.3, 0, 20.3, 20.3, 3.1);  // Month - 2008-3-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(450), 22.2, 0, 22.2, 22.2, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(451), 20.3, 0, 20.3, 20.3, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(452), 19.6, 0, 19.6, 19.6, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(453), 19.7, 0, 19.7, 19.7, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(454), 17.9, 0, 17.9, 17.9, 2.7);  // Month - 2008-3-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(455), 19.7, 0, 19.7, 19.7, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(456), 19.5, 0, 19.5, 19.5, 1.6);  // Month - 2008-4-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(457), 16.6, 0, 16.6, 16.6, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(458), 15.0, 0, 15.0, 15.0, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(459), 18.5, 0, 18.5, 18.5, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(460), 21.0, 0, 21.0, 21.0, 2.7);  // Month - 2008-4-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(461), 21.7, 0, 21.7, 21.7, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(462), 21.3, 0, 21.3, 21.3, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(463), 19.3, 0, 19.3, 19.3, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(464), 19.2, 0, 19.2, 19.2, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(465), 21.6, 0, 21.6, 21.6, 2.3);  // Month - 2008-4-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(466), 20.3, 0, 20.3, 20.3, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(467), 12.5, 0, 12.5, 12.5, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(468), 11.6, 0, 11.6, 11.6, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(469), 10.5, 0, 10.5, 10.5, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(470), 10.7, 0, 10.7, 10.7, 1.6);  // Month - 2008-4-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(471), 13.3, 0, 13.3, 13.3, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(472), 16.8, 0, 16.8, 16.8, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(473), 18.9, 0, 18.9, 18.9, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(474), 19.0, 0, 19.0, 19.0, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(475), 20.4, 0, 20.4, 20.4, 2.7);  // Month - 2008-4-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(476), 20.3, 0, 20.3, 20.3, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(477), 20.4, 0, 20.4, 20.4, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(478), 19.2, 0, 19.2, 19.2, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(479), 18.9, 0, 18.9, 18.9, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(480), 15.7, 0, 15.7, 15.7, 1.6);  // Month - 2008-4-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(481), 14.4, 0, 14.4, 14.4, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(482), 16.0, 0, 16.0, 16.0, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(483), 16.4, 0, 16.4, 16.4, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(484), 11.6, 0, 11.6, 11.6, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(485), 10.5, 0, 10.5, 10.5, 1.0);  // Month - 2008-4-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(486), 10.4, 0, 10.4, 10.4, 0.8);  // Month - 2008-5-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(487), 11.5, 0, 11.5, 11.5, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(488), 14.4, 0, 14.4, 14.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(489), 12.7, 0, 12.7, 12.7, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(490), 11.0, 0, 11.0, 11.0, 0.7);  // Month - 2008-5-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(491), 14.0, 0, 14.0, 14.0, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(492), 13.4, 0, 13.4, 13.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(493), 10.6, 0, 10.6, 10.6, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(494), 11.0, 0, 11.0, 11.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(495), 10.9, 0, 10.9, 10.9, 0.8);  // Month - 2008-5-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(496), 12.2, 0, 12.2, 12.2, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(497), 13.9, 0, 13.9, 13.9, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(498), 14.4, 0, 14.4, 14.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(499), 15.4, 0, 15.4, 15.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(500), 18.0, 0, 18.0, 18.0, 1.4);  // Month - 2008-5-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(501), 14.6, 0, 14.6, 14.6, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(502), 19.5, 0, 19.5, 19.5, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(503), 20.9, 0, 20.9, 20.9, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(504), 22.7, 0, 22.7, 22.7, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(505), 19.5, 0, 19.5, 19.5, 0.6);  // Month - 2008-5-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(506), 18.7, 0, 18.7, 18.7, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(507), 17.2, 0, 17.2, 17.2, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(508), 18.2, 0, 18.2, 18.2, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(509), 14.3, 0, 14.3, 14.3, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(510), 16.0, 0, 16.0, 16.0, 0.5);  // Month - 2008-5-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(511), 13.8, 0, 13.8, 13.8, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(512), 13.8, 0, 13.8, 13.8, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(513), 11.0, 0, 11.0, 11.0, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(514), 08.0, 0, 08.0, 08.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(515), 07.3, 0, 07.3, 07.3, 0.3);  // Month - 2008-5-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(516), 07.1, 0, 07.1, 07.1, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(517), 07.0, 0, 07.0, 07.0, 0.2);  // Month - 2008-6-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(518), 08.4, 0, 08.4, 08.4, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(519), 09.1, 0, 09.1, 09.1, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(520), 11.5, 0, 11.5, 11.5, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(521), 14.4, 0, 14.4, 14.4, 0.4);  // Month - 2008-6-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(522), 10.6, 0, 10.6, 10.6, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(523), 10.5, 0, 10.5, 10.5, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(524), 11.0, 0, 11.0, 11.0, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(525), 09.9, 0, 09.9, 09.9, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(526), 09.4, 0, 09.4, 09.4, 0.4);  // Month - 2008-6-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(527), 11.6, 0, 11.6, 11.6, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(528), 09.1, 0, 09.1, 09.1, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(529), 11.2, 0, 11.2, 11.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(530), 10.5, 0, 10.5, 10.5, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(531), 08.2, 0, 08.2, 08.2, 0.7);  // Month - 2008-6-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(532), 08.0, 0, 08.0, 08.0, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(533), 10.0, 0, 10.0, 10.0, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(534), 07.4, 0, 07.4, 07.4, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(535), 11.0, 0, 11.0, 11.0, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(536), 11.1, 0, 11.1, 11.1, 0.3);  // Month - 2008-6-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(537), 10.8, 0, 10.8, 10.8, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(538), 08.9, 0, 08.9, 08.9, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(539), 09.1, 0, 09.1, 09.1, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(540), 08.4, 0, 08.4, 08.4, 0.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(541), 10.8, 0, 10.8, 10.8, 0.3);  // Month - 2008-6-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(542), 12.6, 0, 12.6, 12.6, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(543), 11.7, 0, 11.7, 11.7, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(544), 10.3, 0, 10.3, 10.3, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(545), 11.4, 0, 11.4, 11.4, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(546), 14.1, 0, 14.1, 14.1, 0.4);  // Month - 2008-6-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(547), 10.6, 0, 10.6, 10.6, 0.4);  // Month - 2008-7-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(548), 09.7, 0, 09.7, 09.7, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(549), 10.2, 0, 10.2, 10.2, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(550), 09.4, 0, 09.4, 09.4, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(551), 20.3, 0, 20.3, 20.3, 1.1);  // Month - 2008-7-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(552), 16.8, 0, 16.8, 16.8, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(553), 16.0, 0, 16.0, 16.0, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(554), 13.1, 0, 13.1, 13.1, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(555), 13.2, 0, 13.2, 13.2, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(556), 13.9, 0, 13.9, 13.9, 0.4);  // Month - 2008-7-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(557), 17.2, 0, 17.2, 17.2, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(558), 18.9, 0, 18.9, 18.9, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(559), 14.8, 0, 14.8, 14.8, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(560), 14.0, 0, 14.0, 14.0, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(561), 22.5, 0, 22.5, 22.5, 1.4);  // Month - 2008-7-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(562), 19.2, 0, 19.2, 19.2, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(563), 19.2, 0, 19.2, 19.2, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(564), 10.5, 0, 10.5, 10.5, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(565), 09.1, 0, 09.1, 09.1, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(566), 08.0, 0, 08.0, 08.0, 0.8);  // Month - 2008-7-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(567), 10.2, 0, 10.2, 10.2, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(568), 10.5, 0, 10.5, 10.5, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(569), 10.6, 0, 10.6, 10.6, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(570), 10.2, 0, 10.2, 10.2, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(571), 09.2, 0, 09.2, 09.2, 0.4);  // Month - 2008-7-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(572), 09.3, 0, 09.3, 09.3, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(573), 12.0, 0, 12.0, 12.0, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(574), 14.5, 0, 14.5, 14.5, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(575), 14.8, 0, 14.8, 14.8, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(576), 13.6, 0, 13.6, 13.6, 0.5);  // Month - 2008-7-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(577), 10.5, 0, 10.5, 10.5, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(578), 10.5, 0, 10.5, 10.5, 0.4);  // Month - 2008-8-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(579), 10.9, 0, 10.9, 10.9, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(580), 07.3, 0, 07.3, 07.3, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(581), 09.8, 0, 09.8, 09.8, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(582), 08.8, 0, 08.8, 08.8, 0.8);  // Month - 2008-8-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(583), 09.3, 0, 09.3, 09.3, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(584), 08.5, 0, 08.5, 08.5, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(585), 06.9, 0, 06.9, 06.9, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(586), 08.1, 0, 08.1, 08.1, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(587), 13.9, 0, 13.9, 13.9, 1.5);  // Month - 2008-8-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(588), 16.4, 0, 16.4, 16.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(589), 07.6, 0, 07.6, 07.6, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(590), 08.2, 0, 08.2, 08.2, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(591), 11.1, 0, 11.1, 11.1, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(592), 15.4, 0, 15.4, 15.4, 0.8);  // Month - 2008-8-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(593), 17.7, 0, 17.7, 17.7, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(594), 09.1, 0, 09.1, 09.1, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(595), 07.9, 0, 07.9, 07.9, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(596), 11.6, 0, 11.6, 11.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(597), 14.3, 0, 14.3, 14.3, 0.6);  // Month - 2008-8-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(598), 09.6, 0, 09.6, 09.6, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(599), 09.5, 0, 09.5, 09.5, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(600), 10.2, 0, 10.2, 10.2, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(601), 11.6, 0, 11.6, 11.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(602), 13.2, 0, 13.2, 13.2, 1.2);  // Month - 2008-8-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(603), 13.3, 0, 13.3, 13.3, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(604), 16.9, 0, 16.9, 16.9, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(605), 11.3, 0, 11.3, 11.3, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(606), 10.5, 0, 10.5, 10.5, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(607), 12.4, 0, 12.4, 12.4, 2.0);  // Month - 2008-8-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(608), 14.9, 0, 14.9, 14.9, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(609), 16.0, 0, 16.0, 16.0, 1.6);  // Month - 2008-9-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(610), 17.6, 0, 17.6, 17.6, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(611), 10.3, 0, 10.3, 10.3, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(612), 08.5, 0, 08.5, 08.5, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(613), 06.6, 0, 06.6, 06.6, 1.0);  // Month - 2008-9-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(614), 08.0, 0, 08.0, 08.0, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(615), 11.4, 0, 11.4, 11.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(616), 10.6, 0, 10.6, 10.6, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(617), 12.3, 0, 12.3, 12.3, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(618), 13.1, 0, 13.1, 13.1, 1.3);  // Month - 2008-9-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(619), 13.5, 0, 13.5, 13.5, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(620), 09.3, 0, 09.3, 09.3, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(621), 08.3, 0, 08.3, 08.3, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(622), 10.5, 0, 10.5, 10.5, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(623), 10.0, 0, 10.0, 10.0, 1.3);  // Month - 2008-9-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(624), 11.7, 0, 11.7, 11.7, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(625), 11.7, 0, 11.7, 11.7, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(626), 13.6, 0, 13.6, 13.6, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(627), 14.3, 0, 14.3, 14.3, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(628), 12.1, 0, 12.1, 12.1, 1.1);  // Month - 2008-9-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(629), 13.2, 0, 13.2, 13.2, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(630), 15.5, 0, 15.5, 15.5, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(631), 13.2, 0, 13.2, 13.2, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(632), 14.4, 0, 14.4, 14.4, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(633), 16.0, 0, 16.0, 16.0, 2.5);  // Month - 2008-9-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(634), 17.9, 0, 17.9, 17.9, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(635), 18.3, 0, 18.3, 18.3, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(636), 18.3, 0, 18.3, 18.3, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(637), 17.2, 0, 17.2, 17.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(638), 13.6, 0, 13.6, 13.6, 1.0);  // Month - 2008-9-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(639), 16.5, 0, 16.5, 16.5, 1.5);  // Month - 2008-10-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(640), 16.6, 0, 16.6, 16.6, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(641), 15.9, 0, 15.9, 15.9, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(642), 12.1, 0, 12.1, 12.1, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(643), 11.5, 0, 11.5, 11.5, 3.0);  // Month - 2008-10-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(644), 16.3, 0, 16.3, 16.3, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(645), 09.5, 0, 09.5, 09.5, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(646), 09.4, 0, 09.4, 09.4, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(647), 14.1, 0, 14.1, 14.1, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(648), 18.0, 0, 18.0, 18.0, 3.3);  // Month - 2008-10-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(649), 21.3, 0, 21.3, 21.3, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(650), 18.2, 0, 18.2, 18.2, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(651), 17.6, 0, 17.6, 17.6, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(652), 15.9, 0, 15.9, 15.9, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(653), 14.0, 0, 14.0, 14.0, 1.3);  // Month - 2008-10-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(654), 13.2, 0, 13.2, 13.2, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(655), 12.5, 0, 12.5, 12.5, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(656), 15.4, 0, 15.4, 15.4, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(657), 17.1, 0, 17.1, 17.1, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(658), 21.6, 0, 21.6, 21.6, 4.6);  // Month - 2008-10-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(659), 19.7, 0, 19.7, 19.7, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(660), 15.5, 0, 15.5, 15.5, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(661), 16.4, 0, 16.4, 16.4, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(662), 20.1, 0, 20.1, 20.1, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(663), 19.0, 0, 19.0, 19.0, 3.0);  // Month - 2008-10-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(664), 18.4, 0, 18.4, 18.4, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(665), 14.9, 0, 14.9, 14.9, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(666), 17.0, 0, 17.0, 17.0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(667), 17.4, 0, 17.4, 17.4, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(668), 14.5, 0, 14.5, 14.5, 3.6);  // Month - 2008-10-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(669), 17.5, 0, 17.5, 17.5, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(670), 19.9, 0, 19.9, 19.9, 4.6);  // Month - 2008-11-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(671), 18.3, 0, 18.3, 18.3, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(672), 20.6, 0, 20.6, 20.6, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(673), 23.4, 0, 23.4, 23.4, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(674), 26.7, 0, 26.7, 26.7, 5.4);  // Month - 2008-11-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(675), 21.7, 0, 21.7, 21.7, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(676), 21.6, 0, 21.6, 21.6, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(677), 23.5, 0, 23.5, 23.5, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(678), 22.7, 0, 22.7, 22.7, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(679), 20.7, 0, 20.7, 20.7, 4.8);  // Month - 2008-11-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(680), 23.0, 0, 23.0, 23.0, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(681), 22.1, 0, 22.1, 22.1, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(682), 21.7, 0, 21.7, 21.7, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(683), 22.4, 0, 22.4, 22.4, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(684), 16.3, 0, 16.3, 16.3, 3.8);  // Month - 2008-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(685), 15.3, 0, 15.3, 15.3, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(686), 16.9, 0, 16.9, 16.9, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(687), 17.9, 0, 17.9, 17.9, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(688), 17.1, 0, 17.1, 17.1, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(689), 19.3, 0, 19.3, 19.3, 5.6);  // Month - 2008-11-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(690), 20.6, 0, 20.6, 20.6, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(691), 23.7, 0, 23.7, 23.7, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(692), 25.3, 0, 25.3, 25.3, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(693), 26.3, 0, 26.3, 26.3, 7.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(694), 28.1, 0, 28.1, 28.1, 6.4);  // Month - 2008-11-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(695), 26.3, 0, 26.3, 26.3, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(696), 28.4, 0, 28.4, 28.4, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(697), 27.1, 0, 27.1, 27.1, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(698), 28.4, 0, 28.4, 28.4, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(699), 27.1, 0, 27.1, 27.1, 3.1);  // Month - 2008-11-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(700), 23.1, 0, 23.1, 23.1, 2.0);  // Month - 2008-12-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(701), 22.0, 0, 22.0, 22.0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(702), 18.3, 0, 18.3, 18.3, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(703), 16.4, 0, 16.4, 16.4, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(704), 18.1, 0, 18.1, 18.1, 4.8);  // Month - 2008-12-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(705), 21.8, 0, 21.8, 21.8, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(706), 25.3, 0, 25.3, 25.3, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(707), 27.3, 0, 27.3, 27.3, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(708), 26.4, 0, 26.4, 26.4, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(709), 22.5, 0, 22.5, 22.5, 4.1);  // Month - 2008-12-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(710), 20.2, 0, 20.2, 20.2, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(711), 20.8, 0, 20.8, 20.8, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(712), 21.7, 0, 21.7, 21.7, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(713), 22.1, 0, 22.1, 22.1, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(714), 22.2, 0, 22.2, 22.2, 6.0);  // Month - 2008-12-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(715), 24.8, 0, 24.8, 24.8, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(716), 24.1, 0, 24.1, 24.1, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(717), 23.8, 0, 23.8, 23.8, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(718), 24.0, 0, 24.0, 24.0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(719), 26.8, 0, 26.8, 26.8, 7.6);  // Month - 2008-12-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(720), 24.3, 0, 24.3, 24.3, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(721), 21.1, 0, 21.1, 21.1, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(722), 22.5, 0, 22.5, 22.5, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(723), 23.5, 0, 23.5, 23.5, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(724), 22.4, 0, 22.4, 22.4, 4.3);  // Month - 2008-12-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(725), 20.8, 0, 20.8, 20.8, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(726), 26.0, 0, 26.0, 26.0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(727), 25.8, 0, 25.8, 25.8, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(728), 16.6, 0, 16.6, 16.6, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(729), 19.0, 0, 19.0, 19.0, 5.9);  // Month - 2008-12-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(730), 19.7, 0, 19.7, 19.7, 3.8);


            





        }
        public static void AddWeatherData_Pivot_02(IrrigationSystem pIrrigationSystem,
                                WeatherStation pWeatherStation)
        {
            WeatherStation lWeatherStation;
            DateTime lFirstDay = new DateTime(2007, 1, 1);


            lWeatherStation = pWeatherStation;

            // DATOS DEL TIEMPO

            


            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(365), 24.3, 0, 24.3, 24.3, 4.2);  // Month - 2008-1-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(366), 27.2, 0, 27.2, 27.2, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(367), 25.7, 0, 25.7, 25.7, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(368), 19.3, 0, 19.3, 19.3, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(369), 20.4, 0, 20.4, 20.4, 5.4);  // Month - 2008-1-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(370), 22.8, 0, 22.8, 22.8, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(371), 26.9, 0, 26.9, 26.9, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(372), 28.5, 0, 28.5, 28.5, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(373), 26.0, 0, 26.0, 26.0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(374), 22.9, 0, 22.9, 22.9, 2.5);  // Month - 2008-1-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(375), 19.6, 0, 19.6, 19.6, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(376), 19.4, 0, 19.4, 19.4, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(377), 22.0, 0, 22.0, 22.0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(378), 24.8, 0, 24.8, 24.8, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(379), 27.8, 0, 27.8, 27.8, 6.6);  // Month - 2008-1-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(380), 20.2, 0, 20.2, 20.2, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(381), 18.7, 0, 18.7, 18.7, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(382), 20.5, 0, 20.5, 20.5, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(383), 17.4, 0, 17.4, 17.4, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(384), 18.9, 0, 18.9, 18.9, 4.1);  // Month - 2008-1-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(385), 22.1, 0, 22.1, 22.1, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(386), 21.0, 0, 21.0, 21.0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(387), 23.1, 0, 23.1, 23.1, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(388), 24.3, 0, 24.3, 24.3, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(389), 24.8, 0, 24.8, 24.8, 5.7);  // Month - 2008-1-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(390), 23.8, 0, 23.8, 23.8, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(391), 24.1, 0, 24.1, 24.1, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(392), 25.9, 0, 25.9, 25.9, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(393), 24.9, 0, 24.9, 24.9, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(394), 23.8, 0, 23.8, 23.8, 4.1);  // Month - 2008-1-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(395), 23.7, 0, 23.7, 23.7, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(396), 23.2, 0, 23.2, 23.2, 5.0);  // Month - 2008-2-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(397), 23.0, 0, 23.0, 23.0, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(398), 18.6, 0, 18.6, 18.6, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(399), 22.4, 0, 22.4, 22.4, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(400), 24.2, 0, 24.2, 24.2, 5.3);  // Month - 2008-2-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(401), 26.4, 0, 26.4, 26.4, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(402), 26.2, 0, 26.2, 26.2, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(403), 22.7, 0, 22.7, 22.7, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(404), 22.4, 0, 22.4, 22.4, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(405), 19.3, 0, 19.3, 19.3, 2.4);  // Month - 2008-2-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(406), 19.0, 0, 19.0, 19.0, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(407), 22.0, 0, 22.0, 22.0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(408), 22.4, 0, 22.4, 22.4, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(409), 23.7, 0, 23.7, 23.7, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(410), 25.5, 0, 25.5, 25.5, 5.1);  // Month - 2008-2-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(411), 24.4, 0, 24.4, 24.4, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(412), 24.8, 0, 24.8, 24.8, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(413), 23.5, 0, 23.5, 23.5, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(414), 24.1, 0, 24.1, 24.1, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(415), 24.3, 0, 24.3, 24.3, 4.7);  // Month - 2008-2-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(416), 25.0, 0, 25.0, 25.0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(417), 23.4, 0, 23.4, 23.4, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(418), 22.9, 0, 22.9, 22.9, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(419), 23.2, 0, 23.2, 23.2, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(420), 23.0, 0, 23.0, 23.0, 3.7);  // Month - 2008-2-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(421), 24.9, 0, 24.9, 24.9, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(422), 24.9, 0, 24.9, 24.9, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(423), 21.8, 0, 21.8, 21.8, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(424), 21.3, 0, 21.3, 21.3, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(425), 23.5, 0, 23.5, 23.5, 2.9);  // Month - 2008-3-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(426), 22.7, 0, 22.7, 22.7, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(427), 22.5, 0, 22.5, 22.5, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(428), 22.4, 0, 22.4, 22.4, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(429), 20.1, 0, 20.1, 20.1, 2.2);  // Month - 2008-3-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(430), 20.9, 0, 20.9, 20.9, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(431), 20.8, 0, 20.8, 20.8, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(432), 23.2, 0, 23.2, 23.2, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(433), 23.1, 0, 23.1, 23.1, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(434), 18.3, 0, 18.3, 18.3, 3.1);  // Month - 2008-3-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(435), 17.2, 0, 17.2, 17.2, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(436), 17.0, 0, 17.0, 17.0, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(437), 17.7, 0, 17.7, 17.7, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(438), 19.9, 0, 19.9, 19.9, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(439), 18.9, 0, 18.9, 18.9, 3.4);  // Month - 2008-3-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(440), 21.8, 0, 21.8, 21.8, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(441), 24.6, 0, 24.6, 24.6, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(442), 22.4, 0, 22.4, 22.4, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(443), 24.3, 0, 24.3, 24.3, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(444), 21.8, 0, 21.8, 21.8, 3.0);  // Month - 2008-3-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(445), 22.5, 0, 22.5, 22.5, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(446), 16.9, 0, 16.9, 16.9, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(447), 17.8, 0, 17.8, 17.8, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(448), 19.2, 0, 19.2, 19.2, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(449), 20.3, 0, 20.3, 20.3, 3.1);  // Month - 2008-3-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(450), 22.2, 0, 22.2, 22.2, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(451), 20.3, 0, 20.3, 20.3, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(452), 19.6, 0, 19.6, 19.6, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(453), 19.7, 0, 19.7, 19.7, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(454), 17.9, 0, 17.9, 17.9, 2.7);  // Month - 2008-3-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(455), 19.7, 0, 19.7, 19.7, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(456), 19.5, 0, 19.5, 19.5, 1.6);  // Month - 2008-4-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(457), 16.6, 0, 16.6, 16.6, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(458), 15.0, 0, 15.0, 15.0, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(459), 18.5, 0, 18.5, 18.5, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(460), 21.0, 0, 21.0, 21.0, 2.7);  // Month - 2008-4-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(461), 21.7, 0, 21.7, 21.7, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(462), 21.3, 0, 21.3, 21.3, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(463), 19.3, 0, 19.3, 19.3, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(464), 19.2, 0, 19.2, 19.2, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(465), 21.6, 0, 21.6, 21.6, 2.3);  // Month - 2008-4-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(466), 20.3, 0, 20.3, 20.3, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(467), 12.5, 0, 12.5, 12.5, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(468), 11.6, 0, 11.6, 11.6, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(469), 10.5, 0, 10.5, 10.5, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(470), 10.7, 0, 10.7, 10.7, 1.6);  // Month - 2008-4-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(471), 13.3, 0, 13.3, 13.3, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(472), 16.8, 0, 16.8, 16.8, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(473), 18.9, 0, 18.9, 18.9, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(474), 19.0, 0, 19.0, 19.0, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(475), 20.4, 0, 20.4, 20.4, 2.7);  // Month - 2008-4-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(476), 20.3, 0, 20.3, 20.3, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(477), 20.4, 0, 20.4, 20.4, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(478), 19.2, 0, 19.2, 19.2, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(479), 18.9, 0, 18.9, 18.9, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(480), 15.7, 0, 15.7, 15.7, 1.6);  // Month - 2008-4-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(481), 14.4, 0, 14.4, 14.4, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(482), 16.0, 0, 16.0, 16.0, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(483), 16.4, 0, 16.4, 16.4, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(484), 11.6, 0, 11.6, 11.6, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(485), 10.5, 0, 10.5, 10.5, 1.0);  // Month - 2008-4-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(486), 10.4, 0, 10.4, 10.4, 0.8);  // Month - 2008-5-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(487), 11.5, 0, 11.5, 11.5, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(488), 14.4, 0, 14.4, 14.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(489), 12.7, 0, 12.7, 12.7, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(490), 11.0, 0, 11.0, 11.0, 0.7);  // Month - 2008-5-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(491), 14.0, 0, 14.0, 14.0, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(492), 13.4, 0, 13.4, 13.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(493), 10.6, 0, 10.6, 10.6, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(494), 11.0, 0, 11.0, 11.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(495), 10.9, 0, 10.9, 10.9, 0.8);  // Month - 2008-5-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(496), 12.2, 0, 12.2, 12.2, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(497), 13.9, 0, 13.9, 13.9, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(498), 14.4, 0, 14.4, 14.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(499), 15.4, 0, 15.4, 15.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(500), 18.0, 0, 18.0, 18.0, 1.4);  // Month - 2008-5-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(501), 14.6, 0, 14.6, 14.6, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(502), 19.5, 0, 19.5, 19.5, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(503), 20.9, 0, 20.9, 20.9, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(504), 22.7, 0, 22.7, 22.7, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(505), 19.5, 0, 19.5, 19.5, 0.6);  // Month - 2008-5-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(506), 18.7, 0, 18.7, 18.7, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(507), 17.2, 0, 17.2, 17.2, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(508), 18.2, 0, 18.2, 18.2, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(509), 14.3, 0, 14.3, 14.3, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(510), 16.0, 0, 16.0, 16.0, 0.5);  // Month - 2008-5-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(511), 13.8, 0, 13.8, 13.8, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(512), 13.8, 0, 13.8, 13.8, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(513), 11.0, 0, 11.0, 11.0, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(514), 08.0, 0, 08.0, 08.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(515), 07.3, 0, 07.3, 07.3, 0.3);  // Month - 2008-5-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(516), 07.1, 0, 07.1, 07.1, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(517), 07.0, 0, 07.0, 07.0, 0.2);  // Month - 2008-6-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(518), 08.4, 0, 08.4, 08.4, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(519), 09.1, 0, 09.1, 09.1, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(520), 11.5, 0, 11.5, 11.5, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(521), 14.4, 0, 14.4, 14.4, 0.4);  // Month - 2008-6-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(522), 10.6, 0, 10.6, 10.6, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(523), 10.5, 0, 10.5, 10.5, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(524), 11.0, 0, 11.0, 11.0, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(525), 09.9, 0, 09.9, 09.9, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(526), 09.4, 0, 09.4, 09.4, 0.4);  // Month - 2008-6-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(527), 11.6, 0, 11.6, 11.6, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(528), 09.1, 0, 09.1, 09.1, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(529), 11.2, 0, 11.2, 11.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(530), 10.5, 0, 10.5, 10.5, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(531), 08.2, 0, 08.2, 08.2, 0.7);  // Month - 2008-6-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(532), 08.0, 0, 08.0, 08.0, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(533), 10.0, 0, 10.0, 10.0, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(534), 07.4, 0, 07.4, 07.4, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(535), 11.0, 0, 11.0, 11.0, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(536), 11.1, 0, 11.1, 11.1, 0.3);  // Month - 2008-6-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(537), 10.8, 0, 10.8, 10.8, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(538), 08.9, 0, 08.9, 08.9, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(539), 09.1, 0, 09.1, 09.1, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(540), 08.4, 0, 08.4, 08.4, 0.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(541), 10.8, 0, 10.8, 10.8, 0.3);  // Month - 2008-6-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(542), 12.6, 0, 12.6, 12.6, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(543), 11.7, 0, 11.7, 11.7, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(544), 10.3, 0, 10.3, 10.3, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(545), 11.4, 0, 11.4, 11.4, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(546), 14.1, 0, 14.1, 14.1, 0.4);  // Month - 2008-6-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(547), 10.6, 0, 10.6, 10.6, 0.4);  // Month - 2008-7-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(548), 09.7, 0, 09.7, 09.7, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(549), 10.2, 0, 10.2, 10.2, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(550), 09.4, 0, 09.4, 09.4, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(551), 20.3, 0, 20.3, 20.3, 1.1);  // Month - 2008-7-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(552), 16.8, 0, 16.8, 16.8, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(553), 16.0, 0, 16.0, 16.0, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(554), 13.1, 0, 13.1, 13.1, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(555), 13.2, 0, 13.2, 13.2, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(556), 13.9, 0, 13.9, 13.9, 0.4);  // Month - 2008-7-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(557), 17.2, 0, 17.2, 17.2, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(558), 18.9, 0, 18.9, 18.9, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(559), 14.8, 0, 14.8, 14.8, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(560), 14.0, 0, 14.0, 14.0, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(561), 22.5, 0, 22.5, 22.5, 1.4);  // Month - 2008-7-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(562), 19.2, 0, 19.2, 19.2, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(563), 19.2, 0, 19.2, 19.2, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(564), 10.5, 0, 10.5, 10.5, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(565), 09.1, 0, 09.1, 09.1, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(566), 08.0, 0, 08.0, 08.0, 0.8);  // Month - 2008-7-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(567), 10.2, 0, 10.2, 10.2, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(568), 10.5, 0, 10.5, 10.5, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(569), 10.6, 0, 10.6, 10.6, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(570), 10.2, 0, 10.2, 10.2, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(571), 09.2, 0, 09.2, 09.2, 0.4);  // Month - 2008-7-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(572), 09.3, 0, 09.3, 09.3, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(573), 12.0, 0, 12.0, 12.0, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(574), 14.5, 0, 14.5, 14.5, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(575), 14.8, 0, 14.8, 14.8, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(576), 13.6, 0, 13.6, 13.6, 0.5);  // Month - 2008-7-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(577), 10.5, 0, 10.5, 10.5, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(578), 10.5, 0, 10.5, 10.5, 0.4);  // Month - 2008-8-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(579), 10.9, 0, 10.9, 10.9, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(580), 07.3, 0, 07.3, 07.3, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(581), 09.8, 0, 09.8, 09.8, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(582), 08.8, 0, 08.8, 08.8, 0.8);  // Month - 2008-8-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(583), 09.3, 0, 09.3, 09.3, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(584), 08.5, 0, 08.5, 08.5, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(585), 06.9, 0, 06.9, 06.9, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(586), 08.1, 0, 08.1, 08.1, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(587), 13.9, 0, 13.9, 13.9, 1.5);  // Month - 2008-8-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(588), 16.4, 0, 16.4, 16.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(589), 07.6, 0, 07.6, 07.6, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(590), 08.2, 0, 08.2, 08.2, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(591), 11.1, 0, 11.1, 11.1, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(592), 15.4, 0, 15.4, 15.4, 0.8);  // Month - 2008-8-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(593), 17.7, 0, 17.7, 17.7, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(594), 09.1, 0, 09.1, 09.1, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(595), 07.9, 0, 07.9, 07.9, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(596), 11.6, 0, 11.6, 11.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(597), 14.3, 0, 14.3, 14.3, 0.6);  // Month - 2008-8-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(598), 09.6, 0, 09.6, 09.6, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(599), 09.5, 0, 09.5, 09.5, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(600), 10.2, 0, 10.2, 10.2, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(601), 11.6, 0, 11.6, 11.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(602), 13.2, 0, 13.2, 13.2, 1.2);  // Month - 2008-8-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(603), 13.3, 0, 13.3, 13.3, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(604), 16.9, 0, 16.9, 16.9, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(605), 11.3, 0, 11.3, 11.3, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(606), 10.5, 0, 10.5, 10.5, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(607), 12.4, 0, 12.4, 12.4, 2.0);  // Month - 2008-8-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(608), 14.9, 0, 14.9, 14.9, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(609), 16.0, 0, 16.0, 16.0, 1.6);  // Month - 2008-9-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(610), 17.6, 0, 17.6, 17.6, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(611), 10.3, 0, 10.3, 10.3, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(612), 08.5, 0, 08.5, 08.5, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(613), 06.6, 0, 06.6, 06.6, 1.0);  // Month - 2008-9-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(614), 08.0, 0, 08.0, 08.0, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(615), 11.4, 0, 11.4, 11.4, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(616), 10.6, 0, 10.6, 10.6, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(617), 12.3, 0, 12.3, 12.3, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(618), 13.1, 0, 13.1, 13.1, 1.3);  // Month - 2008-9-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(619), 13.5, 0, 13.5, 13.5, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(620), 09.3, 0, 09.3, 09.3, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(621), 08.3, 0, 08.3, 08.3, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(622), 10.5, 0, 10.5, 10.5, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(623), 10.0, 0, 10.0, 10.0, 1.3);  // Month - 2008-9-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(624), 11.7, 0, 11.7, 11.7, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(625), 11.7, 0, 11.7, 11.7, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(626), 13.6, 0, 13.6, 13.6, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(627), 14.3, 0, 14.3, 14.3, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(628), 12.1, 0, 12.1, 12.1, 1.1);  // Month - 2008-9-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(629), 13.2, 0, 13.2, 13.2, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(630), 15.5, 0, 15.5, 15.5, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(631), 13.2, 0, 13.2, 13.2, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(632), 14.4, 0, 14.4, 14.4, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(633), 16.0, 0, 16.0, 16.0, 2.5);  // Month - 2008-9-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(634), 17.9, 0, 17.9, 17.9, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(635), 18.3, 0, 18.3, 18.3, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(636), 18.3, 0, 18.3, 18.3, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(637), 17.2, 0, 17.2, 17.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(638), 13.6, 0, 13.6, 13.6, 1.0);  // Month - 2008-9-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(639), 16.5, 0, 16.5, 16.5, 1.5);  // Month - 2008-10-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(640), 16.6, 0, 16.6, 16.6, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(641), 15.9, 0, 15.9, 15.9, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(642), 12.1, 0, 12.1, 12.1, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(643), 11.5, 0, 11.5, 11.5, 3.0);  // Month - 2008-10-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(644), 16.3, 0, 16.3, 16.3, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(645), 09.5, 0, 09.5, 09.5, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(646), 09.4, 0, 09.4, 09.4, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(647), 14.1, 0, 14.1, 14.1, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(648), 18.0, 0, 18.0, 18.0, 3.3);  // Month - 2008-10-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(649), 21.3, 0, 21.3, 21.3, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(650), 18.2, 0, 18.2, 18.2, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(651), 17.6, 0, 17.6, 17.6, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(652), 15.9, 0, 15.9, 15.9, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(653), 14.0, 0, 14.0, 14.0, 1.3);  // Month - 2008-10-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(654), 13.2, 0, 13.2, 13.2, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(655), 12.5, 0, 12.5, 12.5, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(656), 15.4, 0, 15.4, 15.4, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(657), 17.1, 0, 17.1, 17.1, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(658), 21.6, 0, 21.6, 21.6, 4.6);  // Month - 2008-10-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(659), 19.7, 0, 19.7, 19.7, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(660), 15.5, 0, 15.5, 15.5, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(661), 16.4, 0, 16.4, 16.4, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(662), 20.1, 0, 20.1, 20.1, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(663), 19.0, 0, 19.0, 19.0, 3.0);  // Month - 2008-10-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(664), 18.4, 0, 18.4, 18.4, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(665), 14.9, 0, 14.9, 14.9, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(666), 17.0, 0, 17.0, 17.0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(667), 17.4, 0, 17.4, 17.4, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(668), 14.5, 0, 14.5, 14.5, 3.6);  // Month - 2008-10-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(669), 17.5, 0, 17.5, 17.5, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(670), 19.9, 0, 19.9, 19.9, 4.6);  // Month - 2008-11-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(671), 18.3, 0, 18.3, 18.3, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(672), 20.6, 0, 20.6, 20.6, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(673), 23.4, 0, 23.4, 23.4, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(674), 26.7, 0, 26.7, 26.7, 5.4);  // Month - 2008-11-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(675), 21.7, 0, 21.7, 21.7, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(676), 21.6, 0, 21.6, 21.6, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(677), 23.5, 0, 23.5, 23.5, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(678), 22.7, 0, 22.7, 22.7, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(679), 20.7, 0, 20.7, 20.7, 4.8);  // Month - 2008-11-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(680), 23.0, 0, 23.0, 23.0, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(681), 22.1, 0, 22.1, 22.1, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(682), 21.7, 0, 21.7, 21.7, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(683), 22.4, 0, 22.4, 22.4, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(684), 16.3, 0, 16.3, 16.3, 3.8);  // Month - 2008-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(685), 15.3, 0, 15.3, 15.3, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(686), 16.9, 0, 16.9, 16.9, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(687), 17.9, 0, 17.9, 17.9, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(688), 17.1, 0, 17.1, 17.1, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(689), 19.3, 0, 19.3, 19.3, 5.6);  // Month - 2008-11-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(690), 20.6, 0, 20.6, 20.6, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(691), 23.7, 0, 23.7, 23.7, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(692), 25.3, 0, 25.3, 25.3, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(693), 26.3, 0, 26.3, 26.3, 7.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(694), 28.1, 0, 28.1, 28.1, 6.4);  // Month - 2008-11-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(695), 26.3, 0, 26.3, 26.3, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(696), 28.4, 0, 28.4, 28.4, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(697), 27.1, 0, 27.1, 27.1, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(698), 28.4, 0, 28.4, 28.4, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(699), 27.1, 0, 27.1, 27.1, 3.1);  // Month - 2008-11-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(700), 23.1, 0, 23.1, 23.1, 2.0);  // Month - 2008-12-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(701), 22.0, 0, 22.0, 22.0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(702), 18.3, 0, 18.3, 18.3, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(703), 16.4, 0, 16.4, 16.4, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(704), 18.1, 0, 18.1, 18.1, 4.8);  // Month - 2008-12-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(705), 21.8, 0, 21.8, 21.8, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(706), 25.3, 0, 25.3, 25.3, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(707), 27.3, 0, 27.3, 27.3, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(708), 26.4, 0, 26.4, 26.4, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(709), 22.5, 0, 22.5, 22.5, 4.1);  // Month - 2008-12-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(710), 20.2, 0, 20.2, 20.2, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(711), 20.8, 0, 20.8, 20.8, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(712), 21.7, 0, 21.7, 21.7, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(713), 22.1, 0, 22.1, 22.1, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(714), 22.2, 0, 22.2, 22.2, 6.0);  // Month - 2008-12-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(715), 24.8, 0, 24.8, 24.8, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(716), 24.1, 0, 24.1, 24.1, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(717), 23.8, 0, 23.8, 23.8, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(718), 24.0, 0, 24.0, 24.0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(719), 26.8, 0, 26.8, 26.8, 7.6);  // Month - 2008-12-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(720), 24.3, 0, 24.3, 24.3, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(721), 21.1, 0, 21.1, 21.1, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(722), 22.5, 0, 22.5, 22.5, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(723), 23.5, 0, 23.5, 23.5, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(724), 22.4, 0, 22.4, 22.4, 4.3);  // Month - 2008-12-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(725), 20.8, 0, 20.8, 20.8, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(726), 26.0, 0, 26.0, 26.0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(727), 25.8, 0, 25.8, 25.8, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(728), 16.6, 0, 16.6, 16.6, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(729), 19.0, 0, 19.0, 19.0, 5.9);  // Month - 2008-12-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(730), 19.7, 0, 19.7, 19.7, 3.8);


            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(731), 18.5, 0, 18.5, 18.5, 5.0);  // Month - 2009-1-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(732), 19.6, 0, 19.6, 19.6, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(733), 19.9, 0, 19.9, 19.9, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(734), 21.4, 0, 21.4, 21.4, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(735), 26.4, 0, 26.4, 26.4, 8.0);  // Month - 2009-1-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(736), 26.2, 0, 26.2, 26.2, 8.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(737), 23.3, 0, 23.3, 23.3, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(738), 23.3, 0, 23.3, 23.3, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(739), 24.5, 0, 24.5, 24.5, 7.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(740), 23.8, 0, 23.8, 23.8, 6.9);  // Month - 2009-1-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(741), 23.0, 0, 23.0, 23.0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(742), 22.7, 0, 22.7, 22.7, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(743), 23.6, 0, 23.6, 23.6, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(744), 23.2, 0, 23.2, 23.2, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(745), 23.5, 0, 23.5, 23.5, 6.0);  // Month - 2009-1-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(746), 25.8, 0, 25.8, 25.8, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(747), 28.7, 0, 28.7, 28.7, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(748), 18.9, 0, 18.9, 18.9, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(749), 17.4, 0, 17.4, 17.4, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(750), 22.0, 0, 22.0, 22.0, 6.3);  // Month - 2009-1-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(751), 25.2, 0, 25.2, 25.2, 7.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(752), 26.0, 0, 26.0, 26.0, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(753), 27.1, 0, 27.1, 27.1, 8.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(754), 27.5, 0, 27.5, 27.5, 7.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(755), 25.9, 0, 25.9, 25.9, 4.3);  // Month - 2009-1-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(756), 23.2, 0, 23.2, 23.2, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(757), 23.2, 0, 23.2, 23.2, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(758), 23.7, 0, 23.7, 23.7, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(759), 20.8, 0, 20.8, 20.8, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(760), 20.7, 0, 20.7, 20.7, 1.6);  // Month - 2009-1-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(761), 21.5, 0, 21.5, 21.5, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(762), 18.6, 0, 18.6, 18.6, 5.1);  // Month - 2009-2-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(763), 21.5, 0, 21.5, 21.5, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(764), 23.2, 0, 23.2, 23.2, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(765), 23.0, 0, 23.0, 23.0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(766), 23.0, 0, 23.0, 23.0, 3.6);  // Month - 2009-2-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(767), 22.2, 0, 22.2, 22.2, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(768), 19.8, 0, 19.8, 19.8, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(769), 21.5, 0, 21.5, 21.5, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(770), 23.9, 0, 23.9, 23.9, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(771), 26.8, 0, 26.8, 26.8, 4.3);  // Month - 2009-2-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(772), 19.2, 0, 19.2, 19.2, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(773), 19.9, 0, 19.9, 19.9, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(774), 23.2, 0, 23.2, 23.2, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(775), 24.7, 0, 24.7, 24.7, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(776), 24.6, 0, 24.6, 24.6, 5.6);  // Month - 2009-2-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(777), 24.3, 0, 24.3, 24.3, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(778), 23.7, 0, 23.7, 23.7, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(779), 25.9, 0, 25.9, 25.9, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(780), 27.8, 0, 27.8, 27.8, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(781), 26.7, 0, 26.7, 26.7, 2.9);  // Month - 2009-2-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(782), 22.7, 0, 22.7, 22.7, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(783), 18.8, 0, 18.8, 18.8, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(784), 19.0, 0, 19.0, 19.0, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(785), 19.9, 0, 19.9, 19.9, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(786), 21.3, 0, 21.3, 21.3, 3.8);  // Month - 2009-2-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(787), 21.3, 0, 21.3, 21.3, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(788), 22.5, 0, 22.5, 22.5, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(789), 22.2, 0, 22.2, 22.2, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(790), 25.9, 0, 25.9, 25.9, 3.7);  // Month - 2009-3-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(791), 23.0, 0, 23.0, 23.0, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(792), 21.5, 0, 21.5, 21.5, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(793), 20.5, 0, 20.5, 20.5, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(794), 22.1, 0, 22.1, 22.1, 3.2);  // Month - 2009-3-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(795), 21.5, 0, 21.5, 21.5, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(796), 21.5, 0, 21.5, 21.5, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(797), 20.9, 0, 20.9, 20.9, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(798), 21.3, 0, 21.3, 21.3, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(799), 23.1, 0, 23.1, 23.1, 3.8);  // Month - 2009-3-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(800), 21.3, 0, 21.3, 21.3, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(801), 21.5, 0, 21.5, 21.5, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(802), 21.0, 0, 21.0, 21.0, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(803), 25.6, 0, 25.6, 25.6, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(804), 16.7, 0, 16.7, 16.7, 4.0);  // Month - 2009-3-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(805), 16.6, 0, 16.6, 16.6, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(806), 18.6, 0, 18.6, 18.6, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(807), 20.0, 0, 20.0, 20.0, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(808), 20.1, 0, 20.1, 20.1, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(809), 22.0, 0, 22.0, 22.0, 2.8);  // Month - 2009-3-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(810), 22.9, 0, 22.9, 22.9, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(811), 23.5, 0, 23.5, 23.5, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(812), 23.2, 0, 23.2, 23.2, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(813), 22.5, 0, 22.5, 22.5, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(814), 20.7, 0, 20.7, 20.7, 2.8);  // Month - 2009-3-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(815), 22.0, 0, 22.0, 22.0, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(816), 21.5, 0, 21.5, 21.5, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(817), 22.8, 0, 22.8, 22.8, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(818), 25.1, 0, 25.1, 25.1, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(819), 22.3, 0, 22.3, 22.3, 3.1);  // Month - 2009-3-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(820), 17.7, 0, 17.7, 17.7, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(821), 15.6, 0, 15.6, 15.6, 2.5);  // Month - 2009-4-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(822), 14.7, 0, 14.7, 14.7, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(823), 20.1, 0, 20.1, 20.1, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(824), 16.5, 0, 16.5, 16.5, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(825), 17.4, 0, 17.4, 17.4, 2.3);  // Month - 2009-4-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(826), 18.7, 0, 18.7, 18.7, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(827), 19.5, 0, 19.5, 19.5, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(828), 15.2, 0, 15.2, 15.2, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(829), 14.5, 0, 14.5, 14.5, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(830), 17.0, 0, 17.0, 17.0, 2.6);  // Month - 2009-4-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(831), 19.9, 0, 19.9, 19.9, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(832), 21.7, 0, 21.7, 21.7, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(833), 22.0, 0, 22.0, 22.0, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(834), 12.9, 0, 12.9, 12.9, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(835), 13.0, 0, 13.0, 13.0, 1.7);  // Month - 2009-4-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(836), 17.5, 0, 17.5, 17.5, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(837), 19.9, 0, 19.9, 19.9, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(838), 16.8, 0, 16.8, 16.8, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(839), 13.8, 0, 13.8, 13.8, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(840), 14.8, 0, 14.8, 14.8, 1.6);  // Month - 2009-4-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(841), 15.4, 0, 15.4, 15.4, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(842), 19.7, 0, 19.7, 19.7, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(843), 19.5, 0, 19.5, 19.5, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(844), 16.2, 0, 16.2, 16.2, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(845), 17.0, 0, 17.0, 17.0, 1.2);  // Month - 2009-4-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(846), 15.1, 0, 15.1, 15.1, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(847), 16.4, 0, 16.4, 16.4, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(848), 20.7, 0, 20.7, 20.7, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(849), 19.0, 0, 19.0, 19.0, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(850), 15.8, 0, 15.8, 15.8, 1.4);  // Month - 2009-4-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(851), 14.5, 0, 14.5, 14.5, 1.3);  // Month - 2009-5-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(852), 15.9, 0, 15.9, 15.9, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(853), 16.1, 0, 16.1, 16.1, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(854), 18.8, 0, 18.8, 18.8, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(855), 13.3, 0, 13.3, 13.3, 0.8);  // Month - 2009-5-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(856), 13.6, 0, 13.6, 13.6, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(857), 14.3, 0, 14.3, 14.3, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(858), 15.6, 0, 15.6, 15.6, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(859), 16.3, 0, 16.3, 16.3, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(860), 18.1, 0, 18.1, 18.1, 1.5);  // Month - 2009-5-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(861), 17.5, 0, 17.5, 17.5, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(862), 14.3, 0, 14.3, 14.3, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(863), 14.2, 0, 14.2, 14.2, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(864), 12.6, 0, 12.6, 12.6, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(865), 09.2, 0, 09.2, 09.2, 0.7);  // Month - 2009-5-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(866), 09.9, 0, 09.9, 09.9, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(867), 13.0, 0, 13.0, 13.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(868), 12.4, 0, 12.4, 12.4, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(869), 09.3, 0, 09.3, 09.3, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(870), 16.2, 0, 16.2, 16.2, 0.6);  // Month - 2009-5-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(871), 22.5, 0, 22.5, 22.5, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(872), 23.0, 0, 23.0, 23.0, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(873), 22.5, 0, 22.5, 22.5, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(874), 21.4, 0, 21.4, 21.4, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(875), 19.4, 0, 19.4, 19.4, 0.6);  // Month - 2009-5-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(876), 11.1, 0, 11.1, 11.1, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(877), 09.4, 0, 09.4, 09.4, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(878), 10.2, 0, 10.2, 10.2, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(879), 09.3, 0, 09.3, 09.3, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(880), 08.2, 0, 08.2, 08.2, 0.4);  // Month - 2009-5-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(881), 11.6, 0, 11.6, 11.6, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(882), 10.9, 0, 10.9, 10.9, 0.6);  // Month - 2009-6-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(883), 09.0, 0, 09.0, 09.0, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(884), 07.4, 0, 07.4, 07.4, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(885), 12.6, 0, 12.6, 12.6, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(886), 11.1, 0, 11.1, 11.1, 0.4);  // Month - 2009-6-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(887), 10.5, 0, 10.5, 10.5, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(888), 10.1, 0, 10.1, 10.1, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(889), 08.2, 0, 08.2, 08.2, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(890), 05.1, 0, 05.1, 05.1, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(891), 09.5, 0, 09.5, 09.5, 0.2);  // Month - 2009-6-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(892), 06.8, 0, 06.8, 06.8, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(893), 06.0, 0, 06.0, 06.0, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(894), 09.6, 0, 09.6, 09.6, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(895), 13.4, 0, 13.4, 13.4, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(896), 13.0, 0, 13.0, 13.0, 0.4);  // Month - 2009-6-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(897), 08.1, 0, 08.1, 08.1, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(898), 09.3, 0, 09.3, 09.3, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(899), 11.0, 0, 11.0, 11.0, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(900), 15.3, 0, 15.3, 15.3, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(901), 15.3, 0, 15.3, 15.3, 0.7);  // Month - 2009-6-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(902), 09.8, 0, 09.8, 09.8, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(903), 08.0, 0, 08.0, 08.0, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(904), 07.0, 0, 07.0, 07.0, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(905), 06.1, 0, 06.1, 06.1, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(906), 06.5, 0, 06.5, 06.5, 0.2);  // Month - 2009-6-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(907), 06.6, 0, 06.6, 06.6, 0.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(908), 07.9, 0, 07.9, 07.9, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(909), 08.8, 0, 08.8, 08.8, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(910), 12.4, 0, 12.4, 12.4, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(911), 10.4, 0, 10.4, 10.4, 0.4);  // Month - 2009-6-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(912), 11.2, 0, 11.2, 11.2, 0.4);  // Month - 2009-7-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(913), 09.3, 0, 09.3, 09.3, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(914), 10.4, 0, 10.4, 10.4, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(915), 11.1, 0, 11.1, 11.1, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(916), 14.7, 0, 14.7, 14.7, 1.0);  // Month - 2009-7-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(917), 13.9, 0, 13.9, 13.9, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(918), 15.3, 0, 15.3, 15.3, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(919), 06.8, 0, 06.8, 06.8, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(920), 06.2, 0, 06.2, 06.2, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(921), 06.0, 0, 06.0, 06.0, 0.5);  // Month - 2009-7-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(922), 06.5, 0, 06.5, 06.5, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(923), 09.6, 0, 09.6, 09.6, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(924), 08.2, 0, 08.2, 08.2, 0.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(925), 06.5, 0, 06.5, 06.5, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(926), 05.9, 0, 05.9, 05.9, 0.5);  // Month - 2009-7-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(927), 09.0, 0, 09.0, 09.0, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(928), 11.6, 0, 11.6, 11.6, 0.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(929), 12.0, 0, 12.0, 12.0, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(930), 14.4, 0, 14.4, 14.4, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(931), 12.6, 0, 12.6, 12.6, 0.7);  // Month - 2009-7-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(932), 13.2, 0, 13.2, 13.2, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(933), 07.6, 0, 07.6, 07.6, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(934), 05.4, 0, 05.4, 05.4, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(935), 06.3, 0, 06.3, 06.3, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(936), 06.7, 0, 06.7, 06.7, 0.8);  // Month - 2009-7-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(937), 06.4, 0, 06.4, 06.4, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(938), 09.0, 0, 09.0, 09.0, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(939), 05.6, 0, 05.6, 05.6, 0.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(940), 05.3, 0, 05.3, 05.3, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(941), 04.0, 0, 04.0, 04.0, 0.4);  // Month - 2009-7-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(942), 03.1, 0, 03.1, 03.1, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(943), 07.5, 0, 07.5, 07.5, 0.6);  // Month - 2009-8-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(944), 11.1, 0, 11.1, 11.1, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(945), 10.0, 0, 10.0, 10.0, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(946), 13.4, 0, 13.4, 13.4, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(947), 12.6, 0, 12.6, 12.6, 0.8);  // Month - 2009-8-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(948), 08.9, 0, 08.9, 08.9, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(949), 08.3, 0, 08.3, 08.3, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(950), 07.3, 0, 07.3, 07.3, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(951), 07.0, 0, 07.0, 07.0, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(952), 10.1, 0, 10.1, 10.1, 1.2);  // Month - 2009-8-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(953), 12.6, 0, 12.6, 12.6, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(954), 14.3, 0, 14.3, 14.3, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(955), 14.8, 0, 14.8, 14.8, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(956), 19.0, 0, 19.0, 19.0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(957), 24.7, 0, 24.7, 24.7, 2.9);  // Month - 2009-8-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(958), 14.3, 0, 14.3, 14.3, 0.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(959), 10.1, 0, 10.1, 10.1, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(960), 10.3, 0, 10.3, 10.3, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(961), 10.0, 0, 10.0, 10.0, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(962), 08.8, 0, 08.8, 08.8, 0.8);  // Month - 2009-8-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(963), 07.8, 0, 07.8, 07.8, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(964), 12.3, 0, 12.3, 12.3, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(965), 11.6, 0, 11.6, 11.6, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(966), 13.1, 0, 13.1, 13.1, 1.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(967), 17.0, 0, 17.0, 17.0, 1.8);  // Month - 2009-8-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(968), 19.7, 0, 19.7, 19.7, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(969), 20.9, 0, 20.9, 20.9, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(970), 20.2, 0, 20.2, 20.2, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(971), 22.5, 0, 22.5, 22.5, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(972), 23.3, 0, 23.3, 23.3, 3.0);  // Month - 2009-8-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(973), 15.4, 0, 15.4, 15.4, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(974), 13.7, 0, 13.7, 13.7, 0.8);  // Month - 2009-9-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(975), 13.5, 0, 13.5, 13.5, 0.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(976), 14.0, 0, 14.0, 14.0, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(977), 12.3, 0, 12.3, 12.3, 0.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(978), 11.6, 0, 11.6, 11.6, 1.1);  // Month - 2009-9-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(979), 15.2, 0, 15.2, 15.2, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(980), 13.6, 0, 13.6, 13.6, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(981), 09.7, 0, 09.7, 09.7, 1.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(982), 07.2, 0, 07.2, 07.2, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(983), 07.7, 0, 07.7, 07.7, 1.5);  // Month - 2009-9-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(984), 09.2, 0, 09.2, 09.2, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(985), 11.3, 0, 11.3, 11.3, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(986), 12.3, 0, 12.3, 12.3, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(987), 15.2, 0, 15.2, 15.2, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(988), 15.9, 0, 15.9, 15.9, 1.9);  // Month - 2009-9-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(989), 14.1, 0, 14.1, 14.1, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(990), 12.0, 0, 12.0, 12.0, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(991), 14.3, 0, 14.3, 14.3, 0.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(992), 12.0, 0, 12.0, 12.0, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(993), 12.6, 0, 12.6, 12.6, 2.5);  // Month - 2009-9-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(994), 14.6, 0, 14.6, 14.6, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(995), 14.3, 0, 14.3, 14.3, 1.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(996), 09.8, 0, 09.8, 09.8, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(997), 10.0, 0, 10.0, 10.0, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(998), 12.0, 0, 12.0, 12.0, 2.3);  // Month - 2009-9-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(999), 15.8, 0, 15.8, 15.8, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1000), 12.2, 0, 12.2, 12.2, 1.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1001), 08.9, 0, 08.9, 08.9, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1002), 09.3, 0, 09.3, 09.3, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1003), 09.8, 0, 09.8, 09.8, 2.1);  // Month - 2009-9-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1004), 10.4, 0, 10.4, 10.4, 0.9);  // Month - 2009-10-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1005), 12.5, 0, 12.5, 12.5, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1006), 14.7, 0, 14.7, 14.7, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1007), 16.9, 0, 16.9, 16.9, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1008), 17.5, 0, 17.5, 17.5, 1.7);  // Month - 2009-10-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1009), 13.6, 0, 13.6, 13.6, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1010), 10.2, 0, 10.2, 10.2, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1011), 10.3, 0, 10.3, 10.3, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1012), 12.4, 0, 12.4, 12.4, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1013), 17.4, 0, 17.4, 17.4, 3.3);  // Month - 2009-10-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1014), 13.3, 0, 13.3, 13.3, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1015), 12.4, 0, 12.4, 12.4, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1016), 16.5, 0, 16.5, 16.5, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1017), 09.4, 0, 09.4, 09.4, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1018), 08.3, 0, 08.3, 08.3, 2.6);  // Month - 2009-10-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1019), 12.1, 0, 12.1, 12.1, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1020), 14.7, 0, 14.7, 14.7, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1021), 14.7, 0, 14.7, 14.7, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1022), 17.8, 0, 17.8, 17.8, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1023), 17.0, 0, 17.0, 17.0, 3.1);  // Month - 2009-10-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1024), 13.6, 0, 13.6, 13.6, 1.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1025), 16.3, 0, 16.3, 16.3, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1026), 20.8, 0, 20.8, 20.8, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1027), 13.3, 0, 13.3, 13.3, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1028), 14.4, 0, 14.4, 14.4, 3.7);  // Month - 2009-10-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1029), 11.6, 0, 11.6, 11.6, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1030), 13.6, 0, 13.6, 13.6, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1031), 19.2, 0, 19.2, 19.2, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1032), 23.2, 0, 23.2, 23.2, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1033), 21.9, 0, 21.9, 21.9, 2.2);  // Month - 2009-10-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1034), 17.9, 0, 17.9, 17.9, 1.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1035), 19.9, 0, 19.9, 19.9, 1.5);  // Month - 2009-11-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1036), 19.1, 0, 19.1, 19.1, 1.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1037), 15.9, 0, 15.9, 15.9, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1038), 16.0, 0, 16.0, 16.0, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1039), 19.1, 0, 19.1, 19.1, 3.8);  // Month - 2009-11-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1040), 20.7, 0, 20.7, 20.7, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1041), 12.9, 0, 12.9, 12.9, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1042), 15.4, 0, 15.4, 15.4, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1043), 16.5, 0, 16.5, 16.5, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1044), 15.6, 0, 15.6, 15.6, 4.5);  // Month - 2009-11-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1045), 18.6, 0, 18.6, 18.6, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1046), 20.6, 0, 20.6, 20.6, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1047), 23.5, 0, 23.5, 23.5, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1048), 19.2, 0, 19.2, 19.2, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1049), 19.4, 0, 19.4, 19.4, 3.8);  // Month - 2009-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1050), 20.9, 0, 20.9, 20.9, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1051), 19.8, 0, 19.8, 19.8, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1052), 19.0, 0, 19.0, 19.0, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1053), 18.7, 0, 18.7, 18.7, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1054), 18.7, 0, 18.7, 18.7, 4.7);  // Month - 2009-11-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1055), 18.9, 0, 18.9, 18.9, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1056), 20.2, 0, 20.2, 20.2, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1057), 22.0, 0, 22.0, 22.0, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1058), 24.0, 0, 24.0, 24.0, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1059), 24.3, 0, 24.3, 24.3, 4.2);  // Month - 2009-11-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1060), 20.9, 0, 20.9, 20.9, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1061), 17.0, 0, 17.0, 17.0, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1062), 19.9, 0, 19.9, 19.9, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1063), 21.7, 0, 21.7, 21.7, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1064), 19.4, 0, 19.4, 19.4, 4.5);  // Month - 2009-11-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1065), 19.4, 0, 19.4, 19.4, 4.2);  // Month - 2009-12-1
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1066), 21.3, 0, 21.3, 21.3, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1067), 14.5, 0, 14.5, 14.5, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1068), 14.4, 0, 14.4, 14.4, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1069), 14.1, 0, 14.1, 14.1, 3.8);  // Month - 2009-12-5
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1070), 16.0, 0, 16.0, 16.0, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1071), 14.2, 0, 14.2, 14.2, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1072), 18.5, 0, 18.5, 18.5, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1073), 21.0, 0, 21.0, 21.0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1074), 22.7, 0, 22.7, 22.7, 5.5);  // Month - 2009-12-10
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1075), 21.2, 0, 21.2, 21.2, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1076), 17.4, 0, 17.4, 17.4, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1077), 17.7, 0, 17.7, 17.7, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1078), 20.9, 0, 20.9, 20.9, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1079), 21.3, 0, 21.3, 21.3, 4.6);  // Month - 2009-12-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1080), 19.0, 0, 19.0, 19.0, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1081), 20.9, 0, 20.9, 20.9, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1082), 23.4, 0, 23.4, 23.4, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1083), 26.5, 0, 26.5, 26.5, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1084), 21.8, 0, 21.8, 21.8, 2.1);  // Month - 2009-12-20
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1085), 20.1, 0, 20.1, 20.1, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1086), 22.3, 0, 22.3, 22.3, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1087), 24.4, 0, 24.4, 24.4, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1088), 21.9, 0, 21.9, 21.9, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1089), 21.1, 0, 21.1, 21.1, 3.0);  // Month - 2009-12-25
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1090), 23.1, 0, 23.1, 23.1, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1091), 24.1, 0, 24.1, 24.1, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1092), 23.3, 0, 23.3, 23.3, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1093), 23.3, 0, 23.3, 23.3, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1094), 20.9, 0, 20.9, 20.9, 5.9);  // Month - 2009-12-30
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1095), 19.5, 0, 19.5, 19.5, 5.2);





        }
        public static void AddWeatherData_Pivot_03(IrrigationSystem pIrrigationSystem,
                                WeatherStation pWeatherStation)
        {
            WeatherStation lWeatherStation;
            DateTime lFirstDay = new DateTime(2010, 10, 20);


            lWeatherStation = pWeatherStation;

            // DATOS DEL TIEMPO

            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(000), 0, 0, 0, 0, 4.9);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(001), 0, 0, 0, 0, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(002), 0, 0, 0, 0, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(003), 0, 0, 0, 0, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(004), 0, 0, 0, 0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(005), 0, 0, 0, 0, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(006), 0, 0, 0, 0, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(007), 0, 0, 0, 0, 4.6);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(008), 0, 0, 0, 0, 5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(009), 0, 0, 0, 0, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(010), 0, 0, 0, 0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(011), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(012), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(013), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(014), 0, 0, 0, 0, 6.2);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(015), 0, 0, 0, 0, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(016), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(017), 0, 0, 0, 0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(018), 0, 0, 0, 0, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(019), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(020), 0, 0, 0, 0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(021), 0, 0, 0, 0, 5.4);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(022), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(023), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(024), 0, 0, 0, 0, 6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(025), 0, 0, 0, 0, 4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(026), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(027), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(028), 0, 0, 0, 0, 5.2);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(029), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(030), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(031), 0, 0, 0, 0, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(032), 0, 0, 0, 0, 3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(033), 0, 0, 0, 0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(034), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(035), 0, 0, 0, 0, 5.9);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(036), 0, 0, 0, 0, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(037), 0, 0, 0, 0, 7.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(038), 0, 0, 0, 0, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(039), 0, 0, 0, 0, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(040), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(041), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(042), 0, 0, 0, 0, 5.6);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(043), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(044), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(045), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(046), 0, 0, 0, 0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(047), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(048), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(049), 0, 0, 0, 0, 6.2);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(050), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(051), 0, 0, 0, 0, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(052), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(053), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(054), 0, 0, 0, 0, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(055), 0, 0, 0, 0, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(056), 0, 0, 0, 0, 4.4);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(057), 0, 0, 0, 0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(058), 0, 0, 0, 0, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(059), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(060), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(061), 0, 0, 0, 0, 7.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(062), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(063), 0, 0, 0, 0, 6.0);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(064), 0, 0, 0, 0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(065), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(066), 0, 0, 0, 0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(067), 0, 0, 0, 0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(068), 0, 0, 0, 0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(069), 0, 0, 0, 0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(070), 0, 0, 0, 0, 5.8);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(071), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(072), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(073), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(074), 0, 0, 0, 0, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(075), 0, 0, 0, 0, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(076), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(077), 0, 0, 0, 0, 6.9);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(078), 0, 0, 0, 0, 7.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(079), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(080), 0, 0, 0, 0, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(081), 0, 0, 0, 0, 8.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(082), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(083), 0, 0, 0, 0, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(084), 0, 0, 0, 0, 6.4);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(085), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(086), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(087), 0, 0, 0, 0, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(088), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(089), 0, 0, 0, 0, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(090), 0, 0, 0, 0, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(091), 0, 0, 0, 0, 6.1);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(092), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(093), 0, 0, 0, 0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(094), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(095), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(096), 0, 0, 0, 0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(097), 0, 0, 0, 0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(098), 0, 0, 0, 0, 6.3);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(099), 0, 0, 0, 0, 7.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(100), 0, 0, 0, 0, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(101), 0, 0, 0, 0, 7.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(102), 0, 0, 0, 0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(103), 0, 0, 0, 0, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(104), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(105), 0, 0, 0, 0, 5.6);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(106), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(107), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(108), 0, 0, 0, 0, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(109), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(110), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(111), 0, 0, 0, 0, 6.0);

        }
        public static void AddWeatherData_Pivot_04(IrrigationSystem pIrrigationSystem,
                                WeatherStation pWeatherStation)
        {
            WeatherStation lWeatherStation;
            DateTime lFirstDay = new DateTime(2010, 10, 20);


            lWeatherStation = pWeatherStation;

            // DATOS DEL TIEMPO

            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(000), 0, 0, 0, 0, 4.9);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(001), 0, 0, 0, 0, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(002), 0, 0, 0, 0, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(003), 0, 0, 0, 0, 2.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(004), 0, 0, 0, 0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(005), 0, 0, 0, 0, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(006), 0, 0, 0, 0, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(007), 0, 0, 0, 0, 4.6);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(008), 0, 0, 0, 0, 5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(009), 0, 0, 0, 0, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(010), 0, 0, 0, 0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(011), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(012), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(013), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(014), 0, 0, 0, 0, 6.2);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(015), 0, 0, 0, 0, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(016), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(017), 0, 0, 0, 0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(018), 0, 0, 0, 0, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(019), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(020), 0, 0, 0, 0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(021), 0, 0, 0, 0, 5.4);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(022), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(023), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(024), 0, 0, 0, 0, 6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(025), 0, 0, 0, 0, 4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(026), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(027), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(028), 0, 0, 0, 0, 5.2);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(029), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(030), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(031), 0, 0, 0, 0, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(032), 0, 0, 0, 0, 3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(033), 0, 0, 0, 0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(034), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(035), 0, 0, 0, 0, 5.9);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(036), 0, 0, 0, 0, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(037), 0, 0, 0, 0, 7.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(038), 0, 0, 0, 0, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(039), 0, 0, 0, 0, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(040), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(041), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(042), 0, 0, 0, 0, 5.6);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(043), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(044), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(045), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(046), 0, 0, 0, 0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(047), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(048), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(049), 0, 0, 0, 0, 6.2);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(050), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(051), 0, 0, 0, 0, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(052), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(053), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(054), 0, 0, 0, 0, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(055), 0, 0, 0, 0, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(056), 0, 0, 0, 0, 4.4);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(057), 0, 0, 0, 0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(058), 0, 0, 0, 0, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(059), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(060), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(061), 0, 0, 0, 0, 7.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(062), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(063), 0, 0, 0, 0, 6.0);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(064), 0, 0, 0, 0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(065), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(066), 0, 0, 0, 0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(067), 0, 0, 0, 0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(068), 0, 0, 0, 0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(069), 0, 0, 0, 0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(070), 0, 0, 0, 0, 5.8);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(071), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(072), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(073), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(074), 0, 0, 0, 0, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(075), 0, 0, 0, 0, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(076), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(077), 0, 0, 0, 0, 6.9);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(078), 0, 0, 0, 0, 7.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(079), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(080), 0, 0, 0, 0, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(081), 0, 0, 0, 0, 8.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(082), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(083), 0, 0, 0, 0, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(084), 0, 0, 0, 0, 6.4);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(085), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(086), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(087), 0, 0, 0, 0, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(088), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(089), 0, 0, 0, 0, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(090), 0, 0, 0, 0, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(091), 0, 0, 0, 0, 6.1);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(092), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(093), 0, 0, 0, 0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(094), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(095), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(096), 0, 0, 0, 0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(097), 0, 0, 0, 0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(098), 0, 0, 0, 0, 6.3);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(099), 0, 0, 0, 0, 7.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(100), 0, 0, 0, 0, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(101), 0, 0, 0, 0, 7.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(102), 0, 0, 0, 0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(103), 0, 0, 0, 0, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(104), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(105), 0, 0, 0, 0, 5.6);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(106), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(107), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(108), 0, 0, 0, 0, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(109), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(110), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(111), 0, 0, 0, 0, 6.0);

        }

        public static void AddWeatherData_Pivot_05(IrrigationSystem pIrrigationSystem,
                                WeatherStation pWeatherStation)
        {
            WeatherStation lWeatherStation;
            DateTime lFirstDay = new DateTime(2010, 10, 10);


            lWeatherStation = pWeatherStation;

            // DATOS DEL TIEMPO

            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(000), 0, 0, 0, 0, 2.9);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(001), 0, 0, 0, 0, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(002), 0, 0, 0, 0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(003), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(004), 0, 0, 0, 0, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(005), 0, 0, 0, 0, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(006), 0, 0, 0, 0, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(007), 0, 0, 0, 0, 3.4);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(008), 0, 0, 0, 0, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(009), 0, 0, 0, 0, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(010), 0, 0, 0, 0, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(011), 0, 0, 0, 0, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(012), 0, 0, 0, 0, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(013), 0, 0, 0, 0, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(014), 0, 0, 0, 0, 4.3);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(015), 0, 0, 0, 0, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(016), 0, 0, 0, 0, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(017), 0, 0, 0, 0, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(018), 0, 0, 0, 0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(019), 0, 0, 0, 0, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(020), 0, 0, 0, 0, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(021), 0, 0, 0, 0, 4.1);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(022), 0, 0, 0, 0, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(023), 0, 0, 0, 0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(024), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(025), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(026), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(027), 0, 0, 0, 0, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(028), 0, 0, 0, 0, 7.0);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(029), 0, 0, 0, 0, 8.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(030), 0, 0, 0, 0, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(031), 0, 0, 0, 0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(032), 0, 0, 0, 0, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(033), 0, 0, 0, 0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(034), 0, 0, 0, 0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(035), 0, 0, 0, 0, 4.3);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(036), 0, 0, 0, 0, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(037), 0, 0, 0, 0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(038), 0, 0, 0, 0, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(039), 0, 0, 0, 0, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(040), 0, 0, 0, 0, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(041), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(042), 0, 0, 0, 0, 6.2);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(043), 0, 0, 0, 0, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(044), 0, 0, 0, 0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(045), 0, 0, 0, 0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(046), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(047), 0, 0, 0, 0, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(048), 0, 0, 0, 0, 7.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(049), 0, 0, 0, 0, 6.4);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(050), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(051), 0, 0, 0, 0, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(052), 0, 0, 0, 0, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(053), 0, 0, 0, 0, 7.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(054), 0, 0, 0, 0, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(055), 0, 0, 0, 0, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(056), 0, 0, 0, 0, 6.4);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(057), 0, 0, 0, 0, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(058), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(059), 0, 0, 0, 0, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(060), 0, 0, 0, 0, 7.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(061), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(062), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(063), 0, 0, 0, 0, 7.0);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(064), 0, 0, 0, 0, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(065), 0, 0, 0, 0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(066), 0, 0, 0, 0, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(067), 0, 0, 0, 0, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(068), 0, 0, 0, 0, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(069), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(070), 0, 0, 0, 0, 6.0);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(071), 0, 0, 0, 0, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(072), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(073), 0, 0, 0, 0, 7.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(074), 0, 0, 0, 0, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(075), 0, 0, 0, 0, 8.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(076), 0, 0, 0, 0, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(077), 0, 0, 0, 0, 5.2);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(078), 0, 0, 0, 0, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(079), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(080), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(081), 0, 0, 0, 0, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(082), 0, 0, 0, 0, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(083), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(084), 0, 0, 0, 0, 5.6);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(085), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(086), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(087), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(088), 0, 0, 0, 0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(089), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(090), 0, 0, 0, 0, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(091), 0, 0, 0, 0, 7.7);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(092), 0, 0, 0, 0, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(093), 0, 0, 0, 0, 7.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(094), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(095), 0, 0, 0, 0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(096), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(097), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(098), 0, 0, 0, 0, 4.2);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(099), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(100), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(101), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(102), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(103), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(104), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(105), 0, 0, 0, 0, 6.0);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(106), 0, 0, 0, 0, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(107), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(108), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(109), 0, 0, 0, 0, 7.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(110), 0, 0, 0, 0, 7.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(111), 0, 0, 0, 0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(112), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(113), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(114), 0, 0, 0, 0, 7.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(115), 0, 0, 0, 0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(116), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(117), 0, 0, 0, 0, 5.3);

        }
        public static void AddWeatherData_Pivot_06(IrrigationSystem pIrrigationSystem,
                                WeatherStation pWeatherStation)
        {
            WeatherStation lWeatherStation;
            DateTime lFirstDay = new DateTime(2010, 10, 26);


            lWeatherStation = pWeatherStation;

            // DATOS DEL TIEMPO

            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(000), 0, 0, 0, 0, 4.8);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(001), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(002), 0, 0, 0, 0, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(003), 0, 0, 0, 0, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(004), 0, 0, 0, 0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(005), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(006), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(007), 0, 0, 0, 0, 5.5);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(008), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(009), 0, 0, 0, 0, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(010), 0, 0, 0, 0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(011), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(012), 0, 0, 0, 0, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(013), 0, 0, 0, 0, 0.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(014), 0, 0, 0, 0, 1.8);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(015), 0, 0, 0, 0, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(016), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(017), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(018), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(019), 0, 0, 0, 0, 4.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(020), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(021), 0, 0, 0, 0, 5.9);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(022), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(023), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(024), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(025), 0, 0, 0, 0, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(026), 0, 0, 0, 0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(027), 0, 0, 0, 0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(028), 0, 0, 0, 0, 5.2);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(029), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(030), 0, 0, 0, 0, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(031), 0, 0, 0, 0, 7.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(032), 0, 0, 0, 0, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(033), 0, 0, 0, 0, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(034), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(035), 0, 0, 0, 0, 5.2);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(036), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(037), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(038), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(039), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(040), 0, 0, 0, 0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(041), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(042), 0, 0, 0, 0, 5.6);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(043), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(044), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(045), 0, 0, 0, 0, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(046), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(047), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(048), 0, 0, 0, 0, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(049), 0, 0, 0, 0, 4.5);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(050), 0, 0, 0, 0, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(051), 0, 0, 0, 0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(052), 0, 0, 0, 0, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(053), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(054), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(055), 0, 0, 0, 0, 7.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(056), 0, 0, 0, 0, 5.9);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(057), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(058), 0, 0, 0, 0, 3.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(059), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(060), 0, 0, 0, 0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(061), 0, 0, 0, 0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(062), 0, 0, 0, 0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(063), 0, 0, 0, 0, 6.2);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(064), 0, 0, 0, 0, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(065), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(066), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(067), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(068), 0, 0, 0, 0, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(069), 0, 0, 0, 0, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(070), 0, 0, 0, 0, 6.4);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(071), 0, 0, 0, 0, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(072), 0, 0, 0, 0, 7.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(073), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(074), 0, 0, 0, 0, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(075), 0, 0, 0, 0, 8.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(076), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(077), 0, 0, 0, 0, 2.9);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(078), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(079), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(080), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(081), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(082), 0, 0, 0, 0, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(083), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(084), 0, 0, 0, 0, 7.3);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(085), 0, 0, 0, 0, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(086), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(087), 0, 0, 0, 0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(088), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(089), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(090), 0, 0, 0, 0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(091), 0, 0, 0, 0, 5.4);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(092), 0, 0, 0, 0, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(093), 0, 0, 0, 0, 7.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(094), 0, 0, 0, 0, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(095), 0, 0, 0, 0, 7.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(096), 0, 0, 0, 0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(097), 0, 0, 0, 0, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(098), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(099), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(100), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(101), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(102), 0, 0, 0, 0, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(103), 0, 0, 0, 0, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(104), 0, 0, 0, 0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(105), 0, 0, 0, 0, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(106), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(107), 0, 0, 0, 0, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(108), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(109), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(110), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(111), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(112), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(113), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(114), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(115), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(116), 0, 0, 0, 0, 6.0);


            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(093), 0, 0, 0, 0, 7.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(094), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(095), 0, 0, 0, 0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(096), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(097), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(098), 0, 0, 0, 0, 4.2);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(099), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(100), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(101), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(102), 0, 0, 0, 0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(103), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(104), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(105), 0, 0, 0, 0, 6.0);  // Month - 2007-11-15
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(106), 0, 0, 0, 0, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(107), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(108), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(109), 0, 0, 0, 0, 7.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(110), 0, 0, 0, 0, 7.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(111), 0, 0, 0, 0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(112), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(113), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(114), 0, 0, 0, 0, 7.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(115), 0, 0, 0, 0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(116), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(117), 0, 0, 0, 0, 5.3);

        }

        public static void AddWeatherData_Pivot_07(IrrigationSystem pIrrigationSystem,
                                WeatherStation pWeatherStation)
        {
            WeatherStation lWeatherStation;
            DateTime lFirstDay = new DateTime(2012, 11, 20);


            lWeatherStation = pWeatherStation;

            // DATOS DEL TIEMPO

            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(0), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1), 0, 0, 0, 0, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2), 0, 0, 0, 0, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(3), 0, 0, 0, 0, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(4), 0, 0, 0, 0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(5), 0, 0, 0, 0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(6), 0, 0, 0, 0, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(7), 0, 0, 0, 0, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(8), 0, 0, 0, 0, 5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(9), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(10), 0, 0, 0, 0, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(11), 0, 0, 0, 0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(12), 0, 0, 0, 0, 7.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(13), 0, 0, 0, 0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(14), 0, 0, 0, 0, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(15), 0, 0, 0, 0, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(16), 0, 0, 0, 0, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(17), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(18), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(19), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(20), 0, 0, 0, 0, 5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(21), 0, 0, 0, 0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(22), 0, 0, 0, 0, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(23), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(24), 0, 0, 0, 0, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(25), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(26), 0, 0, 0, 0, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(27), 0, 0, 0, 0, 6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(28), 0, 0, 0, 0, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(29), 0, 0, 0, 0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(30), 0, 0, 0, 0, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(31), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(32), 0, 0, 0, 0, 7.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(33), 0, 0, 0, 0, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(34), 0, 0, 0, 0, 8.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(35), 0, 0, 0, 0, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(36), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(37), 0, 0, 0, 0, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(38), 0, 0, 0, 0, 6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(39), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(40), 0, 0, 0, 0, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(41), 0, 0, 0, 0, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(42), 0, 0, 0, 0, 6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(43), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(44), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(45), 0, 0, 0, 0, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(46), 0, 0, 0, 0, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(47), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(48), 0, 0, 0, 0, 6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(49), 0, 0, 0, 0, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(50), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(51), 0, 0, 0, 0, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(52), 0, 0, 0, 0, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(53), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(54), 0, 0, 0, 0, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(55), 0, 0, 0, 0, 6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(56), 0, 0, 0, 0, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(57), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(58), 0, 0, 0, 0, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(59), 0, 0, 0, 0, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(60), 0, 0, 0, 0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(61), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(62), 0, 0, 0, 0, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(63), 0, 0, 0, 0, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(64), 0, 0, 0, 0, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(65), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(66), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(67), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(68), 0, 0, 0, 0, 7.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(69), 0, 0, 0, 0, 7.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(70), 0, 0, 0, 0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(71), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(72), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(73), 0, 0, 0, 0, 7.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(74), 0, 0, 0, 0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(75), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(76), 0, 0, 0, 0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(77), 0, 0, 0, 0, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(78), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(79), 0, 0, 0, 0, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(80), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(81), 0, 0, 0, 0, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(82), 0, 0, 0, 0, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(83), 0, 0, 0, 0, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(84), 0, 0, 0, 0, 6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(85), 0, 0, 0, 0, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(86), 0, 0, 0, 0, 4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(87), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(88), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(89), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(90), 0, 0, 0, 0, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(91), 0, 0, 0, 0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(92), 0, 0, 0, 0, 3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(93), 0, 0, 0, 0, 3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(94), 0, 0, 0, 0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(95), 0, 0, 0, 0, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(96), 0, 0, 0, 0, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(97), 0, 0, 0, 0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(98), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(99), 0, 0, 0, 0, 4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(100), 0, 0, 0, 0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(101), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(102), 0, 0, 0, 0, 3.7);

        }

        public static void AddWeatherData_Pivot_08(IrrigationSystem pIrrigationSystem,
                                WeatherStation pWeatherStation)
        {
            WeatherStation lWeatherStation;
            DateTime lFirstDay = new DateTime(2013, 10, 15);


            lWeatherStation = pWeatherStation;

            // DATOS DEL TIEMPO

            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(0), 0, 0, 0, 0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1), 0, 0, 0, 0, 4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2), 0, 0, 0, 0, 3.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(3), 0, 0, 0, 0, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(4), 0, 0, 0, 0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(5), 0, 0, 0, 0, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(6), 0, 0, 0, 0, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(7), 0, 0, 0, 0, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(8), 0, 0, 0, 0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(9), 0, 0, 0, 0, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(10), 0, 0, 0, 0, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(11), 0, 0, 0, 0, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(12), 0, 0, 0, 0, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(13), 0, 0, 0, 0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(14), 0, 0, 0, 0, 5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(15), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(16), 0, 0, 0, 0, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(17), 0, 0, 0, 0, 2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(18), 0, 0, 0, 0, 1.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(19), 0, 0, 0, 0, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(20), 0, 0, 0, 0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(21), 0, 0, 0, 0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(22), 0, 0, 0, 0, 7.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(23), 0, 0, 0, 0, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(24), 0, 0, 0, 0, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(25), 0, 0, 0, 0, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(26), 0, 0, 0, 0, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(27), 0, 0, 0, 0, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(28), 0, 0, 0, 0, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(29), 0, 0, 0, 0, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(30), 0, 0, 0, 0, 8.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(31), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(32), 0, 0, 0, 0, 5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(33), 0, 0, 0, 0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(34), 0, 0, 0, 0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(35), 0, 0, 0, 0, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(36), 0, 0, 0, 0, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(37), 0, 0, 0, 0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(38), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(39), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(40), 0, 0, 0, 0, 7.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(41), 0, 0, 0, 0, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(42), 0, 0, 0, 0, 2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(43), 0, 0, 0, 0, 2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(44), 0, 0, 0, 0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(45), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(46), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(47), 0, 0, 0, 0, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(48), 0, 0, 0, 0, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(49), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(50), 0, 0, 0, 0, 8.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(51), 0, 0, 0, 0, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(52), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(53), 0, 0, 0, 0, 7.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(54), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(55), 0, 0, 0, 0, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(56), 0, 0, 0, 0, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(57), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(58), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(59), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(60), 0, 0, 0, 0, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(61), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(62), 0, 0, 0, 0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(63), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(64), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(65), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(66), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(67), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(68), 0, 0, 0, 0, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(69), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(70), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(71), 0, 0, 0, 0, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(72), 0, 0, 0, 0, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(73), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(74), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(75), 0, 0, 0, 0, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(76), 0, 0, 0, 0, 8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(77), 0, 0, 0, 0, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(78), 0, 0, 0, 0, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(79), 0, 0, 0, 0, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(80), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(81), 0, 0, 0, 0, 7.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(82), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(83), 0, 0, 0, 0, 7.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(84), 0, 0, 0, 0, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(85), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(86), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(87), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(88), 0, 0, 0, 0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(89), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(90), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(91), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(92), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(93), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(94), 0, 0, 0, 0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(95), 0, 0, 0, 0, 5.8);

        }

        public static void AddWeatherData_Pivot_09(IrrigationSystem pIrrigationSystem,
                                WeatherStation pWeatherStation)
        {
            WeatherStation lWeatherStation;
            DateTime lFirstDay = new DateTime(2013, 11, 10);


            lWeatherStation = pWeatherStation;

            // DATOS DEL TIEMPO

            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(0), 0, 0, 0, 0, 3.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(1), 0, 0, 0, 0, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(2), 0, 0, 0, 0, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(3), 0, 0, 0, 0, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(4), 0, 0, 0, 0, 8.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(5), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(6), 0, 0, 0, 0, 5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(7), 0, 0, 0, 0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(8), 0, 0, 0, 0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(9), 0, 0, 0, 0, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(10), 0, 0, 0, 0, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(11), 0, 0, 0, 0, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(12), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(13), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(14), 0, 0, 0, 0, 7.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(15), 0, 0, 0, 0, 3.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(16), 0, 0, 0, 0, 2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(17), 0, 0, 0, 0, 2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(18), 0, 0, 0, 0, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(19), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(20), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(21), 0, 0, 0, 0, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(22), 0, 0, 0, 0, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(23), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(24), 0, 0, 0, 0, 8.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(25), 0, 0, 0, 0, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(26), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(27), 0, 0, 0, 0, 7.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(28), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(29), 0, 0, 0, 0, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(30), 0, 0, 0, 0, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(31), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(32), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(33), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(34), 0, 0, 0, 0, 7.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(35), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(36), 0, 0, 0, 0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(37), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(38), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(39), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(40), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(41), 0, 0, 0, 0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(42), 0, 0, 0, 0, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(43), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(44), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(45), 0, 0, 0, 0, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(46), 0, 0, 0, 0, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(47), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(48), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(49), 0, 0, 0, 0, 6.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(50), 0, 0, 0, 0, 8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(51), 0, 0, 0, 0, 4.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(52), 0, 0, 0, 0, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(53), 0, 0, 0, 0, 3.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(54), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(55), 0, 0, 0, 0, 7.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(56), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(57), 0, 0, 0, 0, 7.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(58), 0, 0, 0, 0, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(59), 0, 0, 0, 0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(60), 0, 0, 0, 0, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(61), 0, 0, 0, 0, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(62), 0, 0, 0, 0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(63), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(64), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(65), 0, 0, 0, 0, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(66), 0, 0, 0, 0, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(67), 0, 0, 0, 0, 7.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(68), 0, 0, 0, 0, 7.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(69), 0, 0, 0, 0, 8.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(70), 0, 0, 0, 0, 7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(71), 0, 0, 0, 0, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(72), 0, 0, 0, 0, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(73), 0, 0, 0, 0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(74), 0, 0, 0, 0, 7.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(75), 0, 0, 0, 0, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(76), 0, 0, 0, 0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(77), 0, 0, 0, 0, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(78), 0, 0, 0, 0, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(79), 0, 0, 0, 0, 2.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(80), 0, 0, 0, 0, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(81), 0, 0, 0, 0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(82), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(83), 0, 0, 0, 0, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(84), 0, 0, 0, 0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(85), 0, 0, 0, 0, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(86), 0, 0, 0, 0, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(87), 0, 0, 0, 0, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(88), 0, 0, 0, 0, 1.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(89), 0, 0, 0, 0, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(90), 0, 0, 0, 0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(91), 0, 0, 0, 0, 2.4);

        }


        public static void AddWeatherData_Pivot_10(IrrigationSystem pIrrigationSystem,
                                WeatherStation pWeatherStation)
        {
            WeatherStation lWeatherStation;
            DateTime lFirstDay = new DateTime(2010, 10, 26);


            lWeatherStation = pWeatherStation;

            // DATOS DEL TIEMPO
        }


        public static void AddWeatherData_Pivot_11(IrrigationSystem pIrrigationSystem,
                                WeatherStation pWeatherStation)
        {
            WeatherStation lWeatherStation;
            DateTime lFirstDay = new DateTime(2010, 10, 26);


            lWeatherStation = pWeatherStation;

            // DATOS DEL TIEMPO
        }


        public static void AddWeatherData_Pivot_12(IrrigationSystem pIrrigationSystem,
                                WeatherStation pWeatherStation)
        {
            WeatherStation lWeatherStation;
            DateTime lFirstDay = new DateTime(2010, 10, 26);


            lWeatherStation = pWeatherStation;

            // DATOS DEL TIEMPO
        }


        public static void AddWeatherData_Pivot_13(IrrigationSystem pIrrigationSystem,
                                WeatherStation pWeatherStation)
        {
            WeatherStation lWeatherStation;
            DateTime lFirstDay = new DateTime(2010, 10, 26);


            lWeatherStation = pWeatherStation;

            // DATOS DEL TIEMPO
        }


        public static void AddWeatherData(IrrigationSystem pIrrigationSystem,
                                WeatherStation pWeatherStation, DateTime pStartDate)
        {
            WeatherStation lWeatherStation;
            DateTime lFirstDay;
            DateTime lLastDay;
            DateTime lNextDay;
            WeatherData lWeatherData;
            double lTemperature;
            double lSolarRadiation;
            double lTemperatureMax;
            double lTemperatureMin;
            double lEvapotranspiration;
            double lEvapotranspirationLast3;
            double lEvapotranspirationLast3Weight;
            double lEvapotranspirationLast2;
            double lEvapotranspirationLast2Weight;
            double lEvapotranspirationLast1;
            double lEvapotranspirationLast1Weight;

            lWeatherStation = pWeatherStation;
            lFirstDay = pStartDate;
            
            // DATOS DEL TIEMPO
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(000), 19.6, 0, 19.6, 19.6, 2.4); //DateTime(2014, 10, 18)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(001), 18.3, 0, 18.3, 18.3, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(002), 15.9, 0, 15.9, 15.9, 4.1); //DateTime(2014, 10, 20)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(003), 16.9, 0, 16.9, 16.9, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(004), 19.5, 0, 19.5, 19.5, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(005), 20.1, 0, 20.1, 20.1, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(006), 19.7, 0, 19.7, 19.7, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(007), 20.1, 0, 20.1, 20.1, 5.0); //DateTime(2014, 10, 25)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(008), 11.7, 0, 11.7, 11.7, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(009), 23.5, 0, 23.5, 23.5, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(010), 20.0, 0, 20.0, 20.0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(011), 15.3, 0, 15.3, 15.3, 1.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(012), 12.5, 0, 12.5, 12.5, 4.5); //DateTime(2014, 10, 30)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(013), 11.3, 0, 11.3, 11.3, 3.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(014), 12.6, 0, 12.6, 12.6, 3.3); //DateTime(2014, 11, 01)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(015), 12.4, 0, 12.4, 12.4, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(016), 14.2, 0, 14.2, 14.2, 2.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(017), 12.9, 0, 12.9, 12.9, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(018), 14.9, 0, 14.9, 14.9, 4.9); //DateTime(2014, 11, 05)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(019), 16.2, 0, 16.2, 16.2, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(020), 17.7, 0, 17.7, 17.7, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(021), 17.0, 0, 17.0, 17.0, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(022), 17.1, 0, 17.1, 17.1, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(023), 19.2, 0, 19.2, 19.2, 4.4); //DateTime(2014, 11, 10)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(024), 19.6, 0, 19.6, 19.6, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(025), 16.1, 0, 16.1, 16.1, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(026), 13.0, 0, 13.0, 13.0, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(027), 15.8, 0, 15.8, 15.8, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(028), 20.9, 0, 20.9, 20.9, 6.5); //DateTime(2014, 11, 15)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(029), 18.3, 0, 18.3, 18.3, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(030), 18.8, 0, 18.8, 18.8, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(031), 21.1, 0, 21.1, 21.1, 6.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(032), 19.4, 0, 19.4, 19.4, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(033), 17.8, 0, 17.8, 17.8, 3.2); //DateTime(2014, 11, 20)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(034), 17.0, 0, 17.0, 17.0, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(035), 17.3, 0, 17.3, 17.3, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(036), 19.6, 0, 19.6, 19.6, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(037), 17.3, 0, 17.3, 17.3, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(038), 17.2, 0, 17.2, 17.2, 5.1); //DateTime(2014, 11, 25)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(039), 15.7, 0, 15.7, 15.7, 3.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(040), 17.9, 0, 17.9, 17.9, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(041), 20.7, 0, 20.7, 20.7, 7.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(042), 24.0, 0, 24.0, 24.0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(043), 19.5, 0, 19.5, 19.5, 2.2); //DateTime(2014, 11, 30)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(044), 18.0, 0, 18.0, 18.0, 2.7); //DateTime(2014, 12, 01)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(045), 18.0, 0, 18.0, 18.0, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(046), 20.2, 0, 20.2, 20.2, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(047), 21.8, 0, 21.8, 21.8, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(048), 22.7, 0, 22.7, 22.7, 7.6); //DateTime(2014, 12, 05)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(049), 24.7, 0, 24.7, 24.7, 7.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(050), 22.7, 0, 22.7, 22.7, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(051), 21.0, 0, 21.0, 21.0, 2.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(052), 24.3, 0, 24.3, 24.3, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(053), 18.8, 0, 18.8, 18.8, 4.9); //DateTime(2014, 12, 10)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(054), 17.6, 0, 17.6, 17.6, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(055), 20.2, 0, 20.2, 20.2, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(056), 21.0, 0, 21.0, 21.0, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(057), 17.5, 0, 17.5, 17.5, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(058), 18.9, 0, 18.9, 18.9, 6.2); //DateTime(2014, 12, 15)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(059), 22.7, 0, 22.7, 22.7, 3.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(060), 22.0, 0, 22.0, 22.0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(061), 23.2, 0, 23.2, 23.2, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(062), 26.3, 0, 26.3, 26.3, 8.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(063), 22.6, 0, 22.6, 22.6, 4.5); //DateTime(2014, 12, 20)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(064), 16.4, 0, 16.4, 16.4, 3.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(065), 16.2, 0, 16.2, 16.2, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(066), 17.0, 0, 17.0, 17.0, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(067), 19.4, 0, 19.4, 19.4, 6.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(068), 24.3, 0, 24.3, 24.3, 6.9); //DateTime(2014, 12, 25)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(069), 25.1, 0, 25.1, 25.1, 3.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(070), 23.3, 0, 23.3, 23.3, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(071), 24.5, 0, 24.5, 24.5, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(072), 25.4, 0, 25.4, 25.4, 6.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(073), 26.6, 0, 26.6, 26.6, 7.2); //DateTime(2014, 12, 30)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(074), 24.6, 0, 24.6, 24.6, 4.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(075), 21.3, 0, 21.3, 21.3, 4.8); //DateTime(2015, 01, 01)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(076), 19.0, 0, 19.0, 19.0, 6.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(077), 20.6, 0, 20.6, 20.6, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(078), 19.2, 0, 19.2, 19.2, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(079), 23.0, 0, 23.0, 23.0, 7.1); //DateTime(2015, 01, 05)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(080), 22.3, 0, 22.3, 22.3, 2.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(081), 25.0, 0, 25.0, 25.0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(082), 25.1, 0, 25.1, 25.1, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(083), 24.7, 0, 24.7, 24.7, 4.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(084), 25.4, 0, 25.4, 25.4, 5.5);//DateTime(2015, 01, 10)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(085), 26.1, 0, 26.1, 26.1, 5.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(086), 27.0, 0, 27.0, 27.0, 7.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(087), 21.3, 0, 21.3, 21.3, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(088), 22.8, 0, 22.8, 22.8, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(089), 22.6, 0, 22.6, 22.6, 5.2);//DateTime(2015, 01, 15)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(090), 24.5, 0, 24.5, 24.5, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(091), 20.9, 0, 20.9, 20.9, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(092), 21.5, 0, 21.5, 21.5, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(093), 20.5, 0, 20.5, 20.5, 2.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(094), 19.1, 0, 19.1, 19.1, 5.0);//DateTime(2015, 01, 20)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(095), 18.4, 0, 18.4, 18.4, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(096), 20.8, 0, 20.8, 20.8, 6.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(097), 23.0, 0, 23.0, 23.0, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(098), 23.9, 0, 23.9, 23.9, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(099), 25.0, 0, 25.0, 25.0, 6.0);//DateTime(2015, 01, 25)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(100), 26.2, 0, 26.2, 26.2, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(101), 28.0, 0, 28.0, 28.0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(102), 20.7, 0, 20.7, 20.7, 2.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(103), 17.7, 0, 17.7, 17.7, 5.5);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(104), 17.8, 0, 17.8, 17.8, 5.2);//DateTime(2015, 01, 30)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(105), 20.4, 0, 20.4, 20.4, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(106), 23.1, 0, 23.1, 23.1, 6.0);//DateTime(2015, 02, 01)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(107), 23.8, 0, 23.8, 23.8, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(108), 23.4, 0, 23.4, 23.4, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(109), 26.2, 0, 26.2, 26.2, 6.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(111), 25.0, 0, 25.0, 25.0, 6.3);//DateTime(2015, 02, 05)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(112), 24.7, 0, 24.7, 24.7, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(113), 23.4, 0, 23.4, 23.4, 5.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(114), 24.2, 0, 24.2, 24.2, 5.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(115), 26.2, 0, 26.2, 26.2, 5.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(116), 22.3, 0, 22.3, 22.3, 4.0);//DateTime(2015, 02, 10)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(117), 22.1, 0, 22.1, 22.1, 5.9);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(118), 24.5, 0, 24.5, 24.5, 6.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(119), 18.9, 0, 18.9, 18.9, 5.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(120), 19.7, 0, 19.7, 19.7, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(121), 21.7, 0, 21.7, 21.7, 6.0);//DateTime(2015, 02, 15)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(122), 23.2, 0, 23.2, 23.2, 6.0);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(123), 24.0, 0, 24.0, 24.0, 6.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(124), 24.2, 0, 24.2, 24.2, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(125), 18.6, 0, 18.6, 18.6, 2.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(126), 19.7, 0, 19.7, 19.7, 4.2);//DateTime(2015, 02, 20)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(127), 22.7, 0, 22.7, 22.7, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(128), 23.8, 0, 23.8, 23.8, 5.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(129), 25.0, 0, 25.0, 25.0, 5.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(130), 27.2, 0, 27.2, 27.2, 5.1);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(131), 23.5, 0, 23.5, 23.5, 3.5);//DateTime(2015, 02, 25)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(132), 24.3, 0, 24.3, 24.3, 4.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(133), 19.5, 0, 19.5, 19.5, 4.3);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(134), 18.5, 0, 18.5, 18.5, 4.7);//DateTime(2015, 02, 28)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(135), 23.2, 0, 23.2, 23.2, 4.5);//DateTime(2015, 03, 01)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(136), 24.4, 0, 24.4, 24.4, 4.8);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(137), 23.9, 0, 23.9, 23.9, 2.4);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(138), 23.1, 0, 23.1, 23.1, 2.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(139), 22.7, 0, 22.7, 22.7, 4.2);//DateTime(2015, 03, 05)
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(140), 21.9, 0, 21.9, 21.9, 4.2);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(141), 23.0, 0, 23.0, 23.0, 4.6);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(142), 23.6, 0, 23.6, 23.6, 4.7);
            pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lFirstDay.AddDays(143), 24.4, 0, 24.4, 24.4, 4.6);

            //TODO: Step 1 Layout WeatherStation Weather Data


            //Last data record
            lWeatherStation = pWeatherStation;
            lLastDay = lWeatherStation.WeatherDataList[lWeatherStation.WeatherDataList.Count - 1].Date;
            lEvapotranspirationLast3Weight = 0.2;
            lEvapotranspirationLast2Weight = 0.3;
            lEvapotranspirationLast1Weight = 0.5;

            for (int i = 0; i < InitialTables.DAYS_FOR_PREDICTION; i++)
            {
                lWeatherData = pIrrigationSystem.GetWeatherDataByWeatherStationAndDate(lWeatherStation, lLastDay);
                lNextDay = lLastDay.AddDays(1);
                lTemperature = lWeatherData.Temperature;
                lSolarRadiation = lWeatherData.SolarRadiation;
                lTemperatureMax = lWeatherData.TemperatureMax;
                lTemperatureMin = lWeatherData.TemperatureMin;

                lEvapotranspirationLast1 = lWeatherData.Evapotranspiration;
                lWeatherData = pIrrigationSystem.GetWeatherDataByWeatherStationAndDate(lWeatherStation, lLastDay.AddDays(-1));
                lEvapotranspirationLast2 = lWeatherData.Evapotranspiration;
                lWeatherData = pIrrigationSystem.GetWeatherDataByWeatherStationAndDate(lWeatherStation, lLastDay.AddDays(-2));
                lEvapotranspirationLast3 = lWeatherData.Evapotranspiration;

                lEvapotranspiration = Math.Round(
                    lEvapotranspirationLast3 * lEvapotranspirationLast3Weight
                    + lEvapotranspirationLast2 * lEvapotranspirationLast2Weight
                    + lEvapotranspirationLast1 * lEvapotranspirationLast1Weight, 2);

                pIrrigationSystem.AddWeatherDataToList(lWeatherStation, lNextDay, lTemperature,
                                                lSolarRadiation, lTemperatureMax, lTemperatureMin,
                                                lEvapotranspiration);
                lLastDay = lLastDay.AddDays(1);

            }

        }

        #endregion

        #endregion

        #region Overrides
        #endregion


    }
}