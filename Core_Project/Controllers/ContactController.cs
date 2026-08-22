using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = messageManager.TGetList();
            return View(values);
        }
        public IActionResult DeleteContact(int id)
        {
            var values = messageManager.TGetByID(id);
            messageManager.TDelete(values);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult ContactDetails(int id)
        {
            var values = messageManager.TGetByID(id);
            return View(values);
        }
    }
}
