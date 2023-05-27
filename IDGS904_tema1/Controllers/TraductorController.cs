using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class TraductorController : Controller
    {
        // GET: Traductor
        public ActionResult Registrar()
        {
            var arch = new TraductorServices();
            ViewBag.Archivo = arch.LeerPalabras();
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Traductor tra)
        {
            var ope1 = new TraductorServices();
            ope1.GuardarPalabras(tra);

            return View();
        }

        public ActionResult LeerDatos()
        {
           
            return View();
        }

        public ActionResult Traduccion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Traduccion(Traductor tra)
        {
            var services = new TraductorServices();
            var resultado = services.BuscarPalabra(tra);
            TempData["Resultado"] = resultado;
            return RedirectToAction("Traduccion");
        }
    }
}