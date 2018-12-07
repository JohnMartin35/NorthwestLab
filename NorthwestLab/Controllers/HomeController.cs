﻿using Microsoft.AspNet.Identity;
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