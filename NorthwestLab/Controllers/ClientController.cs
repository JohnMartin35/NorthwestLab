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
            List<State_Province> dropdown = new List<State_Province>();

            foreach (State_Province state_province in db.State_ProvinceTable)
            {
                dropdown.Add(state_province);
            }

            ViewBag.stateDropDown = dropdown;

            return View();
        }

        [HttpPost]
        public ActionResult Create(Customers customer)
        {
            if (ModelState.IsValid)
            {
                customer.UserID = User.Identity.GetUserId();
                db.CustomerTable.Add(customer);
                db.SaveChanges();

                return RedirectToAction("Index", "Client", null);
            }

            return View(customer);

        }





    }


}