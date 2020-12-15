using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2_Vjezba.Models
{
    public class StudentOcjenePrikazVM
    {
        public int ID { get; set; }
        public string NazivPredmeta { get; set; }
        public int OcjenaBroj { get; set; }
        public DateTime Datum { get; set; }
    }
}
