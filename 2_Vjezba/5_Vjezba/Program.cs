using _2_Vjezba.DBContext;
using _2_Vjezba.EntityModels;
using System;

namespace _5_Vjezba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi naziv općine: ");
            Opcina opcina = new Opcina { Naziv = Console.ReadLine() };

            MojDBC db = new MojDBC();

            db.Opcina.Add(opcina);
            db.SaveChanges();
        }
    }
}
