using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoGru.Models;

namespace ProyectoGru.Data
{
    public class FormRepo
    {
        private ProyectoEntities db;

        public FormRepo (ProyectoEntities context)
        {
            db = context;
        }

        public FormData Get()
        {
            FormData formData = new FormData()
            {
                CodecAudios = db.CodecAudios.Select(c => c.Nombre).ToList(),
                CodecVideos = db.CodecVideos.Select(c => c.Nombre).ToList(),
                Contenedores = db.Contenedors.Select(c => c.Nombre).ToList(),
                Transcoders = db.Transcoders.Select(t => t.Nombre).ToList()
            };

            return formData;
        }
    }
}