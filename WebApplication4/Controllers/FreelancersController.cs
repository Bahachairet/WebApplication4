using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Controllers
{
    public class FreelancersController : Controller
    {
        private readonly AppDbContext _context;
        public FreelancersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allfreelancer = await _context.Freelancer.ToListAsync();
            return View(allfreelancer);
        }
    }
}
