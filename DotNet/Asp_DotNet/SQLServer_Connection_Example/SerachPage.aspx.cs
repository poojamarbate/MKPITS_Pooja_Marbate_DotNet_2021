using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace SQLServer_Connection_Example
{
    public partial class SerachPage : System.Web.UI.Page
    {
        public SqlConnection con;
        public SqlCommand com;
        public SqlDataReader dr;
        public DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myDB_SQL"].ToString());
            //step 2 command object ,associate with connection
            com = new SqlCommand();
            com.Connection = con;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "select Employee_First_Name,City ,Branch from employee where Employee_ID=@Id";
            SqlParameter p1 = new SqlParameter("@Id", SqlDbType.Int);
            p1.Value = Convert.ToInt32(TextBox1.Text);
            com.Parameters.Add(p1);
            con.Open();
            dr = com.ExecuteReader();
            while(dr.Read())
            {
                TextBox2.Text = dr[0].ToString();
                TextBox3.Text = dr[1].ToString();
                TextBox4.Text = dr[2].ToString();
            }
            con.Close();
        }
    }
}