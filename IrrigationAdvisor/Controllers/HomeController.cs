using IrrigationAdvisor.DBContext;
using IrrigationAdvisor.Models.GridHome;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Management;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace IrrigationAdvisor.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(getGridPivotHome());
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddIrrigation(string irrigation, string pivot)
        {


            return Json("Finished");
        }

        [ChildActionOnly]
        public PartialViewResult FrontPagePartial()
        {
            return PartialView("_FrontPagePartial", getGridPivotHome());
        }
        [ChildActionOnly]
        public PartialViewResult WeatherPartial()
        {
            return PartialView("_WeatherPartial", getWeather());
        }

        private readonly List<GridPivotHome> gridPivotHome = new List<GridPivotHome>();
        public List<GridPivotHome> getGridPivotHome()
        {
            List<GridPivotDetailHome> gridPivotDetailHome2 = new List<GridPivotDetailHome>();
            List<GridPivotDetailHome> gridPivotDetailHome1 = new List<GridPivotDetailHome>();

            gridPivotDetailHome2.Add(new GridPivotDetailHome(0, 10, 0, DateTime.Now.AddDays(-3), false, Models.Utilities.Utils.IrrigationStatus.Cyan));
            gridPivotDetailHome2.Add(new GridPivotDetailHome(10, 0, 0, DateTime.Now.AddDays(-2), false, Models.Utilities.Utils.IrrigationStatus.Green));
            gridPivotDetailHome2.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now.AddDays(-1), false, Models.Utilities.Utils.IrrigationStatus.Blue));
            gridPivotDetailHome2.Add(new GridPivotDetailHome(0, 0, 10, DateTime.Now, true, Models.Utilities.Utils.IrrigationStatus.Red));
            gridPivotDetailHome2.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now.AddDays(+1), false, Models.Utilities.Utils.IrrigationStatus.Green));
            gridPivotDetailHome2.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now.AddDays(+2), false, Models.Utilities.Utils.IrrigationStatus.Green));
            gridPivotDetailHome2.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now.AddDays(+2), false, Models.Utilities.Utils.IrrigationStatus.Green));


            gridPivotDetailHome1.Add(new GridPivotDetailHome(0, 0, 10, DateTime.Now.AddDays(-3), false, Models.Utilities.Utils.IrrigationStatus.Cyan));
            gridPivotDetailHome1.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now.AddDays(-2), false, Models.Utilities.Utils.IrrigationStatus.Green));
            gridPivotDetailHome1.Add(new GridPivotDetailHome(0, 5, 0, DateTime.Now.AddDays(-1), false, Models.Utilities.Utils.IrrigationStatus.Blue));
            gridPivotDetailHome1.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now, true, Models.Utilities.Utils.IrrigationStatus.Red));
            gridPivotDetailHome1.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now.AddDays(+1), false, Models.Utilities.Utils.IrrigationStatus.Green));
            gridPivotDetailHome1.Add(new GridPivotDetailHome(10, 0, 0, DateTime.Now.AddDays(+2), false, Models.Utilities.Utils.IrrigationStatus.Green));
            gridPivotDetailHome1.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now.AddDays(+2), false, Models.Utilities.Utils.IrrigationStatus.Green));


           
            gridPivotHome.Add(new GridPivotHome("Pivot 1", "v0", "Maiz", gridPivotDetailHome2));
            //gridPivotHome.Add(new GridPivotHome("Pivot 2", "v2", "Soja", gridPivotDetailHome1));

            return gridPivotHome;

        }

        public List<IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.GridWeather> getWeather()
        {

            List<IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.GridWeather> GridWeatherList = new List<IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.GridWeather>();

            String high = string.Empty;
            String low = string.Empty;
            String weekday = string.Empty;
            String month = string.Empty;
            String urlImage = string.Empty;
            String description = string.Empty;
            String probabilityRain = string.Empty;
            String mmRain = string.Empty;


            // TODO Replace Url To web Config Diego E.
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://api.wunderground.com/api/ac6d819f785ccfa5/forecast10day/lang:SP/q/-34.8172490,-56.1590040.json");
            httpWebRequest.Method = WebRequestMethods.Http.Get;
            httpWebRequest.Accept = "application/json";
            var response = (HttpWebResponse)httpWebRequest.GetResponse();

            string json = string.Empty;
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                json = sr.ReadToEnd();
            }

            // Json To C#  DeserializeJsno to IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.RootObject
            IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.RootObject jsonObj = JsonConvert.DeserializeObject<IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.RootObject>(json);

            // Iterate ForecastDay
            foreach (var item in jsonObj.forecast.simpleforecast.forecastday)
            {
                if (GridWeatherList.Count <= 6)
                {
                    high = item.high.celsius;
                    low = item.low.celsius;
                    month = item.date.month.ToString();
                    weekday = item.date.weekday;
                    urlImage = "//icons.wxug.com/i/c/v4/" + item.icon + ".svg";
                    description = item.conditions;
                    probabilityRain = item.pop.ToString();
                    mmRain = item.qpf_allday.mm.ToString();
                    GridWeatherList.Add(new IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.GridWeather(high, low, weekday, month, urlImage, description, probabilityRain, mmRain));
                }
            }

        
         
            return GridWeatherList;
        }
 
        public PartialViewResult AddIrrigation()
        {

            IrrigationSystem testIrrigationSystem;
            testIrrigationSystem = IrrigationSystem.Instance;
            
            testIrrigationSystem.IrrigationUnitList = new List<IrrigationUnit>();
            testIrrigationSystem.IrrigationUnitList.Add(new IrrigationUnit(1, "Pivot 1", "", 1, null, 1, null, null, null));
            testIrrigationSystem.IrrigationUnitList.Add(new IrrigationUnit(1, "Pivot 2", "", 1, null, 1, null, null, null));
            testIrrigationSystem.IrrigationUnitList.Add(new IrrigationUnit(1, "Pivot 3", "", 1, null, 1, null, null, null));
            testIrrigationSystem.IrrigationUnitList.Add(new IrrigationUnit(1, "Pivot 4", "", 1, null, 1, null, null, null));
            testIrrigationSystem.IrrigationUnitList.Add(new IrrigationUnit(1, "Pivot 5", "", 1, null, 1, null, null, null));
 
            IrrigationAdvisorContext var = new IrrigationAdvisorContext();
            //var.Farms.Where(q => q.Name == "Santa Lucia").First().IrrigationUnitList
            // var x =  var.Stages.Add(new Models.Agriculture.Stage(1,"Prueba", "desc"));

            return PartialView("_AddIrrigation", testIrrigationSystem.IrrigationUnitList);
        }

    }
}