using HuellaCarbono.BE;
using HuellaCarbono.BL;
using System.Web.Mvc;

namespace HuellaCarbono.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //var huellaTransBL = new HuellaCall();
            //ViewBag.TipoTransporte = huellaTransBL.ListarTipoTransporte();
            return View();
        }
    }
}