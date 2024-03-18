using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTrackingSystem.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
      
    }
}
