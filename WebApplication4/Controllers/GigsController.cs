using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Controllers
{
    public class GigsController : Controller
    {
        private readonly AppDbContext _context;
        public GigsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allgig = await _context.Gig.ToListAsync();
            return View(allgig);
        }
    }
}
