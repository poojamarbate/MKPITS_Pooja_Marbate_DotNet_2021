using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerControlExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ArrayList fruits, cities;
        decimal[] price = { 45.67m, 67m, 80.50m, 70.0m,85.8m };

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = ListBox1.SelectedItem.ToString();
            Label2.Text = DropDownList1.SelectedItem.ToString();
            Label3.Text += ListBox1.SelectedIndex.ToString();//data accept and fill by user
            Label4.Text += DropDownList1.SelectedIndex.ToString();
            Label5.Text = ListBox1.SelectedValue.ToString();

        }

       
        protected void Page_Load(object sender, EventArgs e)
        {//in memeory datasource
            if (!Page.IsPostBack)//fresh request for page
            {
                fruits = new ArrayList();
                fruits.Add("Apple");
                fruits.Add("Orange");
                fruits.Add("Mango");
                fruits.Add("Grapes");
                fruits.Add("chikoo");
                ListBox1.DataSource = fruits;
                ListBox1.DataBind();
                ListBox1.Items[0].Value = price[0].ToString();
                ListBox1.Items[1].Value = price[1].ToString();
                ListBox1.Items[2].Value = price[2].ToString();
                ListBox1.Items[3].Value = price[3].ToString();

                //for (int i = 0; i < fruits.Count; i++)
                //    ListBox1.Items[i].Value = price[i].ToString();


                cities = new ArrayList();
                cities.Add("Mumbai");
                cities.Add("Nagpur");
                cities.Add("Pune");
                DropDownList1.DataSource = cities;
                Page.DataBind();

            }
        }
    }
}