using FitnessTrackingSystem.Core.Contracts;
using FitnessTrackingSystem.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FitnessTrackingSystem.Attributes
{
    public class NotATrainerAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            ITrainerService? trainerService = context.HttpContext.RequestServices.GetService<ITrainerService>();

            if (trainerService == null)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

            if (trainerService!=null 
                && trainerService.ExistsByIdAsync(context.HttpContext.User.Id()).Result)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status400BadRequest);
            }       
        }
    }
}
