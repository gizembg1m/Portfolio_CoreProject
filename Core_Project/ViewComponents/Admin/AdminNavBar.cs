using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Admin
{
    public class AdminNavBar: ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
