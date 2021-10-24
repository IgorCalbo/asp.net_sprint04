using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sharks.Sprint04.Web.Models;
using Sharks.Sprint04.Web.Persistencias;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sharks.Sprint04.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private SharksContext _context;

        public HomeController(ILogger<HomeController> logger, SharksContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["qtd"] = _context.Usuarios.Count();
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
