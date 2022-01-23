using LoginForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        //[httppost]
        //[validateantiforgerytoken]
        //public actionresult login(userprofilecontroller profilecontroller)
        //{ 
          //  if(modelstate.isvalid)
            //{
              //  using (mydb_sqlentities db=new mydb_sqlentities())
                //{
                  //  var obj =db.userprofiles.where(a=>a.username.equals(profilecontroller.))
                //}
           // }
           // return view();
        //}

    }
}