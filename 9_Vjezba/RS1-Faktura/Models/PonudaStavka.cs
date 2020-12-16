using System;

namespace RS1.Ispit.Web.Models
{
    public class PonudaStavka
    {
        public int Id { get; set; }

        public virtual Proizvod Proizvod { get; set; }
        public int ProizvodId { get; set; }

        public virtual Ponuda Ponuda { get; set; }
        public int PonudaId { get; set; }
    

        public float Kolicina { get; set; }
        public float PopustProcenat { get; set; }
    }
}
