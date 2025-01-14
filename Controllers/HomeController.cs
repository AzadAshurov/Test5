using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Testgithub2.Models;

namespace Testgithub2.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

    }
}
