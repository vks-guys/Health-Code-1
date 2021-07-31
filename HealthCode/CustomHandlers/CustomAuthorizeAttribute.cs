using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using HealthCode.Bussiness.DataAccess.Constants;

namespace HealthCode.CustomHandlers
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            var IsLoggedInUser = HttpContext.Current.Session[SessionContext.IsLoggedInUser];

            if(IsLoggedInUser == null)
            {
                var routeValues = new RouteValueDictionary(new
                {
                    controller = "Admin",
                    action = "Index"
                });
                filterContext.Result = new RedirectToRouteResult(routeValues);
            }
        }
    }
}