﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Heal_Foundation.Controllers
{
    public class About : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }

        // GET: About/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: About/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: About/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: About/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: About/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: About/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: About/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
