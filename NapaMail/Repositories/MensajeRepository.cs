using c11eindividual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using c11eindividual.BD;
using System.Threading;
using System.Data.Entity;

namespace c11eindividual.Repositories
{
    public class MensajeRepository : IMensajeRepository
    {
        public MensajeRepository() { }

        public List<Mensaje> Todos(int _id)
        {
            using (var napaMailDB = new CorreoDB())
            {
                List<Mensaje> aRetornar = new List<Mensaje>();

                foreach (Mensaje ap in napaMailDB.Mensajes)
                {
                    Mensaje ap2 = napaMailDB.Mensajes
                        .Include(a => a.eUsuario)
                        .Include(a => a.rUsuario)
                        .Where(a2 => a2.id == ap.id)
                        .Where(a2 => a2.emisor == _id || a2.receptor == _id)
                        .FirstOrDefault();
                    aRetornar.Add(ap2);

                }
                return aRetornar;
            }
        }
        public List<Mensaje> Entrada(int _id)
        {
            using (var napaMailDB = new CorreoDB())
            {
                List<Mensaje> aRetornar = new List<Mensaje>();

                foreach (Mensaje ap in napaMailDB.Mensajes)
                {
                    Mensaje ap2 = napaMailDB.Mensajes
                        .Include(a => a.eUsuario)
                        .Include(a => a.rUsuario)
                        .Where(a2 => a2.id == ap.id)
                        .Where(a2 => a2.receptor == _id)
                        .Where(a2 => a2.bandeja == true)
                        .FirstOrDefault();
                    aRetornar.Add(ap2);

                }
                return aRetornar;
            }
        }
        public List<Mensaje> Salida(int _id)
        {
            using (var napaMailDB = new CorreoDB())
            {
                List<Mensaje> aRetornar = new List<Mensaje>();

                foreach (Mensaje ap in napaMailDB.Mensajes)
                {
                    Mensaje ap2 = napaMailDB.Mensajes
                        .Include(a => a.eUsuario)
                        .Include(a => a.rUsuario)
                        .Where(a2 => a2.id == ap.id)
                        .Where(a2 => a2.emisor == _id)
                        .Where(a2 => a2.bandeja == true)
                        .FirstOrDefault();
                    aRetornar.Add(ap2);

                }
                return aRetornar;
            }
        }
        public List<Mensaje> Papelera(int _id)
        {
            using (var napaMailDB = new CorreoDB())
            {
                List<Mensaje> aRetornar = new List<Mensaje>();

                foreach (Mensaje ap in napaMailDB.Mensajes)
                {
                    Mensaje ap2 = napaMailDB.Mensajes
                        .Include(a => a.eUsuario)
                        .Include(a => a.rUsuario)
                        .Where(a2 => a2.id == ap.id)
                        .Where(a2 => a2.emisor == _id || a2.receptor == _id)
                        .Where(a2 => a2.bandeja == false)
                        .FirstOrDefault();
                    aRetornar.Add(ap2);

                }
                return aRetornar;
            }
        }
        public Mensaje Lee(int _id)
        {
            Mensaje ap = null;
            using (var napaMailDB = new CorreoDB())
            {
                ap = napaMailDB.Mensajes
                    .Include(a => a.eUsuario)
                    .Include(a => a.rUsuario)
                    .Where(a2 => a2.id == _id)
                    .FirstOrDefault();

                ap = napaMailDB.Mensajes.Find(_id);
            }
            return ap;
        }

        public Mensaje Escribe(Mensaje _c)
        {
            using (var napaMailBD = new CorreoDB())
            {
                Mensaje c = napaMailBD.Mensajes.Add(_c);
                napaMailBD.SaveChanges();
                return c;
            }
        }
        public bool Borrar(int _id)
        {
            using (var napaMailBD = new CorreoDB())
            {
                Mensaje c = napaMailBD.Mensajes.Find(_id);
                napaMailBD.Mensajes.Remove(c);
                napaMailBD.SaveChanges();
            }
            return true;
        }
        public Mensaje Modifica(Mensaje _c)
        {
            using (var napaMailBD = new CorreoDB())
            {
                _c = napaMailBD.Mensajes.Attach(_c);
                napaMailBD.Entry(_c).State = System.Data.Entity.EntityState.Modified;
                napaMailBD.SaveChanges();
            }
            return _c;
        }
    }
}