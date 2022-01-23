using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;


namespace Three_Tire_Application
{
    public class Myconnection
    {
        public SqlConnection con;
        public Myconnection()
        {
            con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myDB_SQLconnect"].ToString());
   
        }
        public SqlConnection GetConnection()
        {
            return con;
        }
    }
}