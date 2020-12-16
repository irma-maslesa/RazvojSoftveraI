using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _2_Vjezba.DBContext;
using _2_Vjezba.Models;
using Podaci.EntityModels;
using _2_Vjezba.Helper;

namespace _2_Vjezba.Controllers
{
    public class StudentPrisustvoController : Controller
    {
        MojDBC db = new MojDBC();

        public IActionResult Prikaz(int sID)
        {
            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Prijava");

            StudentPrisustvoPrikazVM model = new StudentPrisustvoPrikazVM();

            model.Prisustva = db.PrisustvoNastavi.Where(p => p.StudentID == sID)
                                            .Select(p => new StudentPrisustvoPrikazVM.Row
                                            {
                                                ID = p.ID,
                                                NazivPredmeta = p.Predmet.Naziv,
                                                Datum = p.Datum,
                                                IsPrisutan = p.IsPrisutan,
                                                Komentar = p.Komentar
                                            }).ToList();

            model.Student = db.Student.Find(sID).Ime + " " + db.Student.Find(sID).Prezime;

            return PartialView(model);
        }

        public IActionResult Uredi(int pID)
        {
            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Prijava");

            StudentPrisustvoUrediVM model = db.PrisustvoNastavi.Where(p => p.ID == pID)
                                    .Select(p => new StudentPrisustvoUrediVM
                                    {
                                        ID = p.ID,
                                        Predmet = p.Predmet.Naziv,
                                        Student = p.Student.Ime + " " + p.Student.Prezime,
                                        IsPrisutan = p.IsPrisutan,
                                        Komentar = p.Komentar
                                    }).Single();
            
            return PartialView(model);
        }
        public IActionResult Snimi(StudentPrisustvoUrediVM p)
        {
            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Prijava");

            PrisustvoNastavi prisustvo = db.PrisustvoNastavi.Find(p.ID);
            prisustvo.IsPrisutan = p.IsPrisutan;
            prisustvo.Komentar = p.Komentar;

            db.SaveChanges();
            return Redirect("/StudentPrisustvo/Prikaz?sID=" + prisustvo.StudentID);
        }
    }
}
