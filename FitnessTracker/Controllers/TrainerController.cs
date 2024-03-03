using FitnessTrackingSystem.Core.Models.Trainer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTrackingSystem.Controllers
{
    [Authorize]
    
    public class TrainerController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Become()
        {
            var model=new BecomeTrainerFormModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeTrainerFormModel model)
        {
            return RedirectToAction(nameof(ChallengeController.All), "Challenge");
        }
    }
}
