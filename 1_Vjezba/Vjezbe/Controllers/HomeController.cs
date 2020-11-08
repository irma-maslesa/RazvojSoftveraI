using Microsoft.AspNetCore.Mvc;
using Vjezbe.Models;

namespace Vjezbe.Controllers
{
    public class CalculatorController : Controller
    {
        public string Proba()
        {
            return "Oks je sve, no worry!";
        }

        public string Saberi(int a, int b)
        {
            return $"Jos je sve oks, a {a} + {b} je {a + b}";
        }

        public ViewResult HTMLSaberi(int a, int b)
        {
            return View("HTMLSaberiView", a+b);
        }

        public ViewResult SumaOpsega(int a, int b)
        {
            OpsegParametarModel p = new OpsegParametarModel { suma = 0, pocetak = a, kraj = b };

            for (int i = a; i < b; i++)
                p.suma += i;

            return View("SumaOpsegaView", p);
        }
    }
}
