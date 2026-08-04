using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using BusinessLayer.ValidationRules;
using ValidationResult = FluentValidation.Results.ValidationResult;


namespace Core_Project.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Project List";
            ViewBag.v2 = "Projects";
            ViewBag.v3 = "Project List";
            var values = portfolioManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {

            return View();
        }


        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(portfolio);
            if (results.IsValid)
            {
                portfolioManager.TAdd(portfolio);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}