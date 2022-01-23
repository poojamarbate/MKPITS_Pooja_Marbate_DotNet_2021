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
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand comm;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        public SqlCommandBuilder bld;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            {
                con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myDB_SQLconnect"].ToString());
                ds = new DataSet();
                //da = new SqlDataAdapter("select Catid from Grocery_Product", con);
                //ds = new DataSet();
                //da.Fill(ds,"emp");
               

                //ddlcategory.Items.Add("select category");
                //ddlcategory.DataSource = ds.Tables[0];
                //ddlcategory.DataValueField = "Catid";

                da = new SqlDataAdapter("select * from Grocery_Product ",con);
                da.Fill(ds, "pro");
                bld = new SqlCommandBuilder(da);

                GridView1.DataSource = ds.Tables["pro"];
                GridView1.DataBind();
            }

            

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            // try { 
            // comm = new SqlCommand();
            // comm.Connection = con;
            // da = new SqlDataAdapter("select * from Grocery_Product ",con);

            // comm.CommandText = "insert into Grocery_Product(Productname,Price,mfd)values(@Productname,@Price,@mfd)";
            // SqlParameter p1 = new SqlParameter("@Productname", SqlDbType.VarChar);
            // SqlParameter p2 = new SqlParameter("@Price", SqlDbType.Decimal);
            // SqlParameter p3 = new SqlParameter("@mfd", SqlDbType.Date);
            ////SqlParameter p4 = new SqlParameter("@Catid",SqlDbType.Int);
            // p1.Value = txtproductname.Text;
            // p2.Value = Convert.ToDecimal(txtprice.Text);
            // p3.Value = Convert.ToDateTime(txtmfd.Text);
            // //p4.Value = ddlcategory.SelectedItem.Value;
            // comm.Parameters.Add(p1);
            // comm.Parameters.Add(p2);
            // comm.Parameters.Add(p3);
            ////comm.Parameters.Add(p4);
            //    // da = new SqlDataAdapter();
            //     bld = new SqlCommandBuilder();
            //     da.InsertCommand = comm;
            //     da.InsertCommand.ExecuteNonQuery();
            //     con.Close();

            try
            {
                DataTable proTable = ds.Tables["pro"];
                DataRow row = proTable.NewRow();
                row["Productname"] = txtproductname.Text;
                row["Price"] = txtprice.Text;
                row["mfd"] = txtmfd.Text;
                proTable.Rows.Add(row);
                da.Update(ds, "pro");


            }
            catch(SqlException ex)
            {
                Llbmessage.Text = ex.Message;
            }


              
            }

    }
    }
