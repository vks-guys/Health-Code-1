using HealthCode.Bussiness.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HealthCode.Bussiness.Facade;
using HealthCode.CustomHandlers;

namespace HealthCode.Controllers
{
    [CustomAuthorizeAttribute]
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult List()
        {
            List<User> userList = Account.UserList();
            return View(userList);
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
                return RedirectToAction("List", "User");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            User user = Account.UserEdit(Id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            ServiceResponse serviceResponse = Account.UserUpdate(user);
            if(serviceResponse != null && serviceResponse.IsError == 0)
            {
                return RedirectToAction("List");
            }
            return View(user);
        }
    }
}