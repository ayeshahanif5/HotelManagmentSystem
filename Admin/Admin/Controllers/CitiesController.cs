using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Admin.Models;

namespace Admin.Controllers
{
    public class CitiesController : Controller
    {
        // GET: Cities
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cities/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cities/Create
        public ActionResult Create()
        {
            ViewBag.Message = "Create city";
            return View();
        }

        // POST: Cities/Create
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

        // GET: Cities/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Message = "edit city";
            return View();
        }

        // POST: Cities/Edit/5
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

        // GET: Cities/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.Message = "delete city";
            return View();
        }

        // POST: Cities/Delete/5
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
        public ActionResult Add_city()
        {
            return View();
        }

        public ActionResult Update_city()
        {
            return View();
        }
        public ActionResult Delete_city()
        {
            return View();
        }
        public ActionResult getCityDetail()
        {
            Cities obj = new Cities();
            obj.CityName = "Lahore";
            obj.CityName = "Karachi";
            obj.CityName = "Islamabad";
            return View(obj);

       

        }


    }
}
