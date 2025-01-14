using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Testgithub2.DAL;
using Testgithub2.Models;
using Testgithub2.ViewModels;


namespace Testgithub2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {
            List<Employee> employee = await _context.Employees.Include(c => c.Profession).ToListAsync();
            var professions = await _context.Professions.Include(c => c.Employees).ToListAsync();
            HomeVM homeVM = new HomeVM()
            {
               Employees =  employee,
               Professions =  professions
            };
            return View(homeVM);
        }

    }
}
