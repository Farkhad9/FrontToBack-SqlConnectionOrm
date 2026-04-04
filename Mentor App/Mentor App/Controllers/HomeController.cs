using System.Diagnostics;
using Mentor_App.Data;
using Mentor_App.Models;
using Mentor_App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mentor_App.Controllers
{
    public class HomeController (MentorAppDbContext context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var slider = await context.Sliders.FirstOrDefaultAsync();
            HomeVm homeVm = new HomeVm()
            {
                Slider = slider
            };
            return View(homeVm);
        }
    }
}
