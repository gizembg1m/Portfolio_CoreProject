using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class SocialMediaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
