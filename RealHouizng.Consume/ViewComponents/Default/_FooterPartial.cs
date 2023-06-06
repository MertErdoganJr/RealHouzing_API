using Microsoft.AspNetCore.Mvc;

namespace RealHouizng.Consume.ViewComponents.Default
{
    public class _FooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
