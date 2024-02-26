using Microsoft.AspNetCore.Mvc;

namespace EpiEdil.Controllers
{
    public class EpiEdilController : Controller
    {
        public IActionResult Index()
        {            
            var employees = 
        return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {           
            return RedirectToAction("Index");
        }

        public IActionResult Payments()
        {            
            var payments = 
        return View(payments);
        }
    }
}
