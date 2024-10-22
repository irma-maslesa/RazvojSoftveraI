﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_Vjezba.DBContext;
using _2_Vjezba.EntityModels;
using _2_Vjezba.Helper;
using _2_Vjezba.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace _2_Vjezba.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Prikaz(string filter)
        {
            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Prijava");

            MojDBC db = new MojDBC();

            StudentPrikazVM model = new StudentPrikazVM();

            List<StudentPrikazVM.Row> studenti = db.Student //SELECT * FROM Student
                           .Where(s => filter == null || filter == "" ||       //WHERE ...
                                 (s.BrojIndeksa.ToLower().StartsWith(filter.ToLower()) ||
                                 (s.Ime + " " + s.Prezime).ToLower().StartsWith(filter.ToLower()) ||
                                 (s.Prezime + " " + s.Ime).ToLower().StartsWith(filter.ToLower())))
                           .Select(s => new StudentPrikazVM.Row
                           {
                               ID = s.ID,
                               BrojIndeksa = s.BrojIndeksa,
                               Ime = s.Ime,
                               Prezime = s.Prezime,
                               OpcinaRodjenja = s.OpcinaRodjenja.Naziv,
                               OpcinaPrebivalista = s.OpcinaPrebivalista.Naziv,
                           })
                           .ToList();

            model.studenti = studenti;
            model.filter = filter;

            return View(model);
        }

        public IActionResult DodajUredi(int sID)
        {
            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Prijava");

            MojDBC db = new MojDBC();

            List<SelectListItem> opcine = db.Opcina
                                        .OrderBy(o => o.Naziv)
                                        .Select(o => new SelectListItem
                                        {
                                            Text = o.Naziv,
                                            Value = o.ID.ToString()
                                        })
                                        .ToList();

            StudentDodajUrediVM student = sID == 0 ?
                                    new StudentDodajUrediVM() :
                                    db.Student.Where(s => sID == s.ID)
                                    .Select(s => new StudentDodajUrediVM
                                    {
                                        ID = s.ID,
                                        Ime = s.Ime,
                                        Prezime = s.Prezime,
                                        BrojIndeksa = s.BrojIndeksa,
                                        OpcinaPrebivalistaID = s.OpcinaPrebivalistaID,
                                        OpcinaRodjenjaID = s.OpcinaRodjenjaID
                                    })
                                    .Single();
            student.Opcine = opcine;
            return View(student);
        }

        public IActionResult Snimi(StudentDodajUrediVM s)
        {
            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Prijava");

            MojDBC db = new MojDBC();

            Student student;

            if (s.ID == 0)
            {
                student = new Student();
                db.Add(student);

                TempData["Poruka"] = "Uspješno ste dodali studenta ";
            }
            else
            {
                student = db.Student.Find(s.ID);

                TempData["Poruka"] = "Uspješno ste uredili studenta ";
            }

            student.BrojIndeksa = s.BrojIndeksa;
            student.Ime = s.Ime;
            student.Prezime = s.Prezime;
            student.OpcinaRodjenjaID = s.OpcinaRodjenjaID;
            student.OpcinaPrebivalistaID = s.OpcinaPrebivalistaID;

            db.SaveChanges(); //INSERT INTO Student VALUE ...

            TempData["Poruka"] += $"{student.Ime} {student.Prezime} ({student.BrojIndeksa})";
            return Redirect(url: "/Student/Poruka?sID=" + student.ID);
        }

        public IActionResult Poruka(int sID)
        {
            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Prijava");

            return View();
        }

        public IActionResult Obrisi(int sID)
        {
            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Prijava");

            MojDBC db = new MojDBC();
            Student s = db.Student.Find(sID);

            db.Remove(s);
            db.SaveChanges(); //DELETE Student WHERE ID = ...

            TempData["Poruka"] = $"Uspješno ste obrisali studenta {s.Ime} {s.Prezime} ({s.BrojIndeksa})";

            return Redirect(url: "/Student/Poruka");
        }
    }
}
