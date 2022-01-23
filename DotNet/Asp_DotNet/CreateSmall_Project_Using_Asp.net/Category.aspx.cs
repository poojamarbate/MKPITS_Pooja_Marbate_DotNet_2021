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
    public partial class Category : System.Web.UI.Page
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
               // GridView1.DataSource = ds.Tables["cat"];
                Page.DataBind();
                
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    DataTable catTable = ds.Tables["cat"];
            //    DataRow row = catTable.NewRow();
            //    row["CarID"] = TextBox1.Text;
            //    row["Carname"] = TextBox2.Text;
            //    //["mfd"] = txtmfd.Text;
            //    catTable.Rows.Add(row);
            //    da.Update(ds, "cat");
            //    Llbmessage.Text = "Record added successfully......";


            //}
            //catch (SqlException ex)
            //{
            //    Llbmessage.Text = ex.Message;
            //}
            try
            {
                comm = new SqlCommand();
                comm.Connection = con;
                comm.CommandText = "insert into Shop_Category(CatID,Catname)values(@CatID,@Catname)";
                SqlParameter p1 = new SqlParameter("@CatID", SqlDbType.Int);
                SqlParameter p2 = new SqlParameter("@Catname", SqlDbType.VarChar);
                p1.Value = TextBox1.Text;
                p2.Value = TextBox2.Text;
                comm.Parameters.Add(p1);
                comm.Parameters.Add(p2);
                con.Open();
                comm.ExecuteNonQuery();
                Llbmessage.Text = "Record added successfully";
            }
            catch (SqlException ex)
            {
                Llbmessage.Text = ex.Message;
            }


        }
        }
}