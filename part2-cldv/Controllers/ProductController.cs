using Microsoft.AspNetCore.Mvc;
using part2_cldv.Data;
using part2_cldv.Models;

namespace part2_cldv.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
            }
            return View(product);
        }

        public IActionResult Confirmation()
        {
            return View();
        }
    }
}