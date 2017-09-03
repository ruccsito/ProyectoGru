using ProyectoGru.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoGru.Controllers
{
    public class GeneradorController : Controller
    {
        private FormRepo formRepo;

        public GeneradorController()
        {
            formRepo = new FormRepo(new ProyectoEntities());
        }

        // GET: Generador
        public ActionResult Index()
        {
            return View(formRepo.Get());
        }
    }
}