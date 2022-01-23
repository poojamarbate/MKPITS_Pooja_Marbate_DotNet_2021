using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
namespace Project_E_BookProduct
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand com;
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
            // {
            //     com = new sqlcommand();
            //   com.connection = con;
            //     com.commandtext = "insert into e_bookcategory(catid,catname)values(@catid,@catname)";
            //     sqlparameter p1 = new sqlparameter("@catid", sqldbtype.int);
            //    sqlparameter p2 = new sqlparameter("@catname", sqldbtype.varchar);
            //    p1.value = textbox1.text;
            //   p2.value = textbox2.text;
            //    com.parameters.add(p1);
            // com.parameters.add(p2);
            //     con.open();
            ////    com.executenonquery();
            ////    llbmessage.text = "record added successfully";
            ////}
            ////catch (sqlexception ex)
            ////{
            ////    llbmessage.text = ex.message;
            ////}
            try
            {
                com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "insert into E_BookCategory(CatID,Catname)values(@CatID,@Catname)";
                SqlParameter p1 = new SqlParameter("@CatID", SqlDbType.Int);
                SqlParameter p2 = new SqlParameter("@Catname", SqlDbType.VarChar);
                p1.Value = TextBox1.Text;
                p2.Value = TextBox2.Text;
               

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                con.Open();
                com.ExecuteNonQuery();
                Llbmessage.Text = "Record added successfully";

            }
            catch (SqlException ex)
            {
                Llbmessage.Text = ex.Message;
            }

        }

      
    }
}