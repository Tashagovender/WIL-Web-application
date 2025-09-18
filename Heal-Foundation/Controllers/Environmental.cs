using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Heal_Foundation.Controllers
{
    public class Environmental : Controller
    {
        // GET: Environmental
        public ActionResult Index()
        {
            return View();
        }

        // GET: Environmental/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Environmental/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Environmental/Create
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

        // GET: Environmental/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Environmental/Edit/5
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

        // GET: Environmental/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Environmental/Delete/5
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
