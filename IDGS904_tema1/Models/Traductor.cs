using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Traductor
    {

        public Traductor() {
            Palabra = "";
            Seleccionado = "";
        }
        public string Español { get; set; }
        public string Ingles { get; set; }
        public string Palabra { get; set; }
        public string Seleccionado { get; set; }
    }
}