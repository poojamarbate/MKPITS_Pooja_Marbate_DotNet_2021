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
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand comm;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myDBconnect"].ToString());
            ds = new DataSet();
            da = new SqlDataAdapter("select ID,City_Name from cities", con);
            ds = new DataSet();
            da.Fill(ds);
            ddlcity.DataSource = ds.Tables[0];
            ddlcity.DataTextField = "City_Name";
            ddlcity.DataValueField = "ID";
            Page.DataBind();
        }
    }
}