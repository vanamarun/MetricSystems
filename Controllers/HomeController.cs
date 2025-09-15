using Microsoft.AspNetCore.Mvc;

namespace MetricSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}