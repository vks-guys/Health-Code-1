using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HealthCode.Bussiness.DataAccess.Constants;
using HealthCode.Bussiness.Entity;
using HealthCode.Bussiness.Facade;

namespace HealthCode.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string UserName, string Password)
        {
            ServiceResponse serviceResponse = Account.UserLogin(UserName, Password);
            if(serviceResponse != null && serviceResponse.IsError == 0 && serviceResponse.Id > 0)
            {
                Session[SessionContext.IsLoggedInUser] = serviceResponse.Id;
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                ViewBag.Message = "Please enter valid user name or password!";
            }
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            ServiceResponse serviceResponse = Account.Register(user);
            if (serviceResponse != null && serviceResponse.IsError == 200 && serviceResponse.Id > 0)
            {
                return RedirectToAction("Index", "Admin");
            }
            return View();
        }

        [HttpGet]
        public ActionResult LogOut()
        {
            Session[SessionContext.IsLoggedInUser] = null;
            Session.Clear();
            Session.RemoveAll();
            return RedirectToAction("Index");
        }
    }
}