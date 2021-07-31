using HealthCode.Bussiness.Entity;
using HealthCode.Bussiness.Facade;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using HealthCode.Bussiness.DataAccess.Constants;
using HealthCode.Bussiness;
using HealthCode.Bussiness.XmlGenerator;
using HealthCode.Bussiness.FileStore;

namespace HealthCode.Controllers
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

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult For_patients()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult healthcare_provider()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult corporates_ngo()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult HomeCollection()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult HomeCollection(HomeCollectionData homeCollectionData)
        {
            homeCollectionData.FileLocation = DocumentHandler.Save(homeCollectionData.FormFile);
            ViewBag.Message = "Your contact page.";

            ServiceResponse serviceResponse = TestPackageFacade.HomeCollectionDataSave(homeCollectionData);

            if (serviceResponse != null && serviceResponse.Id > 0)
            {
                //return RedirectToAction("Index", "Home");
                return RedirectToAction("HomeCollectionSuccess", "Home");
            }
            return View();
        }

        public ActionResult HomeCollectionSuccess()
        {
            ViewBag.Message = "Success";

            return View();
        }
        public ActionResult TestOrPackages(string q)
        {
            Session["PackageOrTestCount"] = new Random().Next(1, 10);
            List<TestOrPackage> list = new List<TestOrPackage>();
            if (string.IsNullOrEmpty(q))
            {
                list = TestPackageFacade.TestOrPackagesList();
                ViewBag.SearchText = "";
            }
            else
            {
                //list = TestPackageFacade.TestOrPackagesList().FindAll(a => a.TestOrPackageName.ToLower() == q.ToLower() || a.Description == q.ToLower());
                list = TestPackageFacade.TestOrPackagesList().FindAll(a => a.TestOrPackageName.ToLower().Contains(q.ToLower()) || a.Description.ToLower().Contains(q.ToLower()));
                ViewBag.SearchText = q;
            }

            return View(list);
        }

        public ActionResult AddTestOrPackages()
        {
            Session["PackageOrTestCount"] = new Random().Next(1, 10);
            List<TestOrPackage> list = TestPackageFacade.TestOrPackagesList();
            return Json(list);
        }

        public JsonResult CartItem(int Id)
        {
            CartItem cartItem = new CartItem();

            if (Session[SessionContext.Cart] == null)
            {
                List<int> list = new List<int>();
                list.Add(Id);
                Session[SessionContext.Cart] = list;

                cartItem.Total = list.Count;
            }
            else
            {
                List<int> list = (List<int>)Session[SessionContext.Cart];

                if (list.Contains(Id))
                {
                    cartItem.IsExist = 1;
                    cartItem.Total = list.Count;
                }
                else
                {
                    list.Add(Id);
                    Session[SessionContext.Cart] = list;
                    cartItem.Total = list.Count;
                }
            }

            return Json(cartItem, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CartItemDelete(int Id)
        {
            List<int> list = (List<int>)Session[SessionContext.Cart];
            if (list.Contains(Id))
            {
                list.Remove(Id);
                Session[SessionContext.Cart] = list;
            }

            var obj = CartItemExtractor.GetCartItem();

            return PartialView("_Cart", obj);
        }

        public ActionResult Cart()
        {
            var obj = CartItemExtractor.GetCartItem();

            return View(obj);
        }

        [HttpPost]
        public ActionResult Cart(string Name, string Email, string Mobile, string hdnTestOrPackages)
        {
            CartItemUser cartItemUser = new CartItemUser()
            {
                Name = Name,
                Email = Email,
                Mobile = Mobile,
                XMLCartItem = XmlFile.XmlData(hdnTestOrPackages)
            };

            ServiceResponse serviceResponse = TestPackageFacade.SaveCartItem(cartItemUser);
            if (serviceResponse.Id > 0)
            {
                Session[SessionContext.Cart] = null;
                return RedirectToAction("CartSuccess", new { Id = serviceResponse.Id });
            }
            return View();
        }

        public ActionResult CartSuccess()
        {
            var obj = CartItemExtractor.GetCartItem();

            return View(obj);
        }
    }
}