using c11eindividual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using c11eindividual.BD;
using System.Data.SqlClient;

namespace c11eindividual.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public UsuarioRepository() { }

        public List<Usuario> Lista()
        {
            using (var napaMailDB = new CorreoDB())
            {
                return napaMailDB.Usuarios.ToList<Usuario>();
            }
        }

        
    }
}