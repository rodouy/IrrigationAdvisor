//using IrrigationAdvisor.Models.GridHome;
using IrrigationAdvisor.Models.Localization;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
#if false
            return View(getGridPivotHome());
#endif
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

#if false
        [ChildActionOnly]
        public PartialViewResult FrontPagePartial()
        {


            return PartialView("_FrontPagePartial", getGridPivotHome());
        }



        private readonly List<GridPivotHome> gridPivotHome = new List<GridPivotHome>();
        public List<GridPivotHome> getGridPivotHome()
        {


            List<GridPivotDetailHome> gridPivotDetailHome2 = new List<GridPivotDetailHome>();

            gridPivotDetailHome2.Add(new GridPivotDetailHome(0, 10, 0, DateTime.Now.AddDays(-3), false, Models.Utilities.Utils.IrrigationStatus.Cyan));
            gridPivotDetailHome2.Add(new GridPivotDetailHome(10, 0, 0, DateTime.Now.AddDays(-2), false, Models.Utilities.Utils.IrrigationStatus.Green));
            gridPivotDetailHome2.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now.AddDays(-1), false, Models.Utilities.Utils.IrrigationStatus.Blue));
            gridPivotDetailHome2.Add(new GridPivotDetailHome(0, 0, 10, DateTime.Now, true, Models.Utilities.Utils.IrrigationStatus.Red));
            gridPivotDetailHome2.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now.AddDays(+1), false, Models.Utilities.Utils.IrrigationStatus.Green));
            gridPivotDetailHome2.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now.AddDays(+2), false, Models.Utilities.Utils.IrrigationStatus.Green));
            gridPivotDetailHome2.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now.AddDays(+2), false, Models.Utilities.Utils.IrrigationStatus.Green));


            List<GridPivotDetailHome> gridPivotDetailHome3 = new List<GridPivotDetailHome>();
        
         
 

            gridPivotHome.Add(new GridPivotHome("Pivot 1", "v0", "Corn", gridPivotDetailHome2));
            
 
            return gridPivotHome;

        }
#endif

    }
}