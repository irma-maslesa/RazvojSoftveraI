using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2_Vjezba.Models
{
    public class StudentPrisustvoVM
    {
        public class Row
        {
            public string NazivPredmeta { get; set; }
            public DateTime Datum { get; set; }
        }

        public List<Row> Prisustva { get; set; }
        public string Student { get; set; }
    }
}
