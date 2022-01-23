using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace CreateSmall_Project_Using_Asp.net
{
    public partial class Product : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand comm;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myDB_SQLconnect"].ToString());
            ds = new DataSet();
            // GridView1.DataSource = ds.Tables["cat"];
            Page.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                comm = new SqlCommand();
                comm.Connection = con;
                comm.CommandText = "insert into Shop_product(ProductID,Productname,Price,MDF)values(@ProductID,@Productname,@Price,@MDF)";
                SqlParameter p1 = new SqlParameter("@ProductID", SqlDbType.Int);
                SqlParameter p2 = new SqlParameter("@Productname", SqlDbType.VarChar);
                SqlParameter p3 = new SqlParameter("@Price", SqlDbType.Decimal);
                SqlParameter p4 = new SqlParameter("@MDF", SqlDbType.Date);
               // SqlParameter p5 = new SqlParameter("CatID", SqlDbType.Int);
                p1.Value = TextBox1.Text;
                p2.Value = TextBox2.Text;
                p3.Value = TextBox3.Text;
                p4.Value = TextBox4.Text;
               // p5.Value=DropDownList1.SelectedItem.Value.
                comm.Parameters.Add(p1);
                comm.Parameters.Add(p2);
                comm.Parameters.Add(p3);
                comm.Parameters.Add(p4);
                //comm.Parameters.Add(p2);
                con.Open();
                comm.ExecuteNonQuery();
                Llbmsg.Text = "Record added successfully";
               
            }
            catch (SqlException ex)
            {
                Llbmsg.Text = ex.Message;
            }


        }
    }
    }
