using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Faktura.Models
{
    public class FakturaStavka
    {
        public int Id { get; set; }

        public virtual Proizvod Proizvod { get; set; }
        public int ProizvodId { get; set; }

        public virtual Faktura Faktura { get; set; }
        public int FakturaId { get; set; }


        public float Kolicina { get; set; }
        public float PopustProcenat { get; set; }
    }
}
