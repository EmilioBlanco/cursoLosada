using c11eindividual.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace c11eindividual.BD
{
    public class CorreoDB: DbContext
    {

        public DbSet<Mensaje> Mensajes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    

        public CorreoDB()
        {
            Database.SetInitializer(new CorreoDBInitializer());
        }
        
    }
}