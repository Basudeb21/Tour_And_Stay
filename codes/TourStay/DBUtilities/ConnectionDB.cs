using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourStay.DBUtilities
{
    internal class ConnectionDB
    {
        private string key = @"Data Source=BLACKHEART21\SQLEXPRESS;Initial Catalog=tour_and_stay_db;Integrated Security=True;";
        public SqlConnection getKey()
        {
            SqlConnection con = new SqlConnection(key);
            return con;
        }

    }
}
