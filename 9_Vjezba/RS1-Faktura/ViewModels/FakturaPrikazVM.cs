using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Faktura.ViewModels
{
    public class FakturaPrikazVM
    {
        public class Row
        {
            public int ID { get; set; }
            public DateTime Datum { get; set; }
            public string Klijent { get; set; }
        }

        public List<Row> Fakture { get; set; }
    }
}
