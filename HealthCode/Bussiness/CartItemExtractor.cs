using HealthCode.Bussiness.DataAccess.Constants;
using HealthCode.Bussiness.Entity;
using HealthCode.Bussiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthCode.Bussiness
{
    public class CartItemExtractor
    {
        public static List<TestOrPackage> GetCartItem()
        {
            List<TestOrPackage> testOrPackageObj = TestPackageFacade.TestOrPackagesList();

            List<TestOrPackage> obj = new List<TestOrPackage>();

            var cart = HttpContext.Current.Session[SessionContext.Cart];
            if (cart != null)
            {
                List<int> sessionCart = (List<int>)cart;

                foreach (var item in sessionCart)
                {
                    var result = testOrPackageObj.FirstOrDefault(a => a.Id == item);
                    if (result != null)
                    {
                        obj.Add(result);
                    }
                }
            }

            return obj;
        }
    }
}