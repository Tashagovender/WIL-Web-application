using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Heal_Foundation.Controllers
{
    public class Donate : Controller
    {
        // GET: Donate
        public ActionResult Index()
        {
            return View();
        }

        // GET: Donate/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Donate/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Donate/Create
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

        // GET: Donate/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Donate/Edit/5
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

        // GET: Donate/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Donate/Delete/5
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
