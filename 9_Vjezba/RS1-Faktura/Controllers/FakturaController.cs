using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            model.Ponude = db.Ponuda.Where(p => p.FakturaID == null) //Sklonjeno da ne dodajem stalno
                        .Select(p => new SelectListItem
                        {
                            Text = p.Klijent.ImePrezime + " - " + p.Datum.ToString("MM.dd.yyyy"),
                            Value = p.Id.ToString()
                        }).ToList();
            model.Klijenti = db.Klijent
                            .Select(k => new SelectListItem
                            {
                                Text = k.ImePrezime,
                                Value = k.Id.ToString()
                            }).ToList();
            model.Datum = DateTime.Now;

            return View(model);
        }

        public IActionResult Snimi(FakturaDodajVM f)
        {
            Faktura faktura = new Faktura { KlijentId = f.KlijentID, Datum = f.Datum };
            db.Faktura.Add(faktura);

            if (f.PonudaID != null)
            {
                Ponuda ponuda = db.Ponuda.Find(f.PonudaID);
                ponuda.Faktura = faktura;

                List<PonudaStavka> ponudaStavke = db.PonudaStavka.Where(ps => ps.PonudaId == ponuda.Id).ToList();

                ponudaStavke.ForEach(ps =>
                {
                    db.FakturaStavka.Add(new FakturaStavka
                    {
                        Faktura = faktura,
                        ProizvodId = ps.ProizvodId,
                        Kolicina = ps.Kolicina,
                        PopustProcenat = 5
                    });
                });

            }

            db.SaveChanges();

            return Redirect("/Faktura/Index");
        }

        public IActionResult Obrisi(int fID)
        {

            //db.Ponuda.RemoveRange(db.Ponuda.Where(p => p.FakturaID == fID).ToList());
            //ili
            List<Ponuda> ponude = db.Ponuda.Where(p => p.FakturaID == fID).ToList();
            ponude.ForEach(p => { p.FakturaID = null; });

            db.Faktura.Remove(db.Faktura.Find(fID));
            db.SaveChanges();

            return Redirect("/Faktura/Index");
        }

        public IActionResult Detalji(int fID)
        {
            FakturaDetaljiVM model = db.Faktura.Where(f => f.Id == fID)
                                        .Select(f => new FakturaDetaljiVM
                                        {
                                            Klijent = f.Klijent.ImePrezime,
                                            Datum = f.Datum,
                                            ID = f.Id
                                        }).FirstOrDefault();

            return View(model);
        }
    }
}