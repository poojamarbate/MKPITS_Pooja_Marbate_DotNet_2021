using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;



namespace Three_Tire_Application
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Product p;
        DataSet ds;

        protected void Page_Load(object sender, EventArgs e)
        {
           if(!Page.IsPostBack)
            { 
            p = new Product();
            ds = new DataSet();
            ds = p.GetProduct();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
                // Page.DataBind();
                p = new Product();
                ds = p.GetProducts();
                DropDownList1.Items.Add("Select Name ");
                DropDownList1.DataSource = ds.Tables[0];
                DropDownList1.DataTextField = "Productname";
                DropDownList1.DataValueField = "ID";
                DropDownList1.DataBind();

            }
        }

       
        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.Proname = TextBox1.Text;
                p.ProPrice = Convert.ToDecimal(TextBox2.Text);
                int r = p.AddProduct();
                if (r >= 1)
                    Llbmessage.Text = "Record added Sucessfully";
                else
                    Llbmessage.Text = "Record not added something Bad";
            }
            catch (Exception ex)
            {
                Llbmessage.Text = ex.Message;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex != -1)
                Response.Write("Product selected is" + DropDownList1.SelectedItem.Value);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try { 
            int id = Convert.ToInt32(DropDownList1.SelectedItem.Value.ToString());
            Product p = new Product();
            p.Proname = TextBox1.Text;
            p.ProPrice =Convert.ToDecimal(TextBox2.Text);
                int result = p.UpdateProduct(id);
                if (result >= 1)
                    Llbmessage.Text = "Record updated successfully";
                else
                    Llbmessage.Text = "OH!!! No something Wrong";
             }
            catch(Exception ex)
            {
                Llbmessage.Text = ex.Message;
            }

        }
    }
}