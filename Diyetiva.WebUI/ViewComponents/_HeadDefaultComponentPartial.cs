using Microsoft.AspNetCore.Mvc;

namespace Diyetiva.WebUI.ViewComponents
{
    public class _HeadDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
