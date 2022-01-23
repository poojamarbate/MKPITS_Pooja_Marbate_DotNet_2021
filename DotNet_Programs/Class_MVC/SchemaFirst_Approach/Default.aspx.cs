using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SchemaFirst_Approach
{
    public partial class _Default : Page
    {
        myDB_SQLEntities db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new myDB_SQLEntities();
            GridView1.DataSource = db.Categories.ToList();
            GridView1.DataBind();
        }
    }
}