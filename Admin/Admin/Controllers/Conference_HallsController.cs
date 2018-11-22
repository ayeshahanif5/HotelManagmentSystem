using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Admin.Models;


namespace Admin.Controllers
{
    public class Conference_HallsController : Controller
    {
        // GET: Conference_Halls
        public ActionResult Index()
        {
            return View();
        }

        // GET: Conference_Halls/Details/5
        public ActionResult Details(int id)
        {
            Conference_Halls obj = new  Conference_Halls();
            obj.HotelName = "PEARL CONTINENTAL";
            obj.CityName = "Lahore";
            obj.HallName = "Crystal Hall";
            return View(obj);
            
        }

        // GET: Conference_Halls/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Conference_Halls/Create
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

        // GET: Conference_Halls/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Conference_Halls/Edit/5
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

        // GET: Conference_Halls/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Conference_Halls/Delete/5
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

        public ActionResult Add_conferencehall()
        {
            return View();
        }

        public ActionResult Update_conferencehall()
        {
            return View();
        }

        public ActionResult Delete_conferencehall()
        {
            return View();
        }
    }
}
