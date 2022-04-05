using INTEX_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace INTEX_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICrashRepository repo { get; set; }

        public HomeController(ILogger<HomeController> logger, ICrashRepository temp)
        {
            _logger = logger;
            repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AccidentSummary(int crashSeverity)
        {
            ViewBag.Severity = crashSeverity;
            var blah = repo.Crashes
                .Take(100)
                .ToList();
                //.Where(c => c.crash_id == 10805517);

            return View(blah);
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
