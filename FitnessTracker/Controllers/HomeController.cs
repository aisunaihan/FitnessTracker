using FitnessTrackingSystem.Core.Contracts;
using FitnessTrackingSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FitnessTrackingSystem.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IChallengeService challengeService;

        public HomeController(ILogger<HomeController> logger,
            IChallengeService _challengeService)
        {
            _logger = logger;
            challengeService = _challengeService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var model = await challengeService.LastThreeChallengesAsync();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [AllowAnonymous]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
