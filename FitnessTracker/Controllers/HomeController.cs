using FitnessTracker.Models;
using FitnessTrackingSystem.Core.Contracts.Challenge;
using FitnessTrackingSystem.Core.Models.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FitnessTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IChallengeService challengeService;

        public HomeController(ILogger<HomeController> logger, 
            IChallengeService _challengeService) 
        {
            _logger = logger;
            challengeService = _challengeService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await challengeService.LastThreeChallenges();
            return  View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
