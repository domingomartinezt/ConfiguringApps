using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index() => View(new Dictionary<string, string> {
            ["Message"] = "This is the Index action"});

    }
}
