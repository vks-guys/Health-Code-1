using HealthCode.Bussiness.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HealthCode.Bussiness.Facade;

namespace HealthCode.Controllers
{
    public class TestOrPackageController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<TestOrPackage> list = TestPackageFacade.TestOrPackagesList();
            return View(list);
        }

        [HttpGet]
        public ActionResult Add()
        {
            TestOrPackage testOrPackage = new TestOrPackage();
            return View(testOrPackage);
        }

        [HttpPost]
        public ActionResult Add(TestOrPackage testOrPackage)
        {
            ServiceResponse serviceResponse = TestPackageFacade.TestOrPackagesAddOrUpdate(testOrPackage);

            if (serviceResponse != null && serviceResponse.IsError > 0)
            {
                return RedirectToAction("Index");
            }
            return View(testOrPackage);
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            TestOrPackage testOrPackageObj = TestPackageFacade.TestOrPackagesById(Id);
            return View(testOrPackageObj);
        }

        [HttpPost]
        public ActionResult Edit(TestOrPackage testOrPackage)
        {
            ServiceResponse serviceResponse = TestPackageFacade.TestOrPackagesAddOrUpdate(testOrPackage);
            
            if(serviceResponse != null && serviceResponse.IsError > 0)
            {
                return RedirectToAction("Index");
            }
            return View(testOrPackage);
        }
    }
}