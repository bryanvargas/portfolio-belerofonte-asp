using System.Web.Mvc;
using Model;

namespace BelerofontePortfolio.Controllers
{
    public class HomeController : Controller
    {
        // localhost8086/home
        public ActionResult Index()
        {
         //   ViewBag.Alumnos = Alumno.Listar();
            return View();
        }

        public ActionResult Ver()
        {           
            return View(Alumno.Obtener());
        }

        public ActionResult Guardar(Alumno a, int[] algo)
        {
            return Redirect("~/home/index");
        }
    }
}