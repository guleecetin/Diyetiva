using Microsoft.AspNetCore.Mvc;

namespace Diyetiva.WebUI.ViewComponents
{
    public class _AboutDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
