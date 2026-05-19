using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class AdminController: Controller
    {

        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        public IActionResult AddMedicalConditions()
        {
            return PartialView("_AddMedicalCOnditions");
        }

        public IActionResult AddAllergies()
        {
            return PartialView("_AddAllergies");
        }

        public IActionResult AddMedication()
        {
            return PartialView("_AddMedication");
        }
    }
}
