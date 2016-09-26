using c11eindividual.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace c11eindividual.BD
{
    public class ApuestasDBInitializer : DropCreateDatabaseAlways<ApuestasDB>
    {
        protected override void Seed(ApuestasDB context)
        {
            IList<Cliente> defaultClientes = new List<Cliente>();
            IList<Apuesta> defaultApuestas = new List<Apuesta>();

            defaultClientes.Add(new Cliente() { nombre = "Emilio", apellidos = "Blanco Villegas", dni = "72181506P", direccion = "C/Ría de Solía nº5 Ch.27", fechaAlta = DateTime.Now.ToString() });
            defaultClientes.Add(new Cliente() { nombre = "Adrián", apellidos = "González García", dni = "72855878E", direccion = "C/Vista Bahía nº3 2ºD", fechaAlta = DateTime.Now.ToString() });
            defaultClientes.Add(new Cliente() { nombre = "Sergio", apellidos = "Gutierrez Pérez", dni = "75857412T", direccion = "C/Consolación nº3 7I", fechaAlta = DateTime.Now.ToString() });
            defaultClientes.Add(new Cliente() { nombre = "Fernando", apellidos = "Vallejo García", dni = "13478549D", direccion = "C/Amargura nº2 9ºA", fechaAlta = DateTime.Now.ToString() });

            defaultApuestas.Add(new Apuesta() { cantidad = 200, fechaApuesta = DateTime.Now.ToString(), textoUsuario = "Futbol club balón pinchao", UsrID = 2 });
            defaultApuestas.Add(new Apuesta() { cantidad = 1500, fechaApuesta = DateTime.Now.ToString(), textoUsuario = "Giants Underdoges", UsrID = 3 });
            defaultApuestas.Add(new Apuesta() { cantidad = 348, fechaApuesta = DateTime.Now.ToString(), textoUsuario = "Narnia FC", UsrID = 1 });

            foreach (Cliente c in defaultClientes)
            {
                context.listClientes.Add(c);
                context.SaveChanges();
            }

            foreach(Apuesta a in defaultApuestas)
            {
                context.listApuestas.Add(a);
                context.SaveChanges();
            }

            base.Seed(context);
        }
    }
}