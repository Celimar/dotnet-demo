using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using teste01.Domains.Services;
using teste01.Models;

namespace teste01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFerramentaService _ferramentaService;

        public HomeController(
            ILogger<HomeController> logger, 
            IFerramentaService ferramentaService)
        {
            _logger = logger;
            _ferramentaService = ferramentaService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Ferramenta()
        {
            
            _ferramentaService.AddFerramenta(new Domains.Models.FerramentaModel {
                Id = 1,
                Nome = "Martelo"
            });

            var result = _ferramentaService.GetAllFerramentaModel();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
