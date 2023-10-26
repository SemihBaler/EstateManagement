using Microsoft.AspNetCore.Mvc;

namespace EstateManagementMVC.Controllers
{
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
