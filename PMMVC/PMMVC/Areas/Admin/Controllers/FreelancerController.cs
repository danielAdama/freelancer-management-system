using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PMMVC.Infrastructure.Data;
using PMMVC.Infrastructure.Data.ViewModels;
using PMMVC.Infrastructure.Services.Infracstructure.Persistence;
using System.Threading;

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
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            IEnumerable<Freelancer> freelances = await _context.Freelancers
                .Include(x => x.Skill)
                .AsNoTracking().ToListAsync(cancellationToken);
            return View(freelances);
        }

        public async Task<IActionResult> Details(long freelancerid)
        {
            if (freelancerid is 0)
            {
                return NotFound();
            }
            Freelancer? freelancer = await _context.Freelancers.FindAsync(freelancerid);

            if (freelancer == null)
            {
                return NotFound();
            }
            return View(freelancer);
        }

        #region API CALLS
        [HttpGet]
        public async Task<IActionResult> project(long id, CancellationToken cancellationToken)
        {
            var freelancer = await _context.Freelancers.FirstOrDefaultAsync(x => x.Id.Equals(id), cancellationToken);
            if (freelancer is null)
            {
                return Json(new { success = false, message = "Error => Freelancer does not exist" });
            }
            var projects = await _context.Projects.Where(x => x.FreelancerId.Equals(freelancer.Id))
                .ToListAsync(cancellationToken);
            return Json(new { data = projects });
        }
        #endregion
    }
}
