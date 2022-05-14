using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADO_MVC.Models
{
    public class DbConfig
    {
        public SqlConnection sql { get; }
        public DbConfig()
        {
            string Asu = ConfigurationManager.ConnectionStrings
                ["conn"].ConnectionString;
            sql = new SqlConnection(Asu);
        }
    }
}