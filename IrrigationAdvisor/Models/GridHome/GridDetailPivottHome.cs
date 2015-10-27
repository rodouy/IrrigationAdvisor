using IrrigationAdvisor.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;


namespace IrrigationAdvisor.Models.GridHome
{

    public class GridPivotDetailHome
    {
        #region Consts
        public CultureInfo culture = new System.Globalization.CultureInfo("Es-Es");
        #endregion

        #region Fields

        /// <summary>
        /// Fields of Class:
        ///     -  string day
        ///     -  string pivotDate
        ///     -  IrrigationAdvisor.Models.Utilities.Utils.WeatherGrid irrigation

        /// </summary>

        private decimal irrigation; // Riego
        private decimal rain; // Lluvia
        private decimal forecastIrrigation;
        private DateTime dateTime;
        private bool isToday;
        private IrrigationAdvisor.Models.Utilities.Utils.IrrigationStatus irrigationStatus;
        #endregion

        #region properties
        public decimal Irrigation
        {
            get { return irrigation; }
            set { irrigation = value; }
        }
        public decimal Rain
        {
            get { return rain; }
            set { rain = value; }
        }
        public decimal ForecastIrrigation
        {
            get { return forecastIrrigation; }
            set { forecastIrrigation = value; }
        }
        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        public string day
        {
            get
            {
                //{ culture.DateTimeFormat.GetDayName(DateTime.DayOfWeek).ToString();

                return dateTime.DayOfWeek.ToString();
            }
        }


        public bool IsToday
        {
            get { return isToday; }
            set { isToday = value; }
        }
        public IrrigationAdvisor.Models.Utilities.Utils.IrrigationStatus IrrigationStatus
        {
            get { return irrigationStatus; }
            set { irrigationStatus = value; }
        }

        #endregion

        public GridPivotDetailHome(decimal pIrrigation, decimal pRain, decimal pForecastIrrigation, DateTime pDateTime, bool pIsToday, IrrigationAdvisor.Models.Utilities.Utils.IrrigationStatus pIrrigationStatus)
        {
            this.Irrigation = pIrrigation;
            this.Rain = pRain;
            this.ForecastIrrigation = pForecastIrrigation;
            this.DateTime = pDateTime;
            this.IsToday = pIsToday;
            this.IrrigationStatus = pIrrigationStatus;
        }
    }
}