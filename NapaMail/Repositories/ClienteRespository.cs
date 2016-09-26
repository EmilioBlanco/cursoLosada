using c11eindividual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using c11eindividual.BD;
using System.Data.SqlClient;

namespace c11eindividual.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public ClienteRepository() { }

        public List<Cliente> Lista()
        {
            using (var ApuestasDB = new ApuestasDB())
            {
                return ApuestasDB.listClientes.ToList<Cliente>();
            }
        }

        public Cliente Lee(int _id)
        {
            using (var ApuestasDB = new ApuestasDB())
            {
                try
                {
                    return ApuestasDB.listClientes.Find(_id);
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Error al encontrar el cliente. ES NULL");
                    return new Cliente();                    
                }
            }
        }

        public Cliente Escribe (Cliente _c)
        {
            using (var ApuestasDB = new ApuestasDB())
            {
                Cliente c = ApuestasDB.listClientes.Add(_c);
                ApuestasDB.SaveChanges();
                return c;
            }
        }
        public bool Borrar (int _id)
        {
            using (var ApuestasDB = new ApuestasDB())
            {
                

                Cliente c = ApuestasDB.listClientes.Find(_id);
                if (checkFgnKey(c))
                {
                    return false;
                }else
                {
                    ApuestasDB.listClientes.Remove(c);
                    ApuestasDB.SaveChanges();
                    return true;
                }
                
            }
        }
        public Cliente Modifica (Cliente _c)
        {
            using (var ApuestasDB = new ApuestasDB())
            {
                _c = ApuestasDB.listClientes.Attach(_c);
                ApuestasDB.Entry(_c).State = System.Data.Entity.EntityState.Modified;
                ApuestasDB.SaveChanges();
            }
            return _c;
        }

        private bool checkFgnKey(Cliente _c)
        {
            string query = "SELECT id FROM [DBO].[APUESTAS] WHERE UsrID = @id";
            int res = -1;
            using (ApuestasDB apuestasDB = new ApuestasDB())
            {
                SqlParameter param = new SqlParameter("@id", _c.id);
                res = apuestasDB.Database.SqlQuery<int>(query,param).FirstOrDefault();
            }
            if (res > 0)
                return true;
            return false;
        }
    }
}