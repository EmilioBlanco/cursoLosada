using c11eindividual.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace c11eindividual.BD
{
    public class CorreoDBInitializer : DropCreateDatabaseAlways<CorreoDB>
    {
        protected override void Seed(CorreoDB context)
        {
            IList<Mensaje> defaultMensajes = new List<Mensaje>();
            IList<Usuario> defaultUsuarios = new List<Usuario>();
           

            defaultUsuarios.Add(new Usuario() { nombre = "Emilio",Administrador =true });
            defaultUsuarios.Add(new Usuario() { nombre = "Juan", Administrador = true });
            defaultUsuarios.Add(new Usuario() { nombre = "Maria", Administrador = false });
            defaultUsuarios.Add(new Usuario() { nombre = "Elisabet", Administrador = true });
            defaultUsuarios.Add(new Usuario() { nombre = "Eduardo", Administrador = false });



            defaultMensajes.Add(new Mensaje() { asunto = "Mail Bienvenida", emisor = 1, receptor = 5,bandeja=true,cuerpo= "Te damos la bienvenida al servicio de mensajeria. \n Servicio de administración ", fecha = new DateTime(2016, 9, 26, 17, 29, 27) });
            defaultMensajes.Add(new Mensaje() { asunto = "Prueba de correo", emisor = 3, receptor = 5, bandeja = true, cuerpo = " Hola esto es un correo \n María DelaÓ ", fecha = new DateTime(2016, 9, 27,10, 9, 13) });
            defaultMensajes.Add(new Mensaje() {asunto="Mail cambio de Rol", emisor = 2, receptor = 4, bandeja = true, cuerpo = " Para seguir creciendo como correo prioritario de nuestros usuarios, ha sido ascendido a administrador de la página.\n Losadianos del séptimo día ", fecha = new DateTime(2016, 9, 27, 10, 9, 13) });


            foreach (Usuario u in defaultUsuarios)
            {
                context.Usuarios.Add(u);
                context.SaveChanges();
            }

            foreach(Mensaje m in defaultMensajes)
            {
                context.Mensajes.Add(m);
                context.SaveChanges();
            }

            base.Seed(context);
        }
    }
}