using Microsoft.AspNetCore.Mvc;

namespace Diyetiva.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
