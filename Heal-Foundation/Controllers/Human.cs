using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Heal_Foundation.Controllers
{
    public class Human : Controller
    {
        // GET: Human
        public ActionResult Index()
        {
            return View();
        }

        // GET: Human/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Human/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Human/Create
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

        // GET: Human/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Human/Edit/5
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

        // GET: Human/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Human/Delete/5
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
