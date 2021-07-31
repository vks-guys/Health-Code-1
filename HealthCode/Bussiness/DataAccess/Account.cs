using HealthCode.Bussiness.DataAccess.Constants;
using HealthCode.Bussiness.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Facade = HealthCode.Bussiness.Facade;

namespace HealthCode.Bussiness.DataAccess
{
    public class Account
    {
        public static ServiceResponse UserLogin(DataSet ds)
        {
            ServiceResponse serviceResponse = new ServiceResponse();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                serviceResponse.IsError = Convert.ToInt32(ds.Tables[0].Rows[0][DBFields.IsError]);
                serviceResponse.Id = Convert.ToInt32(ds.Tables[0].Rows[0][DBFields.Id]);
                serviceResponse.ErrorMessage = Convert.ToString(ds.Tables[0].Rows[0][DBFields.ErrorMessage]);
            }

            return serviceResponse;
        }

        public static ServiceResponse Register(DataSet ds)
        {
            ServiceResponse serviceResponse = new ServiceResponse();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                serviceResponse.IsError = Convert.ToInt32(ds.Tables[0].Rows[0][DBFields.IsError]);
                serviceResponse.Id = Convert.ToInt32(ds.Tables[0].Rows[0][DBFields.Id]);
                serviceResponse.ErrorMessage = Convert.ToString(ds.Tables[0].Rows[0][DBFields.ErrorMessage]);
            }

            return serviceResponse;
        }

        public static List<User> UserList(DataSet ds)
        {
            List<User> listUser = new List<User>();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    User user = new User();
                    user.Id = Convert.ToInt32(ds.Tables[0].Rows[i][DBFields.Id]);
                    user.Mobile = Convert.ToString(ds.Tables[0].Rows[i][DBFields.Mobile]);
                    user.Email = Convert.ToString(ds.Tables[0].Rows[i][DBFields.Email]);
                    listUser.Add(user);
                }
            }

            return listUser;
        }
        
        public static User UserEdit(DataSet ds)
        {
            User user = new User();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    user.Id = Convert.ToInt32(ds.Tables[0].Rows[i][DBFields.Id]);
                    user.Mobile = Convert.ToString(ds.Tables[0].Rows[i][DBFields.Mobile]);
                    user.Email = Convert.ToString(ds.Tables[0].Rows[i][DBFields.Email]);
                }
            }

            return user;
        }
        
        public static ServiceResponse UserUpdate(DataSet ds)
        {
            ServiceResponse serviceResponse = new ServiceResponse();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    serviceResponse.IsError = Convert.ToInt32(ds.Tables[0].Rows[0][DBFields.IsError]);
                    serviceResponse.Id = Convert.ToInt32(ds.Tables[0].Rows[0][DBFields.Id]);
                    serviceResponse.ErrorMessage = Convert.ToString(ds.Tables[0].Rows[0][DBFields.ErrorMessage]);
                }
            }

            return serviceResponse;
        }
    }
}