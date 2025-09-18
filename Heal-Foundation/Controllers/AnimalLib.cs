using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Heal_Foundation.Controllers
{
    public class AnimalLib : Controller
    {
        // GET: AnimalLib
        public ActionResult Index()
        {
            return View();
        }

        // GET: AnimalLib/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnimalLib/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnimalLib/Create
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

        // GET: AnimalLib/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnimalLib/Edit/5
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

        // GET: AnimalLib/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnimalLib/Delete/5
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
