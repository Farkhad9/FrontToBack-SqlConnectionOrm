using EternaApp.Data;
using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaApp.Controllers
{
    public class ProductController(EternaDbContext eternaDbContext) : Controller
    {
        public IActionResult Index()
        {
            ProductVm productVm = new ProductVm
            {
                Categories = eternaDbContext.Categories.ToList(),
                Products = eternaDbContext.Products
                .Include(p => p.ProductImages)
                .ToList()
            };
            return View(productVm);
        }
    }
}
