using FitnessTrackingSystem.Attributes;
using FitnessTrackingSystem.Core.Contracts;
using FitnessTrackingSystem.Core.Models.Challenge;
using FitnessTrackingSystem.Core.Models.Trainer;
using FitnessTrackingSystem.Extensions;
using FitnessTrackingSystem.Infrastructure.Data.DataConstants;
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
        [NotATrainer]
        public IActionResult Become()
        {
            var model=new BecomeTrainerFormModel();

            return View(model);
        }

        [HttpPost]
        [NotATrainer]
        public async Task<IActionResult> Become(BecomeTrainerFormModel model)
        {
            if(await trainerService.UserWithPhoneNumberExistsAsync(model.PhoneNumber))
            {
                ModelState.AddModelError(nameof(model.PhoneNumber),ErrorMessages.PhoneExists);
            }

            if(ModelState.IsValid==false)
            {
                return View(model);
            }

            await trainerService.CreateAsync(User.Id(),model.FullName,model.PhoneNumber,model.ImageUrl);

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
