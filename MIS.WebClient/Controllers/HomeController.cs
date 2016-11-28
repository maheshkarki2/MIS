using System.Web.Mvc;

namespace MIS.WebClient.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Login()
        {
            return View();
        }
    }
}