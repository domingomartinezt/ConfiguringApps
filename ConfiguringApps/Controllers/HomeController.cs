using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ConfiguringApps.Infrastructure;

namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService uptime;

        public HomeController(UptimeService uptime)
        {
            this.uptime = uptime;
        }

        public ViewResult Index() => View(new Dictionary<string, string>
        {
            ["Message"] = "This is the Index action",
            ["Uptime"] = $"{uptime.Uptime}ms"
        });

    }
}
