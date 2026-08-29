using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class SkillController : Controller
    {

        SkillManager skillManager = new SkillManager(new EfSkillDal());


        public IActionResult Index()
        {
            var values = skillManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            if (string.IsNullOrEmpty(skill.Title) || string.IsNullOrEmpty(skill.Value))
            {
                if (string.IsNullOrEmpty(skill.Title))
                {
                    ModelState.AddModelError("Title", "Please enter a title");
                }

                if (string.IsNullOrEmpty(skill.Value))
                {
                    ModelState.AddModelError("Value", "Please enter a value");
                }

                // Alanlar boş olduğu için veritabanına gitmeden sayfayı hatalarla geri döndürür
                return View(skill);
            }
            skillManager.TAdd(skill);
            return RedirectToAction(("Index"));
        }

        public IActionResult DeleteSkill(int id)
        {
            var values = skillManager.TGetByID(id);
            skillManager.TDelete(values);
            return RedirectToAction(("Index"));
        }

        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            
            var values = skillManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            skillManager.TUpdate(skill);
            return RedirectToAction(("Index"));
        }

    }
}
