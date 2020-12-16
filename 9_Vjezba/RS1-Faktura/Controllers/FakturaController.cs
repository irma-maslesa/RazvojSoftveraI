using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RS1_Faktura.EF;
using RS1_Faktura.Models;
using RS1_Faktura.ViewModels;

namespace RS1_Faktura.Controllers
{
    public class FakturaController : Controller
    {
        MojContext db = new MojContext();

        public IActionResult Index()
        {
            FakturaPrikazVM model = new FakturaPrikazVM
            {
                Fakture = db.Faktura
                          .Select(f => new FakturaPrikazVM.Row
                          {
                              ID = f.Id,
                              Datum = f.Datum,
                              Klijent = f.Klijent.ImePrezime
                          }).ToList()
            };

            return View(model);
        }

        public IActionResult Dodaj()
        {
            FakturaDodajVM model = new FakturaDodajVM();

            return View(model);
        }

        public IActionResult Snimi(FakturaDodajVM f)
        {
            db.Faktura.Add(new Faktura
            {
                KlijentId = f.KlijentID,
                Datum = f.Datum
            });
            db.SaveChanges();

            return Redirect("/Faktura/Index");
        }
    }
}