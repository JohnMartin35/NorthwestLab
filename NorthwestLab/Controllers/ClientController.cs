using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwestLab.DAL;
using NorthwestLab.Models;
using Microsoft.AspNet.Identity;
using System.Net;
using NorthwestLab.ViewModels;
using System.Data.Entity;
using System.Data.SqlTypes;

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
            List<WorkOrders> workOrders = db.WorkOrderTable.Where(wo => wo.CustomerID == custID && wo.DateReceived != null).ToList();
            return View(workOrders);
        }

        public ActionResult NewWorkOrder(int currentWorkOrderID = 0)
        {
            string userId = User.Identity.GetUserId();

            WorkOrders currentWorkOrder = new WorkOrders();

            // create new work order if not already existant
            if (currentWorkOrderID == 0)
            {
                

                // set work order customer id to current user
                currentWorkOrder.CustomerID = db.CustomerTable.FirstOrDefault(c => c.UserID == userId).CustomerID;

                db.WorkOrderTable.Add(currentWorkOrder);
                db.SaveChanges();

                currentWorkOrderID = currentWorkOrder.WorkOrderID;
            }
            // find current work order
            else
            {
                currentWorkOrder = db.WorkOrderTable.Find(currentWorkOrderID);
            }


            int custID = db.CustomerTable.FirstOrDefault(c => c.UserID == userId).CustomerID;

            string compoundsQuery = "SELECT DISTINCT Compounds.CompoundID,Compounds.Name,Compounds.CustomerID FROM Samples JOIN Compounds ON Samples.CompoundID = Compounds.CompoundID WHERE Samples.WorkOrderID = " + currentWorkOrderID + ";";

            List<Compounds> compounds = db.CompoundsTable.SqlQuery(compoundsQuery).ToList();

            ViewBag.compounds = compounds;

            ViewBag.currentWorkOrderID = currentWorkOrderID;

            return View(currentWorkOrder);
        }

        [HttpPost]
        public ActionResult NewWorkOrder(WorkOrders newWorkOrder)
        {
            if (ModelState.IsValid)
            {
                WorkOrders currentWorkOrder = db.WorkOrderTable.Find(newWorkOrder.WorkOrderID);

                currentWorkOrder.DateDue = newWorkOrder.DateDue;
                currentWorkOrder.Comments = newWorkOrder.Comments;

                currentWorkOrder.DateReceived = DateTime.Now;
                currentWorkOrder.QuotedPrice = new SqlMoney(57.00);

                db.SaveChanges();

                return RedirectToAction("Index", "Client", null);
            }

            return View(newWorkOrder);
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



        /*------------------------------------------------------------------------------
         * 
         *  Compounds Methods
         * 
         * -----------------------------------------------------------------------------
         */

        // GET: Compounds
        public ActionResult Compounds()
        {
            
            return View();
        }

        // GET: Compounds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compounds compounds = db.CompoundsTable.Find(id);
            if (compounds == null)
            {
                return HttpNotFound();
            }
            return View(compounds);
        }

        // GET: Compounds/Create
        public ActionResult AddCompounds(int currentWorkOrderID)
        {

            List<Assays> newAssays = new List<Assays>();

            List<AssayTypes> defaultAssayTypes = db.AssayTypeTable.ToList();

            foreach (AssayTypes defaultAssayType in defaultAssayTypes)
            {
                Assays newAssay = new Assays();
                newAssay.AssayTypeID = defaultAssayType.AssayTypeID;
                newAssay.WorkOrderID = currentWorkOrderID;
                newAssay.Complete = false;
                newAssay.Selected = false;
                newAssay.AssayTitle = defaultAssayType.AssayTitle;
                newAssay.Description = defaultAssayType.Description;

                newAssay.Tests = new List<Tests>();

                List<AssayTestTypes> defaultAssayTestTypes = db.AssayTestTypeTable.Where(att => att.AssayTypeID == newAssay.AssayTypeID).ToList();

                foreach(AssayTestTypes defaultAssayTestType in defaultAssayTestTypes)
                {
                    Tests newTest = new Tests();

                    newTest.AssayTestTypeID = defaultAssayTestType.AssayTestTypeID;

                    newTest.TestTitle = defaultAssayTestType.TestTypes.TestTitle;
                    newTest.TestProtocol = defaultAssayTestType.TestTypes.TestProtocol;
                    newTest.TimeToComplete = defaultAssayTestType.TestTypes.TimeToComplete;
                    newTest.BasePrice = defaultAssayTestType.TestTypes.BasePrice;

                    string condDepQuery = "SELECT ConditionalDependencyID, AssayTestTypeSuccessorID, AssayTestTypePredecessorID, TriggerConditions FROM ConditionalDependencies WHERE AssayTestTypeSuccessorID = " + defaultAssayTestType.AssayTestTypeID + ";";

                    List<ConditionalDependencies> conditionalDependency = db.ConditionalDependencyTable.SqlQuery(condDepQuery).ToList();

                    if (conditionalDependency.Count == 0)
                    {
                        newTest.Selected = false;
                    }
                    else
                    {
                        newTest.Selected = true;
                    }

                    newAssay.Tests.Add(newTest);

                }

                newAssays.Add(newAssay);
            }

            

            return View(newAssays);
        }

        // POST: Compounds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind(Include = "CompoundID,Name,Description,CustomerID")] Compounds compounds)
        {
            if (ModelState.IsValid)
            {
                db.CompoundsTable.Add(compounds);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerID = new SelectList(db.CustomerTable, "CustomerID", "UserID", compounds.CustomerID);
            return View(compounds);
        }

        // GET: Compounds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compounds compounds = db.CompoundsTable.Find(id);
            if (compounds == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerID = new SelectList(db.CustomerTable, "CustomerID", "UserID", compounds.CustomerID);
            return View(compounds);
        }

        // POST: Compounds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CompoundID,Name,Description,CustomerID")] Compounds compounds)
        {
            if (ModelState.IsValid)
            {
                db.Entry(compounds).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerID = new SelectList(db.CustomerTable, "CustomerID", "UserID", compounds.CustomerID);
            return View(compounds);
        }

        // GET: Compounds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compounds compounds = db.CompoundsTable.Find(id);
            if (compounds == null)
            {
                return HttpNotFound();
            }
            return View(compounds);
        }

        // POST: Compounds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Compounds compounds = db.CompoundsTable.Find(id);
            db.CompoundsTable.Remove(compounds);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }


}