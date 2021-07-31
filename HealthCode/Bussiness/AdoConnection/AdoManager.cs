using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HealthCode.Bussiness.AdoConnection
{
    public class AdoManager
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["HealthCodeConnectionString"].ConnectionString;
        public DataSet DataSet { get; set; }
        public SqlCommand SqlCommand { get; set; }
        public AdoManager(string StoredProceduresName)
        {

            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["HealthCodeConnectionString"].ConnectionString;
                this.SqlCommand = new SqlCommand(StoredProceduresName, new SqlConnection(ConnectionString))
                {
                    CommandType = CommandType.StoredProcedure
                };

                this.SqlCommand.Connection.Open();
                this.DataSet = new DataSet();
            }
            catch (Exception ex)
            {
                
            }

        }
        public DataSet Result()
        {
            try
            {
                SqlDataAdapter da;

                da = new SqlDataAdapter(this.SqlCommand);
                da.Fill(this.DataSet);
            }
            catch (Exception ex)
            {
                this.SqlCommand.Connection.Close();
            }
            finally
            {
                this.SqlCommand.Connection.Close();
            }
            
            return this.DataSet;
        }
    }
}