using FitnessTrackingSystem.Attributes;
using FitnessTrackingSystem.Core.Contracts;
using FitnessTrackingSystem.Core.Models.Challenge;
using FitnessTrackingSystem.Core.Models.Trainer;
using FitnessTrackingSystem.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTrackingSystem.Controllers
{
    public class ChallengeController : BaseController
    {
        private readonly IChallengeService challengeService;

        private readonly ITrainerService trainerService;

        public ChallengeController(IChallengeService _challengeService, ITrainerService _trainerService)
        {
            challengeService = _challengeService;
            trainerService = _trainerService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = new AllChallengesQueryModel();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            var model = new AllChallengesQueryModel();

            return View(model);
        }

        public async Task<IActionResult> TrainerInfo()
        {
            var model = new AllTrainersQueryModel();

            return View(model);
        }

        public async Task<IActionResult> Details()
        {
            var model = new ChallengeDetailsViewModel();

            return View(model);
        }

        [HttpGet]
        [AllowTrainerOnly]
        public async  Task<IActionResult> Add()
        { 
            if(await trainerService.ExistsByIdAsync(User.Id())==false)
            {
                return RedirectToAction(nameof(TrainerController.Become),"Trainer");
            }

            var model = new ChallengeFormModel()
            {
                Categories = await challengeService.AllCategoriesAsync()
            };

            return View(model);
        }

        [HttpPost]
        [AllowTrainerOnly]
        public async Task<IActionResult> Add(ChallengeFormModel model,IFormFile video)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "Files/Videos");

            string fileName = Path.Combine(path, video.FileName);

            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                    await video.CopyToAsync(stream);
            }

            model.VideoUrl = fileName;

            if (await challengeService.CategoryExistsAsync(model.CategoryId)==false)
            {
                ModelState.AddModelError(nameof(model.CategoryId),"");
            }

            if(ModelState.IsValid==false)
            {
                model.Categories= await challengeService.AllCategoriesAsync();

                return View(model);
            }

            int? trainerId = await trainerService.GetTrainerIdAsync(User.Id());

            int newChallengeId = await challengeService.CreateAsync(model,trainerId ?? 0);

            return RedirectToAction(nameof(Details), new { id = 1 });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = new ChallengeFormModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,ChallengeFormModel model)
        {
            return RedirectToAction(nameof(Details), new { id = 1 });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var model = new ChallengeDetailsViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ChallengeDetailsViewModel model)
        {
            return RedirectToAction(nameof(Details), new { id = 1 });
        }

        [HttpPost]
        public async Task<IActionResult> Join(int id)
        {
            return RedirectToAction(nameof(Mine));
        }

        [HttpPost]
        public async Task<IActionResult> Leave(int id)
        {
            return RedirectToAction(nameof(Mine));
        }

        [HttpPost("Upload")]
        public async Task<IActionResult> Upload(IEnumerable<IFormFile> files)
        {
            string path = Path.Combine(Environment.CurrentDirectory,"Files/Videos"); 

            foreach (var file in files.Where(f => f.Length > 0))
            {
                string fileName = Path.Combine(path,file.FileName);

                using (var stream = new FileStream(fileName, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }


            return Ok(
                new 
                { 
                    savedFilesLength = files.Sum(f=>f.Length)
                });
        }
    }
}
