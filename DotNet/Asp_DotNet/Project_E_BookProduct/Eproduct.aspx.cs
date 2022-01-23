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
    public partial class Eproduct : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand com;
        DataSet ds;
        DataTable dt;
        SqlDataAdapter da;
        public SqlCommandBuilder bld;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myDB_SQLconnect"].ToString());
                ds = new DataSet();
                da = new SqlDataAdapter("select CatID,Catname from E_BookCategory", con);
                ds = new DataSet();
                da.Fill(ds, "Cat");
                DropDownList1.DataSource = ds.Tables["Cat"];
                DropDownList1.DataTextField = "Catname";
                DropDownList1.DataValueField = "CatID";

                Page.DataBind();

                da = new SqlDataAdapter("select * from E_BookProduct ", con);
                da.Fill(ds, "Epro");
                bld = new SqlCommandBuilder(da);

            }
        }

        protected void btnadd_Click(object sender, EventArgs e)

        {
          
          
                //com = new SqlCommand();
                //com.Connection = con;
                //com.CommandText = "insert into E_BookProduct(ID,Bookname,Price,PublishedDate,CatID)values(@ID,@Bookname,@Price,@PublishedDate,@CatID)";
                //SqlParameter p1 = new SqlParameter("@ID", SqlDbType.Int);
                //SqlParameter p2 = new SqlParameter("@Bookname", SqlDbType.VarChar);
                //SqlParameter p3 = new SqlParameter("@Price", SqlDbType.Decimal);
                //SqlParameter p4 = new SqlParameter("@PublishedDate", SqlDbType.Date);
                //SqlParameter p5 = new SqlParameter("@CatID", SqlDbType.Int);
                //p1.Value = TextBox1.Text;
                //p2.Value = TextBox2.Text;
                //p3.Value = Convert.ToDecimal(TextBox3.Text);
                //p4.Value = Convert.ToDateTime(TextBox4.Text);
                //p5.Value = Convert.ToInt32(DropDownList1.SelectedItem.Value);
                //com.Parameters.Add(p1);
                //com.Parameters.Add(p2);
                //com.Parameters.Add(p3);
                //com.Parameters.Add(p4);
                //com.Parameters.Add(p5);
                //com.Connection = con;
                //con.Open();
                //com.ExecuteNonQuery();
                //Lmsg.Text = "Record added successfully";


                try
                {
                    DataTable EproTable = ds.Tables["Epro"];
                    DataRow row = EproTable.NewRow();
                    row["Bookname"] = TextBox2.Text;
                    row["Price"] = TextBox3.Text;
                    row["PublishedDate"] = TextBox4.Text;
                    row["CatID"] = DropDownList1.SelectedItem.Value;
                    EproTable.Rows.Add(row);
                    da.Update(ds, "pro");
                Lmsg.Text = "Record added sucessfully";


                }
                catch (SqlException ex)
                {
                    Lmsg.Text = ex.Message;
                }


            
            }

    
    }
}