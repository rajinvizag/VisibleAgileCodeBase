using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VisibleAgileWeb.Models;

namespace VisibleAgileWeb.Controllers
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
            ViewBag.Message = "Your login page.";

            VALoginModel objLogin = new VALoginModel();
            return View(objLogin);
        }

        [HttpPost]
        public ActionResult Login(VALoginModel objuserlogin)
        {
            var display = Userloginvalues().Where(m => m.JiraURL == objuserlogin.JiraURL && m.UserName == objuserlogin.UserName && m.Password == objuserlogin.Password).FirstOrDefault();
            if (display != null)
            {
                ViewBag.Status = "Correct Credentials!";
            }
            else
            {
                ViewBag.Status = "Invalid Credentials!";
            }

            return View(objuserlogin);
        }

        public List<VALoginModel> Userloginvalues()

        {
            List<VALoginModel> objModel = new List<VALoginModel>();
            objModel.Add(new VALoginModel { JiraURL="Jira1", UserName = "user1", Password = "password1" });
            objModel.Add(new VALoginModel { JiraURL = "Jira2", UserName = "user2", Password = "password2" });
            objModel.Add(new VALoginModel { JiraURL = "Jira3", UserName = "user3", Password = "password3" });
            objModel.Add(new VALoginModel { JiraURL = "Jira4", UserName = "user4", Password = "password4" });
            return objModel;

        }
    }
}