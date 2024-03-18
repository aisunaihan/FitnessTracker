using FitnessTrackingSystem.Core.Contracts;
using FitnessTrackingSystem.Core.Models.Challenge;
using FitnessTrackingSystem.Core.Models.Trainer;
using FitnessTrackingSystem.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTrackingSystem.Controllers
{
    public class TrainerController : BaseController
    {
        private readonly ITrainerService trainerService;

        public TrainerController(ITrainerService _trainerService)
        {
            trainerService = _trainerService;
        }

        [HttpGet]
        public async Task<IActionResult> Become()
        {
            if (await trainerService.ExistsByIdAsync(User.Id()))
            {
                return BadRequest();
            }

            var model=new BecomeTrainerFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeTrainerFormModel model)
        {
            return RedirectToAction(nameof(ChallengeController.All), "Challenge");
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> AllTrainers()
        {
            var model = new AllTrainersQueryModel();

            return View(model);
        }
    }
}
