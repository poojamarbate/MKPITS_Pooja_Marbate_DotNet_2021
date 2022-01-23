using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
namespace Disconnected_Architecture
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con;//sqlclient
        SqlCommand com;//sqlclient
        SqlDataAdapter da;//sqlclient

        DataTable dt1,dt2;//data namespace
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myDB_SQLconnect"].ToString());
                ds = new DataSet();
                //da = new SqlDataAdapter("select * from person_details;select fname,qualification from teacher  ", con);
                da = new SqlDataAdapter();
                com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "select CustomerName,City,ContactName from person_details ";
                da.SelectCommand = com;
                
                
                
                
                da.Fill(ds);
                dt1 = new DataTable();
                dt1 = ds.Tables[0];
                //GridView1.DataSource = ds.Tables[0];
                GridView1.DataSource = dt1;
               // dt2 = new DataTable();
              //  dt2 = ds.Tables[1];
                //GridView2.DataSource = ds.Tables[1];
               // GridView2.DataSource = dt2;
                Page.DataBind();

            }
            catch(SqlException ex)
            {
                Label2.Text = ex.Message;
            }
         }
    }
}