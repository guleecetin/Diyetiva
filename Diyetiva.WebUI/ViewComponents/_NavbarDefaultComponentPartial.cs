﻿using Microsoft.AspNetCore.Mvc;

namespace Diyetiva.WebUI.ViewComponents
{
    public class _NavbarDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
