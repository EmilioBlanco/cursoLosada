using c11eindividual.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace c11eindividual.BD
{
    public class ApuestasDB: DbContext
    {

        public DbSet<Cliente> listClientes { get; set; }
        public DbSet<Apuesta> listApuestas { get; set; }

        public ApuestasDB()
        {
            Database.SetInitializer(new ApuestasDBInitializer());
        }
        
    }
}