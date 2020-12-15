using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Podaci.DBContext;

namespace _2_Vjezba.Controllers
{
    public class TestniPodaciController : Controller
    {
        public IActionResult GenerisiPodatke()
        {
            DbInicijalizator.Generisi();

            return View();
        }
    }
}
