using System.Web.Mvc;

namespace Aptor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "System do zarządzania zamówieniami.";

            return View();
        }
    }
}