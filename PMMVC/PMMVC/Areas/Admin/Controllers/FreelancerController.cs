using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PMMVC.Infrastructure.Data;
using PMMVC.Infrastructure.Services.Infracstructure.Persistence;

namespace PMMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FreelancerController : Controller
    {
        private readonly FreelanceDbContext _context;

        public FreelancerController(FreelanceDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Freelancer> freelances = await _context.Freelancers.Include(x => x.Skill).AsNoTracking().ToListAsync();
            return View(freelances);
        }
    }
}
