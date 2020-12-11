using _2_Vjezba.Helper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _2_Vjezba.Models
{
    public class StudentDodajUrediVM
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojIndeksa { get; set; }
        public int OpcinaRodjenjaID { get; set; }
        public int OpcinaPrebivalistaID { get; set; }
        //public List<ComboBoxVM> Opcine;
        public List<SelectListItem> Opcine; //da bi se moglo koristiti asp-items
    }
}
