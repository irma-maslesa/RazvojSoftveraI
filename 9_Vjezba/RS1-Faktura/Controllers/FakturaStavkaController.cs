using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RS1_Faktura.EF;
using RS1_Faktura.ViewModels;

namespace RS1_Faktura.Controllers
{
    public class FakturaStavkaController : Controller
    {
        MojContext db = new MojContext();
        public IActionResult Index(int fID)
        {
            FakturaStavkaPrikazVM model = new FakturaStavkaPrikazVM();

            model.Stavke = db.FakturaStavka.Where(fs => fs.FakturaId == fID)
                        .Select(fs => new FakturaStavkaPrikazVM.Row
                        {
                            ID = fs.Id,
                            Kolicina = fs.Kolicina,
                            Proizvod = fs.Proizvod.Naziv,
                            Popust = fs.PopustProcenat,
                            Cijena = fs.Proizvod.Cijena,
                            Iznos = fs.Kolicina * fs.Proizvod.Cijena * (1- fs.PopustProcenat/100)
                        }).ToList();

            return PartialView(model);
        }
    }
}
