using System;
using System.Configuration;
using System.Data.SqlClient;

namespace BikeStore.WinForm.Models.Database
{
    public class BaseConnection : IDisposable
    {
        public SqlConnection _sqlConnection { get; set; }
        public BaseConnection()
        {
            _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
