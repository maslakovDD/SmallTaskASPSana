using Microsoft.AspNetCore.Mvc;
using SmallTask.Models;
using System.Diagnostics;
using System.Text.Encodings.Web;

namespace SmallTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name)
        {
            ViewData["Name"] = name;
            return View();
        }
    }
}