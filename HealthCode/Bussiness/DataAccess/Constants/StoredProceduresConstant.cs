using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthCode.Bussiness.DataAccess.Constants
{
    public class StoredProceduresConstant
    {
        public static string GetUserLogin = "proc_GetUserLogin";
        public static string AddUserRegister = "proc_AddUserRegister";
        public static string UserList = "proc_UserList";
        public static string UserEdit = "proc_UserEdit";
        public static string UserUpdate = "proc_UserUpdate";

        public static string TestOrPackageListOrGetById = "proc_TestOrPackageListOrGetById";
        public static string TestOrPackagesAddOrUpdate = "proc_TestOrPackagesAddOrUpdate";
        public static string SaveCartItem = "proc_SaveCartItem";
        public static string HomeCollectionDataSave = "proc_HomeCollectionDataSave";
        public static string HomeCollectionDataList = "proc_HomeCollectionDataList";
        public static string BookingList = "proc_BookingList";
        public static string CartTestOrPackageDataById = "proc_CartTestOrPackageDataById";
    }
}