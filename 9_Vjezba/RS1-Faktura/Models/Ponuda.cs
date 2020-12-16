using System;

namespace RS1.Ispit.Web.Models
{
   
    public class Ponuda
    {
        public int Id { get; set; }

        public virtual Klijent Klijent { get; set; }
        public int KlijentId { get; set; }

        public DateTime Datum { get; set; }
    }
}
