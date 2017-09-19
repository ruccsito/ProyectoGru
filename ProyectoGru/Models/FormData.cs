using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGru.Models
{
    public class FormData
    {
        public string id { get; set; }
        public string placeholder { get; set; }
        public List<string> options { get; set; }
    }
}