using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Edit";
            ViewBag.v2 = "About";
            ViewBag.v3 = "About page";
            var values = aboutManager.TGetByID(2);
            return View(values);

        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            aboutManager.TUpdate(about);
            return RedirectToAction("Index", "Default");
        }

    }
}
