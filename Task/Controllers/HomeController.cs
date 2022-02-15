using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Task.Domain.Model;
using Task.Infra.Repositories;
using Task.Models;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILocationRepository _locationRepository;
        public HomeController(ILogger<HomeController> logger, ILocationRepository locationRepository)
        {
            _logger = logger;
            _locationRepository = locationRepository;
        }

        public IActionResult Index()
        {
           
            return View(_locationRepository.Get());
        }


        [HttpPost]
        public ActionResult Location(Locations location)
        {
            if (ModelState.IsValid) _locationRepository.Add(location);

            return View("Index", location);
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
