using _2_Vjezba.EntityModels;
using Microsoft.EntityFrameworkCore;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server = localhost;
                                                            Database = RSI_V2;
                                                            Trusted_Connection = True;
                                                            MultipleActiveResultSets = True;");
        }
    }
}
