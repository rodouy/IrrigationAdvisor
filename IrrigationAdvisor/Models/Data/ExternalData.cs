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

        #region a


        public static void AgregarDatosDelTiempo(IrrigationSystem pIrrigationSystem,
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
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(000), 19.6, 0, 19.6, 19.6, 2.4); //DateTime(2014, 10, 18)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(001), 18.3, 0, 18.3, 18.3, 4.8);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(002), 15.9, 0, 15.9, 15.9, 4.1); //DateTime(2014, 10, 20)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(003), 16.9, 0, 16.9, 16.9, 4.8);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(004), 19.5, 0, 19.5, 19.5, 5.5);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(005), 20.1, 0, 20.1, 20.1, 5.0);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(006), 19.7, 0, 19.7, 19.7, 4.6);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(007), 20.1, 0, 20.1, 20.1, 5.0); //DateTime(2014, 10, 25)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(008), 11.7, 0, 11.7, 11.7, 5.5);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(009), 23.5, 0, 23.5, 23.5, 6.5);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(010), 20.0, 0, 20.0, 20.0, 5.5);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(011), 15.3, 0, 15.3, 15.3, 1.9);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(012), 12.5, 0, 12.5, 12.5, 4.5); //DateTime(2014, 10, 30)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(013), 11.3, 0, 11.3, 11.3, 3.3);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(014), 12.6, 0, 12.6, 12.6, 3.3); //DateTime(2014, 11, 01)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(015), 12.4, 0, 12.4, 12.4, 2.9);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(016), 14.2, 0, 14.2, 14.2, 2.1);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(017), 12.9, 0, 12.9, 12.9, 4.8);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(018), 14.9, 0, 14.9, 14.9, 4.9); //DateTime(2014, 11, 05)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(019), 16.2, 0, 16.2, 16.2, 4.8);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(020), 17.7, 0, 17.7, 17.7, 4.6);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(021), 17.0, 0, 17.0, 17.0, 5.5);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(022), 17.1, 0, 17.1, 17.1, 5.3);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(023), 19.2, 0, 19.2, 19.2, 4.4); //DateTime(2014, 11, 10)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(024), 19.6, 0, 19.6, 19.6, 4.8);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(025), 16.1, 0, 16.1, 16.1, 5.0);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(026), 13.0, 0, 13.0, 13.0, 4.7);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(027), 15.8, 0, 15.8, 15.8, 5.5);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(028), 20.9, 0, 20.9, 20.9, 6.5); //DateTime(2014, 11, 15)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(029), 18.3, 0, 18.3, 18.3, 5.7);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(030), 18.8, 0, 18.8, 18.8, 6.5);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(031), 21.1, 0, 21.1, 21.1, 6.5);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(032), 19.4, 0, 19.4, 19.4, 3.7);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(033), 17.8, 0, 17.8, 17.8, 3.2); //DateTime(2014, 11, 20)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(034), 17.0, 0, 17.0, 17.0, 2.6);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(035), 17.3, 0, 17.3, 17.3, 4.4);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(036), 19.6, 0, 19.6, 19.6, 6.2);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(037), 17.3, 0, 17.3, 17.3, 2.3);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(038), 17.2, 0, 17.2, 17.2, 5.1); //DateTime(2014, 11, 25)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(039), 15.7, 0, 15.7, 15.7, 3.9);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(040), 17.9, 0, 17.9, 17.9, 5.3);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(041), 20.7, 0, 20.7, 20.7, 7.0);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(042), 24.0, 0, 24.0, 24.0, 6.2);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(043), 19.5, 0, 19.5, 19.5, 2.2); //DateTime(2014, 11, 30)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(044), 18.0, 0, 18.0, 18.0, 2.7); //DateTime(2014, 12, 01)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(045), 18.0, 0, 18.0, 18.0, 2.3);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(046), 20.2, 0, 20.2, 20.2, 5.9);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(047), 21.8, 0, 21.8, 21.8, 6.3);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(048), 22.7, 0, 22.7, 22.7, 7.6); //DateTime(2014, 12, 05)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(049), 24.7, 0, 24.7, 24.7, 7.3);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(050), 22.7, 0, 22.7, 22.7, 3.6);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(051), 21.0, 0, 21.0, 21.0, 2.5);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(052), 24.3, 0, 24.3, 24.3, 5.2);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(053), 18.8, 0, 18.8, 18.8, 4.9); //DateTime(2014, 12, 10)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(054), 17.6, 0, 17.6, 17.6, 5.4);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(055), 20.2, 0, 20.2, 20.2, 5.2);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(056), 21.0, 0, 21.0, 21.0, 5.4);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(057), 17.5, 0, 17.5, 17.5, 5.8);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(058), 18.9, 0, 18.9, 18.9, 6.2); //DateTime(2014, 12, 15)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(059), 22.7, 0, 22.7, 22.7, 3.7);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(060), 22.0, 0, 22.0, 22.0, 6.0);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(061), 23.2, 0, 23.2, 23.2, 6.9);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(062), 26.3, 0, 26.3, 26.3, 8.6);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(063), 22.6, 0, 22.6, 22.6, 4.5); //DateTime(2014, 12, 20)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(064), 16.4, 0, 16.4, 16.4, 3.6);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(065), 16.2, 0, 16.2, 16.2, 5.3);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(066), 17.0, 0, 17.0, 17.0, 6.0);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(067), 19.4, 0, 19.4, 19.4, 6.8);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(068), 24.3, 0, 24.3, 24.3, 6.9); //DateTime(2014, 12, 25)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(069), 25.1, 0, 25.1, 25.1, 3.8);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(070), 23.3, 0, 23.3, 23.3, 5.2);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(071), 24.5, 0, 24.5, 24.5, 5.8);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(072), 25.4, 0, 25.4, 25.4, 6.9);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(073), 26.6, 0, 26.6, 26.6, 7.2); //DateTime(2014, 12, 30)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(074), 24.6, 0, 24.6, 24.6, 4.5);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(075), 21.3, 0, 21.3, 21.3, 4.8); //DateTime(2015, 01, 01)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(076), 19.0, 0, 19.0, 19.0, 6.3);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(077), 20.6, 0, 20.6, 20.6, 6.2);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(078), 19.2, 0, 19.2, 19.2, 5.7);
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(079), 23.0, 0, 23.0, 23.0, 7.1); //DateTime(2015, 01, 05)
            pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(080), 22.3, 0, 22.3, 22.3, 2.8);
            //pIrrigationSystem.addWeatherDataToList(lWeatherStation, lFirstDay.AddDays(081), 22.3, 0, 22.3, 22.3, 4.8);

            //TODO: Step 1 Layout WeatherStation Weather Data


            //Last data record
            lWeatherStation = pWeatherStation;
            lLastDay = pIrrigationSystem.WeatherDataList[pIrrigationSystem.WeatherDataList.Count - 1].Date;
            lEvapotranspirationLast3Weight = 0.2;
            lEvapotranspirationLast2Weight = 0.3;
            lEvapotranspirationLast1Weight = 0.5;

            for (int i = 0; i < InitialTables.DAYS_FOR_PREDICTION; i++)
            {
                lWeatherData = pIrrigationSystem.getWeatherDataFromList(lWeatherStation, lLastDay);
                lNextDay = lLastDay.AddDays(1);
                lTemperature = lWeatherData.Temperature;
                lSolarRadiation = lWeatherData.SolarRadiation;
                lTemperatureMax = lWeatherData.TemperatureMax;
                lTemperatureMin = lWeatherData.TemperatureMin;

                lEvapotranspirationLast1 = lWeatherData.Evapotranspiration;
                lWeatherData = pIrrigationSystem.getWeatherDataFromList(lWeatherStation, lLastDay.AddDays(-1));
                lEvapotranspirationLast2 = lWeatherData.Evapotranspiration;
                lWeatherData = pIrrigationSystem.getWeatherDataFromList(lWeatherStation, lLastDay.AddDays(-2));
                lEvapotranspirationLast3 = lWeatherData.Evapotranspiration;

                lEvapotranspiration = Math.Round(
                    lEvapotranspirationLast3 * lEvapotranspirationLast3Weight
                    + lEvapotranspirationLast2 * lEvapotranspirationLast2Weight
                    + lEvapotranspirationLast1 * lEvapotranspirationLast1Weight, 2);

                pIrrigationSystem.addWeatherDataToList(lWeatherStation, lNextDay, lTemperature,
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