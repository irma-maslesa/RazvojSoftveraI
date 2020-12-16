using Microsoft.EntityFrameworkCore;
using RS1_Faktura.Models;

namespace RS1_Faktura.EF
{
    public class MojContext : DbContext
    {
        public MojContext()
        {

        }

        public DbSet<AkcijskiKatalog> AkcijskiKatalog { get; set; }
        public DbSet<KatalogStavka> KatalogStavka { get; set; }
        public DbSet<Klijent> Klijent { get; set; }
        public DbSet<Ponuda> Ponuda { get; set; }
        public DbSet<PonudaStavka> PonudaStavka { get; set; }
        public DbSet<Proizvod> Proizvod { get; set; }
        public DbSet<Faktura> Faktura { get; set; }
        public DbSet<FakturaStavka> FakturaStavka { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"	Server=10.10.10.18;
            //                            	Database=_ovdje_upisati_broj_indeksa;
            //                                Trusted_Connection=false;
            //                                User ID=sa;
            //                                Password=test;
            //                                MultipleActiveResultSets=true;     ");

            optionsBuilder.UseSqlServer(@"	Server= localhost;
                                        	Database=RSI_V9;
                                            Trusted_Connection=true;
                                            MultipleActiveResultSets = true; ");
        }

    }
}
