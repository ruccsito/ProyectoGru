﻿using System;
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

        public List<string> GetTranscoders()
        {
            return db.Transcoders.Select(t => t.Nombre).ToList();
        }
        public List<string> GetContainers(string transcoder)
        {
            return (from ct in db.ContenedorTranscoders
                    join c in db.Contenedors on ct.IdContenedor equals c.IdContenedor
                    join t in db.Transcoders on ct.IdTranscoder equals t.IdTranscoder
                    where t.Nombre == transcoder
                    select c.Nombre).ToList();
        }

        public List<string> GetVideoCodecs(string container)
        {
            return (from ccv in db.ContenedorCodecVideos
                    join cv in db.CodecVideos on ccv.IdCodecVideo equals cv.IdCodecVideo
                    join ct in db.Contenedors on ccv.IdContenedor equals ct.IdContenedor
                    where ct.Nombre == container
                    select cv.Nombre).ToList();
        }
    }
}