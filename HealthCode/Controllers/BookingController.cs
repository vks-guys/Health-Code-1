using HealthCode.Bussiness.Entity;
using HealthCode.Bussiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthCode.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Index()
        {
            List<CartItemUser> list = TestPackageFacade.BookingList();
            return View(list);
        }

        public ActionResult CartTestOrPackageData(int Id)
        {
            List<TestOrPackage> list = TestPackageFacade.CartTestOrPackageDataById(Id);
            
            return PartialView("_CartTestOrPackageDataResult", list);
        }
    }
}