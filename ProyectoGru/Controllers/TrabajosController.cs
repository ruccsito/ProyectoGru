using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoGru.Models;

namespace ProyectoGru.Controllers
{
    public class TrabajosController : Controller
    {
        private ProyectoEntities db = new ProyectoEntities();

        // GET: Trabajos
        public ActionResult Finalizados()
        {
            List<Trabajo> query = (from t in db.Trabajos select t).ToList();
            return View(query);
        }
        public ActionResult Generador()
        {
            GeneradorModel gen = new GeneradorModel();
            gen.Transcoders = new List<string>();
            gen.Contenedores = new List<string>();
            gen.CodecVideos = new List<string>();
            gen.CodecAudios = new List<string>();

            gen.Transcoders.AddRange(
                (from t in db.Transcoders select t.Nombre).ToList()
                );

            gen.Contenedores.AddRange(
                (from c in db.Contenedors select c.Nombre).ToList()
             );

            gen.CodecVideos.AddRange(
                (from cv in db.CodecVideos select cv.Nombre).ToList()
             );

            gen.CodecAudios.AddRange(
                (from ca in db.CodecAudios select ca.Nombre).ToList()
             );

            return View(gen);
        }

        [HttpPost]
        public ActionResult Generador(Trabajo trabajo)
        {
            GeneradorModel gen = new GeneradorModel();
            gen.Transcoders = new List<string>();
            gen.Contenedores = new List<string>();
            gen.CodecVideos = new List<string>();
            gen.CodecAudios = new List<string>();

            gen.Transcoders.AddRange(
                (from t in db.Transcoders select t.Nombre).ToList()
                );

            gen.Contenedores.AddRange(
                (from c in db.Contenedors select c.Nombre).ToList()
             );

            gen.CodecVideos.AddRange(
                (from cv in db.CodecVideos select cv.Nombre).ToList()
             );

            gen.CodecAudios.AddRange(
                (from ca in db.CodecAudios select ca.Nombre).ToList()
             );
            return View(gen);
        }
    }
}