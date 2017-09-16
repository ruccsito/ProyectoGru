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
            ViewBag.transcoders = formRepo.GetTranscoders();
            return View();
        }

        // Get: Generador/Partial

        public ActionResult Test()
        {
            ViewBag.transcoders = formRepo.GetTranscoders();
            return View();
        }

        public  ActionResult Containers(string option)
        {
            // https://stackoverflow.com/questions/11774741/load-partial-view-depending-on-dropdown-selection-in-mvc3

            ViewBag.containers = formRepo.GetContainers(option);
            return PartialView();
        }

        public ActionResult VideoCodecs(string option)
        {
            // https://stackoverflow.com/questions/11774741/load-partial-view-depending-on-dropdown-selection-in-mvc3

            ViewBag.codecvideos = formRepo.GetVideoCodecs(option);
            return PartialView();
        }
    }
}
