using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using HealthCode.Bussiness.Entity;
using DataAccess = HealthCode.Bussiness.DataAccess;
using HealthCode.Bussiness.AdoConnection;
using HealthCode.Bussiness.DataAccess.Constants;

namespace HealthCode.Bussiness.Facade
{
    public class Account
    {
        public static ServiceResponse UserLogin(string UserName, string Password)
        {

            AdoManager adoManager = new AdoManager(StoredProceduresConstant.GetUserLogin);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.UserName, UserName);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Password, Password);

            return DataAccess.Account.UserLogin(adoManager.Result());
        }

        public static ServiceResponse Register(User user)
        {
            AdoManager adoManager = new AdoManager(StoredProceduresConstant.AddUserRegister);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Email, user.Email);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Mobile, user.Mobile);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Password, user.Password);

            return DataAccess.Account.Register(adoManager.Result());
        }

        public static List<User> UserList()
        {
            AdoManager adoManager = new AdoManager(StoredProceduresConstant.UserList);
            return DataAccess.Account.UserList(adoManager.Result());
        }

        public static User UserEdit(int Id)
        {
            AdoManager adoManager = new AdoManager(StoredProceduresConstant.UserEdit);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Id, Id);
            return DataAccess.Account.UserEdit(adoManager.Result());
        }

        public static ServiceResponse UserUpdate(User user)
        {
            AdoManager adoManager = new AdoManager(StoredProceduresConstant.UserUpdate);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Id, user.Id);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Email, user.Email);
            adoManager.SqlCommand.Parameters.AddWithValue(DBParameterConstant.Mobile, user.Mobile);
            return DataAccess.Account.UserUpdate(adoManager.Result());
        }
    }
}