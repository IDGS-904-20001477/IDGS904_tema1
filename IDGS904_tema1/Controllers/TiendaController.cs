using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var alumnos = new Alumnos()
            {
                Nombre = "Eric",
                Edad = 21,
                Activo = true,
                Inscrito = new DateTime(2022, 4, 23)
            };
            ViewBag.alumnos = alumnos;
            return View();
        }

        public ActionResult Registrar()
        {

            return View();
        }

        public ActionResult Temperatura()
        {
            return View();
        }

        public ActionResult CalcularTemperatura(Temperatura temp)
        {
            temp.CalcularCelcius();
            TempData["Resultado"] = temp.Resultado + "";
            return RedirectToAction("Temperatura");
        }
    }
}