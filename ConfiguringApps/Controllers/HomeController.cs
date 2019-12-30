using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ConfiguringApps.Infrastructure;
using Microsoft.Extensions.Logging;

namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService uptime;
        private ILogger<HomeController> logger;

        public HomeController(UptimeService uptime, ILogger<HomeController> log)
        {
            this.uptime = uptime;
            logger = log;
        }

        public ViewResult Index(bool throwException = false) {
            logger.LogDebug($"Handled {Request.Path} at Uptime {uptime.Uptime}");
            if (throwException) {
                throw new System.NullReferenceException();
            }
            return View(new Dictionary<string, string> {
                ["Message"] = "This is the Index action",
                ["Uptime"] = $"{uptime.Uptime}ms"
            });
        }

        public ViewResult Error() => View(nameof(Index),
            new Dictionary<string, string> {
                ["Message"] = "This is the Error action"}
            );

    }
}
