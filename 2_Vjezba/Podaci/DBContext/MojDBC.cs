using _2_Vjezba.EntityModels;
using Microsoft.EntityFrameworkCore;
using Podaci.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2_Vjezba.DBContext
{
    public class MojDBC : DbContext
    {
        public DbSet<Opcina> Opcina { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Predmet> Predmet { get; set; }
        public DbSet<Ocjena> Ocjene { get; set; }
        public DbSet<PrisustvoNastavi> PrisustvoNastavi { get; set; }
        public DbSet<KorisnickiNalog> KorisnickiNalog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server = localhost;
                                                            Database = RSI_V8;
                                                            Trusted_Connection = True;
                                                            MultipleActiveResultSets = True;");
        }
    }
}
