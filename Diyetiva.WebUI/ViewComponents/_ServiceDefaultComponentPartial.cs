using Microsoft.AspNetCore.Mvc;

namespace Diyetiva.WebUI.ViewComponents
{
    public class _ServiceDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
