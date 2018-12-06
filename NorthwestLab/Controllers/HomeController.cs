using Microsoft.AspNet.Identity;
using NorthwestLab.DAL;
using NorthwestLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLab.Controllers
{
    public class HomeController : Controller
    {
        private NorthwestDbContext db = new NorthwestDbContext();
        [Authorize]
        public ActionResult Index()
        {
            string currentUserID = User.Identity.GetUserId();

            Customers currentCustomer = db.CustomerTable.Where(c => c.UserID == currentUserID).First();

            ViewBag.output += currentCustomer.CompanyName + ' ' + currentCustomer.StreetAddress + ' ' + currentCustomer.City + ' ' + currentCustomer.State_ProvinceID + ' ' + currentCustomer.Zip;

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
    }
}