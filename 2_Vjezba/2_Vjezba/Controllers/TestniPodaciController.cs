using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_Vjezba.Helper;
using Microsoft.AspNetCore.Mvc;
using Podaci.DBContext;

namespace _2_Vjezba.Controllers
{
    public class TestniPodaciController : Controller
    {
        public IActionResult GenerisiPodatke()
        {
            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Prijava");

            DbInicijalizator.Generisi();

            return View();
        }
    }
}
