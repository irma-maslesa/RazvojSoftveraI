using System;

namespace RS1_Faktura.Models
{
    public class KatalogStavka
    {
        public int Id { get; set; }

        public virtual Proizvod Proizvod { get; set; }
        public int ProizvodId { get; set; }

        public virtual AkcijskiKatalog AkcijskiKatalog { get; set; }
        public int AkcijskiKatalogId { get; set; }

        public float PopustProcenat { get; set; }
    }
}
