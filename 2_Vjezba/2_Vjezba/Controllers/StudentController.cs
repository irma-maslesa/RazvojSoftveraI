using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_Vjezba.DBContext;
using _2_Vjezba.EntityModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _2_Vjezba.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Prikaz(string filter)
        {
            MojDBC db = new MojDBC();

            ViewData["Studenti"] = db.Student //SELECT * FROM Student
                                        .Where(s => filter == null || filter == "" ||       //WHERE ...
                                               (s.BrojIndeksa.ToLower().StartsWith(filter.ToLower()) ||
                                                (s.Ime + " " + s.Prezime).ToLower().StartsWith(filter.ToLower()) ||
                                                 (s.Prezime + " " + s.Ime).ToLower().StartsWith(filter.ToLower())))
                                        .Include(navigationPropertyPath: s => s.OpcinaRodjenja) //JOIN Opcina ON ...
                                        .Include(navigationPropertyPath: s => s.OpcinaPrebivalista) //JOIN Opcina ON ...
                                        
                                        .ToList();
            ViewData["Filter"] = filter;

            return View();
        }

        public IActionResult Dodaj()
        {
            MojDBC db = new MojDBC();
            ViewData["Opcine"] = db.Opcina
                                    .OrderBy(a => a.Naziv)
                                    .ToList();

            return View();
        }

        public IActionResult Snimi(string BrojIndeksa, string Ime, string Prezime, int OpcinaRodjenjaID, int OpcinaPrebivalistaID)
        {
            Student student = new Student
            {
                BrojIndeksa = BrojIndeksa,
                Ime = Ime,
                Prezime = Prezime,
                OpcinaRodjenjaID = OpcinaRodjenjaID,
                OpcinaPrebivalistaID = OpcinaPrebivalistaID
            };

            MojDBC db = new MojDBC();
            db.Add(student);
            db.SaveChanges(); //INSERT INTO Student VALUE ...

            //TempData se moze koristiti za prebacivanje podataka iz akcije u akciju ili iz akcije u view.
            //Kod TempData podaci ostaju sačuvani i kada se radi redirekcija, a kod ViewData ne.
            //TempData["Student"] = student;

            return Redirect(url: "/Student/DodajPoruka?sID=" + student.ID);
        }

        public IActionResult DodajPoruka(int sID)
        {
            //Student s = (Student) TempData["Student"];
            MojDBC db = new MojDBC();
            ViewData["Student"] = db.Student.Find(sID);

            return View();
        }

        public IActionResult Obrisi(int sID)
        {
            MojDBC db = new MojDBC();
            Student s = db.Student.Find(sID);

            db.Remove(s);
            db.SaveChanges(); //DELETE Student WHERE ID = ...

            TempData["StudentIme"] = s.Ime;
            TempData["StudentPrezime"] = s.Prezime;
            TempData["StudentBrojIndeksa"] = s.BrojIndeksa;

            return Redirect(url: "/Student/ObrisiPoruka");
        }

        public IActionResult ObrisiPoruka()
        {
            return View();
        }
    }
}
