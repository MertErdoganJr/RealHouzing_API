using Microsoft.AspNetCore.Mvc;

namespace RealHouizng.Consume.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
