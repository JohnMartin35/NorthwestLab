using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwestLab.DAL;
using NorthwestLab.Models;
using Microsoft.AspNet.Identity;

namespace NorthwestLab.Controllers
{
    [Authorize(Roles = "Client")]
    public class ClientController : Controller
    {
        private NorthwestDbContext db = new NorthwestDbContext();
        // GET: Client
        public ActionResult Index()
        {
            string userId = User.Identity.GetUserId();
            int custID = db.CustomerTable.FirstOrDefault(c => c.UserID == userId).CustomerID;
            List<WorkOrders> workOrders = db.WorkOrderTable.Where(wo => wo.CustomerID == custID).ToList();
            return View(workOrders);
        }

        public ActionResult NewWorkOrder()
        {
            string userId = User.Identity.GetUserId();
            int custID = db.CustomerTable.FirstOrDefault(c => c.UserID == userId).CustomerID;
            List<Compounds> compounds = db.CompoundsTable.Where(comp => comp.CustomerID == custID).ToList();

            return View(compounds);
        }

        [AllowAnonymous]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customers customer)
        {
            if (ModelState.IsValid)
            {

            }
            return View(customer);

        }





    }


}