using FitnessTrackingSystem.Core.Models.Challenge;
using FitnessTrackingSystem.Core.Models.Trainer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTrackingSystem.Controllers
{
    [Authorize]
    public class ChallengeController : Controller
    {
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
        public IActionResult Add()
        { 
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ChallengeFormModel model)
        {
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
        public async Task<IActionResult> Upload(List<IFormFile> files)
        {
            string path = Path.Combine(Environment.CurrentDirectory,"Files"); 

            foreach (var file in files.Where(f => f.Length > 0))
            {
                string fileName = Path.Combine(path,file.Name);

                using (var fileStream = new FileStream(fileName, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            } 

            return Ok(
                new
                {
                    savedFileLength= files.Sum(f => f.Length)
                });
        }
    }
}
