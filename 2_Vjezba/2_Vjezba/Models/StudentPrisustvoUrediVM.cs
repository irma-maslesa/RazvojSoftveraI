using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2_Vjezba.Models
{
    public class StudentPrisustvoUrediVM
    {
        public int ID { get; set; }
        public string Student { get; set; }
        public string Predmet { get; set; }
        public bool IsPrisutan { get; set; }
        public string Komentar { get; set; }
    }
}
