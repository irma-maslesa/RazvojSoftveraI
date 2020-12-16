using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2_Vjezba.Models
{
    public class StudentPrisustvoPrikazVM
    {
        public class Row
        {
            public int ID { get; set; }
            public string NazivPredmeta { get; set; }
            public DateTime Datum { get; set; }
            public bool IsPrisutan { get; set; }
            public string Komentar { get; set; }
        }

        public List<Row> Prisustva { get; set; }
        public string Student { get; set; }
    }
}
