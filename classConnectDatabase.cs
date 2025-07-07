using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BCSP7C
{
    class classConnectDatabase
    {
        public string strcon = "Data source=DESKTOP-7G48G58; initial catalog=dbBCSP7C; integrated security=True";
        public SqlConnection conn = new SqlConnection();
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public SqlCommand cmd = new SqlCommand();
        public void connectDatabase()
        {
            if(conn.State==ConnectionState.Open)
            {
                conn.Close();
            }
            conn.ConnectionString = strcon;
            conn.Open();
        }
    }
}
