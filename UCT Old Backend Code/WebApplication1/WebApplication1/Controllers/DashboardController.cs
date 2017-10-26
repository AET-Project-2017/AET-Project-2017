using AETProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AETProject.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            if (Session["firstName"] != null)
                return View();
            else
                Response.Redirect("../Home/Index");
            return null;
        }
        public string dashboard(string data) {
            return data;
        }

        public void SetSID(string _email, string _password)
        {
            User temp = new User();
            User login = temp.Login(_email, _password);
            if (login == null)
            {
                Response.Redirect("../Home/Index");
            }
            else
            {
                Session["userId"] = login.userId;
                Session["firstName"] = login.firstName;
                Session["lastName"] = login.lastName;
                Session["startDate"] = DateTime.Now.ToString();
                Session["email"] = login.email;
                Session["endDate"] = DateTime.Now.AddDays(1).ToString();
                Session.Timeout = 60;
                Response.Redirect("Index");
            }
        }
    }
}