using Microsoft.AspNetCore.Mvc;

namespace RealHouizng.Consume.ViewComponents.Default
{
    public class _FeaturePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
