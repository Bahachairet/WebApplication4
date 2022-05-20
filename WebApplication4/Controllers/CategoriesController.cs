using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication4.Data;

namespace WebApplication4.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _context;
        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Categorie.ToList();

            return View(data);
        }
    }
}
