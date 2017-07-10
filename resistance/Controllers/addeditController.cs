using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace resistance.Controllers
{
    public class addeditController : Controller
    {
        // GET: addedit
        public ActionResult Index()
        {
            return View();
        }

        // GET: addedit/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: addedit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: addedit/Create
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

        // GET: addedit/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: addedit/Edit/5
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

        // GET: addedit/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: addedit/Delete/5
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
