using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_Vjezba.EntityModels;

namespace _2_Vjezba.Models
{

    public class StudentPrikazVM
    {
        public class Row
        {
            public int ID { get; set; }
            public string BrojIndeksa { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public string OpcinaRodjenja { get; set; }
            public string OpcinaPrebivalista { get; set; }

            public Row()
            {
                
            }
        }

        public List<Row> studenti;
        public string filter;
    }
}

