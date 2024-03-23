using FitnessTrackingSystem.Core.Contracts;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using FitnessTrackingSystem.Extensions;
using FitnessTrackingSystem.Controllers;

namespace FitnessTrackingSystem.Attributes
{
    public class AllowTrainerOnly:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            ITrainerService? trainerService = context.HttpContext.RequestServices.GetService<ITrainerService>();

            if (trainerService == null)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

            if (trainerService != null
                && trainerService.ExistsByIdAsync(context.HttpContext.User.Id()).Result)
            {
                context.Result = new RedirectToActionResult(nameof(TrainerController.Become),"Trainer",null);
            }
        }
    }
}
