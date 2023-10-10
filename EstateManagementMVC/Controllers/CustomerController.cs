using Microsoft.AspNetCore.Mvc;

namespace EstateManagementMVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
