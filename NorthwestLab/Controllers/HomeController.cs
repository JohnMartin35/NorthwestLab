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

        public ActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return View();
            }
            else if (User.IsInRole("Client"))
            {
                return RedirectToAction("Index", "Client", null);
            }
            else if (User.IsInRole("Lab Technician"))
            {
                return View();
            }
            else
            {
                return View();
            }

           
        }
        public ActionResult Catalog()
        {
            return View();
        }
        public ActionResult Feedback()
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
            ViewBag.Message = "Contact a Sales Representative Now!";

            return View();
        }
    }
}