using Microsoft.AspNetCore.Mvc;

namespace ITELEC_LAPUZ.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee()
        {
            return View();
        }
    }
}
