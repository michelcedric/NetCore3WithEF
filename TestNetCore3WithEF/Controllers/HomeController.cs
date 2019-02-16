using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestNetCore3WithEF.Data;
using TestNetCore3WithEF.Models;

namespace TestNetCore3WithEF.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _applicationDbContext;

        public HomeController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {

            _applicationDbContext.Students.Add(new Student { Name = "Cedric" });
            _applicationDbContext.SaveChanges();
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
