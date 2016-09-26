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
    public class ApuestaRepository : IApuestaRepository
    {
        public ApuestaRepository() { }

        public List<Apuesta> Lista()
        {
            using (var ApuestasDB = new ApuestasDB())
            {
                List<Apuesta> aRetornar = new List<Apuesta>();
                //Thread.Sleep(500);
                foreach(Apuesta ap in ApuestasDB.listApuestas)
                {
                    Apuesta ap2 = ApuestasDB.listApuestas
                        .Include(a => a.usuario)
                        .Where(a2 => a2.id == ap.id)
                        .FirstOrDefault();
                    aRetornar.Add(ap2);
               
                }
                return aRetornar;
            }
        }

        public Apuesta Lee(int _id)
        {
            Apuesta ap = null;
            using (var ApuestasDB = new ApuestasDB())
            {
                ap = ApuestasDB.listApuestas
                    .Include(a => a.usuario)
                    .Where(a2 => a2.id == _id)
                    .FirstOrDefault();

                ap = ApuestasDB.listApuestas.Find(_id);
            }
            return ap;
        }

        public Apuesta Escribe(Apuesta _c)
        {
            using (var ApuestasDB = new ApuestasDB())
            {
                Apuesta c = ApuestasDB.listApuestas.Add(_c);
                ApuestasDB.SaveChanges();
                return c;
            }
        }
        public bool Borrar(int _id)
        {
            using (var ApuestasDB = new ApuestasDB())
            {
                Apuesta c = ApuestasDB.listApuestas.Find(_id);
                ApuestasDB.listApuestas.Remove(c);
                ApuestasDB.SaveChanges();
            }
            return true;
        }
        public Apuesta Modifica(Apuesta _c)
        {
            using (var ApuestasDB = new ApuestasDB())
            {
                _c = ApuestasDB.listApuestas.Attach(_c);
                ApuestasDB.Entry(_c).State = System.Data.Entity.EntityState.Modified;
                ApuestasDB.SaveChanges();
            }
            return _c;
        }
    }
}