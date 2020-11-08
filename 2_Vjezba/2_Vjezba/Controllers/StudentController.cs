using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_Vjezba.DBContext;
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
    }
}
