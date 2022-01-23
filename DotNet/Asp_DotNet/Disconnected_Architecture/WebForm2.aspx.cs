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
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con;//sqlclient
        SqlCommand com;//sqlclient
        SqlDataAdapter da;//sqlclient

        DataTable dt1, dt2;//data namespace
        DataSet ds;

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "insert into Grocery_Product(Productname,Price,mfd,Catid,)values(@Productname,@Price,@mfd,@Catid)";
                SqlParameter p1 = new SqlParameter("@Productname", SqlDbType.VarChar);
                SqlParameter p2 = new SqlParameter("@Price", SqlDbType.Decimal);
                SqlParameter p3 = new SqlParameter("@mfd", SqlDbType.Date);
                SqlParameter p4 = new SqlParameter("@Catid", SqlDbType.Int);
                p1.Value = TextproductName.Text;
                p2.Value = Convert.ToDecimal(Textprice.Text);
                p3.Value = Convert.ToDateTime(txtMFD.Text);
                p4.Value = ddlcategory.SelectedItem.Value;
                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                con.Open();
                com.ExecuteNonQuery();
                //llbmeesage.text="recoded added succfully"
                Llbmessage.Text = "Record Added Successfully";
            }
            catch (SqlException ex)
            {
                Llbmessage.Text = ex.Message;
            }
            con.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myDB_SQLconnect"].ToString());
            ds = new DataSet();
            da = new SqlDataAdapter("select CatID,Catname from Grocery_Category", con);
            ds = new DataSet();
            da.Fill(ds);
            ddlcategory.DataSource = ds.Tables[0];
            ddlcategory.DataTextField = "Catname";
            ddlcategory.DataValueField = "CatID";
            Page.DataBind();
        
        }
    }
}