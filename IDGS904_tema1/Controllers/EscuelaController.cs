using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace IDGS904_tema1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: EScuela
        public ActionResult Index()
        {
            //return Content("<h1> Alan <br/>Funes</h1>");
            var pulque = new Productos()
            {
                Name = "pulque1",
                Description = "fresa",
                Quantity = 10,
                Production = new DateTime(2023, 11, 2)
            };
            return Json(pulque, JsonRequestBehavior.AllowGet);
            //return View();
        }
        public RedirectResult Vista()
        {
            return Redirect("https://google.com.mx");
        }
        public RedirectToRouteResult Vista2()
        {
            TempData["Nombre"] = "Roberto";
            return RedirectToAction("Index2", "Escuela");
        }
        public ActionResult Index2()
        {
            ViewBag.Grupo = "IDGS904";
            ViewData["Materia"] = "DWI";
            string nombre = "";
            if(TempData.ContainsKey("Nombre"))
            {
                nombre = TempData["Nombre"] as string;
            }
            ViewBag.valor = nombre;
            return View();
        }
    }
}