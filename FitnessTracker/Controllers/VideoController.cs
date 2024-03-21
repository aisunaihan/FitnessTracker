using Microsoft.AspNetCore.Mvc;

namespace FitnessTrackingSystem.Controllers
{
    public class VideoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
