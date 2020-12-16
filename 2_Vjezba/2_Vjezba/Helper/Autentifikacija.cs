using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Podaci.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2_Vjezba.Helper
{
    public static class Autentifikacija
    {
        public static KorisnickiNalog GetLogiraniKorisnik(this HttpContext kontekst)
        {
            return kontekst.Session.Get<KorisnickiNalog>("logiraniKorisnik");
        }
        public static void SetLogiraniKorisnik(this HttpContext kontekst, KorisnickiNalog nalog)
        {
            kontekst.Session.Set<KorisnickiNalog>("logiraniKorisnik", nalog);
        }
    }
}
