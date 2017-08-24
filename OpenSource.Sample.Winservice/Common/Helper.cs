using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSource.Sample.Winservice.Common
{
    public class Helper
    {
        public static IDbConnection NewAIConnection()
        {
            string connstring = ConfigurationManager.ConnectionStrings["aDB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);

            return conn;
        }
    }
}
