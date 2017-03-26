using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using test1.BLL;
using test1.Context;
using test1.Interfaces.BLL;
using test1.Models;

namespace test1.Controllers
{
    public class TraineeController : Controller
    {
        private ITraineeManager _traineeManager;

        public TraineeController()
        {
            _traineeManager = new TraineeManager();
        }

        // GET: Trainee
        public ActionResult Index()
        {
            return View(_traineeManager.GetAll());
        }

        // GET: Trainee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trainee trainee = _traineeManager.GetById(id);
            if (trainee == null)
            {
                return HttpNotFound();
            }
            return View(trainee);
        }

        // GET: Trainee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trainee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Address,Email")] Trainee trainee)
        {
            if (ModelState.IsValid)
            {
                _traineeManager.Add(trainee);
                return RedirectToAction("Index");
            }

            return View(trainee);
        }

        // GET: Trainee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trainee trainee = _traineeManager.GetById(id);
            if (trainee == null)
            {
                return HttpNotFound();
            }
            return View(trainee);
        }

        // POST: Trainee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Address,Email")] Trainee trainee)
        {
            if (ModelState.IsValid)
            {
                _traineeManager.Update(trainee);
                return RedirectToAction("Index");
            }
            return View(trainee);
        }

        // GET: Trainee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trainee trainee = _traineeManager.GetById(id);
            if (trainee == null)
            {
                return HttpNotFound();
            }
            return View(trainee);
        }

        // POST: Trainee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trainee trainee = _traineeManager.GetById(id);
            _traineeManager.Remove(trainee);
             return RedirectToAction("Index");
        }

        
    }
}
