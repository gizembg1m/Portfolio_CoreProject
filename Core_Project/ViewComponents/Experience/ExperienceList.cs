using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {

        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IViewComponentResult Invoke()
        {
            var values = experienceManager.TGetList();
            return View(values);
        }
    }
    
    
}
