using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Areas.Writer.ViewComponents
{
    public class Notification : ViewComponent
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IViewComponentResult Invoke()
        {
            var values = announcementManager.TGetList();
            return View(values);
        }
    }
}
