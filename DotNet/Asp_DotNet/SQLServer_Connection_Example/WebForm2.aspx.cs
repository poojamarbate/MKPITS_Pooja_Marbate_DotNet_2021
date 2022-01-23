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
    public partial class WebForm2 : System.Web.UI.Page
    {
        public SqlConnection con;
        public SqlCommand com;
        public SqlDataReader dr;
        public DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            //step1 connection with db

            con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myDB_SQL"].ToString());
            //step 2 command object ,associate with connection
            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "select Employee_ID,Employee_First_Name,Branch,City From Employee";
            //step3 open connection and execute query
            con.Open();
            dr = com.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);


            con.Close();
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "insert into employee(Employee_First_Name,Branch,City)values(@Employee_First_Name,@Branch,@City)";
            //step3 open connection and execute query
            SqlParameter p1 = new SqlParameter("@Employee_First_Name", SqlDbType.VarChar);
            SqlParameter p2 = new SqlParameter("@Branch", SqlDbType.VarChar);
            SqlParameter p3 = new SqlParameter("@City", SqlDbType.VarChar);
            p1.Value = TextBox1.Text;
            p2.Value = TextBox2.Text;
            p3.Value = TextBox3.Text;

            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "update employee set Employee_First_Name=@Employee_First_Name,Branch=@Branch,City=@City where Employee_ID=@id";
            SqlParameter p1 = new SqlParameter("@Employee_First_Name", SqlDbType.VarChar);
            SqlParameter p2 = new SqlParameter("@Branch", SqlDbType.VarChar);
            SqlParameter p3 = new SqlParameter("@City", SqlDbType.VarChar);
            SqlParameter p4 = new SqlParameter("@id", SqlDbType.Int);
            p1.Value = TextBox1.Text;
            p2.Value = TextBox2.Text;
            p3.Value = TextBox3.Text;
            p4.Value = TextBox4.Text;
            

            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);
            com.Parameters.Add(p4);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
}