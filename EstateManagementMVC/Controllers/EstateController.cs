using Microsoft.AspNetCore.Mvc;

namespace EstateManagementMVC.Controllers
{
    public class EstateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
