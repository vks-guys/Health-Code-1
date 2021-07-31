using HealthCode.Bussiness.AdoConnection;
using HealthCode.Bussiness.DataAccess.Constants;
using HealthCode.Bussiness.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthCode.Bussiness.Facade
{
    public class TestPackageFacade
    {
        public static List<TestOrPackage> TestOrPackagesList()
        {
            AdoManager adoManager = new AdoManager(StoredProceduresConstant.TestOrPackageListOrGetById);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Id, 0);
            return DataAccess.TestPackageDataAccess.TestOrPackagesList(adoManager.Result());
        }

        public static TestOrPackage TestOrPackagesById(int Id)
        {
            AdoManager adoManager = new AdoManager(StoredProceduresConstant.TestOrPackageListOrGetById);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Id, Id);
            return DataAccess.TestPackageDataAccess.TestOrPackagesById(adoManager.Result());
        }
        
        public static ServiceResponse TestOrPackagesAddOrUpdate(TestOrPackage testOrPackage)
        {
            AdoManager adoManager = new AdoManager(StoredProceduresConstant.TestOrPackagesAddOrUpdate);

            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Id, testOrPackage.Id);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.TestOrPackageName, testOrPackage.TestOrPackageName);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.TestOrPackageType, testOrPackage.TestOrPackageType);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.TestOrPackagePrice, testOrPackage.TestOrPackagePrice);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.PreTestInformation, testOrPackage.PreTestInformation);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.DeliveryReport, testOrPackage.DeliveryReport);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Description, testOrPackage.Description);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.SampleRequired, testOrPackage.SampleRequired);

            return DataAccess.TestPackageDataAccess.TestOrPackagesAddOrUpdate(adoManager.Result());
        }

        public static ServiceResponse SaveCartItem(CartItemUser cartItemUser)
        {

            AdoManager adoManager = new AdoManager(StoredProceduresConstant.SaveCartItem);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Name, cartItemUser.Name);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Email, cartItemUser.Email);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Mobile, cartItemUser.Mobile);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.XMLCartItem, cartItemUser.XMLCartItem);
            return DataAccess.TestPackageDataAccess.SaveCartItem(adoManager.Result());
        }

        public static ServiceResponse HomeCollectionDataSave(HomeCollectionData homeCollectionData)
        {
            AdoManager adoManager = new AdoManager(StoredProceduresConstant.HomeCollectionDataSave);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Name, homeCollectionData.Name);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Email, homeCollectionData.Email);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.HouseNo, homeCollectionData.HouseNo);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Floor, homeCollectionData.Floor);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Coloni, homeCollectionData.Coloni);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Landmark, homeCollectionData.Landmark);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Country, homeCollectionData.Country);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.PhoneNumber, homeCollectionData.PhoneNumber);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.SelectPreferredDate, homeCollectionData.SelectPreferredDate);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.SelectPrefferedTime, homeCollectionData.SelectPrefferedTime);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Message, homeCollectionData.Message);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.FileLocation, homeCollectionData.FileLocation);
            return DataAccess.TestPackageDataAccess.HomeCollectionDataSave(adoManager.Result());
        }

        public static List<HomeCollectionData> HomeCollectionDataList()
        {
            AdoManager adoManager = new AdoManager(StoredProceduresConstant.HomeCollectionDataList);
            return DataAccess.TestPackageDataAccess.HomeCollectionDataList(adoManager.Result());
        }

        public static List<CartItemUser> BookingList()
        {
            AdoManager adoManager = new AdoManager(StoredProceduresConstant.BookingList);
            return DataAccess.TestPackageDataAccess.BookingList(adoManager.Result());
        }

        
        public static List<TestOrPackage> CartTestOrPackageDataById(int Id)
        {
            AdoManager adoManager = new AdoManager(StoredProceduresConstant.CartTestOrPackageDataById);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Id, Id);
            return DataAccess.TestPackageDataAccess.CartTestOrPackageDataById(adoManager.Result());
        }
    }
}