using Microsoft.AspNetCore.Mvc;

namespace RealHouizng.Consume.ViewComponents.Default
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
