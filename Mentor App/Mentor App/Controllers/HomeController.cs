using System.Diagnostics;
using Mentor_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mentor_App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
