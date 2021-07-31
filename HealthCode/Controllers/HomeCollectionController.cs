using HealthCode.Bussiness.Entity;
using HealthCode.Bussiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthCode.Controllers
{
    public class HomeCollectionController : Controller
    {
        // GET: HomeCollection
        public ActionResult Index()
        {
            List<HomeCollectionData> list = TestPackageFacade.HomeCollectionDataList();
            return View(list);
        }
    }
}