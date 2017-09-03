using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoGru.Models;
using ProyectoGru.Data;

namespace ProyectoGru.Controllers
{
    public class TrabajosController : Controller
    {
        private TrabajosRepo trRepo;

        public TrabajosController()
        {
            trRepo = new TrabajosRepo(new ProyectoEntities());
        }

        // GET: Trabajos
        public ActionResult Index()
        {
            IEnumerable<Trabajo> trabajos = trRepo.Get();
            ViewBag.newJob = TempData["newJob"];
            return View(trabajos);
        }

        [HttpPost]  // POST: Trabajos/Crear
        public ActionResult Crear(Trabajo trabajo)
        {
            // Agregar trabajo a la DB.
            if (ModelState.IsValid)
            {
                trRepo.Insert(trabajo);
                trRepo.Save();
                TempData["newJob"] = "true";
            }

            return RedirectToAction("Index");
        }

        public ActionResult Ok()
        {
            ViewBag.Message = "Creado!";
            return View();
        }
    }
}