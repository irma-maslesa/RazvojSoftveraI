using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Faktura.Models
{
    public class Faktura
    {
        public int Id { get; set; }

        public virtual Klijent Klijent { get; set; }
        public int KlijentId { get; set; }

        public DateTime Datum { get; set; }
    }
}
