using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthCode.Bussiness.DataAccess.Constants
{
    public class SessionContext
    {
        public static string IsLoggedInUser { get; set; }
        public static string Cart { get; set; }
    }
}