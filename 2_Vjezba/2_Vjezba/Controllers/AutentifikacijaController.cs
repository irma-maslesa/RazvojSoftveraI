using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_Vjezba.Models;
using _2_Vjezba.DBContext;
using Microsoft.AspNetCore.Mvc;
using Podaci.EntityModels;
using Microsoft.AspNetCore.Http;
using _2_Vjezba.Helper;

namespace _2_Vjezba.Controllers
{
    public class AutentifikacijaController : Controller
    {
        //public static KorisnickiNalog logiraniKorisnik = null; //Svi korisnici koriste istu varijablu - NE MOZE
        
        MojDBC db = new MojDBC();

        public IActionResult Prijava()
        {
            return View();
        }

        public IActionResult ProvjeraPrijave(AutentifikacijaPrijavaVM p)
        {
            KorisnickiNalog nalog = db.KorisnickiNalog
                                    .Where(k => k.KorisnickoIme == p.KorisnickoIme && k.Lozinka == p.Lozinka)
                                    .SingleOrDefault();

            if (nalog == null)
            {
                TempData["porukaGreska"] = "Neispravno korisničko ime ili lozinka.";
                return Redirect("/Autentifikacija/Prijava");
            }

            HttpContext.SetLogiraniKorisnik(nalog);
            return Redirect("/");
        }

        public IActionResult Odjava()
        {
            HttpContext.SetLogiraniKorisnik(null);

            return Redirect("/Autentifikacija/Prijava");
        }
    }
}
