using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq_Example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int[] nums = new int[] { 0, 1, 2, 3, 4, 5, 6, 73 };
        int[] Numbers = { 20, 40, 60, 80, 100, 120 };
        int[] factorof300 = { 2, 3, 2, 5, 5, 6, 7, 8, 9 };
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        int[] numbers = { 1, 11, 3, 19, 4, 45, 41, 65, 19 };

        int[] numberA = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] numberB = { 1, 3, 5, 7, 8 };
        protected void Page_Load(object sender, EventArgs e)
        {
            var result = from n in nums
                         select n;

            //var r = from d in digits
            //        select d;

            var r = (from d in digits
                     where d[1]=='i'
                    select d).Reverse();

            var uniquefactor = factorof300.Distinct();

            var uniquenumbers = from n in numberA.Union(numberB)
                                orderby n
                                select n;
            var commonfactor = numberA.Intersect(numberB);
            var aOnlyNumbers = numberA.Except(numberB);

            Label2.Text = Numbers.Max().ToString();
            Label3.Text = Numbers.Min().ToString();
            Label4.Text = Numbers.Sum().ToString();
            Label5.Text = Numbers.Average().ToString();
            Label6.Text = Numbers.Count().ToString();

            string[] words = { "believe", "relief", "receipt", "field" };
            bool iAfterE = words.Any(w => w.Contains("ei"));
            Label7.Text = iAfterE.ToString();
            bool eAfteri = words.All(w => w.Contains("e"));
            Label8.Text = eAfteri.ToString();




            if (!Page.IsPostBack)
            {
                DropDownList1.DataSource = result;
                DropDownList2.DataSource = r;
                DropDownList3.DataSource = uniquefactor;
                DropDownList4.DataSource = uniquenumbers;
                DropDownList5.DataSource = commonfactor;
                DropDownList5.DataSource = aOnlyNumbers;
                Page.DataBind();
            }
        }
    }
}