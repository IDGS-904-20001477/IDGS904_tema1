using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index(string n1, string n2)
        {
            ViewBag.Nombre = "Alan Francisco Funes Falcón";
            int res = Convert.ToInt32(n1) + Convert.ToInt32(n2);
            ViewBag.Resultado = Convert.ToString(res);
            return View();
        }
        public ActionResult Calcular(OperasBas op)
        {
            var model = new OperasBas();
            model.Res = op.Calcular();
            return View(model);
        }

        public ActionResult MuestraPulques()
        {
            var pulques = new ProductoServices();
            var model = pulques.ObtenerProducto();
            return View(model);
        }
    }
}