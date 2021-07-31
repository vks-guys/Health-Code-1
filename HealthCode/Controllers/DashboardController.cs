using HealthCode.CustomHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthCode.Controllers
{
    [CustomAuthorizeAttribute]
    public class DashboardController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}