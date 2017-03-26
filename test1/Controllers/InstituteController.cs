﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test1.Context;

namespace test1.Controllers
{
    public class InstituteController : Controller
    {
        TrainingManagementDBContext _db = new TrainingManagementDBContext();
        // GET: Institute
        public ActionResult Index()
        {
            return View(_db.Institutes.ToList());
        }

        // GET: Institute/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Institute/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Institute/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Institute/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Institute/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Institute/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Institute/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
