using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwestLab.DAL;
using NorthwestLab.Models;
using Microsoft.AspNet.Identity;
using System.Data;
using System.Data.Entity;

namespace NorthwestLab.Controllers
{
    [Authorize(Roles = "Lab Technician, Lab Manager, Administrator")]
    public class LabTechnicianController : Controller
    {
        private NorthwestDbContext db = new NorthwestDbContext();

        // GET: LabTechnician
        public ActionResult Index()
        {
            
            return View(db.TestTable.OrderBy(t => t.StartDate).ToList());
        }

        public ActionResult Schedule()
        {
            ScheduleViewModel model = new ScheduleViewModel();
            foreach (Tests test in db.TestTable.Where(t => t.StartDate == null))
            {
                model.Tests.Add(new TestScheduleViewModel() { TestID = test.TestID, AssayTestTypeID = test.AssayTestTypeID, CustomerApproval = test.CustomerApproval, DueDate = test.Assays.WorkOrders.DateDue});
            }
            model.Tests.OrderBy(t => t.DueDate);
            return View(model);
        }


        public ActionResult ReceiveSample()
        {
            ReceiveSampleViewModel model = new ReceiveSampleViewModel();
            foreach (Samples s in db.SampleTable.Where(samp => samp.CompoundReceiptID == null).Include( i => i.Compounds))
            {
                model.Samples.Add(new SamplesViewModel() { OriginSampleID = s.SampleID, CompoundID = s.CompoundID, WorkOrderID = s.WorkOrderID, SampleSequenceID = s.SampleSequenceID,IsSelected = false });
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult ReceiveSample(ReceiveSampleViewModel model)
        {
            if (ModelState.IsValid)
            {
                string userID = User.Identity.GetUserId();
                db.CompoundReceiptTable.Add(new CompoundReceipts()
                {
                    ReceivedByID = db.EmployeeTable.FirstOrDefault(e => e.UserID == userID).EmployeeID,
                    DateArrived = DateTime.Now
                });
                db.SaveChanges();
                foreach (SamplesViewModel s in model.Samples)
                {
                    if (s.IsSelected)
                    {
                        int receiptID = db.CompoundReceiptTable.Max(ct => ct.CompoundReceiptID);
                        Samples sample = db.SampleTable.Find(s.OriginSampleID);
                        sample.CompoundReceiptID = receiptID; ;
                        db.SaveChanges();
                    }

                }
                return View("Index");
            }
            return View(model);
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