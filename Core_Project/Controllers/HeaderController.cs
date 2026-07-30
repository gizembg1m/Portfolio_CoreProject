using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class HeaderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
