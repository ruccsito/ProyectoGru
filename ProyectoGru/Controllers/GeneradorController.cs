using ProyectoGru.Data;
using ProyectoGru.Models;
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

            FormData fd = new FormData();
            fd.id = "containersSelect";
            fd.placeholder = "Seleccionar container";
            fd.options = formRepo.GetContainers(option);

            return PartialView("Selects", fd);
        }

        public ActionResult VideoCodecs(string option)
        {
            FormData fd = new FormData();
            fd.id = "videoCodecs";
            fd.placeholder = "Seleccionar codec";
            fd.options = formRepo.GetVideoCodecs(option);

            return PartialView("Selects",fd);
        }
    }
}
