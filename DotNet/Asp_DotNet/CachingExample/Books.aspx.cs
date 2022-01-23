using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CachingExample
{
    public partial class Books : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Qstr = Request.QueryString["Category"].ToString();


            if (Qstr.Equals("Cooking") == true)
            {
                CheckBoxList1.Items.Add("Theory Of Cookery");
                CheckBoxList1.Items.Add("Tasting India");
                CheckBoxList1.Items.Add("Camellia Panjabi");
                CheckBoxList1.Items.Add("Made in India");
                CheckBoxList1.Items.Add("Indian Kitchen");

            }
            if (Qstr.Equals("Art") == true)
            {
                CheckBoxList1.Items.Add("The Ultimate Craft Book For Kids");
                CheckBoxList1.Items.Add("My First Craft Book ");
                CheckBoxList1.Items.Add("I am never Bored");
                CheckBoxList1.Items.Add("How to Survive the School Holidays");
                CheckBoxList1.Items.Add("Creative World Of Paper Folding");

            }
            if (Qstr.Equals("Puzzles") == true)
            {
                CheckBoxList1.Items.Add("Brain Games");
                CheckBoxList1.Items.Add("Puzzle Baron's Logic Puzzles");
                CheckBoxList1.Items.Add("Ultimate Puzzle Challenge");
                CheckBoxList1.Items.Add("Perfect Logical!");
                CheckBoxList1.Items.Add("Tricky Logic Puzzle");

            }
            if (Qstr.Equals("Story") == true)
            {
                CheckBoxList1.Items.Add("Harry Potter");
                CheckBoxList1.Items.Add("Alice in Wonderland");
                CheckBoxList1.Items.Add("The Hobbit");
                CheckBoxList1.Items.Add("Charlie and the Chocolate Factory");
                CheckBoxList1.Items.Add("The cat in the Hat");

            }

           
        }
    }
}