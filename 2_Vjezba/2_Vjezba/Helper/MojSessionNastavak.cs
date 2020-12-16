using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2_Vjezba.Helper
{
    public static class MojSessionNastavak
    {
        public static void Set<T>(this ISession sesija, string kljuc, T vrijednost)
        {
            sesija.SetString(kljuc, JsonConvert.SerializeObject(vrijednost));
        }

        public static T Get<T>(this ISession sesija, string kljuc)
        {
            var vrijednost = sesija.GetString(kljuc);

            return vrijednost == null ? default(T) : JsonConvert.DeserializeObject<T>(vrijednost);
        }
    }
}
