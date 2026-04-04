using Mentor_App.Data;
using Mentor_App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mentor_App.Controllers
{
    public class PricingController (MentorAppDbContext context) : Controller
    {
        public IActionResult Index()
        {
            var pricings = context.Pricings
                .Include(p => p.PricingServices)
                .ThenInclude(ps => ps.Service)
                .ToList();
            PricingVm pricingVm = new PricingVm()
            {
                Services = context.Services.ToList(),
                Pricings = context.Pricings.ToList()
            };
            return View(pricingVm);
        }
    }
}
