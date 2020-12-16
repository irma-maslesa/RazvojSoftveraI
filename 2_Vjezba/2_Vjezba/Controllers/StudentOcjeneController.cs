using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_Vjezba.DBContext;
using _2_Vjezba.Helper;
using _2_Vjezba.Models;
using Microsoft.AspNetCore.Mvc;
using Podaci.EntityModels;

namespace _2_Vjezba.Controllers
{
    public class StudentOcjeneController : Controller
    {
        MojDBC db = new MojDBC();

        public IActionResult Prikaz(int sID)
        {
            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Prijava");

            List<StudentOcjenePrikazVM> ocjene = db.Ocjene.Where(o => o.StudentID == sID)
                                            .Select(o => new StudentOcjenePrikazVM
                                            {
                                                ID = o.ID,
                                                NazivPredmeta = o.Predmet.Naziv,
                                                OcjenaBroj = o.OcjenaBroj,
                                                Datum = o.Datum
                                            }).ToList();
            return PartialView(ocjene);
        }
        public IActionResult Uredi(int oID)
        {
            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Prijava");

            StudentOcjeneUrediVM model = db.Ocjene.Where(o => o.ID == oID)
                            .Select(o => new StudentOcjeneUrediVM
                            {
                                ID = o.ID,
                                Predmet = o.Predmet.Naziv,
                                Ocjena = o.OcjenaBroj,
                                Student = o.Student.Ime + " " + o.Student.Prezime
                            })
                            .Single();

           

            return PartialView(model);
        }

        public IActionResult Snimi(StudentOcjeneUrediVM o)
        {
            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Prijava");

            Ocjena ocjena = db.Ocjene.Find(o.ID);
            ocjena.OcjenaBroj = o.Ocjena;

            db.SaveChanges();

            return Redirect("/StudentOcjene/Prikaz?sID=" + ocjena.StudentID);
        }

    }
}
