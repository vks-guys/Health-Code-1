using HealthCode.Bussiness.DataAccess.Constants;
using HealthCode.Bussiness.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HealthCode.Bussiness.DataAccess
{
    public class TestPackageDataAccess
    {
        public static List<TestOrPackage> TestOrPackagesList(DataSet ds)
        {
            List<TestOrPackage> TestOrPackageList = new List<TestOrPackage>();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    TestOrPackage testOrPackage = new TestOrPackage();
                    testOrPackage.Id = Convert.ToInt32(ds.Tables[0].Rows[i][DBFields.Id]);
                    testOrPackage.DeliveryReport = Convert.ToString(ds.Tables[0].Rows[i][DBFields.DeliveryReport]);
                    testOrPackage.TestOrPackageName = Convert.ToString(ds.Tables[0].Rows[i][DBFields.TestOrPackageName]);
                    testOrPackage.TestOrPackageType = Convert.ToInt32(ds.Tables[0].Rows[i][DBFields.TestOrPackageType]);
                    testOrPackage.TestOrPackagePrice = Convert.ToDecimal(ds.Tables[0].Rows[i][DBFields.TestOrPackagePrice]);
                    testOrPackage.Description = Convert.ToString(ds.Tables[0].Rows[i][DBFields.Description]);
                    testOrPackage.SampleRequired = Convert.ToString(ds.Tables[0].Rows[i][DBFields.SampleRequired]);
                    testOrPackage.PreTestInformation = Convert.ToString(ds.Tables[0].Rows[i][DBFields.PreTestInformation]);
                    TestOrPackageList.Add(testOrPackage);
                }
            }

            return TestOrPackageList;
        }

        public static TestOrPackage TestOrPackagesById(DataSet ds)
        {
            TestOrPackage testOrPackage = new TestOrPackage();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    testOrPackage.Id = Convert.ToInt32(ds.Tables[0].Rows[i][DBFields.Id]);
                    testOrPackage.DeliveryReport = Convert.ToString(ds.Tables[0].Rows[i][DBFields.DeliveryReport]);
                    testOrPackage.TestOrPackageName = Convert.ToString(ds.Tables[0].Rows[i][DBFields.TestOrPackageName]);
                    testOrPackage.TestOrPackageType = Convert.ToInt32(ds.Tables[0].Rows[i][DBFields.TestOrPackageType]);
                    testOrPackage.TestOrPackagePrice = Convert.ToDecimal(ds.Tables[0].Rows[i][DBFields.TestOrPackagePrice]);
                    testOrPackage.Description = Convert.ToString(ds.Tables[0].Rows[i][DBFields.Description]);
                    testOrPackage.SampleRequired = Convert.ToString(ds.Tables[0].Rows[i][DBFields.SampleRequired]);
                    testOrPackage.PreTestInformation = Convert.ToString(ds.Tables[0].Rows[i][DBFields.PreTestInformation]);
                }
            }

            return testOrPackage;
        }
        
        public static ServiceResponse TestOrPackagesAddOrUpdate(DataSet ds)
        {
            ServiceResponse serviceResponse = new ServiceResponse();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    serviceResponse.Id = Convert.ToInt32(ds.Tables[0].Rows[i][DBFields.Id]);
                    serviceResponse.IsError = Convert.ToInt32(ds.Tables[0].Rows[i][DBFields.IsError]);
                    serviceResponse.ErrorMessage = Convert.ToString(ds.Tables[0].Rows[i][DBFields.ErrorMessage]);
                }
            }

            return serviceResponse;
        }

        public static ServiceResponse SaveCartItem(DataSet ds)
        {
            ServiceResponse serviceResponse = new ServiceResponse();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    serviceResponse.Id = Convert.ToInt32(ds.Tables[0].Rows[i][DBFields.Id]);
                    serviceResponse.IsError = Convert.ToInt32(ds.Tables[0].Rows[i][DBFields.IsError]);
                    serviceResponse.ErrorMessage = Convert.ToString(ds.Tables[0].Rows[i][DBFields.ErrorMessage]);
                }
            }

            return serviceResponse;
        }

        public static ServiceResponse HomeCollectionDataSave(DataSet ds)
        {
            ServiceResponse serviceResponse = new ServiceResponse();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    serviceResponse.Id = Convert.ToInt32(ds.Tables[0].Rows[i][DBFields.Id]);
                    serviceResponse.IsError = Convert.ToInt32(ds.Tables[0].Rows[i][DBFields.IsError]);
                    serviceResponse.ErrorMessage = Convert.ToString(ds.Tables[0].Rows[i][DBFields.ErrorMessage]);
                }
            }

            return serviceResponse;
        }

        public static List<HomeCollectionData> HomeCollectionDataList(DataSet ds)
        {
            List<HomeCollectionData> list = new List<HomeCollectionData>();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                HomeCollectionData homeCollectionData = null;
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    homeCollectionData = new HomeCollectionData();
                    homeCollectionData.Id = Convert.ToInt32(ds.Tables[0].Rows[i][DBFields.Id]);
                    homeCollectionData.Name = Convert.ToString(ds.Tables[0].Rows[i][DBFields.Name]);
                    homeCollectionData.Email = Convert.ToString(ds.Tables[0].Rows[i][DBFields.Email]);
                    homeCollectionData.PhoneNumber = Convert.ToString(ds.Tables[0].Rows[i][DBFields.PhoneNumber]);
                    homeCollectionData.FileLocation = Convert.ToString(ds.Tables[0].Rows[i][DBFields.FileLocation]);
                    homeCollectionData.SelectPreferredDate = Convert.ToString(ds.Tables[0].Rows[i][DBFields.SelectPreferredDate]);
                    homeCollectionData.SelectPrefferedTime = Convert.ToString(ds.Tables[0].Rows[i][DBFields.SelectPrefferedTime]);
                    list.Add(homeCollectionData);
                }
            }

            return list;
        }

        
        public static List<CartItemUser> BookingList(DataSet ds)
        {
            List<CartItemUser> list = new List<CartItemUser>();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                CartItemUser cartItemUser = null;
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cartItemUser = new CartItemUser();
                    cartItemUser.Id = Convert.ToInt32(ds.Tables[0].Rows[i][DBFields.Id]);
                    cartItemUser.Name = Convert.ToString(ds.Tables[0].Rows[i][DBFields.Name]);
                    cartItemUser.Email = Convert.ToString(ds.Tables[0].Rows[i][DBFields.Email]);
                    cartItemUser.Mobile = Convert.ToString(ds.Tables[0].Rows[i][DBFields.Mobile]);
                    list.Add(cartItemUser);
                }
            }

            return list;
        }
        
        public static List<TestOrPackage> CartTestOrPackageDataById(DataSet ds)
        {
            List<TestOrPackage> TestOrPackageList = new List<TestOrPackage>();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    TestOrPackage testOrPackage = new TestOrPackage();
                    testOrPackage.Id = Convert.ToInt32(ds.Tables[0].Rows[i][DBFields.Id]);
                    testOrPackage.TestOrPackageName = Convert.ToString(ds.Tables[0].Rows[i][DBFields.TestOrPackageName]);
                    testOrPackage.TestOrPackageType = Convert.ToInt32(ds.Tables[0].Rows[i][DBFields.TestOrPackageType]);
                    testOrPackage.TestOrPackagePrice = Convert.ToDecimal(ds.Tables[0].Rows[i][DBFields.TestOrPackagePrice]);
                    TestOrPackageList.Add(testOrPackage);
                }
            }

            return TestOrPackageList;
        }
    }
}