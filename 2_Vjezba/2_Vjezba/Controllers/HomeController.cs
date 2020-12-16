using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _2_Vjezba.Helper;
using _2_Vjezba.Models;

namespace _2_Vjezba.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //STATIC VARIJABLA
            //if (AutentifikacijaController.logiraniKorisnik == null)
            //    return Redirect("/Autentifikacija/Prijava");

            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Prijava");

            return View();
        }

        public IActionResult Privacy()
        {
            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Prijava");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Prijava");

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
