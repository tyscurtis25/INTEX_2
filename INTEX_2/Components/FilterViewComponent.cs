using INTEX_2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEX_2.Components
{
    public class FilterViewComponent : ViewComponent
    {
        private ICrashRepository repo { get; set; }
        public FilterViewComponent(ICrashRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedFilter = RouteData?.Values["accidentFilter"];

            var severity = repo.Crashes
                .Select(x => x.crash_severity_id)
                .Distinct()
                .OrderBy(x => x);

            return View(severity);
        }
    }
}
