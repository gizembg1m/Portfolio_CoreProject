using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());


        public IActionResult Index()
        {
            ViewBag.v1 = "Services List";
            ViewBag.v2 = "Services";
            ViewBag.v3 = "Services List";
            var values = serviceManager.TGetList();
            return View(values);

        }


        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.v1 = "Add Service";
            ViewBag.v2 = "Services";
            ViewBag.v3 = "Add Service";
            return View();
        }


        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.TAdd(service);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult DeleteService(int id)
        {
            var values = serviceManager.TGetByID(id);
            serviceManager.TDelete(values);
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult EditService(int id)
        {
            ViewBag.v1 = "Edit";
            ViewBag.v2 = "Services";
            ViewBag.v3 = "Edit Services";
            var values = serviceManager.TGetByID(id);
            return View(values);
        }


        [HttpPost]
        public IActionResult EditService(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction(nameof(Index));
        }
    }
}
