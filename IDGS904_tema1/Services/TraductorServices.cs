using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class TraductorServices
    {
        public void GuardarPalabras(Traductor tra)
        {
            var español = tra.Español.ToLower();
            var ingles = tra.Ingles.ToLower();
            var datos = español + "," + ingles + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/traduccion.txt");
            //File.WriteAllText(archivo, datos);
            File.AppendAllText(archivo, datos);
        }

        public string[] LeerPalabras()
        {
            string[] datos = null;
            var palabras = HttpContext.Current.Server.MapPath("~/App_Data/traduccion.txt");
            if (File.Exists(palabras))
            {
                datos = File.ReadAllLines(palabras);
            }
            return datos;
        }

        public string BuscarPalabra(Traductor tradutctor)
        {

            if (tradutctor == null) return "Manda nulo"; 
            var lista = new List<string>(LeerPalabras());
            var palabra = "";
            if(tradutctor.Seleccionado == "Español")
            {
                palabra = lista.Find(X => X.Split(',')[1] == tradutctor.Palabra.ToLower());

            } else
            {
                palabra = lista.Find(X => X.Split(',')[0] == tradutctor.Palabra.ToLower());
            }
            
            if(palabra != null)
            {
                if (tradutctor.Seleccionado == "Español")
                {
                    palabra = palabra.Split(',')[0];
                } else
                {

                    palabra = palabra.Split(',')[1];
                }
            }
            return palabra;
        }
    }
}