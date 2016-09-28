using c11eindividual.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Entity<Mensaje>()
            //    .HasOptional<Usuario>(s => s.eUsuario)
            //    .WithMany()
            //    .HasForeignKey(s=> s.EmisorID)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Mensaje>()
            //    .HasOptional<Usuario>(s => s.rUsuario)
            //    .WithMany()
            //    .HasForeignKey(s => s.ReceptorID)
            //    .WillCascadeOnDelete(false);
        }
    }
}