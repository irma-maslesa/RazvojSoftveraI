using _2_Vjezba.DBContext;
using _2_Vjezba.EntityModels;
using Podaci.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Podaci.DBContext
{
    public class DbInicijalizator
    {
        private static Random random = new Random();

        public static string GetRandomString(int length = 3)
        {
            return Guid.NewGuid().ToString().Substring(0, length);
        }

        public static int GetRandomInt(int max)
        {
            return random.Next() % max;
        }
        public static void Generisi()
        {
            MojDBC db = new MojDBC();

            if (db.Student.Any())
                return;

            db.KorisnickiNalog.Add(new KorisnickiNalog { KorisnickoIme = "admin", Lozinka = "admin" });
            db.SaveChanges();

            List<Opcina> opcine = new List<Opcina>();
            List<Predmet> predmeti = new List<Predmet>();
            List<Student> studenti = new List<Student>();

            for (int i = 0; i < 10; i++)
            {
                opcine.Add(new Opcina { Naziv = "Opcina " + GetRandomString() });
                predmeti.Add(new Predmet { Naziv = "Predmet " + GetRandomString() });
            }

            for (int i = 0; i < 30; i++)
            {
                studenti.Add(new Student
                {
                    BrojIndeksa = GetRandomString(5),
                    Ime = GetRandomString(4),
                    Prezime = GetRandomString(8),
                    OpcinaRodjenja = opcine[GetRandomInt(10)],
                    OpcinaPrebivalista = opcine[GetRandomInt(10)]
                });
            }

            for (int i = 0; i < 50; i++)
            {
                db.Add(new Ocjena
                {
                    Datum = DateTime.Now,
                    OcjenaBroj = GetRandomInt(5) + 6,
                    Predmet = predmeti[GetRandomInt(10)],
                    Student = studenti[GetRandomInt(30)]
                });
            }

            db.AddRange(opcine);
            db.AddRange(predmeti);
            db.AddRange(studenti);

            db.SaveChanges();

            foreach (Student x in db.Student)
            {
                db.PrisustvoNastavi.Add(new PrisustvoNastavi
                {
                    Datum = DateTime.Now,
                    Predmet = predmeti[GetRandomInt(10)],
                    IsPrisutan = GetRandomInt(2) > 0 ? true : false,
                    Komentar = GetRandomString(20),
                    Student = x
                });
            }

            db.SaveChanges();
        }
    }
}
