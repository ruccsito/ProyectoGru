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

        public List<string> GetAudioCodecs(string container)
        {
            return (from cca in db.ContenedorCodecAudios
                        join ct in db.Contenedors on cca.IdContenedor equals ct.IdContenedor
                        join ca in db.CodecAudios on cca.IdCodecAudio equals ca.IdCodecAudio
                    where ct.Nombre == container
                    select ca.Nombre).ToList();
        }
    }
}