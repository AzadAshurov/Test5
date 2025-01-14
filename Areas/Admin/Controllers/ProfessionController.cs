using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Testgithub2.Areas.Admin.ViewModels.Employees;
using Testgithub2.Areas.Admin.ViewModels.Professions;
using Testgithub2.DAL;

namespace Testgithub2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProfessionController : Controller
    {
        private readonly AppDbContext _context;

        public ProfessionController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
         List<GetProfessionVM> getProfessionVM = await _context.Professions.Select(x => new GetProfessionVM { Name = x.Name }).ToListAsync();
            return View(getProfessionVM);
        }
        public async Task<IActionResult> Create()
        {
            List<CreateProfessionVM> createProfessionVM = await _context.Professions.Select(x => new CreateProfessionVM { Name = x.Name }).ToListAsync();
            return View(createProfessionVM);
        }
        [HttpPost]
        public async Task<IActionResult> Create(int Id)
        {
            List<CreateProfessionVM> createProfessionVM = await _context.Professions.Select(x => new CreateProfessionVM { Name = x.Name }).ToListAsync();
            return View(createProfessionVM);
        }

    }
}
