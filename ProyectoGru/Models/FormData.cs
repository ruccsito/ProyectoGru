using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGru.Models
{
    public class FormData
    {
        public List<string> Transcoders { get; set; }
        public List<string> Contenedores { get; set; }
        public List<string> CodecVideos { get; set; }
        public List<string> CodecAudios { get; set; }
    }
}