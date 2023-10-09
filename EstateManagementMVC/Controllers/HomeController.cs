using EstateManagementMVC.Dtos;

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EstateManagementMVC.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(LoginUserDto user)
        {
            return View();
        }

 
    }
}