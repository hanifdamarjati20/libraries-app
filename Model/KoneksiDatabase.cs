using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PerpusDong.Model
{
    class KoneksiDatabase
    {
        private static SqlConnection sqlConn;

        public static SqlConnection GetConnection()
        {
            sqlConn = new SqlConnection();
            sqlConn.ConnectionString = "Data Source=LAPTOP-D5G491CL\\SQLEXPRESS;" +
                                        "Initial Catalog=db_perpus_fix; " +
                                        "Integrated Security=true";
            return sqlConn;
        }


    }
}
