using Microsoft.AspNetCore.Mvc;

namespace RealHouizng.Consume.ViewComponents.Default
{
    public class _BlogPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
