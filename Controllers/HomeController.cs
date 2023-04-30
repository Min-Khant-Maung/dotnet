using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SFMS.Models;
using SFMS.Models.DAO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SFMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _applicationDbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _applicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {
            ViewBag.TotalStudents = _applicationDbContext.Students.Count();
            return View();
        }
        public IActionResult Teachers()
        {
            ViewBag.Teachers = _applicationDbContext.TeachersInfo.ToList();
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Courses()
        {
            ViewBag.PromotionCourses = _applicationDbContext.Courses.ToList();
            ViewBag.PopularCourses = _applicationDbContext.Courses.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
