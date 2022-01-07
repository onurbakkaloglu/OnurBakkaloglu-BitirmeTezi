using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ÜniversiteSite.Models;

namespace ÜniversiteSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFakulteRepository _fakulteRepository;

        public HomeController(ILogger<HomeController> logger, IFakulteRepository fakulteRepository)
        {
            _logger = logger;
            _fakulteRepository = fakulteRepository;
        }

       
        public IActionResult Index()
        {
            var blogResult = _fakulteRepository.GetFakultes();
            return View(blogResult);
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
