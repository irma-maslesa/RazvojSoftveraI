using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2_Vjezba.EntityModels
{
    public class Student
    {
        public int ID { get; set; }
        public string BrojIndeksa { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public int OpcinaRodjenjaID { get; set; }
        public Opcina OpcinaRodjenja { get; set; }

        public int OpcinaPrebivalistaID { get; set; }
        public Opcina OpcinaPrebivalista { get; set; }
    }
}
