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
    [Authorize(Roles = "Lab Technician, Lab Manager, Administrator")]
    public class LabTechnicianController : Controller
    {
        private NorthwestDbContext db = new NorthwestDbContext();

        // GET: LabTechnician
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ReceiveSample()
        {
            List<Samples> samples = db.SampleTable.Where(s => s.CompoundReceiptID == null).OrderBy(s => s.WorkOrderID).ToList();
            return View(samples);
        }

        [HttpPost]
        public ActionResult RecieveSample(CompoundReceipts newCompound)
        {
            if (ModelState.IsValid)
            {
                return View("Index");
            }
            return View(newCompound);
        }

        public ActionResult LogTime(int id)
        {
            Employees emp = db.EmployeeTable.FirstOrDefault(e => e.UserID == User.Identity.GetUserId());
            TestTimeLog test = new TestTimeLog() { TestID = id , EmployeeID = emp.EmployeeID};
            return View(test);
        }

        [HttpPost]
        public ActionResult LogTime(TestTimeLog log)
        {
            if (ModelState.IsValid)
            {
                return View("Index");
            }
            return View(log);
        }
    }
}