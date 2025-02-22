using for_new_website.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace for_new_website.Controllers
{
    public class ElseController : Controller
    {
        private readonly ILogger<ElseController> _logger;

        public ElseController(ILogger<ElseController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult SellInBulk()
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
