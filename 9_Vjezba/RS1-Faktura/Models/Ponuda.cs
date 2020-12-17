using System;

namespace RS1_Faktura.Models
{

    public class Ponuda
    {
        public int Id { get; set; }

        public virtual Klijent Klijent { get; set; }
        public int KlijentId { get; set; }

        public DateTime Datum { get; set; }

        public int? FakturaID { get; set; }
        public Faktura Faktura { get; set; }
    }
}
