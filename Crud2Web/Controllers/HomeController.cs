using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud2Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Soy un conctato";

            return View();
        }

        public ActionResult Saludo(string nombre="")
        {
            ViewBag.SaludoPersonal = $"Hola soy {nombre} un saludo personalizado.";
            return View();
        }
    }
}