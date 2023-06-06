using Microsoft.AspNetCore.Mvc;

namespace RealHouizng.Consume.ViewComponents.Default
{
    public class _Feature2Partial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
