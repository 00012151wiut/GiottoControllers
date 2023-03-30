using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiottoControllers.Controllers
{
    public class AController : Controller
    {
        // GET: AController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AController/Create
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

        // GET: AController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AController/Edit/5
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

        // GET: AController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AController/Delete/5
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
