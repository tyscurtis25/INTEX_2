using INTEX_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using INTEX_2.Models.ViewModels;
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

        public IActionResult Accidents(int accidentFilter, int pageNum = 1)
        {
            int pageSize = 20;

            ViewBag.pageNumber = pageNum;
            ViewBag.numPages = (int) Math.Ceiling((double) repo.Crashes.Count() / pageSize);

            var x = new CrashViewModel
            {
                Crashes = repo.Crashes
                .Where(c => c.crash_severity_id == accidentFilter || accidentFilter == 0)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumCrashes = (accidentFilter == 0 ? repo.Crashes.Count() : repo.Crashes.Where(c => c.crash_severity_id == accidentFilter).Count()),
                    CrashesPerPage = pageSize,
                    CurrentPage = pageNum,
                    
                }
            };

            return View(x);
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


        public IActionResult AccidentDetails(int recordId)
        {

            var singleCrash = repo.Crashes.FirstOrDefault(x => x.crash_id == recordId);
            

            return View(singleCrash);
        }
    }
}
