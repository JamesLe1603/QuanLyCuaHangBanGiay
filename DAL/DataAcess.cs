using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAcess
    {
        public static SqlConnection GetConnection()
        {
            string conn;
            conn = "Data Source=.;Initial Catalog=BanGiay;Integrated Security=True";
            SqlConnection SqlConn = new SqlConnection(conn);
            return SqlConn;
        }
       
    }
}
